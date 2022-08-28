using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class Frm_Area : Form
    {


        //representa la clases cnarea  listado 

        cnArea listado = new cnArea();



        //----------capa entidad clases area  metodo private -----------------------------
        private Entidad.Area regActual;


        public Frm_Area()
        {
            InitializeComponent();
        }



        private void mostrar()
        {

            DataTable dt = new DataTable();

            String dato = txtconsultar.Text;

            dt = listado.Consultar(dato);

            grilla_listado.DataSource = dt;


        }






        private void btnguardar_Click(object sender, EventArgs e)
        {



            if (txtarea.Text == "")
            {

                MessageBox.Show("Debe Ingresar la Area", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {



                //--------------CAPA ENTIDAD clases area sobre nombre  oEntidad-------------------------
                var oEntidad = new Entidad.Area();


                if (regActual != null)

                    oEntidad.id_area = regActual.id_area;

                //----------las variables para la caja de texto


                oEntidad.id_area = txtcodigo.Text.Trim();
                oEntidad.nombres = txtarea.Text.Trim();
                //---------------------------------------
                //capa negocio , para insertar los datos  y tambien para modificar

                Negocio.cnArea.Insertar(oEntidad);


                MessageBox.Show("Asido Guardado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostrar();

                limpiar();


            }


        }
        private void limpiar()
        {

            txtcodigo.Text = "";
            txtarea.Text = "";
            txtconsultar.Text = "";



        }

        private void habilitar()
        {


            btnguardar.Enabled = false;

            btnmodificar.Enabled = true;

            btneliminar.Enabled = true;

        }

        private void desahilitar()
        {

            btnguardar.Enabled = true;

            btnmodificar.Enabled = false;

            btneliminar.Enabled = false;


        }



        private void Frm_Area_Load(object sender, EventArgs e)
        {

            mostrar();

            desahilitar();



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {





            //--------------CAPA ENTIDAD clases area sobre nombre  oEntidad-------------------------
            var oEntidad = new Entidad.Area();


            if (regActual != null)

                oEntidad.id_area = regActual.id_area;

            //----------las variables para la caja de texto


            oEntidad.id_area = txtcodigo.Text.Trim();
            oEntidad.nombres = txtarea.Text.Trim();
            //---------------------------------------
            //capa negocio , para insertar los datos  y tambien para modificar

            Negocio.cnArea.Insertar(oEntidad);

            MessageBox.Show("Asido Modificado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);


            mostrar();
            limpiar();



        }

        private void btneliminar_Click(object sender, EventArgs e)
        {


            //--------------CAPA ENTIDAD clases area sobre nombre  oEntidad-------------------------
            var oEntidad = new Entidad.Area();


            if (regActual != null)

                oEntidad.id_area = regActual.id_area;

            //----------las variables para la caja de texto


            oEntidad.id_area = txtcodigo.Text.Trim();
        
            //---------------------------------------
            //capa negocio , para insertar los datos  y tambien para modificar

            Negocio.cnArea.Eliminar(oEntidad);

            MessageBox.Show("Asido Eliminado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);


            mostrar();

            limpiar();
        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {

            mostrar();

        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtarea.Text = grilla_listado.CurrentRow.Cells["Area"].Value.ToString();


            habilitar();




        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

            this.Hide();


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrar();

            desahilitar();


        }
    }
}
