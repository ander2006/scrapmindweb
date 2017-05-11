using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CAD;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace LoginWeb
{
    public partial class Usuarios : System.Web.UI.Page
    {
        static string cadena = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
        SqlConnection con = new SqlConnection(cadena);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            DTOUsuario adm = new DTOUsuario();
            adm.Cedula = txtCedula.Text;
            adm.Usuario = txtUsuario.Text;
            adm.Clave = txtContrasena.Text;

            int valorA;

            if (RadioAdministrador.Checked == true)
            {
                valorA = 1;
            }
            else
            {
                valorA = 0;
            }
            adm.Administrador = valorA;
            int valorP;

            if (Radiooperativo.Checked == true)
            {
                valorP = 1;
            }
            else
            {
                valorP = 0;
            }
            adm.Operativo = valorP;



            CADUsuario datocamp = new CADUsuario();
            datocamp.ingresarUsuario(adm);
            cargarUsuarios();
            txtCedula.Text = "";
            txtContrasena.Text = "";
            txtUsuario.Text = "";
            RadioAdministrador.Checked = false;
            Radiooperativo.Checked = false;

            gvusuarios.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e) // Busca por cedula
        {
            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_BuscarUsuario";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                txtUsuario.Text = sdr["usuario"].ToString();
                txtContrasena.Text = sdr["contrasena"].ToString();
                string administrador = sdr["administrador"].ToString();
                int Administrador2 = Convert.ToInt16(administrador);
                bool adm;
                if (Administrador2 == 1)
                {


                    RadioAdministrador.Checked = true;
                }


                string operativo = sdr["operativo"].ToString();
                int operativo2 = Convert.ToInt16(operativo);
                if (operativo2 == 1)

                {

                    Radiooperativo.Checked = true;
                }



            }

            //cerrar conexiòn
            con.Close();


        }



        public void cargarUsuarios()
        {
            string cad = ConfigurationManager.ConnectionStrings["conSQLServer"].ConnectionString;
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "prc_ListarUsuarios";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            con.Open();
            sda.Fill(dt);
            con.Close();
           



        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(); // sentencias sql
            cmd.Connection = con;
            cmd.CommandText = "prc_BorrarPersona";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);

            con.Open();

            cmd.ExecuteNonQuery();
            //cerrar conexiòn
            con.Close();
           

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            DTOUsuario adm = new DTOUsuario();
            adm.Cedula = txtCedula.Text;
            adm.Usuario = txtUsuario.Text;
            adm.Clave = txtContrasena.Text;

            int valorA;

            if (RadioAdministrador.Checked == true)
            {
                valorA = 1;
            }
            else
            {
                valorA = 0;
            }
            adm.Administrador = valorA;
            int valorP;

            if (Radiooperativo.Checked == true)
            {
                valorP = 1;
            }
            else
            {
                valorP = 0;
            }
            adm.Operativo = valorP;



            CADUsuario datocamp = new CADUsuario();
            datocamp.EditarUsuario(adm);




        }
    }
}