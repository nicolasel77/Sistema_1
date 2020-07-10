Imports System.IO

Public Class clsProductos
    Public Id As Integer

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        Dim archivo As String = Application.StartupPath + "\Productos.txt"

        If File.Exists(archivo) Then
            Dim srProd As New StreamReader(archivo)
            Dim vlinea As String = srProd.ReadLine

            While vlinea IsNot Nothing

                dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

                vlinea = srProd.ReadLine

            End While
            srProd.Close()

            Return dt
        End If
    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar()

    End Sub

    Public Sub Editar()

    End Sub

    Public Sub Borrar()
        'Se va a borrar el id
        MsgBox("Se borro el id " & Id)
    End Sub

#End Region
End Class
