<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Button4 = New Button()
        TextBox7 = New TextBox()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(12, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 23)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(12, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 23)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 12F)
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(12, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 23)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 12F)
        Label4.ForeColor = Color.Purple
        Label4.Location = New Point(12, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 23)
        Label4.TabIndex = 3
        Label4.Text = "Email ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 12F)
        Label5.ForeColor = Color.Purple
        Label5.Location = New Point(12, 280)
        Label5.Name = "Label5"
        Label5.Size = New Size(158, 23)
        Label5.TabIndex = 4
        Label5.Text = "Mobile Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(176, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(176, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(176, 176)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(176, 226)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(176, 276)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F)
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(201, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 40)
        Button1.TabIndex = 10
        Button1.Text = "Sign Up"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(12, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(220, 40)
        Button2.TabIndex = 11
        Button2.Text = "Back To Home Page"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Purple
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 12F)
        Button3.ForeColor = Color.Yellow
        Button3.Location = New Point(279, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 40)
        Button3.TabIndex = 12
        Button3.Text = "Sign In"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 12F)
        Label6.ForeColor = Color.Purple
        Label6.Location = New Point(12, 330)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 23)
        Label6.TabIndex = 13
        Label6.Text = "Password"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(176, 326)
        TextBox6.Name = "TextBox6"
        TextBox6.PasswordChar = "*"c
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Purple
        Button4.BackgroundImage = My.Resources.Resources.eye
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Location = New Point(307, 326)
        Button4.Name = "Button4"
        Button4.Size = New Size(40, 40)
        Button4.TabIndex = 15
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(12, 411)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 16
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(12, 376)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 17
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(391, 450)
        Controls.Add(Button5)
        Controls.Add(TextBox7)
        Controls.Add(Button4)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "SignUp"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button5 As Button
End Class
