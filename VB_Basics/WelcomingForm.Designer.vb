<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomingForm
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
        Button1 = New Button()
        Exit_Button = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 253)
        Button1.Name = "Button1"
        Button1.Size = New Size(208, 57)
        Button1.TabIndex = 0
        Button1.Text = "Load Object Demo"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Exit_Button
        ' 
        Exit_Button.Location = New Point(453, 253)
        Exit_Button.Name = "Exit_Button"
        Exit_Button.Size = New Size(208, 57)
        Exit_Button.TabIndex = 1
        Exit_Button.Text = "Exit"
        Exit_Button.UseVisualStyleBackColor = True
        ' 
        ' WelcomingForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(798, 455)
        Controls.Add(Exit_Button)
        Controls.Add(Button1)
        Name = "WelcomingForm"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Private WithEvents Exit_Button As Button

End Class
