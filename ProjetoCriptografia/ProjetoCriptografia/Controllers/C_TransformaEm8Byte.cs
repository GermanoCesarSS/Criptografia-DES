using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Controllers
{
    internal class C_TransformaEm8Byte
    {
        public string TransformaTextoEm8Byte(string texto) {
            byte[] bytes = Encoding.ASCII.GetBytes(texto);

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

        public string Transforma8ByteEmTexto(string bits) {

            List<byte> bytes = new List<byte>();
            for (int i = 0; i < bits.Length; i += 8) {
                string byteString = bits.Substring(i, 8);
                byte valor = Convert.ToByte(byteString, 2);
                bytes.Add(valor);
            }

            return Encoding.ASCII.GetString(bytes.ToArray());
        }
    }
}
