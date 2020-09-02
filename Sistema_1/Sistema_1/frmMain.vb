Public Class frmMain
    Dim frProd As New frmProductos
    Dim frStock As New frmStock

    Private Sub mnuProductos_Click(sender As Object, e As EventArgs) Handles mnuProductos.Click
        frProd.MdiParent = Me
        frProd.Show()
        frProd.WindowState = FormWindowState.Minimized
        frProd.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        frStock.MdiParent = Me
        frStock.Show()
        frStock.WindowState = FormWindowState.Minimized
        frStock.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As String = UnirStrings("100", "101", ",")
        Dim f As String = "Fecha=10/1"
        s = UnirStrings(s, "103", ",")

        s = $"ID_Producto IN({s})"

        s = UnirStrings(s, f)
        MsgBox(s)
    End Sub
End Class
