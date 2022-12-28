Imports MySql.Data.MySqlClient
Public Class Form7
    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
        Me.Hide()
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub


    Private Sub Buttonsave5_Click_1(sender As Object, e As EventArgs) Handles Buttonsave5.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader

        Try
            connection.Open()
            If TextBox1.Text = "" Then
                TextBox1.Text = ""
            ElseIf TextBox4.Text = vbEmpty Then
                TextBox4.Text = vbEmpty
            ElseIf TextBox3.Text = vbEmpty Then
                TextBox3.Text = vbEmpty
            Else
                Dim query As String =
                "insert into garage.bill values ('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "')"
                Dim x = TextBox1.Text
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
                MessageBox.Show("successfully added!")
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        min()
        min1()
        min2()
        min3()
        min4()
        min5()
        min6()
        min7()
        min8()
        minus()
        TextBox39.Text = (Val(TextBox6.Text) * Val(TextBox7.Text)) + (Val(TextBox10.Text) * Val(TextBox11.Text)) + (Val(TextBox14.Text) * Val(TextBox15.Text)) + (Val(TextBox18.Text) * Val(TextBox19.Text)) + (Val(TextBox22.Text) * Val(TextBox23.Text)) + (Val(TextBox26.Text) * Val(TextBox27.Text)) + (Val(TextBox30.Text) * Val(TextBox31.Text)) + (Val(TextBox34.Text) * Val(TextBox35.Text)) + Val(TextBox3.Text)
    End Sub
    Private Sub min()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()

            If TextBox5.Text = "" Then
                TextBox5.Text = ""
            ElseIf TextBox2.Text = vbEmpty Then
                TextBox2.Text = vbEmpty
            ElseIf TextBox6.Text = vbEmpty Then
                TextBox6.Text = vbEmpty
            ElseIf TextBox7.Text = vbEmpty Then
                TextBox7.Text = vbEmpty
            Else
                Dim query As String =
                "insert into garage.parts_ch values ('" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min1()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox9.Text = "" Then
                TextBox9.Text = ""
            ElseIf TextBox8.Text = vbEmpty Then
                TextBox8.Text = vbEmpty
            ElseIf TextBox10.Text = vbEmpty Then
                TextBox10.Text = vbEmpty
            ElseIf TextBox11.Text = vbEmpty Then
                TextBox11.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min2()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox13.Text = "" Then
                TextBox13.Text = ""
            ElseIf TextBox12.Text = vbEmpty Then
                TextBox12.Text = vbEmpty
            ElseIf TextBox14.Text = vbEmpty Then
                TextBox14.Text = vbEmpty
            ElseIf TextBox15.Text = vbEmpty Then
                TextBox15.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min3()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox17.Text = "" Then
                TextBox17.Text = ""
            ElseIf TextBox16.Text = vbEmpty Then
                TextBox16.Text = vbEmpty
            ElseIf TextBox18.Text = vbEmpty Then
                TextBox18.Text = vbEmpty
            ElseIf TextBox19.Text = vbEmpty Then
                TextBox19.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min4()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox21.Text = "" Then
                TextBox21.Text = ""
            ElseIf TextBox20.Text = vbEmpty Then
                TextBox20.Text = vbEmpty
            ElseIf TextBox22.Text = vbEmpty Then
                TextBox22.Text = vbEmpty
            ElseIf TextBox23.Text = vbEmpty Then
                TextBox23.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox23.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min5()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox25.Text = "" Then
                TextBox25.Text = ""
            ElseIf TextBox24.Text = vbEmpty Then
                TextBox24.Text = vbEmpty
            ElseIf TextBox26.Text = vbEmpty Then
                TextBox26.Text = vbEmpty
            ElseIf TextBox27.Text = vbEmpty Then
                TextBox27.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min6()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox29.Text = "" Then
                TextBox29.Text = ""
            ElseIf TextBox28.Text = vbEmpty Then
                TextBox28.Text = vbEmpty
            ElseIf TextBox30.Text = vbEmpty Then
                TextBox30.Text = vbEmpty
            ElseIf TextBox31.Text = vbEmpty Then
                TextBox31.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox31.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub min7()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox33.Text = "" Then
                TextBox33.Text = ""
            ElseIf TextBox32.Text = vbEmpty Then
                TextBox32.Text = vbEmpty
            ElseIf TextBox34.Text = vbEmpty Then
                TextBox34.Text = vbEmpty
            ElseIf TextBox35.Text = vbEmpty Then
                TextBox35.Text = vbEmpty
            Else
                Dim query As String = "insert into garage.parts_ch values ('" & TextBox33.Text & "','" & TextBox34.Text & "','" & TextBox35.Text & "')"

                command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub min8()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            If TextBox37.Text = "" Then
                TextBox37.Text = ""
            ElseIf TextBox36.Text = vbEmpty Then
                TextBox36.Text = vbEmpty
            ElseIf TextBox38.Text = vbEmpty Then
                TextBox38.Text = vbEmpty
            ElseIf TextBox39.Text = vbEmpty Then
                TextBox39.Text = vbEmpty
            Else
                'Dim query As String = "insert into garage.parts_ch values ('" & TextBox36.Text & "','" & TextBox37.Text & "','" & TextBox38.Text & "','" & TextBox39.Text & "')"

                'command = New MySqlCommand(query, connection)
                reader = command.ExecuteReader
            End If
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub

    Private Sub minus()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox6.Text & "' where item_name='" & TextBox5.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
        minus1()
        minus2()
        minus3()
        minus4()
        minus5()
        minus6()
        minus7()
    End Sub
    Private Sub minus1()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox10.Text & "' where item_name='" & TextBox9.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus2()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox14.Text & "' where item_name='" & TextBox13.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus3()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox18.Text & "' where item_name='" & TextBox17.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus4()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox22.Text & "' where item_name='" & TextBox21.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus5()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox26.Text & "' where item_name='" & TextBox25.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus6()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox30.Text & "' where item_name='" & TextBox29.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub minus7()
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
        Dim reader As MySqlDataReader
        Try
            connection.Open()
            Dim query As String = "update garage.stock Set quantity = quantity-'" & TextBox34.Text & "' where item_name='" & TextBox33.Text & "'"
            command = New MySqlCommand(query, connection)
            reader = command.ExecuteReader
            connection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtreceipt.Text = " "
        txtreceipt.AppendText("  " + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = Receipt = = = = = = = = = = = = = =  " + vbNewLine)
        txtreceipt.AppendText("= = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        txtreceipt.AppendText("  " + vbNewLine)

        txtreceipt.AppendText("  " + vbNewLine)
        txtreceipt.AppendText("Receipt No :" + vbTab & TextBox41.Text + vbTab + vbTab + vbNewLine)
        txtreceipt.AppendText("Customer Name :" + vbTab & TextBox42.Text + vbTab & "Customer ID :" + vbTab & TextBox45.Text + vbNewLine)
        txtreceipt.AppendText("Car Name :" + vbTab & TextBox43.Text + vbTab + vbTab & "Car Registration :" + vbTab & TextBox44.Text + vbNewLine)
        txtreceipt.AppendText("  " + vbNewLine)

        txtreceipt.AppendText("Part Name                Quantity                Price" + vbNewLine)
        txtreceipt.AppendText(TextBox5.Text + vbTab + "                     " & TextBox6.Text + vbTab + "                       " & TextBox7.Text + vbNewLine)
        txtreceipt.AppendText(TextBox9.Text + vbTab + "                     " & TextBox10.Text + vbTab + "                       " & TextBox11.Text + vbNewLine)
        txtreceipt.AppendText(TextBox13.Text + vbTab + "                     " & TextBox14.Text + vbTab + "                       " & TextBox15.Text + vbNewLine)
        txtreceipt.AppendText(TextBox17.Text + vbTab + "                     " & TextBox18.Text + vbTab + "                       " & TextBox19.Text + vbNewLine)
        txtreceipt.AppendText(TextBox21.Text + vbTab + "                     " & TextBox22.Text + vbTab + "                       " & TextBox23.Text + vbNewLine)
        txtreceipt.AppendText(TextBox25.Text + vbTab + "                     " & TextBox26.Text + vbTab + "                       " & TextBox27.Text + vbNewLine)
        txtreceipt.AppendText(TextBox29.Text + vbTab + "                     " & TextBox30.Text + vbTab + "                       " & TextBox31.Text + vbNewLine)
        txtreceipt.AppendText(TextBox33.Text + vbTab + "                     " & TextBox34.Text + vbTab + "                       " & TextBox35.Text + vbNewLine)
        txtreceipt.AppendText("  " + vbNewLine)
        txtreceipt.AppendText("Total :" + vbTab + vbTab & TextBox39.Text + vbTab + vbTab + vbNewLine)
        txtreceipt.AppendText("  " + vbNewLine)
        txtreceipt.AppendText("THANK YOU FOR CHOOSING OUR SERVICES, INCASE OF ANY INQUIRIES CONTACT : 0700474674")
    End Sub

    Private Sub TextBox41_TextChanged(sender As Object, e As EventArgs) Handles TextBox41.TextChanged
        TextBox41.Text = TextBox1.Text
    End Sub

    Private Sub TextBox40_TextChanged(sender As Object, e As EventArgs) Handles TextBox40.TextChanged
        TextBox40.Text = TextBox4.Text
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txtreceipt.Text, Font, Brushes.Black, 120, 120)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class

'Private Sub TextBox43_TextChanged(sender As Object, e As EventArgs) Handles TextBox43.TextChanged
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        connection.Open()

'        Dim query As String = "select car_name from garage.car where car_id= '" & TextBox40.Text & "'"

'        command = New MySqlCommand(query, connection)
'        reader = command.ExecuteReader
'        If TextBox40.Text = TextBox40.Text Then
'            TextBox43.Text = query
'        End If
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'End Sub

'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        connection.Open()

'        Dim query As String = "select car_name from garage.car where car_id=  '" & TextBox40.Text & "'"

'        command = New MySqlCommand(query, connection)
'        reader = command.ExecuteReader
'        If TextBox40.Text = TextBox40.Text Then
'            TextBox43.Text = query
'        End If
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'End Sub











'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'    Txtbxreceipt.Text = " "
'    Txtbxreceipt.AppendText("  " + vbNewLine)
'    Txtbxreceipt.AppendText("= = = = = = = = = = = = = = = =Receipt = = = = = = = = = = = = = = = =" + vbNewLine)

'End Sub


'Private Sub Button5_Click(sender As Object, e As EventArgs)
'    Form2.Show()
'    Me.Hide()
'    TextBox1.Clear()
'    TextBox2.Clear()
'    TextBox3.Clear()
'    TextBox4.Clear()
'    TextBox5.Clear()
'    TextBox6.Clear()
'End Sub


'Private Sub Buttonsave5_Click(sender As Object, e As EventArgs)
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        connection.Open()
'        Dim query As String =
'                "insert into garage.bill values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "') "
'        Command = New MySqlCommand(query, connection)
'        reader = Command.ExecuteReader
'        MessageBox.Show("successfully added!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'    minus()
'End Sub
'Private Sub Buttonupdate5_Click(sender As Object, e As EventArgs)
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
'            "update garage.bill set bill_no='" & TextBox1.Text & "',item_code='" & TextBox2.Text & "',mechanic_fee='" & TextBox3.Text & "',car_id='" & TextBox4.Text & "',
'            quantity_used='" & TextBox5.Text & "',parts_repaired='" & TextBox6.Text & "' where bill_no='" & TextBox1.Text & "'"
'        command = New MySqlCommand(query, connection)
'        reader = command.ExecuteReader
'        MessageBox.Show("successfully updated!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'End Sub
'Private Sub Buttondelete5_Click(sender As Object, e As EventArgs)
'    connection = New MySqlConnection
'    connection.ConnectionString = "server=localhost;userid=root;password=MultiTrillionare;database=garage"
'    Dim reader As MySqlDataReader
'    Try
'        If TextBox1.Text = "" Then
'            MessageBox.Show("Insert Bill Number!")
'            Exit Try
'        End If
'        connection.Open()
'        Dim dialog As DialogResult
'        dialog = MessageBox.Show("Do you want to delete?", "Delete!", MessageBoxButtons.YesNo)
'        If dialog = DialogResult.Yes Then
'            Dim query As String =
'            "delete from garage.bill where bill_no='" & TextBox1.Text & "'"
'            command = New MySqlCommand(query, connection)
'            reader = command.ExecuteReader
'        Else
'            Exit Sub
'        End If
'        MessageBox.Show("successfully deleted!")
'        connection.Close()
'    Catch ex As MySqlException
'        MessageBox.Show(ex.Message)
'    Finally
'        connection.Dispose()
'    End Try
'End Sub

''''''('" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "'),
''''''('" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox15.Text & "'),
''''''('" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "'),
''''''('" & TextBox20.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox23.Text & "'),
''''''('" & TextBox24.Text & "','" & TextBox25.Text & "','" & TextBox26.Text & "','" & TextBox27.Text & "'),
''''''('" & TextBox28.Text & "','" & TextBox29.Text & "','" & TextBox30.Text & "','" & TextBox31.Text & "'),
''''''('" & TextBox32.Text & "','" & TextBox33.Text & "','" & TextBox34.Text & "','" & TextBox35.Text & "'),
'''''''" & TextBox36.Text & "','" & TextBox37.Text & "','" & TextBox38.Text & "','" & TextBox39.Text & "')"