Imports MySql.Data.MySqlClient
Public Class Categories
    Private username As String
    Public Sub New(ByVal username As String)
        InitializeComponent()
        Me.username = username
    End Sub
    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Welcome, " & username & "!"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username = "please Sign In/Up!" Then
            Home.Show()
            Me.Hide()
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to go back to the home page? You will be Signed out.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Home.Show()
                Me.Hide()
            End If
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedCategory As String = ListBox1.SelectedItem.ToString()
        Dim Products As New Products(selectedCategory, username)
        Products.Show()
        Me.Hide()
    End Sub
End Class
