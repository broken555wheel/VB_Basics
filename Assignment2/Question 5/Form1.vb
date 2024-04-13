Public Class Form1
    Dim progress As Integer = 0

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ' Reset progress
        progress = 0
        ProgressBar.Value = 0
        ProgressLabel.Text = "Progress: 0%"

        ' Start the timer
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        ' Update progress
        progress += 10
        If progress > 100 Then
            progress = 100
        End If

        ' Update progress bar and label
        ProgressBar.Value = progress
        ProgressLabel.Text = "Progress: " & progress & "%"

        ' Check if process is complete
        If progress = 100 Then
            ' Stop the timer
            Timer.Enabled = False
            MessageBox.Show("Process completed!")
        End If
    End Sub
End Class

