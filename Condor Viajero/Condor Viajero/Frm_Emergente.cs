using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condor_Viajero
{
    public partial class Frm_Emergente : Form
    {
        public string info;
        public Frm_Emergente()
        {
            InitializeComponent();
        }

        private void Frm_Emergente_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            info = txtNombre.Text;
            this.Close();
        }
    }
}
