namespace Condor_Viajero
{
    partial class Frm_CrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CrearCuenta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Condor = new System.Windows.Forms.PictureBox();
            this.LbLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_CrearCuenta_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CrearCuenta_Correo = new System.Windows.Forms.TextBox();
            this.Txt_CrearCuenta_Contra = new System.Windows.Forms.TextBox();
            this.Btn_Login_Acceder = new System.Windows.Forms.Button();
            this.BtnCrearCuentaClose = new System.Windows.Forms.PictureBox();
            this.Link_CrearCuenta_Regresar = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Condor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCuentaClose)).BeginInit();
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
            // Condor
            // 
            this.Condor.Image = global::Condor_Viajero.Properties.Resources.CondorLogo__1_;
            this.Condor.Location = new System.Drawing.Point(-35, 87);
            this.Condor.Name = "Condor";
            this.Condor.Size = new System.Drawing.Size(271, 270);
            this.Condor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Condor.TabIndex = 2;
            this.Condor.TabStop = false;
            // 
            // LbLogin
            // 
            this.LbLogin.AutoSize = true;
            this.LbLogin.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogin.ForeColor = System.Drawing.Color.White;
            this.LbLogin.Location = new System.Drawing.Point(297, 9);
            this.LbLogin.Name = "LbLogin";
            this.LbLogin.Size = new System.Drawing.Size(238, 37);
            this.LbLogin.TabIndex = 2;
            this.LbLogin.Text = "CREAR CUENTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(242, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuario";
            // 
            // Txt_CrearCuenta_Usuario
            // 
            this.Txt_CrearCuenta_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_CrearCuenta_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CrearCuenta_Usuario.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CrearCuenta_Usuario.ForeColor = System.Drawing.Color.White;
            this.Txt_CrearCuenta_Usuario.Location = new System.Drawing.Point(242, 177);
            this.Txt_CrearCuenta_Usuario.Name = "Txt_CrearCuenta_Usuario";
            this.Txt_CrearCuenta_Usuario.Size = new System.Drawing.Size(411, 20);
            this.Txt_CrearCuenta_Usuario.TabIndex = 10;
            this.Txt_CrearCuenta_Usuario.Tag = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Correo Electronico";
            // 
            // Txt_CrearCuenta_Correo
            // 
            this.Txt_CrearCuenta_Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_CrearCuenta_Correo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CrearCuenta_Correo.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CrearCuenta_Correo.ForeColor = System.Drawing.Color.White;
            this.Txt_CrearCuenta_Correo.Location = new System.Drawing.Point(242, 104);
            this.Txt_CrearCuenta_Correo.Name = "Txt_CrearCuenta_Correo";
            this.Txt_CrearCuenta_Correo.Size = new System.Drawing.Size(411, 20);
            this.Txt_CrearCuenta_Correo.TabIndex = 13;
            this.Txt_CrearCuenta_Correo.Tag = "Usuario";
            // 
            // Txt_CrearCuenta_Contra
            // 
            this.Txt_CrearCuenta_Contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_CrearCuenta_Contra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_CrearCuenta_Contra.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CrearCuenta_Contra.ForeColor = System.Drawing.Color.White;
            this.Txt_CrearCuenta_Contra.Location = new System.Drawing.Point(242, 255);
            this.Txt_CrearCuenta_Contra.Name = "Txt_CrearCuenta_Contra";
            this.Txt_CrearCuenta_Contra.Size = new System.Drawing.Size(411, 20);
            this.Txt_CrearCuenta_Contra.TabIndex = 14;
            this.Txt_CrearCuenta_Contra.Tag = "Usuario";
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
            this.Btn_Login_Acceder.Location = new System.Drawing.Point(282, 337);
            this.Btn_Login_Acceder.Name = "Btn_Login_Acceder";
            this.Btn_Login_Acceder.Size = new System.Drawing.Size(345, 40);
            this.Btn_Login_Acceder.TabIndex = 15;
            this.Btn_Login_Acceder.Text = "Crear Cuenta";
            this.Btn_Login_Acceder.UseVisualStyleBackColor = false;
            this.Btn_Login_Acceder.Click += new System.EventHandler(this.Btn_CrearCuenta_Acceder_Click);
            // 
            // BtnCrearCuentaClose
            // 
            this.BtnCrearCuentaClose.Image = global::Condor_Viajero.Properties.Resources.Cerrar;
            this.BtnCrearCuentaClose.Location = new System.Drawing.Point(660, 9);
            this.BtnCrearCuentaClose.Name = "BtnCrearCuentaClose";
            this.BtnCrearCuentaClose.Size = new System.Drawing.Size(28, 25);
            this.BtnCrearCuentaClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCrearCuentaClose.TabIndex = 16;
            this.BtnCrearCuentaClose.TabStop = false;
            this.BtnCrearCuentaClose.Click += new System.EventHandler(this.Btn_CrearCuenta_Close_Click);
            // 
            // Link_CrearCuenta_Regresar
            // 
            this.Link_CrearCuenta_Regresar.AutoSize = true;
            this.Link_CrearCuenta_Regresar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Link_CrearCuenta_Regresar.LinkColor = System.Drawing.SystemColors.Control;
            this.Link_CrearCuenta_Regresar.Location = new System.Drawing.Point(416, 394);
            this.Link_CrearCuenta_Regresar.Name = "Link_CrearCuenta_Regresar";
            this.Link_CrearCuenta_Regresar.Size = new System.Drawing.Size(67, 16);
            this.Link_CrearCuenta_Regresar.TabIndex = 17;
            this.Link_CrearCuenta_Regresar.TabStop = true;
            this.Link_CrearCuenta_Regresar.Text = "Regresar D:";
            this.Link_CrearCuenta_Regresar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_CrearCuenta_Regresar_LinkClicked);
            // 
            // Frm_CrearCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.Link_CrearCuenta_Regresar);
            this.Controls.Add(this.BtnCrearCuentaClose);
            this.Controls.Add(this.Btn_Login_Acceder);
            this.Controls.Add(this.Txt_CrearCuenta_Contra);
            this.Controls.Add(this.Txt_CrearCuenta_Correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_CrearCuenta_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLogin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_CrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CrearCuenta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Condor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCuentaClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Condor;
        private System.Windows.Forms.Label LbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_CrearCuenta_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_CrearCuenta_Correo;
        private System.Windows.Forms.TextBox Txt_CrearCuenta_Contra;
        private System.Windows.Forms.Button Btn_Login_Acceder;
        private System.Windows.Forms.PictureBox BtnCrearCuentaClose;
        private System.Windows.Forms.LinkLabel Link_CrearCuenta_Regresar;
    }
}