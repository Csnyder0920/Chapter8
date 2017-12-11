<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRandomLotteryNumbers = New System.Windows.Forms.Button()
        Me.btnSeatingChart = New System.Windows.Forms.Button()
        Me.btnLargestSmallest = New System.Windows.Forms.Button()
        Me.btnFriendsList = New System.Windows.Forms.Button()
        Me.btnFriendsList2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chapter 8 Program Menu"
        '
        'btnRandomLotteryNumbers
        '
        Me.btnRandomLotteryNumbers.Location = New System.Drawing.Point(65, 47)
        Me.btnRandomLotteryNumbers.Name = "btnRandomLotteryNumbers"
        Me.btnRandomLotteryNumbers.Size = New System.Drawing.Size(157, 23)
        Me.btnRandomLotteryNumbers.TabIndex = 1
        Me.btnRandomLotteryNumbers.Text = "Random Lottery Numbers"
        Me.btnRandomLotteryNumbers.UseVisualStyleBackColor = True
        '
        'btnSeatingChart
        '
        Me.btnSeatingChart.Location = New System.Drawing.Point(65, 76)
        Me.btnSeatingChart.Name = "btnSeatingChart"
        Me.btnSeatingChart.Size = New System.Drawing.Size(157, 23)
        Me.btnSeatingChart.TabIndex = 2
        Me.btnSeatingChart.Text = "Seating Chart"
        Me.btnSeatingChart.UseVisualStyleBackColor = True
        '
        'btnLargestSmallest
        '
        Me.btnLargestSmallest.Location = New System.Drawing.Point(65, 163)
        Me.btnLargestSmallest.Name = "btnLargestSmallest"
        Me.btnLargestSmallest.Size = New System.Drawing.Size(157, 23)
        Me.btnLargestSmallest.TabIndex = 3
        Me.btnLargestSmallest.Text = "Largest/Smallest Arrays"
        Me.btnLargestSmallest.UseVisualStyleBackColor = True
        '
        'btnFriendsList
        '
        Me.btnFriendsList.Location = New System.Drawing.Point(65, 105)
        Me.btnFriendsList.Name = "btnFriendsList"
        Me.btnFriendsList.Size = New System.Drawing.Size(157, 23)
        Me.btnFriendsList.TabIndex = 4
        Me.btnFriendsList.Text = "Friends List"
        Me.btnFriendsList.UseVisualStyleBackColor = True
        '
        'btnFriendsList2
        '
        Me.btnFriendsList2.Location = New System.Drawing.Point(65, 134)
        Me.btnFriendsList2.Name = "btnFriendsList2"
        Me.btnFriendsList2.Size = New System.Drawing.Size(157, 23)
        Me.btnFriendsList2.TabIndex = 5
        Me.btnFriendsList2.Text = "Friends List 2"
        Me.btnFriendsList2.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 321)
        Me.Controls.Add(Me.btnFriendsList2)
        Me.Controls.Add(Me.btnFriendsList)
        Me.Controls.Add(Me.btnLargestSmallest)
        Me.Controls.Add(Me.btnSeatingChart)
        Me.Controls.Add(Me.btnRandomLotteryNumbers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRandomLotteryNumbers As System.Windows.Forms.Button
    Friend WithEvents btnSeatingChart As System.Windows.Forms.Button
    Friend WithEvents btnLargestSmallest As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList As System.Windows.Forms.Button
    Friend WithEvents btnFriendsList2 As System.Windows.Forms.Button

End Class
