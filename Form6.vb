Public Class Form6
    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel_white)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.start_hover)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.start)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form7.StartPosition = FormStartPosition.Manual
        Form7.Location = Me.Location
        Form7.Show()
        Me.Close()
    End Sub
End Class