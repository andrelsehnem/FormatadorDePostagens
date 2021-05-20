using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
    partial class frm_adicionaTexto : Form
    {
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
            comandoProSql = infosBd.comandoProSql;
            infosBd.Execute();
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
            String line;
            int contador = 0;
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
                            contador = 0;
                        }
                        else if (line == "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE:")
                        {
                            tipoTarefa = "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE";
                            line = sr.ReadLine(); //le a proxima linha
                            contador = 0;
                        }

                        else if (line == "CUSTOMIZAÇÕES INCLUSAS:")
                        {
                            tipoTarefa = "CUSTOMIZAÇÕES INCLUSAS";
                            line = sr.ReadLine(); //le a proxima linha
                            contador = 0;
                        }
                        else if (contador == 2)
                        {
                            line = null;
                        }
                        else if (line == "")
                        {
                            contador = contador++;
                            line = sr.ReadLine();
                        }
                        else //caso não for uma definição do tipo de tarefa ele entra aqui para dai separa o numero do texto
                        {
                            //vai receber uma linha assim: 105919 - Ajustada inconsistência ao finalizar venda com desconto.
                            String codTarefa = "";
                            String descricaoT = "";
                            int i = line.IndexOf(" - ");
                            codTarefa = line.Substring(0, i);
                            descricaoT = line.Substring(i + 3);
                            infosBd.ComandoSql("SELECT * FROM tarefas WHERE tarefas.codTarefa = " + Convert.ToInt32(codTarefa) + " AND tarefas.sistema = '" + versoesObj.sistema + "'");
                            infosBd.cnn.Open();
                            reader = comandoProSql.ExecuteReader();

                            if (reader.HasRows)// busca se tem linha com where tarefas.codTarefa = codTarefa and tarefas.sistema = versoesObj.sistema
                            {
                                infosBd.cnn.Close();
                                MessageBox.Show("A tarefa " + codTarefa + " já foi adicionada anteriormente ao banco.");
                            }
                            else
                            {
                                infosBd.cnn.Close();
                                infosBd.ComandoSql("INSERT INTO tarefas (codTarefa, descricao, sistema, versao, compatibilidade, versaoCompat,pc, tipoTarefa) VALUES (" + Convert.ToInt32(codTarefa) + ",'" + descricaoT + "','" + versoesObj.sistema + "', '" + versoesObj.versao + "', '" + versoesObj.sistemaCompatibilidade + "', '" + versoesObj.versaoCompatibilidade + "','" + infosBd.pcName + "', '" + tipoTarefa + "')");
                            }

                            line = sr.ReadLine();
                            contador = 0;
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
            //vai ter que pegar um jeito de contar quantas linhas tem no richtext e fazer um loop com base nela dai inserir linha por linha
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

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            jogaTxt();
            separaTexto2();
            this.Close();
        }
    }
}
