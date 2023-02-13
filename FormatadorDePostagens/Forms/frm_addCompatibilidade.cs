using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace FormatadorDePostagens.Forms
{
    public partial class frm_addCompatibilidade : Form
    {
        public Versoes versaoObj = new Versoes();
        public BancoInfos infosBd = new BancoInfos();
        public MySqlDataReader reader;
        private string mensagemCompatibilidade = "";

        public frm_addCompatibilidade(Versoes temp_versaoObj, BancoInfos temp_infoBd)
        {
            InitializeComponent();
            versaoObj = temp_versaoObj;
            infosBd = temp_infoBd;
            infosBd.Execute();
            VerificaCompatibilidadeInicial();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificaCompatibilidadeInicial()
        {
            string sqlConsulta = $"SELECT * FROM compatibilidades WHERE versao_sistema = '{versaoObj.versao}' AND sistema = '{versaoObj.sistema}' AND versao_compatibilidade = '{versaoObj.versaoCompatibilidade}' AND sistema_compatibilidade = '{versaoObj.sistemaCompatibilidade}'";
            infosBd.ComandoSql(sqlConsulta);
            reader = infosBd.comandoProSql.ExecuteReader();
            if (reader.Read())
            {
                rch_textoCompatibilidades.Text = rch_textoCompatibilidades.Text + GeraTextoCompatibilidade();
            }
            else
            {
                infosBd.cnn.Close();
                sqlConsulta = $"insert into compatibilidades set versao_sistema = '{versaoObj.versao}', sistema = '{versaoObj.sistema}', versao_compatibilidade = '{versaoObj.versaoCompatibilidade}', sistema_compatibilidade = '{versaoObj.sistemaCompatibilidade}'";
                infosBd.ComandoSql(sqlConsulta);
            }
        }

        private string GeraTextoCompatibilidade()
        {
            mensagemCompatibilidade = "Compatível com a versão " + tagInicio_negrito + versoesObject.versaoCompatibilidade + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistemaCompatibilidade + tagFim_negrito;
            return "";
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {
           // if (msk_codTarefa.Text == "")
            //{
            //    MessageBox.Show("Informe o codigo da tarefa!");
           //     return;
          //  }
            if (combo_sistemasCompat.Text == "")
            {
                MessageBox.Show("Informe o tipo da tarefa!");
                return;
            }
            if (rch_textoCompatibilidades.Text == "")
            {
                MessageBox.Show("Informe a descrição da tarefa!");
                return;
            }
            adicionaTarefa();
        }

        private void adicionaTarefa()
        {
            String descricaoT = rch_textoCompatibilidades.Text;
           // infosBd.ComandoSql("SELECT * FROM tarefas WHERE tarefas.codTarefa = " + Convert.ToInt32(codTarefa) + " AND tarefas.sistema = '" + versaoObj.sistema + "'");
            infosBd.cnn.Open();
            reader = infosBd.comandoProSql.ExecuteReader();
            descricaoT = versaoObj.replaceChars(descricaoT);
            if (reader.HasRows)// busca se tem linha com where tarefas.codTarefa = codTarefa and tarefas.sistema = versoesObj.sistema
            {
                infosBd.cnn.Close();
                //MessageBox.Show("A tarefa " + codTarefa + " já foi adicionada anteriormente ao banco.");
            }
            else
            {
                infosBd.cnn.Close();
                //descricaoT = versaoObj.palavraMaiuscula(descricaoT);
                descricaoT = versaoObj.replacePalavras(descricaoT);
                //String cmdSql = "INSERT INTO tarefas (codTarefa, descricao, sistema, versao, compatibilidade, versaoCompat,pc, tipoTarefa) VALUES (" + Convert.ToInt64(codTarefa) + ",'" + descricaoT + "','" + versaoObj.sistema + "', '" + versaoObj.versao + "', '" + versaoObj.sistemaCompatibilidade + "', '" + versaoObj.versaoCompatibilidade + "','" + infosBd.pcName + "', '" + combo_tarefa.Text + "')";
                //infosBd.ComandoSql(cmdSql);
                //MessageBox.Show("Tarefa " + codTarefa + " adicionada com sucesso!");

            }
        }

        private void frm_addCompatibilidade_Load(object sender, EventArgs e)
        {
           // rch_textoCompatibilidades.Text = rch_textoCompatibilidades.Text + "Compatível com a versão " + tagInicio_negrito + versoesObject.versaoCompatibilidade + tagFim_negrito + " do " + tagInicio_negrito + versoesObject.sistemaCompatibilidade + tagFim_negrito;
        }
    }
}
