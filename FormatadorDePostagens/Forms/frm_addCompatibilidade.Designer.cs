
namespace FormatadorDePostagens.Forms
{
    partial class frm_addCompatibilidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addCompatibilidade));
            this.lbl_codTarefa = new System.Windows.Forms.Label();
            this.rch_textoCompatibilidades = new System.Windows.Forms.RichTextBox();
            this.lbl_descricaoTarefa = new System.Windows.Forms.Label();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_sistemasCompat = new System.Windows.Forms.ComboBox();
            this.msk_versaoCompat = new System.Windows.Forms.MaskedTextBox();
            this.txt_versaoSistema = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sistema = new System.Windows.Forms.TextBox();
            this.lbl_tipoTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_codTarefa
            // 
            this.lbl_codTarefa.AutoSize = true;
            this.lbl_codTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_codTarefa.Location = new System.Drawing.Point(19, 13);
            this.lbl_codTarefa.Name = "lbl_codTarefa";
            this.lbl_codTarefa.Size = new System.Drawing.Size(91, 13);
            this.lbl_codTarefa.TabIndex = 0;
            this.lbl_codTarefa.Text = "Código da Versão";
            // 
            // rch_textoCompatibilidades
            // 
            this.rch_textoCompatibilidades.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rch_textoCompatibilidades.Location = new System.Drawing.Point(22, 194);
            this.rch_textoCompatibilidades.MaxLength = 300;
            this.rch_textoCompatibilidades.Name = "rch_textoCompatibilidades";
            this.rch_textoCompatibilidades.Size = new System.Drawing.Size(247, 182);
            this.rch_textoCompatibilidades.TabIndex = 3;
            this.rch_textoCompatibilidades.Text = "";
            // 
            // lbl_descricaoTarefa
            // 
            this.lbl_descricaoTarefa.AutoSize = true;
            this.lbl_descricaoTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_descricaoTarefa.Location = new System.Drawing.Point(24, 174);
            this.lbl_descricaoTarefa.Name = "lbl_descricaoTarefa";
            this.lbl_descricaoTarefa.Size = new System.Drawing.Size(86, 13);
            this.lbl_descricaoTarefa.TabIndex = 3;
            this.lbl_descricaoTarefa.Text = "Compatibilidades";
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_versao.Location = new System.Drawing.Point(19, 112);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(40, 13);
            this.lbl_versao.TabIndex = 6;
            this.lbl_versao.Text = "Versão";
            // 
            // bt_fechar
            // 
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_fechar.Location = new System.Drawing.Point(179, 391);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(90, 40);
            this.bt_fechar.TabIndex = 6;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_gravar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_gravar.Location = new System.Drawing.Point(179, 121);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(90, 40);
            this.bt_gravar.TabIndex = 7;
            this.bt_gravar.Text = "Adicionar";
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
            // combo_sistemasCompat
            // 
            this.combo_sistemasCompat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.combo_sistemasCompat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.combo_sistemasCompat.FormattingEnabled = true;
            this.combo_sistemasCompat.Items.AddRange(new object[] {
            "INCONSISTÊNCIAS RELATADAS POR CLIENTES",
            "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE",
            "CUSTOMIZAÇÕES INCLUSAS"});
            this.combo_sistemasCompat.Location = new System.Drawing.Point(19, 81);
            this.combo_sistemasCompat.Name = "combo_sistemasCompat";
            this.combo_sistemasCompat.Size = new System.Drawing.Size(250, 21);
            this.combo_sistemasCompat.TabIndex = 19;
            // 
            // msk_versaoCompat
            // 
            this.msk_versaoCompat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_versaoCompat.BeepOnError = true;
            this.msk_versaoCompat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_versaoCompat.Location = new System.Drawing.Point(19, 132);
            this.msk_versaoCompat.Mask = "9,99,99,9999";
            this.msk_versaoCompat.Name = "msk_versaoCompat";
            this.msk_versaoCompat.Size = new System.Drawing.Size(93, 20);
            this.msk_versaoCompat.TabIndex = 20;
            // 
            // txt_versaoSistema
            // 
            this.txt_versaoSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_versaoSistema.BeepOnError = true;
            this.txt_versaoSistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_versaoSistema.Location = new System.Drawing.Point(19, 32);
            this.txt_versaoSistema.Mask = "9,99,99,9999";
            this.txt_versaoSistema.Name = "txt_versaoSistema";
            this.txt_versaoSistema.ReadOnly = true;
            this.txt_versaoSistema.Size = new System.Drawing.Size(100, 20);
            this.txt_versaoSistema.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(131, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sistema";
            // 
            // txt_sistema
            // 
            this.txt_sistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txt_sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_sistema.Location = new System.Drawing.Point(134, 32);
            this.txt_sistema.Name = "txt_sistema";
            this.txt_sistema.ReadOnly = true;
            this.txt_sistema.Size = new System.Drawing.Size(135, 20);
            this.txt_sistema.TabIndex = 23;
            // 
            // lbl_tipoTarefa
            // 
            this.lbl_tipoTarefa.AutoSize = true;
            this.lbl_tipoTarefa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_tipoTarefa.Location = new System.Drawing.Point(19, 63);
            this.lbl_tipoTarefa.Name = "lbl_tipoTarefa";
            this.lbl_tipoTarefa.Size = new System.Drawing.Size(121, 13);
            this.lbl_tipoTarefa.TabIndex = 18;
            this.lbl_tipoTarefa.Text = "Sistema Compatibilidade";
            // 
            // frm_addCompatibilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(288, 458);
            this.Controls.Add(this.txt_sistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_versaoSistema);
            this.Controls.Add(this.msk_versaoCompat);
            this.Controls.Add(this.combo_sistemasCompat);
            this.Controls.Add(this.lbl_tipoTarefa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_gravar);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.lbl_versao);
            this.Controls.Add(this.lbl_descricaoTarefa);
            this.Controls.Add(this.rch_textoCompatibilidades);
            this.Controls.Add(this.lbl_codTarefa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_addCompatibilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_addCompatibilidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codTarefa;
        private System.Windows.Forms.RichTextBox rch_textoCompatibilidades;
        private System.Windows.Forms.Label lbl_descricaoTarefa;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_sistemasCompat;
        private System.Windows.Forms.MaskedTextBox msk_versaoCompat;
        private System.Windows.Forms.MaskedTextBox txt_versaoSistema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sistema;
        private System.Windows.Forms.Label lbl_tipoTarefa;
    }
}