
namespace FormatadorDePostagens.Forms
{
    partial class frm_versaoFinal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_versaoFinal));
            this.lbl_liberacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rch_hitoricoFinal = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_liberacao
            // 
            this.lbl_liberacao.AutoSize = true;
            this.lbl_liberacao.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_liberacao.Location = new System.Drawing.Point(12, 9);
            this.lbl_liberacao.Name = "lbl_liberacao";
            this.lbl_liberacao.Size = new System.Drawing.Size(111, 29);
            this.lbl_liberacao.TabIndex = 1;
            this.lbl_liberacao.Text = "Liberação do...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Histórico de Correções:";
            // 
            // rch_hitoricoFinal
            // 
            this.rch_hitoricoFinal.Location = new System.Drawing.Point(15, 61);
            this.rch_hitoricoFinal.Name = "rch_hitoricoFinal";
            this.rch_hitoricoFinal.ReadOnly = true;
            this.rch_hitoricoFinal.Size = new System.Drawing.Size(763, 297);
            this.rch_hitoricoFinal.TabIndex = 3;
            this.rch_hitoricoFinal.Text = "";
            // 
            // frm_versaoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.rch_hitoricoFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_liberacao);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_versaoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_versaoFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liberacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rch_hitoricoFinal;
    }
}