using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOEscrapear
    {
        private string cedula;
        private string departamento;
        private string municipio;
        private string puesto;
        private string dirpuesto;
        private string fecha;
        private string mesa;

        public string Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public string Dirpuesto
        {
            get
            {
                return dirpuesto;
            }

            set
            {
                dirpuesto = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Mesa
        {
            get
            {
                return mesa;
            }

            set
            {
                mesa = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }
    }
}
