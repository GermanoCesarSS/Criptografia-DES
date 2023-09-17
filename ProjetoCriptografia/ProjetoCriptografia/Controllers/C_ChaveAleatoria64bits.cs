using ProjetoCriptografia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Controllers
{
    internal class C_ChaveAleatoria64bits
    {
        public string CriandoChave() {
            Chaves obj = new Chaves();

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
    }
}
