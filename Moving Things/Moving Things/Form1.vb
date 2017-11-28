Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBecca.Click
        picBecca.Left = 25
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount As Integer
        Dim intNumber As Integer
        Dim rand As New Random

        For intCount = 16 To 325
            picBecca.Left = intCount
        Next
    End Sub

    Private Sub picJames_Click(sender As Object, e As EventArgs) Handles picJames.Click
        picJames.Left = 25
    End Sub

    Private Sub picRenee_Click(sender As Object, e As EventArgs) Handles picRenee.Click
        picRenee.Left = 25
    End Sub
End Class
