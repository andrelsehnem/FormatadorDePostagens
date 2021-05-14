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
        private String nomeArquivo = "tarefa.txt";
        static Versoes versoesObj = new Versoes();
        public frm_adicionaTexto(Versoes versoesObj)
        {
            InitializeComponent();
            lbl_liberacao.Text = "Liberação da versão " + versoesObj.versao + " do " + versoesObj.sistema + ", compatível com o " + versoesObj.sistemaCompatibilidade + " (" + versoesObj.versaoCompatibilidade + ")";
        }

        private void frm_adicionaTexto_Load(object sender, EventArgs e)
        {
            jogaTxt();
            separaTexto2();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void separaTexto1()
        {
            /*
             * string original = txtTexto.Text;
            char[] delimitadores = new char[] { ' - ' };
            string[] strings = original.Split(delimitadores);
            foreach (string s in strings)
            {
                txtResultado.Text += "\t" + s;
            }
            
            */
        }

        private void separaTexto2()
        {   
            //nesse vou lendo linha por linha pra separar 
            int nLinha = 1;
            int nTarefa;
            String detalheTarefa;
            String tipoTarefa;
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
                        rch_historico.
                        else if (line == "CUSTOMIZAÇÕES INCLUSAS:")
                        {
                            tipoTarefa = "CUSTOMIZAÇÕES INCLUSAS";
                            line = sr.ReadLine(); //le a proxima linha
                        }
                        else //caso não for uma definição do tipo de tarefa ele entra aqui para dai separa o numero do texto
                        {
                            //vai receber uma linha assim: 105919 - Ajustada inconsistência ao finalizar venda com desconto.

                            int i = line.IndexOf(" - ");

                            /*
                                    int i = textBox1.Text.IndexOf('-');
                                    if (i == -1)
                                    {
                                        MessageBox.Show("Etiqueta 1");
                                    }
                                    else
                                        {
                                            MessageBox.Show("Etiqueta 2");
                                        }
                                        char separa = '-';
                                        string[] etiqueta = textBox1.Text.Split(separa);
                                        foreach (string etq in etiqueta)
                                        {
                                            MessageBox.Show(etq);
                                        }*/

                        }
                    }

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

        private void jogaTxt()
        {
            
            //nesse eu só to jogando pro txt
            String line;
            
            try
            {
                if (System.IO.File.Exists(nomeArquivo))
                {
                    StreamReader sr = new StreamReader(nomeArquivo);
                    line = sr.ReadLine();
                    
                    
                      



                    line = sr.ReadLine(); //le a proxima linha
                    

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

        

        /*private void setTxt()
        {
            try
            {
                if (System.IO.File.Exists(nomeArquivo))
                {
                    StreamWriter sw = new StreamWriter(nomeArquivo);
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
        }*/
                        }

                    }
