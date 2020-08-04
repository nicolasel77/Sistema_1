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
End Class
