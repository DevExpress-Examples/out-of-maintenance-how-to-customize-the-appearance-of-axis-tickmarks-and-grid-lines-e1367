using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace GridLinesTickmarks {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl chartControl1 = new ChartControl();

            // Create a bar series and add points to it.
            Series series1 = new Series("Series 1", ViewType.Bar);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 12 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 17 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 14 }));
            series1.Points.Add(new SeriesPoint("E", new double[] { 17 }));

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Hide the legend and series labels (if necessary).
            chartControl1.Legend.Visible = false;
            series1.Label.Visible = false;

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;

            // Customize the appearance of the axes' tickmarks.
            diagram.AxisX.Tickmarks.CrossAxis = true;
            diagram.AxisX.Tickmarks.Length = 5;
            diagram.AxisX.Tickmarks.Thickness = 2;

            diagram.AxisY.Tickmarks.Visible = false;
            diagram.AxisY.Tickmarks.MinorVisible = false;

            diagram.AxisX.Tickmarks.MinorLength = 3;
            diagram.AxisX.Tickmarks.MinorThickness = 1;

            diagram.AxisX.MinorCount = 2;
            diagram.AxisY.MinorCount = 4;

            // Customize the appearance of the axes' grid lines.
            diagram.AxisX.GridLines.Visible = false;
            diagram.AxisX.GridLines.MinorVisible = false;

            diagram.AxisY.GridLines.Visible = true;
            diagram.AxisY.GridLines.MinorVisible = true;

            diagram.AxisY.GridLines.Color = Color.Red;
            diagram.AxisY.GridLines.LineStyle.DashStyle = DashStyle.Solid;
            diagram.AxisY.GridLines.LineStyle.Thickness = 2;

            diagram.AxisY.GridLines.MinorColor = Color.Blue;
            diagram.AxisY.GridLines.MinorLineStyle.DashStyle = DashStyle.Dash;
            diagram.AxisY.GridLines.MinorLineStyle.Thickness = 1;

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

    }
}