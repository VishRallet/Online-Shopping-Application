Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Public Class Admin
    Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "VishRallet" AndAlso TextBox2.Text = "2164" Then
            Button3.Visible = True
            Button4.Visible = True
            ComboBox1.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            DataGridView1.Visible = True
        Else
            MessageBox.Show("Invalid id or password!")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Visible = False
        Button4.Visible = False
        ComboBox1.Visible = False
        Button1.Visible = True
        Button2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        DataGridView1.Visible = False
        ComboBox1.Text = "Select View:"
        DataGridView1.DataSource = Nothing
        TextBox1.Text = ""
        TextBox2.Text = ""
        Home.Show()
        Hide()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim selectedTable As String = ComboBox1.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM " & selectedTable
        Dim dataTable As New DataTable()
        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error fetching data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView1.Rows.Count > 0 Then
            Using saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files|*.xlsx"
                saveFileDialog.Title = "Save as Excel File"
                saveFileDialog.FileName = "DataGridViewExport.xlsx"
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As New XLWorkbook()
                            Dim worksheet = workbook.Worksheets.Add("Sheet1")
                            For i As Integer = 1 To DataGridView1.Columns.Count
                                worksheet.Cell(1, i).Value = DataGridView1.Columns(i - 1).HeaderText
                            Next
                            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                                For j As Integer = 0 To DataGridView1.Columns.Count - 1
                                    Dim value = DataGridView1.Rows(i).Cells(j).Value
                                    worksheet.Cell(i + 2, j + 1).Value = If(value Is DBNull.Value, "", value.ToString())
                                Next
                            Next
                            workbook.SaveAs(saveFileDialog.FileName)
                            MessageBox.Show("Data exported successfully.")
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error exporting data: " & ex.Message)
                    End Try
                End If
            End Using
        Else
            MessageBox.Show("No data available to export.")
        End If
    End Sub
End Class
