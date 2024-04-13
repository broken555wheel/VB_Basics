Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateMultiplicationTable()
    End Sub

    Private Sub GenerateMultiplicationTable()
        Dim tableText As String = ""

        ' Generate the header row
        tableText &= "Multiplication Table" & vbCrLf
        tableText &= "*  " & vbTab & "1" & vbTab & "2" & vbTab & "3" & vbTab & "4" & vbTab & "5" & vbTab & "6" & vbTab & "7" & vbCrLf

        ' Generate the rest of the table
        For i As Integer = 1 To 7
            tableText &= i.ToString() & "  " & vbTab ' Row header (adjusting spacing)
            For j As Integer = 1 To 7
                Dim result As String = (i * j).ToString()
                ' Adjust spacing for alignment
                If result.Length < 2 Then
                    tableText &= result & " " & vbTab ' Add extra space for single-digit numbers
                Else
                    tableText &= result & vbTab ' Normal spacing for two-digit numbers
                End If
            Next
            tableText &= vbCrLf ' Move to the next row
        Next

        ' Display the table in the text box
        RichTextBox1.Text = tableText
    End Sub
End Class
