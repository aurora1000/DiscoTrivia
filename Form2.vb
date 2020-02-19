Public Class Form2

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        index_screen.StartPosition = FormStartPosition.Manual
        index_screen.Location = Me.Location
        index_screen.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel_white)
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Form3.StartPosition = FormStartPosition.Manual
        Form3.Location = Me.Location
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.speed_mode_hover)
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.speed_mode)
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Panel2.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.survival_mode_hover)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.survival_mode)
    End Sub

    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Form6.StartPosition = FormStartPosition.Manual
        Form6.Location = Me.Location
        Form6.Show()
        Me.Close()
    End Sub
End Class