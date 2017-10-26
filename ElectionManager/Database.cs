using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace ElectionManager
{
    static class Database
    {
        public static string connString { get; set; }

        static Database()
        {
            //connString = "Host=localhost;Port=5432;User Id=postgres;Database=test;Password=1234";
            connString = "Host=201.238.213.114;Port=54321;User Id=grupo24;Database=grupo24;Password=rjEs6l";
        }

        public static string Test(string text)
        {
            return text.ToString();
        }

        public static Dictionary<string, object> GetInfoFromRut(string fromRut)
        {
            var retorno = new Dictionary<string, object>();
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(@"SELECT p.nombre, m.Nombre, m.idlocal, p.calle || ', ' || p.numero_casa || ', depto ' || p.departamento || ', ' || p.ciudad || ', ' || p.region, p.antecedentes, p.vive " +
                                                   "FROM persona p	INNER JOIN mesa m ON m.IDMesa = p.IDMesa " +
                                                   "WHERE p.rut = '" + fromRut + "';", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        retorno.Add("nombre", reader.GetString(0));
                        retorno.Add("mesa", reader.GetString(1));
                        retorno.Add("local", reader.GetString(2));
                        retorno.Add("dir", reader.GetString(3));
                        retorno.Add("antecedentes", reader.GetBoolean(4));
                        retorno.Add("vivo", reader.GetBoolean(5));
                        //Console.WriteLine("RUT: " + rut + "\tTipo:  " + tipo + "\t\tRegional: " + (regional ? "true" : "false"));
                    }
                }
                conn.Close();
            }
            return retorno;
        }

        public static DataSet GetDataSet(string pgsqlCmd)
        {
            DataSet ds = new DataSet(); // Create DataSet
            using (var conn = new NpgsqlConnection(connString)) // Create connection to db
            {
                conn.Open(); // Open connection
                using (var da = new NpgsqlDataAdapter())
                using (var cmd = new NpgsqlCommand(pgsqlCmd, conn))
                {
                    da.SelectCommand = cmd; // Execute sql command
                    da.Fill(ds); // Fill columns and rows to the DataSet
                }
                conn.Close(); // Close connection
            }
            return ds;
        }

        public static DataSet GetElecciones()
        {
            return GetDataSet(@"SELECT e.id, e.categoria, e.fecha FROM eleccion e;");
        }

        public static DataSet GetPeresonas()
        {
            return GetDataSet(@"SELECT * FROM persona;");
        }

        public static List<string> VocalesForElection(string rut, int idEleccion)
        {
            var rutDataSet = GetDataSet("SELECT v.rut rut_vocal " +
                                        "FROM eleccion e INNER JOIN mesa_efectiva me ON me.ideleccion = e.id " +
                                        "INNER JOIN vocal v ON v.idmesaefectiva=me.id " +
                                        "WHERE e.id = " + idEleccion + ";");

            // Extract the values from the column named "rut_vocal" and create a list with them using LINQ
            // https://stackoverflow.com/a/23735845
            var losruts = rutDataSet.Tables[0].AsEnumerable().Select(r => r.Field<string>("rut_vocal")).ToList();
           
            return losruts;

        }

        public static DataSet GetPersonaFromRut(string rut)
        {
            var personaRut = GetDataSet(@"SELECT * FROM persona WHERE rut =" + " '" + rut + "';");
            return personaRut;
        }

        // To transpose datatable: from: https://www.codeproject.com/Articles/44274/Transpose-a-DataTable-using-C
        public static DataTable GenerateTransposedTable(DataTable inputTable)
        {
            DataTable outputTable = new DataTable();

            // Add columns by looping rows

            // Header row's first column is same as in inputTable
            outputTable.Columns.Add(inputTable.Columns[0].ColumnName.ToString());

            // Header row's second column onwards, 'inputTable's first column taken
            foreach (DataRow inRow in inputTable.Rows)
            {
                string newColName = inRow[0].ToString();
                outputTable.Columns.Add(newColName);
            }

            // Add rows by looping columns        
            for (int rCount = 1; rCount <= inputTable.Columns.Count - 1; rCount++)
            {
                DataRow newRow = outputTable.NewRow();

                // First column is inputTable's Header row's second column
                newRow[0] = inputTable.Columns[rCount].ColumnName.ToString();
                for (int cCount = 0; cCount <= inputTable.Rows.Count - 1; cCount++)
                {
                    string colValue = inputTable.Rows[cCount][rCount].ToString();
                    newRow[cCount + 1] = colValue;
                }
                outputTable.Rows.Add(newRow);
            }

            return outputTable;
        }
    }
}
