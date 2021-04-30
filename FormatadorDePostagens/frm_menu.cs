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

        
    }
}
