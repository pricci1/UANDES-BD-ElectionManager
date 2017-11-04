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
    public partial class AgregarPersona : Form
    {
        public AgregarPersona()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var sqlinsert = String.Format("INSERT INTO persona VALUES ('{15}','{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}','{8}','{9}',{10},{11},{12},'{13}', {14});", txtNombre.Text, txtTelefono.Text, chbAntecedentes.Checked,
                txtNacionalidad.Text, txtPais.Text, txtCalle.Text, Convert.ToInt64(txtNumCasa.Text), txtRegion.Text,
                txtDepto.Text, txtCiudad.Text, dateTimePickerNacimiento.Value, txtIdMesa.Text,
                (txtPartido.Text == "") ? "DEFAULT" : $"'{txtPartido.Text}'", txtComuna.Text, chbVive.Checked, txtRut.Text);
            MessageBox.Show(sqlinsert);
            Database.SendCommand(sqlinsert);
            this.Close();
        }
    }
}
