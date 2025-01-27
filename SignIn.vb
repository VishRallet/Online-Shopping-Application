Imports MySql.Data.MySqlClient
Public Class SignIn
    Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        If AuthenticateUser(username, password) Then
            MessageBox.Show("Login successful!")
            Dim categoriesForm As New Categories(username)
            TextBox1.Text = ""
            TextBox2.Text = ""
            categoriesForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect username or password. Please try again.")
        End If
    End Sub
    Private Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"
        Dim count As Integer
        Try
            connection.Open()
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@password", password)
            count = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
        Return count > 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox2.PasswordChar = "*" Then
            TextBox2.PasswordChar = ControlChars.NullChar
        Else
            TextBox2.PasswordChar = "*"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        SignUp.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim email As String = InputBox("Enter your email-id: ")
        Dim phoneno As String = InputBox("Enter your phone number: ")
        If CheckUserExistence(email, phoneno) Then
            Dim password As String = RetrievePassword(email)
            MessageBox.Show("Your password is: " & password, "Password Recovery")
        Else
            MessageBox.Show("Invalid email or phone number.", "Error")
        End If
    End Sub
    Private Function CheckUserExistence(email As String, phoneno As String) As Boolean
        Dim userExists As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND Phoneno = @Phoneno"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Phoneno", phoneno)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    If count > 0 Then
                        userExists = True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking user existence: " & ex.Message, "Error")
        End Try
        Return userExists
    End Function
    Private Function RetrievePassword(email As String) As String
        Dim password As String = String.Empty
        Dim query As String = "SELECT Password FROM Users WHERE Email = @Email"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Email", email)
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        password = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving password: " & ex.Message, "Error")
                End Try
            End Using
        End Using
        Return password
    End Function
End Class
