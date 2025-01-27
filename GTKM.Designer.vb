<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GTKM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GTKM))
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Cambria", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 45)
        Label1.TabIndex = 0
        Label1.Text = "Get To Know Me.."
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(380, 210)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.myself
        PictureBox1.Location = New Point(408, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(380, 380)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(12, 280)
        Label3.Name = "Label3"
        Label3.Size = New Size(380, 110)
        Label3.TabIndex = 3
        Label3.Text = "The main motive of choosing this topic as my Software Engineering Project is to help people shop from their comfortable space and providing them excellenrt services and shopping experience."
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F)
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(12, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 40)
        Button1.TabIndex = 4
        Button1.Text = "Back To Home Page"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12F)
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(242, 398)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 40)
        Button2.TabIndex = 5
        Button2.Text = "Get In Touch"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' GTKM
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "GTKM"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "GTKM"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
