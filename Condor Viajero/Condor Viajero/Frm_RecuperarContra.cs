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
    public partial class Frm_RecuperarContra : Form
    {
        public Frm_RecuperarContra()
        {
            InitializeComponent();
        }

        private void Btn_CrearCuenta_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Btn_CrearCuenta_Acceder_Click(object sender, EventArgs e)
        {
           
            if (Validar_Datos().Equals(true))
            {
                FrmLogin logic = new FrmLogin();
                logic.Visible = true;
                this.Close();
            }
        }

        private void Link_CrearCuenta_Regresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin logic = new FrmLogin();
            logic.Visible = true;
            this.Close();
        }
        private bool Validar_Datos()
        {

           
             if ((Txt_Recuperar_Usuario.Text.Equals("")) && (Txt_RecuperarContra_Correo.Text.Equals("")))
            {
                MessageBox.Show("No hay datos");
                return false;
            }
            else
            {
                MessageBox.Show("Contraseña enviada al correo");
                return true;

            }


        }
    }
}
