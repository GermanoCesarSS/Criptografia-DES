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
            this.btnGerarChave = new System.Windows.Forms.Button();
            this.bntBlocoTexto = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnPC2 = new System.Windows.Forms.Button();
            this.btnPC1 = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnDividirLR = new System.Windows.Forms.Button();
            this.btnExpansao = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnSBOX = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnXOR_L = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.BTNcONVERTA = new System.Windows.Forms.Button();
            this.btnDES = new ReaLTaiizor.Controls.Button();
            this.txtTexto = new ReaLTaiizor.Controls.TextBoxEdit();
            this.txtChave = new ReaLTaiizor.Controls.TextBoxEdit();
            this.label1 = new ReaLTaiizor.Controls.BigLabel();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtTextoCrip = new ReaLTaiizor.Controls.TextBoxEdit();
            this.SuspendLayout();
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
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDividir.Location = new System.Drawing.Point(578, 293);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(109, 32);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "DividirTexto";
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMover
            // 
            this.btnMover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMover.Location = new System.Drawing.Point(578, 343);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(109, 32);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = "MoverTexto";
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnPC2
            // 
            this.btnPC2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPC2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPC2.Location = new System.Drawing.Point(578, 394);
            this.btnPC2.Name = "btnPC2";
            this.btnPC2.Size = new System.Drawing.Size(109, 32);
            this.btnPC2.TabIndex = 6;
            this.btnPC2.Text = "PC-2";
            this.btnPC2.Click += new System.EventHandler(this.btnPC2_Click);
            // 
            // btnPC1
            // 
            this.btnPC1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPC1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPC1.Location = new System.Drawing.Point(578, 246);
            this.btnPC1.Name = "btnPC1";
            this.btnPC1.Size = new System.Drawing.Size(109, 32);
            this.btnPC1.TabIndex = 7;
            this.btnPC1.Text = "PC-1";
            this.btnPC1.Click += new System.EventHandler(this.btnPC1_Click);
            // 
            // btnIP
            // 
            this.btnIP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIP.Location = new System.Drawing.Point(146, 363);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(109, 32);
            this.btnIP.TabIndex = 8;
            this.btnIP.Text = "IP";
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnDividirLR
            // 
            this.btnDividirLR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividirLR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDividirLR.Location = new System.Drawing.Point(146, 413);
            this.btnDividirLR.Name = "btnDividirLR";
            this.btnDividirLR.Size = new System.Drawing.Size(109, 32);
            this.btnDividirLR.TabIndex = 9;
            this.btnDividirLR.Text = "Dividir LR";
            this.btnDividirLR.Click += new System.EventHandler(this.btnDividirLR_Click);
            // 
            // btnExpansao
            // 
            this.btnExpansao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpansao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExpansao.Location = new System.Drawing.Point(146, 464);
            this.btnExpansao.Name = "btnExpansao";
            this.btnExpansao.Size = new System.Drawing.Size(109, 32);
            this.btnExpansao.TabIndex = 10;
            this.btnExpansao.Text = "Expansao";
            this.btnExpansao.Click += new System.EventHandler(this.btnExpansao_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXOR.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXOR.Location = new System.Drawing.Point(373, 325);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(109, 32);
            this.btnXOR.TabIndex = 11;
            this.btnXOR.Text = "XOR";
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnSBOX
            // 
            this.btnSBOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSBOX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSBOX.Location = new System.Drawing.Point(373, 375);
            this.btnSBOX.Name = "btnSBOX";
            this.btnSBOX.Size = new System.Drawing.Size(109, 32);
            this.btnSBOX.TabIndex = 12;
            this.btnSBOX.Text = "S-BOX";
            this.btnSBOX.Click += new System.EventHandler(this.btnSBOX_Click);
            // 
            // btnP
            // 
            this.btnP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP.Location = new System.Drawing.Point(373, 427);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(109, 32);
            this.btnP.TabIndex = 13;
            this.btnP.Text = "P";
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnXOR_L
            // 
            this.btnXOR_L.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXOR_L.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXOR_L.Location = new System.Drawing.Point(373, 465);
            this.btnXOR_L.Name = "btnXOR_L";
            this.btnXOR_L.Size = new System.Drawing.Size(109, 32);
            this.btnXOR_L.TabIndex = 14;
            this.btnXOR_L.Text = "XOR_L";
            this.btnXOR_L.Click += new System.EventHandler(this.btnXOR_L_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFinal.Location = new System.Drawing.Point(373, 503);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(109, 32);
            this.btnFinal.TabIndex = 15;
            this.btnFinal.Text = "FINAL";
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // BTNcONVERTA
            // 
            this.BTNcONVERTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcONVERTA.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNcONVERTA.Location = new System.Drawing.Point(421, 256);
            this.BTNcONVERTA.Name = "BTNcONVERTA";
            this.BTNcONVERTA.Size = new System.Drawing.Size(109, 32);
            this.BTNcONVERTA.TabIndex = 16;
            this.BTNcONVERTA.Text = "CONVERTA";
            this.BTNcONVERTA.Click += new System.EventHandler(this.BTNcONVERTA_Click);
            // 
            // btnDES
            // 
            this.btnDES.BackColor = System.Drawing.Color.Transparent;
            this.btnDES.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDES.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDES.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDES.Image = null;
            this.btnDES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDES.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnDES.Location = new System.Drawing.Point(157, 157);
            this.btnDES.Name = "btnDES";
            this.btnDES.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDES.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.btnDES.Size = new System.Drawing.Size(158, 40);
            this.btnDES.TabIndex = 19;
            this.btnDES.Text = "Criptogravar";
            this.btnDES.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.Transparent;
            this.txtTexto.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtTexto.Image = null;
            this.txtTexto.Location = new System.Drawing.Point(14, 53);
            this.txtTexto.MaxLength = 32767;
            this.txtTexto.Multiline = false;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ReadOnly = false;
            this.txtTexto.Size = new System.Drawing.Size(201, 46);
            this.txtTexto.TabIndex = 20;
            this.txtTexto.Text = "Texto...";
            this.txtTexto.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTexto.UseSystemPasswordChar = false;
            // 
            // txtChave
            // 
            this.txtChave.BackColor = System.Drawing.Color.Transparent;
            this.txtChave.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtChave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtChave.Image = null;
            this.txtChave.Location = new System.Drawing.Point(265, 53);
            this.txtChave.MaxLength = 32767;
            this.txtChave.Multiline = false;
            this.txtChave.Name = "txtChave";
            this.txtChave.ReadOnly = false;
            this.txtChave.Size = new System.Drawing.Size(201, 46);
            this.txtChave.TabIndex = 21;
            this.txtChave.Text = "Chave...";
            this.txtChave.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChave.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(95, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Location = new System.Drawing.Point(172, 120);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 23;
            this.button1.Text = "Gerar Chave";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.Turquoise;
            this.bigLabel1.Location = new System.Drawing.Point(10, 174);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(79, 23);
            this.bigLabel1.TabIndex = 24;
            this.bigLabel1.Text = "Rodadas:";
            // 
            // txtTextoCrip
            // 
            this.txtTextoCrip.BackColor = System.Drawing.Color.Transparent;
            this.txtTextoCrip.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTextoCrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.txtTextoCrip.Image = null;
            this.txtTextoCrip.Location = new System.Drawing.Point(115, 222);
            this.txtTextoCrip.MaxLength = 32767;
            this.txtTextoCrip.Multiline = false;
            this.txtTextoCrip.Name = "txtTextoCrip";
            this.txtTextoCrip.ReadOnly = false;
            this.txtTextoCrip.Size = new System.Drawing.Size(235, 46);
            this.txtTextoCrip.TabIndex = 25;
            this.txtTextoCrip.Text = "Texto criptografado...";
            this.txtTextoCrip.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTextoCrip.UseSystemPasswordChar = false;
            // 
            // CriptografiaDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1304, 779);
            this.Controls.Add(this.txtTextoCrip);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnDES);
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
            this.Controls.Add(this.btnGerarChave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriptografiaDES";
            this.Text = "CriptografiaDES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGerarChave;
        private System.Windows.Forms.Button bntBlocoTexto;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnPC2;
        private System.Windows.Forms.Button btnPC1;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnDividirLR;
        private System.Windows.Forms.Button btnExpansao;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnSBOX;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnXOR_L;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button BTNcONVERTA;
        private ReaLTaiizor.Controls.Button btnDES;
        private ReaLTaiizor.Controls.TextBoxEdit txtTexto;
        private ReaLTaiizor.Controls.TextBoxEdit txtChave;
        private ReaLTaiizor.Controls.BigLabel label1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.TextBoxEdit txtTextoCrip;
    }
}