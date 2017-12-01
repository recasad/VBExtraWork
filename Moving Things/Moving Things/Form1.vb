Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBecca.Click
        picBecca.Left = 25
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intWinner As Integer
        Dim intCount As Integer
        Dim rand As New Random
        Dim intBeccaCount As Integer
        Dim intReneeCount As Integer
        Dim intJamesCount As Integer

        picHappy.Visible = False
        picSad.Visible = False
        picAward.Visible = True
        intWinner = rand.Next(3)

        If intWinner = 0 Then
            intBeccaCount = intBeccaCount + 1
            lblBecca.Text = intBeccaCount
            For intCount = 25 To 325
                picBecca.Left = intCount
            Next
            For intCount = 25 To 240
                picJames.Left = intCount
            Next
            For intCount = 25 To 130
                picRenee.Left = intCount
            Next
            If radBecca.Checked = True Then
                picHappy.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Won!!!")
            Else
                picSad.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Lost!!")
            End If
        ElseIf intWinner = 1 Then
            intJamesCount = intJamesCount + 1
            lblJames.Text = intJamesCount
            For intCount = 25 To 325
                picJames.Left = intCount
            Next
            For intCount = 25 To 240
                picRenee.Left = intCount
            Next
            For intCount = 25 To 130
                picBecca.Left = intCount
            Next
            If radJames.Checked = True Then
                picHappy.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Won!!!")
            Else
                picSad.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Lost!!")
            End If
        ElseIf intWinner = 2 Then
            intReneeCount = intReneeCount + 1
            lblRenee.Text = intReneeCount
            For intCount = 25 To 325
                picRenee.Left = intCount
            Next
            For intCount = 25 To 240
                picBecca.Left = intCount
            Next
            For intCount = 25 To 130
                picJames.Left = intCount
            Next
            If radRenee.Checked = True Then
                picHappy.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Won!!!")
            Else
                picSad.Visible = True
                picAward.Visible = False
                lblWinning.Text = ("You Lost!!")
            End If
        End If
    End Sub

    Private Sub picJames_Click(sender As Object, e As EventArgs) Handles picJames.Click
        picJames.Left = 25
    End Sub

    Private Sub picRenee_Click(sender As Object, e As EventArgs) Handles picRenee.Click
        picRenee.Left = 25
    End Sub
End Class
