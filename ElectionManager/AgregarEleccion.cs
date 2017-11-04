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
    public partial class AgregarEleccion : Form
    {
        public AgregarEleccion()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarEleccion_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = new[] { "Presidencial", "Alcaldes", "Senatorial", "Diputados", "Consejales" };
            dateTimePicker1.Value = DateTime.Today.AddDays(15);
            chbExtranjeros.Checked = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Database.SendCommand(
                string.Format(
                    "INSERT INTO eleccion (id, categoria, fecha, votan_extranjero) VALUES (DEFAULT, '{0}', '{1}', '{2}');",
                    cbCategoria.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    chbExtranjeros.Checked ? "t" : "f"));
            // We obtain the id asigned to this new election
            DataSet getIDdeNuevaEleccion = Database.GetDataSet(@"SELECT MAX(id) AS id FROM eleccion;");
            int idNuevaEleccion = getIDdeNuevaEleccion.Tables[0].Rows[0].Field<int>("id");
            // Create Blanco and Nulo candidates
            Database.SendCommand("INSERT INTO Candidato (rut, regional, tipo, ideleccion) " +
                                 $"VALUES ('0.000.000-1', 'f', 'Blanco', {idNuevaEleccion});");
            Database.SendCommand("INSERT INTO Candidato (rut, regional, tipo, ideleccion) " +
                                 $"VALUES ('0.000.000-2', 'f', 'Nulo', {idNuevaEleccion});");
            this.Close();
            // Open window to edit this new election
            EditarElecciones editarElecciones = new EditarElecciones {IdEleccion = idNuevaEleccion};
            editarElecciones.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
