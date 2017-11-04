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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Database.GetInfoFromRut("17.455.344-3").TryGetValue("nombre", out var x);
            //MessageBox.Show((string)x,@"Calling a function from Database
            PieChart pieChart = new PieChart();
            pieChart.Show();
        }

        private void btnInfoGeneral_Click(object sender, EventArgs e)
        {
            InfoGeneral infoGeneral = new InfoGeneral();
            infoGeneral.Show();
        }

        private void btnElecciones_Click(object sender, EventArgs e)
        {
            Elecciones elecciones = new Elecciones();
            elecciones.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Personas personas = new Personas();
            personas.Show();
        }
    }
}
