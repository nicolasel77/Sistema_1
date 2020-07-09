Imports System.IO

Public Class clsProductos

#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        Dim srProd As New StreamReader(Application.StartupPath + "\Productos.txt")
        Dim vlinea As String = srProd.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

            vlinea = srProd.ReadLine

        End While
        srProd.Close()

        Return dt

    End Function

#End Region

#Region " Editar Datos"
    Public Sub Agregar()

    End Sub

    Public Sub Editar()

    End Sub

    Public Sub Borrar()

    End Sub

#End Region
End Class
