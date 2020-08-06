Public Class frmStock
    Private clStock As New clsStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}
        grdStock.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fFecha As String = ""
        Dim fNombre As String = ""

        If txtBuscador.Text.Length Then
            fNombre = txtBuscador.Text
            If IsNumeric(txtBuscador.Text) Then
                fId = CInt(txtBuscador.Text)
            End If
        End If

        Dim dt As DataTable = clStock.Datos(fId, fFecha, fId, fNombre)

        With grdStock
            .MostrarDatos(dt, True)

            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))

        With grdStock
            Select Case c
                Case .ColIndex("Fecha")
                    .Texto(f, c) = a
                    .ActivarCelda(f, .ColIndex("Id_Producto"))

                Case .ColIndex("Id_Producto")
                    Dim vNombre As String = clStock.Nombre_Producto(a)
                    If vNombre.Length Then
                        .Texto(f, c) = a
                        .Texto(f, .ColIndex("Nombre")) = vNombre
                        .ActivarCelda(f, .ColIndex("Cantidad"))
                    Else
                        .ErrorEnTxt()
                    End If

                Case .ColIndex("Cantidad")
                    'Para hacer:
                    ' Validar fecha y producto

                    .Texto(f, c) = a
                    If vId <> 0 Then
                        'clStock.Editar("j")
                    Else
                        'clStock.Agregar("j")

                        'Escribir el Id de la nueva fila en la columna Id
                        .AgregarFila()
                    End If
                    .ActivarCelda(f + 1, .ColIndex("Fecha"))
            End Select
        End With

    End Sub

    Private Sub grdStock_KeyUp(sender As Object, e As Short) Handles grdStock.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdStock.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el producto {grdStock.Texto(, 0)}. {grdStock.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clStock.Borrar(grdStock.Texto(, 0))
                        grdStock.BorrarFila()
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select

    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        Cargar_LST()
    End Sub
End Class