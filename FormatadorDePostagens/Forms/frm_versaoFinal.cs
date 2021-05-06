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
            rch_hitoricoFinal.Text = "Olá! Versão final " + versoesObject.versao + " do " + versoesObject.sistema + " disponível para atualizações. \n\nCompatível com a versão " + versoesObject.versaoCompatibilidade + " do " + versoesObject.sistemaCompatibilidade + ". \n\nAtenciosamente, " + versoesObject.colaborador + ".";
        }

        private void versaoRelease()
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
