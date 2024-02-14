Public Class WelcomingForm
    Private Sub WelcomingForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub Exit_Button_Click(sender As Object, e As EventArgs) Handles Exit_Button.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objDemoForm As New ObjectDemonstration()
        Me.Hide()
        objDemoForm.Show()

    End Sub


End Class
