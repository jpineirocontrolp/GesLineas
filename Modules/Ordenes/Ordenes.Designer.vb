<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes))
        Me.PLPARTESPRODUCCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PL_PARTESPRODUCCIONTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_PARTESPRODUCCIONTableAdapter()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CABECERAFABRICACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCodEmpresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEjercicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.colFechaProduccion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CABECERAFABRICACIONTableAdapter = New GesLineas.ProduccionSqlTableAdapters.CABECERAFABRICACIONTableAdapter()
        Me.lciBackPicture = New System.Windows.Forms.PictureBox()
        CType(Me.PLPARTESPRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciBackPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLPARTESPRODUCCIONBindingSource
        '
        Me.PLPARTESPRODUCCIONBindingSource.DataMember = "PL_PARTESPRODUCCION"
        Me.PLPARTESPRODUCCIONBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(319, 30)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Relación de Ordenes disponibles"
        '
        'PL_PARTESPRODUCCIONTableAdapter
        '
        Me.PL_PARTESPRODUCCIONTableAdapter.ClearBeforeFill = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(59, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(622, 61)
        Me.PanelControl1.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.PLPARTESPRODUCCIONBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(4, 71)
        Me.GridControl1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(677, 213)
        Me.GridControl1.TabIndex = 3
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNroOrden, Me.colIdLinea, Me.colCodEmpresa, Me.colEjercicio, Me.colESTADO, Me.colFechaProduccion})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupCount = 1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFechaProduccion, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colNroOrden
        '
        Me.colNroOrden.FieldName = "NroOrden"
        Me.colNroOrden.Name = "colNroOrden"
        Me.colNroOrden.Visible = True
        Me.colNroOrden.VisibleIndex = 0
        '
        'colIdLinea
        '
        Me.colIdLinea.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIdLinea.FieldName = "IdLinea"
        Me.colIdLinea.Name = "colIdLinea"
        Me.colIdLinea.Visible = True
        Me.colIdLinea.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.CABECERAFABRICACIONBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        Me.RepositoryItemLookUpEdit1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'CABECERAFABRICACIONBindingSource
        '
        Me.CABECERAFABRICACIONBindingSource.DataMember = "CABECERAFABRICACION"
        Me.CABECERAFABRICACIONBindingSource.DataSource = Me.ProduccionSql
        '
        'colCodEmpresa
        '
        Me.colCodEmpresa.FieldName = "CodEmpresa"
        Me.colCodEmpresa.Name = "colCodEmpresa"
        '
        'colEjercicio
        '
        Me.colEjercicio.FieldName = "Ejercicio"
        Me.colEjercicio.Name = "colEjercicio"
        '
        'colESTADO
        '
        Me.colESTADO.ColumnEdit = Me.RepositoryItemComboBox1
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Pendiente", "En Cola", "En Produccion", "Finalizado"})
        Me.RepositoryItemComboBox1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'colFechaProduccion
        '
        Me.colFechaProduccion.FieldName = "FechaProduccion"
        Me.colFechaProduccion.Name = "colFechaProduccion"
        Me.colFechaProduccion.Visible = True
        Me.colFechaProduccion.VisibleIndex = 2
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'CABECERAFABRICACIONTableAdapter
        '
        Me.CABECERAFABRICACIONTableAdapter.ClearBeforeFill = True
        '
        'lciBackPicture
        '
        Me.lciBackPicture.Image = CType(resources.GetObject("lciBackPicture.Image"), System.Drawing.Image)
        Me.lciBackPicture.Location = New System.Drawing.Point(14, 17)
        Me.lciBackPicture.Name = "lciBackPicture"
        Me.lciBackPicture.Size = New System.Drawing.Size(30, 34)
        Me.lciBackPicture.TabIndex = 54
        Me.lciBackPicture.TabStop = False
        '
        'Ordenes
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lciBackPicture)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Ordenes"
        Me.Size = New System.Drawing.Size(684, 287)
        CType(Me.PLPARTESPRODUCCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciBackPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PLPARTESPRODUCCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents PL_PARTESPRODUCCIONTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_PARTESPRODUCCIONTableAdapter
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIdLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents CABECERAFABRICACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCodEmpresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEjercicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaProduccion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CABECERAFABRICACIONTableAdapter As GesLineas.ProduccionSqlTableAdapters.CABECERAFABRICACIONTableAdapter
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Private WithEvents lciBackPicture As System.Windows.Forms.PictureBox

End Class
