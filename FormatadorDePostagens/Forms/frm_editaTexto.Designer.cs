
namespace FormatadorDePostagens.Forms
{
    partial class frm_editaTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_editaTexto));
            this.lbl_codTarefa = new System.Windows.Forms.Label();
            this.msk_codTarefa = new System.Windows.Forms.MaskedTextBox();
            this.rch_descricaoTarefa = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_carregar = new System.Windows.Forms.Button();
            this.lbl_sistema = new System.Windows.Forms.Label();
            this.txt_sistema = new System.Windows.Forms.TextBox();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.txt_versao = new System.Windows.Forms.TextBox();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tipoTarefa = new System.Windows.Forms.Label();
            this.txt_tipoTarefa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_codTarefa
            // 
            this.lbl_codTarefa.AutoSize = true;
            this.lbl_codTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codTarefa.Location = new System.Drawing.Point(19, 13);
            this.lbl_codTarefa.Name = "lbl_codTarefa";
            this.lbl_codTarefa.Size = new System.Drawing.Size(85, 13);
            this.lbl_codTarefa.TabIndex = 0;
            this.lbl_codTarefa.Text = "Código da tarefa";
            // 
            // msk_codTarefa
            // 
            this.msk_codTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_codTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_codTarefa.Location = new System.Drawing.Point(19, 29);
            this.msk_codTarefa.Mask = "000000";
            this.msk_codTarefa.Name = "msk_codTarefa";
            this.msk_codTarefa.Size = new System.Drawing.Size(100, 20);
            this.msk_codTarefa.TabIndex = 1;
            this.msk_codTarefa.ValidatingType = typeof(int);
            // 
            // rch_descricaoTarefa
            // 
            this.rch_descricaoTarefa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rch_descricaoTarefa.Location = new System.Drawing.Point(19, 82);
            this.rch_descricaoTarefa.MaxLength = 200;
            this.rch_descricaoTarefa.Name = "rch_descricaoTarefa";
            this.rch_descricaoTarefa.Size = new System.Drawing.Size(250, 145);
            this.rch_descricaoTarefa.TabIndex = 3;
            this.rch_descricaoTarefa.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(19, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição da tarefa";
            // 
            // bt_carregar
            // 
            this.bt_carregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_carregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_carregar.Location = new System.Drawing.Point(179, 18);
            this.bt_carregar.Name = "bt_carregar";
            this.bt_carregar.Size = new System.Drawing.Size(90, 40);
            this.bt_carregar.TabIndex = 2;
            this.bt_carregar.Text = "Carregar";
            this.bt_carregar.UseVisualStyleBackColor = true;
            this.bt_carregar.Click += new System.EventHandler(this.bt_carregar_Click);
            // 
            // lbl_sistema
            // 
            this.lbl_sistema.AutoSize = true;
            this.lbl_sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_sistema.Location = new System.Drawing.Point(19, 291);
            this.lbl_sistema.Name = "lbl_sistema";
            this.lbl_sistema.Size = new System.Drawing.Size(44, 13);
            this.lbl_sistema.TabIndex = 4;
            this.lbl_sistema.Text = "Sistema";
            // 
            // txt_sistema
            // 
            this.txt_sistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_sistema.Location = new System.Drawing.Point(19, 307);
            this.txt_sistema.Name = "txt_sistema";
            this.txt_sistema.ReadOnly = true;
            this.txt_sistema.Size = new System.Drawing.Size(250, 20);
            this.txt_sistema.TabIndex = 4;
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_versao.Location = new System.Drawing.Point(19, 340);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(40, 13);
            this.lbl_versao.TabIndex = 6;
            this.lbl_versao.Text = "Versão";
            // 
            // txt_versao
            // 
            this.txt_versao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_versao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_versao.Location = new System.Drawing.Point(19, 356);
            this.txt_versao.Name = "txt_versao";
            this.txt_versao.ReadOnly = true;
            this.txt_versao.Size = new System.Drawing.Size(250, 20);
            this.txt_versao.TabIndex = 5;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_cancelar.Location = new System.Drawing.Point(179, 391);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(90, 40);
            this.bt_cancelar.TabIndex = 6;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_gravar.Location = new System.Drawing.Point(19, 391);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(90, 40);
            this.bt_gravar.TabIndex = 7;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(203, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 7);
            this.label3.TabIndex = 17;
            this.label3.Text = "Por André Luis Sehnem";
            // 
            // lbl_tipoTarefa
            // 
            this.lbl_tipoTarefa.AutoSize = true;
            this.lbl_tipoTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tipoTarefa.Location = new System.Drawing.Point(19, 243);
            this.lbl_tipoTarefa.Name = "lbl_tipoTarefa";
            this.lbl_tipoTarefa.Size = new System.Drawing.Size(73, 13);
            this.lbl_tipoTarefa.TabIndex = 18;
            this.lbl_tipoTarefa.Text = "Tipo da tarefa";
            // 
            // txt_tipoTarefa
            // 
            this.txt_tipoTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_tipoTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_tipoTarefa.Location = new System.Drawing.Point(19, 259);
            this.txt_tipoTarefa.Name = "txt_tipoTarefa";
            this.txt_tipoTarefa.ReadOnly = true;
            this.txt_tipoTarefa.Size = new System.Drawing.Size(250, 20);
            this.txt_tipoTarefa.TabIndex = 19;
            // 
            // frm_editaTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(288, 458);
            this.Controls.Add(this.txt_tipoTarefa);
            this.Controls.Add(this.lbl_tipoTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.txt_versao);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.txt_sistema);
            this.Controls.Add(this.lbl_sistema);
            this.Controls.Add(this.bt_carregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rch_descricaoTarefa);
            this.Controls.Add(this.msk_codTarefa);
            this.Controls.Add(this.lbl_codTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_editaTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_editaTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codTarefa;
        private System.Windows.Forms.MaskedTextBox msk_codTarefa;
        private System.Windows.Forms.RichTextBox rch_descricaoTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_carregar;
        private System.Windows.Forms.Label lbl_sistema;
        private System.Windows.Forms.TextBox txt_sistema;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.TextBox txt_versao;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tipoTarefa;
        private System.Windows.Forms.TextBox txt_tipoTarefa;
    }
}