<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarLote
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.LotesMPADisponiblesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferenciaLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLITROS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDiferencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODIGO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoAlbaran = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LotesMPADisponiblesTableAdapter = New GesLineas.ProduccionSqlTableAdapters.LotesMPADisponiblesTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotesMPADisponiblesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.DataSource = Me.LotesMPADisponiblesBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(630, 606)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'LotesMPADisponiblesBindingSource
        '
        Me.LotesMPADisponiblesBindingSource.DataMember = "LotesMPADisponibles"
        Me.LotesMPADisponiblesBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFECHA, Me.colReferenciaLinea, Me.colUNIDADES, Me.colLITROS, Me.colDiferencia, Me.colID, Me.colCODIGO, Me.colCodigoAlbaran})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "Fecha Albaran"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 3
        '
        'colReferenciaLinea
        '
        Me.colReferenciaLinea.Caption = "Lote (Referencia Linea)"
        Me.colReferenciaLinea.FieldName = "ReferenciaLinea"
        Me.colReferenciaLinea.Name = "colReferenciaLinea"
        Me.colReferenciaLinea.Visible = True
        Me.colReferenciaLinea.VisibleIndex = 0
        '
        'colUNIDADES
        '
        Me.colUNIDADES.FieldName = "UNIDADES"
        Me.colUNIDADES.Name = "colUNIDADES"
        '
        'colLITROS
        '
        Me.colLITROS.FieldName = "LITROS"
        Me.colLITROS.Name = "colLITROS"
        '
        'colDiferencia
        '
        Me.colDiferencia.Caption = "Disponibles"
        Me.colDiferencia.FieldName = "Diferencia"
        Me.colDiferencia.Name = "colDiferencia"
        Me.colDiferencia.OptionsColumn.ReadOnly = True
        Me.colDiferencia.Visible = True
        Me.colDiferencia.VisibleIndex = 1
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colCODIGO
        '
        Me.colCODIGO.FieldName = "CODIGO"
        Me.colCODIGO.Name = "colCODIGO"
        '
        'colCodigoAlbaran
        '
        Me.colCodigoAlbaran.Caption = "Albaran"
        Me.colCodigoAlbaran.FieldName = "CodigoAlbaran"
        Me.colCodigoAlbaran.Name = "colCodigoAlbaran"
        Me.colCodigoAlbaran.Visible = True
        Me.colCodigoAlbaran.VisibleIndex = 2
        '
        'LotesMPADisponiblesTableAdapter
        '
        Me.LotesMPADisponiblesTableAdapter.ClearBeforeFill = True
        '
        'FormBuscarLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FormBuscarLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormBuscarLote"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotesMPADisponiblesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents LotesMPADisponiblesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LotesMPADisponiblesTableAdapter As GesLineas.ProduccionSqlTableAdapters.LotesMPADisponiblesTableAdapter
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferenciaLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLITROS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDiferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODIGO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoAlbaran As DevExpress.XtraGrid.Columns.GridColumn
End Class
