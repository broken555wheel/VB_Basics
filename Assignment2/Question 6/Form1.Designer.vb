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
        Label2 = New Label()
        NameTextBox = New TextBox()
        DailySalesTextBox = New TextBox()
        CalculateButton = New Button()
        ListBox1 = New ListBox()
        AddButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bahnschrift SemiLight", 10F)
        Label1.Location = New Point(35, 56)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 17)
        Label1.TabIndex = 0
        Label1.Text = "Sales Person's Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bahnschrift SemiLight", 10F)
        Label2.Location = New Point(98, 116)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 17)
        Label2.TabIndex = 1
        Label2.Text = "Daily Sales :"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Font = New Font("Bahnschrift SemiLight", 10F)
        NameTextBox.Location = New Point(203, 55)
        NameTextBox.Margin = New Padding(2, 2, 2, 2)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(164, 24)
        NameTextBox.TabIndex = 2
        ' 
        ' DailySalesTextBox
        ' 
        DailySalesTextBox.Font = New Font("Bahnschrift SemiLight", 10F)
        DailySalesTextBox.Location = New Point(203, 112)
        DailySalesTextBox.Margin = New Padding(2, 2, 2, 2)
        DailySalesTextBox.Name = "DailySalesTextBox"
        DailySalesTextBox.Size = New Size(164, 24)
        DailySalesTextBox.TabIndex = 3
        ' 
        ' CalculateButton
        ' 
        CalculateButton.BackColor = SystemColors.Highlight
        CalculateButton.Font = New Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CalculateButton.ForeColor = SystemColors.ButtonHighlight
        CalculateButton.Location = New Point(261, 221)
        CalculateButton.Margin = New Padding(2, 2, 2, 2)
        CalculateButton.Name = "CalculateButton"
        CalculateButton.Size = New Size(105, 31)
        CalculateButton.TabIndex = 4
        CalculateButton.Text = "Calculate"
        CalculateButton.UseVisualStyleBackColor = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(397, 55)
        ListBox1.Margin = New Padding(2, 2, 2, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(381, 199)
        ListBox1.TabIndex = 5
        ' 
        ' AddButton
        ' 
        AddButton.BackColor = SystemColors.Highlight
        AddButton.Font = New Font("Berlin Sans FB", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        AddButton.ForeColor = SystemColors.ButtonHighlight
        AddButton.Location = New Point(66, 221)
        AddButton.Margin = New Padding(2)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(105, 46)
        AddButton.TabIndex = 6
        AddButton.Text = "Next Salesperson"
        AddButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(785, 334)
        Controls.Add(AddButton)
        Controls.Add(ListBox1)
        Controls.Add(CalculateButton)
        Controls.Add(DailySalesTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DailySalesTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AddButton As Button

End Class
