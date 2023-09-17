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

        private void btnGerarChave_Click(object sender, EventArgs e) {
            C_ChaveAleatoria64bits chaveAleatoria64Bits = new C_ChaveAleatoria64bits();
            txtTexto.Text = chaveAleatoria64Bits.CriandoChave();
        }

        private void bntBlocoDeTexto_Click(object sender, EventArgs e) {
            C_BlocoDeTexto blocoDeTexto = new C_BlocoDeTexto();
            txtTexto.Text = blocoDeTexto.DivideTextoEmBlocos(txtTexto.Text);
        }
    }
}
