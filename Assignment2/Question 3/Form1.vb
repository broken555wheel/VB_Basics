Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim principal As Double = 1000000 ' Original amount invested
        Dim annualInterestRate As Double = 0.05 ' Annual interest rate (5%)

        ' Display the header in the ListBox
        ListBox1.Items.Add("Year" & vbTab & "Amount")

        ' Calculate and display the amount for each year
        For year As Integer = 1 To 10
            Dim amount As Double = principal * (1 + annualInterestRate) ^ year
            ListBox1.Items.Add(year.ToString() & vbTab & amount.ToString("N2")) ' Display the amount with two decimal places
        Next
    End Sub
End Class
