Public Class ucFecha
    Private Sub tiHora_Tick(sender As Object, e As EventArgs) Handles tiHora.Tick
        lblFecha.Text = Date.Today.Date.ToShortDateString
        lblHora.Text = Now.ToLongTimeString
    End Sub
End Class
