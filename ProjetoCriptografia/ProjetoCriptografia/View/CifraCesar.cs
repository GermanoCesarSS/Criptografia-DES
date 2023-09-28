using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia
{
    public partial class CifraCesar : Form
    {
        public CifraCesar() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
        

            List<Label> labelTxt = new List<Label>{
                    label1, label2, label3, label4, label5, label6,
                    label7, label8, label9, label10, label11, label12,
                    label13, label14, label15, label16, label17, label18,
                    label19, label20, label21, label22, label23, label24,
                    label25, label26 };

            string[] letras = new string[]{
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                "U", "V", "W", "X", "Y", "Z"};


            for (int i = int.Parse(lblchave.Text), j = 0; j < labelTxt.Count; i++, j++) {

                if (i >= letras.Length) // Verifica se o índice i ultrapassou o tamanho da matriz letras
                {
                    i = 0; // Reinicia o índice i para 0
                }

                labelTxt[j].Text = letras[i];
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            
            string textoNormal = txtTexto.Text;
            int chave = int.Parse(lblchave.Text);

            string textoCriptogravado = Encriptar(textoNormal, chave);
            txtCifrado.Text += textoCriptogravado;
        }
        private void button3_Click(object sender, EventArgs e) {
            string textoCriptografado = txtCifrado.Text;
            int chave = int.Parse(lblchave.Text);

            string textoDescriptografado = Descriptar(textoCriptografado, chave);
            txtTexto.Text += textoDescriptografado;
        }
        private string Encriptar(string text, int chave) {
            string textCriptogravado = "";

                foreach (char caracter in text) {
                    if (char.IsLetter(caracter)) {
                            char chavee = (char)(caracter + chave);

                            if ((char.IsLower(caracter) && chavee > 'z') ||
                                (char.IsUpper(caracter) && chavee > 'Z')) {
                                chavee = (char)(caracter - (26 - chave));
                            }

                            textCriptogravado += chavee;
                    }
                    else{
                            textCriptogravado += caracter;
                    }
                }
            return textCriptogravado;
        }

        private string Descriptar(string text, int chave) {
            string textDescriptografado = "";

            foreach (char caracter in text) {
                if (char.IsLetter(caracter)) {
                    char chavee = (char)(caracter - chave);

                    if ((char.IsLower(caracter) && chavee < 'a') ||
                        (char.IsUpper(caracter) && chavee < 'A')) {
                        chavee = (char)(caracter + (26 - chave));
                    }

                    textDescriptografado += chavee;
                }
                else {
                    textDescriptografado += caracter;
                }
            }

            return textDescriptografado;
        }

    }
}
