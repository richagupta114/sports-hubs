Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Public Class Form3
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




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        'Validate Email
        Dim emailRegex As New Regex("^[A-Za-z0-9]+(.|_)+[A-Za-z0-9]+@+gmail.com$")
        Dim emailValid As Boolean = emailRegex.IsMatch(Guna2TextBox2.Text.Trim)

        If Not emailValid Then
            MessageBox.Show("Invalid email address.")

        End If

        'Validate Phone Number
        Dim phoneRegex As New Regex("\d{4}-\d{3}-\d{4}")
        Dim phoneValid As Boolean = phoneRegex.IsMatch(Guna2TextBox3.Text.Trim)

        If Not phoneValid Then
            MessageBox.Show("Invalid phone number.")
            Return
        End If

        'Validate Name
        Dim nameRegex As New Regex("^[a-zA-Z\s]+$")
        Dim nameValid As Boolean = nameRegex.IsMatch(Guna2TextBox1.Text.Trim)

        If Not nameValid Then
            MessageBox.Show("Invalid name.")
            Return
        End If

        MessageBox.Show("All input values are valid.")

        If Guna2TextBox1.Text = "" Or Guna2TextBox2.Text = "" Or Guna2TextBox3.Text = "" Or Guna2TextBox4.Text = "" Or Guna2TextBox5.Text = "" Then
            MessageBox.Show("All Fields are mandatory!")
        End If

        If Guna2TextBox4.Text = Guna2TextBox5.Text Then
            sql = "insert into employee(username,Email_id,Phone_no,emp_pass) Values ('" & Guna2TextBox1.Text & "','" & Guna2TextBox2.Text & "','" & Guna2TextBox3.Text & "','" & Guna2TextBox5.Text & "') "

            connect()

            MessageBox.Show("Signup Successfull")
            Me.Close()
            Form8.Show()
        End If
    End Sub
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox4.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=330;password=Momosr0568#;database=spm"
    End Sub
End Class

