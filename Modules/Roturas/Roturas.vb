Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid

Public Class Roturas

    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
    Public btbtRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Public btEtiquetas As DevExpress.XtraBars.Navigation.TileBarItem
    Public fin As Boolean = False



    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()


    End Sub
    Public Sub loadData()
        Me.PL_ROTURASTableAdapter.Fill(ProduccionSql.PL_ROTURAS, idCabecera, gCodEmpresa, gEjercicio)
        Me.MateriasPrimasTableAdapter.Fill(ProduccionSql.MateriasPrimas, gCodEmpresa, gEjercicio, idArticulo)
        Me.PL_LOTESAUXILIARESTableAdapter.Fill(ProduccionSql.PL_LOTESAUXILIARES, gCodEmpresa, gEjercicio, idCabecera)
        Me.LotesMPADisponiblesTableAdapter.Fill(ProduccionSql.LotesMPADisponibles)
        Dim gle As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
        gle.DataSource = ProduccionSql.LotesMPADisponibles
        gle.ValueMember = "ID"
        gle.DisplayMember = "ReferenciaLinea"
        gle.BestFitMode = BestFitMode.BestFit
        gle.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        gle.TextEditStyle = TextEditStyles.Standard
        Dim coll As LookUpColumnInfoCollection
        coll = gle.Columns
        coll.Add(New LookUpColumnInfo("ReferenciaLinea", "Lote", 150))
        coll.Add(New LookUpColumnInfo("Diferencia", "Disponible", 70))
        coll.Add(New LookUpColumnInfo("FECHA"))
        coll.Add(New LookUpColumnInfo("CodigoAlbaran", "Albaran"))
        GridView2.Columns("ID_LINCOMPRALOTE").ColumnEdit = gle
        GridView1.Columns("ID_LINCOMPRALOTE").ColumnEdit = gle
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        If idCabecera <> 0 Then
            txtCajas.Enabled = True
            txtPales.Enabled = True
            cmd = New OleDbCommand("Select palesproducidoDs,cajasproducidas from pl_cabeceraproducida where id=" & idCabecera, dbProd)
            dr = cmd.ExecuteReader
            dr.Read()
            txtCajas.EditValue = dr(1)
            txtPales.EditValue = dr(0)
        Else
            txtCajas.Enabled = False
            txtPales.Enabled = False
        End If
    End Sub


    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, Grid.GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("IDCABECERA"), idCabecera)
        view.SetRowCellValue(e.RowHandle, view.Columns("CODEMPRESA"), gCodEmpresa)
        view.SetRowCellValue(e.RowHandle, view.Columns("EJERCICIO"), gEjercicio)
    End Sub
    Private Sub grabar()
        Try
            Me.PL_ROTURASTableAdapter.Update(Me.ProduccionSql.PL_ROTURAS)
            Me.PL_LOTESAUXILIARESTableAdapter.Update(Me.ProduccionSql.PL_LOTESAUXILIARES)
            If idCabecera <> 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE PL_CABECERAPRODUCIDA SET PALESPRODUCIDODS=" & clsNegocioNet.qc(txtPales.EditValue) & ",CAJASPRODUCIDAS=" & clsNegocioNet.qc(txtCajas.EditValue) & " WHERE ID=" & idCabecera, dbProd)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As SqlException
            If ex.ErrorCode = -2146232060 Then
                MsgBox("La accion que intenta añadir ya existe")
            Else
                MsgBox(ex.Message)
            End If


        End Try
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        btEtiquetas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        grabar()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        btEtiquetas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles GridView2.InitNewRow
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, Grid.GridView)
        view.SetRowCellValue(e.RowHandle, view.Columns("idcabecera"), idCabecera)
        view.SetRowCellValue(e.RowHandle, view.Columns("CODEMPRESA"), gCodEmpresa)
        view.SetRowCellValue(e.RowHandle, view.Columns("EJERCICIO"), gEjercicio)
    End Sub

   
    Private clone As DataView
    Private Sub GridView2_ShownEditor(sender As Object, e As EventArgs) Handles GridView2.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        Dim CodigoMateria As String
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If view.FocusedColumn.FieldName = "ID_LINCOMPRALOTE" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)

            CodigoMateria = clsNegocioProd.GetDatoTabla(row("idmateriaprima"), "MATERIASPRIMAS", gCodEmpresa, gEjercicio, "CODIGO", "ID", True)

            clone.RowFilter = "[CODIGO] = " + CodigoMateria.ToString

            edit.Properties.DataSource = clone


            'Dim edit As DevExpress.XtraEditors.LookUpEdit
            'edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            '' Dim bs As BindingSource = CType(edit.Properties.DataSource, BindingSource)
            '' Dim table As DataTable = (CType(bs.DataSource, DataSet)).Tables(bs.DataMember)
            'Dim Table As DataTable = CType(edit.Properties.DataSource, DataTable)
            'clone = New DataView(Table)
            'Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
            'clone.RowFilter = "[IdLinea] = " & row("IdLinea").ToString()
            'edit.Properties.DataSource = clone
            'edit.ItemIndex = 0

        End If
    End Sub

    'Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
    '    Dim view As GridView = TryCast(GridView2, GridView)
    '    Dim f As New FormBuscarLote
    '    Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
    '    f.codigoMateria = clsNegocioProd.GetDatoTabla(row("idmateriaprima"), "MATERIASPRIMAS", gCodEmpresa, gEjercicio, "CODIGO", "ID", True)
    '    f.ShowDialog()
    '    view.SetRowCellValue(view.FocusedRowHandle, view.Columns("ID_"), f.lote)
    'End Sub

    'Private Sub RepositoryItemButtonEdit2_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles RepositoryItemButtonEdit2.ButtonClick
    '    Dim view As GridView = TryCast(GridView1, GridView)
    '    Dim f As New FormBuscarLote
    '    Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
    '    f.codigoMateria = clsNegocioProd.GetDatoTabla(row("idmateriaprima"), "MATERIASPRIMAS", gCodEmpresa, gEjercicio, "CODIGO", "ID", True)
    '    f.ShowDialog()
    '    view.SetRowCellValue(view.FocusedRowHandle, view.Columns("LOTE"), f.lote)
    'End Sub

    Private Sub GridView1_ShownEditor(sender As Object, e As EventArgs) Handles GridView1.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        Dim CodigoMateria As String
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If view.FocusedColumn.FieldName = "ID_LINCOMPRALOTE" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)

            CodigoMateria = clsNegocioProd.GetDatoTabla(row("idmateriaprima"), "MATERIASPRIMAS", gCodEmpresa, gEjercicio, "CODIGO", "ID", True)

            clone.RowFilter = "[CODIGO] = " + CodigoMateria.ToString

            edit.Properties.DataSource = clone


            'Dim edit As DevExpress.XtraEditors.LookUpEdit
            'edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            '' Dim bs As BindingSource = CType(edit.Properties.DataSource, BindingSource)
            '' Dim table As DataTable = (CType(bs.DataSource, DataSet)).Tables(bs.DataMember)
            'Dim Table As DataTable = CType(edit.Properties.DataSource, DataTable)
            'clone = New DataView(Table)
            'Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
            'clone.RowFilter = "[IdLinea] = " & row("IdLinea").ToString()
            'edit.Properties.DataSource = clone
            'edit.ItemIndex = 0

        End If
    End Sub
End Class
