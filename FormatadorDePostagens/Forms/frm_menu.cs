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
        public MySqlConnection cnn = new MySqlConnection();
        public String usuario = "";

        public frm_menu()
        {
            InitializeComponent();
            //lbl_statusMenu.Text = "Banco não conectado";
            var nomeDoComputador = Environment.MachineName;
            conectaBd();        
            String comandoLogin = "insert into log_login (pc,appLanguage) VALUES('" + nomeDoComputador + "', 'C#')";
            //comandoSql(comandoLogin);
            
        }

        
        public void conectaBd()
        {
            try
            {
                cnn.ConnectionString = "server=localhost;database=lojinha;uid=root;pwd=admin;SslMode=none";
                cnn.Open();
                //lbl_statusMenu.Text = "Conectado em " + cnn.Database;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            frm_menu2 frmmenu2 = new frm_menu2();
            frmmenu2.Show();
            
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
