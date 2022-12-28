Imports MySql.Data.MySqlClient
Public Class Form5
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
    End Sub
    Private Sub Buttonsave3_Click(sender As Object, e As EventArgs) Handles Buttonsave3.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String =
                "insert into garage.car values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "') "
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            MessageBox.Show("successfully added!")
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        load_table()
    End Sub

    Private Sub Buttonupdate3_Click(sender As Object, e As EventArgs) Handles Buttonupdate3.Click
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
                "update garage.car set car_id='" & TextBox1.Text & "',emp_id='" & TextBox2.Text & "',car_name='" & TextBox3.Text & "',car_regno='" & TextBox4.Text & "',
                car_colour='" & TextBox5.Text & "' where car_id='" & TextBox1.Text & "'"
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

    Private Sub Buttondelete3_Click(sender As Object, e As EventArgs) Handles Buttondelete3.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Insert Car ID!")
                Exit Try
            End If
            connection.Open()
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Dim query As String =
                "delete from garage.car where car_id='" & TextBox1.Text & "'"
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
    Private Sub Buttonview2_Click(sender As Object, e As EventArgs) Handles Buttonview2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        'Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try
            connection.Open()
            Dim query As String = "Select * from car"
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
    Private Sub load_table()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Try
            connection.Open()
            Dim query As String = "Select * from car"
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

            TextBox1.Text = row.Cells("car_id").Value.ToString
            TextBox2.Text = row.Cells("emp_id").Value.ToString
            TextBox3.Text = row.Cells("car_name").Value.ToString
            TextBox4.Text = row.Cells("car_regno").Value.ToString
            TextBox5.Text = row.Cells("car_colour").Value.ToString

        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim dv As New DataView(dataset)
        dv.RowFilter = String.Format("car_name like '%{0}%'", TextBox6.Text)
        BunifuCustomDataGrid1.DataSource = dv

    End Sub


End Class