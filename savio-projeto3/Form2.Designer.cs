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
            ((System.ComponentModel.ISupportInitialize)(this.dataViw)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViw
            // 
            this.dataViw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViw.Location = new System.Drawing.Point(12, 33);
            this.dataViw.Name = "dataViw";
            this.dataViw.Size = new System.Drawing.Size(454, 233);
            this.dataViw.TabIndex = 0;
            // 
            // consultaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataViw);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "consultaLivros";
            this.Text = "Consulta de Livros";
            this.Load += new System.EventHandler(this.consultaLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViw;
    }
}