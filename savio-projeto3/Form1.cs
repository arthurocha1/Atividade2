using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;
using savio_projeto3;

namespace Sávio_projeto3
{
    public partial class Form1 : Form
    {
        public SQLiteConnectionManager bdGerenciador;

        public Form1()
        {
            InitializeComponent();
            // Usando o caminho absoluto para o banco de dados
            string dbPath = @"C:\Users\LENOVO\Desktop\bytebook\bancodedados.db";
            bdGerenciador = new SQLiteConnectionManager(dbPath);
            bdGerenciador.CriarTabelaLivros();
            CarregarLivros();
        }

        public class SQLiteConnectionManager
        {
            private string connectionString;

            public SQLiteConnectionManager(string databasePath)
            {
                connectionString = $"Data Source={databasePath};Version=3;";  // Usando o caminho absoluto do banco
            }

            public SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }

            public void OpenConnection(SQLiteConnection connection)
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
            }

            public void CloseConnection(SQLiteConnection connection)
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            public void ExecuteNonQuery(string query)
            {
                using (var connection = GetConnection())
                {
                    OpenConnection(connection);
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    CloseConnection(connection);
                }
            }

            public SQLiteDataReader ExecuteQuery(string query)
            {
                var connection = GetConnection();
                OpenConnection(connection);

                var command = new SQLiteCommand(query, connection);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }

            // Método para criar a tabela Livros se não existir
            public void CriarTabelaLivros()
            {
                string query = @"
                    CREATE TABLE IF NOT EXISTS Livros (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titulo TEXT NOT NULL,
                        Autor TEXT NOT NULL,
                        Ano_Publicacao INTEGER NOT NULL,
                        Status TEXT NOT NULL
                    );";

                ExecuteNonQuery(query);
            }

            // Método para inserir um novo livro na tabela
            public void InserirLivro(Livro livro)
            {
                using (var connection = GetConnection())
                {
                    OpenConnection(connection);
                    using (var command = new SQLiteCommand("INSERT INTO Livros (Titulo, Autor, Ano_Publicacao, Status) VALUES (@Titulo, @Autor, @Ano_Publicacao, @Status)", connection))
                    {
                        command.Parameters.AddWithValue("@Titulo", livro.Titulo);
                        command.Parameters.AddWithValue("@Autor", livro.Autor);
                        command.Parameters.AddWithValue("@Ano_Publicacao", livro.Ano); // Usando a coluna Ano_Publicacao
                        command.Parameters.AddWithValue("@Status", livro.Status);
                        command.ExecuteNonQuery();
                    }
                    CloseConnection(connection);
                }
            }
        }

        // Função para carregar os livros
        public string CarregarLivros()
        {
            List<string> livrosCarregados = new List<string>();
            string query = "SELECT * FROM Livros";  // Selecionando todos os livros
            var leitor = bdGerenciador.ExecuteQuery(query);
            while (leitor.Read())
            {
                var livro = new Livro
                {
                    Titulo = leitor["Titulo"].ToString(),
                    Autor = leitor["Autor"].ToString(),
                    Ano = Convert.ToInt32(leitor["Ano_Publicacao"]),
                    Status = leitor["Status"].ToString()
                };
                livrosCarregados.Add($"Título: {livro.Titulo}, Autor: {livro.Autor}, Ano: {livro.Ano}, Status: {livro.Status}");
            }

            return livrosCarregados.Any() ? string.Join(Environment.NewLine, livrosCarregados) : "Nenhum livro cadastrado.";
        }

        public static List<Livro> livros = new List<Livro>();

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TxtTitulo.Focus();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            var consultarForm = new consultaLivros();
            consultarForm.ShowDialog();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitulo.Text) ||
                string.IsNullOrWhiteSpace(TxtAutor.Text) ||
                string.IsNullOrWhiteSpace(TxtAno.Text) ||
                string.IsNullOrWhiteSpace(ComboStatus.Text))
            {
                MessageBox.Show("Você deve preencher os campos acima.");
            }
            else
            {
                Livro novoLivro = new Livro
                {
                    Titulo = TxtTitulo.Text,
                    Autor = TxtAutor.Text,
                    Ano = int.Parse(TxtAno.Text),
                    Status = ComboStatus.Text
                };

                // Inserir livro na tabela Livros
                bdGerenciador.InserirLivro(novoLivro);

                LimparCampos();
                TxtTitulo.Focus();
            }
        }

        public void LimparCampos()
        {
            TxtTitulo.Clear();
            TxtAutor.Clear();
            TxtAno.Clear();
            ComboStatus.SelectedIndex = -1;
        }

        private void TxtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                ComboStatus.Focus();
            }
        }

        private void TxtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtAutor.Focus();
            }
        }

        private void TxtAutor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TxtAno.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtTitulo.Focus();
        }
    }
}
