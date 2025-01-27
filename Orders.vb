Imports MySql.Data.MySqlClient
Public Class Orders
    Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If AuthenticateUser(username, password) Then
            Button3.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button4.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            DataGridView1.Visible = True
            Try
                Using connection As New MySqlConnection(connectionString)
                    Dim query1 As String = "SELECT productbrand, productname, discountedPrice, selectedquantity, totalprice FROM orderdetails WHERE username = @username"
                    Dim command As New MySqlCommand(query1, connection)
                    command.Parameters.AddWithValue("@username", username)
                    connection.Open()
                    Dim dataTable As New DataTable()
                    Dim dataAdapter As New MySqlDataAdapter(command)
                    dataAdapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching orderdetails data: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Incorrect username or password!")
        End If
    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
        Dim count As Integer
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)
                count = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return count > 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Button4.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        DataGridView1.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = ControlChars.NullChar
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
End Class
