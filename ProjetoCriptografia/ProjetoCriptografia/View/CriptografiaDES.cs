using ProjetoCriptografia.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia.View
{
    public partial class CriptografiaDES : Form
    {
        public CriptografiaDES() {
            InitializeComponent();
        }

        C_Chave c_Chave = new C_Chave();
        private void btnGerarChave_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.CriandoChave();
        }

        private void bntBlocoDeTexto_Click(object sender, EventArgs e) {
            C_BlocoDeTexto blocoDeTexto = new C_BlocoDeTexto();
            //txtTexto.Text = blocoDeTexto.DivideTextoEmBlocos(txtTexto.Text);

            txtTexto.Text = c_Chave.PermutacaoPC_1(txtTexto.Text);
        }

        private void btnDividir_Click(object sender, EventArgs e) {
            Tuple<string, string> resultado = c_Chave.DividirStringAoMeio(txtTexto.Text);

            string C = resultado.Item1;
            string D = resultado.Item2;

            txtTexto.Text = $"{C}\r{D}";
        }
    }
}
