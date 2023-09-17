using ProjetoCriptografia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia.Controllers
{
    internal class C_Permutacoes
    {
        public string PermutacaoPC_1(string t) {
            C_Transforma c_Transforma = new C_Transforma();
            t = c_Transforma.TransformaTextoEm8Byte(t);
            Chaves obj = new Chaves();
            string kp = null;
            try {
                for (int i = 0; i < obj.pc1Permutacao.Length; i++) {
                    kp += t[obj.pc1Permutacao[i]];
                }
            }catch(Exception e) {
                MessageBox.Show(e.Message, "Erro na permutação PC-1");
            }
            return kp;
        }
    }
}
