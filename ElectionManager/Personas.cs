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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            dataGridViewPersonas.AutoGenerateColumns = true; // The columns will be extracted automatically from the datasource
            dataGridViewPersonas.DataSource = Database.GetPeresonas().Tables[0];

            // We will hide all coloumns except for the first two (i.e. rut and nombre)
            for (int i = 2; i < dataGridViewPersonas.Columns.Count; i++)
            {
                dataGridViewPersonas.Columns[i].Visible = false;
            }
            dataGridViewPersonas.Columns[1].Width += 80; // Change width of nombre
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            VerPersona verPersona = new VerPersona();
            using (DataTable dt = (DataTable)this.dataGridViewPersonas.DataSource)
            {
                var rowIndex = dataGridViewPersonas.SelectedCells[0].RowIndex;
                var rutOfSelectedCell = dt.Rows[rowIndex].Field<string>("rut");
                verPersona.InputRut = rutOfSelectedCell;
            }
            verPersona.Show();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Personas_Load(this,EventArgs.Empty);
            dataGridViewPersonas.Columns[1].Width += -80; // To counter the effect of the same line in personas_load
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Crear instancia editorPerosona
            EditarPersona editarPersona = new EditarPersona();
            using (DataTable dt = (DataTable) this.dataGridViewPersonas.DataSource)
            {
                var rowIndex = dataGridViewPersonas.SelectedCells[0].RowIndex;
                var rutOfSelectedCell = dt.Rows[rowIndex].Field<string>("rut");
                editarPersona.Rut = rutOfSelectedCell;
            }
            editarPersona.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"No se puede eliminar personas");
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            AgregarPersona agregarPersona = new AgregarPersona();
            agregarPersona.ShowDialog();
        }
    }
}
