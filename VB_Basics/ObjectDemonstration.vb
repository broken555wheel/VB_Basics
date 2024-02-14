Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class ObjectDemonstration

    Inherits Form

    Public Sub New()
        InitializeComponent()

        Me.FormBorderStyle = FormBorderStyle.None

        Dim customTitleBar As New Panel()
        customTitleBar.Dock = DockStyle.Top
        customTitleBar.BackColor = Color.White
        customTitleBar.Height = 20

        Dim titleTextLabel As New Label()
        titleTextLabel.Text = Me.Text
        titleTextLabel.ForeColor = Color.Black
        titleTextLabel.TextAlign = ContentAlignment.MiddleCenter
        titleTextLabel.Dock = DockStyle.Fill

        customTitleBar.Controls.Add(titleTextLabel)
        Me.Controls.Add(customTitleBar)
    End Sub

    Private Sub ObjectDemonstration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbBold.Font = New Font(cbBold.Font, FontStyle.Bold)
        cbItalic.Font = New Font(cbItalic.Font, FontStyle.Italic)
        cbBoldItalic.Font = New Font(cbBoldItalic.Font, FontStyle.Bold Or FontStyle.Italic)
    End Sub
    Private Sub rbFont_CheckedChanged(sender As Object, e As EventArgs) Handles rbGaramond.CheckedChanged, rbMagneto.CheckedChanged, rbTahoma.CheckedChanged
        Dim radioButton As RadioButton = CType(sender, RadioButton)

        If radioButton.Checked Then
            Select Case radioButton.Name
                Case "rbGaramond"
                    ChangeFont("Garamond", 12)
                Case "rbMagneto"
                    ChangeFont("Magneto", 12)
                Case "rbTahoma"
                    ChangeFont("Tahoma", 12)
            End Select
        End If
    End Sub

    Private Sub ChangeFont(fontName As String, fontSize As Integer)
        TextBox.Font = New Font(fontName, fontSize)
    End Sub
    Private Sub cbBold_CheckedChanged(sender As Object, e As EventArgs) Handles cbBold.CheckedChanged
        ApplyFontStyle()
    End Sub

    Private Sub cbItalic_CheckedChanged(sender As Object, e As EventArgs) Handles cbItalic.CheckedChanged
        ApplyFontStyle()
    End Sub

    Private Sub cbBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles cbBoldItalic.CheckedChanged
        ApplyFontStyle()
    End Sub

    Private Sub ApplyFontStyle()
        Dim fontStyle As FontStyle = FontStyle.Regular

        If cbBold.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If cbItalic.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        TextBox.Font = New Font(TextBox.Font, fontStyle)
    End Sub

    Private Sub rbColor_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged, rbBlue.CheckedChanged, rbRed.CheckedChanged
        Dim radioButton As RadioButton = CType(sender, RadioButton)

        If radioButton.Checked Then
            Select Case radioButton.Name
                Case "rbGreen"
                    TextBox.ForeColor = Color.Green
                Case "rbBlue"
                    TextBox.ForeColor = Color.Blue
                Case "rbRed"
                    TextBox.ForeColor = Color.Red
            End Select
        End If
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPicture.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try

                odPictureBox.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub odExitButton_Click(sender As Object, e As EventArgs) Handles odExitButton.Click
        Me.Hide()

        Dim welcomeForm As New WelcomingForm()

        welcomeForm.Show()
    End Sub
End Class