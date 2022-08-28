using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AccesoDatos;
using Entidad;
using System.Data;



namespace Negocio
{
   public  class cnCargo
    {

        adCargo nombre_datos = new adCargo();




        public void guardar(Cargo nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

        public void editar(Cargo nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

        public void cancelar(Cargo nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }





        public DataTable Listar()
        {

            return nombre_datos.Listar_Cargo();


        }







    }
}
