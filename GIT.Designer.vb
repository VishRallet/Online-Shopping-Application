<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GIT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GIT))
        Button1 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(12, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 30)
        Button1.TabIndex = 0
        Button1.Text = "Back To Home Page"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(219, 408)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 30)
        Button2.TabIndex = 1
        Button2.Text = "Get To Know Me"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        Label3.Font = New Font("Arial Rounded MT Bold", 10.5F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Purple
        Label3.Location = New Point(12, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(348, 378)
        Label3.TabIndex = 4
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' GIT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(391, 450)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "GIT"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "GIT"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
