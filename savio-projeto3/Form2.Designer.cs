namespace Sávio_projeto3
{
    partial class consultaLivros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataViw = new System.Windows.Forms.DataGridView();
            this.Combo2 = new System.Windows.Forms.ComboBox();
            this.TxtFiltroTitulo = new System.Windows.Forms.TextBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHistorico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataViw)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViw
            // 
            this.dataViw.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataViw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViw.Location = new System.Drawing.Point(13, 97);
            this.dataViw.Margin = new System.Windows.Forms.Padding(4);
            this.dataViw.Name = "dataViw";
            this.dataViw.RowHeadersWidth = 51;
            this.dataViw.Size = new System.Drawing.Size(786, 267);
            this.dataViw.TabIndex = 0;
            // 
            // Combo2
            // 
            this.Combo2.FormattingEnabled = true;
            this.Combo2.Items.AddRange(new object[] {
            "Todos",
            "Disponível",
            "Emprestado"});
            this.Combo2.Location = new System.Drawing.Point(314, 66);
            this.Combo2.Name = "Combo2";
            this.Combo2.Size = new System.Drawing.Size(235, 24);
            this.Combo2.TabIndex = 1;
            this.Combo2.SelectedIndexChanged += new System.EventHandler(this.Combo2_SelectedIndexChanged);
            // 
            // TxtFiltroTitulo
            // 
            this.TxtFiltroTitulo.Location = new System.Drawing.Point(13, 68);
            this.TxtFiltroTitulo.Name = "TxtFiltroTitulo";
            this.TxtFiltroTitulo.Size = new System.Drawing.Size(295, 22);
            this.TxtFiltroTitulo.TabIndex = 2;
            this.TxtFiltroTitulo.Click += new System.EventHandler(this.TxtFiltroTitulo_TextChanged);
            this.TxtFiltroTitulo.TextChanged += new System.EventHandler(this.TxtFiltroTitulo_TextChanged);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnVoltar.Location = new System.Drawing.Point(653, 436);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(146, 46);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click_1);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRemove.ForeColor = System.Drawing.Color.Red;
            this.BtnRemove.Location = new System.Drawing.Point(12, 436);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(146, 46);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remover";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnEditar.Location = new System.Drawing.Point(501, 436);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(146, 46);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnAlterar.FlatAppearance.BorderSize = 0;
            this.BtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlterar.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAlterar.Location = new System.Drawing.Point(349, 436);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(146, 46);
            this.BtnAlterar.TabIndex = 6;
            this.BtnAlterar.Text = "Alterar Status";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(320, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filtrar por Status";
            // 
            // BtnHistorico
            // 
            this.BtnHistorico.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnHistorico.FlatAppearance.BorderSize = 0;
            this.BtnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistorico.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnHistorico.Location = new System.Drawing.Point(681, 12);
            this.BtnHistorico.Name = "BtnHistorico";
            this.BtnHistorico.Size = new System.Drawing.Size(119, 41);
            this.BtnHistorico.TabIndex = 9;
            this.BtnHistorico.Text = "Histórico";
            this.BtnHistorico.UseVisualStyleBackColor = false;
            this.BtnHistorico.Click += new System.EventHandler(this.BtnHistorico_Click);
            // 
            // consultaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::savio_projeto3.Properties.Resources.livros_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 494);
            this.Controls.Add(this.BtnHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.TxtFiltroTitulo);
            this.Controls.Add(this.Combo2);
            this.Controls.Add(this.dataViw);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "consultaLivros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Livros";
            this.Load += new System.EventHandler(this.ConsultaLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViw;
        private System.Windows.Forms.ComboBox Combo2;
        private System.Windows.Forms.TextBox TxtFiltroTitulo;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnHistorico;
    }
}