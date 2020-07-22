Public Class clsProductos
    Public Sub New()

    End Sub

#Region " Editar Datos "

    Public Sub Agregar(ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"INSERT INTO Productos (Nombre) VALUES('{Nombre_Nuevo}')", db)


        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub
    Public Sub Editar(ByVal Id As Integer, ByVal Nombre_Nuevo As String)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand($"UPDATE Productos SET Nombre='{Nombre_Nuevo}' WHERE ID={Id}", db)


        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub

    Public Sub Borrar(ByVal Id As Integer)
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dc As New OleDb.OleDbCommand("DELETE FROM Productos WHERE ID=" & Id, db)


        db.Open()

        dc.ExecuteNonQuery()

        db.Close()
    End Sub

#End Region
#Region " Devolver Datos "
    Public Function Datos() As DataTable
        Dim db As New OleDb.OleDbConnection(My.Resources.Cadena_Conexion)
        Dim dat As New OleDb.OleDbDataAdapter("SELECT * FROM Productos", db)

        Dim dt As New DataTable("Datos")
        dat.Fill(dt)

        Return dt
    End Function

    Public Function Nombre_Producto(ByVal Id As Integer) As String

    End Function

    Public Function Maximo_Id() As Integer

    End Function
#End Region
End Class
