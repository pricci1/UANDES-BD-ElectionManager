using System;
using System.Data;
using System.Linq;
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
            dateTimePicker1.Value = Database.GetDataSet(@"select fecha from eleccion where id = "+IdEleccion+";").Tables[0].Rows[0].Field<DateTime>("fecha");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            EditarElecciones_Load(this, EventArgs.Empty);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCandidato agregarCandidato = new AgregarCandidato {IdEleccion = IdEleccion};
            agregarCandidato.ShowDialog();
            EditarElecciones_Load(this, EventArgs.Empty);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var rowIndex = dataGridViewCandidatos.SelectedCells[0].RowIndex;
            using (DataTable dt = (DataTable)dataGridViewCandidatos.DataSource)
            {
                var idCandidato = Convert.ToInt16(dt.Rows[rowIndex].Field<int>("id_candidato"));
                Database.SendCommand(@"DELETE FROM Candidato WHERE id_candidato = "+ idCandidato +";");
            }
            EditarElecciones_Load(this, EventArgs.Empty);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            var fecha = dateTimePicker1.Value.ToString().Replace('/', '-')
                .Remove(dateTimePicker1.Value.ToString().Length - 3, 3);
            Database.SendCommand(@"UPDATE eleccion set fecha ='"+ dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE id="+ IdEleccion + ";");
            //MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss")+ "id: "+IdEleccion);
        }
    }
}
