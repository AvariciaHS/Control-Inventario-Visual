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
  public    class cnUsuario
    {
   
      

       adUsuario nombre_datos = new adUsuario();

       public void guardar(Usuario nombre_entidad)
        {
            nombre_datos.insertar(nombre_entidad);


        }

       public void editar(Usuario nombre_entidad)
        {
            nombre_datos.modificar(nombre_entidad);



        }

       public void cancelar(Usuario nombre_entidad)
        {
            nombre_datos.eliminar(nombre_entidad);



        }
        public DataTable Consultar(String parametro)
        {

            return nombre_datos.Buscar(parametro);


        }





        public DataTable Mostrar_cargo()
        {

            return nombre_datos.Listar_cargo();


        }




    }
}
