namespace savio_projeto3
{
    partial class Form3
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
            this.TxtAno = new System.Windows.Forms.TextBox();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAno
            // 
            this.TxtAno.Location = new System.Drawing.Point(12, 200);
            this.TxtAno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAno.Name = "TxtAno";
            this.TxtAno.Size = new System.Drawing.Size(141, 22);
            this.TxtAno.TabIndex = 23;
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(12, 148);
            this.TxtAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(220, 22);
            this.TxtAutor.TabIndex = 22;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(12, 97);
            this.TxtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(220, 22);
            this.TxtTitulo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Status";
            // 
            // ComboStatus
            // 
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Items.AddRange(new object[] {
            "Disponível",
            "Emprestado"});
            this.ComboStatus.Location = new System.Drawing.Point(15, 252);
            this.ComboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(138, 24);
            this.ComboStatus.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ano de Publicação";
            // 
            // txtAt
            // 
            this.txtAt.AutoSize = true;
            this.txtAt.BackColor = System.Drawing.Color.Transparent;
            this.txtAt.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.txtAt.Location = new System.Drawing.Point(12, 121);
            this.txtAt.Name = "txtAt";
            this.txtAt.Size = new System.Drawing.Size(66, 26);
            this.txtAt.TabIndex = 17;
            this.txtAt.Text = "Autor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Título";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(326, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 40);
            this.button1.TabIndex = 24;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSalvar);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAno);
            this.Controls.Add(this.TxtAutor);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAt);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAno;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtAt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}