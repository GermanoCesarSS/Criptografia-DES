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
            this.btnPC1 = new ReaLTaiizor.Controls.AirButton();
            this.btnIP = new ReaLTaiizor.Controls.AirButton();
            this.btnDividirLR = new ReaLTaiizor.Controls.AirButton();
            this.btnExpansao = new ReaLTaiizor.Controls.AirButton();
            this.btnXOR = new ReaLTaiizor.Controls.AirButton();
            this.btnSBOX = new ReaLTaiizor.Controls.AirButton();
            this.btnP = new ReaLTaiizor.Controls.AirButton();
            this.btnXOR_L = new ReaLTaiizor.Controls.AirButton();
            this.btnFinal = new ReaLTaiizor.Controls.AirButton();
            this.BTNcONVERTA = new ReaLTaiizor.Controls.AirButton();
            this.SuspendLayout();
            // 
            // txtChave
            // 
            this.txtChave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChave.Location = new System.Drawing.Point(439, 56);
            this.txtChave.Multiline = true;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(365, 120);
            this.txtChave.TabIndex = 0;
            // 
            // btnGerarChave
            // 
            this.btnGerarChave.Location = new System.Drawing.Point(563, 202);
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
            this.bntBlocoTexto.Location = new System.Drawing.Point(101, 325);
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
            this.btnDividir.Location = new System.Drawing.Point(578, 293);
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
            this.btnMover.Location = new System.Drawing.Point(578, 343);
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
            this.btnPC2.Location = new System.Drawing.Point(578, 394);
            this.btnPC2.Name = "btnPC2";
            this.btnPC2.NoRounding = false;
            this.btnPC2.Size = new System.Drawing.Size(109, 32);
            this.btnPC2.TabIndex = 6;
            this.btnPC2.Text = "PC-2";
            this.btnPC2.Transparent = false;
            this.btnPC2.Click += new System.EventHandler(this.btnPC2_Click);
            // 
            // btnPC1
            // 
            this.btnPC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPC1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnPC1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPC1.Image = null;
            this.btnPC1.Location = new System.Drawing.Point(578, 246);
            this.btnPC1.Name = "btnPC1";
            this.btnPC1.NoRounding = false;
            this.btnPC1.Size = new System.Drawing.Size(109, 32);
            this.btnPC1.TabIndex = 7;
            this.btnPC1.Text = "PC-1";
            this.btnPC1.Transparent = false;
            this.btnPC1.Click += new System.EventHandler(this.btnPC1_Click);
            // 
            // btnIP
            // 
            this.btnIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIP.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIP.Image = null;
            this.btnIP.Location = new System.Drawing.Point(146, 363);
            this.btnIP.Name = "btnIP";
            this.btnIP.NoRounding = false;
            this.btnIP.Size = new System.Drawing.Size(109, 32);
            this.btnIP.TabIndex = 8;
            this.btnIP.Text = "IP";
            this.btnIP.Transparent = false;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnDividirLR
            // 
            this.btnDividirLR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividirLR.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnDividirLR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDividirLR.Image = null;
            this.btnDividirLR.Location = new System.Drawing.Point(146, 413);
            this.btnDividirLR.Name = "btnDividirLR";
            this.btnDividirLR.NoRounding = false;
            this.btnDividirLR.Size = new System.Drawing.Size(109, 32);
            this.btnDividirLR.TabIndex = 9;
            this.btnDividirLR.Text = "Dividir LR";
            this.btnDividirLR.Transparent = false;
            this.btnDividirLR.Click += new System.EventHandler(this.btnDividirLR_Click);
            // 
            // btnExpansao
            // 
            this.btnExpansao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpansao.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnExpansao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExpansao.Image = null;
            this.btnExpansao.Location = new System.Drawing.Point(146, 464);
            this.btnExpansao.Name = "btnExpansao";
            this.btnExpansao.NoRounding = false;
            this.btnExpansao.Size = new System.Drawing.Size(109, 32);
            this.btnExpansao.TabIndex = 10;
            this.btnExpansao.Text = "Expansao";
            this.btnExpansao.Transparent = false;
            this.btnExpansao.Click += new System.EventHandler(this.btnExpansao_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXOR.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnXOR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXOR.Image = null;
            this.btnXOR.Location = new System.Drawing.Point(373, 325);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.NoRounding = false;
            this.btnXOR.Size = new System.Drawing.Size(109, 32);
            this.btnXOR.TabIndex = 11;
            this.btnXOR.Text = "XOR";
            this.btnXOR.Transparent = false;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnSBOX
            // 
            this.btnSBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSBOX.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnSBOX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSBOX.Image = null;
            this.btnSBOX.Location = new System.Drawing.Point(373, 375);
            this.btnSBOX.Name = "btnSBOX";
            this.btnSBOX.NoRounding = false;
            this.btnSBOX.Size = new System.Drawing.Size(109, 32);
            this.btnSBOX.TabIndex = 12;
            this.btnSBOX.Text = "S-BOX";
            this.btnSBOX.Transparent = false;
            this.btnSBOX.Click += new System.EventHandler(this.btnSBOX_Click);
            // 
            // btnP
            // 
            this.btnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP.Image = null;
            this.btnP.Location = new System.Drawing.Point(373, 427);
            this.btnP.Name = "btnP";
            this.btnP.NoRounding = false;
            this.btnP.Size = new System.Drawing.Size(109, 32);
            this.btnP.TabIndex = 13;
            this.btnP.Text = "P";
            this.btnP.Transparent = false;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnXOR_L
            // 
            this.btnXOR_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXOR_L.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnXOR_L.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXOR_L.Image = null;
            this.btnXOR_L.Location = new System.Drawing.Point(373, 465);
            this.btnXOR_L.Name = "btnXOR_L";
            this.btnXOR_L.NoRounding = false;
            this.btnXOR_L.Size = new System.Drawing.Size(109, 32);
            this.btnXOR_L.TabIndex = 14;
            this.btnXOR_L.Text = "XOR_L";
            this.btnXOR_L.Transparent = false;
            this.btnXOR_L.Click += new System.EventHandler(this.btnXOR_L_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinal.Image = null;
            this.btnFinal.Location = new System.Drawing.Point(373, 503);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.NoRounding = false;
            this.btnFinal.Size = new System.Drawing.Size(109, 32);
            this.btnFinal.TabIndex = 15;
            this.btnFinal.Text = "FINAL";
            this.btnFinal.Transparent = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // BTNcONVERTA
            // 
            this.BTNcONVERTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcONVERTA.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.BTNcONVERTA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNcONVERTA.Image = null;
            this.BTNcONVERTA.Location = new System.Drawing.Point(421, 256);
            this.BTNcONVERTA.Name = "BTNcONVERTA";
            this.BTNcONVERTA.NoRounding = false;
            this.BTNcONVERTA.Size = new System.Drawing.Size(109, 32);
            this.BTNcONVERTA.TabIndex = 16;
            this.BTNcONVERTA.Text = "CONVERTA";
            this.BTNcONVERTA.Transparent = false;
            this.BTNcONVERTA.Click += new System.EventHandler(this.BTNcONVERTA_Click);
            // 
            // CriptografiaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 577);
            this.Controls.Add(this.BTNcONVERTA);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnXOR_L);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnSBOX);
            this.Controls.Add(this.btnXOR);
            this.Controls.Add(this.btnExpansao);
            this.Controls.Add(this.btnDividirLR);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnPC1);
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
        private ReaLTaiizor.Controls.AirButton btnPC1;
        private ReaLTaiizor.Controls.AirButton btnIP;
        private ReaLTaiizor.Controls.AirButton btnDividirLR;
        private ReaLTaiizor.Controls.AirButton btnExpansao;
        private ReaLTaiizor.Controls.AirButton btnXOR;
        private ReaLTaiizor.Controls.AirButton btnSBOX;
        private ReaLTaiizor.Controls.AirButton btnP;
        private ReaLTaiizor.Controls.AirButton btnXOR_L;
        private ReaLTaiizor.Controls.AirButton btnFinal;
        private ReaLTaiizor.Controls.AirButton BTNcONVERTA;
    }
}