Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors

Public Class SettingsUC
    Dim WithEvents cmblinea As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit
    Dim WithEvents cmbAcciones As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit
    Dim cmbOperaciones As RepositoryItemSearchLookUpEdit = New RepositoryItemSearchLookUpEdit

    Dim miLinea As Integer
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        PropertyGridControl1.SelectedObject = configuracion
        Me.CABECERAFABRICACIONTableAdapter.Fill(ProduccionSql.CABECERAFABRICACION, gCodEmpresa, gEjercicio)
        Me.PL_ACCIONESTableAdapter.Fill(ProduccionSql.PL_ACCIONES, gCodEmpresa, gEjercicio)
        ' Me.PL_OPERACIONESTableAdapter.Fill(ProduccionSql.PL_OPERACIONES, gCodEmpresa, gEjercicio, configuracion.Linea, configuracion.AccionCambioTurno)

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ' cmbLineas.Properties.DataSource = Me.ProduccionSql.CABECERAFABRICACION
        'comboLineas.Properties.DataSource = Me.ProduccionSql.CABECERAFABRICACION

    End Sub


    Private Sub SettingsUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        configuracion.LoadSettings()
        miLinea = configuracion.Linea
        cmbLinea.DataSource = Me.ProduccionSql.CABECERAFABRICACION
        cmbLinea.ValueMember = "ID"
        cmbLinea.DisplayMember = "Descripcion"
        cmbLinea.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        cmblinea.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        Dim col1 As GridColumn = cmblinea.View.Columns.AddField("ID")
        col1.VisibleIndex = 0
        col1.Visible = False
        col1.Caption = "Id"
        ' A column to display the values of the ProductName field.
        Dim col2 As GridColumn = cmblinea.View.Columns.AddField("Descripcion")
        col2.VisibleIndex = 2
        col2.Caption = "Linea"

        cmbAcciones.DataSource = Me.ProduccionSql.PL_ACCIONES
        cmbAcciones.ValueMember = "ID"
        cmbAcciones.DisplayMember = "NOMBRE"
        cmbAcciones.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        Dim col3 As GridColumn = cmbAcciones.View.Columns.AddField("ID")
        col3.VisibleIndex = 0
        col3.Visible = False
        col3.Caption = "Id"
        ' A column to display the values of the ProductName field.
        Dim col4 As GridColumn = cmbAcciones.View.Columns.AddField("NOMBRE")
        col4.VisibleIndex = 2
        col4.Caption = "Descripcion"

        cmbOperaciones.DataSource = Me.ProduccionSql.PL_ACCIONES
        cmbOperaciones.ValueMember = "ID"
        cmbOperaciones.DisplayMember = "NOMBRE"
        cmbOperaciones.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        Dim col5 As GridColumn = cmbOperaciones.View.Columns.AddField("ID")
        col5.VisibleIndex = 0
        col5.Visible = False
        col5.Caption = "Id"
        ' A column to display the values of the ProductName field.
        Dim col6 As GridColumn = cmbOperaciones.View.Columns.AddField("NOMBRE")
        col6.VisibleIndex = 2
        col6.Caption = "Descripcion"

        PropertyGridControl1.RepositoryItems.Add(cmblinea)
        PropertyGridControl1.RepositoryItems.Add(cmbAcciones)
        PropertyGridControl1.RepositoryItems.Add(cmbOperaciones)
        PropertyGridControl1.GetRowByFieldName("Linea").Properties.RowEdit = cmblinea
        PropertyGridControl1.GetRowByFieldName("AccionCambioTurno").Properties.RowEdit = cmbAcciones
        PropertyGridControl1.GetRowByFieldName("AccionCambioOperario").Properties.RowEdit = cmbOperaciones
        PropertyGridControl1.GetRowByFieldName("AccionAveria").Properties.RowEdit = cmbAcciones
        PropertyGridControl1.GetRowByFieldName("AccionParada").Properties.RowEdit = cmbAcciones
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        configuracion.SaveSettings()
    End Sub
End Class
