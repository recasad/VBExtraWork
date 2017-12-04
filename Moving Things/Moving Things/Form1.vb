Public Class Form1
    Private intBeccaCount As Integer
    Private intJamesCount As Integer
    Private intReneeCount As Integer

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBecca.Click
        picBecca.Left = 25
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random
        Dim intScore As Integer = 1
        Dim intYouWin As Integer = 9

        For intCount1 = 25 To rand.Next(250) + 50
            picBecca.Left = intCount1
        Next
        For intCount2 = 25 To rand.Next(250) + 50
            picJames.Left = intCount2
        Next
        For intCount3 = 25 To rand.Next(250) + 50
            picRenee.Left = intCount3
        Next

        If intCount1 > intCount2 & intCount3 Then
            intBeccaCount = intBeccaCount + 1
            lblBecca.Text += 1
            If intBeccaCount = intYouWin Then
                lblBecca.Text = "You Win!!"
            End If
        ElseIf intCount2 > intCount3 & intCount1 Then
            intJamesCount = intJamesCount + 1
            lblJames.Text = intJamesCount
            If intJamesCount = intYouWin Then
                lblJames.Text = "You Win!!"
            End If
        ElseIf intCount3 > intCount2 & intCount1 Then
            intReneeCount = intReneeCount + 1
            lblRenee.Text = intReneeCount
            If intReneeCount = intYouWin Then
                lblRenee.Text = "You Win!!"
            End If
        End If

        lblBecca.Text = intBeccaCount
        lblJames.Text = intJamesCount
        lblRenee.Text = intReneeCount
    End Sub

    Private Sub picJames_Click(sender As Object, e As EventArgs) Handles picJames.Click
        picJames.Left = 25
    End Sub

    Private Sub picRenee_Click(sender As Object, e As EventArgs) Handles picRenee.Click
        picRenee.Left = 25
    End Sub
End Class
