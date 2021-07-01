# Dashboard for WPF - How to customize the GridDashboardItem using template

This example demonstrates how to use the [DashboardControl.GridItemStyle](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControlBase.GridItemStyle) property in XAML to apply a custom template that allows an end-user to move grid columns by dragging their headers.

A custom style has the [GridDashboardLayoutItem](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.GridDashboardLayoutItem) class as its target type. A data template used as the style's content template sets the [GridControl.View.AllowMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.AllowColumnMoving) property to **true**.
