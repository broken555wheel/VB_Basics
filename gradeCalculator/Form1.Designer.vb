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
        Label1 = New Label()
        btnCalculateGrade = New Button()
        txtBoxSubOne = New TextBox()
        txtBoxSubFour = New TextBox()
        txtBoxSubThree = New TextBox()
        txtBoxSubTwo = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(165, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 0
        Label1.Text = "Subject 1"
        ' 
        ' btnCalculateGrade
        ' 
        btnCalculateGrade.BackColor = SystemColors.ActiveCaption
        btnCalculateGrade.Location = New Point(147, 313)
        btnCalculateGrade.Name = "btnCalculateGrade"
        btnCalculateGrade.Size = New Size(75, 38)
        btnCalculateGrade.TabIndex = 1
        btnCalculateGrade.Text = "Calculate Grade"
        btnCalculateGrade.UseVisualStyleBackColor = False
        ' 
        ' txtBoxSubOne
        ' 
        txtBoxSubOne.Location = New Point(256, 72)
        txtBoxSubOne.Name = "txtBoxSubOne"
        txtBoxSubOne.Size = New Size(100, 23)
        txtBoxSubOne.TabIndex = 2
        ' 
        ' txtBoxSubFour
        ' 
        txtBoxSubFour.Location = New Point(256, 243)
        txtBoxSubFour.Name = "txtBoxSubFour"
        txtBoxSubFour.Size = New Size(100, 23)
        txtBoxSubFour.TabIndex = 4
        ' 
        ' txtBoxSubThree
        ' 
        txtBoxSubThree.Location = New Point(256, 185)
        txtBoxSubThree.Name = "txtBoxSubThree"
        txtBoxSubThree.Size = New Size(100, 23)
        txtBoxSubThree.TabIndex = 5
        ' 
        ' txtBoxSubTwo
        ' 
        txtBoxSubTwo.Location = New Point(256, 122)
        txtBoxSubTwo.Name = "txtBoxSubTwo"
        txtBoxSubTwo.Size = New Size(100, 23)
        txtBoxSubTwo.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(165, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 15)
        Label2.TabIndex = 7
        Label2.Text = "Subject 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(165, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 8
        Label3.Text = "Subject 4"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(165, 193)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 9
        Label4.Text = "Subject 3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtBoxSubTwo)
        Controls.Add(txtBoxSubThree)
        Controls.Add(txtBoxSubFour)
        Controls.Add(txtBoxSubOne)
        Controls.Add(btnCalculateGrade)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grade Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculateGrade As Button
    Friend WithEvents txtBoxSubOne As TextBox
    Friend WithEvents txtBoxSubFour As TextBox
    Friend WithEvents txtBoxSubThree As TextBox
    Friend WithEvents txtBoxSubTwo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
