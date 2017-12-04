Public Class Form1
    Sub ShowRightPic()
        picRight.Visible = True
        picLeft.Visible = False
    End Sub
    Sub ShowLeftPic()
        picLeft.Visible = True
        picRight.Visible = False
    End Sub
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim rand As New Random
        If rand.Next(2) = 0 Then
            ShowLeftPic()
        Else
            ShowRightPic()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
