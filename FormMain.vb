Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraEditors

Public Class FormMain

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        xPath = GetSetting("Gestion V.4", "Instalacion", "Path")
        AppPath = GetSetting("Gestion V.4", "Instalacion", "AppPath")
        gCodEmpresa = GetSetting("Gestion V.4", "Empresas", "Codigo")
        gEjercicio = GetSetting("Gestion V.4", "Empresas", "Ejercicio")
        xNombreBase = GetSetting("Gestion V.4", "Instalacion", "NombreBaseGestion")
        xConnectionProd = LeerConfiguracion(GetSetting("Gestion V.4", "Instalacion", "AppPath"))
        xConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xPath & "\" & xNombreBase & ";Persist Security Info=True;Jet OLEDB:Database Password=77"
        xConnectionGrupos = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xPath & "\GRUPOS.MDE;"
        'My.Settings.Item("datosConnectionString") = xConnectionString
        My.Settings.Item("produccionSqlConnectionString") = "Data Source=" & strSERVERPROD & ";Initial Catalog=" & strDATABASEPROD & ";User ID=" & strUIDPROD & ";Password=" & strPWDPROD & ";"
        Dim touchScaleFactor As Single, fontSize As Single
        ' GesLineas.Common.Utils.DeviceDetector.SuggestHybridDemoParameters(touchScaleFactor, fontSize)
        WindowsFormsSettings.DefaultFont = New Font("Segoe UI", fontSize)
        WindowsFormsSettings.DefaultMenuFont = New Font("Segoe UI", fontSize)
    End Sub

    Private Sub navButtonSettings_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles navButtonSettings.ElementClick
        Dim settingsUc As New SettingsUC

        'Dim settingsUC As New settinsuc

        'settingsUC.allowTransitionCheckEdit.Checked = allowTransition
        'settingsUC.comboBoxEdit.EditValue = tType
        'settingsUC.fullScreenCheckEdit.Checked = FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Dim result As DialogResult = FlyoutDialog.Show(Me, settingsUc)
        If result = System.Windows.Forms.DialogResult.OK Then
            '    allowTransition = settingsUC.allowTransitionCheckEdit.Checked
            '    SetFullScreenMode(settingsUC)
            '    SetTransitionType(settingsUC)
        End If
    End Sub

    Private Sub navButtonClose_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles navButtonClose.ElementClick
        Close()
    End Sub
End Class
