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
        public string Transforma8ByteEmTexto(string textoBinario) {

            // Converte a sequência binária em um array de bytes
            byte[] bytes = new byte[textoBinario.Length / 8];
            for (int i = 0; i < bytes.Length; i++) {
                bytes[i] = Convert.ToByte(textoBinario.Substring(i * 8, 8), 2);
            }

            // Converte o array de bytes em texto usando UTF-8
            return Encoding.UTF8.GetString(bytes);
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

    }
}
