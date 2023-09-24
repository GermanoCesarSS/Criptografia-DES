using ProjetoCriptografia.View;
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
    public partial class Principal : Form
    {
        bool sidebarExpand;
        CriptografiaDES criptografiaDES;
        public Principal() {
            InitializeComponent();
            string CorPreto = "23;24;29";
            string CorTurquesa = "64; 224; 208";
        }
        
        public void loadForm(object Form) {
            sidebarTimer.Start();
            if (sidebarExpand == true) {
                if (mainpanel.Controls.Count > 0) {
                    mainpanel.Controls.RemoveAt(0);
                    Form f = Form as Form;
                    f.FormBorderStyle = FormBorderStyle.None;
                    f.TopLevel = false;
                    f.Dock = DockStyle.Fill;
                    mainpanel.Controls.Add(f);
                    mainpanel.Tag = f;
                    f.Show();
                }
            }
        }

        private void sidebarTimer_Tick(object sender, EventArgs e) {
            if(sidebarExpand) {
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width){
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width) {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e) {
            sidebarTimer.Start();
        }

        private void button4_Click(object sender, EventArgs e) {
                loadForm(new CriptografiaDES());
        }

        private void btnCesar_Click(object sender, EventArgs e) {
            loadForm(new CifraCesar());
        }
    }
}
