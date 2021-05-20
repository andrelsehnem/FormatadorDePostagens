using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatadorDePostagens
{
    public class BancoInfos
    {
        public string servidor = "localhost";
        public int porta = 3306;
        public string user = "root";
        public string senha = "admin";
        public string banco = "formatador";
        public string pcName = "";
        public string colaborador = "";
        public string comando = "";
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        public Boolean conectado = false;

        public void Execute()
        {
            comandoProSql.Connection = cnn;
            comandoProSql.CommandType = CommandType.Text;
        }
        public void ComandoSql(String cmd)
        {
            
            cnn.Open();
            comandoProSql.CommandText = cmd;
            try
            {
                comandoProSql.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ConectaBanco()
        {
            try
            {
                cnn.ConnectionString = "server=" + servidor + ";Port=" + porta + ";uid=" + user + ";pwd=" + senha + ";SslMode=none";
                cnn.Open();
                //lbl_statusMenu.Text = "Conectado em " + cnn.Database;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
                MessageBox.Show(ex.ToString());
                return;
            }
            conectado = true;
            cnn.Close();
        }

        
    }

    
}