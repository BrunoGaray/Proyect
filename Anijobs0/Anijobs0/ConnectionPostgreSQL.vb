Public Class ConnectionPostgreSQL
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection
        Dim conexion As Npgsql.NpgsqlConnection
        conexion = New Npgsql.NpgsqlConnection()

        Dim CadenaDeConexion As String
        CadenaDeConexion = "Server=10.1.2.4;Port=5432;UserId='postgres';Password='root';Database='anijobs'"

        Try
            conexion.ConnectionString = CadenaDeConexion
            conexion.Open()

        Catch ex As Exception
            conexion.Close()
            Throw ex
        End Try

        Return conexion
    End Function
End Class
