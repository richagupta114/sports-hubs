Imports MySql.Data.MySqlClient

Public Class Form2
    Public conn As MySqlConnection = New MySqlConnection
    Public cmd As MySqlCommand = New MySqlCommand

    Public dr As MySqlDataReader
    Public sql, sql2, User As String
    Public dt As DataTable


    Public Sub connect()

        cmd.CommandText = sql

        cmd.CommandType = CommandType.Text

        cmd.Connection = conn

        conn.Open()
        dr = cmd.ExecuteReader



    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()

    End Sub

    Private Sub SIGNUP_Click(sender As Object, e As EventArgs) Handles SIGNUP.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click

        sql = "SELECT * FROM employee WHERE username = '" & Guna2TextBox1.Text & "' AND emp_pass= '" & Guna2TextBox2.Text & "' "

        connect()


        If dr.Read Then
            MsgBox("Login Successful")
            Me.Hide()
            Form4.Show()





        Else
            MsgBox("Invalid Username or Password")

        End If
        If Guna2TextBox1.Text = "Rahul" And Guna2TextBox2.Text = "r123" Then
            MsgBox("Loggedin as Admin")
            Me.Hide()
            Form8.show()
        End If

        conn.Close()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=330;password=Momosr0568#;database=spm"

    End Sub
End Class