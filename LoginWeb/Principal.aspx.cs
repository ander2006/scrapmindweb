
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using DTO;
using CAD;
using System.Windows;

namespace LoginWeb
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            DTODireccion dir = new DTODireccion();
            dir.Codigo = Convert.ToInt32(txtcodigo.Text);
            dir.Direccion = txtdireccion.Text;
            CADDireccion datodir = new CADDireccion();
            datodir.guardarDireccion(dir);
        }
    }
}