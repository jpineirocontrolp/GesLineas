Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OleDb
Imports DevExpress.XtraBars.Docking2010.Customization
Imports System.Globalization

Public Class Principal

    Public Sub New()
        Try
            ' Llamada necesaria para el diseñador.
            InitializeComponent()

            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LoadData()
        Me.Partes_de_produccionTableAdapter.Fill(Me.ProduccionSql.Partes_de_produccion, configuracion.Linea, NroOrden, gCodEmpresa, gEjercicio)
        Me.ARTICULOSTableAdapter.Fill(Me.DatosDataset.ARTICULOS, gCodEmpresa, gEjercicio)
        Me.PL_ACCIONESTableAdapter.Fill(Me.ProduccionSql.PL_ACCIONES, gCodEmpresa, gEjercicio)
        Me.TANQUES1TableAdapter.Fill(Me.ProduccionSql.TANQUES1, gCodEmpresa, gEjercicio)
        Dim myLookUp As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
        Dim LST As New Dictionary(Of String, String)
        LST.Add("1", "Pendiente")
        LST.Add("2", "En Cola")
        LST.Add("3", "En Produccion")
        LST.Add("4", "Finalizada")
        myLookUp.DisplayMember = "Value"
        myLookUp.ValueMember = "Key"
        myLookUp.Columns.Add(New LookUpColumnInfo("Value", 1, "Pendiente"))
        myLookUp.DataSource = LST
        GridView2.Columns("ESTADO").ColumnEdit = myLookUp
        Dim da As OleDbDataAdapter
        Dim cmd As OleDbCommand
        da = New OleDbDataAdapter("SELECT id,IdLinea,IdEnvase    from pl_lineasenvases where CODEMPRESA='" & gCodEmpresa & "' AND eJERCICIO='" & gEjercicio & "'", dbProd)
        Dim dtFormatos As New DataTable
        da.Fill(dtFormatos)
        dtFormatos.Columns.Add("Descripcion", GetType(String))
        For Each item In dtFormatos.Rows
            cmd = New OleDbCommand("Select descripcion from envases where id=" & item("idenvase") & " and codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "'", dbAdo)
            item("Descripcion") = cmd.ExecuteScalar
        Next
        Dim gle As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
        gle.DataSource = dtFormatos
        gle.ValueMember = "id"
        gle.DisplayMember = "Descripcion"
        GridView2.Columns("idEnvase").ColumnEdit = gle
        gle = New RepositoryItemLookUpEdit
        gle.DataSource = ProduccionSql.TANQUES1
        gle.ValueMember = "ID"
        gle.DisplayMember = "CODIGO"
        GridView2.Columns("TANQUE").ColumnEdit = gle
        gle = New RepositoryItemLookUpEdit
        gle.DataSource = DatosDataset.ARTICULOS
        gle.ValueMember = "Id"
        gle.DisplayMember = "Descripcion"
        GridView2.Columns("Articulo").ColumnEdit = gle

        GridView2.BestFitColumns()
        GridView1.BestFitColumns()
        GridView3.BestFitColumns()


    End Sub
    Sub loadDataOperaciones()
        Me.PL_CABECERAPRODUCIDATableAdapter.Fill(Me.ProduccionSql.PL_CABECERAPRODUCIDA, miLinea, gCodEmpresa, gEjercicio)
        Me.PL_LINEASPRODUCIDASTableAdapter.Fill(Me.ProduccionSql.PL_LINEASPRODUCIDAS, gCodEmpresa, gEjercicio)
        Me.PL_TURNOSTableAdapter.Fill(Me.ProduccionSql.PL_TURNOS, gCodEmpresa, gEjercicio)
        Me.PL_OPERACIONES1TableAdapter.Fill(Me.ProduccionSql.PL_OPERACIONES1, gCodEmpresa, gEjercicio)

        ExpandAllRows(GridView1)
        GridView3.FocusedRowHandle = GridView3.DataRowCount - 1
    End Sub

    Private Sub cbAcciones_EditValueChanged(sender As Object, e As EventArgs) Handles cbAcciones.EditValueChanged
        Me.PL_OPERACIONESTableAdapter.Fill(Me.ProduccionSql.PL_OPERACIONES, gCodEmpresa, gEjercicio, configuracion.Linea, cbAcciones.EditValue)
        cbOperaciones.Refresh()
    End Sub

    Private Sub GridView2_Click(sender As Object, e As EventArgs) Handles GridView2.Click
        Dim view As GridView = TryCast(sender, GridView)
        If Not view.IsEmpty Then
            Observaciones.Text = view.GetDataRow(view.FocusedRowHandle)("Observaciones").ToString()
        End If
    End Sub



    Private Sub GridView2_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView2.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim miEstado As Double = View.GetDataRow(e.RowHandle)("ESTADO")

            If miEstado = 3 Then
                e.Appearance.BackColor = Color.IndianRed
            ElseIf miEstado = 4 Then
                e.Appearance.BackColor = Color.LawnGreen
            End If
        End If
    End Sub

    Private Sub AceptaAccion_Click(sender As Object, e As EventArgs) Handles AceptaAccion.Click
        Dim cmd As New OleDbCommand
        Dim miLineacopia As Integer = miLinea
        Dim idCabeceraCopia As Integer = idCabecera
        Dim idLineaCopia As Integer = idLinea
        Dim miLoteCopia As String = miLoteGlobal

        Dim operacion As Integer = IIf(miPrincipal.cbOperaciones.EditValue Is Nothing, 0, miPrincipal.cbOperaciones.EditValue)
        Dim accion As Integer = IIf(miPrincipal.cbAcciones.EditValue Is Nothing, 0, miPrincipal.cbAcciones.EditValue)
        If operacion = 0 And accion = 0 Then
            MsgBox("Debe de elegir al menos una acción")
            Exit Sub
        End If

        Try
            miTrans = dbProd.BeginTransaction
            If FinDeLinea() Then
                If InsertarLinea(accion, operacion, Date.Now, Nothing, 0, Nothing) Then
                    miTrans.Commit()
                    Select Case accion

                        Case configuracion.AccionAveria
                            Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)
                                controencurso = misAverias

                                misAverias.accion = accion

                                misAverias.loaddata()
                                misAverias.Visible = True
                                miPrincipal.Visible = False

                            End Using
                        Case configuracion.AccionParada
                            Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)
                                controencurso = misAverias
                                misAverias.accion = accion


                                misAverias.loaddata()
                                misAverias.Visible = True
                                miPrincipal.Visible = False

                            End Using
                        Case configuracion.AccionAjuste
                            Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)
                                controencurso = misAverias
                                misAverias.accion = accion


                                misAverias.loaddata()
                                misAverias.Visible = True
                                miPrincipal.Visible = False

                            End Using
                        Case configuracion.AccionLoteado

                            'Dim rowHandle As Integer = GetRowHandleByColumnValue(miPrincipal.GridView2, "id", miLinea, miPrincipal.GridControl2)
                            '' Dim Col As DevExpress.XtraGrid.Columns.GridColumn = miPrincipal.GridView2.Columns("id")
                            '' Dim rowhandle As Integer = miPrincipal.GridView2.LocateByValue(miLinea, Col, "id")
                            Dim Loteado As New Loteado
                            Loteado.loadData()
                            Dim result As DialogResult = FlyoutDialog.Show(FormMain, Loteado)
                            If result = System.Windows.Forms.DialogResult.Cancel Then
                                Loteado.Dispose()
                                Exit Sub
                            Else
                                miLoteGlobal = Loteado.miLote
                                Loteado.Dispose()
                            End If
                            miTrans = dbProd.BeginTransaction
                            If FinDeLinea() Then

                                If InsertaCabecera(idArticulo, miTrans, miLoteGlobal) Then


                                Else
                                    miTrans.Rollback()
                                    miLinea = miLineacopia
                                    idCabecera = idCabeceraCopia
                                    idLinea = idLineaCopia
                                    miLoteGlobal = miLoteCopia
                                    Exit Sub
                                End If

                                cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and ID=" & configuracion.AccionLoteado, dbProd, miTrans)
                                Try
                                    miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar
                                Catch EX As Exception
                                    cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and ID=" & configuracion.AccionDefecto, dbProd, miTrans)
                                    miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar
                                End Try

                                If InsertarLinea(miPrincipal.cbAcciones.EditValue, 0, Date.Now, Nothing, 0, Nothing) Then
                                    miTrans.Commit()
                                Else
                                    miLinea = miLineacopia
                                    idCabecera = idCabeceraCopia
                                    idLinea = idLineaCopia
                                    miLoteGlobal = miLoteCopia
                                    miTrans.Rollback()

                                    Exit Sub
                                End If
                            Else
                                miTrans.Rollback()
                                miLinea = miLineacopia
                                idCabecera = idCabeceraCopia
                                idLinea = idLineaCopia
                                Exit Sub
                            End If
                            ' PONER COMO PRIMERA ACCION CAMBIO
                            'cmd = New OleDbCommand("Select id from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd, miTrans)
                            'miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar

                            cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd)
                            miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar

                            controencurso = miPrincipal
                            miPrincipal.LoadData()
                            miPrincipal.loadDataOperaciones()
                            miPrincipal.GridControl2.RefreshDataSource()


                        Case Else
                            cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and id=" & accion, dbProd)
                            If Not IsDBNull(cmd.ExecuteScalar) Then miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar Else miPrincipal.cbAcciones.EditValue = 0
                            miPrincipal.cbOperaciones.EditValue = 0

                            miPrincipal.LoadData()
                            miPrincipal.loadDataOperaciones()
                            miPrincipal.GridControl2.RefreshDataSource()
                    End Select
                Else
                    miLinea = miLineacopia
                    idCabecera = idCabeceraCopia
                    idLinea = idLineaCopia
                    miTrans.Rollback()
                    miPrincipal.LoadData()
                    miPrincipal.loadDataOperaciones()
                    miPrincipal.GridControl2.RefreshDataSource()
                    Exit Sub
                End If

            Else
                miTrans.Rollback()
                miLinea = miLineacopia
                idCabecera = idCabeceraCopia
                idLinea = idLineaCopia
                miPrincipal.LoadData()
                miPrincipal.loadDataOperaciones()
                miPrincipal.GridControl2.RefreshDataSource()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Debe de elegir al menos una accion")
            miTrans.Rollback()
            miLinea = miLineacopia
            idCabecera = idCabeceraCopia
            idLinea = idLineaCopia
            miPrincipal.LoadData()
            miPrincipal.loadDataOperaciones()
            miPrincipal.GridControl2.RefreshDataSource()
        End Try


    End Sub


    Private Sub GridControl2_Click(sender As Object, e As EventArgs) Handles GridControl2.Click

    End Sub

    Private Sub GridView1_RowStyle(sender As Object, e As RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim miEstado As String = View.GetRowCellDisplayText(e.RowHandle, "IDARTICULO")
            LabelControl2.Text = miEstado
            lblInicio.Text = View.GetRowCellDisplayText(e.RowHandle, "INICIO")
         

            'If miEstado = 3 Then
            '    e.Appearance.BackColor = Color.IndianRed
            'ElseIf miEstado = 4 Then
            '    e.Appearance.BackColor = Color.LawnGreen
            'End If
        End If
    End Sub

    
End Class
