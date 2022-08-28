using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// las CAPAS

using AccesoDatos;
using Entidad;
using System.Data;



namespace Negocio
{
    public class cnMarca
    {


        adMarca nombre_datos = new adMarca();

        public void guardar(Marcas nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

        public void editar(Marcas nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

        public void cancelar(Marcas nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }




    }
}
