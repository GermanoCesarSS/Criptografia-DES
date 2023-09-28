using ProjetoCriptografia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia.Controllers
{
    internal class C_Chave
    {
        Chaves chaves = new Chaves();
        C_Transforma c_Transforma = new C_Transforma();

        public string CriandoChave() {
            Random random = new Random();
            StringBuilder senha = new StringBuilder();
            for (int i = 0; i < chaves.tamanhoChave; i++) {
                int indiceCaractere = random.Next(0, chaves.Chave.Length);
                senha.Append(chaves.Chave[indiceCaractere]);
            }
            return senha.ToString();
            //  Byte
            //return textoEm8Byte.TransformaTextoEm8Byte(senha.ToString());
        }

        public string PermutacaoPC_1(string texto) {
            //texto = c_Transforma.TransformaTextoEm8Byte(texto);
  
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < chaves.pc1Permutacao.Length; i++) {
                    kp.Append(texto[chaves.pc1Permutacao[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação PC-1");
            }
            return kp.ToString();
        }


        public Tuple<string, string> DividirStringAoMeio56bits(string texto) {
            int meio = texto.Length / 2;
            string parte1 = texto.Substring(0, meio);
            string parte2 = texto.Substring(meio);

            return new Tuple<string, string>(parte1, parte2);
        }

        public string MoverPrimeiraLetraParaOFinal(string texto) {

            char primeiraLetra = texto[0];
            string restante = texto.Substring(1);

            return restante + primeiraLetra;
        }
        public Tuple<string, string> TabelaCD(string c, string d, int rodadas)
        {
            for (int i = 0; i < chaves.TabelaCD[rodadas]; i++)
            {
                c = MoverPrimeiraLetraParaOFinal(c);
                d = MoverPrimeiraLetraParaOFinal(d);
            }
            return new Tuple<string, string>(c, d);
        }
        public string PermutacaoPC_2(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < chaves.pc2Permutacao.Length; i++) {
                    kp.Append(texto[chaves.pc2Permutacao[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação PC-1");
            }
            return kp.ToString();
        }

    }
}
