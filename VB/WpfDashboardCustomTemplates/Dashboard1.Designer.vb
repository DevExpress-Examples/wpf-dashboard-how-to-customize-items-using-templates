Namespace WpfDashboardCustomTemplates

    Partial Class Dashboard1

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WpfDashboardCustomTemplates.Dashboard1))
            Dim fieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim fieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim excelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim excelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
            Dim dimension1 As DevExpress.DashboardCommon.Dimension = New DevExpress.DashboardCommon.Dimension()
            Dim gridDimensionColumn1 As DevExpress.DashboardCommon.GridDimensionColumn = New DevExpress.DashboardCommon.GridDimensionColumn()
            Dim measure1 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn1 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure2 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn2 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure3 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn3 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim measure4 As DevExpress.DashboardCommon.Measure = New DevExpress.DashboardCommon.Measure()
            Dim gridMeasureColumn4 As DevExpress.DashboardCommon.GridMeasureColumn = New DevExpress.DashboardCommon.GridMeasureColumn()
            Dim dashboardLayoutGroup1 As DevExpress.DashboardCommon.DashboardLayoutGroup = New DevExpress.DashboardCommon.DashboardLayoutGroup()
            Dim dashboardLayoutItem1 As DevExpress.DashboardCommon.DashboardLayoutItem = New DevExpress.DashboardCommon.DashboardLayoutItem()
            Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
            Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
            CType((Me.dashboardExcelDataSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridDashboardItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((dimension1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((measure4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dashboardExcelDataSource1
            ' 
            Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
            Me.dashboardExcelDataSource1.FileName = "|DataDirectory|\Data\Sales.xlsx"
            Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
            Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
            fieldInfo1.Name = "Category"
            fieldInfo1.Type = GetType(String)
            fieldInfo2.Name = "Product"
            fieldInfo2.Type = GetType(String)
            fieldInfo3.Name = "State"
            fieldInfo3.Type = GetType(String)
            fieldInfo4.Name = "UnitsSoldYTD (Sum)"
            fieldInfo4.Type = GetType(Double)
            fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
            fieldInfo5.Type = GetType(Double)
            fieldInfo6.Name = "RevenueQTD (Sum)"
            fieldInfo6.Type = GetType(Double)
            fieldInfo7.Name = "RevenueQTDTarget (Sum)"
            fieldInfo7.Type = GetType(Double)
            fieldInfo8.Name = "RevenueYTD (Sum)"
            fieldInfo8.Type = GetType(Double)
            fieldInfo9.Name = "RevenueYTDTarget (Sum)"
            fieldInfo9.Type = GetType(Double)
            Me.dashboardExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
            excelWorksheetSettings1.CellRange = Nothing
            excelWorksheetSettings1.WorksheetName = "Sheet1"
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1
            Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
            ' 
            ' gridDashboardItem1
            ' 
            dimension1.DataMember = "Product"
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridDimensionColumn1.AddDataItem("Dimension", dimension1)
            measure1.DataMember = "RevenueQTD (Sum)"
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn1.AddDataItem("Measure", measure1)
            measure2.DataMember = "RevenueQTDTarget (Sum)"
            gridMeasureColumn2.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn2.AddDataItem("Measure", measure2)
            measure3.DataMember = "RevenueYTD (Sum)"
            gridMeasureColumn3.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn3.AddDataItem("Measure", measure3)
            measure4.DataMember = "RevenueYTDTarget (Sum)"
            gridMeasureColumn4.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
            gridMeasureColumn4.AddDataItem("Measure", measure4)
            Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() {gridDimensionColumn1, gridMeasureColumn1, gridMeasureColumn2, gridMeasureColumn3, gridMeasureColumn4})
            Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
            Me.gridDashboardItem1.DataItemRepository.Clear()
            Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
            Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
            Me.gridDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
            Me.gridDashboardItem1.DataItemRepository.Add(measure3, "DataItem3")
            Me.gridDashboardItem1.DataItemRepository.Add(measure4, "DataItem4")
            Me.gridDashboardItem1.DataSource = Me.dashboardExcelDataSource1
            Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
            Me.gridDashboardItem1.Name = "Grid 1"
            Me.gridDashboardItem1.ShowCaption = True
            ' 
            ' Dashboard1
            ' 
            Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() {Me.dashboardExcelDataSource1})
            Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() {Me.gridDashboardItem1})
            dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
            dashboardLayoutItem1.Weight = 49.94753410283316R
            dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() {dashboardLayoutItem1})
            dashboardLayoutGroup1.DashboardItem = Nothing
            Me.LayoutRoot = dashboardLayoutGroup1
            Me.Title.Text = "Dashboard"
            CType((Me.dashboardExcelDataSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((dimension1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((measure4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridDashboardItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

#End Region
        Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource

        Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
    End Class
End Namespace
