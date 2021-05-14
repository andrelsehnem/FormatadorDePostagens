
namespace FormatadorDePostagens.Forms
{
    partial class frm_adicionaTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_adicionaTexto));
            this.lbl_liberacao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rch_historico = new System.Windows.Forms.RichTextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_liberacao
            // 
            this.lbl_liberacao.AutoSize = true;
            this.lbl_liberacao.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_liberacao.Location = new System.Drawing.Point(12, 9);
            this.lbl_liberacao.Name = "lbl_liberacao";
            this.lbl_liberacao.Size = new System.Drawing.Size(111, 29);
            this.lbl_liberacao.TabIndex = 0;
            this.lbl_liberacao.Text = "Liberação do...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico de Correções:";
            // 
            // rch_historico
            // 
            this.rch_historico.Location = new System.Drawing.Point(16, 54);
            this.rch_historico.Name = "rch_historico";
            this.rch_historico.Size = new System.Drawing.Size(763, 297);
            this.rch_historico.TabIndex = 2;
            this.rch_historico.Text = "";
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(671, 363);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(108, 42);
            this.bt_adicionar.TabIndex = 3;
            this.bt_adicionar.Text = "Adicionar";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(547, 363);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(108, 42);
            this.bt_cancelar.TabIndex = 4;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(710, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 7);
            this.label2.TabIndex = 16;
            this.label2.Text = "Por André Luis Sehnem";
            // 
            // frm_adicionaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.rch_historico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_liberacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_adicionaTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_adicionaTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liberacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rch_historico;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label2;
    }
}