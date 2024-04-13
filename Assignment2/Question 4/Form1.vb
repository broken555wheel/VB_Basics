Public Class Form1
    Private Sub GetNextCharacterButton_Click(sender As Object, e As EventArgs) Handles GetNextCharacterButton.Click
        ' Prompt the user to enter a character
        Dim inputChar As String = InputBox("Enter a character:", "Input")

        ' Call the function to get the next character
        Dim nextChar As String = GetNextCharacter(inputChar)

        ' Display the result in a MessageBox
        MessageBox.Show("The next character after " & inputChar & " is " & nextChar, "Next Character")
    End Sub

    ' Function to return the character following the input character
    Private Function GetNextCharacter(inputChar As String) As String
        ' Get the ASCII value of the input character
        Dim asciiValue As Integer = Asc(inputChar)

        ' Increment the ASCII value by 1 to get the ASCII value of the next character
        Dim nextAsciiValue As Integer = asciiValue + 1

        ' Convert the ASCII value back to a character
        Dim nextChar As String = Chr(nextAsciiValue)

        ' Return the next character
        Return nextChar
    End Function
End Class

