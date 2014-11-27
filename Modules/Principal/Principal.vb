Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

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
    End Sub

    Private Sub cbAcciones_EditValueChanged(sender As Object, e As EventArgs) Handles cbAcciones.EditValueChanged
        Me.PL_OPERACIONESTableAdapter.Fill(Me.ProduccionSql.PL_OPERACIONES, gCodEmpresa, gEjercicio, configuracion.Linea, cbAcciones.EditValue)
        cbOperaciones.Refresh()
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
End Class
