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
    public partial class VerPersona : Form
    {
        public VerPersona()
        {
            InitializeComponent();
        }

        public string InputRut;

        private void VerPersona_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Database.GenerateTransposedTable(Database.GetPersonaFromRut(InputRut).Tables[0]);
        }
    }
}
