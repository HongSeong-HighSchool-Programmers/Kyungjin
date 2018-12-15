Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Random
        Label1.Text = a.Next(1, 301)
        Dim b As New Integer
        b = Label1.Text
        If Label1.Text = b Then
            Label2.Text = "★문제 번호" & b & " 이 뽑혔습니다★"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
