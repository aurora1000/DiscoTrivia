﻿Imports MySql.Data.MySqlClient
Public Class Form4
    Public time As Byte = 60
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Public score As Integer = 0
    Dim questions(100) As Integer
    Dim question_ID As String
    Public speed As Boolean
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        time = time - 1
        Label1.Text = time
        If ProgressBar1.Value = 30 Then
            ProgressBar1.ForeColor = Color.DarkGoldenrod
        ElseIf ProgressBar1.Value = 50 Then
            ProgressBar1.ForeColor = Color.DarkRed
            Label1.ForeColor = Color.DarkRed
        ElseIf ProgressBar1.Value = 60 Then
            Timer1.Stop()
        End If

        If (time = 0) Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Form5.StartPosition = FormStartPosition.Manual
            Form5.Location = Me.Location
            Form5.BackgroundImage = New Bitmap(Trivia_Disco.My.Resources.Resources.speed_mode_after)
            Form5.PictureBox3.Hide()
            Form5.PictureBox1.Show()
            Form5.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection
        command = New MySqlCommand("select * from trivia", connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        Try
            connection.Open()
            Dim read As MySqlDataReader = command.ExecuteReader


            While read.Read
                Label2.Text = Convert.ToString(read("question"))
                Button1.Text = Convert.ToString(read("choice_1"))
                Button2.Text = Convert.ToString(read("choice_2"))
                Button3.Text = Convert.ToString(read("choice_3"))
                Button4.Text = Convert.ToString(read("choice_4"))
                question_ID = Convert.ToString(read("id"))
            End While
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Label1.Text = time
        Timer1.Start()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        command = New MySqlCommand("select * from trivia where id = '" + question_ID + "'", connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        Try
            connection.Open()
            Dim read As MySqlDataReader = command.ExecuteReader
            While read.Read
                If (Button1.Text = Convert.ToString(read("answer"))) Then
                    Button1.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button1.Text <> Convert.ToString(read("answer"))) Then
                    Button1.BackColor = Color.DarkRed
                    If (Button2.Text = Convert.ToString(read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        command = New MySqlCommand("select * from trivia where id = '" + question_ID + "'", connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        Try
            connection.Open()
            Dim read As MySqlDataReader = command.ExecuteReader

            While read.Read
                If (Button2.Text = Convert.ToString(read("answer"))) Then
                    Button2.BackColor = Color.DarkGreen
                    Button1.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button2.Text <> Convert.ToString(read("answer"))) Then
                    Button2.BackColor = Color.DarkRed
                    If (Button1.Text = Convert.ToString(read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    End If
                End If
            End While
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection = New MySqlConnection
        command = New MySqlCommand("select * from trivia where id = '" + question_ID + "'", connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        Try
            connection.Open()
            Dim read As MySqlDataReader = command.ExecuteReader

            While read.Read
                If (Button3.Text = Convert.ToString(read("answer"))) Then
                    Button3.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DarkRed
                    Button4.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button3.Text <> Convert.ToString(read("answer"))) Then
                    Button3.BackColor = Color.DarkRed
                    If (Button2.Text = Convert.ToString(read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button1.Text = Convert.ToString(read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button4.BackColor = Color.DarkRed
                    ElseIf (Button4.Text = Convert.ToString(read("answer"))) Then
                        Button4.BackColor = Color.DarkGreen
                        Button1.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer2.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        connection = New MySqlConnection
        command = New MySqlCommand("select * from trivia where id = '" + question_ID + "'", connection)
        connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
        Try
            connection.Open()
            Dim read As MySqlDataReader = command.ExecuteReader

            While read.Read
                If (Button4.Text = Convert.ToString(read("answer"))) Then
                    Button4.BackColor = Color.DarkGreen
                    Button2.BackColor = Color.DarkRed
                    Button3.BackColor = Color.DarkRed
                    Button1.BackColor = Color.DarkRed
                    score = score + 1
                ElseIf (Button4.Text <> Convert.ToString(read("answer"))) Then
                    Button4.BackColor = Color.DarkRed
                    If (Button2.Text = Convert.ToString(read("answer"))) Then
                        Button2.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    ElseIf (Button3.Text = Convert.ToString(read("answer"))) Then
                        Button3.BackColor = Color.DarkGreen
                        Button2.BackColor = Color.DarkRed
                        Button1.BackColor = Color.DarkRed
                    ElseIf (Button1.Text = Convert.ToString(read("answer"))) Then
                        Button1.BackColor = Color.DarkGreen
                        Button3.BackColor = Color.DarkRed
                        Button2.BackColor = Color.DarkRed
                    End If
                End If
            End While
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        End Try
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (time > 0) Then
            Button1.BackColor = Color.DimGray
            Button2.BackColor = Color.DimGray
            Button3.BackColor = Color.DimGray
            Button4.BackColor = Color.DimGray
            connection = New MySqlConnection
            command = New MySqlCommand("select * from trivia where id != '" + question_ID + "' order by RAND() Limit 1", connection)
            connection.ConnectionString = "server=localhost;userid=root;password=P@ssw0rd;database=disco_trivia"
            Try
                connection.Open()
                Dim read As MySqlDataReader = command.ExecuteReader


                While read.Read
                    Label2.Text = Convert.ToString(read("question"))
                    Button1.Text = Convert.ToString(read("choice_1"))
                    Button2.Text = Convert.ToString(read("choice_2"))
                    Button3.Text = Convert.ToString(read("choice_3"))
                    Button4.Text = Convert.ToString(read("choice_4"))
                    question_ID = Convert.ToString(read("id"))
                End While
                connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            End Try
            Timer2.Stop()
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.pause_hover)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = New Bitmap(Trivia_Disco.My.Resources.Resources.pause)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Stop()
        speed = True
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class