Public Class Menu

    Private Sub btnRandomLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnRandomLotteryNumbers.Click
        Dim box = New LotteryNumbers()
        box.Show()
    End Sub
End Class
