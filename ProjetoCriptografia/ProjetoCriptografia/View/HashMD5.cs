using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCriptografia
{
    public partial class HashMD5 : Form
    {
        public HashMD5() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string msg = textBox1.Text;

            using (MD5 md5 = MD5.Create()) {

                byte[] bytes = Encoding.UTF8.GetBytes(msg);
                byte[] hashBytes = md5.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++) {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                textBox1.Text = sb.ToString();
            }

        }
    }
}
