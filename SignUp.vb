Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types
Public Class SignUp
    Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Dim connection As New MySqlConnection(connectionString)
    Dim otp As String
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String = TextBox1.Text
        Dim lastName As String = TextBox2.Text
        Dim username As String = TextBox3.Text
        Dim email As String = TextBox4.Text
        Dim phoneNo As String = TextBox5.Text
        Dim password As String = TextBox6.Text
        Dim pattern As String = "^\d{10}$"
        If Not String.IsNullOrEmpty(username) AndAlso Not String.IsNullOrEmpty(password) AndAlso Not String.IsNullOrEmpty(email) AndAlso Not String.IsNullOrEmpty(firstName) AndAlso Not String.IsNullOrEmpty(lastName) AndAlso Not String.IsNullOrEmpty(phoneNo) Then
            If Not email.Contains("@gmail.com") Then
                MessageBox.Show("Please enter a valid email address.", "Invalid email-id", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox4.Focus()
                Return
            End If
            If Not Regex.IsMatch(phoneNo, pattern) Then
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox5.Focus()
                Return
            End If
            otp = GenerateOTP()
            SendOtp(phoneNo, otp)
            MessageBox.Show("OTP sent to your mobile number. Please enter it in the provided field to verify.")
            StoreUserDetails(firstName, lastName, username, email, phoneNo, password)
        Else
            MessageBox.Show("Please fill in all the fields!")
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim enteredOtp As String = TextBox7.Text
        If enteredOtp = otp Then
            Dim userDetails As (firstName As String, lastName As String, username As String, email As String, phoneNo As String, password As String) = RetrieveUserDetails()
            Dim query As String = "INSERT INTO Users (FirstName, LastName, Username, Email, PhoneNo, Password) VALUES (@FirstName, @LastName, @Username, @Email, @PhoneNo, @Password)"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FirstName", userDetails.firstName)
                    command.Parameters.AddWithValue("@LastName", userDetails.lastName)
                    command.Parameters.AddWithValue("@Username", userDetails.username)
                    command.Parameters.AddWithValue("@Email", userDetails.email)
                    command.Parameters.AddWithValue("@PhoneNo", userDetails.phoneNo)
                    command.Parameters.AddWithValue("@Password", userDetails.password)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Sign Up successful!")
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox3.Text = ""
                        TextBox4.Text = ""
                        TextBox5.Text = ""
                        TextBox6.Text = ""
                        SignIn.Show()
                        Me.Hide()
                    Catch ex As Exception
                        MessageBox.Show("Your account already exists, please sign in.")
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Invalid OTP. Please try again.")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        SignIn.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox6.PasswordChar = "*" Then
            TextBox6.PasswordChar = ControlChars.NullChar
        Else
            TextBox6.PasswordChar = "*"
        End If
    End Sub
    Private Function GenerateOTP() As String
        Dim rand As New Random()
        Dim otp As String = rand.Next(100000, 999999).ToString()
        Return otp
    End Function
    Private Sub SendOtp(phoneNo As String, otp As String)
        Dim accountSid As String = "ACf5a8f150d5f02e681a8ee29e58097400"
        Dim authToken As String = "cc2a2d7f0fef518a2dcc54e2d3c4b90b"
        TwilioClient.Init(accountSid, authToken)
        Dim toPhoneNumber As New PhoneNumber("+91" & phoneNo)
        Dim fromPhoneNumber As New PhoneNumber("+14849862092")
        Dim message = MessageResource.Create(
            body:="Your OTP is: " & otp,
            from:=fromPhoneNumber,
            to:=toPhoneNumber
        )
        MessageBox.Show("OTP sent to your mobile number.")
    End Sub
    Private userDetails As (String, String, String, String, String, String)
    Private Sub StoreUserDetails(firstName As String, lastName As String, username As String, email As String, phoneNo As String, password As String)
        userDetails = (firstName, lastName, username, email, phoneNo, password)
    End Sub
    Private Function RetrieveUserDetails() As (String, String, String, String, String, String)
        Return userDetails
    End Function
End Class
