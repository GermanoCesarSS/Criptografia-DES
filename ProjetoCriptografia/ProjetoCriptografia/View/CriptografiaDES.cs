using ProjetoCriptografia.Controllers;
using ProjetoCriptografia.Model;
using System;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ProjetoCriptografia.View
{
    public partial class CriptografiaDES : Form
    {
        public CriptografiaDES() {
            InitializeComponent();
        }

        Chaves chaves = new Chaves();
        BlocoDeTexto Texto = new BlocoDeTexto();

        C_Chave c_Chave = new C_Chave();
        C_BlocoDeTexto c_BlocoDeTexto = new C_BlocoDeTexto();
        C_Transforma c_Transforma = new C_Transforma();
        int rodadas = 0;
        bool PC1, deslocamento, PC2, IP, LR, XOR1, SBOX, P, Rodada;

        private void btnComecar_Click(object sender, EventArgs e) {
            if (rodadas < 15) {
                deslocamento = false;
                PC2 = false;
                LR = false;
                XOR1 = false;
                SBOX = false;
                P = false;
                Rodada = false;

                btnPC_1.Enabled = false;
                btnIP.Enabled = false;

                btnDeslocamento.Enabled = true;
                btnLR.Enabled = true;

                btnPC_2.Enabled = false;
                btnXOR1.Enabled = false;
                btnSBOX.Enabled = false;
                btnP.Enabled = false;
                btnRodada.Enabled = false;
                btnComecar.Enabled = false;
                rodadas++;
                btnRodada.Text = $"Terminar Rodada {rodadas + 1}";
            }
            else {
                MessageBox.Show("As 16 Rodadas terminaram, coloque um novo texto");
                PC1 = false;
                IP = false;
                deslocamento = false;
                PC2 = false;
                LR = false;
                XOR1 = false;
                SBOX = false;
                P = false;
                Rodada = false;

                btnPC_1.Enabled = true;
                btnIP.Enabled = true;

                btnDeslocamento.Enabled = false;
                btnLR.Enabled = false;

                btnPC_2.Enabled = false;
                btnXOR1.Enabled = false;
                btnSBOX.Enabled = false;
                btnP.Enabled = false;
                btnRodada.Enabled = false;
                btnComecar.Enabled = false;
                rodadas = 0;
                btnRodada.Text = $"Terminar Rodada {rodadas + 1}";
            }
        }
        private void btnGerarChave_Click(object sender, EventArgs e) {
            txtChave.Text = c_Chave.CriandoChave();
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
        private void btnPC_1_Click(object sender, EventArgs e) {
            if (!PC1) {
                if (txtChave.Text.Length == 8) {
                    pnlPC_1.Visible = true;
                    btnDeslocamento.Enabled = true;

                    // A string dentro da textBox tem 8 caracteres
                    chaves.K = c_Transforma.TransformaTextoEm8Byte(txtChave.Text);
                    txtK.Text = c_Transforma.InserirHifensAcada8Caracteres(chaves.K).Insert(63, "(").Insert(65, ")"); //Transforma para textBox
                    chaves.Kp = c_Chave.PermutacaoPC_1(chaves.K);
                    txtKp.Text = c_Transforma.InserirHifensAcada8Caracteres(chaves.Kp).Insert(0, "(").Insert(2, ")");
                    Tuple<string, string> resultadoChave = c_Chave.DividirStringAoMeio56bits(chaves.Kp);
                    chaves.C = resultadoChave.Item1;
                    chaves.D = resultadoChave.Item2;
                    PC1 = true;
                }
                else {
                    MessageBox.Show("Chave não possui 8 caracter");
                }
            }
            else {
                MessageBox.Show("Comando já executado");
            }

        }
        private void btnDeslocamento_Click(object sender, EventArgs e) {
            if (!deslocamento) {
                pnlCD.Visible = true;
                btnPC_2.Enabled = true;
                txtCD.Text = $"C{rodadas}:{chaves.C}";
                txtCD.Text += "\n" + $"      D{rodadas}:" + chaves.D;
                Tuple<string, string> resultadoCD = c_Chave.TabelaCD(chaves.C, chaves.D, rodadas);
                chaves.C = resultadoCD.Item1;
                chaves.D = resultadoCD.Item2;
                txtDeslocamento.Text = $"C{rodadas+1}:{chaves.C}";
                txtDeslocamento.Text += "\n" + $"      D{rodadas+1}:" + chaves.D;
                chaves.Kpg = chaves.C + chaves.D;
                deslocamento = true;
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnPC_2_Click(object sender, EventArgs e) {
            if (!PC2) {
                pnlPC_2.Visible = true;

                chaves.Ki = c_Chave.PermutacaoPC_2(chaves.Kpg);
                txtCDjuntos.Text = "CD:" + c_Transforma.InserirHifensAcada8Caracteres(chaves.Kpg).Insert(14, "(").Insert(16, ")");
                txtPC_2.Text = c_Transforma.InserirHifensAcada8Caracteres(chaves.Ki).Insert(0, "(").Insert(2, ")");
                PC2 = true; 
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnIP_Click_1(object sender, EventArgs e) {
            if (!IP) {
                if (txtTexto.Text.Length == 8) {
                    pnlIP.Visible = true;
                    Texto.texto = c_Transforma.TransformaTextoEm8Byte(txtTexto.Text);
                    txtTextoBinario.Text = c_Transforma.InserirHifensAcada8Caracteres(Texto.texto);
                    Texto.texto = c_BlocoDeTexto.PermutacaoInicialIP(Texto.texto);
                    txtIP.Text = c_Transforma.InserirHifensAcada8Caracteres(Texto.texto);

                    IP = true;
                    btnLR.Enabled = true;
                }
                else {
                    MessageBox.Show("Texto não possui 8 caracter");
                }
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnLR_Click(object sender, EventArgs e) {
            if (!LR) {  
            pnlLR.Visible = true;

            Tuple<string, string> resultadoTexto = c_BlocoDeTexto.DividirStringAoMeio64bits(Texto.texto);
            Texto.L = resultadoTexto.Item1;
            Texto.R = resultadoTexto.Item2;
            txtLR.Text = $"L{rodadas}:{Texto.L}";
            txtLR.Text += "\n" + $"      R{rodadas}:" + Texto.R;
            Texto.Ln = Texto.R;

            Texto.texto = c_BlocoDeTexto.ExpansaoEBit(Texto.R);
            txtR.Text = Texto.texto;
            LR = true;
                btnXOR1.Enabled = true;
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnXOR1_Click(object sender, EventArgs e) {
            if (!XOR1 && (PC2 && LR)) {
                pnlXOR1.Visible = true;
                Texto.F = c_BlocoDeTexto.XOR(Texto.texto, chaves.Ki);
                txtEKi.Text = $"Ei:{c_Transforma.InserirHifensAcada6Caracteres(Texto.texto)} " +
                $"                                Ki:{c_Transforma.InserirHifensAcada6Caracteres(chaves.Ki)}";
                txtXorEKi.Text = "XOR: " + c_Transforma.InserirHifensAcada6Caracteres(Texto.F);

                XOR1 = true;
                btnSBOX.Enabled = true;
            }
            else {
                MessageBox.Show("Comando já executado ou falta fazer o texto e a chave");
            }
        }
        private void btnSBOX_Click_1(object sender, EventArgs e) {
            if (!SBOX) {
                pnlSBOX.Visible = true;

                Texto.F = c_BlocoDeTexto.SBOX(Texto.F);
                txtSBOX.Text = c_Transforma.InserirHifensAcada4Caracteres(Texto.F);

                SBOX = true;
                btnP.Enabled = true;
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnP_Click_1(object sender, EventArgs e) {
            if (!P) {
                pnlPermutacaoP.Visible = true;

                Texto.F = c_BlocoDeTexto.PermutacaoP(Texto.F);
                txtP.Text = "P:" + c_Transforma.InserirHifensAcada4Caracteres(Texto.F);

                Texto.Rn = c_BlocoDeTexto.XOR(Texto.F, Texto.L);
                txtXorLP.Text = "P:" + c_Transforma.InserirHifensAcada4Caracteres(Texto.F);
                txtXorLP.Text += "\n\n\n\n\n\n\n\n\n\n\n\n\nL:" + c_Transforma.InserirHifensAcada4Caracteres(Texto.L);
                txtXorLP.Text += "\n\n\n\n\nXOR:" + c_Transforma.InserirHifensAcada4Caracteres(Texto.Rn);

                P = true;
                btnRodada.Enabled = true;
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }
        private void btnRodada_Click(object sender, EventArgs e) {
            if (!Rodada) {
                pnlPermutacaoP.Visible = true;

                Texto.F = Texto.Ln + Texto.Rn;
                txtRodada.Text = c_Transforma.InserirHifensAcada8Caracteres(Texto.F);
                Texto.texto = Texto.F;

                string RELE = Texto.Rn + Texto.Ln;
                txtFinal.Text = "R + N: " + c_Transforma.InserirHifensAcada8Caracteres(RELE);
                RELE = c_BlocoDeTexto.PermutacaoIP_1(RELE);
                txtFinal.Text += "  \t\t\t\tIP-1: " + c_Transforma.InserirHifensAcada8Caracteres(RELE);
                RELE = c_Transforma.ConverteBinarioParaBase64(RELE);
                txtFinal.Text += "\t\t\t\tBinario Convertido para Base64: " + RELE;
                Rodada = true;
                btnComecar.Enabled = true;
            }
            else {
                MessageBox.Show("Comando já executado");
            }
        }


        string L = "";
        string R = "";
        string L1 = "";
        string R1 = "";
        private void btnDES_Click(object sender, EventArgs e) {
            chaves.Kp = c_Transforma.TransformaTextoEm8Byte(txtChave.Text);
            chaves.Kp = c_Chave.PermutacaoPC_1(chaves.Kp);
            Tuple<string, string> resultadoChave = c_Chave.DividirStringAoMeio56bits(chaves.Kp);
            chaves.C = resultadoChave.Item1;
            chaves.D = resultadoChave.Item2;

            //Texto.texto = c_BlocoDeTexto.DivideTextoEmBlocos("0000000100100011010001010110011110001001101010111100110111101111"); //divide em blocos de 64bits
            Texto.texto = c_Transforma.TransformaTextoEm8Byte(txtTexto.Text);
            Texto.texto = c_BlocoDeTexto.PermutacaoInicialIP(Texto.texto); //começa aqui

            for (int rodadas = 0; rodadas < 16; rodadas++) {
                //Chave
                Tuple<string, string> resultadoCD = c_Chave.TabelaCD(chaves.C, chaves.D, rodadas);
                chaves.C = resultadoCD.Item1;
                chaves.D = resultadoCD.Item2;
                chaves.Kpg = chaves.C + chaves.D;


                chaves.Ki = c_Chave.PermutacaoPC_2(chaves.Kpg);

                //Texto
                Tuple<string, string> resultadoTexto = c_BlocoDeTexto.DividirStringAoMeio64bits(Texto.texto);
                Texto.L = resultadoTexto.Item1;
                Texto.R = resultadoTexto.Item2;
                L1 = Texto.R;
                Texto.texto = c_BlocoDeTexto.ExpansaoEBit(Texto.R);

                //Texto + Chave
                string F = c_BlocoDeTexto.XOR(Texto.texto, chaves.Ki);
                F = c_BlocoDeTexto.SBOX(F);
                F = c_BlocoDeTexto.PermutacaoP(F);
                R1 = c_BlocoDeTexto.XOR(F, Texto.L);
                F = L1 + R1;
                Texto.texto = F;
                label1.Text = Convert.ToString(rodadas + 1);
            }

            //Ultima rodada
            string RELE = R1 + L1;
            RELE = c_BlocoDeTexto.PermutacaoIP_1(RELE);
            //string caminhoArquivo = @"C:\Users\Public\Documents\Encrypt\TesteMeuNome.txt";

            RELE = c_Transforma.ConverteBinarioParaBase64(RELE);

            //File.WriteAllText(caminhoArquivo, RELE);
            txtTextoCrip.Text = RELE;
        }
        
        //Controle dos Paineis
       
        void pnlVisible() {
            pnlPC_1.Visible = false;
            pnlCD.Visible = false;
            pnlPC_2.Visible = false;
            pnlIP.Visible = false;
            pnlLR.Visible = false;
            pnlXOR1.Visible = false;
            pnlSBOX.Visible = false;
            pnlPermutacaoP.Visible = false;
            pnlRodada.Visible = false;
            pnlTabela.Visible = false;

        }

        private void btnSBOX_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlSBOX.Visible = true;
        }

        private void txtSBOX_TextChanged(object sender, EventArgs e) {

        }

        private void btnRodada_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlRodada.Visible = true;
        }

        private void btnTabela_Click(object sender, EventArgs e) {
            pnlVisible();
            pnlTabela.Visible = true;
        }

        private void btnParar_Click(object sender, EventArgs e) {
            MessageBox.Show("Comece uma nova encriptação");
            PC1 = false;
            IP = false;
            deslocamento = false;
            PC2 = false;
            LR = false;
            XOR1 = false;
            SBOX = false;
            P = false;
            Rodada = false;

            btnPC_1.Enabled = true;
            btnIP.Enabled = true;

            btnDeslocamento.Enabled = false;
            btnLR.Enabled = false;

            btnPC_2.Enabled = false;
            btnXOR1.Enabled = false;
            btnSBOX.Enabled = false;
            btnP.Enabled = false;
            btnRodada.Enabled = false;
            btnComecar.Enabled = false;
            rodadas = 0;
            btnRodada.Text = $"Terminar Rodada {rodadas + 1}";
        }

        private void bigLabel21_Click(object sender, EventArgs e) {

        }


        private void btnP_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlPermutacaoP.Visible = true;
        }

        private void btnXOR1_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlXOR1.Visible = true;
        }

        private void btnPC_2_MouseEnter(object sender, EventArgs e) {
            pnlVisible();
            pnlPC_2.Visible = true;
        }

        private void btnLR_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlLR.Visible=true;
        }

        private void pnlIP_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlIP.Visible = true;
        }

        private void btnDeslocamento_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlCD.Visible = true;
        }

        private void btnPC_1_MouseHover(object sender, EventArgs e) {
            pnlVisible();
            pnlPC_1.Visible = true;
        }
    }
}
