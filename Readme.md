<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574251/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1367)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/GridLinesTickmarks/Form1.cs) (VB: [Form1.vb](./VB/GridLinesTickmarks/Form1.vb))
<!-- default file list end -->
# How to customize the appearance of axis tickmarks and grid lines

This example demonstrates how [grid lines and tickmarks](https://docs.devexpress.com/WindowsForms/5782/controls-and-libraries/chart-control/axes/grid-lines-tickmarks-and-interlacing?p=netframework) of an [axis](https://docs.devexpress.com/WindowsForms/5779/controls-and-libraries/chart-control/diagram/axes) can be customized at runtime.

To access an axis, you should cast your chart's [diagram](https://docs.devexpress.com/WindowsForms/DevExpress.XtraCharts.ChartControl.Diagram?p=netframework) object to the required diagram type. Then, use the [Tickmarks](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.Axis2D.Tickmarks?p=netframework) and [GridLines](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.GridLines?p=netframework) properties to access the corresponding elements. To define the number of minor tickmarks (grid lines), use the [MinorCount](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.AxisBase.MinorCount?p=netframework) property of an axis.
