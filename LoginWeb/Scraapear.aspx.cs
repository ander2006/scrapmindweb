using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using DTO;
using CAD;

namespace LoginWeb
{
    public partial class Scraapear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistraduria_Click(object sender, EventArgs e)
        {
            string line;
            System.IO.StreamReader file =
           new System.IO.StreamReader(@"c:\test.txt");

            while ((line = file.ReadLine()) != null)
            {

                IWebDriver driver = new FirefoxDriver();
                driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
                driver.Navigate().GoToUrl("https://wsp.registraduria.gov.co/censo/_censoResultado.php");
          

                string cedula = line;
                IWebElement searchInput = driver.FindElement(By.Id("nCedula"));
                searchInput.SendKeys(cedula);
                searchInput.SendKeys(Keys.Enter);
                string departamento = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[1]/td[2]")).Text;
                string municipio = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[2]/td[2]")).Text;
                string puesto = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[3]/td[2]")).Text;
                string dirpuesto = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[4]/td[2]/div")).Text;
                string fecha = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[5]/td[2]")).Text;
                string mesa = driver.FindElement(By.XPath("//*[@id='apto']/table/tbody/tr[6]/td[2]")).Text;

                


                if (departamento == null)
                {
                    departamento = "No Aplica";
                }


                if (municipio == null)
                {
                    municipio = "No Aplica";
                }

                if (puesto == null)
                {
                    puesto = "No Aplica";
                }

                if (dirpuesto == null)
                {
                    dirpuesto = "No Aplica";
                }

                if (fecha == null)
                {
                    fecha = "No Aplica";
                }

                if (mesa == null)
                {
                    mesa = "No Aplica";
                }

                DTOEscrapear adm = new DTOEscrapear();
                adm.Cedula = cedula;
                adm.Departamento = departamento;
                adm.Municipio = municipio;
                adm.Puesto = puesto;
                adm.Dirpuesto = dirpuesto;
                adm.Fecha = fecha;
                adm.Mesa = mesa;

                CADEscrapear datocamp = new CADEscrapear();
                datocamp.guardarCampos(adm);
                driver.Close();



            }

        }
    }
}