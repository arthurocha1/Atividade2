using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using savio_projeto3;

namespace Sávio_projeto3
{
    public partial class consultaLivros : Form
    {
        public consultaLivros()
        {
            InitializeComponent();
        }

        private void consultaLivros_Load(object sender, EventArgs e)
        {
            // Vincula a lista de livros do Form1 ao DataGridView
            dataViw.DataSource = Form1.livros;
        }
    }
}