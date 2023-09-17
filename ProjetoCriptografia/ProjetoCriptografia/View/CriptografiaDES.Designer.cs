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
            this.btnMover = new ReaLTaiizor.Controls.AirButton();
            this.btnPC2 = new ReaLTaiizor.Controls.AirButton();
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
            // btnMover
            // 
            this.btnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMover.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnMover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMover.Image = null;
            this.btnMover.Location = new System.Drawing.Point(342, 377);
            this.btnMover.Name = "btnMover";
            this.btnMover.NoRounding = false;
            this.btnMover.Size = new System.Drawing.Size(109, 32);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "MoverTexto";
            this.btnMover.Transparent = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnPC2
            // 
            this.btnPC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPC2.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnPC2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPC2.Image = null;
            this.btnPC2.Location = new System.Drawing.Point(342, 428);
            this.btnPC2.Name = "btnPC2";
            this.btnPC2.NoRounding = false;
            this.btnPC2.Size = new System.Drawing.Size(109, 32);
            this.btnPC2.TabIndex = 6;
            this.btnPC2.Text = "PC-2";
            this.btnPC2.Transparent = false;
            this.btnPC2.Click += new System.EventHandler(this.btnPC2_Click);
            // 
            // CriptografiaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 509);
            this.Controls.Add(this.btnPC2);
            this.Controls.Add(this.btnMover);
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
        private ReaLTaiizor.Controls.AirButton btnMover;
        private ReaLTaiizor.Controls.AirButton btnPC2;
    }
}