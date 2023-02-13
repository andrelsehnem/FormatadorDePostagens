using FormatadorDePostagens.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormatadorDePostagens
{
    public partial class frm_menu : Form
    {
        public String usuario = "";
        private BancoInfos infoBd = new BancoInfos();
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        private String nomeDoComputador;
        public String arquivoConfig = "Config.txt";
        private Boolean valido = false;
        private IniFile ini = new IniFile("Configurações.ini");
        private Erros err = new Erros();

        public frm_menu()
        {
            InitializeComponent();
            getTxt();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            nomeDoComputador = Environment.MachineName;
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            cnn.Close();
            this.Close();
        }

        private void formClosing_main(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
            this.Visible = true;
            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão
            if (DialogResult.Yes != MessageBox.Show("Tem certeza que deseja fechar a janela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                //Cancelar o evento
                e.Cancel = true;
            }
        }

        private void bt_conectar_Click(object sender, EventArgs e)
        {
            setInfosBanco();
            infoBd.Execute();
            infoBd.ConectaBanco();
            infoBd.ComandoSql("use " + infoBd.banco);
            String comandoLogin = "insert into log_login (pc, usuario) VALUES('" + nomeDoComputador + "', '" + infoBd.colaborador + "')";
            infoBd.ComandoSql(comandoLogin);
            criaTabelas();
            abreMenu2();
            infoBd.cnn.Close();
        }

        private void bt_criarBD_Click(object sender, EventArgs e)
        {
            setInfosBanco();
            criaBD();
            if (valido) abreMenu2();
        }

        private void abreMenu2()
        {
            if (infoBd.conectado)
            {
                alteraTabelas();
                setTxt();
                frm_menu2 frmmenu2 = new frm_menu2(infoBd);
                frmmenu2.Show();
                this.Visible = false;
            }
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
            infoBd.cnn = cnn;
            infoBd.comandoProSql = comandoProSql;
        }

        private void criaBD()
        {
            String cmd = "";
            infoBd.Execute();
            infoBd.ConectaBanco();
            try
            {
                cmd = "CREATE DATABASE IF NOT EXISTS " + infoBd.banco;
                infoBd.ComandoSql(cmd);
                infoBd.ComandoSql("use " + infoBd.banco);
                criaTabelas();
                valido = true;
            }
            catch
            {
                MessageBox.Show("Verifique a conexão SQL");
                return;
            }

            cmd = "insert into log_login (pc, usuario) VALUES('" + nomeDoComputador + "', '" + infoBd.colaborador + "')";
            infoBd.ComandoSql(cmd);
        }

        private void criaTabelas()
        {
            //TABELA DE LOG DO LOGIN NO APP
            infoBd.ComandoSql("CREATE TABLE if not exists log_login (codigo int(4) not null AUTO_INCREMENT, data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', PRIMARY KEY(codigo));");
            //TRIGGER PARA INSERIR NO LOG_LOGIN A DATA QUE FOI LOGADO
            infoBd.ComandoSql("CREATE TRIGGER if not exists dataLogin BEFORE INSERT ON log_login FOR EACH ROW SET NEW.data = NOW()");
            //TABELA DE TAREFAS DA VERSÃO
            infoBd.ComandoSql("CREATE TABLE if not exists tarefas (codigo int(4) not null AUTO_INCREMENT, codTarefa int(6) not null default 0, descricao varchar(300) not null default 'Não informado', sistema varchar(25) not null default 'N.A.', versao varchar(12) not null default 'N.A.', compatibilidade varchar(25) not null default 'N.A.', versaoCompat varchar(12) not null default 'N.A.',data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', dataAlteracao datetime, usuarioAlteracao varchar(50), PRIMARY KEY(codigo));");
            //TRIGGER PARA INSERIR NO tarefas A DATA QUE FOI inserido
            infoBd.ComandoSql("CREATE TRIGGER if not exists dataInsert BEFORE INSERT ON tarefas FOR EACH ROW SET NEW.data = NOW()");
            //TRIGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem inseriu
            infoBd.ComandoSql("create trigger if not exists userInsert before insert on tarefas for each row set new.usuario = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO QUANDO HOUVER ALTERAÇÕES
            infoBd.ComandoSql("create trigger if not exists dataUpdate before update on tarefas for each row set new.dataAlteracao = NOW()");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem alterou
            infoBd.ComandoSql("create trigger if not exists userUpdate before update on tarefas for each row set new.usuarioAlteracao = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");
            infoBd.ComandoSql("CREATE TABLE if NOT EXISTS compatibilidades (	`id` INT(11) NOT NULL AUTO_INCREMENT,	`versao_sistema` VARCHAR(50) NOT NULL DEFAULT '' COLLATE 'utf8_general_ci',	`sistema` VARCHAR(50) NOT NULL DEFAULT '' COLLATE 'utf8_general_ci',	`versao_compatibilidade` VARCHAR(50) NOT NULL DEFAULT '' COLLATE 'utf8_general_ci',	`sistema_compatibilidade` VARCHAR(50) NOT NULL DEFAULT '' COLLATE 'utf8_general_ci', `excluido` TINYINT(4) NULL DEFAULT '0',   PRIMARY KEY(`id`) USING BTREE)COLLATE = 'utf8_general_ci'ENGINE = InnoDB;            ");
        }

        private void alteraTabelas() //para cada alter table fazer o if com o valida tabela
        {
            try
            {
                if (!validaTabela("tarefas", "tipoTarefa"))
                {
                    reader.Close();
                    infoBd.ComandoSql("ALTER TABLE tarefas add tipoTarefa varchar(50) NOT NULL DEFAULT 'INCONSISTÊNCIAS RELATADAS POR CLIENTES';");
                }
            }
            catch (Exception EX)
            {
                err.verifica(EX, "frm_MENU.alteraTabelas     ");
            }
        }

        private Boolean validaTabela(String tabela, String coluna)
        {
            //essa função vai retornar se a coluna existe nesta tabela
            infoBd.ComandoSql("SELECT * FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + infoBd.banco + "' AND TABLE_NAME = '" + tabela + "' AND COLUMN_NAME = '" + coluna + "'");
            try
            {
                infoBd.cnn.Open();
                reader = comandoProSql.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                err.verifica(ex, "frm_MENU.validaTabela."+tabela+"."+coluna+ "    ") ;
            }

            return reader.HasRows; //se existir retorna TRUE
        }

        private void getTxt()
        {
            txt_banco.Text = ini.Read("Banco","Conexao");
            txt_nomeUsuario.Text = ini.Read("Colaborador"); ;
            txt_porta.Text = ini.Read("Porta", "Conexao"); ;
            txt_senha.Text = ini.Read("Senha", "Conexao"); ;
            txt_servidor.Text = ini.Read("Servidor", "Conexao"); ;
            txt_user.Text = ini.Read("User", "Conexao"); ;
        }

        private void setTxt()
        {
            ini.Write("Banco", infoBd.banco, "Conexao");
            ini.Write("Servidor", infoBd.servidor, "Conexao");
            ini.Write("Porta", infoBd.porta.ToString(), "Conexao");
            ini.Write("User", infoBd.user, "Conexao");
            ini.Write("Senha", infoBd.senha, "Conexao");
            ini.Write("Colaborador", infoBd.colaborador);
        }

        private void button1_Click(object sender, EventArgs e) //usado somente para testes
        {
        }
    }
}