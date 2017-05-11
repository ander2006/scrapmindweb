using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using CAD;
using System.Data;

namespace LoginWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DTOUsuario user = new DTOUsuario();
            user.Usuario = txtuser.Text;
            user.Clave = txtcontrasena.Text;
            CADUsuario datoUser = new CADUsuario();
            DataTable dt = datoUser.autenticarUsuario(user);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("Menu.aspx");

            }
           
            
        }
    }
}