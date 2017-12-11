Public Class LargestSmallestArrays

    Private Sub btnStep1_Click(sender As Object, e As EventArgs) Handles btnStep1.Click
        'Create an array to hold the 10 numbers
        Const intMAX_SUBSCRIPT As Integer = 9    'The maximum subescript
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer 'array declaration
        Dim intCount As Integer           'Loop count

        'Tells the user what will happen
        MessageBox.Show("An input box will appear, please enter 10 numbers into the input boxes.")

        'get the numbers from the user
        For intCount = 0 To intMAX_SUBSCRIPT
            intNumbers(intCount) = InputBox("Enter a number.")
        Next

        'clear the list box of its current contents 
        lstValues.Items.Clear()

        'Display the contents of the array in the list box.
        For intCount = 0 To intMAX_SUBSCRIPT
            lstValues.Items.Add(intNumbers(intCount))
        Next
    End Sub
    Private Sub btnStep2_Click(sender As Object, e As EventArgs) Handles btnStep2.Click
        Const intMAX_SUBSCRIPT As Integer = 9    'The maximum subescript
        Dim intNumbers(intMAX_SUBSCRIPT) As Integer 'array declaration
        Dim intCount As Integer           'Loop count
        Dim intHighest As Integer    'to hold the highest value
        Dim intSmallest As Integer    'to hold the lowest value

        'get the first high value
        intHighest = intNumbers(intMAX_SUBSCRIPT)

        'search for the highest value.
        For intCount = 1 To (intNumbers.Length - 1)
            If intNumbers(intCount) > intHighest Then
                intHighest = intNumbers(intCount)
            End If
        Next

        lblHighest.Text = "The highest number is " & intHighest.ToString


        'get the first low value
        intSmallest = intNumbers(intMAX_SUBSCRIPT)

        'search for the lowest value
        For intCount = 1 To (intNumbers.Length - 1)
            If intNumbers(intCount) < intSmallest Then
                intSmallest = intNumbers(intCount)
            End If
        Next

        lblLowest.Text = "The smallest number is " & intSmallest.ToString
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Clear everything
        lstValues.Items.Clear()
        lblHighest.Text = String.Empty
        lblLowest.Text = String.Empty
    End Sub

End Class