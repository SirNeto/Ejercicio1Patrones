using Practica1Creacionales;
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

namespace VentanaData
{
    public partial class Form1 : Form
    {
        DataFactory Fact;
        TransFactory TFact;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fact = new DataFactory();
            TFact = new TransFactory();
            chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            chart2.Series["Series1"].ChartType = SeriesChartType.Column;
            DataContainer Data = new DataContainer();
            Data.Data = Fact.GenerateDataGenerator(comboBox1.SelectedIndex).GenerateData();

            foreach (double x in Data.Data)
            {
                chart1.Series["Series1"].Points.AddY(x);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContainer Data = new DataContainer();
            Data.Data = Fact.GenerateDataGenerator(comboBox1.SelectedIndex).GenerateData();
            chart1.Series["Series1"].Points.Clear();
            foreach (double x in Data.Data)
            {
                chart1.Series["Series1"].Points.AddY(x);
            }
            
            IStatisticsFactory sf = TFact.GenerateDataTrans(comboBox2.SelectedIndex, 1);

            Data.Data = sf.GetDataTransformer().TransformData(((DataContainer)Data.Clone()).Data);
            chart2.Series["Series1"].Points.Clear();
            foreach (double x in Data.Data)
            {
                chart2.Series["Series1"].Points.AddY(x);
            }

            label1.Text = "Media: " + sf.GetMeanCalculator().CalculateMean(Data.Data).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataContainer Data = new DataContainer();
            Data.Data = Fact.GenerateDataGenerator(comboBox1.SelectedIndex).GenerateData();
            chart1.Series["Series1"].Points.Clear();
            foreach (double x in Data.Data)
            {
                chart1.Series["Series1"].Points.AddY(x);
            }

            IStatisticsFactory sf = TFact.GenerateDataTrans(comboBox2.SelectedIndex, 1);

            Data.Data = sf.GetDataTransformer().TransformData(((DataContainer)Data.Clone()).Data);
            chart2.Series["Series1"].Points.Clear();
            foreach (double x in Data.Data)
            {
                chart2.Series["Series1"].Points.AddY(x);
            }

            label1.Text = "Media: " + sf.GetMeanCalculator().CalculateMean(Data.Data).ToString();

        }
    }
}
