<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargestSmallestArrays
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
        Me.btnStep1 = New System.Windows.Forms.Button()
        Me.btnStep2 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstValues = New System.Windows.Forms.ListBox()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.lblLowest = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStep1
        '
        Me.btnStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep1.Location = New System.Drawing.Point(25, 26)
        Me.btnStep1.Name = "btnStep1"
        Me.btnStep1.Size = New System.Drawing.Size(219, 30)
        Me.btnStep1.TabIndex = 0
        Me.btnStep1.Text = "Step 1: Input the Integers"
        Me.btnStep1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStep1.UseVisualStyleBackColor = True
        '
        'btnStep2
        '
        Me.btnStep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStep2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStep2.Location = New System.Drawing.Point(25, 76)
        Me.btnStep2.Name = "btnStep2"
        Me.btnStep2.Size = New System.Drawing.Size(219, 30)
        Me.btnStep2.TabIndex = 1
        Me.btnStep2.Text = "Step 2: Display Min and Max"
        Me.btnStep2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStep2.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(25, 123)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 30)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstValues
        '
        Me.lstValues.FormattingEnabled = True
        Me.lstValues.Location = New System.Drawing.Point(260, 26)
        Me.lstValues.Name = "lstValues"
        Me.lstValues.Size = New System.Drawing.Size(143, 173)
        Me.lstValues.TabIndex = 3
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHighest.Location = New System.Drawing.Point(55, 202)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(232, 23)
        Me.lblHighest.TabIndex = 6
        '
        'lblLowest
        '
        Me.lblLowest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLowest.Location = New System.Drawing.Point(55, 235)
        Me.lblLowest.Name = "lblLowest"
        Me.lblLowest.Size = New System.Drawing.Size(232, 23)
        Me.lblLowest.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Highest:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lowest:"
        '
        'LargestSmallestArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 272)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLowest)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lstValues)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStep2)
        Me.Controls.Add(Me.btnStep1)
        Me.Name = "LargestSmallestArrays"
        Me.Text = "LargestSmallestArrays"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStep1 As System.Windows.Forms.Button
    Friend WithEvents btnStep2 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstValues As System.Windows.Forms.ListBox
    Friend WithEvents lblHighest As System.Windows.Forms.Label
    Friend WithEvents lblLowest As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
