namespace Condor_Viajero
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbLogin = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.Btn_Login_Acceder = new System.Windows.Forms.Button();
            this.Link_Login_OlvidaContra = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Link_Logic_CrearCuenta = new System.Windows.Forms.LinkLabel();
            this.BtnLoginClose = new System.Windows.Forms.PictureBox();
            this.Condor = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLoginClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Condor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Condor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.White;
            this.LbLogin.Location = new System.Drawing.Point(402, 9);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(137, 44);
            this.LbLogin.TabIndex = 1;
            this.LbLogin.Text = "LOGIN";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.White;
            this.TxtUsuario.Location = new System.Drawing.Point(247, 118);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(411, 23);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.Tag = "Usuario";
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtContraseña.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContraseña.ForeColor = System.Drawing.Color.White;
            this.TxtContraseña.Location = new System.Drawing.Point(247, 222);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(411, 23);
            this.TxtContraseña.TabIndex = 3;
            // 
            // Btn_Login_Acceder
            // 
            this.Btn_Login_Acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Login_Acceder.FlatAppearance.BorderSize = 0;
            this.Btn_Login_Acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Login_Acceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Login_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Login_Acceder.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login_Acceder.ForeColor = System.Drawing.Color.Silver;
            this.Btn_Login_Acceder.Location = new System.Drawing.Point(285, 311);
            this.Btn_Login_Acceder.Name = "Btn_Login_Acceder";
            this.Btn_Login_Acceder.Size = new System.Drawing.Size(345, 40);
            this.Btn_Login_Acceder.TabIndex = 4;
            this.Btn_Login_Acceder.Text = "Acceder";
            this.Btn_Login_Acceder.UseVisualStyleBackColor = false;
            this.Btn_Login_Acceder.Click += new System.EventHandler(this.Btn_Login_Acceder_Click);
            // 
            // Link_Login_OlvidaContra
            // 
            this.Link_Login_OlvidaContra.AutoSize = true;
            this.Link_Login_OlvidaContra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Login_OlvidaContra.LinkColor = System.Drawing.SystemColors.Control;
            this.Link_Login_OlvidaContra.Location = new System.Drawing.Point(373, 400);
            this.Link_Login_OlvidaContra.Name = "Link_Login_OlvidaContra";
            this.Link_Login_OlvidaContra.Size = new System.Drawing.Size(178, 17);
            this.Link_Login_OlvidaContra.TabIndex = 5;
            this.Link_Login_OlvidaContra.TabStop = true;
            this.Link_Login_OlvidaContra.Text = "¿Olvidaste la contraseña?";
            this.Link_Login_OlvidaContra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Login_OlvidaContra_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(247, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // Link_Logic_CrearCuenta
            // 
            this.Link_Logic_CrearCuenta.AutoSize = true;
            this.Link_Logic_CrearCuenta.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_Logic_CrearCuenta.LinkColor = System.Drawing.SystemColors.Control;
            this.Link_Logic_CrearCuenta.Location = new System.Drawing.Point(407, 369);
            this.Link_Logic_CrearCuenta.Name = "Link_Logic_CrearCuenta";
            this.Link_Logic_CrearCuenta.Size = new System.Drawing.Size(115, 17);
            this.Link_Logic_CrearCuenta.TabIndex = 9;
            this.Link_Logic_CrearCuenta.TabStop = true;
            this.Link_Logic_CrearCuenta.Text = "Crear Cuenta :D";
            this.Link_Logic_CrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCrearCuenta_LinkClicked);
            // 
            // BtnLoginClose
            // 
            this.BtnLoginClose.Image = global::Condor_Viajero.Properties.Resources.Cerrar;
            this.BtnLoginClose.Location = new System.Drawing.Point(660, 9);
            this.BtnLoginClose.Name = "BtnLoginClose";
            this.BtnLoginClose.Size = new System.Drawing.Size(28, 25);
            this.BtnLoginClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLoginClose.TabIndex = 6;
            this.BtnLoginClose.TabStop = false;
            this.BtnLoginClose.Click += new System.EventHandler(this.BtnLoginClose_Click);
            // 
            // Condor
            // 
            this.Condor.Image = global::Condor_Viajero.Properties.Resources.CondorLogo;
            this.Condor.Location = new System.Drawing.Point(-30, 83);
            this.Condor.Name = "Condor";
            this.Condor.Size = new System.Drawing.Size(271, 270);
            this.Condor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Condor.TabIndex = 1;
            this.Condor.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.Link_Logic_CrearCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLoginClose);
            this.Controls.Add(this.Link_Login_OlvidaContra);
            this.Controls.Add(this.Btn_Login_Acceder);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLoginClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Condor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Condor;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button Btn_Login_Acceder;
        private System.Windows.Forms.LinkLabel Link_Login_OlvidaContra;
        private System.Windows.Forms.PictureBox BtnLoginClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel Link_Logic_CrearCuenta;
    }
}