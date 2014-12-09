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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.TileNavPane1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.navButtonHome = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonOrden = New DevExpress.XtraBars.Navigation.NavButton()
        Me.NavButton2 = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonSettings = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonHelp = New DevExpress.XtraBars.Navigation.NavButton()
        Me.navButtonClose = New DevExpress.XtraBars.Navigation.NavButton()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.BuscarOrdenes = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.Envasar = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.btRoturas = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarGroup3 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.Etiquetas = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarGroup4 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.cmbTurno = New DevExpress.XtraEditors.LookUpEdit()
        Me.PLTURNOSBindingSource = New System.Windows.Forms.BindingSource()
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.cmbOperarios = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.OPERARIOSBindingSource = New System.Windows.Forms.BindingSource()
        Me.PL_TURNOSTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_TURNOSTableAdapter()
        Me.OPERARIOSTableAdapter = New GesLineas.ProduccionSqlTableAdapters.OPERARIOSTableAdapter()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OPERARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TileNavPane1.Size = New System.Drawing.Size(1362, 38)
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
        Me.TileBar1.Groups.Add(Me.TileBarGroup3)
        Me.TileBar1.Groups.Add(Me.TileBarGroup4)
        Me.TileBar1.Location = New System.Drawing.Point(0, 44)
        Me.TileBar1.MaxId = 7
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.ShowGroupText = False
        Me.TileBar1.Size = New System.Drawing.Size(1362, 88)
        Me.TileBar1.TabIndex = 1
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.BuscarOrdenes)
        Me.TileBarGroup2.Items.Add(Me.Envasar)
        Me.TileBarGroup2.Items.Add(Me.btRoturas)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'BuscarOrdenes
        '
        Me.BuscarOrdenes.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuscarOrdenes.AppearanceItem.Normal.Options.UseBackColor = True
        Me.BuscarOrdenes.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        TileItemElement1.Appearance.Normal.Options.UseBackColor = True
        TileItemElement1.Image = CType(resources.GetObject("TileItemElement1.Image"), System.Drawing.Image)
        TileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        TileItemElement1.Text = "Ordenes"
        Me.BuscarOrdenes.Elements.Add(TileItemElement1)
        Me.BuscarOrdenes.Id = 2
        Me.BuscarOrdenes.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.BuscarOrdenes.Name = "BuscarOrdenes"
        ToolTipTitleItem1.Text = "Cargar Ordenes de trabajo"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Pulse aqui para cargar las ordenes de trabajo disponibles para el proceso de prod" & _
    "ucción"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.BuscarOrdenes.SuperTip = SuperToolTip1
        '
        'Envasar
        '
        Me.Envasar.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Envasar.AppearanceItem.Normal.Options.UseBackColor = True
        Me.Envasar.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = CType(resources.GetObject("TileItemElement2.Image"), System.Drawing.Image)
        TileItemElement2.Text = "Envasar"
        Me.Envasar.Elements.Add(TileItemElement2)
        Me.Envasar.Id = 4
        Me.Envasar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.Envasar.Name = "Envasar"
        '
        'btRoturas
        '
        Me.btRoturas.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red
        Me.btRoturas.AppearanceItem.Normal.Options.UseBackColor = True
        Me.btRoturas.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.Text = "Roturas"
        Me.btRoturas.Elements.Add(TileItemElement3)
        Me.btRoturas.Id = 5
        Me.btRoturas.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.btRoturas.Name = "btRoturas"
        ToolTipTitleItem2.Text = "Roturas/Defectos"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Informa de las roturas/defectos encontrados en el proceso de envasado"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btRoturas.SuperTip = SuperToolTip2
        '
        'TileBarGroup3
        '
        Me.TileBarGroup3.Items.Add(Me.Etiquetas)
        Me.TileBarGroup3.Name = "TileBarGroup3"
        '
        'Etiquetas
        '
        Me.Etiquetas.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Image = CType(resources.GetObject("TileItemElement4.Image"), System.Drawing.Image)
        TileItemElement4.Text = "Generar Etiqueta"
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.Etiquetas.Elements.Add(TileItemElement4)
        Me.Etiquetas.Id = 6
        Me.Etiquetas.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.Etiquetas.Name = "Etiquetas"
        ToolTipTitleItem3.Text = "Generar Etiqueta"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Genera Etiqueta palet producido"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.Etiquetas.SuperTip = SuperToolTip3
        '
        'TileBarGroup4
        '
        Me.TileBarGroup4.Name = "TileBarGroup4"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 138)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1362, 602)
        Me.PanelControl1.TabIndex = 2
        '
        'cmbTurno
        '
        Me.cmbTurno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTurno.CausesValidation = False
        Me.cmbTurno.Location = New System.Drawing.Point(856, 76)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTurno.Properties.Appearance.Options.UseFont = True
        Me.cmbTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTurno.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Turno")})
        Me.cmbTurno.Properties.DataSource = Me.PLTURNOSBindingSource
        Me.cmbTurno.Properties.DisplayMember = "DESCRIPCION"
        Me.cmbTurno.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbTurno.Properties.ValueMember = "ID"
        Me.cmbTurno.Size = New System.Drawing.Size(193, 42)
        Me.cmbTurno.TabIndex = 3
        '
        'PLTURNOSBindingSource
        '
        Me.PLTURNOSBindingSource.DataMember = "PL_TURNOS"
        Me.PLTURNOSBindingSource.DataSource = Me.ProduccionSql
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbOperarios
        '
        Me.cmbOperarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOperarios.CausesValidation = False
        Me.cmbOperarios.EditValue = ""
        Me.cmbOperarios.Location = New System.Drawing.Point(1055, 76)
        Me.cmbOperarios.Name = "cmbOperarios"
        Me.cmbOperarios.Properties.AllowMultiSelect = True
        Me.cmbOperarios.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperarios.Properties.Appearance.Options.UseFont = True
        Me.cmbOperarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperarios.Properties.DataSource = Me.OPERARIOSBindingSource
        Me.cmbOperarios.Properties.DisplayMember = "NOMBRE"
        Me.cmbOperarios.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbOperarios.Properties.ValueMember = "ID"
        Me.cmbOperarios.Size = New System.Drawing.Size(295, 48)
        Me.cmbOperarios.TabIndex = 5
        '
        'OPERARIOSBindingSource
        '
        Me.OPERARIOSBindingSource.DataMember = "OPERARIOS"
        Me.OPERARIOSBindingSource.DataSource = Me.ProduccionSql
        '
        'PL_TURNOSTableAdapter
        '
        Me.PL_TURNOSTableAdapter.ClearBeforeFill = True
        '
        'OPERARIOSTableAdapter
        '
        Me.OPERARIOSTableAdapter.ClearBeforeFill = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(856, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 20)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Turno"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(1055, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 20)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Operarios"
        '
        'Timer1
        '
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 742)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmbOperarios)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.TileBar1)
        Me.Controls.Add(Me.TileNavPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "Captura de datos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPERARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TileNavPane1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents navButtonSettings As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonHome As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonClose As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents navButtonHelp As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents BuscarOrdenes As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents navButtonOrden As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents NavButton2 As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Envasar As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents btRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents cmbTurno As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbOperarios As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents PLTURNOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents OPERARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PL_TURNOSTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_TURNOSTableAdapter
    Friend WithEvents OPERARIOSTableAdapter As GesLineas.ProduccionSqlTableAdapters.OPERARIOSTableAdapter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TileBarGroup3 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents Etiquetas As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarGroup4 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
