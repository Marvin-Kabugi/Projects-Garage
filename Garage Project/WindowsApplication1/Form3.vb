Imports MySql.Data.MySqlClient
Public Class Form3
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim dataset As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Buttonsave1_Click_1(sender As Object, e As EventArgs) Handles Buttonsave1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String =
                "insert into garage.emp values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "') "
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

    Private Sub Buttonupdate1_Click_1(sender As Object, e As EventArgs) Handles Buttonupdate1.Click
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
                "update garage.emp set emp_id='" & TextBox1.Text & "',emp_name='" & TextBox2.Text & "',designation='" & TextBox3.Text & "',year_of_birth='" & TextBox4.Text & "',
                gender='" & TextBox5.Text & "',phone_number='" & TextBox6.Text & "' where emp_id='" & TextBox1.Text & "'"
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

    Private Sub Buttondelete1_Click_1(sender As Object, e As EventArgs) Handles Buttondelete1.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            If TextBox1.Text = "" Then
                MessageBox.Show("Insert employee ID!")

                Exit Try

            End If
            connection.Open()

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then

                Dim query As String =
                "delete from garage.emp where emp_id='" & TextBox1.Text & "'"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                MessageBox.Show("successfully deleted!")
            Else
                Exit Sub
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()

        End Try
        'load_table()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim sda As New MySqlDataAdapter
        'Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try

            connection.Open()
            Dim query As String = "Select * from emp"
            command = New MySqlCommand(query, connection)
            sda.SelectCommand = command
            sda.Fill(dataset)
            bsource.DataSource = dataset
            BunifuCustomDataGrid2.DataSource = bsource
            sda.Update(dataset)
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

            connection.Dispose()

            'BunifuCustomDataGrid2.Enabled = Enabled
        End Try
    End Sub

    Private Sub BunifuCustomDataGrid2_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid2.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.BunifuCustomDataGrid2.Rows(e.RowIndex)

            TextBox1.Text = row.Cells("emp_id").Value.ToString
            TextBox2.Text = row.Cells("emp_name").Value.ToString
            TextBox3.Text = row.Cells("designation").Value.ToString
            TextBox4.Text = row.Cells("year_of_birth").Value.ToString
            TextBox5.Text = row.Cells("gender").Value.ToString
            TextBox6.Text = row.Cells("phone_number").Value.ToString

        End If
    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Dim dv As New DataView(dataset)
        dv.RowFilter = String.Format("emp_name like '%{0}%'", TextBox7.Text)
        BunifuCustomDataGrid2.DataSource = dv
    End Sub


End Class


'Private Sub Buttonsave1_Click(sender As Object, e As EventArgs)
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        connection.Open()
'        Dim query As String =
'            "insert into garage.emp values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "') "
'        command = New MySqlCommand(query, connection)
'        reader = command.ExecuteReader
'        MessageBox.Show("successfully added!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()

'    End Try
'    'load_table()
'End Sub

'Private Sub Buttonupdate1_Click(sender As Object, e As EventArgs)
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
'            "update garage.emp set emp_id='" & TextBox1.Text & "',emp_name='" & TextBox2.Text & "',designation='" & TextBox3.Text & "',year_of_birth='" & TextBox4.Text & "',
'            gender='" & TextBox5.Text & "',phone_number='" & TextBox6.Text & "' where emp_id='" & TextBox1.Text & "'"
'        command = New MySqlCommand(query, connection)
'        reader = command.ExecuteReader
'        MessageBox.Show("successfully updated!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()

'    End Try
'    'load_table()

'End Sub

'Private Sub Buttondelete1_Click(sender As Object, e As EventArgs)
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        If TextBox1.Text = "" Then
'            MessageBox.Show("Insert employee ID!")

'            Exit Try

'        End If
'        connection.Open()

'        Dim dialog As DialogResult
'        dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
'        If dialog = DialogResult.Yes Then

'            Dim query As String =
'            "delete from garage.emp where emp_id='" & TextBox1.Text & "'"
'            command = New MySqlCommand(query, connection)
'            reader = command.ExecuteReader
'            MessageBox.Show("successfully deleted!")
'        Else
'            Exit Sub
'        End If
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()

'    End Try
'    'load_table()

'End Sub

'Private Sub Buttonview_Click(sender As Object, e As EventArgs)
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim sda As New MySqlDataAdapter
'    'Dim dataset As New DataTable
'    Dim bsource As New BindingSource

'    Try

'        connection.Open()
'        Dim query As String = "Select * from emp"
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
'Private Sub load_table()
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim sda As New MySqlDataAdapter
'    'Dim dataset As New DataTable
'    Dim bsource As New BindingSource

'    Try
'        connection.Open()
'        Dim query As String = "Select * from emp"
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

'Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
'    If e.RowIndex >= 0 Then
'        Dim row As DataGridViewRow
'        row = Me.BunifuCustomDataGrid1.Rows(e.RowIndex)

'        TextBox1.Text = row.Cells("emp_id").Value.ToString
'        TextBox2.Text = row.Cells("emp_name").Value.ToString
'        TextBox3.Text = row.Cells("designation").Value.ToString
'        TextBox4.Text = row.Cells("year_of_birth").Value.ToString
'        TextBox5.Text = row.Cells("gender").Value.ToString
'        TextBox6.Text = row.Cells("phone_number").Value.ToString

'    End If
'End Sub

'Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)
'    Dim dv As New DataView(dataset)
'    dv.RowFilter = String.Format("emp_name like '%{0}%'", TextBox7.Text)
'    BunifuCustomDataGrid1.DataSource = dv
'End Sub



'Private Sub BunifuCustomDataGrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
'    If e.RowIndex >= 0 Then
'        Dim row As DataGridViewRow
'        row = Me.BunifuCustomDataGrid2.Rows(e.RowIndex)

'        TextBox1.Text = row.Cells("emp_id").Value.ToString
'        TextBox2.Text = row.Cells("emp_name").Value.ToString
'        TextBox3.Text = row.Cells("designation").Value.ToString
'        TextBox4.Text = row.Cells("year_of_birth").Value.ToString
'        TextBox5.Text = row.Cells("gender").Value.ToString
'        TextBox6.Text = row.Cells("phone_number").Value.ToString

'    End If
'End Sub

'Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)
'    Dim dv As New DataView(dataset)
'    dv.RowFilter = String.Format("emp_name like '%{0}%'", TextBox8.Text)
'    BunifuCustomDataGrid2.DataSource = dv
'End Sub
