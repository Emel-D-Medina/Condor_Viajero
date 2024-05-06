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
    public partial class Frm_CrearCuenta : Form
    {
        public Frm_CrearCuenta()
        {
            InitializeComponent();
        }

        private void Btn_CrearCuenta_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            
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

           
             if ((Txt_CrearCuenta_Usuario.Text.Equals("")) && (Txt_CrearCuenta_Contra.Text.Equals("")) && (Txt_CrearCuenta_Correo.Text.Equals("")))
            {
                MessageBox.Show("No hay datos");
                return false;
            }
            else
            {
                MessageBox.Show("Usuario Creado");
                return true;

            }


        }
    }
}
