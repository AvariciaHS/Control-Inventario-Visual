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
    public partial class Frm_Cargo : Form
    {


        Cargo descripcion_entidad = new Cargo();

        cnCargo descripcion_negocio = new cnCargo();

        cnCargo Listado = new cnCargo();

        public Frm_Cargo()
        {
            InitializeComponent();
        }

        private void mostrar()
        {

            DataTable dt = new DataTable();

            String dato = txtconsultar.Text;


            dt = Listado.Consultar(dato);

            grilla_listado.DataSource = dt;


        }



        private void limpiar()
        {

            txtcodigo.Text = "";
            txtmarca.Text = "";

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



        private void Frm_Cargo_Load(object sender, EventArgs e)
        {

            mostrar();
            desahilitar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrar();

            desahilitar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtmarca.Text == "")
            {

                MessageBox.Show("Debe Ingresar el Cargo ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
                descripcion_entidad.Descripcion = txtmarca.Text;

                // metodo de guardar
                descripcion_negocio.guardar(descripcion_entidad);


                MessageBox.Show("Asido Guardado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostrar();

                limpiar();


            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;

            descripcion_entidad.Descripcion = txtmarca.Text;

            // metodo de modificar
            descripcion_negocio.editar(descripcion_entidad);


            MessageBox.Show("Asido Modificado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);


            mostrar();
            limpiar();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {


            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;


            // ELIMINAR REGISTRO

            descripcion_negocio.cancelar(descripcion_entidad);






            MessageBox.Show("Asido Eliminado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);


            mostrar();

            limpiar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtmarca.Text = grilla_listado.CurrentRow.Cells["Cargo"].Value.ToString();


            habilitar();
        }
    }
}
