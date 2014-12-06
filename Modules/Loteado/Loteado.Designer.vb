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
        Me.txtCajas = New DevExpress.XtraEditors.TextEdit()
        Me.txtPales = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.btAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.btCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(873, 60)
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
        'txtCajas
        '
        Me.txtCajas.EditValue = "0"
        Me.txtCajas.Location = New System.Drawing.Point(595, 98)
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Properties.Appearance.Options.UseFont = True
        Me.txtCajas.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtCajas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCajas.Size = New System.Drawing.Size(140, 42)
        Me.txtCajas.TabIndex = 61
        '
        'txtPales
        '
        Me.txtPales.EditValue = "0"
        Me.txtPales.Location = New System.Drawing.Point(248, 98)
        Me.txtPales.Name = "txtPales"
        Me.txtPales.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPales.Properties.Appearance.Options.UseFont = True
        Me.txtPales.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.txtPales.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPales.Size = New System.Drawing.Size(140, 42)
        Me.txtPales.TabIndex = 60
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(403, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(177, 30)
        Me.LabelControl3.TabIndex = 59
        Me.LabelControl3.Text = "Cajas Producidas.:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(51, 101)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(179, 30)
        Me.LabelControl2.TabIndex = 58
        Me.LabelControl2.Text = "Palés Producidos.:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(51, 261)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(206, 30)
        Me.LabelControl4.TabIndex = 62
        Me.LabelControl4.Text = "Nuevo Nro. de Lote.:"
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(282, 258)
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
        Me.btAceptar.Location = New System.Drawing.Point(582, 361)
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
        Me.btCancelar.Location = New System.Drawing.Point(67, 361)
        Me.btCancelar.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(190, 62)
        Me.btCancelar.TabIndex = 65
        Me.btCancelar.Text = "Cancelar"
        '
        'Loteado
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCajas)
        Me.Controls.Add(Me.txtPales)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "Loteado"
        Me.Size = New System.Drawing.Size(873, 508)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

End Class
