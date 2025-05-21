using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace savio_projeto3
{
    public partial class Form3 : Form
    {
        public Livro EditaLivro { get; private set; }

        public Form3(Livro livro)
        {
            InitializeComponent();
            TxtTitulo.Text = livro.Titulo;
            TxtAutor.Text = livro.Autor;
            TxtAno.Text = livro.Ano.ToString();
        }

        private void BtnSalvar(object sender, EventArgs e)
        {
            EditaLivro = new Livro
            {
                Titulo = TxtTitulo.Text,
                Autor = TxtAutor.Text,
                Ano = int.Parse(TxtAno.Text),
                Status = ComboStatus.Text,
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}