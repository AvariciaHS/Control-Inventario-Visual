using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
     public  class Impresora
    {


        private string id;
        private string serial;

        private string modelo;
        private string tipo;


        private string marcax;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Serial
        {
            get
            {
                return serial;
            }

            set
            {
                serial = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string  Marcax
        {
            get
            {
                return marcax;
            }

            set
            {
                marcax = value;
            }
        }
    
    }
}
