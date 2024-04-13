Public Class Form1
    Const WeeklyBasePay As Double = 2500
    Const Quota As Double = 1000
    Const CommissionRate As Double = 0.15

    Dim salesPeople As New List(Of Tuple(Of String, Double))

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If salesPeople.Count < 10 Then
            salesPeople.Add(New Tuple(Of String, Double)(NameTextBox.Text, CDbl(DailySalesTextBox.Text)))
            NameTextBox.Clear()
            DailySalesTextBox.Clear()
        Else
            MessageBox.Show("Maximum limit of 10 salespeople reached. Click Calculate to view their sales data", "Salesperson Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NameTextBox.Clear()
            DailySalesTextBox.Clear()
        End If
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ListBox1.Items.Clear()

        For Each person In salesPeople
            Dim name As String = person.Item1
            Dim dailySales As Double = person.Item2
            Dim weeklySales As Double = dailySales * 7
            Dim commission As Double = If(weeklySales > Quota, weeklySales * CommissionRate, 0)
            Dim weeklySalary As Double = WeeklyBasePay + commission

            ListBox1.Items.Add(name & ": Daily Sales: " & dailySales & ", Weekly Sales: " & weeklySales & ", Weekly Salary: " & weeklySalary)
        Next
    End Sub
End Class
