Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class Loteado
    Public miLote As String
    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        grabar()
    End Sub

    Private Sub grabar()
        Try
            If idCabecera <> 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE PL_CABECERAPRODUCIDA SET PALESPRODUCIDODS=" & clsNegocioNet.qc(txtPales.EditValue) & ",CAJASPRODUCIDAS=" & clsNegocioNet.qc(txtCajas.EditValue) & ",LOTEPRODUCIDO='" & TextEdit1.Text & "' WHERE ID=" & idCabecera, dbProd)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As OleDbException
            If ex.ErrorCode = -2146232060 Then
                MsgBox("La accion que intenta añadir ya existe")
            Else
                MsgBox(ex.Message)
            End If


        End Try
        miLote = TextEdit1.Text
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
