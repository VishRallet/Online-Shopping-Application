<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feedback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Feedback))
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F)
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(582, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 40)
        Button1.TabIndex = 0
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12F)
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(688, 398)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 40)
        Button2.TabIndex = 1
        Button2.Text = "Skip"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(12, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(12, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 23)
        Label2.TabIndex = 3
        Label2.Text = "Email ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(107, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(107, 50)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 5
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Arial Rounded MT Bold", 10.2F)
        RadioButton1.ForeColor = Color.Purple
        RadioButton1.Location = New Point(424, 139)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(128, 24)
        RadioButton1.TabIndex = 6
        RadioButton1.TabStop = True
        RadioButton1.Text = "Dissatisfied"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Arial Rounded MT Bold", 10.2F)
        RadioButton2.ForeColor = Color.Purple
        RadioButton2.Location = New Point(558, 139)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(91, 24)
        RadioButton2.TabIndex = 7
        RadioButton2.TabStop = True
        RadioButton2.Text = "Neutral"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Font = New Font("Arial Rounded MT Bold", 10.2F)
        RadioButton3.ForeColor = Color.Purple
        RadioButton3.Location = New Point(655, 139)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(103, 24)
        RadioButton3.TabIndex = 8
        RadioButton3.TabStop = True
        RadioButton3.Text = "Satisfied"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(366, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(422, 71)
        Label3.TabIndex = 10
        Label3.Text = "Please share your overall experience" & vbCrLf & "with this software. I value your feedback" & vbCrLf & "and strive to improve based on your input."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.ForeColor = Color.Purple
        Label4.Location = New Point(12, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(406, 23)
        Label4.TabIndex = 12
        Label4.Text = "How satisfied are you with this software?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Purple
        Label5.Location = New Point(12, 200)
        Label5.Name = "Label5"
        Label5.Size = New Size(729, 69)
        Label5.TabIndex = 13
        Label5.Text = resources.GetString("Label5.Text")
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 272)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(776, 100)
        TextBox3.TabIndex = 14
        ' 
        ' Feedback
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Feedback"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Feedback"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
