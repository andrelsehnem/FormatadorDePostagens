
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
            this.rbt_mycommerce = new System.Windows.Forms.RadioButton();
            this.rbt_mymilk = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msk_versao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_compat_myc = new System.Windows.Forms.RadioButton();
            this.rnt_compat_pdv = new System.Windows.Forms.RadioButton();
            this.check_Final = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_compVersao = new System.Windows.Forms.MaskedTextBox();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.rbt_pdv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbt_mycommerce
            // 
            this.rbt_mycommerce.AutoSize = true;
            this.rbt_mycommerce.Checked = true;
            this.rbt_mycommerce.Location = new System.Drawing.Point(5, 19);
            this.rbt_mycommerce.Name = "rbt_mycommerce";
            this.rbt_mycommerce.Size = new System.Drawing.Size(89, 17);
            this.rbt_mycommerce.TabIndex = 1;
            this.rbt_mycommerce.TabStop = true;
            this.rbt_mycommerce.Text = "MyCommerce";
            this.rbt_mycommerce.UseVisualStyleBackColor = true;
            // 
            // rbt_mymilk
            // 
            this.rbt_mymilk.AutoSize = true;
            this.rbt_mymilk.Location = new System.Drawing.Point(5, 42);
            this.rbt_mymilk.Name = "rbt_mymilk";
            this.rbt_mymilk.Size = new System.Drawing.Size(58, 17);
            this.rbt_mymilk.TabIndex = 2;
            this.rbt_mymilk.Text = "MyMilk";
            this.rbt_mymilk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_pdv);
            this.groupBox1.Controls.Add(this.rbt_mymilk);
            this.groupBox1.Controls.Add(this.rbt_mycommerce);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema a ser liberado";
            // 
            // msk_versao
            // 
            this.msk_versao.BeepOnError = true;
            this.msk_versao.Location = new System.Drawing.Point(12, 32);
            this.msk_versao.Mask = "9,99,99,9999";
            this.msk_versao.Name = "msk_versao";
            this.msk_versao.Size = new System.Drawing.Size(106, 20);
            this.msk_versao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Versão";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_compat_myc);
            this.groupBox2.Controls.Add(this.rnt_compat_pdv);
            this.groupBox2.Location = new System.Drawing.Point(188, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 252);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compatibilidade";
            // 
            // rbt_compat_myc
            // 
            this.rbt_compat_myc.AutoSize = true;
            this.rbt_compat_myc.Location = new System.Drawing.Point(6, 42);
            this.rbt_compat_myc.Name = "rbt_compat_myc";
            this.rbt_compat_myc.Size = new System.Drawing.Size(89, 17);
            this.rbt_compat_myc.TabIndex = 1;
            this.rbt_compat_myc.TabStop = true;
            this.rbt_compat_myc.Text = "MyCommerce";
            this.rbt_compat_myc.UseVisualStyleBackColor = true;
            // 
            // rnt_compat_pdv
            // 
            this.rnt_compat_pdv.AutoSize = true;
            this.rnt_compat_pdv.Checked = true;
            this.rnt_compat_pdv.Location = new System.Drawing.Point(6, 19);
            this.rnt_compat_pdv.Name = "rnt_compat_pdv";
            this.rnt_compat_pdv.Size = new System.Drawing.Size(114, 17);
            this.rnt_compat_pdv.TabIndex = 0;
            this.rnt_compat_pdv.TabStop = true;
            this.rnt_compat_pdv.Text = "MyCommerce PDV";
            this.rnt_compat_pdv.UseVisualStyleBackColor = true;
            // 
            // check_Final
            // 
            this.check_Final.AutoSize = true;
            this.check_Final.Location = new System.Drawing.Point(124, 35);
            this.check_Final.Name = "check_Final";
            this.check_Final.Size = new System.Drawing.Size(48, 17);
            this.check_Final.TabIndex = 7;
            this.check_Final.Text = "Final";
            this.check_Final.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Versão";
            // 
            // msk_compVersao
            // 
            this.msk_compVersao.BeepOnError = true;
            this.msk_compVersao.Location = new System.Drawing.Point(188, 30);
            this.msk_compVersao.Mask = "9,99,99,9999";
            this.msk_compVersao.Name = "msk_compVersao";
            this.msk_compVersao.Size = new System.Drawing.Size(106, 20);
            this.msk_compVersao.TabIndex = 9;
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Location = new System.Drawing.Point(356, 92);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(109, 45);
            this.bt_adicionar.TabIndex = 10;
            this.bt_adicionar.Text = "Adicionar Correções";
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.Location = new System.Drawing.Point(356, 157);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(109, 45);
            this.bt_visualizar.TabIndex = 11;
            this.bt_visualizar.Text = "Visualizar Correções";
            this.bt_visualizar.UseVisualStyleBackColor = true;
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(356, 221);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(109, 45);
            this.bt_fechar.TabIndex = 12;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // rbt_pdv
            // 
            this.rbt_pdv.AutoSize = true;
            this.rbt_pdv.Location = new System.Drawing.Point(5, 65);
            this.rbt_pdv.Name = "rbt_pdv";
            this.rbt_pdv.Size = new System.Drawing.Size(114, 17);
            this.rbt_pdv.TabIndex = 3;
            this.rbt_pdv.TabStop = true;
            this.rbt_pdv.Text = "MyCommerce PDV";
            this.rbt_pdv.UseVisualStyleBackColor = true;
            // 
            // frm_menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 325);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_visualizar);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.msk_compVersao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.check_Final);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_versao);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_menu2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_menu2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_mycommerce;
        private System.Windows.Forms.RadioButton rbt_mymilk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox msk_versao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rnt_compat_pdv;
        private System.Windows.Forms.RadioButton rbt_compat_myc;
        private System.Windows.Forms.CheckBox check_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msk_compVersao;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.RadioButton rbt_pdv;
    }
}