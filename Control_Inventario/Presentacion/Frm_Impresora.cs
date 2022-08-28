using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;


using Entidad;
using Negocio;



namespace Presentacion
{
    public partial class Frm_Impresora : Form
    {


        Impresora descripcion_entidad = new Impresora();

        cnImpresora descripcion_negocio = new cnImpresora();

        cnImpresora Listado = new cnImpresora();



        public Frm_Impresora()
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


        private void mostrar_marca()
        {
            DataTable dt = new DataTable();
            dt = Listado.Listar();
            cbomarca.DataSource = dt;


            this.cbomarca.DisplayMember = "descripcion";
            this.cbomarca.ValueMember = "id_marca";



        }





        private void limpiar()
        {

            txtcodigo.Text = "";
           txtserial.Text = "";
            txttipo.Text = "";
            txtmodelo.Text = "";
            cbomarca.Text = "";


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


     





        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtserial.Text == "" )

            // ---------->  ||

            {



                MessageBox.Show("Debe Ingresar N° Serial Impresora ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

           }



            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
                descripcion_entidad.Serial = txtserial.Text;

                descripcion_entidad.Modelo = txtmodelo.Text;
                descripcion_entidad.Tipo  = txttipo.Text;




                descripcion_entidad.Marcax = cbomarca.SelectedValue.ToString();







                // metodo de guardar
                descripcion_negocio.guardar(descripcion_entidad);


                MessageBox.Show("Asido Guardado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mostrar();

                limpiar();


            }
        }



     


        private void Frm_Impresora_Load(object sender, EventArgs e)
        {
            mostrar();



            mostrar_marca();

            desahilitar();

            cbomarca.Text = "";


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {



            // la variables que representa  para la caja de textos

             descripcion_entidad.Id = txtcodigo.Text;

            descripcion_entidad.Serial = txtserial.Text;

            descripcion_entidad.Modelo = txtmodelo.Text;
            descripcion_entidad.Tipo = txttipo.Text;




            descripcion_entidad.Marcax = cbomarca.SelectedValue.ToString();







            // metodo de guardar
            descripcion_negocio.editar(descripcion_entidad);


            MessageBox.Show("Asido Modificado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostrar();

            limpiar();


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {



            DialogResult resultado = MessageBox.Show("¿Desea Eliminar el Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

              
                return;

                mostrar();

                limpiar();

            }

            // la variables que representa  para la caja de textos

            descripcion_entidad.Id = txtcodigo.Text;


            // metodo de guardar
            descripcion_negocio.cancelar(descripcion_entidad);

            //   MessageBox.Show("Asido Eliminado Correctamente", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mostrar();

            limpiar();


        }

        private void txtconsultar_TextChanged(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrar();

            desahilitar();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void grilla_listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txtcodigo.Text = grilla_listado.CurrentRow.Cells["Codigo"].Value.ToString();

            txtserial.Text = grilla_listado.CurrentRow.Cells["Serial"].Value.ToString();

            txtmodelo.Text = grilla_listado.CurrentRow.Cells["Modelo"].Value.ToString();

            txttipo.Text = grilla_listado.CurrentRow.Cells["Tipo"].Value.ToString();

            cbomarca.Text = grilla_listado.CurrentRow.Cells["Marca"].Value.ToString();



            habilitar();








        }
    }
}
