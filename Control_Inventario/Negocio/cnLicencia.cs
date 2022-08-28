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
 public      class cnLicencia
    {


     adLicencia nombre_datos = new adLicencia();

     public void guardar(Licencia nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

     public void editar(Licencia nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

     public void cancelar(Licencia nombre_entidad)
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

