using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
    public partial class frm_addTarefas : Form
    {
        public Versoes versaoObj = new Versoes();
        public BancoInfos infosBd = new BancoInfos();
        public MySqlDataReader reader;

        public frm_addTarefas(Versoes temp_versaoObj, BancoInfos temp_infoBd)
        {
            InitializeComponent();
            versaoObj = temp_versaoObj;
            infosBd = temp_infoBd;
            infosBd.Execute();
            txt_sistema.Text = versaoObj.sistema;
            txt_versao.Text = versaoObj.versao;
        }

        private void frm_addTarefas_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
            if (msk_codTarefa.Text == "")
            {
                MessageBox.Show("Informe o codigo da tarefa!");
                return;
            }
            if (combo_tarefa.Text == "")
            {
                MessageBox.Show("Informe o tipo da tarefa!");
                return;
            }
            if (rch_descricaoTarefa.Text == "")
            {
                MessageBox.Show("Informe a descrição da tarefa!");
                return;
            }
            adicionaTarefa();
        }

        private void adicionaTarefa()
        {
            String codTarefa = msk_codTarefa.Text;
            String descricaoT = rch_descricaoTarefa.Text;
            infosBd.ComandoSql("SELECT * FROM tarefas WHERE tarefas.codTarefa = " + Convert.ToInt32(codTarefa) + " AND tarefas.sistema = '" + versaoObj.sistema + "'");
            infosBd.cnn.Open();
            reader = infosBd.comandoProSql.ExecuteReader();

            if (reader.HasRows)// busca se tem linha com where tarefas.codTarefa = codTarefa and tarefas.sistema = versoesObj.sistema
            {
                infosBd.cnn.Close();
                MessageBox.Show("A tarefa " + codTarefa + " já foi adicionada anteriormente ao banco.");
            }
            else
            {
                infosBd.cnn.Close();
                descricaoT = versaoObj.palavraMaiuscula(descricaoT);
                String cmdSql = "INSERT INTO tarefas (codTarefa, descricao, sistema, versao, compatibilidade, versaoCompat,pc, tipoTarefa) VALUES (" + Convert.ToInt64(codTarefa) + ",'" + descricaoT + "','" + versaoObj.sistema + "', '" + versaoObj.versao + "', '" + versaoObj.sistemaCompatibilidade + "', '" + versaoObj.versaoCompatibilidade + "','" + infosBd.pcName + "', '" + combo_tarefa.Text + "')";
                infosBd.ComandoSql(cmdSql);
                MessageBox.Show("Tarefa " + codTarefa + " adicionada com sucesso!");

            }
        }

    }
}
