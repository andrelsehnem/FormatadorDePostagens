using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer;
using MySql.Data.MySqlClient;

namespace FormatadorDePostagens
{
    public partial class frm_menu : Form
    {
        public String usuario = "";
        BancoInfos infoBd = new BancoInfos();
        public MySqlConnection cnn = new MySqlConnection();
        private String nomeDoComputador;

        public frm_menu()
        {
            InitializeComponent();
            //lbl_statusMenu.Text = "Banco não conectado";
        }

        public void conectaBd()
        {
            setInfosBanco();
            try
            {
                cnn.ConnectionString = "server=" + infoBd.servidor + ";database=" + infoBd.banco + ";uid=" + infoBd.user + ";pwd=" + infoBd.senha + ";SslMode=none";
                //cnn.Open();
                //lbl_statusMenu.Text = "Conectado em " + cnn.Database;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                

        private void formClosing_main(object sender, FormClosingEventArgs e)
        {
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão
            if (DialogResult.Yes != MessageBox.Show("Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Cancelar o evento
                e.Cancel = true;
            }
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            frm_menu2 frmmenu2 = new frm_menu2(infoBd);
            frmmenu2.Show();

            conectaBd();
            String comandoLogin = "insert into log_login (pc,appLanguage) VALUES('" + nomeDoComputador + "', 'C#')";
            //comandoSql();

        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            nomeDoComputador = Environment.MachineName;
        }

        private void setInfosBanco()
        {
            infoBd.servidor = txt_servidor.Text;
            infoBd.porta = Convert.ToInt32(txt_porta.Text);
            infoBd.user = txt_user.Text;
            infoBd.senha = txt_senha.Text;
            infoBd.banco = txt_banco.Text;
            infoBd.pcName = nomeDoComputador;
            infoBd.colaborador = txt_nomeUsuario.Text;
        }

        private void bt_criarBD_Click(object sender, EventArgs e)
        {
            setInfosBanco();


        }
    }
}
