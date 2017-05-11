using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;


namespace LoginWeb
{
    public partial class Iframe : System.Web.UI.Page
    {

        private void ESPERA(int INTERVALO)
        {
            Stopwatch PARADA = new Stopwatch();
            PARADA.Start();

            do
            {
                System.Windows.Forms.Application.DoEvents();
            }


            while (PARADA.ElapsedMilliseconds < INTERVALO);


            PARADA.Stop();
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    string url = "https://wsp.registraduria.gov.co/censo/_censoResultado.php";
        //    Thread thread = new Thread(delegate ()
        //    {
        //        using (WebBrowser browser = new WebBrowser())
        //        {
        //            browser.ScrollBarsEnabled = false;
        //            browser.AllowNavigation = true;
        //            browser.Navigate(url);
                  
        //            browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DocumentCompleted);
        //            while (browser.ReadyState != WebBrowserReadyState.Complete)
        //            {
        //                System.Windows.Forms.Application.DoEvents();
        //            }
        //        }
        //    });
        //    thread.SetApartmentState(ApartmentState.STA);
        //    thread.Start();
        //    thread.Join();
            
            
        //}

        //private void DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        //{
           
        //    WebBrowser browser = sender as WebBrowser;
        //    ESPERA(4000);
        //    browser.Document.GetElementById("nCedula").InnerText = "1035417284";
        //    ESPERA(4000);
        //    foreach (HtmlElement node2 in browser.Document.GetElementsByTagName("input"))
        //    {
        //        if (node2.GetAttribute("value").Equals("Consultar"))
        //        {
        //            node2.InvokeMember("Click");
        //        }
        //    }
        //    string departamento;
        //    string municipio;
        //    string puesto;
        //    string dirpuesto;
        //    string fecha;
        //    string mesa;
        //    string[] palabras = new string[12];
        //    int i = 0;
        //    foreach (HtmlElement node1 in browser.Document.GetElementsByTagName("td"))
        //    {
        //        palabras[i] = node1.InnerText;
        //        departamento = palabras[1];
        //        municipio = palabras[3];
        //        puesto = palabras[5];
        //        dirpuesto = palabras[7];
        //        fecha = palabras[9];
        //        mesa = palabras[11];

        //        i++;
        //    }
        //    TextBox1.Text = palabras[i];

        //    departamento = palabras[1];
        //    if (departamento == null)
        //    {
        //        departamento = "No Aplica";
        //    }
        //    municipio = palabras[3];

        //    if (municipio == null)
        //    {
        //        municipio = "No Aplica";
        //    }
        //    puesto = palabras[5];
        //    if (puesto == null)
        //    {
        //        puesto = "No Aplica";
        //    }
        //    dirpuesto = palabras[7];
        //    if (dirpuesto == null)
        //    {
        //        dirpuesto = "No Aplica";
        //    }
        //    fecha = palabras[9];
        //    if (fecha == null)
        //    {
        //        fecha = "No Aplica";
        //    }
        //    mesa = palabras[11];
        //    if (mesa == null)
        //    {
        //        mesa = "No Aplica";
        //    }
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("https://wsp.registraduria.gov.co/censo/_censoResultado.php");
            ESPERA(4000);

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "mykey", "dihola()", true);

            
        }
    }

        
    }
