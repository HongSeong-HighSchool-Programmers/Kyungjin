Public Class Form1
    Dim a, b, c, d As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        a = TextBox1.Text

        For c = a - 1 To 1 Step -1
            a = c * a
        Next

        TextBox3.Text = a
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b
        TextBox3.Text = c

    End Sub
End Class
