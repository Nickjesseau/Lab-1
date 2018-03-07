'Name:                Average Units Shipped
'Author:              Nicholas Jesseau
'Date:                Feburary 7th, 2017
'Description:         A windows Form that is used to calculate the average
'                     units shipped per day for 7 days, with Validation.
'                     Then display the output to the user.
Option Strict On
Public Class ftmAverageUnitsShipped

    'Declarations'
    'Constants
    'Declaring last day
    Private lastDay As Integer = 7
    'Variables
    'Declaring for looping through the array
    Private currentIndex As Integer = 0
    'Declaring total for math equation
    Dim totalShipped As Integer = 0
    'The output of the math equation is stored here
    Dim averageShipped As Double = 0
    'Used for input validation
    Dim inputUnits As Integer = 0
    'Declaring the Array
    Private arrayUnits(6) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Code for the exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the form
        Me.Close()
    End Sub

    'Code for the reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Reset the output text box
        tbUnitsDisplay.ResetText()
        'Reset the average output
        lbAverageOutput.ResetText()
        'Clearing the total shipped
        totalShipped = 0
        'Resets the day to Day 1
        lbDays.Text = "Day 1"

        'For loop to reset the array
        For index As Integer = 0 To arrayUnits.Length - 1

            'Setting each element to 0
            arrayUnits(index) = 0

        Next

        'Setting enter button to active
        btnEnter.Enabled = True
        'Setting text box entry to active
        tbUnits.Enabled = True

        'setting the index to 0
        currentIndex = 0

        'Resets and focuses on input textbox
        tbUnits.ResetText()
        tbUnits.Focus()


    End Sub

    'Code for the enter button
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Input'
        'If statement to validate interger
        If (Not Integer.TryParse(tbUnits.Text, inputUnits)) Then
            'Message box displaying error message
            MessageBox.Show(" The number entered was not a whole number.")
            'Selecting the text and highlighting it
            tbUnits.SelectionStart = 0
            tbUnits.SelectionLength = tbUnits.Text.Length

            'If statement to validate range
        ElseIf ((inputUnits < 0) Or (inputUnits > 1000)) Then
            'Message box displaying error message
            MessageBox.Show("The number entered was not in the appropriate range.")
            'Selecting the text and highlighting it
            tbUnits.SelectionStart = 0
            tbUnits.SelectionLength = tbUnits.Text.Length

        Else
            'If statement to populate the array
            If currentIndex <= lastDay - 1 Then
                'Entering data into the array
                arrayUnits(currentIndex) = Convert.ToInt32(tbUnits.Text)
                'Adding the input to display
                tbUnitsDisplay.Text += arrayUnits(currentIndex) & vbCrLf
                'incrementing the index 
                currentIndex += 1
                'clearing text box inbetween days
                tbUnits.Clear()

                'Incrementing the days
                lbDays.Text = "Day " & Convert.ToString(currentIndex + 1)

                'If statement to start processing
                If currentIndex > lastDay - 1 Then

                    'Changing Days label to average
                    lbDays.Text = "Average"
                    'Setting enter button inactive
                    btnEnter.Enabled = False
                    'Setting text box units inactive
                    tbUnits.Enabled = False

                    'Processing'
                    'For loop to add the array
                    For index As Integer = 0 To arrayUnits.Length - 1
                        'Math for adding the array indexs
                        totalShipped = totalShipped + arrayUnits(index)

                    Next
                    'Dividing by array length
                    averageShipped = totalShipped / lastDay

                    'Output'
                    lbAverageOutput.Text = "Average per day: " & averageShipped.ToString("n2")
                End If
            End If
        End If
    End Sub
End Class
