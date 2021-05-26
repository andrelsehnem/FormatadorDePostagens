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
    public partial class frm_editaTexto : Form
    {
        public frm_editaTexto()
        {
            InitializeComponent();
            int count1 = 0;
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
            
            if (count < 3)
            {
                MessageBox.Show("Não funciona ainda");
                count++;
            }else if (count == 3 || count < 6)
            {
                MessageBox.Show("Não sabe ler?");
                count++;
            }
            else
            {
                MessageBox.Show("Desisto...");
                this.Close();
            }
        }

        private void bt_carregar_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (count < 3)
            {
                MessageBox.Show("Não funciona ainda");
                count++;
            }
            else if (count == 3 || count < 6)
            {
                MessageBox.Show("Não sabe ler?");
                count++;
            }
            else
            {
                MessageBox.Show("Desisto...");
                this.Close();
            }
        }
    }
}
