namespace ProjetoCriptografia.View
{
    partial class CriptografiaDES
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
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.bntBlocoTexto = new System.Windows.Forms.Button();
            this.btnDividir = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // txtChave
            // 
            this.txtChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave.Location = new System.Drawing.Point(439, 56);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(365, 28);
            this.txtChave.TabIndex = 0;
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Location = new System.Drawing.Point(575, 104);
            this.btnGerarChave.Name = "btnGerarChave";
            this.btnGerarChave.Size = new System.Drawing.Size(140, 23);
            this.btnGerarChave.TabIndex = 1;
            this.btnGerarChave.Text = "Gerar Chave";
            this.btnGerarChave.UseVisualStyleBackColor = true;
            this.btnGerarChave.Click += new System.EventHandler(this.btnGerarChave_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(29, 56);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(365, 232);
            this.txtTexto.TabIndex = 2;
            // 
            // bntBlocoTexto
            // 
            this.bntBlocoTexto.Location = new System.Drawing.Point(108, 334);
            this.bntBlocoTexto.Name = "bntBlocoTexto";
            this.bntBlocoTexto.Size = new System.Drawing.Size(192, 23);
            this.bntBlocoTexto.TabIndex = 3;
            this.bntBlocoTexto.Text = "Gerar Bloco de Texto";
            this.bntBlocoTexto.UseVisualStyleBackColor = true;
            this.bntBlocoTexto.Click += new System.EventHandler(this.bntBlocoDeTexto_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDividir.Image = null;
            this.btnDividir.Location = new System.Drawing.Point(342, 327);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.NoRounding = false;
            this.btnDividir.Size = new System.Drawing.Size(109, 32);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "DividirTexto";
            this.btnDividir.Transparent = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // CriptografiaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 509);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.bntBlocoTexto);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnGerarChave);
            this.Controls.Add(this.txtChave);
            this.Name = "CriptografiaDES";
            this.Text = "CriptografiaDES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnGerarChave;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button bntBlocoTexto;
        private ReaLTaiizor.Controls.AirButton btnDividir;
    }
}