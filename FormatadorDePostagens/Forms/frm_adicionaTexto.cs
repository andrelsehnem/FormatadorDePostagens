﻿using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        private String cmdSql = "";
        private String tarefasAdicionadas = "";

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

                    while (line != null)
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
                                //descricaoT = palavraMaiuscula(descricaoT);
                                cmdSql = "INSERT INTO tarefas (codTarefa, descricao, sistema, versao, compatibilidade, versaoCompat,pc, tipoTarefa) VALUES (" + Convert.ToInt64(codTarefa) + ",'" + descricaoT + "','" + versoesObj.sistema + "', '" + versoesObj.versao + "', '" + versoesObj.sistemaCompatibilidade + "', '" + versoesObj.versaoCompatibilidade + "','" + infosBd.pcName + "', '" + tipoTarefa + "')";
                                infosBd.ComandoSql(cmdSql);
                                tarefasAdicionadas = tarefasAdicionadas + ", " + codTarefa;
                            }

                            line = sr.ReadLine();
                            contador = 0;
                        }
                    }
                    MessageBox.Show("Tarefas "+ tarefasAdicionadas + " adicionadas com sucesso!");
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

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            jogaTxt();
            separaTexto2();
            this.Close();
        }

        private String palavraMaiuscula(String texto)
        {
            return texto; //remover essa depois
            //faz 2 arrays, um certo e um errado
            //dai roda pra ver se ta no errado dai ve a mesma posição no certo pra substituir
            String[] palavrasErradas = new string[] { "nfe", "nf-e", "nfce", "nfc-e", "nfse", "nfs-e", "cte", "ct-e", "nf" };
            String[] palavrasCertas = new string[] { "NF-e", "NF-e", "NFC-e", "NFC-e", "NFS-e", "NFS-e", "CT-e", "CT-e", "NF" };
            String descricao = ""; //aqui vai ir juntando as palavras pra fazer o texto de volta;
            int i = texto.IndexOf(" ");
            int ult = 1;
            string palavra = "";
            while (i <= texto.Length)
            {
                if (ult == 1) palavra = texto.Substring(ult - 1, i - ult + 1);
                else palavra = texto.Substring(ult, i - ult);

                for (int cont = 0; cont < palavrasErradas.Length; cont++)
                {
                    if (palavra == palavrasErradas[cont])
                    {
                        palavra = palavrasCertas[cont];
                    }
                }
                if (i == texto.Length) descricao = palavra + ".";
                else descricao = palavra + " ";
                ult = i + 1;
                i = texto.IndexOf(" ", ult);
                if (i == -1) i = texto.Length;
            }


            return texto;
        }
    }
}

/*int i = 0;
 *i = texto.IndexOf(" ");
palavra = texto.Substring(0, i);
*/