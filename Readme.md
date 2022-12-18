<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/143311307/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830550)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfDashboardCustomTemplates/MainWindow.xaml)
<!-- default file list end -->

# Dashboard for WPF - How to customize the GridDashboardItem using template

This example demonstrates how to use the [DashboardControl.GridItemStyle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.GridItemStyle) property in XAML to apply a custom template that allows an end-user to move grid columns by dragging their headers.

A custom style has the [GridDashboardLayoutItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.GridDashboardLayoutItem) class as its target type. A data template used as the style's content template sets the [GridControl.View.AllowMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.AllowColumnMoving) property to **true**.

## Documentation

* [DevExpress WPF Controls Common Concepts](https://docs.devexpress.com/WPF/6794)
* [DevExpress MVVM Framework for WPF](https://docs.devexpress.com/WPF/15112)
* [WPF Dashboard Viewer - Styles and Templates](https://docs.devexpress.com/Dashboard/400142)

## More Examples

* [Dashboard for WPF - How to embed a DevExpress control in the WPF Dashboard](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-embed-devexpress-control)
