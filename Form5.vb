
Public Class Form5
    Dim origin As Boolean
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form4.speed Then
            Dim score_int As Integer = Form4.score
            If (score_int < 10) Then
                Label1.Text = "0" + Convert.ToString(score_int)
            Else
                Label1.Text = Convert.ToString(score_int)
            End If
            Form4.speed = False
            origin = True
            Form4.Close()

        ElseIf Form7.survival Then
            Dim score_int As Integer = Form7.score
            If (score_int < 10) Then
                Label1.Text = "0" + Convert.ToString(score_int)
            Else
                Label1.Text = Convert.ToString(score_int)
            End If
            Form7.survival = False
            origin = False
            Form7.Close()
        End If

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.cancel_white)
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.play_again_hover)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.play_again)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (origin) Then
            Form3.StartPosition = FormStartPosition.Manual
            Form3.Location = Me.Location
            Form3.Show()
            Me.Close()
        Else
            Form6.StartPosition = FormStartPosition.Manual
            Form6.Location = Me.Location
            Form6.Show()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        index_screen.StartPosition = FormStartPosition.Manual
        index_screen.Location = Me.Location
        index_screen.Show()
        Me.Close()
    End Sub
End Class