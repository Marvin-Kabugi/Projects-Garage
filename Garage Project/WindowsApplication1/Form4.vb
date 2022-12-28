Imports MySql.Data.MySqlClient
Public Class Form4
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim dataset As New DataTable
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Buttonsave2_Click(sender As Object, e As EventArgs) Handles Buttonsave2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String =
                "insert into garage.customer values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "') "
            command = New MySqlCommand(query, connection)
            reader = Command.ExecuteReader
            MessageBox.Show("successfully added!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        load_table()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Insert employee ID!")
                Exit Try
            End If
            connection.Open()
            Dim query As String =
                "update garage.customer set customer_id='" & TextBox1.Text & "',customer_name='" & TextBox2.Text & "',gender='" & TextBox3.Text & "',phone_number='" & TextBox4.Text & "',
                email_address='" & TextBox5.Text & "',car_id='" & TextBox6.Text & "' where customer_id='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("successfully updated!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub Buttondelete2_Click(sender As Object, e As EventArgs) Handles Buttondelete2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Insert customer ID!")
                Exit Try
            End If
            connection.Open()
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then

                Dim query As String =
                    "delete from garage.customer where customer_id='" & TextBox1.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            Else
                Exit Sub
            End If
            MessageBox.Show("successfully deleted!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.BunifuCustomDataGrid1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("customer_id").Value.ToString
            TextBox2.Text = row.Cells("customer_name").Value.ToString
            TextBox3.Text = row.Cells("gender").Value.ToString
            TextBox4.Text = row.Cells("phone_number").Value.ToString
            TextBox5.Text = row.Cells("email_address").Value.ToString
            TextBox6.Text = row.Cells("car_id").Value.ToString

        End If
    End Sub

    Private Sub Buttonview2_Click(sender As Object, e As EventArgs) Handles Buttonview2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        'Dim dataset As New DataTable
        Dim bsource As New BindingSource

        Try
            connection.Open()
            Dim query As String = "Select * from customer"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dataset)
            bsource.DataSource = dataset
            BunifuCustomDataGrid1.DataSource = bsource
            sda.Update(dataset)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub
    Private Sub load_table()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        'Dim dataset As New DataTable
        Dim bsource As New BindingSource

        Try
            connection.Open()
            Dim query As String = "Select * from customer"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dataset)
            bsource.DataSource = dataset
            BunifuCustomDataGrid1.DataSource = bsource
            sda.Update(dataset)

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

        Dim dv As New DataView(dataset)
        dv.RowFilter = String.Format("customer_name like '%{0}%'", TextBox7.Text)
        BunifuCustomDataGrid1.DataSource = dv
    End Sub
End Class
'Private Sub Buttonupdate2_Click(sender As Object, e As EventArgs) Handles Buttonupdate2.Click
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        If TextBox1.Text = "" Then
'            MessageBox.Show("Insert employee ID!")
'            Exit Try
'        End If
'        connection.Open()
'        Dim query As String =
'                "update garage.customer set customer_id='" & TextBox1.Text & "',customer_name='" & TextBox2.Text & "',gender='" & TextBox3.Text & "',phone_number='" & TextBox4.Text & "',
'                email_address='" & TextBox5.Text & "',car_id='" & TextBox6.Text & "' where customer_id='" & TextBox1.Text & "'"
'        Command = New MySqlCommand(query, connection)
'        reader = Command.ExecuteReader
'        MessageBox.Show("successfully updated!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'    load_table()
'End Sub