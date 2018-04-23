Namespace OfficeNavigationBarCustomization.Win
    Partial Public Class OfficeNavigationBarCustomizationWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New CustomizeOfficeNavigationBar.OfficeNavigationBarCustomizationModule()
            Me.module4 = New CustomizeOfficeNavigationBar.Win.OfficeNavigationBarCustomizationWindowsFormsModule()
            Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.chartModule = New DevExpress.ExpressApp.Chart.ChartModule()
            Me.chartWindowsFormsModule = New DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule()
            Me.conditionalAppearanceModule = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            Me.kpiModule = New DevExpress.ExpressApp.Kpi.KpiModule()
            Me.reportsModuleV2 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.reportsWindowsFormsModuleV2 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
            Me.schedulerModuleBase = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
            Me.schedulerWindowsFormsModule = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
            Me.validationModule = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.validationWindowsFormsModule = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            ' reportsModuleV2
            '
            Me.reportsModuleV2.EnableInplaceReports = True
            Me.reportsModuleV2.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
            Me.reportsModuleV2.ShowAdditionalNavigation = False
            Me.reportsModuleV2.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML
            ' 
            ' OfficeNavigationBarCustomizationWindowsFormsApplication
            ' 
            Me.ApplicationName = "OfficeNavigationBarCustomization"
            Me.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.objectsModule)
            Me.Modules.Add(Me.chartModule)
            Me.Modules.Add(Me.chartWindowsFormsModule)
            Me.Modules.Add(Me.conditionalAppearanceModule)
            Me.Modules.Add(Me.kpiModule)
            Me.Modules.Add(Me.reportsModuleV2)
            Me.Modules.Add(Me.reportsWindowsFormsModuleV2)
            Me.Modules.Add(Me.schedulerModuleBase)
            Me.Modules.Add(Me.schedulerWindowsFormsModule)
            Me.Modules.Add(Me.validationModule)
            Me.Modules.Add(Me.validationWindowsFormsModule)
            Me.UseOldTemplates = False
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.OfficeNavigationBarCustomizationWindowsFormsApplication_DatabaseVersionMismatch)
'            Me.CustomizeLanguagesList += New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(Me.OfficeNavigationBarCustomizationWindowsFormsApplication_CustomizeLanguagesList)

            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As CustomizeOfficeNavigationBar.OfficeNavigationBarCustomizationModule
        Private module4 As CustomizeOfficeNavigationBar.Win.OfficeNavigationBarCustomizationWindowsFormsModule
        Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private chartModule As DevExpress.ExpressApp.Chart.ChartModule
        Private chartWindowsFormsModule As DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule
        Private conditionalAppearanceModule As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private kpiModule As DevExpress.ExpressApp.Kpi.KpiModule
        Private reportsModuleV2 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsWindowsFormsModuleV2 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
        Private schedulerModuleBase As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
        Private schedulerWindowsFormsModule As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
        Private validationModule As DevExpress.ExpressApp.Validation.ValidationModule
        Private validationWindowsFormsModule As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
    End Class
End Namespace
