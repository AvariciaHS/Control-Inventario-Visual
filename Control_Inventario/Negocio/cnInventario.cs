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
    public class cnInventario
    {


        adInventario nombre_datos = new adInventario();

        public void guardar(Inventario nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

        public void editar(Inventario nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

        public void cancelar(Inventario nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }

        public DataTable Mostrar_area()
        {

            return nombre_datos.Listar_area();


        }

        public DataTable Mostrar_ubicacion()
        {

            return nombre_datos.Listar_ubicacion();


        }


        public DataTable Mostrar_equipo()
        {

            return nombre_datos.Listar_equipo();


        }


        public DataTable Mostrar_usuario()
        {

            return nombre_datos.Listar_usuario();


        }

    }
}
