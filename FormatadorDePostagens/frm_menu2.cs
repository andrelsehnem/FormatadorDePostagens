using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatadorDePostagens
{
    public partial class frm_menu2 : Form
    {
        public String versao = "";
        public String versaoCompatibilidade = "";
        public Boolean versaoFinal = false;
        public String sistema = "";
        public String sistemaCompatibilidade = "";
        public Boolean validado = false;

        public frm_menu2()
        {
            InitializeComponent();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_menu2_Load(object sender, EventArgs e)
        {
            validado = false;
        }

        private void validaSistemas()
        {
            validado = false;
            if (msk_versao.Text == " .  .  .")
            {
                MessageBox.Show("Informe o número da versão que vai ser liberada");
                return;
            }
            else
            {
                versao = msk_versao.Text;
                //pegar o radio button
            }
            if (msk_compVersao.Text == " .  .  .")
            {
                MessageBox.Show("Informe o número da versão de compatibilidade");
                return;
            }
            else
            {
                versaoCompatibilidade = msk_compVersao.Text;
                //pegar o radio button
            }

            versaoFinal = check_Final.Checked;
            validado = true;
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Validação " + validado);
            validaSistemas();
            MessageBox.Show("Validação " + validado);

        }
    }
}
