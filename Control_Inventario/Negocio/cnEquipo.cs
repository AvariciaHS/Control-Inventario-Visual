using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// las CAPAS

using AccesoDatos;
using Entidad;

//***************************************
using System.Data;


namespace Negocio
{
  public   class cnEquipo
    {

      adEquipo nombre_datos = new adEquipo();


      public void guardar(Equipo nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

      public void editar(Equipo nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

      public void cancelar(Equipo nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }

     

     


        public DataTable Mostrar_equipo()
        {

            return nombre_datos.Listar_equipo();


        }



    }
}


