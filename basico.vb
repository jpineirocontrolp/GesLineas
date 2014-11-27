Imports System.IO
Imports System.Data.OleDb
Imports DevExpress.Utils.Animation
Imports DevExpress.XtraGrid.Views.Grid

Module basico
    Public xPath As String
    Public AppPath As String
    Public gCodEmpresa As String
    Public gEjercicio As String
    Public xNombreBase As String
    Public xConnectionProd As String
    Public xConnectionString As String
    Public xConnectionGrupos As String
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
    Public misOrdenes As Ordenes
    Public misSettings As SettingsUC
    Public miPrincipal As Principal
    Public NroOrden As Integer = 0
    Public miManejador As Integer = 0
    Public miTrans As OleDbTransaction
    Public idCabecera As Integer

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
            Dim trtype As DevExpress.Utils.Animation.Transitions = DevExpress.Utils.Animation.Transitions.Push
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

                miPrincipal.Observaciones.Text = row.Row("OBSERVACIONES")
                cmd = New OleDbCommand("Select desencadena from pl_acciones where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and nuevareferencia<>0", dbProd)
                miPrincipal.cbAcciones.EditValue = cmd.ExecuteScalar
                Exit Sub

            End If
        Next
        miLinea = 0

    End Sub
    Public Function InsertarLinea(Accion As Integer, operacion As Integer, Inicio As DateTime, final As DateTime) As Boolean
        Dim cmd As New OleDbCommand
        miTrans = dbProd.BeginTransaction
        cmd = New OleDbCommand("INSERT iNTO PL_LINEASPRODUCIDAS( IDCABECERA, IDACCION, IDOPERACION, INICIO, FIN, CODEMPRESA, EJERCICIO) VALUES (" & idCabecera & "," & Accion & "," & operacion & ",'" & Inicio & "','" & final & "','" & gCodEmpresa & "', '" & gEjercicio & "')", dbProd, miTrans)
        Try
            cmd.ExecuteNonQuery()
            miTrans.Commit()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            miTrans.Rollback()
            Return False
        End Try
    End Function
End Module
