Imports MySql.Data.MySqlClient
Public Class Cart
    Private Category As String
    Private username As String
    Private totalCartValue As Decimal
    Public Sub New(ByVal selectedCategory As String, ByVal username As String)
        InitializeComponent()
        Me.Category = selectedCategory
        Me.username = username
    End Sub
    Private connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome, " & username & "!"
        FetchCartData()
        DisplayTotalCartValue()
    End Sub
    Private Sub FetchCartData()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT productbrand, productname, discountedPrice, selectedquantity, totalprice FROM Cart WHERE username = @username"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            Try
                connection.Open()
                Dim dataTable As New DataTable()
                Dim dataAdapter As New MySqlDataAdapter(command)
                dataAdapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error fetching cart data: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim productsForm As New Products(Category, username)
        productsForm.Show()
        Me.Hide()
    End Sub
    Private Sub DisplayTotalCartValue()
        totalCartValue = CalculateTotalCartValue()
        Label2.Text = "Total Cart Value: " + totalCartValue.ToString("C")
    End Sub
    Private Function CalculateTotalCartValue() As Decimal
        Dim totalValue As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                totalValue += Convert.ToDecimal(row.Cells("totalprice").Value)
            End If
        Next
        Return totalValue
    End Function
    Private Sub ClearCart()
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM Cart WHERE username = @username"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", username)
            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Cart has been cleared.")
                FetchCartData()
                DisplayTotalCartValue()
            Catch ex As Exception
                MessageBox.Show("Error clearing cart: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearCart()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If totalCartValue = 0 Then
            MessageBox.Show("Your VishRallet.com Cart is empty!")
        Else
            Dim checkoutForm As New Checkout(Category, username, totalCartValue)
            checkoutForm.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            Dim productName As String = selectedRow.Cells("productname").Value.ToString()
            Dim query As String = "DELETE FROM Cart WHERE productname = @productName AND username = @username"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@productName", productName)
                    command.Parameters.AddWithValue("@username", username)
                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Item removed from cart successfully.")
                            FetchCartData()
                            DisplayTotalCartValue()
                        Else
                            MessageBox.Show("Failed to remove item from cart.")
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error removing item from cart: " & ex.Message)
                    End Try
                End Using
            End Using
        Else
            MessageBox.Show("Please select a row to delete from the cart.")
        End If
    End Sub
End Class
