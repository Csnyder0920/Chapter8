Public Class Menu

    Private Sub btnRandomLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnRandomLotteryNumbers.Click
        Dim box = New LotteryNumbers()
        box.Show()
    End Sub

    Private Sub btnSeatingChart_Click(sender As Object, e As EventArgs) Handles btnSeatingChart.Click
        Dim box = New SeatingChart()
        box.Show()
    End Sub
End Class
