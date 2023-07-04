Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Char() = TextBox2.Text.ToCharArray
        Dim fl As Byte() = IO.File.ReadAllBytes(TextBox1.Text)
        Dim b As Byte() = fl
        Dim c As Integer = 0
        Dim kk As Integer
        For Each bt As Byte In fl
            kk = bt + AscW(k(c Mod k.Length))
            If kk > 255 Then b(c) = kk - 256
            c = c + 1

        Next
        IO.File.WriteAllBytes(OpenFileDialog1.SafeFileName, b)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim k As Char() = TextBox2.Text.ToCharArray
        Dim fl As Byte() = IO.File.ReadAllBytes(TextBox1.Text)
        Dim b As Byte() = fl
        Dim c As Integer = 0
        Dim kk As Integer
        For Each bt As Byte In fl
            kk = bt + AscW(k(c Mod k.Length))
            If kk > 255 Then b(c) = kk - 256
            c = c + 1

        Next
        IO.File.WriteAllBytes(OpenFileDialog1.SafeFileName, b)
    End Sub
End Class