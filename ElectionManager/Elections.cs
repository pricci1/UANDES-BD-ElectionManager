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
    public partial class Elections : Form
    {
        public Elections()
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

        }
    }
}
