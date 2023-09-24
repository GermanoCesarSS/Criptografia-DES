namespace ProjetoCriptografia.View
{
    partial class Teste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.airButton1 = new ReaLTaiizor.Controls.AirButton();
            this.EncText = new ReaLTaiizor.Controls.TextBoxEdit();
            this.EncKey = new ReaLTaiizor.Controls.TextBoxEdit();
            this.SuspendLayout();
            // 
            // airButton1
            // 
            this.airButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.airButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airButton1.Image = null;
            this.airButton1.Location = new System.Drawing.Point(105, 312);
            this.airButton1.Name = "airButton1";
            this.airButton1.NoRounding = false;
            this.airButton1.Size = new System.Drawing.Size(100, 45);
            this.airButton1.TabIndex = 0;
            this.airButton1.Text = "Encriptar";
            this.airButton1.Transparent = false;
            // 
            // EncText
            // 
            this.EncText.BackColor = System.Drawing.Color.Transparent;
            this.EncText.Font = new System.Drawing.Font("Tahoma", 11F);
            this.EncText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.EncText.Image = null;
            this.EncText.Location = new System.Drawing.Point(12, 49);
            this.EncText.MaxLength = 32767;
            this.EncText.Multiline = true;
            this.EncText.Name = "EncText";
            this.EncText.ReadOnly = false;
            this.EncText.Size = new System.Drawing.Size(286, 248);
            this.EncText.TabIndex = 1;
            this.EncText.Text = "textBoxEdit1";
            this.EncText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.EncText.UseSystemPasswordChar = false;
            // 
            // EncKey
            // 
            this.EncKey.BackColor = System.Drawing.Color.Transparent;
            this.EncKey.Font = new System.Drawing.Font("Tahoma", 11F);
            this.EncKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.EncKey.Image = null;
            this.EncKey.Location = new System.Drawing.Point(328, 49);
            this.EncKey.MaxLength = 32767;
            this.EncKey.Multiline = false;
            this.EncKey.Name = "EncKey";
            this.EncKey.ReadOnly = false;
            this.EncKey.Size = new System.Drawing.Size(352, 46);
            this.EncKey.TabIndex = 2;
            this.EncKey.Text = "textBoxEdit2";
            this.EncKey.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.EncKey.UseSystemPasswordChar = false;
            // 
            // Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.EncKey);
            this.Controls.Add(this.EncText);
            this.Controls.Add(this.airButton1);
            this.Name = "Teste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teste";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.TextBoxEdit EncText;
        private ReaLTaiizor.Controls.TextBoxEdit EncKey;
    }
}