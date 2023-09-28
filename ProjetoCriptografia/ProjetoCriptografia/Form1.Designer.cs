namespace ProjetoCriptografia
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.sidebarMenu = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCesar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.sidebarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sidebar.Controls.Add(this.sidebarMenu);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(317, 787);
            this.sidebar.MinimumSize = new System.Drawing.Size(70, 787);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(317, 787);
            this.sidebar.TabIndex = 1;
            // 
            // sidebarMenu
            // 
            this.sidebarMenu.Controls.Add(this.menuButton);
            this.sidebarMenu.Controls.Add(this.dungeonHeaderLabel1);
            this.sidebarMenu.Location = new System.Drawing.Point(3, 3);
            this.sidebarMenu.Name = "sidebarMenu";
            this.sidebarMenu.Size = new System.Drawing.Size(570, 138);
            this.sidebarMenu.TabIndex = 5;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(16, 57);
            this.menuButton.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(42, 31);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 1;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.Turquoise;
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(64, 60);
            this.dungeonHeaderLabel1.Margin = new System.Windows.Forms.Padding(3, 33, 3, 30);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(146, 25);
            this.dungeonHeaderLabel1.TabIndex = 1;
            this.dungeonHeaderLabel1.Text = "CRIPTOGRAFIA";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(3, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 52);
            this.panel3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Turquoise;
            this.button4.Location = new System.Drawing.Point(-3, -29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(573, 109);
            this.button4.TabIndex = 0;
            this.button4.Text = "            DES";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCesar);
            this.panel2.Location = new System.Drawing.Point(3, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 52);
            this.panel2.TabIndex = 7;
            // 
            // btnCesar
            // 
            this.btnCesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCesar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCesar.ForeColor = System.Drawing.Color.Turquoise;
            this.btnCesar.Location = new System.Drawing.Point(-3, -29);
            this.btnCesar.Name = "btnCesar";
            this.btnCesar.Size = new System.Drawing.Size(573, 109);
            this.btnCesar.TabIndex = 0;
            this.btnCesar.Text = "            CIFRA DE CESAR";
            this.btnCesar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCesar.UseVisualStyleBackColor = true;
            this.btnCesar.Click += new System.EventHandler(this.btnCesar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Location = new System.Drawing.Point(3, 263);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(561, 52);
            this.panel4.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(-3, -29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(573, 109);
            this.button2.TabIndex = 0;
            this.button2.Text = "            SUBSTITUIÇÃO";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.Location = new System.Drawing.Point(59, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1304, 779);
            this.mainpanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(511, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1363, 767);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.sidebar.ResumeLayout(false);
            this.sidebarMenu.ResumeLayout(false);
            this.sidebarMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.Panel sidebarMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCesar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

