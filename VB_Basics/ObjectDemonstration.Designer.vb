<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LoadPicture = New Button()
        odExitButton = New Button()
        TextBox = New TextBox()
        DisplayTest = New GroupBox()
        gbFont = New GroupBox()
        rbTahoma = New RadioButton()
        rbMagneto = New RadioButton()
        rbGaramond = New RadioButton()
        GroupBox2 = New GroupBox()
        rbRed = New RadioButton()
        rbBlue = New RadioButton()
        rbGreen = New RadioButton()
        gbFontStyle = New GroupBox()
        cbBoldItalic = New CheckBox()
        cbBold = New CheckBox()
        cbItalic = New CheckBox()
        odPictureBox = New PictureBox()
        DisplayTest.SuspendLayout()
        gbFont.SuspendLayout()
        GroupBox2.SuspendLayout()
        gbFontStyle.SuspendLayout()
        CType(odPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoadPicture
        ' 
        LoadPicture.Location = New Point(84, 518)
        LoadPicture.Name = "LoadPicture"
        LoadPicture.Size = New Size(139, 63)
        LoadPicture.TabIndex = 0
        LoadPicture.Text = "Load Picture"
        LoadPicture.UseVisualStyleBackColor = True
        ' 
        ' odExitButton
        ' 
        odExitButton.Location = New Point(632, 518)
        odExitButton.Name = "odExitButton"
        odExitButton.Size = New Size(139, 63)
        odExitButton.TabIndex = 1
        odExitButton.Text = "Exit"
        odExitButton.UseVisualStyleBackColor = True
        ' 
        ' TextBox
        ' 
        TextBox.Location = New Point(29, 36)
        TextBox.Name = "TextBox"
        TextBox.Size = New Size(139, 25)
        TextBox.TabIndex = 2
        TextBox.Text = "Sample Text"
        ' 
        ' DisplayTest
        ' 
        DisplayTest.Controls.Add(TextBox)
        DisplayTest.Location = New Point(39, 34)
        DisplayTest.Name = "DisplayTest"
        DisplayTest.Size = New Size(246, 97)
        DisplayTest.TabIndex = 3
        DisplayTest.TabStop = False
        DisplayTest.Text = "Display Test"
        ' 
        ' gbFont
        ' 
        gbFont.Controls.Add(rbTahoma)
        gbFont.Controls.Add(rbMagneto)
        gbFont.Controls.Add(rbGaramond)
        gbFont.Location = New Point(352, 34)
        gbFont.Name = "gbFont"
        gbFont.Size = New Size(435, 97)
        gbFont.TabIndex = 4
        gbFont.TabStop = False
        gbFont.Text = "Font"
        ' 
        ' rbTahoma
        ' 
        rbTahoma.AutoSize = True
        rbTahoma.Location = New Point(317, 40)
        rbTahoma.Name = "rbTahoma"
        rbTahoma.Size = New Size(74, 23)
        rbTahoma.TabIndex = 7
        rbTahoma.TabStop = True
        rbTahoma.Text = "Tahoma"
        rbTahoma.UseVisualStyleBackColor = True
        ' 
        ' rbMagneto
        ' 
        rbMagneto.AutoSize = True
        rbMagneto.Location = New Point(189, 40)
        rbMagneto.Name = "rbMagneto"
        rbMagneto.Size = New Size(83, 23)
        rbMagneto.TabIndex = 6
        rbMagneto.TabStop = True
        rbMagneto.Text = "Magneto"
        rbMagneto.UseVisualStyleBackColor = True
        ' 
        ' rbGaramond
        ' 
        rbGaramond.AutoSize = True
        rbGaramond.Location = New Point(45, 40)
        rbGaramond.Name = "rbGaramond"
        rbGaramond.Size = New Size(92, 23)
        rbGaramond.TabIndex = 5
        rbGaramond.TabStop = True
        rbGaramond.Text = "Garamond"
        rbGaramond.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(rbRed)
        GroupBox2.Controls.Add(rbBlue)
        GroupBox2.Controls.Add(rbGreen)
        GroupBox2.Location = New Point(623, 199)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(164, 227)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font Color"
        ' 
        ' rbRed
        ' 
        rbRed.AutoSize = True
        rbRed.Location = New Point(34, 168)
        rbRed.Name = "rbRed"
        rbRed.Size = New Size(50, 23)
        rbRed.TabIndex = 2
        rbRed.TabStop = True
        rbRed.Text = "Red"
        rbRed.UseVisualStyleBackColor = True
        ' 
        ' rbBlue
        ' 
        rbBlue.AutoSize = True
        rbBlue.Location = New Point(34, 116)
        rbBlue.Name = "rbBlue"
        rbBlue.Size = New Size(53, 23)
        rbBlue.TabIndex = 1
        rbBlue.TabStop = True
        rbBlue.Text = "Blue"
        rbBlue.UseVisualStyleBackColor = True
        ' 
        ' rbGreen
        ' 
        rbGreen.AutoSize = True
        rbGreen.Location = New Point(34, 65)
        rbGreen.Name = "rbGreen"
        rbGreen.Size = New Size(64, 23)
        rbGreen.TabIndex = 0
        rbGreen.TabStop = True
        rbGreen.Text = "Green"
        rbGreen.UseVisualStyleBackColor = True
        ' 
        ' gbFontStyle
        ' 
        gbFontStyle.Controls.Add(cbBoldItalic)
        gbFontStyle.Controls.Add(cbBold)
        gbFontStyle.Controls.Add(cbItalic)
        gbFontStyle.Location = New Point(386, 199)
        gbFontStyle.Name = "gbFontStyle"
        gbFontStyle.Size = New Size(168, 227)
        gbFontStyle.TabIndex = 6
        gbFontStyle.TabStop = False
        gbFontStyle.Text = "Font Style"
        ' 
        ' cbBoldItalic
        ' 
        cbBoldItalic.AutoSize = True
        cbBoldItalic.Location = New Point(38, 168)
        cbBoldItalic.Name = "cbBoldItalic"
        cbBoldItalic.Size = New Size(83, 23)
        cbBoldItalic.TabIndex = 2
        cbBoldItalic.Text = "BoldItalic"
        cbBoldItalic.UseVisualStyleBackColor = True
        ' 
        ' cbBold
        ' 
        cbBold.AutoSize = True
        cbBold.Location = New Point(38, 117)
        cbBold.Name = "cbBold"
        cbBold.Size = New Size(55, 23)
        cbBold.TabIndex = 1
        cbBold.Text = "Bold"
        cbBold.UseVisualStyleBackColor = True
        ' 
        ' cbItalic
        ' 
        cbItalic.AutoSize = True
        cbItalic.FlatStyle = FlatStyle.System
        cbItalic.Location = New Point(38, 66)
        cbItalic.Name = "cbItalic"
        cbItalic.Size = New Size(62, 24)
        cbItalic.TabIndex = 0
        cbItalic.Text = "Italic"
        cbItalic.UseVisualStyleBackColor = True
        ' 
        ' odPictureBox
        ' 
        odPictureBox.BorderStyle = BorderStyle.FixedSingle
        odPictureBox.Location = New Point(39, 187)
        odPictureBox.Name = "odPictureBox"
        odPictureBox.Size = New Size(287, 285)
        odPictureBox.TabIndex = 7
        odPictureBox.TabStop = False
        ' 
        ' ObjectDemonstration
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 17.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 646)
        Controls.Add(odPictureBox)
        Controls.Add(gbFontStyle)
        Controls.Add(GroupBox2)
        Controls.Add(gbFont)
        Controls.Add(DisplayTest)
        Controls.Add(odExitButton)
        Controls.Add(LoadPicture)
        Font = New Font("Segoe UI", 10.0F)
        Name = "ObjectDemonstration"
        RightToLeft = RightToLeft.No
        Text = "Object Demonstrations"
        DisplayTest.ResumeLayout(False)
        DisplayTest.PerformLayout()
        gbFont.ResumeLayout(False)
        gbFont.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        gbFontStyle.ResumeLayout(False)
        gbFontStyle.PerformLayout()
        CType(odPictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadPicture As Button
    Friend WithEvents odExitButton As Button
    Friend WithEvents TextBox As TextBox
    Friend WithEvents DisplayTest As GroupBox
    Friend WithEvents gbFont As GroupBox
    Friend WithEvents rbTahoma As RadioButton
    Friend WithEvents rbMagneto As RadioButton
    Friend WithEvents rbGaramond As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gbFontStyle As GroupBox
    Friend WithEvents cbBoldItalic As CheckBox
    Friend WithEvents cbBold As CheckBox
    Friend WithEvents cbItalic As CheckBox



    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents odPictureBox As PictureBox


End Class
