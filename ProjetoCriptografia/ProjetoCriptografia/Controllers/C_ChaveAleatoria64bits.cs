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
            ChaveAleatoria64bits obj = new ChaveAleatoria64bits();
            C_TransformaEm8Byte textoEm8Byte = new C_TransformaEm8Byte();
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            obj.ChaveEmBytes = new byte[obj.tamanhoChave];

            rng.GetBytes(obj.ChaveEmBytes);
            //
            //  Texto
            //
            //string chaveAleatoria = string.Join("-",obj.ChaveEmBytes);
            //
            string chaveAleatoria = textoEm8Byte.TransformaNumeroEm8Byte(obj.ChaveEmBytes);
            return chaveAleatoria;
        }
    }
}
