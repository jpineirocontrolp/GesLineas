<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etiquetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Etiquetas))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCajas = New DevExpress.XtraEditors.TextEdit()
        Me.txtPales = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PalesPendientesTicarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdOperario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdTanque = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TANQUESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colIdArti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosDataset = New GesLineas.DatosDataset()
        Me.colNumLote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContador = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdLinProd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodempresa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEjercicio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDPL_PARTESPRODUCCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNroOrden = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PalesPendientesTicarTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PalesPendientesTicarTableAdapter()
        Me.TANQUESTableAdapter = New GesLineas.ProduccionSqlTableAdapters.TANQUESTableAdapter()
        Me.ARTICULOSTableAdapter = New GesLineas.DatosDatasetTableAdapters.ARTICULOSTableAdapter()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalesPendientesTicarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TANQUESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btImprimir)
        Me.PanelControl1.Controls.Add(Me.txtCajas)
        Me.PanelControl1.Controls.Add(Me.txtPales)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(946, 175)
        Me.PanelControl1.TabIndex = 0
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Image = CType(resources.GetObject("btCancelar.Image"), System.Drawing.Image)
        Me.btCancelar.Location = New System.Drawing.Point(791, 467)
        Me.btCancelar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(138, 62)
        Me.btCancelar.TabIndex = 12
        Me.btCancelar.Text = "Salir"
        '
        'btImprimir
        '
        Me.btImprimir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImprimir.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btImprimir.Image = CType(resources.GetObject("btImprimir.Image"), System.Drawing.Image)
        Me.btImprimir.Location = New System.Drawing.Point(607, 88)
        Me.btImprimir.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(193, 62)
        Me.btImprimir.TabIndex = 11
        Me.btImprimir.Text = "Almacenar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Etiquetas"
        '
        'txtCajas
        '
        Me.txtCajas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCajas.EditValue = "0"
        Me.txtCajas.Location = New System.Drawing.Point(657, 15)
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Properties.Appearance.Options.UseFont = True
        Me.txtCajas.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtCajas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCajas.Size = New System.Drawing.Size(143, 42)
        Me.txtCajas.TabIndex = 10
        '
        'txtPales
        '
        Me.txtPales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPales.EditValue = "0"
        Me.txtPales.Location = New System.Drawing.Point(268, 15)
        Me.txtPales.Name = "txtPales"
        Me.txtPales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPales.Properties.Appearance.Options.UseFont = True
        Me.txtPales.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtPales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPales.Size = New System.Drawing.Size(143, 42)
        Me.txtPales.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(451, 18)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(194, 30)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Pico (0 no es pico).:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(61, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(152, 30)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Nro. Etiquetas.:"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.PalesPendientesTicarBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(4, 182)
        Me.GridControl1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(748, 531)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PalesPendientesTicarBindingSource
        '
        Me.PalesPendientesTicarBindingSource.DataMember = "PalesPendientesTicar"
        Me.PalesPendientesTicarBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIdOperario, Me.colIdTanque, Me.colIdArti, Me.colNumLote, Me.colContador, Me.colUbicacion, Me.colIdLinProd, Me.colCodempresa, Me.colEjercicio, Me.colUnidades, Me.colIDPL_PARTESPRODUCCION, Me.colNroOrden})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colIdOperario
        '
        Me.colIdOperario.FieldName = "IdOperario"
        Me.colIdOperario.Name = "colIdOperario"
        '
        'colIdTanque
        '
        Me.colIdTanque.Caption = "Tanque"
        Me.colIdTanque.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIdTanque.FieldName = "IdTanque"
        Me.colIdTanque.Name = "colIdTanque"
        Me.colIdTanque.Visible = True
        Me.colIdTanque.VisibleIndex = 4
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TANQUESBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "descripcion"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'TANQUESBindingSource
        '
        Me.TANQUESBindingSource.DataMember = "TANQUES"
        Me.TANQUESBindingSource.DataSource = Me.ProduccionSql
        '
        'colIdArti
        '
        Me.colIdArti.Caption = "Articulo"
        Me.colIdArti.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colIdArti.FieldName = "IdArti"
        Me.colIdArti.Name = "colIdArti"
        Me.colIdArti.Visible = True
        Me.colIdArti.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.ARTICULOSBindingSource
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Descripcion"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Id"
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
        'colNumLote
        '
        Me.colNumLote.FieldName = "NumLote"
        Me.colNumLote.Name = "colNumLote"
        Me.colNumLote.Visible = True
        Me.colNumLote.VisibleIndex = 3
        '
        'colContador
        '
        Me.colContador.Caption = "Palet"
        Me.colContador.FieldName = "Contador"
        Me.colContador.Name = "colContador"
        Me.colContador.Visible = True
        Me.colContador.VisibleIndex = 2
        '
        'colUbicacion
        '
        Me.colUbicacion.FieldName = "Ubicacion"
        Me.colUbicacion.Name = "colUbicacion"
        '
        'colIdLinProd
        '
        Me.colIdLinProd.FieldName = "IdLinProd"
        Me.colIdLinProd.Name = "colIdLinProd"
        '
        'colCodempresa
        '
        Me.colCodempresa.FieldName = "Codempresa"
        Me.colCodempresa.Name = "colCodempresa"
        '
        'colEjercicio
        '
        Me.colEjercicio.FieldName = "Ejercicio"
        Me.colEjercicio.Name = "colEjercicio"
        '
        'colUnidades
        '
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        '
        'colIDPL_PARTESPRODUCCION
        '
        Me.colIDPL_PARTESPRODUCCION.FieldName = "IDPL_PARTESPRODUCCION"
        Me.colIDPL_PARTESPRODUCCION.Name = "colIDPL_PARTESPRODUCCION"
        '
        'colNroOrden
        '
        Me.colNroOrden.Caption = "Nro.Orden"
        Me.colNroOrden.FieldName = "NroOrden"
        Me.colNroOrden.Name = "colNroOrden"
        Me.colNroOrden.Visible = True
        Me.colNroOrden.VisibleIndex = 0
        '
        'PalesPendientesTicarTableAdapter
        '
        Me.PalesPendientesTicarTableAdapter.ClearBeforeFill = True
        '
        'TANQUESTableAdapter
        '
        Me.TANQUESTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton1.Location = New System.Drawing.Point(791, 202)
        Me.SimpleButton1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(138, 91)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Imprimir Etiquietas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pales Seleccionados"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.SimpleButton2.Location = New System.Drawing.Point(791, 332)
        Me.SimpleButton2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(138, 91)
        Me.SimpleButton2.TabIndex = 13
        Me.SimpleButton2.Text = "Imprimir Etiquietas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pales Seleccionados"
        '
        'Etiquetas
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Etiquetas"
        Me.Size = New System.Drawing.Size(946, 716)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalesPendientesTicarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TANQUESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCajas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents PalesPendientesTicarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdOperario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdTanque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TANQUESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colIdArti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatosDataset As GesLineas.DatosDataset
    Friend WithEvents colNumLote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContador As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdLinProd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodempresa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEjercicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDPL_PARTESPRODUCCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNroOrden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PalesPendientesTicarTableAdapter As GesLineas.ProduccionSqlTableAdapters.PalesPendientesTicarTableAdapter
    Friend WithEvents TANQUESTableAdapter As GesLineas.ProduccionSqlTableAdapters.TANQUESTableAdapter
    Friend WithEvents ARTICULOSTableAdapter As GesLineas.DatosDatasetTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton

End Class
