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
    public partial class EsVocal : Form
    {
        public string elrut; // We define this variable to store the rut from the prevous Form

        public EsVocal()
        {
            InitializeComponent();
            // Creates a new event handler that triggers when double click on a cell
            this.dataGridViewElecciones.CellDoubleClick += this.dataGridViewElecciones_CellDoubleClick;
        }

        private void dataGridViewElecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("as");
            btnConsultar_Click(this, EventArgs.Empty);
        }

        private void EsVocal_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.Width += 10;
            // While the Form is loading, fill the dataGridView with the Dataset coming from GetElecciones
            dataGridViewElecciones.DataSource = Database.GetElecciones().Tables[0];
            // https://stackoverflow.com/a/23702091 Adjust width of grid adecuatedly
            dataGridViewElecciones.Width = dataGridViewElecciones.Columns.Cast<DataGridViewColumn>().Sum(x => x.Width)
                                           + (dataGridViewElecciones.RowHeadersVisible ? dataGridViewElecciones.RowHeadersWidth : 0) + 3;
        }

        private void dataGridViewElecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("test");
            //Int32 selectedCellCount =
            //    dataGridViewElecciones.GetCellCount(DataGridViewElementStates.Selected);
            //if (selectedCellCount > 0)
            //{
            //    if (dataGridViewElecciones.AreAllCellsSelected(true))
            //    {
            //        MessageBox.Show("All cells are selected", "Selected Cells");
            //    }
            //    else
            //    {
            //        System.Text.StringBuilder sb =
            //            new System.Text.StringBuilder();

            //        for (int i = 0;
            //            i < selectedCellCount; i++)
            //        {
            //            sb.Append("Row: ");
            //            sb.Append(dataGridViewElecciones.SelectedCells[i].RowIndex
            //                .ToString());
            //            sb.Append(", Column: ");
            //            sb.Append(dataGridViewElecciones.SelectedCells[i].ColumnIndex
            //                .ToString());
            //            sb.Append(Environment.NewLine);
            //        }

            //        sb.Append("Total: " + selectedCellCount.ToString());
            //        MessageBox.Show(sb.ToString(), "Selected Cells");
            //    }
            //}
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var RowIndex = dataGridViewElecciones.SelectedCells[0].RowIndex;

            // Extraemos un objeto de tipo DataTable del DataSource (que es un DataSet)
            using (DataTable dt = (DataTable)this.dataGridViewElecciones.DataSource)
            {
//                MessageBox.Show(RowIndex.ToString());

                // From the DataTable dt in the row selected we extract the int from the field name id.
                // We send this id to a method that executes a SQL query checking if the rut is part of the table containing all vocales
                    // and show true if it is in it
                var id = Convert.ToInt16(dt.Rows[RowIndex].Field<int>("id"));
                
                if (Database.VocalesForElection(elrut, id).Contains(elrut))
                {
                    //MessageBox.Show(dt.Rows[RowIndex].Field<int>("id").ToString());
                    MessageBox.Show(elrut + @" SI es vocal en esta elección", @"Si");
                }
                else
                {
                    //MessageBox.Show(Database.VocalesForElection(elrut, id)[0]);
                    MessageBox.Show(elrut + @" NO es vocal en esta elección", @"No");
                }
                
            }
//            var dt = (DataTable)this.dataGridViewElecciones.DataSource;

        }
    }
}
