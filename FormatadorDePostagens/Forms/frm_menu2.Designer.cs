
namespace FormatadorDePostagens
{
    partial class frm_menu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu2));
            this.msk_versao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_compatibilidade = new System.Windows.Forms.GroupBox();
            this.list_comp = new System.Windows.Forms.ListBox();
            this.check_Final = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_compVersao = new System.Windows.Forms.MaskedTextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_editarCorrecoes = new System.Windows.Forms.Button();
            this.check_naoCompativel = new System.Windows.Forms.CheckBox();
            this.gbox_versoesAdicionais = new System.Windows.Forms.GroupBox();
            this.check_v4 = new System.Windows.Forms.CheckBox();
            this.check_v3 = new System.Windows.Forms.CheckBox();
            this.check_v2 = new System.Windows.Forms.CheckBox();
            this.check_v1 = new System.Windows.Forms.CheckBox();
            this.msk_v4 = new System.Windows.Forms.MaskedTextBox();
            this.msk_v3 = new System.Windows.Forms.MaskedTextBox();
            this.msk_v2 = new System.Windows.Forms.MaskedTextBox();
            this.msk_v1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_adicionaTarefa = new System.Windows.Forms.Button();
            this.gbox_Sistema = new System.Windows.Forms.GroupBox();
            this.list_sistemas = new System.Windows.Forms.ListBox();
            this.gbox_compatibilidade.SuspendLayout();
            this.gbox_versoesAdicionais.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbox_Sistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // msk_versao
            // 
            this.msk_versao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_versao.BeepOnError = true;
            this.msk_versao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_versao.Location = new System.Drawing.Point(12, 32);
            this.msk_versao.Mask = "9,99,99,9999";
            this.msk_versao.Name = "msk_versao";
            this.msk_versao.Size = new System.Drawing.Size(106, 20);
            this.msk_versao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Versão";
            // 
            // gbox_compatibilidade
            // 
            this.gbox_compatibilidade.Controls.Add(this.list_comp);
            this.gbox_compatibilidade.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox_compatibilidade.Location = new System.Drawing.Point(188, 58);
            this.gbox_compatibilidade.Name = "gbox_compatibilidade";
            this.gbox_compatibilidade.Size = new System.Drawing.Size(153, 171);
            this.gbox_compatibilidade.TabIndex = 9;
            this.gbox_compatibilidade.TabStop = false;
            this.gbox_compatibilidade.Text = "Compatibilidade";
            // 
            // list_comp
            // 
            this.list_comp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.list_comp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_comp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.list_comp.FormattingEnabled = true;
            this.list_comp.Location = new System.Drawing.Point(7, 20);
            this.list_comp.Name = "list_comp";
            this.list_comp.Size = new System.Drawing.Size(140, 143);
            this.list_comp.TabIndex = 0;
            this.list_comp.SelectedValueChanged += new System.EventHandler(this.list_comp_SelectedValueChanged);
            // 
            // check_Final
            // 
            this.check_Final.AutoSize = true;
            this.check_Final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_Final.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check_Final.Location = new System.Drawing.Point(70, 15);
            this.check_Final.Name = "check_Final";
            this.check_Final.Size = new System.Drawing.Size(48, 17);
            this.check_Final.TabIndex = 2;
            this.check_Final.Text = "Final";
            this.check_Final.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(185, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Versão";
            // 
            // msk_compVersao
            // 
            this.msk_compVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_compVersao.BeepOnError = true;
            this.msk_compVersao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_compVersao.Location = new System.Drawing.Point(188, 32);
            this.msk_compVersao.Mask = "9,99,99,9999";
            this.msk_compVersao.Name = "msk_compVersao";
            this.msk_compVersao.Size = new System.Drawing.Size(106, 20);
            this.msk_compVersao.TabIndex = 3;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_adicionar.Location = new System.Drawing.Point(9, 63);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(109, 45);
            this.bt_adicionar.TabIndex = 12;
            this.bt_adicionar.Text = "Adicionar Texto Completo";
            this.bt_adicionar.UseVisualStyleBackColor = false;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_visualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_visualizar.Location = new System.Drawing.Point(9, 216);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(109, 45);
            this.bt_visualizar.TabIndex = 14;
            this.bt_visualizar.Text = "Visualizar Correções";
            this.bt_visualizar.UseVisualStyleBackColor = false;
            this.bt_visualizar.Click += new System.EventHandler(this.bt_visualizar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_fechar.Location = new System.Drawing.Point(9, 267);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(109, 45);
            this.bt_fechar.TabIndex = 15;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(43, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 7);
            this.label3.TabIndex = 16;
            this.label3.Text = "Por André Luis Sehnem";
            // 
            // bt_editarCorrecoes
            // 
            this.bt_editarCorrecoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_editarCorrecoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editarCorrecoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_editarCorrecoes.Location = new System.Drawing.Point(9, 165);
            this.bt_editarCorrecoes.Name = "bt_editarCorrecoes";
            this.bt_editarCorrecoes.Size = new System.Drawing.Size(109, 45);
            this.bt_editarCorrecoes.TabIndex = 13;
            this.bt_editarCorrecoes.Text = "Editar Correções";
            this.bt_editarCorrecoes.UseVisualStyleBackColor = false;
            this.bt_editarCorrecoes.Click += new System.EventHandler(this.bt_editarCorrecoes_Click);
            // 
            // check_naoCompativel
            // 
            this.check_naoCompativel.AutoSize = true;
            this.check_naoCompativel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_naoCompativel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.check_naoCompativel.Location = new System.Drawing.Point(241, 15);
            this.check_naoCompativel.Name = "check_naoCompativel";
            this.check_naoCompativel.Size = new System.Drawing.Size(100, 17);
            this.check_naoCompativel.TabIndex = 4;
            this.check_naoCompativel.Text = "Não compativel";
            this.check_naoCompativel.UseVisualStyleBackColor = false;
            // 
            // gbox_versoesAdicionais
            // 
            this.gbox_versoesAdicionais.Controls.Add(this.check_v4);
            this.gbox_versoesAdicionais.Controls.Add(this.check_v3);
            this.gbox_versoesAdicionais.Controls.Add(this.check_v2);
            this.gbox_versoesAdicionais.Controls.Add(this.check_v1);
            this.gbox_versoesAdicionais.Controls.Add(this.msk_v4);
            this.gbox_versoesAdicionais.Controls.Add(this.msk_v3);
            this.gbox_versoesAdicionais.Controls.Add(this.msk_v2);
            this.gbox_versoesAdicionais.Controls.Add(this.msk_v1);
            this.gbox_versoesAdicionais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox_versoesAdicionais.Location = new System.Drawing.Point(15, 235);
            this.gbox_versoesAdicionais.Name = "gbox_versoesAdicionais";
            this.gbox_versoesAdicionais.Size = new System.Drawing.Size(326, 77);
            this.gbox_versoesAdicionais.TabIndex = 17;
            this.gbox_versoesAdicionais.TabStop = false;
            this.gbox_versoesAdicionais.Text = "Mensagens de versões a serem liberadas junto";
            this.gbox_versoesAdicionais.Enter += new System.EventHandler(this.gbox_versoesAdicionais_Enter);
            // 
            // check_v4
            // 
            this.check_v4.AutoSize = true;
            this.check_v4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_v4.Enabled = false;
            this.check_v4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.check_v4.Location = new System.Drawing.Point(179, 53);
            this.check_v4.Name = "check_v4";
            this.check_v4.Size = new System.Drawing.Size(15, 14);
            this.check_v4.TabIndex = 25;
            this.check_v4.UseVisualStyleBackColor = false;
            this.check_v4.CheckedChanged += new System.EventHandler(this.check_v4_CheckedChanged);
            // 
            // check_v3
            // 
            this.check_v3.AutoSize = true;
            this.check_v3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_v3.Enabled = false;
            this.check_v3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.check_v3.Location = new System.Drawing.Point(179, 27);
            this.check_v3.Name = "check_v3";
            this.check_v3.Size = new System.Drawing.Size(15, 14);
            this.check_v3.TabIndex = 24;
            this.check_v3.UseVisualStyleBackColor = false;
            this.check_v3.CheckedChanged += new System.EventHandler(this.check_v3_CheckedChanged);
            // 
            // check_v2
            // 
            this.check_v2.AutoSize = true;
            this.check_v2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_v2.Enabled = false;
            this.check_v2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.check_v2.Location = new System.Drawing.Point(6, 53);
            this.check_v2.Name = "check_v2";
            this.check_v2.Size = new System.Drawing.Size(15, 14);
            this.check_v2.TabIndex = 23;
            this.check_v2.UseVisualStyleBackColor = false;
            this.check_v2.CheckedChanged += new System.EventHandler(this.check_v2_CheckedChanged);
            // 
            // check_v1
            // 
            this.check_v1.AutoSize = true;
            this.check_v1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.check_v1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.check_v1.Location = new System.Drawing.Point(6, 27);
            this.check_v1.Name = "check_v1";
            this.check_v1.Size = new System.Drawing.Size(15, 14);
            this.check_v1.TabIndex = 22;
            this.check_v1.UseVisualStyleBackColor = false;
            this.check_v1.CheckedChanged += new System.EventHandler(this.check_v1_CheckedChanged);
            // 
            // msk_v4
            // 
            this.msk_v4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_v4.BeepOnError = true;
            this.msk_v4.Enabled = false;
            this.msk_v4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_v4.Location = new System.Drawing.Point(200, 50);
            this.msk_v4.Mask = "9,99,99,9999";
            this.msk_v4.Name = "msk_v4";
            this.msk_v4.Size = new System.Drawing.Size(106, 20);
            this.msk_v4.TabIndex = 21;
            // 
            // msk_v3
            // 
            this.msk_v3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_v3.BeepOnError = true;
            this.msk_v3.Enabled = false;
            this.msk_v3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_v3.Location = new System.Drawing.Point(200, 24);
            this.msk_v3.Mask = "9,99,99,9999";
            this.msk_v3.Name = "msk_v3";
            this.msk_v3.Size = new System.Drawing.Size(106, 20);
            this.msk_v3.TabIndex = 20;
            // 
            // msk_v2
            // 
            this.msk_v2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_v2.BeepOnError = true;
            this.msk_v2.Enabled = false;
            this.msk_v2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_v2.Location = new System.Drawing.Point(27, 50);
            this.msk_v2.Mask = "9,99,99,9999";
            this.msk_v2.Name = "msk_v2";
            this.msk_v2.Size = new System.Drawing.Size(106, 20);
            this.msk_v2.TabIndex = 19;
            // 
            // msk_v1
            // 
            this.msk_v1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.msk_v1.BeepOnError = true;
            this.msk_v1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msk_v1.Enabled = false;
            this.msk_v1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msk_v1.Location = new System.Drawing.Point(27, 24);
            this.msk_v1.Mask = "9,99,99,9999";
            this.msk_v1.Name = "msk_v1";
            this.msk_v1.Size = new System.Drawing.Size(106, 20);
            this.msk_v1.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.bt_adicionaTarefa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_editarCorrecoes);
            this.panel1.Controls.Add(this.bt_fechar);
            this.panel1.Controls.Add(this.bt_visualizar);
            this.panel1.Controls.Add(this.bt_adicionar);
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 325);
            this.panel1.TabIndex = 18;
            // 
            // bt_adicionaTarefa
            // 
            this.bt_adicionaTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.bt_adicionaTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionaTarefa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_adicionaTarefa.Location = new System.Drawing.Point(9, 114);
            this.bt_adicionaTarefa.Name = "bt_adicionaTarefa";
            this.bt_adicionaTarefa.Size = new System.Drawing.Size(109, 45);
            this.bt_adicionaTarefa.TabIndex = 17;
            this.bt_adicionaTarefa.Text = "Adicionar Tarefa Individual";
            this.bt_adicionaTarefa.UseVisualStyleBackColor = false;
            this.bt_adicionaTarefa.Click += new System.EventHandler(this.bt_adicionaTarefa_Click);
            // 
            // gbox_Sistema
            // 
            this.gbox_Sistema.Controls.Add(this.list_sistemas);
            this.gbox_Sistema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox_Sistema.Location = new System.Drawing.Point(12, 58);
            this.gbox_Sistema.Name = "gbox_Sistema";
            this.gbox_Sistema.Size = new System.Drawing.Size(160, 171);
            this.gbox_Sistema.TabIndex = 5;
            this.gbox_Sistema.TabStop = false;
            this.gbox_Sistema.Text = "Sistema a ser liberado";
            // 
            // list_sistemas
            // 
            this.list_sistemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.list_sistemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_sistemas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.list_sistemas.FormattingEnabled = true;
            this.list_sistemas.Location = new System.Drawing.Point(6, 22);
            this.list_sistemas.Name = "list_sistemas";
            this.list_sistemas.Size = new System.Drawing.Size(148, 143);
            this.list_sistemas.TabIndex = 1;
            // 
            // frm_menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(476, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbox_versoesAdicionais);
            this.Controls.Add(this.check_naoCompativel);
            this.Controls.Add(this.msk_compVersao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_Final);
            this.Controls.Add(this.gbox_compatibilidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_versao);
            this.Controls.Add(this.gbox_Sistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_menu2_Load);
            this.gbox_compatibilidade.ResumeLayout(false);
            this.gbox_versoesAdicionais.ResumeLayout(false);
            this.gbox_versoesAdicionais.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbox_Sistema.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox msk_versao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_compatibilidade;
        private System.Windows.Forms.CheckBox check_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_compVersao;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_editarCorrecoes;
        private System.Windows.Forms.CheckBox check_naoCompativel;
        private System.Windows.Forms.GroupBox gbox_versoesAdicionais;
        private System.Windows.Forms.CheckBox check_v4;
        private System.Windows.Forms.CheckBox check_v3;
        private System.Windows.Forms.CheckBox check_v2;
        private System.Windows.Forms.CheckBox check_v1;
        private System.Windows.Forms.MaskedTextBox msk_v4;
        private System.Windows.Forms.MaskedTextBox msk_v3;
        private System.Windows.Forms.MaskedTextBox msk_v2;
        private System.Windows.Forms.MaskedTextBox msk_v1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_adicionaTarefa;
        private System.Windows.Forms.ListBox list_comp;
        private System.Windows.Forms.GroupBox gbox_Sistema;
        private System.Windows.Forms.ListBox list_sistemas;
    }
}