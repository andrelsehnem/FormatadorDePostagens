
namespace FormatadorDePostagens
{
    partial class frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.txt_nomeUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_conectar = new System.Windows.Forms.Button();
            this.bt_criarBD = new System.Windows.Forms.Button();
            this.lbl_servidor = new System.Windows.Forms.Label();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.lbl_porta = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_servidor = new System.Windows.Forms.TextBox();
            this.txt_porta = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_nomeUsuario
            // 
            resources.ApplyResources(this.txt_nomeUsuario, "txt_nomeUsuario");
            this.txt_nomeUsuario.Name = "txt_nomeUsuario";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bt_conectar
            // 
            resources.ApplyResources(this.bt_conectar, "bt_conectar");
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.UseVisualStyleBackColor = true;
            this.bt_conectar.Click += new System.EventHandler(this.bt_conectar_Click);
            // 
            // bt_criarBD
            // 
            resources.ApplyResources(this.bt_criarBD, "bt_criarBD");
            this.bt_criarBD.Name = "bt_criarBD";
            this.bt_criarBD.UseVisualStyleBackColor = true;
            this.bt_criarBD.Click += new System.EventHandler(this.bt_criarBD_Click);
            // 
            // lbl_servidor
            // 
            resources.ApplyResources(this.lbl_servidor, "lbl_servidor");
            this.lbl_servidor.Name = "lbl_servidor";
            // 
            // lbl_banco
            // 
            resources.ApplyResources(this.lbl_banco, "lbl_banco");
            this.lbl_banco.Name = "lbl_banco";
            // 
            // lbl_porta
            // 
            resources.ApplyResources(this.lbl_porta, "lbl_porta");
            this.lbl_porta.Name = "lbl_porta";
            // 
            // lbl_user
            // 
            resources.ApplyResources(this.lbl_user, "lbl_user");
            this.lbl_user.Name = "lbl_user";
            // 
            // lbl_pass
            // 
            resources.ApplyResources(this.lbl_pass, "lbl_pass");
            this.lbl_pass.Name = "lbl_pass";
            // 
            // txt_servidor
            // 
            resources.ApplyResources(this.txt_servidor, "txt_servidor");
            this.txt_servidor.Name = "txt_servidor";
            // 
            // txt_porta
            // 
            resources.ApplyResources(this.txt_porta, "txt_porta");
            this.txt_porta.Name = "txt_porta";
            // 
            // txt_user
            // 
            resources.ApplyResources(this.txt_user, "txt_user");
            this.txt_user.Name = "txt_user";
            // 
            // txt_senha
            // 
            resources.ApplyResources(this.txt_senha, "txt_senha");
            this.txt_senha.Name = "txt_senha";
            // 
            // txt_banco
            // 
            resources.ApplyResources(this.txt_banco, "txt_banco");
            this.txt_banco.Name = "txt_banco";
            // 
            // bt_sair
            // 
            resources.ApplyResources(this.bt_sair, "bt_sair");
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.txt_banco);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_porta);
            this.Controls.Add(this.txt_servidor);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_porta);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.lbl_servidor);
            this.Controls.Add(this.bt_criarBD);
            this.Controls.Add(this.bt_conectar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frm_menu";
            this.Tag = "frmMenuLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing_main);
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_conectar;
        private System.Windows.Forms.Button bt_criarBD;
        private System.Windows.Forms.Label lbl_servidor;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.Label lbl_porta;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_servidor;
        private System.Windows.Forms.TextBox txt_porta;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

