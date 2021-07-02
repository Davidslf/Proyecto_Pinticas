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

            if (frmLogueo.area.Trim() == "A001")

            {

                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;


                /*lblcargo.Text = "Administrador";*/


            }

            //Ventas
            else if (frmLogueo.area == "A002")
                        {
                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;
                /*lblcargo.Text = "Ventas";*/
            }
            //Compras
            else if (frmLogueo.area == "A003")
            {
                btnusuarios.Enabled = true;
                btnciudades.Enabled = true;
                btnempleados.Enabled = true;
                btncargo.Enabled = true;


                /*lblcargo.Text = "Compras";*/
            }

            /*lblnombre.Text = frmLogueo.usuario_nombre;*/
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Mantenimiento VentanaClientes = new Mantenimiento();
            AddOwnedForm(VentanaClientes);
            VentanaClientes.Show();
        }*/

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Mantenimiento());
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmEmpleados());
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }
    }
}
