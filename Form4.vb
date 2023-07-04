Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fl_read As New IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open)
        Dim fl_write As New IO.FileStream(TextBox2.Text, IO.FileMode.CreateNew)
        Dim bt As Integer
        Dim s As String = TextBox3.Text
        For k = 0 To fl_read.Length - 1
            bt = fl_read.ReadByte + 3
            If bt > 255 Then bt = bt - 256

            fl_write.WriteByte(bt)
        Next
        fl_read.Close()
        fl_write.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim fl_read As New IO.FileStream(TextBox1.Text, IO.FileMode.Open)
        Dim fl_write As New IO.FileStream(TextBox2.Text, IO.FileMode.CreateNew)
        Dim bt As Integer
        For k = 0 To fl_read.Length - 1
            bt = fl_read.ReadByte - 3
            If bt < 0 Then bt = bt + 256

            fl_write.WriteByte(bt)
        Next
        fl_read.Close()
        fl_write.Close()
    End Sub


End Class