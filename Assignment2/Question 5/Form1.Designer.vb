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
        components = New ComponentModel.Container()
        ProgressBar = New ProgressBar()
        Timer = New Timer(components)
        ProgressLabel = New Label()
        StartButton = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(44, 194)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(279, 41)
        ProgressBar.TabIndex = 0
        ' 
        ' Timer
        ' 
        Timer.Interval = 1000
        ' 
        ' ProgressLabel
        ' 
        ProgressLabel.AutoSize = True
        ProgressLabel.Font = New Font("UbuntuMono Nerd Font Propo", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ProgressLabel.Location = New Point(44, 155)
        ProgressLabel.Name = "ProgressLabel"
        ProgressLabel.Size = New Size(129, 20)
        ProgressLabel.TabIndex = 1
        ProgressLabel.Text = "Progress: 0%"
        ProgressLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StartButton
        ' 
        StartButton.BackColor = SystemColors.Highlight
        StartButton.Font = New Font("UbuntuMono Nerd Font Mono", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StartButton.ForeColor = SystemColors.ControlLightLight
        StartButton.Location = New Point(199, 273)
        StartButton.Name = "StartButton"
        StartButton.Size = New Size(124, 49)
        StartButton.TabIndex = 2
        StartButton.Text = "Start"
        StartButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(StartButton)
        Controls.Add(ProgressLabel)
        Controls.Add(ProgressBar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Timer As Timer
    Friend WithEvents ProgressLabel As Label
    Friend WithEvents StartButton As Button

End Class
