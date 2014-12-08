Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors

Public Class Loteado
    Public miLote As String
    Dim udesEscandallo As Decimal
    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub
    Public Sub loadData()

        Me.MateriasPrimasTableAdapter.Fill(ProduccionSql.MateriasPrimas, gCodEmpresa, gEjercicio, idArticulo)
        Me.PL_LOTESAUXILIARESTableAdapter.Fill(ProduccionSql.PL_LOTESAUXILIARES, gCodEmpresa, gEjercicio, idCabecera)
        Me.LotesMPADisponiblesTableAdapter.Fill(ProduccionSql.LotesMPADisponibles)
        Dim gle As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
        gle.DataSource = ProduccionSql.LotesMPADisponibles
        gle.ValueMember = "ID"
        gle.DisplayMember = "ReferenciaLinea"
        gle.BestFitMode = BestFitMode.BestFit
        gle.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        ' gle.TextEditStyle = TextEditStyles.Standard
        Dim coll As LookUpColumnInfoCollection
        coll = gle.Columns
        coll.Add(New LookUpColumnInfo("ReferenciaLinea", "Lote", 150))
        coll.Add(New LookUpColumnInfo("Diferencia", "Disponible", 70))
        coll.Add(New LookUpColumnInfo("FECHA"))
        coll.Add(New LookUpColumnInfo("CodigoAlbaran", "Albaran"))
        GridView2.Columns("ID_LINCOMPRALOTE").ColumnEdit = gle

        


        Dim gle1 As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
        gle1.DataSource = ProduccionSql.MateriasPrimas
        gle1.ValueMember = "Id"
        gle1.DisplayMember = "DESCRIPCION"
        gle1.BestFitMode = BestFitMode.BestFit
        gle1.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.True
        gle1.TextEditStyle = TextEditStyles.Standard
        coll = New LookUpColumnInfoCollection
        coll = gle1.Columns
        coll.Add(New LookUpColumnInfo("DESCRIPCION", "Descripcion"))
        coll.Add(New LookUpColumnInfo("UNIDADES", "Unidades"))

        GridView2.Columns("idmateriaprima").ColumnEdit = gle1
        AddHandler gle1.EditValueChanged, AddressOf OnchangeMateriaPrima
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
    Private Sub OnchangeMateriaPrima(sender As Object, e As EventArgs)
        Dim miLookUp As LookUpEdit = TryCast(sender, LookUpEdit)
        Dim view As GridView = TryCast(GridView2, GridView)

        '    Dim f As New FormBuscarLote
        udesEscandallo = miLookUp.GetColumnValue("UNIDADES")


        '    f.codigoMateria = clsNegocioProd.GetDatoTabla(row("idmateriaprima"), "MATERIASPRIMAS", gCodEmpresa, gEjercicio, "CODIGO", "ID", True)
        '    f.ShowDialog()

        view.SetRowCellValue(view.FocusedRowHandle, view.Columns("Producido"), udesEscandallo)
    End Sub

    
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        grabar()
    End Sub

    Private Sub grabar()
        Try
            If idCabecera <> 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("UPDATE PL_CABECERAPRODUCIDA SET PALESPRODUCIDODS=" & clsNegocioNet.qc(txtPales.EditValue) & ",CAJASPRODUCIDAS=" & clsNegocioNet.qc(txtCajas.EditValue) & " WHERE ID=" & idCabecera, dbProd)
                cmd.ExecuteNonQuery()
            End If
        Catch ex As OleDbException
            If ex.ErrorCode = -2146232060 Then
                MsgBox("La accion que intenta añadir ya existe")
            Else
                MsgBox(ex.Message)
            End If


        End Try
        miLote = TextEdit1.Text
        'btEnvasar.Enabled = True
        'btbtRoturas.Enabled = True
        'btEtiquetas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub GridView2_CustomUnboundColumnData(sender As Object, e As Base.CustomColumnDataEventArgs) Handles GridView2.CustomUnboundColumnData
        Dim view As GridView = TryCast(sender, GridView)
        If e.Column.FieldName = "Producido" Then

            If Not view.IsEditing Then
                Dim myLookup As RepositoryItemLookUpEdit = TryCast(view.Columns("idmateriaprima").ColumnEdit, RepositoryItemLookUpEdit)

                Dim row As DataRowView = myLookup.GetDataSourceRowByKeyValue(e.Row("idmateriaprima"))
                If IsDBNull(e.Row("idmateriaprima")) Then
                    udesEscandallo = 0
                Else
                    udesEscandallo = row.Row("UNIDADES")
                End If
            End If
            e.Value = getTotalValue()

        End If

    End Sub
    Private Function getTotalValue() As Decimal
        Dim udesCja As Double
        Dim cjaspalet As Double
        udesCja = clsNegocioNet.GetDatoTabla(idArticulo, "ARTICULOS", gCodEmpresa, gEjercicio, "UDES_CAJA", "ID")
        cjaspalet = clsNegocioProd.GetDatoTabla(miLinea, "PL_PARTESPRODUCCION", gCodEmpresa, gEjercicio, "CANTIDAD", "ID")
        Dim TotalUdes As Double = udesCja * cjaspalet * txtPales.EditValue
        TotalUdes = TotalUdes + (udesCja * txtCajas.EditValue)
        Return Math.Round(udesEscandallo * TotalUdes, 0)
    End Function
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

        ElseIf view.FocusedColumn.FieldName = "idmateriaprima" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "[CODIGO] <>'01'"

            edit.Properties.DataSource = clone



        End If
    End Sub

End Class
