using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Capas
{

    private void Principal Load(object sender, EventArgs e)
    {

        //admin

        if (Login.area == "A001")

        {

            btnalmacen.Enabled = true;
            btncompras.Enabled = true;
            btnventas.Enabled = true;

            lblcargo.Text = "Administrador";


        }

        //Ventas
        else if (Login.area == "A002”)
                    {
            btnalmacen.Enabled = false;
            btncompras.Enabled = false;
            btnventas.Enabled = true;
            lblcargo.Text = "Ventas";
        }
        //Compras
        else if (Login.area == "A003")
        {
            btnalmacen.Enabled = false;
            btncompras.Enabled = true;
            btnventas.Enabled = false;


            lblcargo.Text = "Compras";
        }

        lblnombre.Text = Login.usuario_nombre;
        timer1.Start();


    }
}

