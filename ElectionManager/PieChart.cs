using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ElectionManager
{
    public partial class PieChart : Form
    {
        public int IdEleccion;
        public PieChart()
        {
            InitializeComponent();
        }

        private void PieChart_Load(object sender, EventArgs e)
        {
            // https://stackoverflow.com/a/34107528
            //reset your chart series and legends
            chart1.Series.Clear();
            chart1.Legends.Clear();

            chart1.BackColor = Color.Transparent;
            //Add a new Legend(if needed) and do some formating
            chart1.Legends.Add("Legend");
            chart1.Legends[0].LegendStyle = LegendStyle.Table;
            chart1.Legends[0].Docking = Docking.Right;
            chart1.Legends[0].Alignment = StringAlignment.Center;
            chart1.Legends[0].Title = "Candidatos";
            chart1.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "SeriesName";
            chart1.Series.Add(seriesname);
            //set the chart-type to "Pie"
            chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
            //Add some datapoints so the series. Candidates votes
            string sqlquery = "select count(v.idcandidato), cand.id_candidato idcandidato, p.nombre from voto v " +
                              "inner join candidato cand ON cand.id_candidato = v.idcandidato " +
                              "inner join persona p ON cand.rut = p.rut " +
                              $"where ideleccion = {IdEleccion} " +
                              "GROUP BY cand.id_candidato, p.nombre;";
            
            using (DataTable dt = (DataTable)Database.GetDataSet(sqlquery).Tables[0])
            {
                foreach (DataRow item in dt.Rows)
                {
                    chart1.Series[seriesname].Points.AddXY(item.Field<string>("nombre").ToString(), item.Field<Int64>("count"));
                }
                //var idEleccionSeleccionada = Convert.ToInt16(dt.Rows[rowIndex].Field<int>("id"));
            }
            
            //chart1.Series[seriesname].Points.AddXY("Test", 10);
            //chart1.Series[seriesname].Points.AddXY("Test", 10);
        }
    }
}
