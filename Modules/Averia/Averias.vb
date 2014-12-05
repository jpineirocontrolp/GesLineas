Public Class Averias

    Private Sub Averias_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub loaddata()
        Me.MaquinasTableAdapter.Fill(Me.Mantenimiento.Maquinas, gCodEmpresa, gEjercicio, configuracion.CodigoLinea)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        controencurso = miPrincipal
        miPrincipal.Visible = True
        misAverias.Visible = False
        miPrincipal.loadDataOperaciones()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        controencurso = miPrincipal
        miPrincipal.Visible = True

        misAverias.Visible = False
        miPrincipal.loadDataOperaciones()
    End Sub
End Class
