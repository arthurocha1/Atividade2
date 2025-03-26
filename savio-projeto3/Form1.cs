using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using savio_projeto3;

namespace Sávio_projeto3
{
  
    public partial class Form1 : Form
    {
        
        // Lista estática para armazenar os livros cadastrados
        public static List<Livro> livros = new List<Livro>();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; 
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtAno.Text = "";
            comboStatus.Text = "";
            txtTitulo.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
            var consultarForm = new consultaLivros();
            consultarForm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Coleta os dados do livro
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int ano = int.Parse(txtAno.Text);
            string status = comboStatus.Text;

            // Cria um novo objeto Livro
            Livro novoLivro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Ano = ano,
                Status = status
            };

            // Adiciona o livro à lista
            livros.Add(novoLivro);

            // Limpa os campos
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAno.Clear();
            comboStatus.SelectedIndex = -1; // Limpa o combo box

         
        }
    }
}
