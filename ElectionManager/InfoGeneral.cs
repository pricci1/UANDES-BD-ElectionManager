using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ElectionManager
{
    public partial class InfoGeneral : Form
    {
        public InfoGeneral()
        {
            InitializeComponent();
            // Creates event when key pressed in txtBox (in this case Enter)
            // https://stackoverflow.com/questions/3752451/enter-key-pressed-event-handler
            txtRut.KeyDown += new KeyEventHandler(txtRut_KeyDown);
        }

        private void txtRut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConsultar_Click(this, EventArgs.Empty);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text != "")
            {
                var lista = new string[6] {"nombre", "mesa", "local", "dir", "antecedentes", "vivo"};
                var valores = new object[lista.Length];
                try
                {
                    for (var i = 0; i < lista.Length; i++)
                    {
                        var y = lista[i];
                        Database.GetInfoFromRut(txtRut.Text).TryGetValue(y, out var x);
                        valores[i] = x;
                    }

                    //Database.GetInfoFromRut(txtRut.Text).TryGetValue("nombre", out var x);
                    lblNombre.Text = (string)valores[0];
                    lblMesa.Text = (string)valores[1];
                    lblLocal.Text = (string)valores[2];
                    lblDir.Text = (string)valores[3];
                    lblHabil.Text = ((bool)valores[4] || !(bool)valores[5]) ? "No" : "Si";
                    btnEsVocal.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Ingrese datos válidos", caption: @"Error");
                }
                //MessageBox.Show((string)x, @"Calling a function from Database");
            }
        }

        private void btnEsVocal_Click(object sender, EventArgs e)
        {
            EsVocal esVocal = new EsVocal(); // Create instance of Form EsVocal
            esVocal.elrut = txtRut.Text;
            esVocal.Text = @"Verificar si " + txtRut.Text + @" es vocal"; // Set window title acording to rut
            esVocal.Show();
        }

        private void InfoGeneral_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            // This is to suggest from an array of all rut in perosna
            AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
            // We extract all values in "rut" column and transform it to an array. Then we "append" the array to the stringcollection using AddRange method (wich accespts arrays!!)
            suggest.AddRange(Database.GetPeresonas().Tables[0].AsEnumerable().Select(r => r.Field<string>("rut")).ToArray());

            txtRut.AutoCompleteCustomSource = suggest;
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
