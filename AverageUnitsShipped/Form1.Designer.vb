<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ftmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbDays = New System.Windows.Forms.Label()
        Me.lbAverageOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbUnitsDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(33, 29)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(34, 13)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "Units:"
        '
        'tbUnits
        '
        Me.tbUnits.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tbUnits.Location = New System.Drawing.Point(73, 26)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(67, 20)
        Me.tbUnits.TabIndex = 1
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnits, "Enter Units for the Day")
        '
        'lbDays
        '
        Me.lbDays.AutoSize = True
        Me.lbDays.Location = New System.Drawing.Point(168, 29)
        Me.lbDays.Name = "lbDays"
        Me.lbDays.Size = New System.Drawing.Size(35, 13)
        Me.lbDays.TabIndex = 2
        Me.lbDays.Text = "Day 1"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbDays, "Displays Current Day")
        '
        'lbAverageOutput
        '
        Me.lbAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbAverageOutput.Location = New System.Drawing.Point(33, 185)
        Me.lbAverageOutput.Name = "lbAverageOutput"
        Me.lbAverageOutput.Size = New System.Drawing.Size(215, 30)
        Me.lbAverageOutput.TabIndex = 4
        Me.lbAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lbAverageOutput, "Average Unit per Day")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(23, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Press to enter data")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(185, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Press to exit the form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(104, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Press to reset the form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'tbUnitsDisplay
        '
        Me.tbUnitsDisplay.Location = New System.Drawing.Point(23, 50)
        Me.tbUnitsDisplay.Multiline = True
        Me.tbUnitsDisplay.Name = "tbUnitsDisplay"
        Me.tbUnitsDisplay.ReadOnly = True
        Me.tbUnitsDisplay.Size = New System.Drawing.Size(232, 132)
        Me.tbUnitsDisplay.TabIndex = 8
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.tbUnitsDisplay, "Units per Day Display")
        '
        'ftmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.tbUnitsDisplay)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbAverageOutput)
        Me.Controls.Add(Me.lbDays)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ftmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUnits As Label
    Friend WithEvents tbUnits As TextBox
    Friend WithEvents lbDays As Label
    Friend WithEvents lbAverageOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
    Friend WithEvents tbUnitsDisplay As TextBox
End Class
