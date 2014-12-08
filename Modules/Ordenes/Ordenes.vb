Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.OleDb

Public Class Ordenes



    Public BotonLinea As DevExpress.XtraBars.Navigation.NavButton
    Public BtBuscaOrdenes As DevExpress.XtraBars.Navigation.TileBarItem
    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
    Public btbtRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        loaddata()
    End Sub
    Public Sub loaddata()
        Me.CABECERAFABRICACIONTableAdapter.Fill(Me.ProduccionSql.CABECERAFABRICACION, gCodEmpresa, gEjercicio)
        Me.PL_PARTESPRODUCCIONTableAdapter.Fill(Me.ProduccionSql.PL_PARTESPRODUCCION, gCodEmpresa, gEjercicio, configuracion.Linea, 2, 3)

    End Sub
    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        Dim cmd As New OleDbCommand
        NroOrden = GridView1.GetFocusedDataRow()("NroOrden").ToString()
        BotonLinea.Caption = "Cargada Orden Nro...:   " & NroOrden.ToString
        BtBuscaOrdenes.Enabled = False
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        miPrincipal.LoadData()

        miPrincipal.LabelControl1.Text = "Orden Nº: " & NroOrden.ToString
        LocalizaLineaenProduccion(miPrincipal.GridView2)
        If miLinea <> 0 And idCabecera <> 0 Then
            'Dim misOperarios() As String = FormMain.cmbOperarios.EditValue.ToString.Split(",")
            'miTrans = dbProd.BeginTransaction
            'If InsertarLinea(configuracion.AccionCambioTurno, 0, Date.Now, Date.Now, FormMain.cmbTurno.EditValue, misOperarios) Then
            '    miTrans.Commit()
            'Else
            '    miTrans.Rollback()
            '    Exit Sub
            'End If
            ' buscamos la fecha de inicio de la orden
            cmd = New OleDbCommand("SELECT     MIN(PL_CABECERAPRODUCIDA.INICIO) AS Expr1 FROM PL_CABECERAPRODUCIDA INNER JOIN PL_PARTESPRODUCCION ON PL_CABECERAPRODUCIDA.IDORDEN = PL_PARTESPRODUCCION.id WHERE (PL_PARTESPRODUCCION.NroOrden =" & NroOrden & ")" & miLinea, dbProd)
            miPrincipal.lblInicioOrden.Text = cmd.ExecuteScalar

            FormMain.Timer1.Enabled = True
            cmd = New OleDbCommand("Select ARTICULO FROM PL_PARTESPRODUCCION WHERE CodEmpresa= '" & gCodEmpresa & "' and Ejercicio='" & gEjercicio & "' and ID=" & miLinea, dbProd)

            idArticulo = cmd.ExecuteScalar
            miPrincipal.cbAcciones.Properties.ReadOnly = False
            miPrincipal.cbOperaciones.Properties.ReadOnly = False
            miPrincipal.AceptaAccion.Enabled = True
            CambioTurno()
            CambioOperario()
        Else
            miPrincipal.lblInicioOrden.Text = Date.Now
        End If
        miPrincipal.loadDataOperaciones()
        ExpandAllRows(miPrincipal.GridView1)
        lciBackPicture_Click(sender, e)
    End Sub

    Private Sub lciBackPicture_Click(sender As Object, e As EventArgs) Handles lciBackPicture.Click
        ' If controencurso.Name <> "Principal" Then
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
        End Using

        ' End If
    End Sub

End Class
