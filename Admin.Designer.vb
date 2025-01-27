<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Button1.TabIndex = 0
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 12F)
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(277, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 23)
        Label1.TabIndex = 1
        Label1.Text = "Admin ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 12F)
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(277, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 23)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(390, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(390, 45)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 27)
        TextBox2.TabIndex = 4
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
        Button2.TabIndex = 5
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
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
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 138)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(776, 300)
        DataGridView1.TabIndex = 12
        DataGridView1.Visible = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ComboBox1.DropDownHeight = 150
        ComboBox1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.ForeColor = Color.Purple
        ComboBox1.FormattingEnabled = True
        ComboBox1.IntegralHeight = False
        ComboBox1.Items.AddRange(New Object() {"Cart", "Users", "Orders", "Products", "Feedback", "OrderDetails"})
        ComboBox1.Location = New Point(340, 100)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(150, 31)
        ComboBox1.TabIndex = 13
        ComboBox1.Text = "Select View"
        ComboBox1.Visible = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Purple
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial Rounded MT Bold", 12F)
        Button4.ForeColor = Color.Yellow
        Button4.Location = New Point(12, 58)
        Button4.Name = "Button4"
        Button4.Size = New Size(160, 40)
        Button4.TabIndex = 14
        Button4.Text = "Save As Excel"
        Button4.UseVisualStyleBackColor = False
        Button4.Visible = False
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Admin"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
End Class
