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
     partial class frm_adicionaTexto : Form
    {
        static Versoes versoesObj = new Versoes();
        public frm_adicionaTexto(Versoes versoesObj)
        {
            InitializeComponent();
            lbl_liberacao.Text = "Liberação da versão " + versoesObj.versao + " do " + versoesObj.sistema + ", compatível com o " + versoesObj.sistemaCompatibilidade + " (" + versoesObj.versaoCompatibilidade + ")";
        }

        private void frm_adicionaTexto_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        
}
