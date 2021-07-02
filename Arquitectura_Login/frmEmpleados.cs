using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Nrgocio;

namespace Arquitectura_Login
{
    public partial class frmEmpleados : Form
    {

        ClassEntidad_Empleado objent = new ClassEntidad_Empleado();
        ClassEmpleados objneg = new ClassEmpleados();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {


            lblnombre.Text = frmLogueo.usuario_nombre;

        }

        

        private void txtNombreBus_TextChanged_1(object sender, EventArgs e)
        {

            if (txtNombreBus.Text != "")
            {

                objent.Nombre_empleado = txtNombreBus.Text;

                DataTable dt = new DataTable();
                dt = objneg.N_buscar_Empleados(objent);
                dataGridView1.DataSource = dt;





            }

            else

            {
                dataGridView1.DataSource = objneg.N_listar_Empleados();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
