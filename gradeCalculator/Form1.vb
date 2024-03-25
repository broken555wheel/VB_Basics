Public Class Form1
    Private Sub btnCalculateGrade_Click(sender As Object, e As EventArgs) Handles btnCalculateGrade.Click
        ' Variables to store grades
        Dim grade1, grade2, grade3, grade4 As Integer

        ' Parse grades from textboxes
        Integer.TryParse(txtBoxSubOne.Text, grade1)
        Integer.TryParse(txtBoxSubTwo.Text, grade2)
        Integer.TryParse(txtBoxSubThree.Text, grade3)
        Integer.TryParse(txtBoxSubFour.Text, grade4)

        ' Calculate average
        Dim average As Double = (grade1 + grade2 + grade3 + grade4) / 4

        ' Display average in a messagebox
        MessageBox.Show("Average Grade: " & average.ToString())

        ' Determine grade based on average
        Dim grade As String = ""
        If average >= 75 Then
            grade = "A"
        ElseIf average >= 65 Then
            grade = "B"
        ElseIf average >= 50 Then
            grade = "C"
        Else
            grade = "Fail"
        End If

        ' Display grade in a messagebox
        MessageBox.Show("Grade: " & grade)
    End Sub

End Class
