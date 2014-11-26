Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraEditors

Public Class FormMain
   

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
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
            My.Settings.Item("datosConnectionString") = xConnectionString
            configuracion.LoadSettings()
            cargarControles()

            If dbAdo.State = ConnectionState.Closed Then
                dbAdo.ConnectionString = xConnectionString
                dbAdo.Open()
            End If
            EjecutacpNegocioProdNet(clsNegocioProd)
            If configuracion.Linea <> 0 Then
                navButtonHome.Caption = Microsoft.VisualBasic.Left(clsNegocioProd.GetDatoTabla(configuracion.Linea, "CABECERAFABRICACION", gCodEmpresa, gEjercicio, "Descripcion", "ID", True) & Space(30), 30)
            Else
                config()
            End If
            miPrincipal.Visible = True
            controencurso = miPrincipal
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub navButtonSettings_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles navButtonSettings.ElementClick
        config()
    End Sub

    Private Sub navButtonClose_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles navButtonClose.ElementClick
        Close()
    End Sub
    Public Sub config()
        Dim settingsUc As New SettingsUC

        Dim result As DialogResult = FlyoutDialog.Show(Me, settingsUc)
        If result = System.Windows.Forms.DialogResult.OK Then
            configuracion.Linea = settingsUc.cmbLineas.EditValue
            configuracion.SaveSettings()
            navButtonHome.Caption = Microsoft.VisualBasic.Left(clsNegocioProd.GetDatoTabla(configuracion.Linea, "CABECERAFABRICACION", gCodEmpresa, gEjercicio, "Descripcion", "ID", True) & Space(30), 30)
        Else
            navButtonHome.Caption = "Linea no configurada"
        End If
    End Sub
    Sub cargarcontroles()
        misOrdenes = New Ordenes
        Me.PanelControl1.Controls.Add(misOrdenes)
        misOrdenes.Dock = DockStyle.Fill
        misOrdenes.Visible = False
        misSettings = New SettingsUC
        Me.PanelControl1.Controls.Add(misSettings)
        misSettings.Dock = DockStyle.Fill
        misSettings.Visible = False
        miPrincipal = New Principal
        Me.PanelControl1.Controls.Add(miPrincipal)
        miPrincipal.Dock = DockStyle.Fill
        miPrincipal.Visible = False

    End Sub

    Private Sub Ordenes_ItemClick(sender As Object, e As TileItemEventArgs) Handles Ordenes.ItemClick
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)
            controencurso = misOrdenes
            misOrdenes.BotonLinea = navButtonOrden

            misOrdenes.Visible = True
            miPrincipal.Visible = False
        End Using
    End Sub

    'Private Sub Home_ItemPress(sender As Object, e As TileItemEventArgs)
    '    If controencurso.Name <> "Principal" Then
    '        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

    '            controencurso.Visible = False
    '            miPrincipal.Visible = True
    '            Select Case controencurso.Name
    '                Case "Ordenes"

    '            End Select
    '            controencurso = miPrincipal
    '        End Using

    '    End If
    'End Sub
End Class
