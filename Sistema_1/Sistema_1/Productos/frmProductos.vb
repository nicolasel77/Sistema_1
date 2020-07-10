Public Class frmProductos
    Dim prod As New clsProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = prod.Datos

        For Each dr As DataRow In dt.Rows
            lstProductos.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        prod.Borrar()
    End Sub

    Private Sub lstProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductos.SelectedIndexChanged
        prod.Id = Codigo_Seleccionado(lstProductos.Text)
    End Sub
End Class