﻿Public Class ucFecha
    Public Event Cambio_Fecha()


    Private Sub mntFecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mntFecha.DateChanged
        lblSeleccion.Text = "Fecha: " & mntFecha.SelectionRange.Start.ToString("dd/MM/yy")
        If chDevolver.Checked Then RaiseEvent Cambio_Fecha()
    End Sub

    Public Function Devolver_Cadena() As String
        Dim vFiltro As String = ""

        If chDevolver.Checked Then
            Select Case tabSeleccion.SelectedIndex
                Case 0 ' Fecha
                    vFiltro = $"Fecha=#{mntFecha.SelectionRange.Start:MM/dd/yy}#"
                Case 1 ' Semana
                    If lstSemanas.SelectedIndex > -1 Then
                        vFiltro = $"Fecha BETWEEN #{CDate(lstSemanas.Text):MM/dd/yy}# AND #{CDate(lstSemanas.Text).AddDays(6):MM/dd/yy}#"
                    End If
                Case 2 ' Mes
                    If lstMes.SelectedIndex > -1 Then
                        Dim vAño As String = Today.Year.ToString
                        If lstAñoMes.SelectedIndex > -1 Then vAño = lstAñoMes.Text

                        Dim vMes As Date = CDate($"1/{lstMes.SelectedIndex + 1}/{vAño}")

                        vFiltro = $"Fecha BETWEEN #{vMes:MM/dd/yyyy}# AND #{vMes.AddMonths(1).AddDays(-1):MM/dd/yy}#"
                    End If
                Case 3 ' Año

                Case 4 ' Desde-Hasta

            End Select
        End If
        Return vFiltro
    End Function

    Private Sub chDevolver_CheckedChanged(sender As Object, e As EventArgs) Handles chDevolver.CheckedChanged
        RaiseEvent Cambio_Fecha()
    End Sub

    Private Sub ucFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vSemana As Date = Today.Date.AddDays((Today.Date.DayOfWeek + 1) * -1)
        For i As Integer = 1 To 100
            lstSemanas.Items.Add(vSemana.ToString("dd/MM/yyyy"))
            vSemana = vSemana.AddDays(-7)
        Next

        vSemana = Today.Date
        For i As Integer = 1 To 5
            lstAñoMes.Items.Add(vSemana.ToString("yyyy"))
            lstAño.Items.Add(vSemana.ToString("yyyy"))
            vSemana = vSemana.AddYears(-1)
        Next
    End Sub

    Private Sub lstSemanas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemanas.SelectedIndexChanged, lstMes.SelectedIndexChanged
        RaiseEvent Cambio_Fecha()
    End Sub
End Class
