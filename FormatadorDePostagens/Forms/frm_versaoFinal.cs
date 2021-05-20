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
            rch_hitoricoFinal.Text = "Olá! Versão " + versoesObject.versao + " do " + versoesObject.sistema + " disponível para atualizações. \n\n";
            
            //aqui valda se tem bugs externos 
            infoBd.ComandoSql("SELECT * FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS RELATADAS POR CLIENTES' AND t.sistema = '"+ versoesObject.sistema +"' AND t.versao = '"+ versoesObject.versao +"';");
            infoBd.cnn.Open();
            reader = infoBd.comandoProSql.ExecuteReader();
            if (reader.HasRows)
            {
                //se tiver insere o texto de bugs externos
                //aqui vai os bugs externos
            }

            //aqui valda se tem bugs internos
            infoBd.ComandoSql("SELECT * FROM tarefas t WHERE t.tipoTarefa = 'INCONSISTÊNCIAS ENCONTRADAS INTERNAMENTE' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "';");
            infoBd.cnn.Open();
            reader = infoBd.comandoProSql.ExecuteReader();
            if (reader.HasRows)
            {
                //se tiver insere o texto de bugs internos
                //aqui vai os bugs internos
            }

            //aqui valda se tem customizações
            infoBd.ComandoSql("SELECT * FROM tarefas t WHERE t.tipoTarefa = 'CUSTOMIZAÇÕES INCLUSAS' AND t.sistema = '" + versoesObject.sistema + "' AND t.versao = '" + versoesObject.versao + "';");
            infoBd.cnn.Open();
            reader = infoBd.comandoProSql.ExecuteReader();
            if (reader.HasRows)
            {
                //se tiver insere o texto de customizações
                //aqui vai as customizações
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
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Compatível com a versão " + versoesObject.versaoCompatibilidade + " do " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
            }
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
