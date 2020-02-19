Public Class index_screen
    Private Sub title_label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub single_player_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub index_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter
        Panel1.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.single_player_hovers)
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave
        Panel1.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.single_player_disco)
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Form2.StartPosition = FormStartPosition.Manual
        Form2.Location = Me.Location
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_MouseEnter(sender As Object, e As EventArgs) Handles Panel2.MouseEnter
        Panel2.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.multi_player_hover)
    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        Panel2.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.multi_player_disco)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
