using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condor_Viajero
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Btn_Login_Acceder_Click(object sender, EventArgs e)
        {
            String Usuario = "admin";
            String Contra = "123";
            if(Validar_Datos(Usuario, Contra).Equals(true))
            {
                Frm_Mapa mapa = new Frm_Mapa();
                mapa.Visible = true;
                this.Close();
            }

            
        }
        private bool Validar_Datos(String Usuario, String Contra) {

            if ((TxtUsuario.Text.Equals(Usuario)) && (TxtContraseña.Text.Equals(Contra)))
            {
                
                return true;
            }
            else if ((TxtUsuario.Text.Equals("")) || (TxtContraseña.Text.Equals("")))
            {
                MessageBox.Show("No hay datos");
                return false;
            }
            else
            {
                MessageBox.Show("datos incorrectos");
                return false;

            }


        }

        private void BtnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_CrearCuenta crear = new Frm_CrearCuenta();
            crear.Visible = true;
            this.Close();
        }

        private void Link_Login_OlvidaContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_RecuperarContra recuperar = new Frm_RecuperarContra();
            recuperar.Visible = true;
            this.Close();
        }
    }
}
