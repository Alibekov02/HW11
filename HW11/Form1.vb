Public Class Form1
    Private Sub PicturesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PicturesToolStripMenuItem.Click
        Dim i As Form2 = New Form2
        i.MdiParent = Me
        i.Show()
    End Sub
End Class
