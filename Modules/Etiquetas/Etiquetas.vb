Imports System.Data.OleDb

Public Class Etiquetas
    Public btEnvasar As DevExpress.XtraBars.Navigation.TileBarItem
    Public btbtRoturas As DevExpress.XtraBars.Navigation.TileBarItem
    Private Sub Etiquetas_Load(sender As Object, e As EventArgs) Handles Me.Load
       

    End Sub
    Public Sub loaddata()
        Me.PalesPendientesTicarTableAdapter.Fill(Me.ProduccionSql.PalesPendientesTicar, gCodEmpresa, gEjercicio, miLinea)
        Me.ARTICULOSTableAdapter.Fill(Me.DatosDataset.ARTICULOS, gCodEmpresa, gEjercicio)
        Me.TANQUESTableAdapter.Fill(Me.ProduccionSql.TANQUES, gCodEmpresa, gEjercicio)
    End Sub
    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim rowHandle As Integer = GetRowHandleByColumnValue(miPrincipal.GridView2, "id", miLinea, miPrincipal.GridControl2)
        ' Dim Col As DevExpress.XtraGrid.Columns.GridColumn = miPrincipal.GridView2.Columns("id")
        ' Dim rowhandle As Integer = miPrincipal.GridView2.LocateByValue(miLinea, Col, "id")
        Dim MITANQUE As Integer = miPrincipal.GridView2.GetRowCellValue(rowHandle, miPrincipal.GridView2.Columns("TANQUE"))
        Dim MIfecha As Date = miPrincipal.GridView2.GetRowCellValue(rowHandle, miPrincipal.GridView2.Columns("FechaConsumoPreferente"))
        Dim MILote As String = miPrincipal.GridView2.GetRowCellValue(rowHandle, miPrincipal.GridView2.Columns("LOTE"))
        ' primero comprobamos que todo esta correcto
        Dim cmd As New OleDbCommand
        Dim idEtiqueta As Integer
        Dim contador As String
        Dim misOperarios() As String = FormMain.cmbOperarios.EditValue.ToString.Split(",")
        Dim i As Integer
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
End Class
