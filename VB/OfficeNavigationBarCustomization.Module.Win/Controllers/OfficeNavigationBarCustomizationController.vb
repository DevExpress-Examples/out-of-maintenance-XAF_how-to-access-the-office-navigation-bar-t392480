Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Templates
Imports DevExpress.XtraBars.Ribbon

Namespace CustomizeOfficeNavigationBar.Win
    Public Class OfficeNavigationBarCustomizationController
        Inherits WindowController

        Private Sub Frame_TemplateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As Form = TryCast(Frame.Template, Form)
            If form IsNot Nothing Then
                AddHandler form.Load, AddressOf Form_Load
            End If
        End Sub
        Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim officeNavigationBarHolder As IOfficeNavigationBarHolder = TryCast(sender, IOfficeNavigationBarHolder)
            If officeNavigationBarHolder IsNot Nothing Then
                officeNavigationBarHolder.OfficeNavigationBar.MaxItemCount = 4
            End If
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            AddHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler Frame.TemplateChanged, AddressOf Frame_TemplateChanged
            MyBase.OnDeactivated()
        End Sub

        Public Sub New()
            TargetWindowType = WindowType.Main
        End Sub
    End Class
End Namespace
