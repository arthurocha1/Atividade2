using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using savio_projeto3;
using static Sávio_projeto3.Form1;

namespace Sávio_projeto3
{
    public partial class consultaLivros : Form
    {
        private List<Livro> Editalivros = new List<Livro>();
        private SQLiteConnectionManager bdGerenciador;

        public consultaLivros()
        {
            InitializeComponent();
            // Inicializando o gerenciador de banco de dados
            string dbPath = @"C:\Users\LENOVO\Desktop\bytebook\bancodedados.db";
            bdGerenciador = new SQLiteConnectionManager(dbPath);
            CarregarLivros();
        }

        // Carregar os livros a partir do banco de dados
        private void CarregarLivros()
        {
            Editalivros.Clear();
            string query = "SELECT * FROM Livros";
            var leitor = bdGerenciador.ExecuteQuery(query);
            while (leitor.Read())
            {
                Editalivros.Add(new Livro
                {
                    Id = Convert.ToInt32(leitor["Id"]),
                    Titulo = leitor["Titulo"].ToString(),
                    Autor = leitor["Autor"].ToString(),
                    Ano = Convert.ToInt32(leitor["Ano_Publicacao"]),
                    Status = leitor["Status"].ToString()
                });
            }

            // Atualizando o DataGridView
            dataViw.DataSource = null;
            dataViw.DataSource = Editalivros;
        }

        private void ConsultaLivros_Load(object sender, EventArgs e)
        {
            CarregarLivros(); // Carregar livros quando o formulário for carregado
        }

        private void Combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = sender as System.Windows.Forms.ComboBox;

            var filtro = item.Text == "Todos"
                ? Editalivros
                : Editalivros.Where(x => x.Status.Equals(item.Text, StringComparison.OrdinalIgnoreCase)).ToList();

            // Atualizar a DataGridView
            dataViw.DataSource = null;
            dataViw.DataSource = filtro;
        }

        private void TxtFiltroTitulo_TextChanged(object sender, EventArgs e)
        {
            string tituloBusca = TxtFiltroTitulo.Text.ToLower().Trim();
            var livrosFiltrados = Editalivros.Where(l => l.Titulo.ToLower().Trim().Contains(tituloBusca)).ToList();
            dataViw.DataSource = null;
            dataViw.DataSource = livrosFiltrados;
        }

        public void BtnRemove_Click_1(object sender, EventArgs e)
        {
            if (dataViw.SelectedRows.Count > 0)
            {
                Livro livroSelecionado = (Livro)dataViw.SelectedRows[0].DataBoundItem;
                string query = $"DELETE FROM Livros WHERE Id = {livroSelecionado.Id}";
                bdGerenciador.ExecuteNonQuery(query);

                // Carregar livros novamente após a remoção
                CarregarLivros();
            }
            else
            {
                MessageBox.Show("Selecione um livro para remover.");
            }
        }

        private void BtnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dataViw.SelectedRows.Count > 0)
            {
                int indice = dataViw.SelectedRows[0].Index;
                Livro livroSelecionado = Editalivros[indice];

                Form3 form3 = new Form3(livroSelecionado);
                if (form3.ShowDialog() == DialogResult.OK)
                {
                    // Atualizando os dados no banco de dados após edição
                    string query = $"UPDATE Livros SET " +
                                   $"Titulo = '{form3.EditaLivro.Titulo}', " +
                                   $"Autor = '{form3.EditaLivro.Autor}', " +
                                   $"Ano_Publicacao = {form3.EditaLivro.Ano}, " +
                                   $"Status = '{form3.EditaLivro.Status}' " +
                                   $"WHERE Id = {livroSelecionado.Id}";

                    bdGerenciador.ExecuteNonQuery(query);

                    // Atualizando o DataGridView após a edição
                    CarregarLivros();
                }
            }
            else
            {
                MessageBox.Show("Selecione um livro para editar.");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (dataViw.SelectedRows.Count > 0)
            {
                Livro livroSelecionado = (Livro)dataViw.SelectedRows[0].DataBoundItem;

                // Alterando o status do livro entre "Disponível" e "Emprestado"
                livroSelecionado.Status = livroSelecionado.Status == "Disponível" ? "Emprestado" : "Disponível";

                // Atualizando o banco de dados após alteração de status
                string query = $"UPDATE Livros SET Status = '{livroSelecionado.Status}' WHERE Id = {livroSelecionado.Id}";
                bdGerenciador.ExecuteNonQuery(query);

                // Atualizando a exibição no DataGridView
                CarregarLivros();
            }
            else
            {
                MessageBox.Show("Selecione um livro para alterar.");
            }
        }

        private void BtnHistorico_Click(object sender, EventArgs e)
        {
            var historico = new Historico();
            historico.ShowDialog();
        }
    }
}
