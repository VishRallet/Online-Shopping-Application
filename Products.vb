Imports MySql.Data.MySqlClient
Public Class Products
    Private connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Private Category As String
    Private username As String
    Private quantity As Integer
    Public Sub New(ByVal selectedCategory As String, ByVal username As String)
        InitializeComponent()
        Me.Category = selectedCategory
        Me.username = username
        PopulateProductNamesComboBox()
    End Sub
    Private Sub PopulateProductNamesComboBox()
        Dim queryString As String = "SELECT ProductName FROM Products WHERE Category = @Category;"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@Category", Category)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                ComboBox1.Items.Clear()
                While reader.Read()
                    ComboBox1.Items.Add(reader("ProductName").ToString())
                End While
            Catch ex As Exception
                MessageBox.Show("Error retrieving product names: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ComboBox2.Text = "Quantity:"
        Dim selectedProductName As String = ComboBox1.SelectedItem.ToString()
        Dim queryString As String = "SELECT ProductBrand, ProductName, Description, OriginalPrice, DiscountedPrice, quantity, ImagePath FROM Products WHERE ProductName = @ProductName;"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand(queryString, connection)
            command.Parameters.AddWithValue("@ProductName", selectedProductName)
            Try
                connection.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    Dim productBrand As String = reader("ProductBrand").ToString
                    Dim productName As String = reader("ProductName").ToString()
                    Dim description As String = reader("Description").ToString()
                    Dim originalPrice As Decimal = Convert.ToDecimal(reader("OriginalPrice"))
                    Dim discountedPrice As Decimal = Convert.ToDecimal(reader("DiscountedPrice"))
                    quantity = reader("quantity")
                    Dim imagePath As String = reader("ImagePath").ToString()
                    PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                    PictureBox1.Image = Image.FromFile(imagePath)
                    Label1.Text = productBrand
                    Label2.Text = productName
                    Label10.Text = "-" + ((originalPrice - discountedPrice) / originalPrice * 100).ToString("N") + "% Off"
                    Label3.Text = originalPrice.ToString("C")
                    Label4.Text = discountedPrice.ToString("C")
                    TextBox1.Text = description
                End If
            Catch ex As Exception
                MessageBox.Show("Error retrieving product details: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedQuantity As Integer = Convert.ToInt32(ComboBox2.SelectedItem)
        If username = "please Sign In/Up!" Then
            MessageBox.Show("Please Sign In before adding products to cart or purchase them!")
            SignIn.Show()
            Me.Hide()
        ElseIf ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please select a product from the list.")
        ElseIf ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please select the quantity.")
        ElseIf selectedQuantity > quantity Then
            MessageBox.Show("Selected quantity is not available.")
        Else
            Dim productBrand As String = Label1.Text
            Dim productName As String = Label2.Text
            Dim discountedPrice As Decimal = Decimal.Parse(Label4.Text, Globalization.NumberStyles.Currency)
            Dim totalPrice As Decimal = selectedQuantity * discountedPrice
            Dim queryString As String = "INSERT INTO Cart (ProductBrand, ProductName, discountedPrice, selectedQuantity, totalprice, username) VALUES (@ProductBrand, @ProductName, @discountedPrice, @selectedQuantity, @totalPrice, @username);"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(queryString, connection)
                    command.Parameters.AddWithValue("@ProductBrand", productBrand)
                    command.Parameters.AddWithValue("@ProductName", productName)
                    command.Parameters.AddWithValue("@discountedPrice", discountedPrice)
                    command.Parameters.AddWithValue("@selectedQuantity", selectedQuantity)
                    command.Parameters.AddWithValue("@totalPrice", totalPrice)
                    command.Parameters.AddWithValue("@username", username)
                    Try
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Product Added to Cart!")
                    Catch ex As Exception
                        MessageBox.Show("Error adding product to cart: " & ex.Message)
                    End Try
                End Using
            End Using
        End If
    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim categoriesForm As New Categories(username)
        categoriesForm.Show()
        Me.Hide()
    End Sub
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = "Welcome, " & username & "!"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If username = "please Sign In/Up" Then
            MessageBox.Show("Please Sign In before viewing the cart!")
            SignIn.Show()
            Me.Hide()
        Else
            Dim cartForm As New Cart(Category, username)
            cartForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
