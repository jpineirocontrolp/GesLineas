Public Class Roturas

    
    Private Sub lciBackPicture_Click(sender As Object, e As EventArgs) Handles lciBackPicture.Click
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
        End Using
    End Sub
End Class
