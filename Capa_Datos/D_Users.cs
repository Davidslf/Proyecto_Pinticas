using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Datos
{

    public class D_Users
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);
        public DataTable D_User(E_Users obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logueo", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@clave", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        }
    }


    public class ClassDatos
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);



        public DataTable D_Listar_Clientes()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_clientes", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }


        public string D_mantenimiento_clientes(ClassEntidad obje)

        {

            string accion = "";

            SqlCommand cmd = new SqlCommand("sp_mantenimiento clientes", cn);

            cmd.CommandType = CommandType.StoredProcedure; 
            
            cmd.Parameters.AddWithValue("@identificacion", obje.identificacion);

            cmd.Parameters.AddWithValue("@nombre", obje.nombre);

            cmd.Parameters.AddWithValue("@edad", obje.edad);

            cmd.Parameters.AddWithValue("@telefono", obje.telefono); cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;

            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;

            if (cn.State == ConnectionState.Open) cn.Close();

            cn.Open();

            cmd.ExecuteNonQuery();

            accion = cmd.Parameters["@accion"].Value.ToString();

            cn.Close(); return accion;


        }

        public DataTable D_buscar_clientes(ClassEntidad obje)
        {

            SqlCommand cmd = new SqlCommand("sp_buscar_clientes", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre", obje.nombre);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }
    }

    public class ClassDatos_Empleados
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString);



        public DataTable D_Listar_Empleado()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_empleado", cn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }


        /*public string D_mantenimiento_clientes(ClassEntidad obje)

        {

            string accion = "";

            SqlCommand cmd = new SqlCommand("sp_mantenimiento clientes", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@identificacion", obje.identificacion);

            cmd.Parameters.AddWithValue("@nombre", obje.nombre);

            cmd.Parameters.AddWithValue("@edad", obje.edad);

            cmd.Parameters.AddWithValue("@telefono", obje.telefono); cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;

            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;

            if (cn.State == ConnectionState.Open) cn.Close();

            cn.Open();

            cmd.ExecuteNonQuery();

            accion = cmd.Parameters["@accion"].Value.ToString();

            cn.Close(); return accion;


        }*/

        public DataTable D_buscar_Empleado(ClassEntidad_Empleado obje)
        {

            SqlCommand cmd = new SqlCommand("sp_buscar_empleado", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombre_empleado", obje.Nombre_empleado);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;

        }
    }

}



