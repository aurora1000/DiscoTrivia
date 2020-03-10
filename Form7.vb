Imports MySql.Data.MySqlClient
Public Class Form7
    Public score As Integer = 0
    Dim life As Byte = 3
    Dim question_ID As String
    Public survival As Boolean = False

    Private conn As connection

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn = New connection("select * from trivia order by RAND() Limit 1")
            While conn.read.Read
                Label2.Text = Convert.ToString(conn.read("question"))
                Button1.Text = Convert.ToString(conn.read("choice_1"))
                Button2.Text = Convert.ToString(conn.read("choice_2"))
                Button3.Text = Convert.ToString(conn.read("choice_3"))
                Button4.Text = Convert.ToString(conn.read("choice_4"))
                question_ID = Convert.ToString(conn.read("id"))
            End While
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New connection("select * from trivia where id = '" + question_ID + "'")
            While conn.read.Read
                If (Button1.Text = Convert.ToString(conn.read("answer"))) Then
                    Button1.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button1.Text <> Convert.ToString(conn.read("answer"))) Then
                    Button1.BackColor = Color.DarkRed
                    life = life - 1
                    If (Button2.Text = Convert.ToString(conn.read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(conn.read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(conn.read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn = New connection("select * from trivia where id = '" + question_ID + "'")
            While conn.read.Read
                If (Button2.Text = Convert.ToString(conn.read("answer"))) Then
                    Button2.BackColor = Color.DarkGreen
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button2.Text <> Convert.ToString(conn.read("answer"))) Then
                    Button2.BackColor = Color.DarkRed
                    life = life - 1
                    If (Button1.Text = Convert.ToString(conn.read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(conn.read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(conn.read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    End If
                End If
            End While
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn = New connection("select * from trivia where id = '" + question_ID + "'")
            While conn.read.Read
                If (Button3.Text = Convert.ToString(conn.read("answer"))) Then
                    Button3.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button3.Text <> Convert.ToString(conn.read("answer"))) Then
                    Button3.BackColor = Color.DarkRed
                    life = life - 1
                    If (Button2.Text = Convert.ToString(conn.read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button1.Text = Convert.ToString(conn.read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(conn.read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            conn = New connection("select * from trivia where id = '" + question_ID + "'")
            While conn.read.Read
                If (Button4.Text = Convert.ToString(conn.read("answer"))) Then
                    Button4.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button4.Text <> Convert.ToString(conn.read("answer"))) Then
                    Button4.BackColor = Color.DarkRed
                    life = life - 1
                    If (Button2.Text = Convert.ToString(conn.read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(conn.read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    ElseIf (Button1.Text = Convert.ToString(conn.read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If (life = 1) Then
            PictureBox2.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
            PictureBox3.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
        ElseIf (life = 2) Then
            PictureBox3.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
        ElseIf (life = 0) Then
            PictureBox1.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
            PictureBox2.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
            PictureBox3.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.heart_gray)
        End If

        If (life = 0) Then
            Timer1.Stop()
            survival = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Form5.StartPosition = FormStartPosition.Manual
            Form5.Location = Me.Location
            Form5.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.survival_mode_after)
            Form5.PictureBox3.Show()
            Form5.PictureBox1.Hide()
            Form5.Show()
            Me.Hide()
        End If

        If (score < 10) Then
            Label1.Text = "0" + Convert.ToString(score)
        Else
            Label1.Text = Convert.ToString(score)
        End If

        If (life > 0) Then

            Button1.BackColor = Color.DimGray
            Button2.BackColor = Color.DimGray
            Button3.BackColor = Color.DimGray
            Button4.BackColor = Color.DimGray
            Try
                conn = New connection("select * from trivia where id != '" + question_ID + "' order by RAND() Limit 1")
                While conn.read.Read
                    Label2.Text = Convert.ToString(conn.read("question"))
                    Button1.Text = Convert.ToString(conn.read("choice_1"))
                    Button2.Text = Convert.ToString(conn.read("choice_2"))
                    Button3.Text = Convert.ToString(conn.read("choice_3"))
                    Button4.Text = Convert.ToString(conn.read("choice_4"))
                    question_ID = Convert.ToString(conn.read("id"))
                End While
                conn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Timer1.Stop()
        End If
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.pause_hover)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.pause)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        survival = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Pause.StartPosition = FormStartPosition.Manual

        Dim r As Rectangle
        r = Me.RectangleToScreen(Me.ClientRectangle)
        Dim x = r.Left + (r.Width - Pause.Width) \ 2
        Dim y = r.Top + (r.Height - Pause.Height) \ 2
        Pause.Location = New Point(x, y)
        Pause.Show()
        Me.Enabled = False
    End Sub
End Class