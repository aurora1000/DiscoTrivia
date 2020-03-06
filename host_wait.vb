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
            Startgame()
        End If
    End Sub

    Private Sub Startgame()
        MessageBox.Show(":: Client Connected ::")
        Try
            Server.IsListening = False
            Server.Server.Stop()
            multiplayer_start.player = player
            multiplayer_start.StartPosition = FormStartPosition.Manual
            multiplayer_start.Location = Form8.Location
            multiplayer_start.Show()
            Form8.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Server.IsListening = False
            Server.Server.Stop()
            Form8.Enabled = True
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error" + ex.ToString)
        End Try
    End Sub
End Class