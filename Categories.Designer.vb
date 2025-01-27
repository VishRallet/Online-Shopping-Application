<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categories
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
        ListBox1 = New ListBox()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Purple
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Yellow
        Button1.Location = New Point(159, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 40)
        Button1.TabIndex = 0
        Button1.Text = "Back To Home Page"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        Label1.Font = New Font("Cambria", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(12, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 40)
        Label1.TabIndex = 1
        Label1.Text = "Shop By Category"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ListBox1.Cursor = Cursors.Hand
        ListBox1.Font = New Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.ForeColor = Color.Purple
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 35
        ListBox1.Items.AddRange(New Object() {"Men's Fashion", "Women's Fashion", "Home Appliances", "Electronics", "Sports & Fitness", "Toys & Games"})
        ListBox1.Location = New Point(12, 130)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(367, 214)
        ListBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Purple
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(2, 25)
        Label2.TabIndex = 3
        ' 
        ' Categories
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(184), CByte(219), CByte(124))
        ClientSize = New Size(391, 450)
        Controls.Add(Label2)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        MaximizeBox = False
        Name = "Categories"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Categories"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
End Class
