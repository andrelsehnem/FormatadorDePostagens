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
        private Versoes versaoObj = new Versoes();

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

        private void validaVersoes()
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
            validaVersoes();
            if (validado)
            {
                getVers();
                //aqui coloca pra ir pro form de adicionar os textos passando o objeto de versoes
                
                
            }
           

        }

        private String validaSistema()
        {
            String sistema = "";

            if (rbt_mycommerce.Checked) sistema = rbt_mycommerce.Text;
            else if (rbt_mymilk.Checked) sistema = rbt_mymilk.Text;
            else if (rbt_pdv.Checked) sistema = rbt_pdv.Text;

            return sistema;
        }

        private String validaCompativel()
        {
            String sistema = "";

            if (rbt_compat_myc.Checked) sistema = rbt_compat_myc.Text;
            else if (rbt_compat_pdv.Checked) sistema = rbt_compat_pdv.Text;

            return sistema;
        }

        private void getVers()
        {
            versaoObj.sistema = validaSistema();
            versaoObj.sistemaCompatibilidade = validaCompativel();
            versaoObj.versao = versao;
            versaoObj.versaoCompatibilidade = versaoCompatibilidade;
            versaoObj.versaoFinal = versaoFinal;
        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            getVers();
        }
    }
}
