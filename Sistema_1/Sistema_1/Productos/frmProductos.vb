Public Class frmProductos
    Private clProd As New clsProductos
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim vTeclas() As Integer = {46}
        grdProductos.TeclasManejadas = vTeclas

        Cargar_LST()
    End Sub

    Private Sub Cargar_LST()
        Dim fId As Integer = 0
        Dim fNombre As String = ""

        If txtBuscador.Text.Length Then
            fNombre = txtBuscador.Text
            If IsNumeric(txtBuscador.Text) Then fId = CInt(txtBuscador.Text)
        End If

        Dim dt As DataTable = clProd.Datos(fId, fNombre)

        With grdProductos
            .MostrarDatos(dt, True)
            .ColW(0) = 60
            .ColW(1) = 150
            .FixCols = 1
        End With
    End Sub

    Private Sub grdProductos_Editado(f As Short, c As Short, a As Object) Handles grdProductos.Editado
        Dim vId As Integer = grdProductos.Texto(f, grdProductos.ColIndex("Id"))

        If grdProductos.EsUltimaF Then
            clProd.Agregar(a)
            grdProductos.Texto(f, grdProductos.ColIndex("Id")) = clProd.Maximo_Id
            grdProductos.AgregarFila()
            grdProductos.ActivarCelda(f + 1, c)
        Else
            clProd.Editar(vId, a)
        End If

        grdProductos.Texto(f, c) = a
    End Sub

    Private Sub grdProductos_KeyUp(sender As Object, e As Short) Handles grdProductos.KeyUp
        Select Case e
            Case 46
                'Tecla Borrar/Delete
                If grdProductos.Texto(, 0) <> 0 Then
                    If MsgBox($"¿Esta seguro de borrar el producto {grdProductos.Texto(, 0)}. {grdProductos.Texto(, 1)}?",
                          MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical, "Borrar") = MsgBoxResult.Yes Then
                        'Borrar el registro
                        clProd.Borrar(grdProductos.Texto(, 0))
                        grdProductos.BorrarFila()
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