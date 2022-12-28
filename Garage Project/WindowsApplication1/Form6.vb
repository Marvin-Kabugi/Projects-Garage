Imports MySql.Data.MySqlClient
Public Class Form6
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
    Private Sub Buttonsave4_Click(sender As Object, e As EventArgs) Handles Buttonsave4.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String =
                "insert into garage.stock values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "') "
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("successfully added!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        'load_table()
    End Sub

    Private Sub Buttonupdate4_Click(sender As Object, e As EventArgs) Handles Buttonupdate4.Click
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
                "update garage.stock set item_code='" & TextBox1.Text & "',item_name='" & TextBox2.Text & "',category='" & TextBox3.Text & "',quantity=quantity+'" & TextBox4.Text & "',
                buying_price='" & TextBox5.Text & "',selling_price='" & TextBox6.Text & "' where item_code='" & TextBox1.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("successfully updated!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        'load_table()
    End Sub



    Private Sub Buttondelete4_Click(sender As Object, e As EventArgs) Handles Buttondelete4.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Insert Item Code!")
                Exit Try
            End If
            connection.Open()
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Dim query As String =
                "delete from garage.stock where item_code='" & TextBox1.Text & "'"
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
        'load_table()
    End Sub

    Private Sub Buttonview3_Click(sender As Object, e As EventArgs) Handles Buttonview3.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        'Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try
            connection.Open()
            Dim query As String = "Select * from stock"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dataset)
            bsource.DataSource = dataset
            BunifuCustomDataGrid1.DataSource = bsource
            sda.Update(dataset)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.BunifuCustomDataGrid1.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("item_code").Value.ToString
            TextBox2.Text = row.Cells("item_name").Value.ToString
            TextBox3.Text = row.Cells("category").Value.ToString
            TextBox4.Text = row.Cells("quantity").Value.ToString
            TextBox5.Text = row.Cells("buying_price").Value.ToString
            TextBox6.Text = row.Cells("selling_price").Value.ToString

        End If
    End Sub
    'Private Sub load_table()
    '    connection = New MySqlConnection
    '    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
    '    Dim sda As New MySqlDataAdapter
    '    Dim bsource As New BindingSource
    '    Try
    '        connection.Open()
    '        Dim query As String = "Select * from stock"
    '        command = New MySqlCommand(query, connection)
    '        sda.SelectCommand = command
    '        sda.Fill(dataset)
    '        bsource.DataSource = dataset
    '        BunifuCustomDataGrid1.DataSource = bsource
    '        sda.Update(dataset)
    '        connection.Close()
    '    Catch ex As MySqlException
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        connection.Dispose()
    '    End Try
    'End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim dv As New DataView(dataset)
        dv.RowFilter = String.Format("item_name like '%{0}%'", TextBox7.Text)
        BunifuCustomDataGrid1.DataSource = dv
    End Sub


End Class

''Private Sub update1()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set item_code = '" & TextBox1.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub

''Private Sub update2()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set item_name= '" & TextBox2.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub
''Private Sub update3()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set category= '" & TextBox3.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub


''Private Sub update4()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set item_name='" & TextBox2.Text & "',category='" & TextBox3.Text & "', quantity = quantity+'" & TextBox4.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub

''Private Sub update5()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set buying_price= '" & TextBox5.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub

''Private Sub update6()
''    connection = New MySqlConnection
''    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
''    Dim reader As MySqlDataReader
''    Try
''        connection.Open()
''        Dim query As String = "update garage.stock set selling_price= '" & TextBox6.Text & "' where item_code='" & TextBox1.Text & "'"
''        Command = New MySqlCommand(query, connection)
''        reader = Command.ExecuteReader
''        connection.Close()
''    Catch ex As MySqlException
''        MessageBox.Show(ex.Message)
''    Finally
''        connection.Dispose()
''    End Try
''End Sub



