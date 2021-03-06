
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
            this.label3 = new System.Windows.Forms.Label();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gbox_formatacao = new System.Windows.Forms.GroupBox();
            this.rb_forum = new System.Windows.Forms.RadioButton();
            this.rb_workplace = new System.Windows.Forms.RadioButton();
            this.rb_normal = new System.Windows.Forms.RadioButton();
            this.lbl_NumTarefas = new System.Windows.Forms.Label();
            this.bt_editar = new System.Windows.Forms.Button();
            this.gbox_formatacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_liberacao
            // 
            this.lbl_liberacao.AutoSize = true;
            this.lbl_liberacao.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_liberacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.rch_hitoricoFinal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rch_hitoricoFinal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rch_hitoricoFinal.Location = new System.Drawing.Point(15, 61);
            this.rch_hitoricoFinal.Name = "rch_hitoricoFinal";
            this.rch_hitoricoFinal.ReadOnly = true;
            this.rch_hitoricoFinal.Size = new System.Drawing.Size(763, 297);
            this.rch_hitoricoFinal.TabIndex = 3;
            this.rch_hitoricoFinal.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(708, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 7);
            this.label3.TabIndex = 17;
            this.label3.Text = "Por André Luis Sehnem";
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_cancelar.Location = new System.Drawing.Point(670, 365);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(108, 42);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Fechar";
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // gbox_formatacao
            // 
            this.gbox_formatacao.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbox_formatacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbox_formatacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gbox_formatacao.Controls.Add(this.rb_forum);
            this.gbox_formatacao.Controls.Add(this.rb_workplace);
            this.gbox_formatacao.Controls.Add(this.rb_normal);
            this.gbox_formatacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbox_formatacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbox_formatacao.Location = new System.Drawing.Point(518, 25);
            this.gbox_formatacao.Margin = new System.Windows.Forms.Padding(0);
            this.gbox_formatacao.Name = "gbox_formatacao";
            this.gbox_formatacao.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gbox_formatacao.Size = new System.Drawing.Size(257, 31);
            this.gbox_formatacao.TabIndex = 19;
            this.gbox_formatacao.TabStop = false;
            // 
            // rb_forum
            // 
            this.rb_forum.AutoSize = true;
            this.rb_forum.Location = new System.Drawing.Point(199, 9);
            this.rb_forum.Name = "rb_forum";
            this.rb_forum.Size = new System.Drawing.Size(54, 17);
            this.rb_forum.TabIndex = 2;
            this.rb_forum.Text = "Fórum";
            this.rb_forum.UseVisualStyleBackColor = true;
            this.rb_forum.CheckedChanged += new System.EventHandler(this.rb_forum_CheckedChanged);
            // 
            // rb_workplace
            // 
            this.rb_workplace.AutoSize = true;
            this.rb_workplace.Location = new System.Drawing.Point(117, 9);
            this.rb_workplace.Name = "rb_workplace";
            this.rb_workplace.Size = new System.Drawing.Size(77, 17);
            this.rb_workplace.TabIndex = 1;
            this.rb_workplace.Text = "Workplace";
            this.rb_workplace.UseVisualStyleBackColor = true;
            this.rb_workplace.CheckedChanged += new System.EventHandler(this.rb_workplace_CheckedChanged);
            // 
            // rb_normal
            // 
            this.rb_normal.AutoSize = true;
            this.rb_normal.Checked = true;
            this.rb_normal.Location = new System.Drawing.Point(6, 9);
            this.rb_normal.Name = "rb_normal";
            this.rb_normal.Size = new System.Drawing.Size(105, 17);
            this.rb_normal.TabIndex = 0;
            this.rb_normal.TabStop = true;
            this.rb_normal.Text = "Sem Formatação";
            this.rb_normal.UseVisualStyleBackColor = true;
            this.rb_normal.CheckedChanged += new System.EventHandler(this.rb_normal_CheckedChanged);
            // 
            // lbl_NumTarefas
            // 
            this.lbl_NumTarefas.AutoSize = true;
            this.lbl_NumTarefas.Location = new System.Drawing.Point(15, 365);
            this.lbl_NumTarefas.Name = "lbl_NumTarefas";
            this.lbl_NumTarefas.Size = new System.Drawing.Size(47, 13);
            this.lbl_NumTarefas.TabIndex = 20;
            this.lbl_NumTarefas.Text = "x tarefas";
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.bt_editar.Location = new System.Drawing.Point(556, 365);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(108, 42);
            this.bt_editar.TabIndex = 21;
            this.bt_editar.Text = "Editar Tarefas";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // frm_versaoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.lbl_NumTarefas);
            this.Controls.Add(this.gbox_formatacao);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rch_hitoricoFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_liberacao);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_versaoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formatador de Postagens";
            this.Load += new System.EventHandler(this.frm_versaoFinal_Load);
            this.gbox_formatacao.ResumeLayout(false);
            this.gbox_formatacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_liberacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rch_hitoricoFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.GroupBox gbox_formatacao;
        private System.Windows.Forms.RadioButton rb_forum;
        private System.Windows.Forms.RadioButton rb_workplace;
        private System.Windows.Forms.RadioButton rb_normal;
        private System.Windows.Forms.Label lbl_NumTarefas;
        private System.Windows.Forms.Button bt_editar;
    }
}