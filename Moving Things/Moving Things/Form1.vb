Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picBecca.Click
        picBecca.Left = 25
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        lblBank.Text = String.Empty

        Dim intWinner As Integer
        Dim intCount As Integer
        Dim rand As New Random
        Dim decBet As Decimal
        Dim decBank As Decimal = 1000

        intWinner = rand.Next(3)
            If intWinner = 0 Then
                For intCount = 25 To 325
                    picBecca.Left = intCount
                Next
                For intCount = 25 To 240
                    picJames.Left = intCount
                Next
                For intCount = 25 To 130
                    picRenee.Left = intCount
                Next
            ElseIf intWinner = 1 Then
                For intCount = 25 To 325
                    picJames.Left = intCount
                Next
                For intCount = 25 To 240
                    picRenee.Left = intCount
                Next
                For intCount = 25 To 130
                    picBecca.Left = intCount
                Next
            ElseIf intWinner = 2 Then
                For intCount = 25 To 325
                    picRenee.Left = intCount
                Next
                For intCount = 25 To 240
                    picBecca.Left = intCount
                Next
                For intCount = 25 To 130
                    picJames.Left = intCount
                Next
            End If

        If intWinner = 0 & radBecca.Checked = True Then
            decBank += decBet
        ElseIf intWinner = 1 & radJames.Checked = True Then
            decBank += decBet
        ElseIf intWinner = 2 & radRenee.Checked = True Then
            decBank += decBet
        Else
            decBank -= decBet
        End If

        lblBank.Text = decBank.ToString("c")
    End Sub

    Private Sub picJames_Click(sender As Object, e As EventArgs) Handles picJames.Click
        picJames.Left = 25
    End Sub

    Private Sub picRenee_Click(sender As Object, e As EventArgs) Handles picRenee.Click
        picRenee.Left = 25
    End Sub
End Class
