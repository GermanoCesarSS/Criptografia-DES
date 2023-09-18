using ProjetoCriptografia.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        C_BlocoDeTexto c_BlocoDeTexto = new C_BlocoDeTexto();
        C_Transforma c_Transforma = new C_Transforma();
        private void btnGerarChave_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.CriandoChave();
        }

        private void btnPC1_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.PermutacaoPC_1(txtChave.Text);
        }

        string C = "";
        string D = "";
        private void btnDividir_Click(object sender, EventArgs e) {
            Tuple<string, string> resultado = c_Chave.DividirStringAoMeio56bits(txtChave.Text);

            C = resultado.Item1;
            D = resultado.Item2;

            txtChave.Text = $"{C}{D}";
        }

        private void btnMover_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.MoverPrimeiraLetraParaOFinal(C);
            txtChave.Text += c_Chave.MoverPrimeiraLetraParaOFinal(D);
        }

        private void btnPC2_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.PermutacaoPC_2(txtChave.Text);
        }


        private void bntBlocoDeTexto_Click(object sender, EventArgs e) {
            
            txtTexto.Text = c_BlocoDeTexto.DivideTextoEmBlocos(txtTexto.Text);

        }
        private void btnIP_Click(object sender, EventArgs e) {
            txtTexto.Text = c_BlocoDeTexto.PermutacaoInicialIP(txtTexto.Text);
        }
        string L = "";
        string R = "";
        string L1 = "";
        string R1 = "";
        private void btnDividirLR_Click(object sender, EventArgs e) {
            Tuple<string, string> resultado = c_BlocoDeTexto.DividirStringAoMeio64bits(txtTexto.Text);

            L = resultado.Item1;
            R = resultado.Item2;

            txtTexto.Text = $"{L}\n{R}";
            L1 = R;
            
        }
        
        private void btnExpansao_Click(object sender, EventArgs e) {
            txtTexto.Text = c_BlocoDeTexto.ExpansaoEBit(R);
        }

        private void btnXOR_Click(object sender, EventArgs e) {
            txtTexto.Text = c_BlocoDeTexto.XOR(txtTexto.Text, txtChave.Text);
        }

        private void btnSBOX_Click(object sender, EventArgs e) {
            txtTexto.Text = c_BlocoDeTexto.SBOX(txtTexto.Text);
        }

        private void btnP_Click(object sender, EventArgs e) {
            txtTexto.Text = c_BlocoDeTexto.PermutacaoP(txtTexto.Text);
        }

        private void btnXOR_L_Click(object sender, EventArgs e) {
            R1 = c_BlocoDeTexto.XOR(txtTexto.Text, L);
            txtTexto.Text = R1;

        }

        private void btnFinal_Click(object sender, EventArgs e) {
            string RELE = R1+L1;
            RELE = c_BlocoDeTexto.PermutacaoP(RELE);
            string caminhoArquivo = @"C:\Users\Public\Documents\Encrypt\TesteMeuNome.txt";
            
            RELE = c_Transforma.Transforma8ByteEmTexto(RELE);
            File.WriteAllText(caminhoArquivo, RELE);
            txtTexto.Text = RELE;
        }

        private void BTNcONVERTA_Click(object sender, EventArgs e) {
            txtTexto.Text = c_Transforma.TransformaTextoEm8Byte(txtTexto.Text);
        }
    }
}
