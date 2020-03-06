Imports System.Net.Sockets
Imports System.Text
Public Class Form8

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        host_wait.StartPosition = FormStartPosition.Manual
        Dim r As Rectangle
        r = Me.RectangleToScreen(Me.ClientRectangle)
        Dim x = r.Left + (r.Width - host_wait.Width) \ 2
        Dim y = r.Top + (r.Height - host_wait.Height) \ 2
        host_wait.Location = New Point(x, y)
        Me.Enabled = False
        host_wait.Show()

    End Sub


    'Private Sub Form8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    '    'Server.IsListening = False
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        client_wait.StartPosition = FormStartPosition.Manual
        Dim r As Rectangle
        r = Me.RectangleToScreen(Me.ClientRectangle)
        Dim x = r.Left + (r.Width - client_wait.Width) \ 2
        Dim y = r.Top + (r.Height - client_wait.Height) \ 2
        client_wait.Location = New Point(x, y)
        Me.Enabled = False
        client_wait.Show()
    End Sub

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

    Private Sub Button1_EnabledChanged(sender As Object, e As EventArgs) Handles Button1.EnabledChanged

    End Sub


End Class