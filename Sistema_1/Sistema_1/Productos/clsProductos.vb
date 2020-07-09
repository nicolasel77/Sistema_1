Imports System.IO

Public Class clsProductos

    Public Function Datos() As DataTable
        Dim srProd As New StreamReader(Application.StartupPath + "\Productos.txt")

        Dim dt As New DataTable()
        dt.Columns.Add("Id", GetType(Integer))
        dt.Columns.Add("Nombre", GetType(String))

        Dim vlinea As String = srProd.ReadLine

        While vlinea IsNot Nothing

            dt.Rows.Add(Codigo_Seleccionado(vlinea), Nombre_Seleccionado(vlinea))

            vlinea = srProd.ReadLine

        End While

        Return dt

    End Function
End Class
