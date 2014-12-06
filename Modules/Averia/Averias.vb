

Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Controls
Imports System.Data.OleDb

Public Class Averias
    Dim dbMant As New SqlConnection
    Dim dt As New DataTable
    Public accion As Integer
    Private Sub Averias_Load(sender As Object, e As EventArgs) Handles Me.Load
        
    End Sub
    Public Sub loaddata()
        Try
            cmbMaquina.Properties.DataSource = ""
            cmbMaquina.Refresh()
            Dim da As SqlDataAdapter
            dt = New DataTable
            Select Case accion
                Case configuracion.AccionParada
                    Avisar.CheckState = CheckState.Unchecked
                Case configuracion.AccionAveria
                    Avisar.CheckState = CheckState.Checked
                Case configuracion.AccionAjuste
                    Avisar.CheckState = CheckState.Unchecked
            End Select
            Dim sql As String = "SELECT Maquinas.ID, Maquinas.IDLINEA, Maquinas.IDCLASEMAQUINA, Maquinas.CODEMPRESA, Maquinas.EJERCICIO, Maquinas.CODIGO,MAQUINAS.DESCRIPCION,Lineas.CODIGO AS CodigoLinea FROM  Maquinas FULL OUTER JOIN Lineas ON Maquinas.IDLINEA = Lineas.ID WHERE  (Maquinas.CODEMPRESA ='" & gCodEmpresa & "') AND (Maquinas.EJERCICIO ='" & gEjercicio & "') AND (Lineas.CODIGO IN (" & configuracion.CodigoLinea & "))"
            dbMant.ConnectionString = xConnectionMantenimiento
            dbMant.Open()
            da = New SqlDataAdapter(sql, dbMant)
            da.Fill(dt)
            cmbMaquina.Properties.DisplayMember = "DESCRIPCION"
            cmbMaquina.Properties.ValueMember = "ID"
            cmbMaquina.Properties.DataSource = dt
            'Dim coll As LookUpColumnInfoCollection
            'coll = cmbMaquina.Properties.Columns
            'coll.Add(New LookUpColumnInfo("CODIGO", "Codigo"))
            'coll.Add(New LookUpColumnInfo("DESCRIPCION", "Descripcion"))
            'cmbMaquina.Properties.Columns = coll
            'Me.MaquinasTableAdapter.Adapter.SelectCommand.CommandText = sql

            'Me.MaquinasTableAdapter.Fill(Me.Mantenimiento.Maquinas)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim cmd As New SqlCommand
        Dim Row As DataRowView = cmbMaquina.Properties.GetDataSourceRowByKeyValue(cmbMaquina.EditValue)

        cmd = New SqlCommand("INSERT INTO NOTIFICACIONES (IdLinea, IdMaquina, Observaciones, Leida) VALUES (" & Row.Row("IDLINEA") & "," & Row.Row("ID") & ",'" & Observaciones.Text & "'," & IIf(Avisar.CheckState = CheckState.Checked, 0, 1) & ")", dbMant)
        cmd.ExecuteNonQuery()
        cmd = New SqlCommand("Select @@identity", dbMant)
        Dim idNotificacion As Integer = cmd.ExecuteScalar
        Dim cmdOledb As OleDb.OleDbCommand
        cmdOledb = New OleDbCommand("UPDATE PL_LINEASPRODUCIDAS SET ID_NOTIFICACION=" & idNotificacion & " where id=" & idLinea, dbProd)
        cmdOledb.ExecuteNonQuery()
        dbMant.Close()
        dbMant.Dispose()

        cmbMaquina.EditValue = -1
        Observaciones.Text = ""
        controencurso = miPrincipal
        miPrincipal.Visible = True
        misAverias.Visible = False
        miPrincipal.loadDataOperaciones()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cmbMaquina.EditValue = -1
        Observaciones.Text = ""

        dbMant.Close()
        dbMant.Dispose()
        controencurso = miPrincipal
        miPrincipal.Visible = True

        misAverias.Visible = False
        miPrincipal.loadDataOperaciones()
    End Sub
End Class
