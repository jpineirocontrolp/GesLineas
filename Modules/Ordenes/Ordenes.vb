Public Class Ordenes

    

    Public BotonLinea As DevExpress.XtraBars.Navigation.NavButton
    Public BtBuscaOrdenes As DevExpress.XtraBars.Navigation.TileBarItem
    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
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
        NroOrden = GridView1.GetFocusedDataRow()("NroOrden").ToString()
        BotonLinea.Caption = "Cargada Orden Nro...:   " & NroOrden.ToString
        BtBuscaOrdenes.Enabled = False
        btEnvasar.Enabled = True
        miPrincipal.LoadData()
        miPrincipal.LabelControl1.Text = "Orden Nº: " & NroOrden.ToString
        LocalizaLineaenProduccion(miPrincipal.GridView2)
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
