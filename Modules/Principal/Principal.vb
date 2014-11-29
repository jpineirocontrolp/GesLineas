Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OleDb

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

    Private Sub GridView2_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GridView2.CustomColumnDisplayText
       
        If e.Column.FieldName = "Formato" Then
            Try

                Dim view As GridView = TryCast(sender, GridView)
                Dim row As DataRowView = view.GetRow(view.GetRowHandle(e.ListSourceRowIndex))

                If row.Row("idenvase") = 0 Then e.DisplayText = ""
                Dim cmd As New OleDbCommand
                cmd = New OleDbCommand("Select idenvase from PL_LINEASENVASES WHERE ID=" & row.Row("Idenvase"), dbProd)
                Dim idEnvase As Integer = cmd.ExecuteScalar

                cmd = New OleDbCommand("Select descripcion from envases where id=" & idEnvase, dbAdo)
                e.DisplayText = cmd.ExecuteScalar
            Catch ex As Exception
                e.DisplayText = ""
            End Try

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
                  
                    cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and id=" & accion, dbProd)
                    If Not IsDBNull(cmd.ExecuteScalar) Then miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar Else miPrincipal.cbAcciones.EditValue = 0
                    miPrincipal.cbOperaciones.EditValue = 0

                    miPrincipal.LoadData()
                    miPrincipal.loadDataOperaciones()
                    miPrincipal.GridControl2.RefreshDataSource()
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
End Class
