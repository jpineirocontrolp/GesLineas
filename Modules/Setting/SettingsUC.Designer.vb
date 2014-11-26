<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsUC
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
        Me.CABECERAFABRICACIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.CABECERAFABRICACIONTableAdapter = New GesLineas.ProduccionSqlTableAdapters.CABECERAFABRICACIONTableAdapter()
        Me.emptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmbLineas = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLineas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CABECERAFABRICACIONBindingSource
        '
        Me.CABECERAFABRICACIONBindingSource.DataMember = "CABECERAFABRICACION"
        Me.CABECERAFABRICACIONBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CABECERAFABRICACIONTableAdapter
        '
        Me.CABECERAFABRICACIONTableAdapter.ClearBeforeFill = True
        '
        'emptySpaceItem5
        '
        Me.emptySpaceItem5.AllowHotTrack = False
        Me.emptySpaceItem5.CustomizationFormText = "emptySpaceItem5"
        Me.emptySpaceItem5.Location = New System.Drawing.Point(0, 255)
        Me.emptySpaceItem5.Name = "emptySpaceItem5"
        Me.emptySpaceItem5.Size = New System.Drawing.Size(425, 46)
        Me.emptySpaceItem5.Text = "emptySpaceItem5"
        Me.emptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmbLineas
        '
        Me.cmbLineas.Location = New System.Drawing.Point(100, 64)
        Me.cmbLineas.Name = "cmbLineas"
        Me.cmbLineas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLineas.Properties.DataSource = Me.CABECERAFABRICACIONBindingSource
        Me.cmbLineas.Properties.DisplayMember = "Descripcion"
        Me.cmbLineas.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbLineas.Properties.ValueMember = "ID"
        Me.cmbLineas.Properties.View = Me.GridLookUpEdit1View
        Me.cmbLineas.Size = New System.Drawing.Size(397, 36)
        Me.cmbLineas.TabIndex = 2
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(100, 44)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(213, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Indicar la linea por defecto para este puesto"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton1.Location = New System.Drawing.Point(100, 119)
        Me.SimpleButton1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(104, 61)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Aceptar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(393, 119)
        Me.SimpleButton2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(104, 61)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "Cancelar"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Descripcion"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'SettingsUC
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmbLineas)
        Me.Name = "SettingsUC"
        Me.Size = New System.Drawing.Size(651, 200)
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLineas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CABECERAFABRICACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents CABECERAFABRICACIONTableAdapter As GesLineas.ProduccionSqlTableAdapters.CABECERAFABRICACIONTableAdapter
    Private WithEvents emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents cmbLineas As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
