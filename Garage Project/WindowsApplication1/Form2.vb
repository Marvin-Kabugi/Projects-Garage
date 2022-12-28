Imports MySql.Data.clients

Public Class Form2
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim dialog As DialogResult
        dialog = MessageBox.Show("do you want to logout?", "exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs)
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs)
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs)
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        Form7.Show()
        Me.Hide()
    End Sub
End Class