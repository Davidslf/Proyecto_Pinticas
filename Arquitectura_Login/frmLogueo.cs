using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Nrgocio;
using Capa_Entidad;
using System.Runtime.InteropServices;

namespace Arquitectura_Login
{
    public partial class frmLogueo : Form
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        frmPrincipal frm1 = new frmPrincipal();

        public static string usuario_nombre;
        public static string area;


        public frmLogueo()
        {
            InitializeComponent();
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        void logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txtusuario.Text;
            objeuser.clave = txtcontraseña.Text;
            dt = objnuser.N_user(objeuser);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido al Sistema " + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                frm1.ShowDialog();

                frmLogueo login = new frmLogueo();
                //login. ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new frmPrincipal());
                txtusuario.Clear();
                txtcontraseña.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta" + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {

                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;

            }
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {


                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }

        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "CONTRASEÑA")
            {


                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {

                txtcontraseña.Text = "CONTRASEÑA";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            logueo();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

    }
}
