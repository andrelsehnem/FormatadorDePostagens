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
        public String colaborador = "";

        public Boolean validado = false;

        private BancoInfos infoBd = new BancoInfos();
        private Versoes versaoObj = new Versoes();

        public frm_menu2(BancoInfos temp_bcInf)
        {
            InitializeComponent();
            colaborador = temp_bcInf.user;
        }
        
        private void frm_menu2_Load(object sender, EventArgs e)
        {
            validado = false;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {   
            this.Close();
            Application.Exit();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            validaVersoes();
            if (validado)
            {
                setVers();
                Forms.frm_adicionaTexto frmadd = new Forms.frm_adicionaTexto(versaoObj);
                frmadd.Show();
            }

        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            validaVersoes();
            setVers();
            if (validado)
            {
                Forms.frm_versaoFinal frmFinal = new Forms.frm_versaoFinal(versaoObj);
                frmFinal.Show();
            }
        }

        private void validaVersoes()
        {
            validado = false;
            if (msk_versao.Text == " .  .  ."){
                MessageBox.Show("Informe o número da versão que vai ser liberada");
                return;
            }else{
                versao = msk_versao.Text;
                //pegar o radio button
            }
            if (msk_compVersao.Text == " .  .  ."){
                MessageBox.Show("Informe o número da versão de compatibilidade");
                return;
            }else{
                versaoCompatibilidade = msk_compVersao.Text;
                //pegar o radio button
            }
            versaoFinal = check_Final.Checked;
            validado = true;
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

        private void setVers()
        {
            versaoObj.sistema = validaSistema();
            versaoObj.sistemaCompatibilidade = validaCompativel();
            versaoObj.versao = versao;
            versaoObj.versaoCompatibilidade = versaoCompatibilidade;
            versaoObj.versaoFinal = versaoFinal;
            versaoObj.colaborador = colaborador;
        }     
    }
}
