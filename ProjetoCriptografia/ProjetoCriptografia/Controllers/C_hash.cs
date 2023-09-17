using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Controllers
{
    internal class C_hash {
        string mensagem = "Oiiiiiiii";

        MD5 md5 = MD5.Create();

        private string FazerHash(string msg) {
            byte[] bytes = Encoding.UTF8.GetBytes(msg);
            byte[] hashBytes = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            for(int i = 0; i< hashBytes.Length; i++) {
                sb.Append(hashBytes[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
