using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
  public   class Inventario
    {

        private string id;
        private string personas;
        private string empresa;
        private string correo;
        private string ubicaciones;
        private string equipos;
        private string areas;
        private string usuarios;

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

        public string Personas
        {
            get
            {
                return personas;
            }

            set
            {
                personas = value;
            }
        }

        public string Empresa
        {
            get
            {
                return empresa;
            }

            set
            {
                empresa = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Ubicaciones
        {
            get
            {
                return ubicaciones;
            }

            set
            {
                ubicaciones = value;
            }
        }

        public string Equipos
        {
            get
            {
                return equipos;
            }

            set
            {
                equipos = value;
            }
        }

        public string Areas
        {
            get
            {
                return areas;
            }

            set
            {
                areas = value;
            }
        }

        public string Usuarios
        {
            get
            {
                return usuarios;
            }

            set
            {
                usuarios = value;
            }
        }
    }
}
