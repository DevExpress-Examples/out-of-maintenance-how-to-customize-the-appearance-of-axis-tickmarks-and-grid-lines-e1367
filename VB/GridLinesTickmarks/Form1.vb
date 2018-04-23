Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace GridLinesTickmarks
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim chartControl1 As New ChartControl()

			' Create a bar series and add points to it.
			Dim series1 As New Series("Series 1", ViewType.Bar)
			series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
			series1.Points.Add(New SeriesPoint("B", New Double() { 12 }))
			series1.Points.Add(New SeriesPoint("C", New Double() { 17 }))
			series1.Points.Add(New SeriesPoint("D", New Double() { 14 }))
			series1.Points.Add(New SeriesPoint("E", New Double() { 17 }))

			' Add the series to the chart.
			chartControl1.Series.Add(series1)

			' Hide the legend and series labels (if necessary).
			chartControl1.Legend.Visible = False
			series1.Label.Visible = False

			' Cast the chart's diagram to the XYDiagram type, to access its axes.
			Dim diagram As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)

			' Customize the appearance of the axes' tickmarks.
			diagram.AxisX.Tickmarks.CrossAxis = True
			diagram.AxisX.Tickmarks.Length = 5
			diagram.AxisX.Tickmarks.Thickness = 2

			diagram.AxisY.Tickmarks.Visible = False
			diagram.AxisY.Tickmarks.MinorVisible = False

			diagram.AxisX.Tickmarks.MinorLength = 3
			diagram.AxisX.Tickmarks.MinorThickness = 1

			diagram.AxisX.MinorCount = 2
			diagram.AxisY.MinorCount = 4

			' Customize the appearance of the axes' grid lines.
			diagram.AxisX.GridLines.Visible = False
			diagram.AxisX.GridLines.MinorVisible = False

			diagram.AxisY.GridLines.Visible = True
			diagram.AxisY.GridLines.MinorVisible = True

			diagram.AxisY.GridLines.Color = Color.Red
			diagram.AxisY.GridLines.LineStyle.DashStyle = DashStyle.Solid
			diagram.AxisY.GridLines.LineStyle.Thickness = 2

			diagram.AxisY.GridLines.MinorColor = Color.Blue
			diagram.AxisY.GridLines.MinorLineStyle.DashStyle = DashStyle.Dash
			diagram.AxisY.GridLines.MinorLineStyle.Thickness = 1

			' Add the chart to the form.
			chartControl1.Dock = DockStyle.Fill
			Me.Controls.Add(chartControl1)
		End Sub

	End Class
End Namespace