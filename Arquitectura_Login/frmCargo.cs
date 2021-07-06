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
    
    public partial class frmCargo : Form  
    {
        E_cargo objent = new E_cargo();
        ClassCargo objneg = new ClassCargo();
        public frmCargo()
        {
            InitializeComponent();
        }

        void mantenimiento(string accion)
        {

            objent.Id_cargo = txt_IdCargo.Text;

            objent.Nombre_Cargo = txt_Nombre.Text;
            objent.Salario = txt_Salario.Text;
            

            objent.accion = accion;
            string men = objneg.N_mantenimiento_cargos(objent);

            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void limpiar()
        {

            txt_IdCargo.Text = "";

            txt_Nombre.Text = "";

            txt_Salario.Text = "";

            txtbus_car.Text = "";

            dataGridView1.DataSource = objneg.N_listar_cargo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            txt_IdCargo.Text = dataGridView1[0, fila].Value.ToString();
            txt_Nombre.Text = dataGridView1[1, fila].Value.ToString();
            txt_Salario.Text = dataGridView1[2, fila].Value.ToString();
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_IdCargo.Text != "")

            {

                if (MessageBox.Show("¿Deseas modificar a " + txt_Nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)

                {

                    mantenimiento("2");

                    limpiar();

                }
            }
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txt_IdCargo.Text != "")

                if (MessageBox.Show("¿Deseas registrar a " + txt_Nombre.Text + " ? ", "Mensaje",
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
            if (txt_IdCargo.Text != "")

            {

                if (MessageBox.Show("¿Deseas eliminar a " + txt_Nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)

                {

                    mantenimiento("3");

                    limpiar();

                }
            }
        }

        private void txtbus_car_TextChanged(object sender, EventArgs e)
        {
            if (txtbus_car.Text != "")
            {

                objent.Nombre_Cargo = txtbus_car.Text;

                DataTable dt = new DataTable();
                dt = objneg.N_buscar_cargo(objent);
                dataGridView1.DataSource = dt;





            }

            else

            {
                dataGridView1.DataSource = objneg.N_listar_cargo();
            }
        }
    }
}
