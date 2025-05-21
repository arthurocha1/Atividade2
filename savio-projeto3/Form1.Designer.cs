namespace Sávio_projeto3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(65, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // txtAt
            // 
            this.txtAt.AutoSize = true;
            this.txtAt.BackColor = System.Drawing.Color.Transparent;
            this.txtAt.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.txtAt.ForeColor = System.Drawing.Color.SpringGreen;
            this.txtAt.Location = new System.Drawing.Point(65, 140);
            this.txtAt.Name = "txtAt";
            this.txtAt.Size = new System.Drawing.Size(98, 39);
            this.txtAt.TabIndex = 1;
            this.txtAt.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SpringGreen;
            this.label3.Location = new System.Drawing.Point(65, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano de Publicação";
            // 
            // ComboStatus
            // 
            this.ComboStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.ComboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.ComboStatus.Location = new System.Drawing.Point(72, 330);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(294, 24);
            this.ComboStatus.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SpringGreen;
            this.label4.Location = new System.Drawing.Point(65, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Status";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtTitulo.Location = new System.Drawing.Point(72, 116);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(294, 22);
            this.TxtTitulo.TabIndex = 0;
            this.TxtTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTitulo_KeyPress);
            // 
            // TxtAutor
            // 
            this.TxtAutor.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtAutor.Location = new System.Drawing.Point(72, 186);
            this.TxtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(294, 22);
            this.TxtAutor.TabIndex = 6;
            this.TxtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAutor_KeyPress);
            // 
            // TxtAno
            // 
            this.TxtAno.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtAno.Location = new System.Drawing.Point(72, 258);
            this.TxtAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(294, 22);
            this.TxtAno.TabIndex = 7;
            this.TxtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAno_KeyPress);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnCadastrar.FlatAppearance.BorderSize = 0;
            this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCadastrar.Location = new System.Drawing.Point(708, 465);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(146, 46);
            this.BtnCadastrar.TabIndex = 8;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLimpar.FlatAppearance.BorderSize = 0;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnLimpar.ImageKey = "(nenhum/a)";
            this.BtnLimpar.Location = new System.Drawing.Point(404, 465);
            this.BtnLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(146, 46);
            this.BtnLimpar.TabIndex = 9;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.UseWaitCursor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConsultar.Location = new System.Drawing.Point(556, 465);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(146, 46);
            this.BtnConsultar.TabIndex = 10;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::savio_projeto3.Properties.Resources.livros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(866, 522);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAt);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtAt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnConsultar;
    }
}

