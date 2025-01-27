Imports MySql.Data.MySqlClient
Public Class Feedback
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please enter your Name and Email ID")
        ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MessageBox.Show("Please elect one option.")
            Label4.Focus()
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Please write some feedback.")
            TextBox3.Focus()
        Else
            Dim connectionString As String = "Server=127.0.0.1;Database=osdb;Uid=root;Pwd=2164@Vishal;"
            Dim query As String = "INSERT INTO Feedback (Name, Emailid, Rating, userfeed) VALUES (@Name, @Emailid, @Rating, @userfeed)"
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", TextBox1.Text)
                    command.Parameters.AddWithValue("@Emailid", TextBox2.Text)
                    command.Parameters.AddWithValue("@Rating", GetSelectedRating())
                    command.Parameters.AddWithValue("@userfeed", TextBox3.Text)
                    Try
                        connection.Open()
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Thank You for your feedback.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearFormFields()
                            Home.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Failed to submit feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error submitting feedback: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub
    Private Function GetSelectedRating() As String
        If RadioButton1.Checked Then
            Return "Dissatisfied"
        ElseIf RadioButton2.Checked Then
            Return "Neutral"
        ElseIf RadioButton3.Checked Then
            Return "Satisfied"
        End If
    End Function
    Private Sub ClearFormFields()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
    End Sub
    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
