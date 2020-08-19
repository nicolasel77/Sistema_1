Public Class ucFecha


    Private Sub mntFecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mntFecha.DateChanged
        lblSeleccion.Text = "Fecha: " & mntFecha.SelectionRange.Start.ToString("dd/MM/yy")
    End Sub

    Public Function Devolver_Cadena() As String
        Dim vFiltro As String = ""

        If chDevolver.Checked Then
            vFiltro = $"Fecha=#{mntFecha.SelectionRange.Start:MM/dd/yy}#"
        End If

        Return vFiltro
    End Function
End Class
