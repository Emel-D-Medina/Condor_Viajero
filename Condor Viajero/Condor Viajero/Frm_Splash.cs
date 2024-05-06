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
    public partial class Frm_Splash : Form
    {
        public Frm_Splash()
        {
            InitializeComponent();
        }
        private void Slpash_Load(object sender, EventArgs e)
        {
            Circulo1.Size = Circulo2.Size = Circulo3.Size = Circulo4.Size = new Size(0,0);
            timer1.Start();       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Circulo1.Size=new Size(Circulo1.Width+2,Circulo1.Height+2);
            Circulo1.Location = new Point(Circulo1.Location.X-1,Circulo1.Location.Y-1);
            if (Circulo1.Width == 24) {
                timer3.Start();
            }
            else if (Circulo1.Width == 50){
                timer1.Stop(); timer2.Start(); 
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Circulo1.Size = new Size(Circulo1.Width - 2, Circulo1.Height - 2);
            Circulo1.Location = new Point(Circulo1.Location.X + 1, Circulo1.Location.Y + 1);
            if (Circulo1.Width == 0)
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Circulo2.Size = new Size(Circulo2.Width + 2, Circulo2.Height + 2);
            Circulo2.Location = new Point(Circulo2.Location.X - 1, Circulo2.Location.Y - 1);
            if (Circulo2.Width == 24)
            {
                timer5.Start();
            }
            else if (Circulo2.Width == 50)
            {
                timer3.Stop(); timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Circulo2.Size = new Size(Circulo2.Width - 2, Circulo2.Height - 2);
            Circulo2.Location = new Point(Circulo2.Location.X + 1, Circulo2.Location.Y + 1);
            if (Circulo2.Width == 0)
            {
                timer4.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Circulo3.Size = new Size(Circulo3.Width + 2, Circulo3.Height + 2);
            Circulo3.Location = new Point(Circulo3.Location.X - 1, Circulo3.Location.Y - 1);
            if (Circulo3.Width == 24)
            {
                timer7.Start();
            }
            else if (Circulo3.Width == 50)
            {
                timer5.Stop(); timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            Circulo3.Size = new Size(Circulo3.Width - 2, Circulo3.Height - 2);
            Circulo3.Location = new Point(Circulo3.Location.X + 1, Circulo3.Location.Y + 1);
            if (Circulo3.Width == 0)
            {
                timer6.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Circulo4.Size = new Size(Circulo4.Width + 2, Circulo4.Height + 2);
            Circulo4.Location = new Point(Circulo4.Location.X - 1, Circulo4.Location.Y - 1);
            if (Circulo4.Width == 50)
            {
                timer7.Stop(); timer8.Start(); ;
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            Circulo4.Size = new Size(Circulo4.Width - 2, Circulo4.Height - 2);
            Circulo4.Location = new Point(Circulo4.Location.X + 1, Circulo4.Location.Y + 1);
            if (Circulo4.Width == 0)
            {
                timer8.Stop();
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); timer2.Stop(); timer3.Stop(); timer4.Stop(); timer5.Stop(); timer6.Stop(); timer7.Stop(); timer9.Stop();
            FrmLogin login = new FrmLogin();
            login.Visible = true;
            this.Hide();
        }
    }
}
