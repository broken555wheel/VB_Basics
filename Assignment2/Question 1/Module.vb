Imports Microsoft.VisualBasic

Module FormUtilities
    Sub ResizeForm(ByVal form As Form)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        form.Width = screenWidth * 0.75 ' Three-quarters of the screen width
        form.Height = screenHeight * 0.5 ' Half of the screen height

        ' Reposition the form to the top-left corner of the screen
        form.Location = New Point(0, 0)
    End Sub
End Module
