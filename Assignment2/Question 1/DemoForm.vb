Public Class DemoForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormUtilities.ResizeForm(Me) ' Call the ResizeForm sub procedure passing the current form object
    End Sub
End Class
