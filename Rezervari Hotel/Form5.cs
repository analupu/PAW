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

namespace Rezervari_Hotel
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {

            preturi.Series.Add("preturi");
            List<camere> camereDisponibile = new List<camere>
            {
                new camere("Single", 100, "Oras"),
                new camere("Double", 150, "Mare"),
                new camere("Suite", 200, "Mare"),
                new camere("Triple", 250, "Gradina"),
                new camere("Penthouse", 900, "Mare"),
                new camere("Single", 150, "Munte"),
                new camere("Family", 300, "Munte"),
                new camere("Family", 400, "Mare"),
                new camere("Family", 400, "Gradina")

            };

           
            foreach (var camera in camereDisponibile)
            {
                preturi.Series["preturi"].Points.AddXY(camera.Tip, camera.Pret);
            }

          
            preturi.ChartAreas[0].AxisX.Title = "Tipul camerei";
            preturi.ChartAreas[0].AxisY.Title = "Pretul camerei";
            preturi.ChartAreas[0].AxisX.Interval = 1;

            preturi.Series["preturi"].ChartType = SeriesChartType.Column;
        }

    }
}
