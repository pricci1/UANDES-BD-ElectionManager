﻿using System;
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
    public partial class EditarPersona : Form
    {
        public string Rut;
        public EditarPersona()
        {
            InitializeComponent();
        }

        private void EditarPersona_Load(object sender, EventArgs e)
        {
            lblRut.Text = Rut;
            var datos = Database.GetPersonaFromRut(Rut).Tables[0].Rows[0];
            txtNombre.Text = datos.Field<string>("nombre");
            txtTelefono.Text = datos.Field<string>("telefono");
            chbAntecedentes.Checked = datos.Field<bool>("antecedentes");
            txtNacionalidad.Text = datos.Field<string>("nacionalidad");
            txtPais.Text = datos.Field<string>("pais");
            txtCalle.Text = datos.Field<string>("calle");
            long numcasa = Convert.ToInt16(datos.Field<long>("numero_casa")); // SQL Bigint -> c# long //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
            //MessageBox.Show(numcasa);
            txtNumCasa.Text = numcasa.ToString();
            txtRegion.Text = datos.Field<string>("region");
            txtDepto.Text = datos.Field<string>("departamento");
            txtCiudad.Text = datos.Field<string>("ciudad");
            var fechaNacimiento= datos.Field<DateTime>("fecha_de_nacimiento");
            dateTimePickerNacimiento.Value = fechaNacimiento;
            //MessageBox.Show(fechaNacimiento.ToString()); //test datetime
            txtIdMesa.Text = datos.Field<long>("idmesa").ToString();
            txtPartido.Text = datos.Field<string>("partidopolitico");
            txtComuna.Text = datos.Field<string>("comuna");
            chbVive.Checked = datos.Field<bool>("vive");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            EditarPersona_Load(this, EventArgs.Empty);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var sqlinsert = String.Format("UPDATE persona SET " +
                                          "nombre = '{0}'," +
                                          "telefono = '{1}'," +
                                          "antecedentes = {2}," +
                                          "pais = '{3}'," +
                                          "calle = '{4}'," +
                                          "numero_casa = {5}," +
                                          "region = '{6}'," +
                                          "departamento = '{7}'," +
                                          "ciudad = '{8}'," +
                                          "fecha_de_nacimiento = '{9}'," +
                                          "idmesa = {10}," +
                                          "partidopolitico = {11}," +
                                          "comuna = '{12}'," +
                                          "vive = {13}" +
                                          " WHERE rut = '{14}';", txtNombre.Text, txtTelefono.Text, chbAntecedentes.Checked,
                                            txtPais.Text, txtCalle.Text, Convert.ToInt64(txtNumCasa.Text), txtRegion.Text,
                                            txtDepto.Text, txtCiudad.Text, dateTimePickerNacimiento.Value, txtIdMesa.Text,
                                            (txtPartido.Text == "")? "DEFAULT" : $"'{txtPartido.Text}'", txtComuna.Text, chbVive.Checked, Rut);
            Database.SendCommand(sqlinsert);
            this.Close();
        }
    }
}
