<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        GetNextCharacterButton = New Button()
        RichTextBox1 = New RichTextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RichTextBox1)
        GroupBox1.Controls.Add(GetNextCharacterButton)
        GroupBox1.Font = New Font("Segoe UI", 10F)
        GroupBox1.Location = New Point(66, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(481, 329)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Get Next ASCII"
        ' 
        ' GetNextCharacterButton
        ' 
        GetNextCharacterButton.BackColor = SystemColors.MenuHighlight
        GetNextCharacterButton.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GetNextCharacterButton.ForeColor = SystemColors.ButtonHighlight
        GetNextCharacterButton.Location = New Point(233, 246)
        GetNextCharacterButton.Name = "GetNextCharacterButton"
        GetNextCharacterButton.Size = New Size(214, 54)
        GetNextCharacterButton.TabIndex = 2
        GetNextCharacterButton.Text = "Get Next Character"
        GetNextCharacterButton.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Location = New Point(21, 68)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.None
        RichTextBox1.Size = New Size(294, 134)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = "Clicking Get next character will display an input dialog then give you the next ascii character based on your input"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GetNextCharacterButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox

End Class
