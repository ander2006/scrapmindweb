using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using CAD;
using System.Configuration;
using System.Data.SqlClient;


namespace CAD
{
    public class CADEscrapear
    {
        static string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
        static SqlConnection con = new SqlConnection(cadena);
        static SqlCommand cmd;

        public void guardarCampos(DTOEscrapear adm)
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_Guardarcamposreg";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", adm.Cedula);
            cmd.Parameters.AddWithValue("@departamento", adm.Departamento);

            cmd.Parameters.AddWithValue("@municipio", adm.Municipio);
            cmd.Parameters.AddWithValue("@puesto", adm.Puesto);
            cmd.Parameters.AddWithValue("@dirpuesto", adm.Dirpuesto);
            cmd.Parameters.AddWithValue("@fecha", adm.Fecha);
            cmd.Parameters.AddWithValue("@mesa", adm.Mesa);


            con.Open();


            cmd.ExecuteNonQuery();
            //cerrar conexiòn
            con.Close();
            //
        }
    }
}