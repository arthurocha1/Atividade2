namespace savio_projeto3
{
    partial class Historico
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
            this.TxtHistorico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtHistorico
            // 
            this.TxtHistorico.Location = new System.Drawing.Point(12, 12);
            this.TxtHistorico.Multiline = true;
            this.TxtHistorico.Name = "TxtHistorico";
            this.TxtHistorico.ReadOnly = true;
            this.TxtHistorico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtHistorico.Size = new System.Drawing.Size(776, 426);
            this.TxtHistorico.TabIndex = 0;
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtHistorico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Historico";
            this.ShowIcon = false;
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHistorico;
    }
}