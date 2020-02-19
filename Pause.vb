Public Class Pause
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Form4.speed) Then
            Form4.Enabled = True
            Form4.Button1.Enabled = True
            Form4.Button2.Enabled = True
            Form4.Button3.Enabled = True
            Form4.Button4.Enabled = True
            Form4.Timer1.Start()
            Form4.speed = False
            Me.Close()
        ElseIf (Form7.survival) Then
            Form7.Enabled = True
            Form7.Button1.Enabled = True
            Form7.Button2.Enabled = True
            Form7.Button3.Enabled = True
            Form7.Button4.Enabled = True
            Form7.survival = False
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Form4.speed) Then
            Form5.StartPosition = FormStartPosition.Manual
            Form5.Location = Form4.Location
            Form5.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.speed_mode_after)
            Form5.PictureBox3.Hide()
            Form5.PictureBox1.Show()
            Form5.Show()
            Form4.Hide()
            Me.Close()
        ElseIf (Form7.survival) Then
            Form5.StartPosition = FormStartPosition.Manual
            Form5.Location = Form7.Location
            Form5.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.survival_mode_after)
            Form5.PictureBox3.Show()
            Form5.PictureBox1.Hide()
            Form5.Show()
            Form7.Hide()
            Me.Close()
        End If

    End Sub
End Class