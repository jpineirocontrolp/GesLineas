Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OleDb

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
            cargarcontroles()
            Me.PL_TURNOSTableAdapter.Fill(Me.ProduccionSql.PL_TURNOS, gCodEmpresa, gEjercicio)
            Me.OPERARIOSTableAdapter.Fill(Me.ProduccionSql.OPERARIOS, gCodEmpresa, gEjercicio)
            If dbAdo.State = ConnectionState.Closed Then
                dbAdo.ConnectionString = xConnectionString
                dbAdo.Open()
            End If
            If dbProd.State = ConnectionState.Closed Then
                dbProd.ConnectionString = xConnectionProd
                dbProd.Open()
            End If
            EjecutacpNegocioProdNet(clsNegocioProd)
            EjecutacpNegocioNet(clsNegocioNet)
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
        clsNegocioNet.dispose()
        clsNegocioProd.Dispose()
        Close()
    End Sub
    Public Sub config()
        Dim settingsUc As New SettingsUC

        Dim result As DialogResult = FlyoutDialog.Show(Me, settingsUc)
        If result = System.Windows.Forms.DialogResult.OK Then
            configuracion.LoadSettings()
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
        Me.PanelControl1.Controls.Add(misRoturas)
        misRoturas.Dock = DockStyle.Fill
        misRoturas.Visible = True

        If NroOrden = 0 Then
            Envasar.Enabled = False
            btRoturas.Enabled = False
        Else
            BuscarOrdenes.Enabled = True
        End If

    End Sub

    Private Sub BuscarOrdenes_ItemClick(sender As Object, e As TileItemEventArgs) Handles BuscarOrdenes.ItemClick
        'If Then
        If cmbOperarios.EditValue.ToString <> "" And Not cmbTurno.EditValue Is Nothing Then
            Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)
                controencurso = misOrdenes
                misOrdenes.BotonLinea = navButtonOrden
                misOrdenes.BtBuscaOrdenes = BuscarOrdenes
                misOrdenes.btEnvasar = Envasar
                misOrdenes.Visible = True
                miPrincipal.Visible = False

            End Using
        Else
            MsgBox("Debe de elegir un turno y un operario")
            'End If
        End If
    End Sub



    Private Sub Envasar_ItemClick(sender As Object, e As TileItemEventArgs) Handles Envasar.ItemClick
        Dim miLineacopia As Integer = miLinea
        Dim idCabeceracopia As Integer = idCabecera
        Dim idLineaCopia As Integer = idLinea
        Try
            Dim blnContinuar As Boolean = False
            Dim cmd As New OleDbCommand
            ' poner controles editables

            If miLinea <> 0 Then
                If MsgBox("Desea finalizar el envasado de esta referencia?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ' pongo la linea como finalizada
                    miTrans = dbProd.BeginTransaction

                    If FinDeLinea() Then

                        cmd = New OleDbCommand("update pl_partesproduccion set estado=4 where id=" & miLinea, dbProd, miTrans)
                        cmd.ExecuteNonQuery()
                        If OrdenFinalizada(miPrincipal.GridView2) Then
                            miTrans.Commit()
                            MsgBox("Se ha terminado la orden de producción")
                            BuscarOrdenes.Enabled = True
                            Envasar.Enabled = False
                            miPrincipal.GridControl2.DataSource = Nothing
                            miPrincipal.GridControl2.RefreshDataSource()
                            miPrincipal.GridControl1.DataSource = Nothing
                            miPrincipal.GridControl1.RefreshDataSource()
                            misOrdenes.loaddata()
                            misOrdenes.GridControl1.RefreshDataSource()
                            miPrincipal.cbAcciones.Properties.ReadOnly = True
                            miPrincipal.cbOperaciones.Properties.ReadOnly = True
                            miPrincipal.AceptaAccion.Enabled = False
                            Exit Sub
                        End If
                        cmd = New OleDbCommand("Select id from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd, miTrans)
                        miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar

                        FindRowHandleByDataRow(miPrincipal.GridView2)
                        cmd = New OleDbCommand("Select ARTICULO FROM PL_PARTESPRODUCCION WHERE CodEmpresa= '" & gCodEmpresa & "' and Ejercicio='" & gEjercicio & "' and ID=" & miLinea, dbProd, miTrans)

                        Dim idarticulo As Integer = cmd.ExecuteScalar
                        cmd = New OleDbCommand("update pl_partesproduccion set estado=3 where id=" & miLinea, dbProd, miTrans)
                        cmd.ExecuteNonQuery()
                        If InsertaCabecera(idarticulo, miTrans) Then


                        Else
                            miTrans.Rollback()
                            miLinea = miLineacopia
                            idCabecera = idCabeceracopia
                            idLinea = idLineaCopia
                            Exit Sub
                        End If
                        If InsertarLinea(miPrincipal.cbAcciones.EditValue, 0, Date.Now, Nothing, 0, Nothing) Then
                            miTrans.Commit()
                        Else
                            miLinea = miLineacopia
                            idCabecera = idCabeceracopia
                            idLinea = idLineaCopia
                            miTrans.Rollback()
                            Exit Sub
                        End If
                    Else
                        miTrans.Rollback()
                        miLinea = miLineacopia
                        idCabecera = idCabeceracopia
                        idLinea = idLineaCopia
                        Exit Sub
                    End If
                    ' PONER COMO PRIMERA ACCION CAMBIO
                    cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd)
                    miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar

                    miPrincipal.LoadData()
                    miPrincipal.loadDataOperaciones()
                    miPrincipal.GridControl2.RefreshDataSource()

                    'miPrincipal.LoadData()
                    ''Dim row As DataRow = miPrincipal.GridView2.GetDataRow(miManejador)
                    ''row("ESTADO") = 4
                    'miPrincipal.GridControl2.RefreshDataSource()
                   
                    blnContinuar = True
                Else
                    blnContinuar = False
                End If
            Else
                miPrincipal.cbAcciones.Properties.ReadOnly = False
                miPrincipal.cbOperaciones.Properties.ReadOnly = False
                miPrincipal.AceptaAccion.Enabled = True

                ' cargo el primer elemento de la grid
                Dim CurrentRow As Integer

                CurrentRow = FindRowHandleByDataRow(miPrincipal.GridView2)
                miPrincipal.GridView2.FocusedRowHandle = CurrentRow
                Dim idarticulo As Integer = clsNegocioProd.GetDatoTabla(miLinea, "PL_PARTESPRODUCCION", gCodEmpresa, gEjercicio, "ARTICULO", "ID")
                miTrans = dbProd.BeginTransaction
                cmd = New OleDbCommand("update pl_partesproduccion set estado=3 where id=" & miLinea, dbProd, miTrans)
                cmd.ExecuteNonQuery()
                If idCabecera = 0 Then
                    If InsertaCabecera(idarticulo, miTrans) Then
                        cmd = New OleDbCommand("Select id from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd, miTrans)
                        miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar
                        If InsertarLinea(miPrincipal.cbAcciones.EditValue, 0, Date.Now, Nothing, 0, Nothing) Then
                            miTrans.Commit()
                            miPrincipal.LoadData()
                            miPrincipal.loadDataOperaciones()
                            miPrincipal.GridControl2.RefreshDataSource()

                        Else
                            miTrans.Rollback()
                            miLinea = miLineacopia
                            idCabecera = idCabeceracopia
                            idLinea = idLineaCopia
                            miPrincipal.LoadData()
                            miPrincipal.loadDataOperaciones()
                            miPrincipal.GridControl2.RefreshDataSource()
                            Exit Sub
                        End If
                        ' PONER COMO PRIMERA ACCION CAMBIO
                        cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd, miTrans)
                        miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar

                    Else

                        miLinea = miLineacopia
                        idCabecera = idCabeceracopia
                        idLinea = idLineaCopia
                        miTrans.Rollback()
                        miPrincipal.LoadData()
                        miPrincipal.loadDataOperaciones()
                        miPrincipal.GridControl2.RefreshDataSource()
                        Exit Sub
                    End If

                End If

            End If

        Catch ex As Exception
            If Not miTrans Is Nothing Then
                miTrans.Rollback()
            End If
            miLinea = miLineacopia
            idCabecera = idCabeceracopia
            idLinea = idLineaCopia

            MsgBox(ex.Message)
            miPrincipal.LoadData()
            miPrincipal.loadDataOperaciones()
            miPrincipal.GridControl2.RefreshDataSource()
        End Try
    End Sub
    Private Function FindRowHandleByDataRow(ByVal view As GridView) As Integer

        Dim I As Integer
        For I = 0 To view.DataRowCount - 1
            If view.GetDataRow(I)("ESTADO") = 2 Then
                Dim row As DataRowView = view.GetRow(I)
                'Change the Phone field via the bound data source 
                row.Row("ESTADO") = 3
                miLinea = row.Row("ID")
                miPrincipal.Observaciones.Text = row.Row("OBSERVACIONES")
                miManejador = I
                Return I
            End If
        Next
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle

    End Function
    Private Function OrdenFinalizada(ByVal view As GridView) As Boolean

        Dim I As Integer
        For I = 0 To view.DataRowCount - 1
            If view.GetDataRow(I)("ESTADO") <> 4 Then
                Return False
            End If
        Next
        Return True

    End Function
   

    Private Sub cmbTurno_EditValueChanged(sender As Object, e As EventArgs) Handles cmbTurno.EditValueChanged
        CambioTurno()
    End Sub

    Private Sub cmbOperarios_EditValueChanged(sender As Object, e As EventArgs) Handles cmbOperarios.EditValueChanged
        CambioOperario()
    End Sub
End Class
