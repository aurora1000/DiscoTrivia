Public Class multiplayer_start
    Private time As Byte = 3
    Public player As String
    Private Sub multiplayer_start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time = time - 1
        Label2.Text = "Starting in " + time.ToString + " . . ."

        If time = 0 Then
            If player = "host" Then
                Timer1.Stop()
                'MessageBox.Show("Trial Your the host!")
                Form4.player = "host"
                Form4.StartPosition = FormStartPosition.Manual
                Form4.Location = Me.Location
                Form4.Show()
                Me.Close()
            ElseIf player = "client" Then
                Timer1.Stop()
                'MessageBox.Show("Trial Your the client!")
                Form4.player = "client"
                Form4.StartPosition = FormStartPosition.Manual
                Form4.Location = Me.Location
                Form4.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class