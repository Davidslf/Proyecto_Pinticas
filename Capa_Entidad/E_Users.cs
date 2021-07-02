using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{


    public class E_Users
    {

        public string usuario { get; set; }

        public string clave { get; set; }
    }




    public class ClassEntidad
    {


        public String nombre { get; set; }



        public String identificacion { get; set; }



        public int edad { get; set; }



        public int telefono { get; set; }



        public String accion { get; set; }

    }

    public class ClassEntidad_Empleado
    {


        public int Id_empleado { get; set; }



        public String Nombre_empleado { get; set; }



        public String Apellido_empleado { get; set; }



        public int Id_cargo_empleado { get; set; }



        public String Id_ciudad_empleado { get; set; }


        public String Direccion_empleado { get; set; }


        public int Telefono_empleado { get; set; }


    }

}