﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Roturas = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.cmbTurno = New DevExpress.XtraEditors.LookUpEdit()
        Me.cmbOperario = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cmbOperarios = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ProduccionSql = New GesLineas.ProduccionSql()
        Me.PLTURNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PL_TURNOSTableAdapter = New GesLineas.ProduccionSqlTableAdapters.PL_TURNOSTableAdapter()
        Me.OPERARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OPERARIOSTableAdapter = New GesLineas.ProduccionSqlTableAdapters.OPERARIOSTableAdapter()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTurno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOperarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLTURNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TileBar1.MaxId = 6
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.ShowGroupText = False
        Me.TileBar1.Size = New System.Drawing.Size(1585, 88)
        Me.TileBar1.TabIndex = 1
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.BuscarOrdenes)
        Me.TileBarGroup2.Items.Add(Me.Envasar)
        Me.TileBarGroup2.Items.Add(Me.Roturas)
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
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 138)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1585, 686)
        Me.PanelControl1.TabIndex = 2
        '
        'Roturas
        '
        Me.Roturas.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red
        Me.Roturas.AppearanceItem.Normal.Options.UseBackColor = True
        Me.Roturas.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Image = CType(resources.GetObject("TileItemElement3.Image"), System.Drawing.Image)
        TileItemElement3.Text = "Roturas"
        Me.Roturas.Elements.Add(TileItemElement3)
        Me.Roturas.Id = 5
        Me.Roturas.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
        Me.Roturas.Name = "Roturas"
        ToolTipTitleItem2.Text = "Roturas/Defectos"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Informa de las roturas/defectos encontrados en el proceso de envasado"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.Roturas.SuperTip = SuperToolTip2
        '
        'cmbTurno
        '
        Me.cmbTurno.Location = New System.Drawing.Point(866, 76)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTurno.Properties.Appearance.Options.UseFont = True
        Me.cmbTurno.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTurno.Properties.DataSource = Me.PLTURNOSBindingSource
        Me.cmbTurno.Properties.DisplayMember = "ID"
        Me.cmbTurno.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbTurno.Properties.ValueMember = "DESCRIPCION"
        Me.cmbTurno.Size = New System.Drawing.Size(193, 42)
        Me.cmbTurno.TabIndex = 3
        '
        'cmbOperario
        '
        Me.cmbOperario.Location = New System.Drawing.Point(1240, 76)
        Me.cmbOperario.Name = "cmbOperario"
        Me.cmbOperario.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperario.Properties.Appearance.Options.UseFont = True
        Me.cmbOperario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperario.Properties.NullText = "[Vacío]"
        Me.cmbOperario.Size = New System.Drawing.Size(100, 26)
        Me.cmbOperario.TabIndex = 4
        '
        'cmbOperarios
        '
        Me.cmbOperarios.Location = New System.Drawing.Point(1098, 76)
        Me.cmbOperarios.Name = "cmbOperarios"
        Me.cmbOperarios.Properties.AllowMultiSelect = True
        Me.cmbOperarios.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperarios.Properties.Appearance.Options.UseFont = True
        Me.cmbOperarios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbOperarios.Properties.DataSource = Me.OPERARIOSBindingSource
        Me.cmbOperarios.Properties.DisplayMember = "ID"
        Me.cmbOperarios.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[True]
        Me.cmbOperarios.Properties.ValueMember = "NOMBRE"
        Me.cmbOperarios.Size = New System.Drawing.Size(194, 42)
        Me.cmbOperarios.TabIndex = 5
        '
        'ProduccionSql
        '
        Me.ProduccionSql.DataSetName = "ProduccionSql"
        Me.ProduccionSql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PLTURNOSBindingSource
        '
        Me.PLTURNOSBindingSource.DataMember = "PL_TURNOS"
        Me.PLTURNOSBindingSource.DataSource = Me.ProduccionSql
        '
        'PL_TURNOSTableAdapter
        '
        Me.PL_TURNOSTableAdapter.ClearBeforeFill = True
        '
        'OPERARIOSBindingSource
        '
        Me.OPERARIOSBindingSource.DataMember = "OPERARIOS"
        Me.OPERARIOSBindingSource.DataSource = Me.ProduccionSql
        '
        'OPERARIOSTableAdapter
        '
        Me.OPERARIOSTableAdapter.ClearBeforeFill = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1585, 826)
        Me.Controls.Add(Me.cmbOperarios)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.TileBar1)
        Me.Controls.Add(Me.TileNavPane1)
        Me.Controls.Add(Me.cmbOperario)
        Me.Name = "FormMain"
        Me.Text = "FormMain"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTurno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOperarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionSql, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLTURNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OPERARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents Roturas As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents cmbTurno As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbOperario As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cmbOperarios As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents PLTURNOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProduccionSql As GesLineas.ProduccionSql
    Friend WithEvents OPERARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PL_TURNOSTableAdapter As GesLineas.ProduccionSqlTableAdapters.PL_TURNOSTableAdapter
    Friend WithEvents OPERARIOSTableAdapter As GesLineas.ProduccionSqlTableAdapters.OPERARIOSTableAdapter
End Class
