using FormatadorDePostagens.Classes;
using FormatadorDePostagens.Forms;
using System;
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
        public Boolean naoCompativel = false;
        public string versoesAdicionais = "";
        private IniFile ini = new IniFile("Sistemas.ini");
        private int quantidadeComp = 0 ;
        private int quantidadeSis = 0;


        public Boolean validado = false;

        private BancoInfos infoBd = new BancoInfos();
        private Versoes versaoObj = new Versoes();

        public frm_menu2(BancoInfos temp_bcInf)
        {
            InitializeComponent();
            colaborador = temp_bcInf.colaborador;
            infoBd = temp_bcInf;
            quantidadeComp = Convert.ToInt32(ini.Read("Quantidade", "Compatibilidade"));
            quantidadeSis = Convert.ToInt32(ini.Read("Quantidade", "Sistemas"));
        }

        private void frm_menu2_Load(object sender, EventArgs e)
        {
            validado = false;
            addSistema();
            addComps();
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
                Forms.frm_adicionaTexto frmadd = new Forms.frm_adicionaTexto(versaoObj, infoBd);
                frmadd.Show();
            }

        }

        private void bt_visualizar_Click(object sender, EventArgs e)
        {
            validaVersoes();
            setVers();
            if (validado)
            {
                Forms.frm_versaoFinal frmFinal = new Forms.frm_versaoFinal(versaoObj, infoBd);
                frmFinal.Show();
            }
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
            }
            if (msk_compVersao.Text == " .  .  .")
            {
                MessageBox.Show("Informe o número da versão de compatibilidade");
                return;
            }
            else
            {
                versaoCompatibilidade = msk_compVersao.Text;
            }
            versaoFinal = check_Final.Checked;
            naoCompativel = check_naoCompativel.Checked;
            validado = true;
        }

        private String validaSistema()
        {
            return list_sistemas.SelectedItem.ToString();
        }

        private String validaCompativel()
        {
            return list_comp.SelectedItem.ToString();
        }

        private void setVers()
        {
            validaVersoes();
            versaoObj.sistema = validaSistema();
            versaoObj.sistemaCompatibilidade = validaCompativel();
            versaoObj.versao = versao;
            versaoObj.versaoCompatibilidade = versaoCompatibilidade;
            versaoObj.versaoFinal = versaoFinal;
            versaoObj.colaborador = colaborador;
            versaoObj.naoCompativel = naoCompativel;
            validaVersoesAdicionais();
            versaoObj.versoesMensagem = versoesAdicionais;
        }


        private void bt_editarCorrecoes_Click(object sender, EventArgs e)
        {
            setVers();
            Forms.frm_editaTexto frm = new Forms.frm_editaTexto(versaoObj, infoBd);
            frm.Show();

        }

        private void check_v1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_v1.Checked)
            {
                msk_v1.Enabled = true;
                check_v2.Enabled = true;

            }
            else
            {
                msk_v1.Enabled = false;
                msk_v2.Enabled = false;
                check_v2.Enabled = false;
                check_v2.Checked = false;
            }
        }

        private void gbox_versoesAdicionais_Enter(object sender, EventArgs e)
        {

        }

        private void check_v2_CheckedChanged(object sender, EventArgs e)
        {
            if (check_v2.Checked)
            {
                msk_v2.Enabled = true;
                check_v3.Enabled = true;
            }
            else
            {
                msk_v2.Enabled = false;
                msk_v3.Enabled = false;
                check_v3.Enabled = false;
                check_v3.Checked = false;
            }
        }

        private void check_v3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_v3.Checked)
            {
                msk_v3.Enabled = true;
                check_v4.Enabled = true;
            }
            else
            {
                msk_v3.Enabled = false;
                msk_v4.Enabled = false;
                check_v4.Enabled = false;
                check_v4.Checked = false;
            }
        }

        private void check_v4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_v4.Checked)
            {
                msk_v4.Enabled = true;
            }
            else
            {
                msk_v4.Enabled = false;
            }
        }

        private void validaVersoesAdicionais()
        {
            versoesAdicionais = "'" + versao + "'";
            if (check_v1.Checked)
            {
                if (msk_v1.Text == " .  .  .")
                {
                    MessageBox.Show("Informe uma versão correta!");
                    return;
                }
                else
                {
                    versoesAdicionais = versoesAdicionais + "," + "'" + msk_v1.Text + "'";
                }
            }

            if (check_v2.Checked)
            {
                if (msk_v2.Text == " .  .  .")
                {
                    MessageBox.Show("Informe uma versão correta!");
                    return;
                }
                else
                {
                    versoesAdicionais = versoesAdicionais + "," + "'" + msk_v2.Text + "'";
                }
            }

            if (check_v3.Checked)
            {
                if (msk_v3.Text == " .  .  .")
                {
                    MessageBox.Show("Informe uma versão correta!");
                    return;
                }
                else
                {
                    versoesAdicionais = versoesAdicionais + "," + "'" + msk_v3.Text + "'";
                }
            }

            if (check_v4.Checked)
            {
                if (msk_v4.Text == " .  .  .")
                {
                    MessageBox.Show("Informe uma versão correta!");
                    return;
                }
                else
                {
                    versoesAdicionais = versoesAdicionais + "," + "'" + msk_v4.Text + "'";
                }
            }
        }

        private void bt_adicionaTarefa_Click(object sender, EventArgs e)
        {
            validaVersoes();
            if (validado)
            {
                setVers();
                frm_addTarefas frmadd = new frm_addTarefas(versaoObj, infoBd);
                frmadd.Show();
            }
        }

        public void addComps()
        {
            int cont = 0;
            list_comp.Items.Clear();
            list_comp.BeginUpdate();
            while (cont < quantidadeComp)
            {
                list_comp.Items.Add(ini.Read("Nome" + cont,"Compatibilidade"));
                cont++;
            }
            list_comp.EndUpdate();
            list_comp.SetSelected(0,true);
        }

        public void addSistema()
        {
            int cont = 0;
            list_sistemas.Items.Clear();
            list_sistemas.BeginUpdate();
            while (cont < quantidadeSis)
            {
                list_sistemas.Items.Add(ini.Read("Nome" + cont, "Sistemas"));
                cont++;
            }
            list_sistemas.EndUpdate();
            list_sistemas.SetSelected(0, true);
        }

        private void list_comp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (list_comp.SelectedItem.ToString() == "Sem compatibilidade")
            {
                check_naoCompativel.Checked = false;
                check_naoCompativel.Enabled = false;
            }
            else
            {
                check_naoCompativel.Checked = false;
                check_naoCompativel.Enabled = true;
            }
        }
    }
}
