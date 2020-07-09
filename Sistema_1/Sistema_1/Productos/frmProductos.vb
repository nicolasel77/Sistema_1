Public Class frmProductos

    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prod As New clsProductos

        Dim dt As DataTable = prod.Datos

        For Each dr As DataRow In dt.Rows
            lstProductos.Items.Add($"{dr.Item(0)}. {dr.Item(1)}")
        Next
    End Sub
End Class