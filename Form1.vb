Public Class Form1
    Dim readfile As New IO.StreamReader("users.txt")
    Public users As New List(Of String)
    Public passwords As New List(Of String)
    Public m1 As New List(Of String)
    Public m2 As New List(Of String)
    Public pos As Integer
    Dim k As Integer
    Dim ok As Boolean
    Dim ss As String

    Function decod(ByVal x As String) As String


        Dim s As String = ""
        For Each c As Char In x
            s = s & ChrW(AscW(c) - 3)
           
        Next
        Return s
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        While Not readfile.EndOfStream
            ss = decod(readfile.ReadLine)
            users.Add(ss.Split(",")(0))
            passwords.Add(ss.Split(",")(1))
            m1.Add(ss.Split(",")(2))
            m2.Add(ss.Split(",")(3))
        End While
        readfile.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ok = False
        k = 0
        For Each u As String In users
            If u = TextBox1.Text Then If passwords(k) = TextBox2.Text Then ok = True : pos = k
            k = k + 1
        Next
        If ok Then Form2.Show() Else MsgBox("try agin .....")
    End Sub


End Class
