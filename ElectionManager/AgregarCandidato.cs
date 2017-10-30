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
    public partial class AgregarCandidato : Form
    {
        public int IdEleccion;
        public AgregarCandidato()
        {
            InitializeComponent();
        }

        private void AgregarCandidato_Load(object sender, EventArgs e)
        {
            cbPersonas.DataSource = Database.GetPeresonas().Tables[0].AsEnumerable().Select(r => r.Field<string>("rut")).ToArray();
            cbTipo.DataSource = new[] { "Presidente", "Alcalde", "Senador", "Diputado", "Consejal" }; 


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Database.SendCommand("INSERT INTO Candidato (rut, regional, tipo, ideleccion) " +
                                 @"VALUES ('" +
                                 cbPersonas.Text
                                 + "','" + (chbRegional.Checked ? "t" : "f")
                                 + "','" + cbTipo.Text + "'," + IdEleccion + ");");
            //MessageBox.Show(@"INSERT INTO Candidato (rut, regional, tipo, ideleccion) " +
            //                @"VALUES ('" +
            //                cbPersonas.Text
            //                + @"','" + (chbRegional.Checked ? "t" : "f")
            //                + @"','" + cbTipo.Text + @"'," + IdEleccion + @");");
            this.Close();
        }
    }
}
