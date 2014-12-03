Imports DevExpress.XtraGrid.Views.Grid

Public Class FormBuscarLote
    Public codigoMateria As String
    Public lote As String
    Private Sub FormBuscarLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionSql.LotesMPADisponibles' Puede moverla o quitarla según sea necesario.
        Me.LotesMPADisponiblesTableAdapter.Fill(Me.ProduccionSql.LotesMPADisponibles, codigoMateria)

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click
     
    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Dim view As GridView = TryCast(sender, GridView)

        lote = view.GetRowCellValue(view.FocusedRowHandle, "ReferenciaLinea")
        Me.Close()
    End Sub
End Class