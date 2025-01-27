Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Checkout
    Private Category As String
    Private username As String
    Private totalCartValue As Decimal
    Public Sub New(ByVal selectedCategory As String, ByVal username As String, ByVal totalCartValue As Decimal)
        InitializeComponent()
        Me.Category = selectedCategory
        Me.username = username
        Me.totalCartValue = totalCartValue
    End Sub
    Private Sub Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Text = "Order Total: " + totalCartValue.ToString("C")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cartForm As New Cart(Category, username)
        cartForm.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pattern As String = "^\d{6}$"
        If String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text) Then
            MessageBox.Show("Please fill in all required address fields.", "Incomplete Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Not Regex.IsMatch(TextBox4.Text, pattern) Then
                MessageBox.Show("Please enter a valid 6-digit pincode.", "Invalid Pincode", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox4.Focus()
                Return
            End If
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to confirm the address?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox4.Enabled = False
                TextBox5.Enabled = False
                Button3.Enabled = False
                GroupBox2.Visible = True
                RadioButton1.Visible = True
                RadioButton2.Visible = True
                RadioButton3.Visible = True
                Button4.Visible = True
            End If
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TextBox6.Visible = RadioButton1.Checked
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox7.Visible = RadioButton2.Checked
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pattern1 As String = "^\d{16}$"
        Dim pattern2 As String = "^\d{10}$"
        If Not RadioButton1.Checked AndAlso Not RadioButton2.Checked AndAlso Not RadioButton3.Checked Then
            MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf RadioButton1.Checked AndAlso TextBox6.Visible AndAlso String.IsNullOrEmpty(TextBox6.Text) Then
            MessageBox.Show("Please enter your card number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf RadioButton2.Checked AndAlso TextBox7.Visible AndAlso String.IsNullOrEmpty(TextBox7.Text) Then
            MessageBox.Show("Please enter your upi number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf RadioButton1.Checked AndAlso Not Regex.IsMatch(TextBox6.Text, pattern1) Then
            MessageBox.Show("Please enter a valid 16-digit card number.", "Invalid card number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox6.Focus()
            Return
        ElseIf RadioButton2.Checked AndAlso Not Regex.IsMatch(TextBox7.Text, pattern2) Then
            MessageBox.Show("Please enter a valid 10-digit upi number.", "Invalid upi number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox7.Focus()
            Return
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to confirm the payment?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                RadioButton1.Enabled = False
                RadioButton2.Enabled = False
                RadioButton3.Enabled = False
                TextBox6.Enabled = False
                TextBox7.Enabled = False
                Button4.Enabled = False
                Button1.Visible = True
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Your order will be placed!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If result = DialogResult.OK Then
            Dim userId As Integer = GetUserIdByUsername(username)
            Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "INSERT INTO Orders (userid, username, totalprice, street, City, State, PinCode, landmark, PaymentMethod, CardNumber, upinumber) VALUES (@userid, @username, @totalprice, @street, @City, @State, @PinCode, @landmark, @PaymentMethod, @CardNumber, @upinumber)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@userid", userId)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@totalprice", totalCartValue)
                    command.Parameters.AddWithValue("@Street", TextBox1.Text)
                    command.Parameters.AddWithValue("@City", TextBox2.Text)
                    command.Parameters.AddWithValue("@State", TextBox3.Text)
                    command.Parameters.AddWithValue("@PinCode", TextBox4.Text)
                    command.Parameters.AddWithValue("@Landmark", TextBox5.Text)
                    Dim paymentMethod As String
                    If RadioButton1.Checked Then
                        paymentMethod = "Card"
                        command.Parameters.AddWithValue("@CardNumber", TextBox6.Text)
                        command.Parameters.AddWithValue("@upiNumber", DBNull.Value)
                    ElseIf RadioButton2.Checked Then
                        paymentMethod = "Upi"
                        command.Parameters.AddWithValue("@upiNumber", TextBox7.Text)
                        command.Parameters.AddWithValue("@CardNumber", DBNull.Value)
                    Else
                        paymentMethod = "Cod"
                        command.Parameters.AddWithValue("@CardNumber", DBNull.Value)
                        command.Parameters.AddWithValue("@upiNumber", DBNull.Value)
                    End If
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("An error occurred while placing the order: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
            Dim query1 As String = "INSERT INTO OrderDetails (productBrand, ProductName, discountedPrice, SelectedQuantity, TotalPrice, username) " &
                                  "SELECT productBrand, ProductName, discountedPrice, SelectedQuantity, TotalPrice, username " & "FROM Cart WHERE Username = @Username;"
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Using cmd As New MySqlCommand(query1, conn)
                        cmd.Parameters.AddWithValue("@Username", username)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
            Dim query3 As String = "UPDATE Products AS p
                                    JOIN Cart AS c ON p.ProductName = c.ProductName
                                    SET p.quantity = p.quantity - c.SelectedQuantity;"
            Try
                Using conn As New MySqlConnection(connectionString)
                    conn.Open()
                    Using cmd As New MySqlCommand(query3, conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("qwerty: " & ex.Message)
            End Try
            Using connection As New MySqlConnection(connectionString)
                Dim query2 As String = "DELETE FROM Cart where username = @username"
                Dim command As New MySqlCommand(query2, connection)
                command.Parameters.AddWithValue("@username", username)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Error clearing cart: " & ex.Message)
                End Try
            End Using
            Feedback.Show()
            Me.Hide()
        End If
    End Sub
    Private Function GetUserIdByUsername(username As String) As Integer
        Dim userId As Integer
        Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT UserId FROM Users WHERE Username = @Username"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        userId = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred while fetching user ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
        Return userId
    End Function
End Class
