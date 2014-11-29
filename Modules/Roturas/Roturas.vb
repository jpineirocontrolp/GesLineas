Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Roturas

    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
    Public btbtRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Public fin As Boolean = False

   

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'btAceptar.Visible = fin
        'btCancelar.Visible = fin
        'If fin Then
        '    grabar()
        'End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub loadData()
        Me.PL_ROTURASTableAdapter.Fill(ProduccionSql.PL_ROTURAS, idCabecera, gCodEmpresa, gEjercicio)
        Me.MateriasPrimasTableAdapter.Fill(ProduccionSql.MateriasPrimas, gCodEmpresa, gEjercicio, idArticulo)
        Me.PL_LOTESAUXILIARESTableAdapter.Fill(ProduccionSql.PL_LOTESAUXILIARES, gCodEmpresa, gEjercicio, idCabecera)
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        If idCabecera <> 0 Then
            txtCajas.Enabled = True
            txtPales.Enabled = True
            cmd = New OleDbCommand("Select palesproducidoDs,cajasproducidas from pl_cabeceraproducida where id=" & idCabecera, dbProd)
            dr = cmd.ExecuteReader
            dr.Read()
            txtCajas.EditValue = dr(1)
            txtPales.EditValue = dr(0)
        Else
            txtCajas.Enabled = False
            txtPales.Enabled = False
        End If
    End Sub


    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, Grid.GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("IDCABECERA"), idCabecera)
        view.SetRowCellValue(e.RowHandle, view.Columns("CODEMPRESA"), gCodEmpresa)
        view.SetRowCellValue(e.RowHandle, view.Columns("EJERCICIO"), gEjercicio)
    End Sub
    Private Sub grabar()
        Try
            Me.PL_ROTURASTableAdapter.Update(Me.ProduccionSql.PL_ROTURAS)
            Me.PL_LOTESAUXILIARESTableAdapter.Update(Me.ProduccionSql.PL_LOTESAUXILIARES)
            If idCabecera <> 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE PL_CABECERAPRODUCIDA SET PALESPRODUCIDODS=" & clsNegocioNet.qc(txtPales.EditValue) & ",CAJASPRODUCIDAS=" & clsNegocioNet.qc(txtCajas.EditValue) & " WHERE ID=" & idCabecera, dbProd)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As SqlException
            If ex.ErrorCode = -2146232060 Then
                MsgBox("La accion que intenta añadir ya existe")
            Else
                MsgBox(ex.Message)
            End If


        End Try
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        grabar()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, Grid.GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("idcabecera"), idCabecera)
        view.SetRowCellValue(e.RowHandle, view.Columns("CODEMPRESA"), gCodEmpresa)
        view.SetRowCellValue(e.RowHandle, view.Columns("EJERCICIO"), gEjercicio)
    End Sub
End Class
