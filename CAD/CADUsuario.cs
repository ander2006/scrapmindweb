using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CAD
{
    public class CADUsuario
    {
        static string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
        static SqlConnection con = new SqlConnection(cadena);
        static SqlCommand cmd;

        public DataTable autenticarUsuario(DTOUsuario user)
        {
            cmd = new SqlCommand();
            DataTable dt;
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "prc_AutenticarUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", user.Usuario);
                cmd.Parameters.AddWithValue("@contrasena", user.Clave);
                dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                // ejecuta el procedimiento y guarde los resultados de la consulta en la tabla virtual osea el datatable
                con.Open();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception error)
            {
                dt = null;
            }
            return dt;
        }
        public void ingresarUsuario(DTOUsuario user)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_InsertarUsuario";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", user.Cedula);
            cmd.Parameters.AddWithValue("@usuario", user.Usuario);
            cmd.Parameters.AddWithValue("@contrasena", user.Clave);
            cmd.Parameters.AddWithValue("@administrador", user.Administrador);
            cmd.Parameters.AddWithValue("@operativo", user.Operativo);



            con.Open();


            cmd.ExecuteNonQuery();
            //cerrar conexiòn
            con.Close();
            //

        }
        public void Buscar_usuario(DTOUsuario user)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_BuscarUsuario";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", "1035417284");
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                user.Usuario = sdr["usuario"].ToString();
                user.Clave = sdr["contrasena"].ToString();

            }

            //cerrar conexiòn
            con.Close();
            //  

        }

        public void EditarUsuario(DTOUsuario user)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prcActualizarPersona";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", user.Cedula);
            cmd.Parameters.AddWithValue("@usuario", user.Usuario);
            cmd.Parameters.AddWithValue("@contrasena", user.Clave);
            cmd.Parameters.AddWithValue("@administrador", user.Administrador);
            cmd.Parameters.AddWithValue("@operativo", user.Operativo);



            con.Open();


            cmd.ExecuteNonQuery();
            //cerrar conexiòn
            con.Close();
            //

        }

    }


}




