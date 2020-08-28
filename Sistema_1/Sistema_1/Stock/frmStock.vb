Public Class frmStock
    Private clStock As New clsStock
    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}
        grdStock.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST(Optional fFecha As String = "")
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        'If txtBuscador.Text.Length Then
        '    fNombre = txtBuscador.Text
        '    If IsNumeric(txtBuscador.Text) Then
        '        fId = CInt(txtBuscador.Text)
        '    End If
        'End If

        Dim dt As DataTable = clStock.Datos(fId, fFecha, fId, fNombre)

        With grdStock
            .MostrarDatos(dt, True)

            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1

            Totales()
        End With
    End Sub

    Private Sub Totales()
        With grdStock
            Dim vCant As Integer
            For i As Integer = 1 To .Rows - 2
                vCant = vCant + .Texto(i, .ColIndex("Cantidad"))
            Next
            lblRegistros.Text = "Registros: " & .Rows - 2 & " Cantidad: " & vCant
        End With
    End Sub

    Private Sub grdStock_Editado(f As Short, c As Short, a As Object) Handles grdStock.Editado
        Dim vId As Integer = grdStock.Texto(f, grdStock.ColIndex("Id"))
        Dim vFecha As Date = grdStock.Texto(f, grdStock.ColIndex("Fecha"))
        Dim vProd As Integer = grdStock.Texto(f, grdStock.ColIndex("Id_Producto"))
        Dim vCant As Integer = grdStock.Texto(f, grdStock.ColIndex("Cantidad"))

        With grdStock
            Select Case c
                Case .ColIndex("Fecha")
                    .Texto(f, c) = a
                    If vId Then clStock.Editar(vId, a, vProd, vCant)
                    .ActivarCelda(f, .ColIndex("Id_Producto"))

                Case .ColIndex("Id_Producto")
                    Dim vNombre As String = clStock.Nombre_Producto(a)
                    If vNombre.Length Then
                        .Texto(f, c) = a
                        .Texto(f, .ColIndex("Nombre")) = vNombre
                        If vId Then clStock.Editar(vId, vFecha, a, vCant)
                        .ActivarCelda(f, .ColIndex("Cantidad"))
                    Else
                        .ErrorEnTxt()
                    End If

                Case .ColIndex("Cantidad")
                    If vId = 0 Then
                        'Es nuevo
                        If vFecha > #1/1/2010# Then
                            If vProd <> 0 Then
                                'Es valido, agregar

                                'clStock.Agregar()

                                .Texto(f, c) = a
                                .Texto(f, .ColIndex("Id")) = clStock.Maximo_Id
                                .AgregarFila()
                                lblRegistros.Text = "Registros: " & .Rows - 2

                                .ActivarCelda(f + 1, .ColIndex("Fecha"))
                            Else
                                MsgBox("Debe ingresar un producto, culeao.")
                                .ActivarCelda(f, .ColIndex("ID_Producto"))
                            End If
                        Else
                            MsgBox("Debe ingresar una fecha válida, culeao.")
                            .ActivarCelda(f, .ColIndex("Fecha"))
                        End If
                    Else
                        'No es nuevo
                        clStock.Editar(vId, vFecha, vProd, a)
                        .ActivarCelda(f + 1, c)
                    End If
                    Totales()
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
                        lblRegistros.Text = "Registros: " & grdStock.Rows - 2
                    End If
                End If
            Case 32
                'Barra Espaciadora
        End Select

    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs)
        Cargar_LST()
    End Sub

    Private Sub filtro(sender As Object, e As EventArgs) Handles cmdFiltro.Click
        Cargar_LST(ucFecha.Devolver_Cadena)
    End Sub

    Private Sub ucFecha_Cambio_Fecha() Handles ucFecha.Cambio_Fecha
        Cargar_LST(ucFecha.Devolver_Cadena)
    End Sub
End Class