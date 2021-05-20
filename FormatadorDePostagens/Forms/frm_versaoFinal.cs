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
        public frm_versaoFinal(Versoes versoesObj)
        {
            InitializeComponent();

            versoesObject = versoesObj;

            lbl_liberacao.Text = "Liberação da versão " + versoesObj.versao + " do " + versoesObj.sistema + ", compatível com o " + versoesObj.sistemaCompatibilidade + " (" + versoesObj.versaoCompatibilidade + ")";
            
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
            //se tiver insere o texto de bugs externos
            //aqui vai os bugs externos

            //aqui valda se tem bugs internos
            //se tiver insere o texto de bugs internos
            //aqui vai os bugs internos

            //aqui valda se tem customizações
            //se tiver insere o texto de customizações
            //aqui vai as customizações

            if (versoesObject.naoCompativel)
            {
                rch_hitoricoFinal.Text = rch_hitoricoFinal.Text + "Não compatível com o " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
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
