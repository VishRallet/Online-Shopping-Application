<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button6 = New Button()
        Button7 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(562, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 40)
        Button1.TabIndex = 0
        Button1.Text = "Sign In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(678, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(110, 40)
        Button2.TabIndex = 1
        Button2.Text = "Sign Up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Purple
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Yellow
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(120, 40)
        Button3.TabIndex = 2
        Button3.Text = "Products"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Purple
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.Yellow
        Button4.Location = New Point(452, 398)
        Button4.Name = "Button4"
        Button4.Size = New Size(180, 40)
        Button4.TabIndex = 3
        Button4.Text = "Get To Know Me"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Purple
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Yellow
        Button5.Location = New Point(638, 398)
        Button5.Name = "Button5"
        Button5.Size = New Size(150, 40)
        Button5.TabIndex = 4
        Button5.Text = "Get In Touch"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        Label1.Font = New Font("Bell MT", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(75, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(649, 42)
        Label1.TabIndex = 5
        Label1.Text = "Bringing the Mall to Your Fingertips..."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        Label2.Font = New Font("Algerian", 28.2F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(45, 150)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(9)
        Label2.Size = New Size(708, 71)
        Label2.TabIndex = 6
        Label2.Text = "Welcome To VishRallet.com"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Purple
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.ForeColor = Color.Yellow
        Button6.Location = New Point(138, 12)
        Button6.Name = "Button6"
        Button6.Size = New Size(130, 40)
        Button6.TabIndex = 7
        Button6.Text = "My Orders"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Purple
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.ForeColor = Color.Yellow
        Button7.Location = New Point(12, 398)
        Button7.Name = "Button7"
        Button7.Size = New Size(100, 40)
        Button7.TabIndex = 8
        Button7.Text = "Admin"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(800, 450)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Home"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button

End Class
