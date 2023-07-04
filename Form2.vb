Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FileToolStripMenuItem.Enabled = Form1.m1.Item(Form1.pos)
        EditToolStripMenuItem.Enabled = Form1.m2.Item(Form1.pos)
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Form3.Show()
    End Sub

   
    Private Sub SelectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub عملياتالنصToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عملياتالنصToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub عملياتاخرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles عملياتاخرToolStripMenuItem.Click
        Form6.Show()
    End Sub
End Class