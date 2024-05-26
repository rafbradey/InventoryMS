Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Login
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        'pan butnga ha screen
        Me.CenterToScreen()
        Me.CenterToParent()
        Me.Text = "Login"

    End Sub
    Private Sub loginBTN_Click(sender As Object, e As EventArgs) Handles loginBTN.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=@Mar2022108194; database=inventoryms"
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM inventoryms.users WHERE username = @username AND password = @password"
            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@username", usernameINPUT.Text)
            COMMAND.Parameters.AddWithValue("@password", passwordINPUT.Text)
            reader = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Login successful!")
                Me.Hide()
                Dashboard.Show()
            Else
                MessageBox.Show("Username and password do not match.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


End Class