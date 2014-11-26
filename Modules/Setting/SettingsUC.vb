Public Class SettingsUC

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.CABECERAFABRICACIONTableAdapter.Fill(ProduccionSql.CABECERAFABRICACION, gCodEmpresa, gEjercicio)


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ' cmbLineas.Properties.DataSource = Me.ProduccionSql.CABECERAFABRICACION
        'comboLineas.Properties.DataSource = Me.ProduccionSql.CABECERAFABRICACION

    End Sub

 
End Class
