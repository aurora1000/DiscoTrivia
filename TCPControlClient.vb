Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class TCPControlClient
    Private Server As TCPControl
    Public Client As TcpClient
    Public Connected As Boolean
    Public DataStream As StreamWriter

    Public ServerIP As IPAddress = IPAddress.Parse("127.0.0.1")
    Public ServerPort As Integer = 64555

    Private ReceiveData As StreamReader
    Private comThread As Thread
    Public isListening As Boolean = True
    Public Sub New(Host As String, Port As Integer)
        ' CLIENT
        Try
            Client = New TcpClient(Host, ServerPort)
            Connected = True
            DataStream = New StreamWriter(Client.GetStream)
            comThread = New Thread(New ThreadStart(AddressOf Listening))
            comThread.Start()
        Catch
            Connected = False
            client_wait.Label2.Show()
        End Try
    End Sub

    Public Sub Send(Data As String)
        DataStream.Write(Data & vbCrLf)
        DataStream.Flush()
    End Sub

    Public Event MessageReceived(sender As TCPControl, Data As String)
    Private Sub Listening()

        Do Until isListening = False

            If Client.Connected = True Then
                ReceiveData = New StreamReader(Client.GetStream)
            End If

            Try
                RaiseEvent MessageReceived(Server, ReceiveData.ReadLine)
            Catch ex As Exception

            End Try


            Thread.Sleep(10)
        Loop

    End Sub

End Class
