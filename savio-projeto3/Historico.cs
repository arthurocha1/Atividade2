using Sávio_projeto3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace savio_projeto3
{

    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 != null)
            {
                TxtHistorico.Text = form1.CarregarLivros();
            }
        }
    }
}