Public Class ucProductos
    Private clProds As New clsProductos

    Private Sub ucProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Llenar_List(lstProds, "Productos")
    End Sub

    Private Sub cmdNinguno_Click(sender As Object, e As EventArgs) Handles cmdNinguno.Click
        lstProds.SelectedIndex = -1
    End Sub

    'Private Sub lstProds_MouseClick(sender As Object, e As MouseEventArgs) Handles lstProds.MouseClick
    '    Select Case e.Button
    '        Case MouseButtons.Right
    '            For i As Integer = 0 To lstProds.Items.Count - 1
    '                If lstProds.GetSelected(i) = True Then
    '                    lstProds.SetSelected(i, False)
    '                Else
    '                    lstProds.SetSelected(i, True)
    '                End If
    '            Next
    '    End Select
    'End Sub

    Private Sub lstProds_MouseUp(sender As Object, e As MouseEventArgs) Handles lstProds.MouseUp
        Select Case e.Button
            Case MouseButtons.Right
                For i As Integer = 0 To lstProds.Items.Count - 1
                    'If lstProds.GetSelected(i) = True Then
                    '    lstProds.SetSelected(i, False)
                    'Else
                    '    lstProds.SetSelected(i, True)
                    'End If
                    lstProds.SetSelected(i, Not lstProds.GetSelected(i))
                Next
        End Select
    End Sub
End Class
