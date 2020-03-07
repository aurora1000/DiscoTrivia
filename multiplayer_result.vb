Public Class multiplayer_result
    Public my_score As Integer
    Public player As String
    Public ip_server As String

    Private Server As TCPControl
    Private Client As TCPControlClient
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        index_screen.StartPosition = FormStartPosition.Manual
        index_screen.Location = Me.Location
        index_screen.Show()
        Me.Close()
    End Sub

    Private Sub multiplayer_result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If player = "host" Then
            'Label3.Text = my_score.ToString
            'Server = New TCPControl
            'AddHandler Server.MessageReceived, AddressOf OnLineReceived

        ElseIf player = "client" Then
            Label3.Text = my_score.ToString
            'Client = New TCPControlClient(ip_server, 64555)
            'If Client.Connected = True Then
            'Client.Send(my_score)
            'End If
        End If
    End Sub

    Private Sub OnLineReceived(sender As TCPControl, Data As Integer)
        Server.IsListening = False
        Server.Server.Stop()
        Label4.Text = Data.ToString

        If Data > my_score Then
            PictureBox1.Hide()
            PictureBox2.Show()
        ElseIf my_score > Data Then
            PictureBox2.Hide()
            PictureBox1.Show()
        End If

    End Sub
End Class