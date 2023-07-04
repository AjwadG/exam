
Public Class Form5
    Dim em As Integer = 6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
        For Each letter As String In TextBox1.Text
            TextBox2.Text += Chr(Asc(letter) + em)
        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For Each letter As String In TextBox2.Text
            TextBox3.Text += Chr(Asc(letter) - em)
        Next
    End Sub
End Class