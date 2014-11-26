<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.navButtonHome = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonOrden = New DevExpress.XtraBars.Navigation.NavButton()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonSettings = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonHelp = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonClose = New DevExpress.XtraBars.Navigation.NavButton()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.Ordenes = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileNavPane1
        '
        Me.TileNavPane1.AllowGlyphSkinning = True
        Me.TileNavPane1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TileNavPane1.Appearance.Options.UseBackColor = True
        Me.TileNavPane1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TileNavPane1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TileNavPane1.AppearanceHovered.Options.UseBackColor = True
        Me.TileNavPane1.AppearanceHovered.Options.UseForeColor = True
        Me.TileNavPane1.AppearanceSelected.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TileNavPane1.AppearanceSelected.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.TileNavPane1.AppearanceSelected.Options.UseBackColor = True
        Me.TileNavPane1.AppearanceSelected.Options.UseForeColor = True
        Me.TileNavPane1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.TileNavPane1.Buttons.Add(Me.navButtonHome)
        Me.TileNavPane1.Buttons.Add(Me.navButtonOrden)
        Me.TileNavPane1.Buttons.Add(Me.NavButton2)
        Me.TileNavPane1.Buttons.Add(Me.navButtonSettings)
        Me.TileNavPane1.Buttons.Add(Me.navButtonHelp)
        Me.TileNavPane1.Buttons.Add(Me.navButtonClose)
        '
        'tileNavCategory1
        '
        Me.TileNavPane1.DefaultCategory.Name = "tileNavCategory1"
        Me.TileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.TileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.TileNavPane1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileNavPane1.Location = New System.Drawing.Point(0, 0)
        Me.TileNavPane1.Name = "TileNavPane1"
        Me.TileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.TileNavPane1.Size = New System.Drawing.Size(1585, 38)
        Me.TileNavPane1.TabIndex = 0
        Me.TileNavPane1.Text = "tileNavPane1"
        '
        'navButtonHome
        '
        Me.navButtonHome.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left
        Me.navButtonHome.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.navButtonHome.Caption = "Linea"
        Me.navButtonHome.Enabled = False
        Me.navButtonHome.Name = "navButtonHome"
        '
        'navButtonOrden
        '
        Me.navButtonOrden.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left
        Me.navButtonOrden.Caption = "Orden :  No hay orden establecida"
        Me.navButtonOrden.Name = "navButtonOrden"
        '
        'NavButton2
        '
        Me.NavButton2.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.NavButton2.Caption = "NavButton2"
        Me.NavButton2.Name = "NavButton2"
        '
        'navButtonSettings
        '
        Me.navButtonSettings.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.navButtonSettings.Caption = Nothing
        Me.navButtonSettings.Glyph = CType(resources.GetObject("navButtonSettings.Glyph"), System.Drawing.Image)
        Me.navButtonSettings.Name = "navButtonSettings"
        '
        'navButtonHelp
        '
        Me.navButtonHelp.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.navButtonHelp.Caption = Nothing
        Me.navButtonHelp.Glyph = CType(resources.GetObject("navButtonHelp.Glyph"), System.Drawing.Image)
        Me.navButtonHelp.Name = "navButtonHelp"
        '
        'navButtonClose
        '
        Me.navButtonClose.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
        Me.navButtonClose.Caption = Nothing
        Me.navButtonClose.Glyph = CType(resources.GetObject("navButtonClose.Glyph"), System.Drawing.Image)
        Me.navButtonClose.Name = "navButtonClose"
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TileBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TileBar1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.Location = New System.Drawing.Point(0, 44)
        Me.TileBar1.MaxId = 5
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.ShowGroupText = False
        Me.TileBar1.Size = New System.Drawing.Size(1585, 88)
        Me.TileBar1.TabIndex = 1
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.Ordenes)
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'Ordenes
        '
        Me.Ordenes.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Ordenes.AppearanceItem.Normal.Options.UseBackColor = True
        Me.Ordenes.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        TileItemElement5.Appearance.Normal.Options.UseBackColor = True
        TileItemElement5.Image = CType(resources.GetObject("TileItemElement5.Image"), System.Drawing.Image)
        TileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement5.Text = "Ordenes"
        Me.Ordenes.Elements.Add(TileItemElement5)
        Me.Ordenes.Id = 2
        Me.Ordenes.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.Ordenes.Name = "Ordenes"
        ToolTipTitleItem3.Text = "Cargar Ordenes de trabajo"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Pulse aqui para cargar las ordenes de trabajo disponibles para el proceso de prod" & _
    "ucción"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.Ordenes.SuperTip = SuperToolTip3
        '
        'TileBarItem1
        '
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement6.Text = "TileBarItem1"
        Me.TileBarItem1.Elements.Add(TileItemElement6)
        Me.TileBarItem1.Id = 4
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 138)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1585, 533)
        Me.PanelControl1.TabIndex = 2
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 826)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.TileBar1)
        Me.Controls.Add(Me.TileNavPane1)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents navButtonSettings As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonHome As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonClose As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonHelp As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents Ordenes As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents navButtonOrden As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
End Class
