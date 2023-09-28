using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Controllers
{
    internal class C_Transforma
    {
        public string TransformaTextoEm8Byte(string texto) {
            byte[] bytes = Encoding.UTF8.GetBytes(texto);

            // Converte em uma representação binaria de 8 bits
            string[] textoEm8Bytes = new string[bytes.Length];
            for (int i = 0; i < bytes.Length; i++) {
                textoEm8Bytes[i] = Convert.ToString(bytes[i], 2).PadLeft(8, '0');
            }

            //Transforma o vetor em uma string
            return string.Join("", textoEm8Bytes);
        }
        public string InserirHifensAcada8Caracteres(string input) {
            // Verifica se a entrada é nula ou vazia
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            int tamanhoBloco = 8; // Tamanho do bloco de caracteres
            int inputLength = input.Length;
            int numBlocos = (inputLength + tamanhoBloco - 1) / tamanhoBloco; // Calcula o número de blocos

            // Inicializa um StringBuilder para construir a string resultante de forma eficiente
            StringBuilder resultado = new StringBuilder(inputLength + numBlocos - 1);

            // Itera sobre os blocos
            for (int i = 0; i < numBlocos; i++) {
                int startIndex = i * tamanhoBloco;
                int endIndex = Math.Min(startIndex + tamanhoBloco, inputLength);
                string bloco = input.Substring(startIndex, endIndex - startIndex);

                resultado.Append(bloco);

                // Adiciona um hífen se não for o último bloco
                if (i < numBlocos - 1) {
                    resultado.Append("-");
                }
            }
            return resultado.ToString();
        }
        public string InserirHifensAcada6Caracteres(string input) {
            // Verifica se a entrada é nula ou vazia
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            int tamanhoBloco = 6; // Tamanho do bloco de caracteres
            int inputLength = input.Length;
            int numBlocos = (inputLength + tamanhoBloco - 1) / tamanhoBloco; // Calcula o número de blocos

            // Inicializa um StringBuilder para construir a string resultante de forma eficiente
            StringBuilder resultado = new StringBuilder(inputLength + numBlocos - 1);

            // Itera sobre os blocos
            for (int i = 0; i < numBlocos; i++) {
                int startIndex = i * tamanhoBloco;
                int endIndex = Math.Min(startIndex + tamanhoBloco, inputLength);
                string bloco = input.Substring(startIndex, endIndex - startIndex);

                resultado.Append(bloco);

                // Adiciona um hífen se não for o último bloco
                if (i < numBlocos - 1) {
                    resultado.Append("-");
                }
            }
            return resultado.ToString();
        }
        public string InserirHifensAcada4Caracteres(string input) {
            // Verifica se a entrada é nula ou vazia
            if (string.IsNullOrEmpty(input)) {
                return input;
            }

            int tamanhoBloco = 4; // Tamanho do bloco de caracteres
            int inputLength = input.Length;
            int numBlocos = (inputLength + tamanhoBloco - 1) / tamanhoBloco; // Calcula o número de blocos

            // Inicializa um StringBuilder para construir a string resultante de forma eficiente
            StringBuilder resultado = new StringBuilder(inputLength + numBlocos - 1);

            // Itera sobre os blocos
            for (int i = 0; i < numBlocos; i++) {
                int startIndex = i * tamanhoBloco;
                int endIndex = Math.Min(startIndex + tamanhoBloco, inputLength);
                string bloco = input.Substring(startIndex, endIndex - startIndex);

                resultado.Append(bloco);

                // Adiciona um hífen se não for o último bloco
                if (i < numBlocos - 1) {
                    resultado.Append("-");
                }
            }
            return resultado.ToString();
        }
        public string Transforma8ByteEmHEX(string textoBinario) {

            long valorDecimal = Convert.ToInt64(textoBinario, 2);

            // Converte o valor decimal em uma string hexadecimal
            return valorDecimal.ToString("X");
        }
        public string ConverteBinarioParaBase64(string sequenciaBinaria) {
            // Converte a sequência binária para um array de bytes
            byte[] bytes = new byte[sequenciaBinaria.Length / 8];
            for (int i = 0; i < bytes.Length; i++) {
                bytes[i] = Convert.ToByte(sequenciaBinaria.Substring(i * 8, 8), 2);
            }

            // Converte o array de bytes para base64
            string base64 = Convert.ToBase64String(bytes);

            return base64;
        }

    }
}
