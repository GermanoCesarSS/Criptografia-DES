using ProjetoCriptografia.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCriptografia.Controllers
{
    internal class C_BlocoDeTexto
    {
        public string DivideTextoEmBlocos(string Texto) {
            BlocoDeTexto obj = new BlocoDeTexto();
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

            return string.Join("", blocos);
        }
    }
}
