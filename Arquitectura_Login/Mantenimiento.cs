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
    public partial class Mantenimiento : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        
        void mantenimiento(string accion)
        {

            objent.identificacion = txtIdentificación.Text;

            objent.nombre = txtNombre.Text;
            objent.edad = Convert.ToInt32(txtEdad.Text);
            objent.telefono = Convert.ToInt32(txtTelefono.Text);

            objent.accion = accion;
            string men = objneg.N_mantenimientoclientes(objent);

            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        void limpiar()
        {

            txtIdentificación.Text = "";

            txtNombre.Text = "";

            txtEdad.Text = "";

            txtTelefono.Text = "";

            txtNombreBus.Text = "";

            dataGridView1.DataSource = objneg.N_listar_clientes();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txtIdentificación.Text = dataGridView1[0, fila].Value.ToString();
            txtNombre.Text = dataGridView1[1, fila].Value.ToString();
            txtEdad.Text = dataGridView1[2, fila].Value.ToString();
            txtTelefono.Text = dataGridView1[3, fila].Value.ToString();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtIdentificación.Text != "")

            {

                if (MessageBox.Show("¿Deseas modificar a " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)

                {

                    mantenimiento("2");

                    limpiar();

                }
            }

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtIdentificación.Text != "")

                if (MessageBox.Show("¿Deseas registrar a " + txtNombre.Text + " ? ", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    {

                        mantenimiento("1");

                        limpiar();
                    }

                }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtIdentificación.Text != "")

            {

                if (MessageBox.Show("¿Deseas eliminar a " + txtNombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)

                {

                    mantenimiento("3");

                    limpiar();

                }
            }

        }

        private void txtNombreBus_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreBus.Text != "")
            {

                objent.nombre = txtNombreBus.Text;

                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;





            }

            else

            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }
    }

}
