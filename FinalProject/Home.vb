Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim pForm1 As New Form1
        Me.Hide()
        pForm1.ShowDialog()
        Me.Close()
    End Sub
End Class