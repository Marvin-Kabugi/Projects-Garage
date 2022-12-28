Imports MySql.Data.MySqlClient
Public Class Form1
    Dim connection As MySqlConnection
    Dim command As MySqlCommand


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to exit the app", "exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then

            Application.ExitThread()
        End If

    End Sub
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String
            query = "select * from garage.login where username='" & Txtusername.Text & "' and password='" & Txtpassword.Text & "' "
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            Dim count As Integer = 0
            While reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("username and password correct")
                Form2.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect username and password")
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try


    End Sub







    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    TxtPassword.Clear()
    '    TxtUsername.Clear()
    'End Sub


End Class
