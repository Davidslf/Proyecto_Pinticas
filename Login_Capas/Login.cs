using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Capa_Entidad;
using Capa_Nrgocio;



namespace Login_Capas
{

    public partial class Login : Form
    {

        E_Users objeuser = new E_Users();
        N_Users objnuser = new N_Users();
        Principal frm1 = new Principal();

        public static string usuario_nombre;
        private Button button1;
        private TextBox textcontraseña;
        private TextBox textusuario;
        private Label label3;
        private Label label2;
        private Label label1;
        public static string area;



        void logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = textusuario.Text;
            objeuser.clave = textcontraseña.Text;
            dt = objnuser.N_user(objeuser);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido al Sistema" + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][1].ToString();
                area = dt.Rows[0][0].ToString();

                frm1.Showbialog();

                Login login = new Login();
                //login. ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Principal());
                textusuario.Clear();
                textcontraseña.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta" + dt.Rows[0][1].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textcontraseña = new System.Windows.Forms.TextBox();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(288, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textcontraseña
            // 
            this.textcontraseña.Location = new System.Drawing.Point(215, 242);
            this.textcontraseña.Name = "textcontraseña";
            this.textcontraseña.Size = new System.Drawing.Size(228, 20);
            this.textcontraseña.TabIndex = 11;
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(215, 151);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(228, 20);
            this.textusuario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 52);
            this.label1.TabIndex = 7;
            this.label1.Text = "LOGUEO";
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(637, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textcontraseña);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logueo();
        }
    }


}
