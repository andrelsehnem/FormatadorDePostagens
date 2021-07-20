using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using FormatadorDePostagens.Classes;

namespace FormatadorDePostagens.Forms
{
    partial class frm_versaoFinal : Form
    {
        static Versoes versoesObject = new Versoes();
        private BancoInfos infoBd;
        public MySqlDataReader reader;

        //ESSAS TAGS SÃO PARA FORMATAÇÃO DA MENSAGEM
        private String tagInicio_negrito = "";
        private String tagFim_negrito = "";
        private Erros err = new Erros();


        public frm_versaoFinal(Versoes temp_versoesObj, BancoInfos temp_infoBd)
        {
            InitializeComponent();
            infoBd = temp_infoBd;
            versoesObject = temp_versoesObj;

            lbl_liberacao.Text = "Liberação da versão " + versoesObject.versao + " do " + versoesObject.sistema + ".";

            incluiTexto();
            verificaNTarefas();

        }

        private void frm_versaoFinal_Load(object sender, EventArgs e)
        {

        }

        private void incluiTexto()
        {
            if (versoesObject.versaoFinal) versaoFinal();
            else versaoRelease();
        }

        private void versaoFinal()
        {
            rch_hitoricoFinal.Text = "Olá! Versão final " + tagInicio_negrito + versoesObject.versao + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistema + tagFim_negrito + " disponível para atualizações. \n\n";
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
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Compatível com a versão " + tagInicio_negrito + versoesObject.versaoCompatibilidade + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistemaCompatibilidade + tagFim_negrito + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }



        }

        private void versaoRelease()
        {
            int codTarefa = 0;
            String desc = "";
            rch_hitoricoFinal.Text = "Olá! Versão " + tagInicio_negrito + versoesObject.versao + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistema + tagFim_negrito + " disponível para atualizações. \n\n";
            try
            {
                //aqui valda se tem bugs externos
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS RELATADAS POR CLIENTES' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                int numLinhas = reader.GetInt32(0);
                if (numLinhas > 0)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS RELATADAS POR CLIENTES' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + "INCONSISTÊNCIAS RELATADAS POR CLIENTES" + tagFim_negrito + "\n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + codTarefa + tagFim_negrito + " - " + desc + "\n";
                        reader.Read();
                    }
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\n";
                }

                //aqui valda se tem bugs internos
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                numLinhas = reader.GetInt32(0);
                if (numLinhas > 0)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + "INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE" + tagFim_negrito + "\n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + codTarefa + tagFim_negrito + " - " + desc + "\n";
                        reader.Read();
                    }
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\n";
                }

                //aqui valda se tem customizações
                infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.tipoTarefa = 'CUSTOMIZAÇÕES INCLUSAS' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao  in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                numLinhas = reader.GetInt32(0);
                if (numLinhas > 0)
                {
                    infoBd.ComandoSql("SELECT t.codTarefa, t.descricao FROM tarefas t WHERE t.tipoTarefa = 'CUSTOMIZAÇÕES INCLUSAS' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao in (" + versoesObject.versoesMensagem + ") ORDER BY t.codTarefa;");
                    infoBd.cnn.Open();
                    reader = infoBd.comandoProSql.ExecuteReader();
                    reader.Read();
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + "CUSTOMIZAÇÕES INCLUSAS" + tagFim_negrito + "\n";
                    for (int i = 0; i < numLinhas; i++)
                    {
                        codTarefa = reader.GetInt32(0);
                        desc = reader.GetString(1);
                        rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + codTarefa + tagFim_negrito + " - " + desc + "\n";
                        reader.Read();
                    }
                    rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "\n";
                }
            }
            catch (Exception e)
            {
                err.verifica(e, "frm_versaoFinal.versaoRelease");
            }

            //aqui fica o texto do rodapé da mensagem, onde vai validar a mensagem para compatibilidade
            if (versoesObject.naoCompativel)
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + tagInicio_negrito + "Não compatível" + tagFim_negrito + " com o " + tagInicio_negrito + versoesObject.sistemaCompatibilidade + tagFim_negrito + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
            else if (versoesObject.sistemaCompatibilidade == "Sem compatibilidade")
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Atenciosamente, " + versoesObject.colaborador + ".";
            }
            else
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Compatível com a versão " + tagInicio_negrito + versoesObject.versaoCompatibilidade + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistemaCompatibilidade + tagFim_negrito + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb_workplace_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_workplace.Checked)
            {
                tagInicio_negrito = "**";
                tagFim_negrito = "**";
                incluiTexto();
                verificaNTarefas();
            }
        }

        private void rb_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_normal.Checked)
            {
                tagInicio_negrito = "";
                tagFim_negrito = "";
                incluiTexto();
                verificaNTarefas();
            }

        }

        private void rb_forum_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_forum.Checked)
            {
                tagInicio_negrito = "[b]";
                tagFim_negrito = "[/b]";
                incluiTexto();
                verificaNTarefas();
            }
        }

        private void verificaNTarefas()
        {
            int quantidade = 0;
            infoBd.ComandoSql("SELECT count(t.codigo) FROM tarefas t WHERE t.sistema = '" + versoesObject.sistema + "' AND t.versao  in (" + versoesObject.versoesMensagem + ");");
            infoBd.cnn.Open();
            reader = infoBd.comandoProSql.ExecuteReader();
            reader.Read();
            quantidade = reader.GetInt32(0);
            lbl_NumTarefas.Text = quantidade + " Tarefas Para Liberação";
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            Forms.frm_editaTexto frm = new Forms.frm_editaTexto(versoesObject, infoBd);
            frm.Show();
        }
    }
}
