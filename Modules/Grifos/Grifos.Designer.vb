<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grifos
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grifos))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.PLGRIFOSLINEASBindingSource = New System.Windows.Forms.BindingSource()
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDCABECERAPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDGRIFOPL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PLGRIFOSBindingSource = New System.Windows.Forms.BindingSource()
        Me.colPESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHORA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODEMPRESA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEJERCICIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.PL_GRIFOSLINEASTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_GRIFOSLINEASTableAdapter()
        Me.PL_GRIFOSTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_GRIFOSTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLGRIFOSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLGRIFOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.PLGRIFOSLINEASBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 64)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(734, 332)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PLGRIFOSLINEASBindingSource
        '
        Me.PLGRIFOSLINEASBindingSource.DataMember = "PL_GRIFOSLINEAS"
        Me.PLGRIFOSLINEASBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIDCABECERAPL, Me.colIDGRIFOPL, Me.colPESO, Me.colHORA, Me.colCODEMPRESA, Me.colEJERCICIO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colIDCABECERAPL
        '
        Me.colIDCABECERAPL.FieldName = "IDCABECERAPL"
        Me.colIDCABECERAPL.Name = "colIDCABECERAPL"
        '
        'colIDGRIFOPL
        '
        Me.colIDGRIFOPL.Caption = "Grifo"
        Me.colIDGRIFOPL.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colIDGRIFOPL.FieldName = "IDGRIFOPL"
        Me.colIDGRIFOPL.Name = "colIDGRIFOPL"
        Me.colIDGRIFOPL.Visible = True
        Me.colIDGRIFOPL.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMBRE", "Grifo")})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.PLGRIFOSBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "NOMBRE"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'PLGRIFOSBindingSource
        '
        Me.PLGRIFOSBindingSource.DataMember = "PL_GRIFOS"
        Me.PLGRIFOSBindingSource.DataSource = Me.ProduccionSql
        '
        'colPESO
        '
        Me.colPESO.Caption = "Peso"
        Me.colPESO.FieldName = "PESO"
        Me.colPESO.Name = "colPESO"
        Me.colPESO.Visible = True
        Me.colPESO.VisibleIndex = 1
        '
        'colHORA
        '
        Me.colHORA.FieldName = "HORA"
        Me.colHORA.Name = "colHORA"
        Me.colHORA.Visible = True
        Me.colHORA.VisibleIndex = 2
        '
        'colCODEMPRESA
        '
        Me.colCODEMPRESA.FieldName = "CODEMPRESA"
        Me.colCODEMPRESA.Name = "colCODEMPRESA"
        '
        'colEJERCICIO
        '
        Me.colEJERCICIO.FieldName = "EJERCICIO"
        Me.colEJERCICIO.Name = "colEJERCICIO"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(737, 58)
        Me.PanelControl1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(167, 30)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Control de grifos"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btAceptar)
        Me.PanelControl2.Controls.Add(Me.btCancelar)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 402)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(737, 100)
        Me.PanelControl2.TabIndex = 2
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btAceptar.Image = CType(resources.GetObject("btAceptar.Image"), System.Drawing.Image)
        Me.btAceptar.Location = New System.Drawing.Point(524, 18)
        Me.btAceptar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(190, 62)
        Me.btAceptar.TabIndex = 66
        Me.btAceptar.Text = "Aceptar"
        '
        'btCancelar
        '
        Me.btCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelar.Image = CType(resources.GetObject("btCancelar.Image"), System.Drawing.Image)
        Me.btCancelar.Location = New System.Drawing.Point(34, 18)
        Me.btCancelar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 62)
        Me.btCancelar.TabIndex = 67
        Me.btCancelar.Text = "Cancelar"
        '
        'PL_GRIFOSLINEASTableAdapter
        '
        Me.PL_GRIFOSLINEASTableAdapter.ClearBeforeFill = True
        '
        'PL_GRIFOSTableAdapter
        '
        Me.PL_GRIFOSTableAdapter.ClearBeforeFill = True
        '
        'Grifos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Grifos"
        Me.Size = New System.Drawing.Size(737, 502)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLGRIFOSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLGRIFOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PLGRIFOSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDCABECERAPL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDGRIFOPL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PLGRIFOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHORA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODEMPRESA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEJERCICIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PL_GRIFOSLINEASTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_GRIFOSLINEASTableAdapter
    Friend WithEvents PL_GRIFOSTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_GRIFOSTableAdapter

End Class
