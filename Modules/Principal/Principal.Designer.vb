<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PartesDeProduccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemGridLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataset = New GesLineas.DatosDataset()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPalesFabricar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajasFabricar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaProduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTANQUE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLOTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colIdEnvase = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaConsumoPreferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGTINCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCADUCIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMENSAJEBOTELLA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMENSAJECAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPOETIQUETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMARCA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGTINCAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGTINPALET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdiomaMes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMARCARCAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFORMATOMESALFA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colETIQUETARCAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPOETIQUETACAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMENSAJELASER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Partes_de_produccionTableAdapter = New GesLineas.ProduccionSqlTableAdapters.Partes_de_produccionTableAdapter()
        Me.ARTICULOSTableAdapter = New GesLineas.DatosDatasetTableAdapters.ARTICULOSTableAdapter()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.CancelaAccion = New DevExpress.XtraEditors.SimpleButton()
        Me.AceptaAccion = New DevExpress.XtraEditors.SimpleButton()
        Me.cbOperaciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.PLOPERACIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbAcciones = New DevExpress.XtraEditors.LookUpEdit()
        Me.PLACCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PL_ACCIONESTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_ACCIONESTableAdapter()
        Me.PL_OPERACIONESTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_OPERACIONESTableAdapter()
        Me.Observaciones = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartesDeProduccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.cbOperaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLOPERACIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbAcciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLACCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Observaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.SplitContainerControl1.Panel2.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Observaciones)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1499, 335)
        Me.SplitContainerControl1.SplitterPosition = 252
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.PartesDeProduccionBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(3, 47)
        Me.GridControl2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemGridLookUpEdit1, Me.RepositoryItemComboBox1})
        Me.GridControl2.Size = New System.Drawing.Size(1496, 204)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PartesDeProduccionBindingSource
        '
        Me.PartesDeProduccionBindingSource.DataMember = "Partes de produccion"
        Me.PartesDeProduccionBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrden, Me.colCODIGO, Me.colArticulo, Me.colPalesFabricar, Me.colCajasFabricar, Me.colFechaProduccion, Me.colTANQUE, Me.colLOTE, Me.colESTADO, Me.colIdEnvase, Me.colObservaciones, Me.colFechaConsumoPreferente, Me.colDESCRIPCION, Me.colGTINCLIENTE, Me.colCANTIDAD, Me.colCADUCIDAD, Me.colMENSAJEBOTELLA, Me.colMENSAJECAJA, Me.colTIPOETIQUETA, Me.colMARCA, Me.colGTINCAJA, Me.colGTINPALET, Me.colIdiomaMes, Me.colMARCARCAJA, Me.colFORMATOMESALFA, Me.colETIQUETARCAJA, Me.colTIPOETIQUETACAJA, Me.colMENSAJELASER, Me.colIdLinea})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsBehavior.AllowPartialRedrawOnScrolling = False
        Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsBehavior.ReadOnly = True
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsMenu.EnableColumnMenu = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colESTADO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOrden
        '
        Me.colOrden.FieldName = "Orden"
        Me.colOrden.Name = "colOrden"
        Me.colOrden.Visible = True
        Me.colOrden.VisibleIndex = 0
        '
        'colCODIGO
        '
        Me.colCODIGO.Caption = "Tanque"
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        Me.colCODIGO.Visible = True
        Me.colCODIGO.VisibleIndex = 5
        '
        'colArticulo
        '
        Me.colArticulo.Caption = "Articulo"
        Me.colArticulo.ColumnEdit = Me.RepositoryItemGridLookUpEdit1
        Me.colArticulo.FieldName = "Articulo"
        Me.colArticulo.Name = "colArticulo"
        Me.colArticulo.Visible = True
        Me.colArticulo.VisibleIndex = 2
        Me.colArticulo.Width = 350
        '
        'RepositoryItemGridLookUpEdit1
        '
        Me.RepositoryItemGridLookUpEdit1.AutoHeight = False
        Me.RepositoryItemGridLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemGridLookUpEdit1.DataSource = Me.ARTICULOSBindingSource
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "Descripcion"
        Me.RepositoryItemGridLookUpEdit1.Name = "RepositoryItemGridLookUpEdit1"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "Id"
        Me.RepositoryItemGridLookUpEdit1.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.DatosDataset
        '
        'DatosDataset
        '
        Me.DatosDataset.DataSetName = "DatosDataset"
        Me.DatosDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colPalesFabricar
        '
        Me.colPalesFabricar.FieldName = "PalesFabricar"
        Me.colPalesFabricar.Name = "colPalesFabricar"
        Me.colPalesFabricar.Visible = True
        Me.colPalesFabricar.VisibleIndex = 3
        '
        'colCajasFabricar
        '
        Me.colCajasFabricar.FieldName = "CajasFabricar"
        Me.colCajasFabricar.Name = "colCajasFabricar"
        Me.colCajasFabricar.Visible = True
        Me.colCajasFabricar.VisibleIndex = 4
        '
        'colFechaProduccion
        '
        Me.colFechaProduccion.FieldName = "FechaProduccion"
        Me.colFechaProduccion.Name = "colFechaProduccion"
        '
        'colTANQUE
        '
        Me.colTANQUE.FieldName = "TANQUE"
        Me.colTANQUE.Name = "colTANQUE"
        '
        'colLOTE
        '
        Me.colLOTE.FieldName = "LOTE"
        Me.colLOTE.Name = "colLOTE"
        Me.colLOTE.Visible = True
        Me.colLOTE.VisibleIndex = 6
        '
        'colESTADO
        '
        Me.colESTADO.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 1
        Me.colESTADO.Width = 99
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Pendiente", "En Cola", "En Produccion", "Finalizado"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colIdEnvase
        '
        Me.colIdEnvase.FieldName = "IdEnvase"
        Me.colIdEnvase.Name = "colIdEnvase"
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        '
        'colFechaConsumoPreferente
        '
        Me.colFechaConsumoPreferente.FieldName = "FechaConsumoPreferente"
        Me.colFechaConsumoPreferente.Name = "colFechaConsumoPreferente"
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        '
        'colGTINCLIENTE
        '
        Me.colGTINCLIENTE.FieldName = "GTINCLIENTE"
        Me.colGTINCLIENTE.Name = "colGTINCLIENTE"
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        '
        'colCADUCIDAD
        '
        Me.colCADUCIDAD.FieldName = "CADUCIDAD"
        Me.colCADUCIDAD.Name = "colCADUCIDAD"
        '
        'colMENSAJEBOTELLA
        '
        Me.colMENSAJEBOTELLA.FieldName = "MENSAJEBOTELLA"
        Me.colMENSAJEBOTELLA.Name = "colMENSAJEBOTELLA"
        '
        'colMENSAJECAJA
        '
        Me.colMENSAJECAJA.FieldName = "MENSAJECAJA"
        Me.colMENSAJECAJA.Name = "colMENSAJECAJA"
        '
        'colTIPOETIQUETA
        '
        Me.colTIPOETIQUETA.FieldName = "TIPOETIQUETA"
        Me.colTIPOETIQUETA.Name = "colTIPOETIQUETA"
        '
        'colMARCA
        '
        Me.colMARCA.FieldName = "MARCA"
        Me.colMARCA.Name = "colMARCA"
        Me.colMARCA.Visible = True
        Me.colMARCA.VisibleIndex = 7
        '
        'colGTINCAJA
        '
        Me.colGTINCAJA.FieldName = "GTINCAJA"
        Me.colGTINCAJA.Name = "colGTINCAJA"
        '
        'colGTINPALET
        '
        Me.colGTINPALET.FieldName = "GTINPALET"
        Me.colGTINPALET.Name = "colGTINPALET"
        '
        'colIdiomaMes
        '
        Me.colIdiomaMes.FieldName = "IdiomaMes"
        Me.colIdiomaMes.Name = "colIdiomaMes"
        '
        'colMARCARCAJA
        '
        Me.colMARCARCAJA.FieldName = "MARCARCAJA"
        Me.colMARCARCAJA.Name = "colMARCARCAJA"
        '
        'colFORMATOMESALFA
        '
        Me.colFORMATOMESALFA.FieldName = "FORMATOMESALFA"
        Me.colFORMATOMESALFA.Name = "colFORMATOMESALFA"
        '
        'colETIQUETARCAJA
        '
        Me.colETIQUETARCAJA.FieldName = "ETIQUETARCAJA"
        Me.colETIQUETARCAJA.Name = "colETIQUETARCAJA"
        '
        'colTIPOETIQUETACAJA
        '
        Me.colTIPOETIQUETACAJA.FieldName = "TIPOETIQUETACAJA"
        Me.colTIPOETIQUETACAJA.Name = "colTIPOETIQUETACAJA"
        '
        'colMENSAJELASER
        '
        Me.colMENSAJELASER.FieldName = "MENSAJELASER"
        Me.colMENSAJELASER.Name = "colMENSAJELASER"
        '
        'colIdLinea
        '
        Me.colIdLinea.FieldName = "IdLinea"
        Me.colIdLinea.Name = "colIdLinea"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1499, 46)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 11)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 30)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Orden Nº"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1501, 45)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(129, 30)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Movimientos"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(3, 51)
        Me.GridControl1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(931, 397)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'Partes_de_produccionTableAdapter
        '
        Me.Partes_de_produccionTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 341)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Appearance.BackColor = System.Drawing.Color.White
        Me.SplitContainerControl2.Panel1.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.CancelaAccion)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.PanelControl2)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.AceptaAccion)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.GridControl1)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.cbOperaciones)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.cbAcciones)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Appearance.BackColor = System.Drawing.SystemColors.Menu
        Me.SplitContainerControl2.Panel2.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1501, 544)
        Me.SplitContainerControl2.SplitterPosition = 452
        Me.SplitContainerControl2.TabIndex = 1
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'CancelaAccion
        '
        Me.CancelaAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelaAccion.Enabled = False
        Me.CancelaAccion.Image = CType(resources.GetObject("CancelaAccion.Image"), System.Drawing.Image)
        Me.CancelaAccion.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.CancelaAccion.Location = New System.Drawing.Point(1315, 311)
        Me.CancelaAccion.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.CancelaAccion.Name = "CancelaAccion"
        Me.CancelaAccion.Size = New System.Drawing.Size(76, 68)
        Me.CancelaAccion.TabIndex = 5
        Me.CancelaAccion.ToolTip = "Cancelar"
        '
        'AceptaAccion
        '
        Me.AceptaAccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AceptaAccion.Enabled = False
        Me.AceptaAccion.Image = CType(resources.GetObject("AceptaAccion.Image"), System.Drawing.Image)
        Me.AceptaAccion.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.AceptaAccion.Location = New System.Drawing.Point(1180, 311)
        Me.AceptaAccion.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.AceptaAccion.Name = "AceptaAccion"
        Me.AceptaAccion.Size = New System.Drawing.Size(76, 68)
        Me.AceptaAccion.TabIndex = 4
        Me.AceptaAccion.ToolTip = "Aceptar"
        '
        'cbOperaciones
        '
        Me.cbOperaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOperaciones.Location = New System.Drawing.Point(977, 192)
        Me.cbOperaciones.Name = "cbOperaciones"
        Me.cbOperaciones.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperaciones.Properties.Appearance.Options.UseFont = True
        Me.cbOperaciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbOperaciones.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Operación")})
        Me.cbOperaciones.Properties.DataSource = Me.PLOPERACIONESBindingSource
        Me.cbOperaciones.Properties.DisplayMember = "DESCRIPCION"
        Me.cbOperaciones.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cbOperaciones.Properties.ReadOnly = True
        Me.cbOperaciones.Properties.ValueMember = "ID"
        Me.cbOperaciones.Size = New System.Drawing.Size(342, 42)
        Me.cbOperaciones.TabIndex = 2
        '
        'PLOPERACIONESBindingSource
        '
        Me.PLOPERACIONESBindingSource.DataMember = "PL_OPERACIONES"
        Me.PLOPERACIONESBindingSource.DataSource = Me.ProduccionSql
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(977, 173)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Operación :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(977, 51)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Acción :"
        '
        'cbAcciones
        '
        Me.cbAcciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAcciones.Location = New System.Drawing.Point(977, 70)
        Me.cbAcciones.Name = "cbAcciones"
        Me.cbAcciones.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAcciones.Properties.Appearance.Options.UseFont = True
        Me.cbAcciones.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbAcciones.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Accion")})
        Me.cbAcciones.Properties.DataSource = Me.PLACCIONESBindingSource
        Me.cbAcciones.Properties.DisplayMember = "NOMBRE"
        Me.cbAcciones.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cbAcciones.Properties.ReadOnly = True
        Me.cbAcciones.Properties.ValueMember = "ID"
        Me.cbAcciones.Size = New System.Drawing.Size(279, 42)
        Me.cbAcciones.TabIndex = 0
        '
        'PLACCIONESBindingSource
        '
        Me.PLACCIONESBindingSource.DataMember = "PL_ACCIONES"
        Me.PLACCIONESBindingSource.DataSource = Me.ProduccionSql
        '
        'PL_ACCIONESTableAdapter
        '
        Me.PL_ACCIONESTableAdapter.ClearBeforeFill = True
        '
        'PL_OPERACIONESTableAdapter
        '
        Me.PL_OPERACIONESTableAdapter.ClearBeforeFill = True
        '
        'Observaciones
        '
        Me.Observaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Observaciones.Location = New System.Drawing.Point(0, 0)
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
        Me.Observaciones.Properties.Appearance.Options.UseBackColor = True
        Me.Observaciones.Size = New System.Drawing.Size(1499, 78)
        Me.Observaciones.TabIndex = 0
        '
        'Principal
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.SplitContainerControl2)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "Principal"
        Me.Size = New System.Drawing.Size(1504, 888)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartesDeProduccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.cbOperaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLOPERACIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbAcciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLACCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Observaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PartesDeProduccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPalesFabricar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajasFabricar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTANQUE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLOTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdEnvase As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaConsumoPreferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGTINCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCADUCIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMENSAJEBOTELLA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMENSAJECAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPOETIQUETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMARCA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGTINCAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGTINPALET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdiomaMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMARCARCAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFORMATOMESALFA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colETIQUETARCAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPOETIQUETACAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMENSAJELASER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Partes_de_produccionTableAdapter As GesLineas.ProduccionSqlTableAdapters.Partes_de_produccionTableAdapter
    Friend WithEvents RepositoryItemGridLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataset As GesLineas.DatosDataset
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents ARTICULOSTableAdapter As GesLineas.DatosDatasetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents cbAcciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CancelaAccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AceptaAccion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbOperaciones As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PLACCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PL_ACCIONESTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_ACCIONESTableAdapter
    Friend WithEvents PLOPERACIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PL_OPERACIONESTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_OPERACIONESTableAdapter
    Friend WithEvents Observaciones As DevExpress.XtraEditors.MemoEdit

End Class
