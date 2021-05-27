using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
    public partial class frm_editaTexto : Form
    {

        public BancoInfos infoBd;
        public MySqlDataReader reader;
        public Versoes versaoObj = new Versoes();

        private int count1 = 0;
        private int count2 = 0;

        public frm_editaTexto(Versoes temp_vers, BancoInfos temp_banco)
        {
            InitializeComponent();
            infoBd = temp_banco;
            versaoObj = temp_vers;
            txt_sistema.Text = versaoObj.sistema;
            txt_versao.Text = versaoObj.versao;
            infoBd.Execute();
        }

        private void frm_editaTexto_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja alterar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                alteraTarefa();
            }
            else
            {

            }
        }

        private void alteraTarefa()
        {
            try
            {
                infoBd.ComandoSql("UPDATE tarefas  SET descricao = '" + rch_descricaoTarefa.Text + "' WHERE codTarefa =" + Convert.ToInt32(msk_codTarefa.Text));
                MessageBox.Show("Descrição da tarefa alterada!");
                //infoBd.cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bt_carregar_Click(object sender, EventArgs e)
        {
            try
            {
                infoBd.ComandoSql("SELECT t.codTarefa, t.descricao, t.tipotarefa FROM tarefas t WHERE t.codTarefa = " + Convert.ToInt32(msk_codTarefa.Text));
                infoBd.cnn.Open();
                reader = infoBd.comandoProSql.ExecuteReader();
                reader.Read();
                rch_descricaoTarefa.Text = reader.GetString(1);
                txt_tipoTarefa.Text = reader.GetString(2);
                reader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Tarefa não encontrada");
                //MessageBox.Show(ex.ToString());
            }

        }
    }
}
