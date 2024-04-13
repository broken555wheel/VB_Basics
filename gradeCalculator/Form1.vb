Public Class Form1
    Private Sub btnCalculateGrade_Click(sender As Object, e As EventArgs) Handles btnCalculateGrade.Click

        Dim grade1, grade2, grade3, grade4 As Integer
        Integer.TryParse(txtBoxSubOne.Text, grade1)
        Integer.TryParse(txtBoxSubTwo.Text, grade2)
        Integer.TryParse(txtBoxSubThree.Text, grade3)
        Integer.TryParse(txtBoxSubFour.Text, grade4)

        Dim average As Double = (grade1 + grade2 + grade3 + grade4) / 4

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


        MessageBox.Show("Average Grade: " & average.ToString() & vbCrLf & "Grade: " & grade, "Average Grade", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



End Class
