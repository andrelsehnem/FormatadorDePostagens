using System;

namespace FormatadorDePostagens
{
    public class Versoes
    {
        public String versao = "";
        public String versaoCompatibilidade = "";
        public Boolean versaoFinal = false;
        public String sistema = "";
        public String sistemaCompatibilidade = "";
        public String colaborador = "";
        public Boolean naoCompativel = false;
        public string versoesMensagem = ""; //essa aqui recebe as versões adicionais que vão ser liberadas

        public String replacePalavras(String text)  
        {
            String[] palavrasErradas = new string[] { " nfe ", " nf-e ", " nfce ", " nfc-e ", " nfse ", " nfs-e ", " cte ", " ct-e ", " nf ", " nfse ", " nfs-e ", " pis ", " cofins ", " cst ", " cfop ", " coi ", " icmsst ", " icms-st ", " icms ", " sped ", " ncm ", " ipi ", " inconsitencia ", " inconcistencia ", " inconsitência ", " inconcistência ", " Ajustado ", " inconsistencia ", " incôncistencia ", " xml ", " sat ", " qr code " };
            String[] palavrasCertas = new string[] { " NF-e ", " NF-e ", " NFC-e ", " NFC-e ", " NFS-e ", " NFS-e ", " CT-e ", " CT-e ", " NF ", " NFS-e ", " NFS-e ", " PIS ", " COFINS ", " CST ", " CFOP ", " COI ", " ICMS-ST ", " ICMS-ST ", " ICMS ", " SPED", " NCM ", " IPI ", " inconsistência ", " inconsistência ", " inconsistência ", " inconsistência ", " Ajustada ", " inconsistência ", " inconsistência ", " XML ", " SAT ", " QR Code " };
            String descricao = "";

            for (int i = 0; i < palavrasErradas.Length; i++)
            {
                descricao = text.Replace(palavrasErradas[i], palavrasCertas[i]);
                text = descricao;
            }
            return descricao;
        }

        public string replaceChars(String text)
        {
             
            String[] palavrasErradas = new String[] {"'" };
            String[] palavrasCertas = new String[] {"''"};
            String descricao = "";

            for (int i = 0; i < palavrasErradas.Length; i++)
            {
                descricao = text.Replace(palavrasErradas[i], palavrasCertas[i]);
                text = descricao;
            }

            return descricao;
        }

    }
}

/*
 public String palavraMaiuscula(String texto)
        {
            String[] palavrasErradas = new string[] { "nfe", "nf-e", "nfce", "nfc-e", "nfse", "nfs-e", "cte", "ct-e", "nf", "nfse", "nfs-e", "pis", "cofins", "cst", "cfop", "coi", "icmsst", "icms-st", "icms", "sped", "ncm", "ipi", "inconsitencia", "inconcistencia", "inconsitência", "inconcistência", "Ajustado", "inconsistencia", "incôncistencia ", "xml", "sat" };
            String[] palavrasCertas = new string[] { "NF-e", "NF-e", "NFC-e", "NFC-e", "NFS-e", "NFS-e", "CT-e", "CT-e", "NF", "NFS-e", "NFS-e", "PIS", "COFINS", "CST", "CFOP", "COI", "ICMS-ST", "ICMS-ST", "ICMS", "SPED", "NCM", "IPI", "inconsistência", "inconsistência", "inconsistência", "inconsistência", "Ajustada", "inconsistência", "inconsistência", "XML", "SAT" };
            String descricao = ""; //aqui vai ir juntando as palavras pra fazer o texto de volta;
            int i = texto.IndexOf(" ");
            int ult = 1;
            string palavra = "";
            while (i <= texto.Length)
            {

                if (ult == 1)
                {
                    descricao = "";
                    palavra = texto.Substring(0, i);
                } else if (i == -1) { return descricao; }
                else
                {
                    if (ult == i) i++;
                    palavra = texto.Substring(ult, i - ult);
                    String tempPalavra = palavra;
                    if (tempPalavra.Substring(palavra.Length - 1, 1) == ".")
                    {
                        palavra = palavra.Substring(0, palavra.Length - 1);
                    }
                }
                for (int cont = 0; cont < palavrasErradas.Length; cont++)
                {
                    if (palavra == palavrasErradas[cont])
                    {
                        palavra = palavrasCertas[cont];
                    }
                }
                if (i >= texto.Length)
                {
                    ult = i;
                    descricao = descricao + palavra + ".";
                    //return descricao;
                    return descricao;
                }
                else
                {
                    ult = i + 1;
                    descricao = descricao + palavra + " ";
                    i = texto.IndexOf(" ", ult);
                    //if (i == -1) i = texto.Length;
                }
            }
            return descricao;
        }
*/