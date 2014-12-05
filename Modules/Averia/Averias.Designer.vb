<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Averias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Averias))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbMaquina = New DevExpress.XtraEditors.LookUpEdit()
        Me.Observaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.MaquinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mantenimiento = New GesLineas.Mantenimiento()
        Me.NotificacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotificacionesTableAdapter = New GesLineas.MantenimientoTableAdapters.NotificacionesTableAdapter()
        Me.MaquinasTableAdapter = New GesLineas.MantenimientoTableAdapters.MaquinasTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cmbMaquina.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Observaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaquinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotificacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1006, 58)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(21, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 30)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Averias"
        '
        'cmbMaquina
        '
        Me.cmbMaquina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMaquina.Location = New System.Drawing.Point(168, 112)
        Me.cmbMaquina.Name = "cmbMaquina"
        Me.cmbMaquina.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMaquina.Properties.Appearance.Options.UseFont = True
        Me.cmbMaquina.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbMaquina.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", "Codigo"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Máquina")})
        Me.cmbMaquina.Properties.DataSource = Me.MaquinasBindingSource
        Me.cmbMaquina.Properties.DisplayMember = "DESCRIPCION"
        Me.cmbMaquina.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbMaquina.Properties.ValueMember = "ID"
        Me.cmbMaquina.Size = New System.Drawing.Size(611, 42)
        Me.cmbMaquina.TabIndex = 1
        '
        'Observaciones
        '
        Me.Observaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Observaciones.Location = New System.Drawing.Point(35, 185)
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Observaciones.Properties.Appearance.Options.UseFont = True
        Me.Observaciones.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.Observaciones.Size = New System.Drawing.Size(934, 362)
        Me.Observaciones.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(767, 553)
        Me.SimpleButton1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(202, 59)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Aceptar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(35, 553)
        Me.SimpleButton2.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(202, 59)
        Me.SimpleButton2.TabIndex = 4
        Me.SimpleButton2.Text = "Cancelar"
        '
        'MaquinasBindingSource
        '
        Me.MaquinasBindingSource.DataMember = "Maquinas"
        Me.MaquinasBindingSource.DataSource = Me.Mantenimiento
        '
        'Mantenimiento
        '
        Me.Mantenimiento.DataSetName = "Mantenimiento"
        Me.Mantenimiento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotificacionesBindingSource
        '
        Me.NotificacionesBindingSource.DataMember = "Notificaciones"
        Me.NotificacionesBindingSource.DataSource = Me.Mantenimiento
        '
        'NotificacionesTableAdapter
        '
        Me.NotificacionesTableAdapter.ClearBeforeFill = True
        '
        'MaquinasTableAdapter
        '
        Me.MaquinasTableAdapter.ClearBeforeFill = True
        '
        'Averias
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cmbMaquina)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Observaciones)
        Me.Name = "Averias"
        Me.Size = New System.Drawing.Size(1006, 632)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cmbMaquina.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Observaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaquinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotificacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NotificacionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Mantenimiento As GesLineas.Mantenimiento
    Friend WithEvents NotificacionesTableAdapter As GesLineas.MantenimientoTableAdapters.NotificacionesTableAdapter
    Friend WithEvents cmbMaquina As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MaquinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaquinasTableAdapter As GesLineas.MantenimientoTableAdapters.MaquinasTableAdapter
    Friend WithEvents Observaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton

End Class
