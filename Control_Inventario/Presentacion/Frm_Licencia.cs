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
    public partial class Frm_Licencia : Form
    {


        Licencia descripcion_entidad = new Licencia();

        cnLicencia descripcion_negocio = new cnLicencia();

        cnLicencia Listado = new cnLicencia();


        public Frm_Licencia()
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
            dt = Listado.Mostrar_equipo();
            cboequipo.DataSource = dt;


            this.cboequipo.DisplayMember = "equipo";
            this.cboequipo.ValueMember = "id_equipo";



        }





        private void limpiar()
        {

            txtcodigo.Text = "";
            txtoffice.Text = "";
            txtantivirus.Text = "";
            txtpdf.Text = "";
            cboequipo.Text = "";
            txtwindows.Text = "";
            txtautocad.Text = "";


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



        private void Frm_Licencia_Load(object sender, EventArgs e)
        {
            mostrar();



            mostrar_marca();

            desahilitar();

            cboequipo.Text = "";
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            limpiar();
            mostrar();

            desahilitar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtoffice.Text == ""  )

            // ---------->  ||
            {



                MessageBox.Show("Debe Ingresar N° Clave Office ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (cboequipo.Text == "")

            // ---------->  ||
            {



                MessageBox.Show("Debe Ingresar N° Equipo ", "Aviso....", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            else
            {

                // la variables que representa  para la caja de textos

                //******* descripcion_entidad.Id = txtcodigo.Text;
                descripcion_entidad.Office = txtoffice.Text;

                descripcion_entidad.Windows  = txtwindows.Text;
                descripcion_entidad.Autocad= txtautocad.Text;

                descripcion_entidad.Pdf = txtpdf.Text;
                descripcion_entidad.Antivirus = txtantivirus.Text;

          



                descripcion_entidad.Idequipo = cboequipo.SelectedValue.ToString();







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
            descripcion_entidad.Office = txtoffice.Text;

            descripcion_entidad.Windows = txtwindows.Text;
            descripcion_entidad.Autocad = txtautocad.Text;

            descripcion_entidad.Pdf = txtpdf.Text;
            descripcion_entidad.Antivirus = txtantivirus.Text;





            descripcion_entidad.Idequipo = cboequipo.SelectedValue.ToString();









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

            txtoffice.Text = grilla_listado.CurrentRow.Cells["clave_office"].Value.ToString();

            txtwindows.Text = grilla_listado.CurrentRow.Cells["clave_windows"].Value.ToString();

            txtautocad.Text = grilla_listado.CurrentRow.Cells["clave_autocad"].Value.ToString();

            txtpdf.Text = grilla_listado.CurrentRow.Cells["clave_pdf"].Value.ToString();

            txtantivirus.Text = grilla_listado.CurrentRow.Cells["clave_antivirus"].Value.ToString();

            cboequipo.Text = grilla_listado.CurrentRow.Cells["equipo"].Value.ToString();

            habilitar();

        }
    }
}
