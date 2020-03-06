Imports System.Net
Imports System.Net.Sockets
Imports System.IO

Public Class TCPControlClient
    Public Client As TcpClient
    Public Connected As Boolean
    Public DataStream As StreamWriter
    Public ServerIP As IPAddress = IPAddress.Parse("127.0.0.1")
    Public ServerPort As Integer = 64555
        Public Sub New(Host As String, Port As Integer)
        ' CLIENT

        Try
            Client = New TcpClient(Host, ServerPort)
            Connected = True
            DataStream = New StreamWriter(Client.GetStream)
        Catch
            Connected = False
            client_wait.Label2.Show()
        End Try
    End Sub

        Public Sub Send(Data As String)
            DataStream.Write(Data & vbCrLf)
            DataStream.Flush()
        End Sub
    End Class
