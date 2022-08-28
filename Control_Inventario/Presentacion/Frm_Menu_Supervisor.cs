using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Frm_Menu_Supervisor : Form
    {
        public Frm_Menu_Supervisor()
        {
            InitializeComponent();
        }

        private void reporteDeImpresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void reporteDeInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void reporteDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {


         
        }

        private void reporteDeLincenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea Salir del Control de Inventario ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {

                return;



            }

            this.Dispose();
            this.Hide();
        }

        private void Frm_Menu_Supervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
