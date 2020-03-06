Public Class client_wait
    Private Client As TCPControlClient
    Public player As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Client = New TCPControlClient(RichTextBox1.Text, 64555)

        If Client.Connected = True Then
            Client.Send("Play Game")
            multiplayer_start.player = player
            multiplayer_start.StartPosition = FormStartPosition.Manual
            multiplayer_start.Location = Form8.Location
            multiplayer_start.Show()
            Client.Client.Close()
            Form8.Close()
            Me.Close()
        End If
    End Sub

    Private Sub client_wait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Hide()
        player = "client"
    End Sub
End Class