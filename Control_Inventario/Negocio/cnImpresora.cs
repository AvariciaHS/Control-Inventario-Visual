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
    public class cnImpresora
    {


        adImpresora nombre_datos = new adImpresora();

        public void guardar(Impresora nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

        public void editar(Impresora nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

        public void cancelar(Impresora  nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }

        public DataTable Listar()
        {

            return nombre_datos.Listar_Marca();


        }


    }
}
