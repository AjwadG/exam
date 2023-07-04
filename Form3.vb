Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.DataSource = Form1.users

    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        TextBox1.Text = Form1.users.Item(ListBox1.SelectedIndex)
        TextBox2.Text = Form1.passwords.Item(ListBox1.SelectedIndex)
        CheckBox1.Checked = Form1.m1.Item(ListBox1.SelectedIndex)
        CheckBox2.Checked = Form1.m2.Item(ListBox1.SelectedIndex)

    End Sub

  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.users.Add(TextBox1.Text)
        Form1.passwords.Add(TextBox2.Text)
        Form1.m1.Add(CheckBox1.Checked)
        Form1.m2.Add(CheckBox2.Checked)
        ListBox1.DataSource = Nothing
        ListBox1.DataSource = Form1.users
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.users.RemoveAt(ListBox1.SelectedIndex)
        Form1.passwords.RemoveAt(ListBox1.SelectedIndex)
        Form1.m1.RemoveAt(ListBox1.SelectedIndex)
        Form1.m2.RemoveAt(ListBox1.SelectedIndex)
        ListBox1.DataSource = Nothing
        ListBox1.DataSource = Form1.users
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.users.Item(ListBox1.SelectedIndex) = TextBox1.Text
        Form1.passwords.Item(ListBox1.SelectedIndex) = TextBox2.Text
        Form1.m1.Item(ListBox1.SelectedIndex) = CheckBox1.Checked
        Form1.m2.Item(ListBox1.SelectedIndex) = CheckBox2.Checked
        ListBox1.DataSource = Nothing
        ListBox1.DataSource = Form1.users
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim writefile As New IO.StreamWriter("users.txt")
        Dim k As Integer = 0
        For Each u As String In Form1.users
            writefile.WriteLine(cod(u) & cod(",") & cod(Form1.passwords(k)) & cod(",") & cod(Form1.m1(k)) & cod(",") & cod(Form1.m2(k)))
            k = k + 1
        Next
        writefile.Close()
    End Sub

    Function cod(ByVal x As String) As String

        Dim s As String = ""
        For Each c As Char In x

            s = s & ChrW(AscW(c) + 3)
            
        Next
        Return s
    End Function
End Class