using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public  class Usuario
    {

       

        //get y set  es Una propiedad 

        private string id;


        private string usu;

        private string contra;
        private string idcargo;


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

        public string Usu
        {
            get
            {
                return usu;
            }

            set
            {
               usu = value;
            }

        }






        public string Contra
        {
            get
            {
                return contra;
            }

            set
            {
                contra = value;
            }

        }


         public string Idcargo
        {
            get
            {
                return idcargo;
            }

            set
            {
              idcargo = value;
            }






        }
    }
}

 