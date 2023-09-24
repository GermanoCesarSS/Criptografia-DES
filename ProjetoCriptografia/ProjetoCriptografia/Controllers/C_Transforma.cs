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
        public string TransformaNumeroEm8Byte(byte[] texto) {

            // Converte em uma representação binaria de 8 bits
            string[] textoEm8Bytes = new string[texto.Length];
            for (int i = 0; i < texto.Length; i++) {
                textoEm8Bytes[i] = Convert.ToString(texto[i], 2).PadLeft(8, '0');
            }

            //Transforma o vetor em uma string
            return string.Join("", textoEm8Bytes);
        }
        public string Transforma8ByteEmHEX(string textoBinario) {

            long valorDecimal = Convert.ToInt64(textoBinario, 2);

            // Converte o valor decimal em uma string hexadecimal
            return valorDecimal.ToString("X");
        }

        public byte[] TransformaBinarioEm8byte(string texto) {

            byte[] byteArray = new byte[texto.Length / 8];

            // Preencha o array de bytes com os valores convertidos da string binária
            for (int i = 0; i < byteArray.Length; i++) {
                string byteString = texto.Substring(i * 8, 8);
                byteArray[i] = Convert.ToByte(byteString, 2);
            }
            return byteArray;
        }
        public byte[] BinarioParaHexadecimalBytes(string binario) {
            // Certifique-se de que a sequência binária tenha um número par de dígitos (um byte completo)
            if (binario.Length % 8 != 0) {
                throw new ArgumentException("A sequência binária deve ter um número par de dígitos (um byte completo).");
            }

            // Crie um array de bytes para armazenar a representação hexadecimal
            byte[] hexadecimalBytes = new byte[binario.Length / 8];

            for (int i = 0; i < binario.Length; i += 8) {
                string byteBinario = binario.Substring(i, 8); // Separa cada byte binário
                byte valorByte = Convert.ToByte(byteBinario, 2); // Converte para um byte
                hexadecimalBytes[i / 8] = valorByte; // Armazena no array de bytes
            }

            return hexadecimalBytes;
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
