using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;
using System.Data;


namespace Capa_Nrgocio
{
    public class N_Users
    {

        D_Users objd = new D_Users();


        public DataTable N_user(E_Users obje)
        {
            return objd.D_User(obje);
        }


    }
    public class ClassNegocio
    {
        ClassDatos objd = new  ClassDatos();



        public DataTable N_listar_clientes()
        {

            return objd.D_Listar_Clientes();

        }

        public DataTable N_buscar_clientes(ClassEntidad obje)

        {

            return objd.D_buscar_clientes(obje);

        }

        public string N_mantenimientoclientes(ClassEntidad obje)

        {

            return objd.D_mantenimiento_clientes(obje);
        }

    }

    public class ClassEmpleados
    {
        ClassDatos_Empleados objd = new ClassDatos_Empleados();



        public DataTable N_listar_Empleados()
        {

            return objd.D_Listar_Empleado();

        }

        public DataTable N_buscar_Empleados(ClassEntidad_Empleado obje)

        {

            return objd.D_buscar_Empleado(obje);

        }

        /*public string N_mantenimientoEmpleados(ClassEntidad obje)

        {

            return objd.D_mantenimiento_clientes(obje);
        }*/

    }
}
