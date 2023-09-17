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
        Chaves obj = new Chaves();
        C_Transforma c_Transforma = new C_Transforma();

        public string CriandoChave() {
            Random random = new Random();
            StringBuilder senha = new StringBuilder();
            for (int i = 0; i < obj.tamanhoChave; i++) {
                int indiceCaractere = random.Next(0, obj.Chave.Length);
                senha.Append(obj.Chave[indiceCaractere]);
            }
            return senha.ToString();
            //  Byte
            //return textoEm8Byte.TransformaTextoEm8Byte(senha.ToString());
        }

        public string PermutacaoPC_1(string texto) {
            //texto = c_Transforma.TransformaTextoEm8Byte(texto);
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.pc1Permutacao.Length; i++) {
                    kp.Append(texto[obj.pc1Permutacao[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação PC-1");
            }
            return kp.ToString();
        }


        public Tuple<string, string> DividirStringAoMeio(string texto) {
            if (texto.Length != 56) {
                throw new ArgumentException("A string de entrada deve ter 56 caracteres.");
            }

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
        public string PermutacaoPC_2(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.pc2Permutacao.Length; i++) {
                    kp.Append(texto[obj.pc2Permutacao[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação PC-1");
            }
            return kp.ToString();
        }
    }
}
