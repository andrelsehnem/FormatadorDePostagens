using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
    partial class frm_versaoFinal : Form
    {
        static Versoes versoesObject = new Versoes();
        private BancoInfos infoBd;
        public MySqlDataReader reader;
        public frm_versaoFinal(Versoes temp_versoesObj, BancoInfos temp_infoBd)
        {
            InitializeComponent();
            infoBd = temp_infoBd;
            versoesObject = temp_versoesObj;

            lbl_liberacao.Text = "Liberação da versão " + versoesObject.versao + " do " + versoesObject.sistema + ", compatível com o " + versoesObject.sistemaCompatibilidade + " (" + versoesObject.versaoCompatibilidade + ")";
            
            if (versoesObject.versaoFinal) versaoFinal();
            else versaoRelease();
            
        }

        private void frm_versaoFinal_Load(object sender, EventArgs e)
        {
            
        }

        private void versaoFinal()
        {
            rch_hitoricoFinal.Text = "Olá! Versão final " + versoesObject.versao + " do " + versoesObject.sistema + " disponível para atualizações. \n\n";
            if (versoesObject.naoCompativel)
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Não compatível com o " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
            else if (versoesObject.sistemaCompatibilidade == "Sem compatibilidade")
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Atenciosamente, " + versoesObject.colaborador + ".";
            }
            else
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Compatível com a versão " + versoesObject.versaoCompatibilidade + " do " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
            

            
        }

        private void versaoRelease()
        {
            int codTarefa = 0;
            String desc = "";
            rch_hitoricoFinal.Text = "Olá! Versão " + versoesObject.versao + " do " + versoesObject.sistema + " disponível para atualizações. \n\n";
            try
            {
                //aqui valda se tem bugs externos
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS RELATADAS POR CLIENTES' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                int numLinhas = reader.GetInt32(0);
                if (reader.HasRows)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS RELATADAS POR CLIENTES' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "INCONSISTÊNCIAS RELATADAS POR CLIENTES \n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + codTarefa + " - " + desc + "\n";
                        reader.Read();
                    }
                }

                //aqui valda se tem bugs internos
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                numLinhas = reader.GetInt32(0);
                if (reader.HasRows)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\nINCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE \n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + codTarefa + " - " + desc + "\n";
                        reader.Read();
                    }
                }

                //aqui valda se tem bugs internos
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'CUSTOMIZAÇÕES INCLUSAS' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                numLinhas = reader.GetInt32(0);
                if (reader.HasRows)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'CUSTOMIZAÇÕES INCLUSAS' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "' ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\nCUSTOMIZAÇÕES INCLUSAS \n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + codTarefa + " - " + desc + "\n";
                        reader.Read();
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            //aqui fica o texto do rodapé da mensagem, onde vai validar a mensagem para compatibilidade
            if (versoesObject.naoCompativel)
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Não compatível com o " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
            else if (versoesObject.sistemaCompatibilidade == "Sem compatibilidade")
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Atenciosamente, " + versoesObject.colaborador + ".";
            }
            else
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\nCompatível com a versão " + versoesObject.versaoCompatibilidade + " do " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
