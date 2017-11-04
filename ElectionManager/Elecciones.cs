using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectionManager
{
    public partial class Elecciones : Form
    {
        public Elecciones()
        {
            InitializeComponent();
        }

        private void Elections_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            dataGridViewElecciones.DataSource = Database.GetElecciones().Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewElecciones.DataSource = Database.GetElecciones().Tables[0];
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewElecciones.SelectedCells[0].RowIndex; // Index of selected row
            EditarElecciones editarElecciones = new EditarElecciones();
            using (DataTable dt = (DataTable) dataGridViewElecciones.DataSource)
                editarElecciones.IdEleccion = Convert.ToInt16(dt.Rows[rowIndex].Field<int>("id"));
            editarElecciones.ShowDialog();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Ver");
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            AgregarEleccion agregarEleccion = new AgregarEleccion();
            agregarEleccion.ShowDialog();
            this.btnRefresh_Click(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtain id of selected elecion
            
            var rowIndex = dataGridViewElecciones.SelectedCells[0].RowIndex;
            using (DataTable dt = (DataTable)dataGridViewElecciones.DataSource)
            {
                var idEleccionSeleccionada = Convert.ToInt16(dt.Rows[rowIndex].Field<int>("id"));
            }

            DialogResult eliminarYesNo = MessageBox.Show(@"¿Seguro que desea eliminar esta elección?", @"Alerta!", MessageBoxButtons.YesNo);
            if (eliminarYesNo == DialogResult.Yes)
            {
                Database.SendCommand($"");
                MessageBox.Show(@"Eleccion eliminada");
            }
            else if (eliminarYesNo == DialogResult.No)
            {
                MessageBox.Show(@"No eliminar!!");

            }
            this.btnRefresh_Click(this, EventArgs.Empty);
        }
    }
}
