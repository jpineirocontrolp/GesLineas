Public Class Ordenes

    

    Public BotonLinea As DevExpress.XtraBars.Navigation.NavButton

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.CABECERAFABRICACIONTableAdapter.Fill(Me.ProduccionSql.CABECERAFABRICACION, gCodEmpresa, gEjercicio)
        Me.PL_PARTESPRODUCCIONTableAdapter.Fill(Me.ProduccionSql.PL_PARTESPRODUCCION, gCodEmpresa, gEjercicio, 2, configuracion.Linea)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub GridView1_Click(sender As Object, e As EventArgs) Handles GridView1.Click
        NroOrden = GridView1.GetFocusedDataRow()("NroOrden").ToString()
        BotonLinea.Caption = "Cargada Orden Nro...:   " & NroOrden.ToString

        miPrincipal.LoadData()
        miPrincipal.LabelControl1.Text = "Orden Nº: " & NroOrden.ToString
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
