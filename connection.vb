Imports MySql.Data.MySqlClient
Public Class connection
    Public connection As MySqlConnection
    Public command As MySqlCommand
    Public read As MySqlDataReader
    Public Sub New(comm As String)
        connection = New MySqlConnection
        command = New MySqlCommand(comm, connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        'connection.ConnectionString = "server=85.10.205.173;port=3306;userid=disco_trivia_db;password=D1sc0tr1v1@;database=disco_trivia_db"
        connection.Open()
        read = command.ExecuteReader
    End Sub


    Public Sub Close()
        connection.Close()
    End Sub

End Class
