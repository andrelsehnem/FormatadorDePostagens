using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
     partial class frm_adicionaTexto : Form
    {
        public MySqlConnection cnn = new MySqlConnection();
        public MySqlCommand comandoProSql = new MySqlCommand();
        public MySqlDataReader reader;
        private String nomeArquivo = "tarefa.txt";
        static Versoes versoesObj = new Versoes();
        public BancoInfos infosBd = new BancoInfos();
        private String tipoTarefa;

        public frm_adicionaTexto(Versoes tmp_versoesObj, BancoInfos tmp_infosBd)
        {
            InitializeComponent();
            versoesObj = tmp_versoesObj;
            lbl_liberacao.Text = "Liberação da versão " + versoesObj.versao + " do " + versoesObj.sistema + ", compatível com o " + versoesObj.sistemaCompatibilidade + " (" + versoesObj.versaoCompatibilidade + ")";
            infosBd = tmp_infosBd;
            cnn = infosBd.cnn;
            comandoProSql.Connection = cnn;
            comandoProSql.CommandType = CommandType.Text;
            
            //cnn.ConnectionString = "server=" + infosBd.servidor + ";Port=" + infosBd.porta + ";uid=" + infosBd.user + ";pwd=" + infosBd.senha + ";SslMode=none";
            //cnn.Open();
            //comandoSql("use " + infosBd.banco);
        }

        private void frm_adicionaTexto_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void separaTexto2()  //nesse vou lendo linha por linha pra separar
        {   
            int nLinha = 1;
            int nTarefa;
            String detalheTarefa;
            String line;

            try
            {
                if (System.IO.File.Exists(nomeArquivo))
                {
                    
                    StreamReader sr = new StreamReader(nomeArquivo);
                    line = sr.ReadLine();

                    while (line != null) //buscar uma condição de loop melhor, acho que essa vai estar fraca
                    {
                        if (line == "INCONSISTÊNCIAS RELATADAS POR CLIENTES:")
                        {
                            tipoTarefa = "INCONSISTÊNCIAS RELATADAS POR CLIENTES";
                            line = sr.ReadLine(); //le a proxima linha
                        }
                        else if (line == "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE:")
                        {
                            tipoTarefa = "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE";
                            line = sr.ReadLine(); //le a proxima linha
                        }
                        
                        else if (line == "CUSTOMIZAÇÕES INCLUSAS:")
                        {
                            tipoTarefa = "CUSTOMIZAÇÕES INCLUSAS";
                            line = sr.ReadLine(); //le a proxima linha
                        }
                        else //caso não for uma definição do tipo de tarefa ele entra aqui para dai separa o numero do texto
                        {
                            //vai receber uma linha assim: 105919 - Ajustada inconsistência ao finalizar venda com desconto.
                            String codTarefa = "";
                            String descricaoT = "";
                            int i = line.IndexOf(" - ");
                            codTarefa = line.Substring(0, i);
                            descricaoT = line.Substring(i + 3);
                            comandoSql("SELECT * FROM tarefas WHERE tarefas.codTarefa = " + codTarefa + " AND tarefas.sistema = '" + versoesObj.sistema + "'");
                            cnn.Open();
                            reader = comandoProSql.ExecuteReader();
                            cnn.Close();
                            if (reader.HasRows)// busca se tem linha com where tarefas.codTarefa = codTarefa and tarefas.sistema = versoesObj.sistema
                            {
                                MessageBox.Show("A tarefa " + codTarefa + " já foi adicionada anteriormente ao banco.");
                            }
                            else
                            {
                                comandoSql("INSERT INTO tarefas (codTarefa, descricao, sistema, versao, compatibilidade, versaoCompat,pc, tipoTarefa) VALUES (" + Convert.ToInt32(codTarefa) + ",'" + descricaoT + "','" + versoesObj.sistema + "', '" + versoesObj.versao + "', '" + versoesObj.sistemaCompatibilidade + "', '" + versoesObj.versaoCompatibilidade + "','" + infosBd.pcName + "', '" + tipoTarefa + "')");
                            }
                            line = sr.ReadLine();
                        }
                    }
                    MessageBox.Show("Tarefas adicionadas com sucesso");
                    sr.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + nomeArquivo + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void jogaTxt()//nesse eu só to jogando pro arquivo .txt
        {
            try
            {
                if (System.IO.File.Exists(nomeArquivo))
                {
                    StreamWriter sw = new StreamWriter(nomeArquivo);
                    sw.WriteLine(rch_historico.Text);
                    sw.Close();
                }
                else
                {
                    MessageBox.Show("Arquivo ''" + nomeArquivo + "'' não encontrado na pasta, configurações de conexão não serão salvas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void comandoSql(String cmd)
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

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            //jogaTxt();
            separaTexto2();
            this.Close();
        }
    }
}
