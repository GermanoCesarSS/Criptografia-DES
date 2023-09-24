using ProjetoCriptografia.Controllers;
using ProjetoCriptografia.Model;
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjetoCriptografia.View
{
    public partial class CriptografiaDES : Form
    {
        public CriptografiaDES() {
            InitializeComponent();
        }

       Chaves chaves = new Chaves();
        BlocoDeTexto blocoDeTexto = new BlocoDeTexto();

        C_Chave c_Chave = new C_Chave();
        C_BlocoDeTexto c_BlocoDeTexto = new C_BlocoDeTexto();
        C_Transforma c_Transforma = new C_Transforma();

        int rodadas = 0;
        private void btnGerarChave_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.CriandoChave();
        }

        private void btnPC1_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.PermutacaoPC_1(txtChave.Text);
        }

     
        private void btnDividir_Click(object sender, EventArgs e) {
            Tuple<string, string> resultado = c_Chave.DividirStringAoMeio56bits(txtChave.Text);

            chaves.C = resultado.Item1;
            chaves.D = resultado.Item2;

            txtChave.Text = $"{chaves.C}{chaves.D}";
        }

        private void btnMover_Click(object sender, EventArgs e) {

            //chaves.Ki = c_Chave.TabelaCD(chaves.C, chaves.D, rodadas);
            txtChave.Text = chaves.Ki;
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
            txtTexto.Text = L1 + R1;

            rodadas++;
            label1.Text = Convert.ToString(rodadas);
        }

        private void btnFinal_Click(object sender, EventArgs e) {
            string RELE = R1+L1;
            RELE = c_BlocoDeTexto.PermutacaoIP_1(RELE);
            string caminhoArquivo = @"C:\Users\Public\Documents\TesteMeuNome.txt";
            
            RELE = c_Transforma.ConverteBinarioParaBase64(RELE);

            File.WriteAllText(caminhoArquivo,RELE);
            txtTexto.Text = RELE;
        }

        private void BTNcONVERTA_Click(object sender, EventArgs e) {
            txtTexto.Text = c_Transforma.Transforma8ByteEmHEX(txtTexto.Text);
         
        }

        private void label1_Click(object sender, EventArgs e) {
        }

        private void btnDES_Click(object sender, EventArgs e) {
            chaves.Kp = c_Chave.PermutacaoPC_1("0010010101001011001110000010111101011111001000110101010101001101");
            Tuple<string, string> resultadoChave = c_Chave.DividirStringAoMeio56bits(chaves.Kp);
            chaves.C = resultadoChave.Item1;
            chaves.D = resultadoChave.Item2;

            //blocoDeTexto.texto = c_BlocoDeTexto.DivideTextoEmBlocos("0000000100100011010001010110011110001001101010111100110111101111"); //divide em blocos de 64bits
            blocoDeTexto.texto = c_BlocoDeTexto.PermutacaoInicialIP("0100011101100101011100100110110101100001011011100110111101101111"); //começa aqui

            for (int rodadas = 0; rodadas < 16; rodadas++) {
                //Chave
                Tuple<string, string> resultadoCD = c_Chave.TabelaCD(chaves.C, chaves.D, rodadas);
                chaves.C = resultadoCD.Item1;
                chaves.D = resultadoCD.Item2;
                chaves.Kpg = chaves.C + chaves.D;


                chaves.Ki = c_Chave.PermutacaoPC_2(chaves.Kpg);

                //Texto
                Tuple<string, string> resultadoTexto = c_BlocoDeTexto.DividirStringAoMeio64bits(blocoDeTexto.texto);
                blocoDeTexto.L = resultadoTexto.Item1;
                blocoDeTexto.R = resultadoTexto.Item2;
                L1 = blocoDeTexto.R;
                blocoDeTexto.texto = c_BlocoDeTexto.ExpansaoEBit(blocoDeTexto.R);

                //Texto + Chave
                string F = c_BlocoDeTexto.XOR(blocoDeTexto.texto, chaves.Ki);
                F = c_BlocoDeTexto.SBOX(F);
                F = c_BlocoDeTexto.PermutacaoP(F);

                R1 = c_BlocoDeTexto.XOR(F, blocoDeTexto.L);
                F = L1 + R1;
                blocoDeTexto.texto = F;
                label1.Text = Convert.ToString(rodadas + 1);
            }

            //Ultima rodada
            string RELE = R1 + L1;
            RELE = c_BlocoDeTexto.PermutacaoIP_1(RELE);
            string caminhoArquivo = @"C:\Users\Public\Documents\Encrypt\TesteMeuNome.txt";

            RELE = c_Transforma.ConverteBinarioParaBase64(RELE);

            File.WriteAllText(caminhoArquivo, RELE);
            txtTextoCrip.Text = RELE;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e) {
            if (txtTexto.Text.Length >= 8 && e.KeyChar != 8) {
                e.Handled = true; // Impede a entrada da tecla
            }
        }

        private void txtChave_KeyPress(object sender, KeyPressEventArgs e) {
            if (txtChave.Text.Length >= 8 && e.KeyChar != 8) {
                e.Handled = true; // Impede a entrada da tecla
            }
        }
    }
}
