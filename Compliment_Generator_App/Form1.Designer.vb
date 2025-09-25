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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        buttonGenerate = New Button()
        textbox_Name = New TextBox()
        labelName = New Label()
        listboxCategories = New ListBox()
        labelCategory = New Label()
        SuspendLayout()
        ' 
        ' buttonGenerate
        ' 
        buttonGenerate.BackColor = Color.Orchid
        buttonGenerate.Font = New Font("Century Gothic", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        buttonGenerate.ForeColor = Color.Purple
        buttonGenerate.Location = New Point(12, 12)
        buttonGenerate.Name = "buttonGenerate"
        buttonGenerate.Size = New Size(234, 60)
        buttonGenerate.TabIndex = 0
        buttonGenerate.Text = "Give me a compliment!"
        buttonGenerate.UseVisualStyleBackColor = False
        ' 
        ' textbox_Name
        ' 
        textbox_Name.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        textbox_Name.Location = New Point(108, 81)
        textbox_Name.Name = "textbox_Name"
        textbox_Name.Size = New Size(138, 26)
        textbox_Name.TabIndex = 1
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelName.Location = New Point(12, 84)
        labelName.Name = "labelName"
        labelName.Size = New Size(90, 20)
        labelName.TabIndex = 2
        labelName.Text = "Your name:"
        ' 
        ' listboxCategories
        ' 
        listboxCategories.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        listboxCategories.FormattingEnabled = True
        listboxCategories.Items.AddRange(New Object() {"Confidence-Boosting", "Gentle Encouragement", "Fun & Silly"})
        listboxCategories.Location = New Point(12, 152)
        listboxCategories.Name = "listboxCategories"
        listboxCategories.Size = New Size(234, 64)
        listboxCategories.TabIndex = 3
        ' 
        ' labelCategory
        ' 
        labelCategory.AutoSize = True
        labelCategory.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labelCategory.Location = New Point(12, 120)
        labelCategory.Name = "labelCategory"
        labelCategory.Size = New Size(234, 20)
        labelCategory.TabIndex = 4
        labelCategory.Text = "Desired Compliment Category:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(265, 233)
        Controls.Add(labelCategory)
        Controls.Add(listboxCategories)
        Controls.Add(labelName)
        Controls.Add(textbox_Name)
        Controls.Add(buttonGenerate)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Compliment Generator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents buttonGenerate As Button
    Friend WithEvents textbox_Name As TextBox
    Friend WithEvents labelName As Label
    Friend WithEvents listboxCategories As ListBox
    Friend WithEvents labelCategory As Label

End Class
