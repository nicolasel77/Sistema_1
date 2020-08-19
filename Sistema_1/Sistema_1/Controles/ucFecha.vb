Public Class ucFecha
    Public Event Cambio_Fecha()


    Private Sub mntFecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mntFecha.DateChanged
        lblSeleccion.Text = "Fecha: " & mntFecha.SelectionRange.Start.ToString("dd/MM/yy")
        If chDevolver.Checked Then RaiseEvent Cambio_Fecha()
    End Sub

    Public Function Devolver_Cadena() As String
        Dim vFiltro As String = ""

        If chDevolver.Checked Then
            vFiltro = $"Fecha=#{mntFecha.SelectionRange.Start:MM/dd/yy}#"
        End If

        Return vFiltro
    End Function

    Private Sub chDevolver_CheckedChanged(sender As Object, e As EventArgs) Handles chDevolver.CheckedChanged
        RaiseEvent Cambio_Fecha()
    End Sub
End Class
