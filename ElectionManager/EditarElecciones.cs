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
    public partial class EditarElecciones : Form
    {
        public int IdEleccion; // Stores the election's id from previous form
        public EditarElecciones()
        {
            InitializeComponent();
        }

        private void EditarElecciones_Load(object sender, EventArgs e)
        {
            dataGridViewCandidatos.DataSource = Database.GetCandidatosFromEleccion(IdEleccion).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.EditarElecciones_Load(this, EventArgs.Empty);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCandidato agregarCandidato = new AgregarCandidato {IdEleccion = IdEleccion};
            agregarCandidato.ShowDialog();
            this.EditarElecciones_Load(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewCandidatos.SelectedCells[0].RowIndex;
            using (DataTable dt = (DataTable)dataGridViewCandidatos.DataSource)
            {
                var idCandidato = Convert.ToInt16(dt.Rows[rowIndex].Field<int>("id_candidato"));
                Database.SendCommand(@"DELETE FROM Candidato WHERE id_candidato = "+ idCandidato +";");
            }
            this.EditarElecciones_Load(this, EventArgs.Empty);
        }
    }
}
