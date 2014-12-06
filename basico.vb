Imports System.IO
Imports System.Data.OleDb
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Module basico
    Public xPath As String
    Public AppPath As String
    Public gCodEmpresa As String
    Public gEjercicio As String
    Public xNombreBase As String
    Public xConnectionProd As String
    Public xConnectionString As String
    Public xConnectionGrupos As String
    Public xConnectionMantenimiento As String
    Public strDATABASEPROD As String
    Public strSERVERPROD As String
    Public strUIDPROD As String
    Public strPWDPROD As String
    Public dbAdo As New OleDbConnection
    Public dbProd As New OleDbConnection
    Dim blnProdSqlServer As Boolean = False
    Public configuracion As New miConfiguracion
    Public clsNegocioProd As cpNegocioProdNet.clsNegocioProdNet
    Public clsNegocioNet As cpNegocioNet.clsNegocioNet
    Public controencurso As New Control
    Public WithEvents TransitionManager1 As New DevExpress.Utils.Animation.TransitionManager
    Public miLinea As Integer = 0
    Public idLinea As Integer = 0
    Public misOrdenes As Ordenes
    Public misSettings As SettingsUC
    Public miPrincipal As Principal
    Public misRoturas As Roturas
    Public misEtiquetas As Etiquetas
    Public misAverias As Averias
    Public NroOrden As Integer = 0
    Public miManejador As Integer = 0
    Public miTrans As OleDbTransaction
    Public idCabecera As Integer
    Public idArticulo As Integer
    Public miLoteGlobal As String = ""

    Public Function LeerConfiguracion(File As String) As String
        ' We need to read into this List.
        Dim list As New List(Of String)

        ' Open file.txt with the Using statement.
        Using r As StreamReader = New StreamReader(File & "\produccion.cfg")
            ' Store contents in this String.
            Dim line As String

            ' Read first line.
            line = r.ReadLine

            ' Loop over each line in file, While list is Not Nothing.
            Do While (Not line Is Nothing)
                ' Add this line to list.
                list.Add(line)
                ' Display to console.
                Console.WriteLine(line)
                ' Read in the next line.
                line = r.ReadLine
            Loop
        End Using
        If Right(list(0), 1) = "1" Then ' sqlserver
            blnProdSqlServer = True
            LeerConfiguracion = Trim(Mid(list(1), 16)) '"CadenaConexion=" mide 15 caracteres, le sumamos 1 para comenzar a leer la cadena en la posición siguiente. 
            strSERVERPROD = list(2).Split("=")(1)
            strUIDPROD = list(3).Split("=")(1)
            strPWDPROD = list(4).Split("=")(1)
            strDATABASEPROD = list(5).Split("=")(1)
        Else
            LeerConfiguracion = Trim(Mid(list(1), 16)) '"CadenaConexion=" mide 15 caracteres, le sumamos 1 para comenzar a leer la cadena en la posición siguiente.
        End If


        ' LeerConfiguracion = ""
    End Function
    Public Sub EjecutacpNegocioNet(ByRef OBJ As Object)
        OBJ = New cpNegocioNet.clsNegocioNet

        'OBJ = CreateObject("cpnegocionet.clsnegocionet")

        OBJ.ConnectionString = xConnectionString
        'OBJ.ConnectionGrupos = xConnectionGrupos
        'OBJ.ConnectionMail = xConnectionMail
        OBJ.CODEMPRESA = gCodEmpresa
        OBJ.EJERCICIO = gEjercicio
        'OBJ.Producto = mProducto
        OBJ.path = xPath
        OBJ.nombrebase = xNombreBase
        OBJ.compruebaexistetablaiva()
        OBJ.MIDBADO = dbAdo
    End Sub
    Public Sub EjecutacpNegocioProdNet(ByRef obj As cpNegocioProdNet.clsNegocioProdNet)
        obj = New cpNegocioProdNet.clsNegocioProdNet
        obj.CodEmpresa = gCodEmpresa
        obj.Ejercicio = gEjercicio
        obj.Temporada = ""
        obj.ConnectionString = xConnectionString
        If blnProdSqlServer Then
            obj.ConnectionProd = Mid(xConnectionProd, InStr(xConnectionProd, ";") + 1, Len(xConnectionProd) - InStr(xConnectionProd, ";")) + "MultipleActiveResultSets=true;"
        Else
            obj.ConnectionProd = xConnectionProd
        End If
        obj.SQLServer = blnProdSqlServer
        obj.NombreServidorSql = strSERVERPROD
        obj.NombreBaseProduccionSql = strDATABASEPROD
        obj.Uid = strUIDPROD
        obj.Pwd = strPWDPROD
        obj.CreaConexiones()
    End Sub

    Public Class BatchTransition
        Implements IDisposable
        Private manager As DevExpress.Utils.Animation.TransitionManager
        Public Sub New(ByVal manager As DevExpress.Utils.Animation.TransitionManager, ByVal control As Control)
            Me.manager = manager

            If control Is Nothing Then
                Return
            End If

            If manager.Transitions(control) Is Nothing Then
                ' Add a transition, associated with the xtraTabControl1, to the TransitionManager.
                Dim transition1 As New Transition()
                transition1.Control = control
                manager.Transitions.Add(transition1)
            End If
            Dim trtype As DevExpress.Utils.Animation.Transitions = DevExpress.Utils.Animation.Transitions.Shape

            manager.Transitions(control).TransitionType = CreateTransitionInstance(trtype)
            manager.StartTransition(control)
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            manager.EndTransition()
            manager = Nothing
        End Sub
    End Class
    Private Function CreateTransitionInstance(transitionType As Transitions) As BaseTransition
        Select Case transitionType
            Case Transitions.Dissolve
                Return New DissolveTransition()
            Case Transitions.Fade
                Return New FadeTransition()
            Case Transitions.Shape
                Return New ShapeTransition()
            Case Transitions.Clock
                Return New ClockTransition()
            Case Transitions.SlideFade
                Return New SlideFadeTransition()
            Case Transitions.Cover
                Return New CoverTransition()
            Case Transitions.Comb
                Return New CombTransition()
            Case Else
                Return New PushTransition()
        End Select
    End Function
    Public Sub LocalizaLineaenProduccion(ByVal view As GridView)
        Dim cmd As New OleDbCommand
        Dim dbProd As New OleDbConnection
        dbProd.ConnectionString = xConnectionProd
        dbProd.Open()
        Dim I As Integer
        For I = 0 To view.DataRowCount - 1
            If view.GetDataRow(I)("ESTADO") = 3 Then
                Dim row As DataRowView = view.GetRow(I)
                'Change the Phone field via the bound data source 
                miLinea = row.Row("ID")
                idCabecera = clsNegocioProd.GetDatoTabla(miLinea, "PL_CABECERAPRODUCIDA", gCodEmpresa, gEjercicio, "MAX(ID)", "IDORDEN")
                miLoteGlobal = clsNegocioProd.GetDatoTabla(idCabecera, "PL_CABECERAPRODUCIDA", gCodEmpresa, gEjercicio, "LOTEPRODUCIDO", "ID", True)
                miPrincipal.Observaciones.Text = row.Row("OBSERVACIONES")
                cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd)
                miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar
                Exit Sub

            End If
        Next
        miLinea = 0

    End Sub

    Public Function InsertaCabecera(idArticulo As Integer, miTrans As OleDbTransaction, Optional miLote As String = "") As Boolean
        Dim cmd As New OleDbCommand

        Dim misOperarios() As String = Split(FormMain.cmbOperarios.EditValue, ",")
        ' buscamos la cabecera por si hubo un cambio de turno
        If miLote = "" Then
            cmd = New OleDbCommand("Select lote from PL_PARTESPRODUCCION WHERE ID=" & miLinea, dbProd, miTrans)
            miLote = cmd.ExecuteScalar
        End If
        cmd = New OleDbCommand("INSERT INTO PL_CABECERAPRODUCIDA (  IDTURNO, IDORDEN, IDARTICULO, PALESPRODUCIDODS, CAJASPRODUCIDAS, CODEMPRESA, EJERCICIO,INICIO,LOTEPRODUCIDO) VALUES     (" & FormMain.cmbTurno.EditValue & "," & miLinea & "," & idArticulo & ", 0, 0,'" & gCodEmpresa & "', '" & gEjercicio & "','" & Date.Now & "','" & miLote & "')", dbProd, miTrans)

        Try
            cmd.ExecuteNonQuery()
            miLoteGlobal = miLote
            cmd = New OleDbCommand("Select @@identity", dbProd, miTrans)
            idCabecera = cmd.ExecuteScalar
            ' inserto los operarios
            For Each elemento In misOperarios
                cmd = New OleDbCommand("INSERT INTO PL_CABECERAS_OPERARIOS( idCabecera, idOperario, idturno, CODEMPRESA, EJERCICIO) VALUES(" & idCabecera & "," & CInt(elemento) & "," & FormMain.cmbTurno.EditValue & ",'" & gCodEmpresa & "', '" & gEjercicio & "')", dbProd, miTrans)
                cmd.ExecuteNonQuery()
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Public Function InsertarLinea(Accion As Integer, operacion As Integer, Inicio As DateTime, final As DateTime, miturno As Integer, misOperarios() As String) As Boolean
        Dim cmd As New OleDbCommand
        Dim Horas As String
        If operacion <> 0 Then
            cmd = New OleDbCommand("Select estimado from pl_operaciones where id=" & operacion, dbProd, miTrans)
            If IsDBNull(cmd.ExecuteScalar) Then Horas = "00:00:00" Else Horas = cmd.ExecuteScalar.ToString
        Else
            cmd = New OleDbCommand("Select estimado from pl_acciones where id=" & Accion, dbProd, miTrans)
            If IsDBNull(cmd.ExecuteScalar) Then Horas = "00:00:00" Else Horas = cmd.ExecuteScalar.ToString

        End If


        cmd = New OleDbCommand("INSERT iNTO PL_LINEASPRODUCIDAS( IDCABECERA, IDACCION, IDOPERACION, INICIO, FIN, CODEMPRESA, EJERCICIO,ESTIMADO) VALUES (" & idCabecera & "," & Accion & "," & operacion & ",'" & Inicio & "','" & final & "','" & gCodEmpresa & "', '" & gEjercicio & "','" & Horas.ToString & "')", dbProd, miTrans)
        Try
            cmd.ExecuteNonQuery()
            cmd = New OleDbCommand("Select @@identity", dbProd, miTrans)
            idLinea = cmd.ExecuteScalar
            If miturno <> 0 Or Not misOperarios Is Nothing Then ' es cambio de turno, meto datos de turnos


                For Each elemento In misOperarios
                    cmd = New OleDbCommand("INSERT INTO PL_CABECERAS_OPERARIOS( idLinea, idOperario, idturno, CODEMPRESA, EJERCICIO) VALUES(" & idLinea & "," & CInt(elemento) & "," & miturno & ",'" & gCodEmpresa & "', '" & gEjercicio & "')", dbProd, miTrans)
                    cmd.ExecuteNonQuery()
                Next
            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

            Return False
        End Try
    End Function
    Public Function FinDeLinea() As Boolean
        Dim cmd As New OleDbCommand
        If idLinea = 0 Then Return True
        cmd = New OleDbCommand("UPDATE PL_LINEASPRODUCIDAS SET FIN='" & Date.Now & "' WHERE ID=" & idLinea, dbProd, miTrans)
        Try
            cmd.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

            Return False
        End Try
    End Function

    Public Function GetRowHandleByColumnValue(ByVal view As GridView, ByVal ColumnFieldName As String, ByVal value As Object, gridcontrol As GridControl) As Integer
        Dim result As Integer = gridcontrol.InvalidRowHandle
        Dim i As Integer
        For i = 0 To view.RowCount - 1
            If view.GetDataRow(i)(ColumnFieldName).Equals(value) Then
                Return i
            End If
        Next
        Return result
    End Function
    Public Sub ExpandAllRows(view__1 As GridView)
        view__1.BeginUpdate()
        Try
            Dim dataRowCount As Integer = view__1.DataRowCount
            For rHandle As Integer = 0 To dataRowCount - 1
                view__1.SetMasterRowExpanded(rHandle, True)
            Next
        Finally
            view__1.EndUpdate()

        End Try
    End Sub
    Public Sub CambioOperario()
        Try
            If miLinea <> 0 Then
                Dim misOperarios() As String = FormMain.cmbOperarios.EditValue.ToString.Split(",")
                Dim cmd As New OleDbCommand
                miTrans = dbProd.BeginTransaction
                If FinDeLinea() Then
                    If InsertarLinea(configuracion.AccionCambioOperario, 0, Date.Now, Nothing, FormMain.cmbTurno.EditValue, misOperarios) Then
                        miTrans.Commit()
                        cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and id=" & configuracion.AccionCambioOperario, dbProd)
                        If Not IsDBNull(cmd.ExecuteScalar) Then miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar Else miPrincipal.cbAcciones.EditValue = -1
                    Else
                        miTrans.Rollback()
                    End If
                    miPrincipal.loadDataOperaciones()
                Else
                    miTrans.Rollback()
                    miPrincipal.loadDataOperaciones()
                End If
            End If
        Catch ex As Exception
            miTrans.Rollback()
            MsgBox(ex.Message)
            miPrincipal.loadDataOperaciones()


        End Try
    End Sub
    Public Sub CambioTurno()
        Try
            If miLinea <> 0 Then
                Dim misOperarios() As String = FormMain.cmbOperarios.EditValue.ToString.Split(",")
                Dim cmd As New OleDbCommand
                miTrans = dbProd.BeginTransaction
                If FinDeLinea() Then
                    If InsertarLinea(configuracion.AccionCambioTurno, 0, Date.Now, Nothing, FormMain.cmbTurno.EditValue, misOperarios) Then
                        miTrans.Commit()
                        cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and id=" & configuracion.AccionCambioTurno, dbProd)
                        If Not IsDBNull(cmd.ExecuteScalar) Then miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar Else miPrincipal.cbAcciones.EditValue = -1
                    Else
                        miTrans.Rollback()
                    End If
                    miPrincipal.loadDataOperaciones()
                Else
                    miTrans.Rollback()
                    miPrincipal.loadDataOperaciones()
                End If
            End If
        Catch ex As Exception
            miTrans.Rollback()
            miPrincipal.loadDataOperaciones()
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
