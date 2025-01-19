namespace SistemaLogin
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
            this.lbl_BoasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_BoasVindas
            // 
            this.lbl_BoasVindas.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_BoasVindas.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BoasVindas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BoasVindas.Location = new System.Drawing.Point(-1, 0);
            this.lbl_BoasVindas.Name = "lbl_BoasVindas";
            this.lbl_BoasVindas.Size = new System.Drawing.Size(960, 549);
            this.lbl_BoasVindas.TabIndex = 0;
            this.lbl_BoasVindas.Text = "Tela Inicial";
            this.lbl_BoasVindas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 547);
            this.Controls.Add(this.lbl_BoasVindas);
            this.MaximumSize = new System.Drawing.Size(973, 586);
            this.MinimumSize = new System.Drawing.Size(973, 586);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_BoasVindas;
    }
}

