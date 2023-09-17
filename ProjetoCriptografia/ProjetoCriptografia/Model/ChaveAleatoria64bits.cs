using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Model
{
    internal class ChaveAleatoria64bits
    {
        public ChaveAleatoria64bits() {
            
        }

        public int tamanhoChave { get; } = 8;
        public string Chave { get;} = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
    }
}
