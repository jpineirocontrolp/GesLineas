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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.PropertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.PLACCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PL_ACCIONESTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_ACCIONESTableAdapter()
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLACCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SimpleButton1
        '
        Me.SimpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SimpleButton1.Location = New System.Drawing.Point(311, 570)
        Me.SimpleButton1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(104, 61)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Aceptar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SimpleButton2.Location = New System.Drawing.Point(536, 570)
        Me.SimpleButton2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(104, 61)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "Cancelar"
        '
        'PropertyGridControl1
        '
        Me.PropertyGridControl1.Location = New System.Drawing.Point(3, 3)
        Me.PropertyGridControl1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.PropertyGridControl1.Name = "PropertyGridControl1"
        Me.PropertyGridControl1.Size = New System.Drawing.Size(637, 548)
        Me.PropertyGridControl1.TabIndex = 11
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
        'SettingsUC
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PropertyGridControl1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "SettingsUC"
        Me.Size = New System.Drawing.Size(651, 662)
        CType(Me.CABECERAFABRICACIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLACCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CABECERAFABRICACIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents CABECERAFABRICACIONTableAdapter As GesLineas.ProduccionSqlTableAdapters.CABECERAFABRICACIONTableAdapter
    Private WithEvents emptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PropertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents PLACCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PL_ACCIONESTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_ACCIONESTableAdapter
End Class
