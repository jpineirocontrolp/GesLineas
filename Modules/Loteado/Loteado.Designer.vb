<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loteado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loteado))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPales = New DevExpress.XtraEditors.TextEdit()
        Me.txtCajas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.btAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.PLLOTESAUXILIARESBindingSource = New System.Windows.Forms.BindingSource()
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidcabecera1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colidmateriaprima1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colLOTE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODEMPRESA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEJERCICIO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PL_LOTESAUXILIARESTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_LOTESAUXILIARESTableAdapter()
        Me.LotesMPADisponiblesTableAdapter = New GesLineas.ProduccionSqlTableAdapters.LotesMPADisponiblesTableAdapter()
        Me.MateriasPrimasTableAdapter = New GesLineas.ProduccionSqlTableAdapters.MateriasPrimasTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLLOTESAUXILIARESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtPales)
        Me.PanelControl1.Controls.Add(Me.txtCajas)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1221, 60)
        Me.PanelControl1.TabIndex = 57
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 17)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(251, 30)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Loteado (Cambio de lote)"
        '
        'txtPales
        '
        Me.txtPales.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPales.EditValue = "0"
        Me.txtPales.Location = New System.Drawing.Point(697, 13)
        Me.txtPales.Name = "txtPales"
        Me.txtPales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPales.Properties.Appearance.Options.UseFont = True
        Me.txtPales.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtPales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPales.Size = New System.Drawing.Size(140, 42)
        Me.txtPales.TabIndex = 60
        '
        'txtCajas
        '
        Me.txtCajas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCajas.EditValue = "0"
        Me.txtCajas.Location = New System.Drawing.Point(1045, 6)
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Properties.Appearance.Options.UseFont = True
        Me.txtCajas.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtCajas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCajas.Size = New System.Drawing.Size(140, 42)
        Me.txtCajas.TabIndex = 61
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(852, 16)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(177, 30)
        Me.LabelControl3.TabIndex = 59
        Me.LabelControl3.Text = "Cajas Producidas.:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(512, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(179, 30)
        Me.LabelControl2.TabIndex = 58
        Me.LabelControl2.Text = "Palés Producidos.:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(33, 425)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(206, 30)
        Me.LabelControl4.TabIndex = 62
        Me.LabelControl4.Text = "Nuevo Nro. de Lote.:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(33, 461)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(497, 42)
        Me.TextEdit1.TabIndex = 63
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btAceptar.Image = CType(resources.GetObject("btAceptar.Image"), System.Drawing.Image)
        Me.btAceptar.Location = New System.Drawing.Point(961, 403)
        Me.btAceptar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(190, 62)
        Me.btAceptar.TabIndex = 64
        Me.btAceptar.Text = "Aceptar"
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Image = CType(resources.GetObject("btCancelar.Image"), System.Drawing.Image)
        Me.btCancelar.Location = New System.Drawing.Point(961, 482)
        Me.btCancelar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 62)
        Me.btCancelar.TabIndex = 65
        Me.btCancelar.Text = "Cancelar"
        '
        'GridControl2
        '
        Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl2.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl2.DataSource = Me.PLLOTESAUXILIARESBindingSource
        Me.GridControl2.Location = New System.Drawing.Point(0, 66)
        Me.GridControl2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemImageComboBox1, Me.RepositoryItemButtonEdit1})
        Me.GridControl2.Size = New System.Drawing.Size(1218, 331)
        Me.GridControl2.TabIndex = 66
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'PLLOTESAUXILIARESBindingSource
        '
        Me.PLLOTESAUXILIARESBindingSource.DataMember = "PL_LOTESAUXILIARES"
        Me.PLLOTESAUXILIARESBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView2
        '
        Me.GridView2.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.Appearance.Row.Options.UseFont = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID1, Me.colidcabecera1, Me.colidmateriaprima1, Me.colLOTE1, Me.colCODEMPRESA1, Me.colEJERCICIO1, Me.colCANTIDAD, Me.GridColumn1})
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colID1
        '
        Me.colID1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        Me.colID1.OptionsColumn.ReadOnly = True
        '
        'colidcabecera1
        '
        Me.colidcabecera1.FieldName = "idcabecera"
        Me.colidcabecera1.Name = "colidcabecera1"
        '
        'colidmateriaprima1
        '
        Me.colidmateriaprima1.Caption = "Materia Prima"
        Me.colidmateriaprima1.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colidmateriaprima1.FieldName = "idmateriaprima"
        Me.colidmateriaprima1.Name = "colidmateriaprima1"
        Me.colidmateriaprima1.Visible = True
        Me.colidmateriaprima1.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Descripcion")})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "DESCRIPCION"
        Me.RepositoryItemLookUpEdit2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Id"
        '
        'colLOTE1
        '
        Me.colLOTE1.Caption = "Lote"
        Me.colLOTE1.FieldName = "ID_LINCOMPRALOTE"
        Me.colLOTE1.Name = "colLOTE1"
        Me.colLOTE1.Visible = True
        Me.colLOTE1.VisibleIndex = 2
        '
        'colCODEMPRESA1
        '
        Me.colCODEMPRESA1.FieldName = "CODEMPRESA"
        Me.colCODEMPRESA1.Name = "colCODEMPRESA1"
        '
        'colEJERCICIO1
        '
        Me.colEJERCICIO1.FieldName = "EJERCICIO"
        Me.colEJERCICIO1.Name = "colEJERCICIO1"
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "Cantidad usada"
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Producido"
        Me.GridColumn1.FieldName = "Producido"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReferenciaLinea", "Lote"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Diferencia", "Cantidad Disponible"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoAlbaran", "Albaran"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FECHA", "Fecha")})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "ReferenciaLinea"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "ReferenciaLinea"
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'PL_LOTESAUXILIARESTableAdapter
        '
        Me.PL_LOTESAUXILIARESTableAdapter.ClearBeforeFill = True
        '
        'LotesMPADisponiblesTableAdapter
        '
        Me.LotesMPADisponiblesTableAdapter.ClearBeforeFill = True
        '
        'MateriasPrimasTableAdapter
        '
        Me.MateriasPrimasTableAdapter.ClearBeforeFill = True
        '
        'Loteado
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl2)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Loteado"
        Me.Size = New System.Drawing.Size(1221, 547)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLLOTESAUXILIARESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCajas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidcabecera1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colidmateriaprima1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colLOTE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODEMPRESA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEJERCICIO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents PLLOTESAUXILIARESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents PL_LOTESAUXILIARESTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_LOTESAUXILIARESTableAdapter
    Friend WithEvents LotesMPADisponiblesTableAdapter As GesLineas.ProduccionSqlTableAdapters.LotesMPADisponiblesTableAdapter
    Friend WithEvents MateriasPrimasTableAdapter As GesLineas.ProduccionSqlTableAdapters.MateriasPrimasTableAdapter

End Class
