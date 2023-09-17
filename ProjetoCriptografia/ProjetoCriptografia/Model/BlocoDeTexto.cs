using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Model
{
    internal class BlocoDeTexto
    {
        public string texto { get; set; }
        public int tamanhoDoBloco { get; } = 64;
    }
}
