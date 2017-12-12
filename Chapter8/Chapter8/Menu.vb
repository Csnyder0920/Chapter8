Public Class Menu

    Private Sub btnRandomLotteryNumbers_Click(sender As Object, e As EventArgs) Handles btnRandomLotteryNumbers.Click
        Dim box = New LotteryNumbers()
        box.Show()
    End Sub

    Private Sub btnSeatingChart_Click(sender As Object, e As EventArgs) Handles btnSeatingChart.Click
        Dim box = New SeatingChart()
        box.Show()
    End Sub

    Private Sub btnFriendsList_Click(sender As Object, e As EventArgs) Handles btnFriendsList.Click
        Dim box = New Friends_List()
        box.Show()
    End Sub

    Private Sub btnLargestSmallest_Click(sender As Object, e As EventArgs)
        Dim box = New LargestSmallestArrays()
        box.Show()
    End Sub

    Private Sub btnFriendsList2_Click(sender As Object, e As EventArgs) Handles btnFriendsList2.Click
        Dim box = New Friends_List_2()
        box.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
