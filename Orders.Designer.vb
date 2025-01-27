<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(405, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(405, 45)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F)
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(582, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 40)
        Button1.TabIndex = 2
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(288, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 23)
        Label1.TabIndex = 3
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(288, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Purple
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial Rounded MT Bold", 12F)
        Button3.ForeColor = Color.Yellow
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 40)
        Button3.TabIndex = 6
        Button3.Text = "Log Out"
        Button3.UseVisualStyleBackColor = False
        Button3.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = My.Resources.Resources.eye
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Location = New Point(536, 45)
        Button4.Name = "Button4"
        Button4.Size = New Size(40, 40)
        Button4.TabIndex = 7
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Arial Rounded MT Bold", 12F)
        Button2.ForeColor = Color.Yellow
        Button2.Location = New Point(688, 12)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 40)
        Button2.TabIndex = 8
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 88)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(776, 350)
        DataGridView1.TabIndex = 9
        DataGridView1.Visible = False
        ' 
        ' Orders
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        MaximizeBox = False
        Name = "Orders"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Orders"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
