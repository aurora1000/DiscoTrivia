Public Class host_wait
    Private Server As TCPControl
    Public player As String
    Private Sub host_wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Server = New TCPControl
        player = "host"
        AddHandler Server.MessageReceived, AddressOf OnLineReceived
    End Sub
    Private Sub OnLineReceived(sender As TCPControl, Data As String)
        'MessageBox.Show(":: Client Connected ::")
        If (Data = "Play Game") Then
            Startgame(Data)
        End If
    End Sub

    Private Sub Startgame(txt As String)
        MessageBox.Show(":: Client Connected ::")
        Server.IsListening = False
        Server.Server.Stop()
        multiplayer_start.player = player
        multiplayer_start.StartPosition = FormStartPosition.Manual
        multiplayer_start.Location = Form8.Location
        multiplayer_start.Show()
        Form8.Close()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Server.IsListening = False
        Server.Server.Stop()
        Form8.Enabled = True
        Me.Close()
    End Sub
End Class