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
                cnn.ConnectionString = "server=" + infoBd.servidor + ";uid=" + infoBd.user + ";pwd=" + infoBd.senha + ";SslMode=none";
                cnn.Open();
                //lbl_statusMenu.Text = "Conectado em " + cnn.Database;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Conexão não estabelecida, verifique as informações inseridas");
                return;
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
            conectaBd();
            comandoSql("use " + infoBd.banco);
            String comandoLogin = "insert into log_login (pc, usuario) VALUES('" + nomeDoComputador + "', '" + infoBd.colaborador + "')";
            comandoSql(comandoLogin);
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
            criaBD();

            frm_menu2 frmmenu2 = new frm_menu2(infoBd);
            frmmenu2.Show();

        }

        private void criaBD()
        {
            conectaBd();
            try
            {
                String cmd = "CREATE DATABASE IF NOT EXISTS " + infoBd.banco ;
                comandoSql(cmd);
                comandoSql("use " + infoBd.banco);
                criaTabelas();
            }
            catch
            {
                MessageBox.Show("Verifique a conexão SQL");
                return;
            }

            String comandoLogin = "insert into log_login (pc, usuario) VALUES('" + nomeDoComputador + "', '" + infoBd.colaborador +"')";
            comandoSql(comandoLogin);
        }

        public void comandoSql(String cmd)
        {
            MySqlCommand comandoProSql = new MySqlCommand();
            comandoProSql.Connection = cnn;
            comandoProSql.CommandType = CommandType.Text;
            comandoProSql.CommandText = cmd;

            try
            {
                comandoProSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void criaTabelas()
        {
            //TABELA DE LOG DO LOGIN NO APP
            comandoSql("CREATE TABLE if not exists log_login (codigo int(4) not null AUTO_INCREMENT, data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', PRIMARY KEY(codigo));");
            //TRIGGER PARA INSERIR NO LOG_LOGIN A DATA QUE FOI LOGADO
            comandoSql("CREATE TRIGGER if not exists dataLogin BEFORE INSERT ON log_login FOR EACH ROW SET NEW.data = NOW()");
            //TABELA DE TAREFAS DA VERSÃO
            comandoSql("CREATE TABLE if not exists tarefas (codigo int(4) not null AUTO_INCREMENT, codTarefa int(6) not null default 0, descricao varchar(200) not null default 'Não informado', sistema varchar(25) not null default 'N.A.', versao varchar(12) not null default 'N.A.', compatibilidade varchar(25) not null default 'N.A.', versaoCompat varchar(12) not null default 'N.A.',data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', dataAlteracao datetime, usuarioAlteracao varchar(50), PRIMARY KEY(codigo));");
            //TRIGGER PARA INSERIR NO tarefas A DATA QUE FOI inserido
            comandoSql("CREATE TRIGGER if not exists dataInsert BEFORE INSERT ON tarefas FOR EACH ROW SET NEW.data = NOW()");
            //TRIGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem inseriu
            comandoSql("create trigger if not exists userInsert before insert on tarefas for each row set new.usuario = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO QUANDO HOUVER ALTERAÇÕES
            comandoSql("create trigger if not exists dataUpdate before update on tarefas for each row set new.dataAlteracao = NOW()");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem alterou
            comandoSql("create trigger if not exists userUpdate before update on tarefas for each row set new.usuarioAlteracao = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");

        }
    }
}
