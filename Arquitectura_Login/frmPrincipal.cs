using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arquitectura_Login
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

      

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //admin

            if (frmLogin.area.Trim() == "A001")

            {

                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;


                lblcargo.Text = "Administrador";


            }

            //Ventas
            else if (frmLogin.area == "A002")
                        {
                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;
                lblcargo.Text = "Ventas";
            }
            //Compras
            else if (frmLogin.area == "A003")
            {
                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;


                lblcargo.Text = "Compras";
            }

            lblnombre.Text = frmLogin.usuario_nombre;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
