Public Class Principal

    Public Sub New()
        Try
            ' Llamada necesaria para el diseñador.
            InitializeComponent()


            ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub LoadData()
        Me.Partes_de_produccionTableAdapter.Fill(Me.ProduccionSql.Partes_de_produccion, configuracion.Linea, NroOrden, gCodEmpresa, gEjercicio)
        Me.ARTICULOSTableAdapter.Fill(Me.DatosDataset.ARTICULOS, gCodEmpresa, gEjercicio)
    End Sub
End Class
