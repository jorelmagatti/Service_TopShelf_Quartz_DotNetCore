
namespace Alerta
{
    partial class AlertaForm
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
            this.lblTituloAlerta = new System.Windows.Forms.Label();
            this.lblMensagemAlerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloAlerta
            // 
            this.lblTituloAlerta.AutoSize = true;
            this.lblTituloAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlerta.Location = new System.Drawing.Point(44, 20);
            this.lblTituloAlerta.Name = "lblTituloAlerta";
            this.lblTituloAlerta.Size = new System.Drawing.Size(176, 31);
            this.lblTituloAlerta.TabIndex = 0;
            this.lblTituloAlerta.Text = "Alerta Inicial";
            // 
            // lblMensagemAlerta
            // 
            this.lblMensagemAlerta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensagemAlerta.Location = new System.Drawing.Point(12, 78);
            this.lblMensagemAlerta.Name = "lblMensagemAlerta";
            this.lblMensagemAlerta.Size = new System.Drawing.Size(776, 148);
            this.lblMensagemAlerta.TabIndex = 1;
            this.lblMensagemAlerta.Text = "--";
            // 
            // AlertaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.lblMensagemAlerta);
            this.Controls.Add(this.lblTituloAlerta);
            this.Name = "AlertaForm";
            this.Text = "Alerta RPA ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAlerta;
        private System.Windows.Forms.Label lblMensagemAlerta;
    }
}

