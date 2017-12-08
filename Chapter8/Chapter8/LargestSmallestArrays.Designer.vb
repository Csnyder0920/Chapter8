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
        Me.lstInput = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
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
        Me.btnStep2.Location = New System.Drawing.Point(25, 75)
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
        Me.btnClear.Location = New System.Drawing.Point(25, 126)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(102, 30)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstInput
        '
        Me.lstInput.FormattingEnabled = True
        Me.lstInput.Location = New System.Drawing.Point(260, 26)
        Me.lstInput.Name = "lstInput"
        Me.lstInput.Size = New System.Drawing.Size(143, 173)
        Me.lstInput.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 228)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(391, 23)
        Me.lblResult.TabIndex = 4
        '
        'LargestSmallestArrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 260)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lstInput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStep2)
        Me.Controls.Add(Me.btnStep1)
        Me.Name = "LargestSmallestArrays"
        Me.Text = "LargestSmallestArrays"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStep1 As System.Windows.Forms.Button
    Friend WithEvents btnStep2 As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstInput As System.Windows.Forms.ListBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
