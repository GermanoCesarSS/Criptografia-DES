using ProjetoCriptografia.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia.Controllers
{
    internal class C_BlocoDeTexto
    {
            BlocoDeTexto obj = new BlocoDeTexto();
        public string DivideTextoEmBlocos(string Texto) {
            C_Transforma textoEm8Byte = new C_Transforma();

            obj.texto = textoEm8Byte.TransformaTextoEm8Byte(Texto);

            int numeroDeBlocos = (int)Math.Ceiling((double)obj.texto.Length / obj.tamanhoDoBloco);
            string[] blocos = new string[numeroDeBlocos];

            for (int i = 0; i < numeroDeBlocos; i++) {
                int inicio = i * obj. tamanhoDoBloco;
                int comprimento = Math.Min(obj.tamanhoDoBloco, obj.texto.Length - inicio);
                string bloco = obj.texto.Substring(inicio, comprimento);

                // Preencha com 0 a esquerda
                if (comprimento < obj.tamanhoDoBloco) {
                    bloco = bloco.PadLeft(obj.tamanhoDoBloco, '0');
                }

                blocos[i] = bloco;
            }

            return string.Join("-", blocos);
        }

        public string PermutacaoInicialIP(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.permutacaoIP.Length; i++) {
                    kp.Append(texto[obj.permutacaoIP[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação inicial");
            }
            return kp.ToString();
        }
        public Tuple<string, string> DividirStringAoMeio64bits(string texto) {
            if (texto.Length != 64) {
                throw new ArgumentException("A string de entrada deve ter 64 bits.");
            }

            int meio = texto.Length / 2;
            string parte1 = texto.Substring(0, meio);
            string parte2 = texto.Substring(meio);

            return new Tuple<string, string>(parte1, parte2);
        }
        public string ExpansaoEBit(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.expansaoEBit.Length; i++) {
                    kp.Append(texto[obj.expansaoEBit[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na expansão de bit");
            }
            return kp.ToString();
        }
        public  string XOR(string texto1, string texto2) {

            char[] binaryArray1 = texto1.ToCharArray();
            char[] binaryArray2 = texto2.ToCharArray();

            char[] resultArray = new char[binaryArray1.Length];

            // Execute o XOR bit a bit
            for (int i = 0; i < binaryArray1.Length; i++) {
                resultArray[i] = (binaryArray1[i] == binaryArray2[i]) ? '0' : '1';
            }

            // Converta o resultado de volta para uma string de binários
            string result = new string(resultArray);

            return result;
        }

        public string SBOX(string texto) {

            //Divide a string em um arry com 6 bits
            int tamanhoDoPedaço = 6;
            int quantidadeDePedacos = 8; 
            string[] arrayDeByte = new string[quantidadeDePedacos];

            for (int i = 0; i < quantidadeDePedacos; i++) {
                int indiceInicial = i * tamanhoDoPedaço;
                    int tamanho = Math.Min(tamanhoDoPedaço, texto.Length - indiceInicial);
                    arrayDeByte[i] = texto.Substring(indiceInicial, tamanho);
               //
                string Byte = arrayDeByte[i];

                string primeiroEultimoCaractere = $"{Byte[0]}{Byte[Byte.Length - 1]}";
                int Linha = Convert.ToInt32(primeiroEultimoCaractere, 2);

                string caracteresIntermediarios = Byte.Substring(1, Byte.Length - 2);
                int Coluna = Convert.ToInt32(caracteresIntermediarios, 2);

                arrayDeByte[i] = Convert.ToString(obj.SBOXs[i][Linha,Coluna], 2);
                arrayDeByte[i] = arrayDeByte[i].ToString().PadLeft(4, '0');

            }

            return string.Join("",arrayDeByte);
        }
        public string PermutacaoP(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.permutacaoP.Length; i++) {
                    kp.Append(texto[obj.permutacaoP[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação");
            }
            return kp.ToString();
        }
        public string PermutacaoIP_1(string texto) {
            StringBuilder kp = new StringBuilder();

            try {
                for (int i = 0; i < obj.permutacaoIP_1.Length; i++) {
                    kp.Append(texto[obj.permutacaoIP_1[i] - 1]);
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação final");
            }
            return kp.ToString();
        }
    }
}
