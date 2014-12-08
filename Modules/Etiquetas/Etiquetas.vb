Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils


Public Class Etiquetas
    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
    Public btbtRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Private Sub Etiquetas_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub
    Public Sub loaddata()

        Me.PalesPendientesTicarTableAdapter.Fill(Me.ProduccionSql.PalesPendientesTicar, gCodEmpresa, gEjercicio, configuracion.Linea, NroOrden)
        Me.ARTICULOSTableAdapter.Fill(Me.DatosDataset.ARTICULOS, gCodEmpresa, gEjercicio)
        Me.TANQUESTableAdapter.Fill(Me.ProduccionSql.TANQUES, gCodEmpresa, gEjercicio)
    End Sub
    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim rowHandle As Integer = GetRowHandleByColumnValue(miPrincipal.GridView2, "id", miLinea, miPrincipal.GridControl2)

        ' Dim Col As DevExpress.XtraGrid.Columns.GridColumn = miPrincipal.GridView2.Columns("id")
        ' Dim rowhandle As Integer = miPrincipal.GridView2.LocateByValue(miLinea, Col, "id")
        Dim MITANQUE As Integer = miPrincipal.GridView2.GetRowCellValue(rowHandle, miPrincipal.GridView2.Columns("TANQUE"))
        Dim MIfecha As Date = miPrincipal.GridView2.GetRowCellValue(rowHandle, miPrincipal.GridView2.Columns("FechaConsumoPreferente"))
        Dim MILote As String = miLoteGlobal

        ' primero comprobamos que todo esta correcto
        Dim cmd As New OleDbCommand

        Dim misOperarios() As String = FormMain.cmbOperarios.EditValue.ToString.Split(",")

        If idArticulo <> 0 And misOperarios(0) <> 0 And MITANQUE <> 0 And (txtPales.Text <> "0" Or txtCajas.Text <> "0") Then


            If clsNegocioProd.GeneraEtiquetaNumLote(misOperarios(0), MITANQUE, idArticulo, MIfecha, MILote, txtCajas.Text, miLinea, CInt(txtPales.Text)) = False Then
                MsgBox("Ha habido un error generando la etiqueta")
                'Else
                '    cmd = New OleDbCommand("select contador from etiqnumlote where codempresa='" & gCodEmpresa & "' and ejercicio='" & gEjercicio & "' and id=" & idEtiqueta & " and impresa<>1 ", dbProd)
                '    contador = cmd.ExecuteScalar
                '    clsNegocioProd.ImprimirEtiqueta(contador, 0, False, 0)
            End If


        Else
            MsgBox("Campos obligatorios: Tanque,Articulo y operario")
        End If
        loaddata()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        btEnvasar.Enabled = True
        btbtRoturas.Enabled = True
        Using TempBatchTransition As BatchTransition = New BatchTransition(TransitionManager1, PanelControl1)

            controencurso.Visible = False
            miPrincipal.Visible = True

            controencurso = miPrincipal
            miPrincipal.loadDataOperaciones()
        End Using
    End Sub

    Private Sub GridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView1.MouseDown
        Dim gvi As GridHitInfo = TryCast(GridView1.CalcHitInfo(e.Location), GridHitInfo)
        If gvi.InRow AndAlso (gvi.HitTest <> GridHitTest.RowDetailIndicator AndAlso gvi.HitTest <> GridHitTest.RowGroupButton) Then
            If GridView1.IsRowSelected(gvi.RowHandle) Then
                GridView1.UnselectRow(gvi.RowHandle)
            Else
                GridView1.SelectRow(gvi.RowHandle)
            End If


            DXMouseEventArgs.GetMouseArgs(e).Handled = True
        End If
    End Sub


    Private Sub GridView1_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
        Dim View As GridView = sender
        If (e.RowHandle >= 0) Then
            Dim miEstado As Double = View.GetDataRow(e.RowHandle)("IdLinProd")
            If miEstado <> 0 Then
                e.Appearance.BackColor = Color.IndianRed
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim view As GridView = TryCast(GridView1, GridView)
        For Each rowhandle In view.GetSelectedRows
            Dim row As DataRowView = view.GetRow(rowhandle)
            If row.Row("ubicacion").trim <> "0" And row.Row("ubicacion").trim <> "" Then
                clsNegocioProd.ImprimirEtiqueta(row.Row("contador"), 0, True, CInt(row.Row("ubicacion")))
            Else
                clsNegocioProd.ImprimirEtiqueta(row.Row("contador"), 0, False, 0)
            End If
        Next
        loaddata()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim actualiza As New ActualizaProd.ActualizaProd
        Dim cmd As New OleDbCommand
        actualiza.CodEmpresa = gCodEmpresa
        actualiza.Ejercicio = gEjercicio
        actualiza.ConnectionAbril = ""
        actualiza.ConnectionString = xConnectionString
        actualiza.ConnectionProd = xConnectionProd
        Dim view As GridView = TryCast(GridView1, GridView)
      
        Dim cajas As Double
        Dim udescja As Double
        Dim txtArticulo As String
        'TODO: COMPROBAR QUE DESCUENTA BIEN LOS LOTES DE LOS ARTICULOS PRODUCIDOS QUE LLEVAN MAS DE UN LOTE
        For Each rowhandle In view.GetSelectedRows

            Dim row As DataRowView = view.GetRow(rowhandle)
            If row.Row("IMPRESA") = True And row.Row("idlinprod") = 0 Then
                cmd = New OleDbCommand("SELECT IDARTICULO,IDTANQUE FROM LINEAFABRICACION WHERE IDARTICULO=" & row.Row("idarti") & " and idtanque=" & row.Row("idtanque") & " AND EJERCICIO='" & gEjercicio & "' AND CODEMPRESA='" & gCodEmpresa & "'", dbProd)
                If cmd.ExecuteNonQuery = 0 Then
                    If MsgBox("El tanque seleccionado no coincide con el que este artículo tiene asociado a través de la tabla Lineas de Fabricación. ¿Desea continuar?", vbYesNo + vbExclamation, "Proceso de Producción") = MsgBoxResult.No Then
                        Exit For
                    End If
                End If
            End If
            If CDbl(row.Row("ubicacion")) <> 0 Then
                cajas = CDbl(row.Row("ubicacion"))
            Else
                cajas = clsNegocioNet.GetDatoTabla(row.Row("idarti"), "ARTICULOS", gCodEmpresa, gEjercicio, "CAJASPALET", "ID")
            End If
            udescja = cajas * clsNegocioNet.GetDatoTabla(row.Row("idarti"), "ARTICULOS", gCodEmpresa, gEjercicio, "UDES_CAJA", "ID")
            txtArticulo = clsNegocioNet.GetDatoTabla(row.Row("idarti"), "ARTICULOS", gCodEmpresa, gEjercicio, "descripcion", "ID", True)
            actualiza.ActualizaProduccionManual(row.Row("id"), row.Row("numlote"), txtArticulo, IIf(cajas = 0, udescja, cajas), Date.Now.ToString, Date.Today)

        Next
        actualiza.dispose()
        loaddata()
    End Sub
End Class
