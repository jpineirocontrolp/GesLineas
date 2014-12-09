Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient

Public Class Grifos

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, Grid.GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("IDCABECERAPL"), idCabecera)
        view.SetRowCellValue(e.RowHandle, view.Columns("CODEMPRESA"), gCodEmpresa)
        view.SetRowCellValue(e.RowHandle, view.Columns("EJERCICIO"), gEjercicio)
    End Sub

    Private Sub Grifos_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub loadData()
        Me.PL_GRIFOSTableAdapter.Fill(ProduccionSql.PL_GRIFOS, gCodEmpresa, gEjercicio)
        Me.PL_GRIFOSLINEASTableAdapter.Fill(ProduccionSql.PL_GRIFOSLINEAS, idCabecera, gCodEmpresa, gEjercicio)
    End Sub

    Private Sub grabar()
        Try

            Me.PL_GRIFOSLINEASTableAdapter.Update(Me.ProduccionSql.PL_GRIFOSLINEAS)

        Catch ex As SqlException
            If ex.ErrorCode = -2146232060 Then
                MsgBox("La accion que intenta añadir ya existe")
            Else
                MsgBox(ex.Message)
            End If


        End Try
        'btEnvasar.Enabled = True
        'btbtRoturas.Enabled = True
        'btEtiquetas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub
End Class
