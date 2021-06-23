using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatadorDePostagens.Classes
{
    class Erros


//criar umas validações pra erros ou só isso mesmo por enquanto


    {
        //private Mail mail = new Mail();
        public void conexaoBd(Exception ex, String local)
        {
            //mail.enviaEmail(ex.GetBaseException().ToString(), local);
            MessageBox.Show("Erro ocororrido em: " + local + ex.GetBaseException().ToString());
            //ex.Message
            //TargetSite
            //ex.GetType()
            //ex.GetBaseException()
            //ex.ToString()
        }

        public void verifica(Exception ex, String local)
        {

        }
    }
}
