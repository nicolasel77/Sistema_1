Public Class frmProductos
    Private clProd As New clsProductos
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim dt As DataTable = clProd.Datos()

        With lstProductos
            .Items.Clear()

            For Each dr As DataRow In dt.Rows
                .Items.Add(dr.Item("Id") & ". " & dr.Item("Nombre"))
            Next
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lstProductos.Text.Length Then
            Dim i As Integer = Codigo_Seleccionado(lstProductos.Text)

            clProd.Borrar(i)
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstProductos.Text.Length And txtEdicion.Text.Length Then
            Dim i As Integer = Codigo_Seleccionado(lstProductos.Text)

            clProd.Editar(i, txtEdicion.Text)
            lstProductos.Items.Insert(lstProductos.SelectedIndex, $"{i}. {txtEdicion.Text}")
            lstProductos.Items.RemoveAt(lstProductos.SelectedIndex)
        End If
    End Sub

    Private Sub cmdAgregar_Click(sender As Object, e As EventArgs) Handles cmdAgregar.Click
        If txtEdicion.Text.Length Then
            clProd.Agregar(txtEdicion.Text)
            Cargar_LST()
        End If
    End Sub
End Class