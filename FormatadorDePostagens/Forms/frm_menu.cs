using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections;

namespace FormatadorDePostagens
{
    public partial class frm_menu : Form
    {
        public String usuario = "";
        BancoInfos infoBd = new BancoInfos();
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        private String nomeDoComputador;
        public String arquivoConfig = "Config.txt";
        private Boolean valido = false;

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
            infoBd.ComandoSql("CREATE TABLE if not exists tarefas (codigo int(4) not null AUTO_INCREMENT, codTarefa int(6) not null default 0, descricao varchar(200) not null default 'Não informado', sistema varchar(25) not null default 'N.A.', versao varchar(12) not null default 'N.A.', compatibilidade varchar(25) not null default 'N.A.', versaoCompat varchar(12) not null default 'N.A.',data datetime default null,pc varchar(30) null default null collate 'utf8_general_ci', usuario VARCHAR(50) NOT NULL DEFAULT 'Usuario', dataAlteracao datetime, usuarioAlteracao varchar(50), PRIMARY KEY(codigo));");
            //TRIGGER PARA INSERIR NO tarefas A DATA QUE FOI inserido
            infoBd.ComandoSql("CREATE TRIGGER if not exists dataInsert BEFORE INSERT ON tarefas FOR EACH ROW SET NEW.data = NOW()");
            //TRIGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem inseriu
            infoBd.ComandoSql("create trigger if not exists userInsert before insert on tarefas for each row set new.usuario = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO QUANDO HOUVER ALTERAÇÕES
            infoBd.ComandoSql("create trigger if not exists dataUpdate before update on tarefas for each row set new.dataAlteracao = NOW()");
            //TRIGGER DE LOG PARA INSERIR NA TABELA DE TAREFAS DA VERSAO quem alterou
            infoBd.ComandoSql("create trigger if not exists userUpdate before update on tarefas for each row set new.usuarioAlteracao = (SELECT usuario FROM log_login ORDER BY codigo DESC LIMIT 1)");
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
            catch
            {
                MessageBox.Show("Tabelas atualizadas!");
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
                MessageBox.Show(ex.ToString());
            }

            return reader.HasRows; //se existir retorna TRUE
        }

        private void getTxt()
        {
            String line;
            int cont = 1;
            try
            {
                if (System.IO.File.Exists(arquivoConfig))
                {
                    StreamReader sr = new StreamReader(arquivoConfig);
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        switch (cont)
                        {
                            case 1:
                                txt_banco.Text = line;
                                break;
                            case 2:
                                txt_nomeUsuario.Text = line;
                                break;
                            case 3:
                                txt_porta.Text = line;
                                break;
                            case 4:
                                txt_senha.Text = line;
                                break;
                            case 5:
                                txt_servidor.Text = line;
                                break;
                            case 6:
                                txt_user.Text = line;
                                break;
                        }
                        cont++;
                        line = sr.ReadLine();
                    }
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + arquivoConfig + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {

            }

        }

        private void setTxt()
        {
            try
            {
                if (System.IO.File.Exists(arquivoConfig))
                {
                    StreamWriter sw = new StreamWriter(arquivoConfig);
                    sw.WriteLine(infoBd.banco);
                    sw.WriteLine(infoBd.colaborador);
                    sw.WriteLine(infoBd.porta);
                    sw.WriteLine(infoBd.senha);
                    sw.WriteLine(infoBd.servidor);
                    sw.WriteLine(infoBd.user);
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + arquivoConfig + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {

            }
        }

        private void button1_Click(object sender, EventArgs e) //usado somente para testes
        {
            
            
        }
    }
}
