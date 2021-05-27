<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GridLinesTickmarks/Form1.cs) (VB: [Form1.vb](./VB/GridLinesTickmarks/Form1.vb))
<!-- default file list end -->
# How to customize the appearance of axis tickmarks and grid lines

This example demonstrates how [grid lines and tickmarks](https://docs.devexpress.com/WindowsForms/5782/controls-and-libraries/chart-control/axes/grid-lines-tickmarks-and-interlacing?p=netframework) of an [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes) can be customized at runtime.

To access an axis, you should cast your chart's [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to the required diagram type. Then, use the [Tickmarks](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Axis2D.Tickmarks?p=netframework) and [GridLines](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.GridLines?p=netframework) properties to access the corresponding elements. To define the number of minor tickmarks (grid lines), use the [MinorCount](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.MinorCount?p=netframework) property of an axis.
