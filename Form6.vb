Imports MySql.Data.MySqlClient

Public Class Form6
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

    Private Sub Guna2HtmlLabel3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2vScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

        Guna2ComboBox1.Items.Add("Archery")
        Guna2ComboBox1.Items.Add("Badminton")
        Guna2ComboBox1.Items.Add("Baseball")
        Guna2ComboBox1.Items.Add("Basketball")
        Guna2ComboBox1.Items.Add("Boxing")
        Guna2ComboBox1.Items.Add("Car Racing")
        Guna2ComboBox1.Items.Add("Chess")
        Guna2ComboBox1.Items.Add("Cricket")
        Guna2ComboBox1.Items.Add("Diving")
        Guna2ComboBox1.Items.Add("Football")
        Guna2ComboBox1.Items.Add("Golf")
        Guna2ComboBox1.Items.Add("Hockey")
        Guna2ComboBox1.Items.Add("Ice Skating")
    End Sub

    Private Sub Guna2ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox2.SelectedIndexChanged
        If Guna2ComboBox1.SelectedItem = "Archery" Then
            Guna2ComboBox2.Items.Add("Arrows")
            Guna2ComboBox2.Items.Add("Arm Guard")
            Guna2ComboBox2.Items.Add("Bows")


        End If
        If Guna2ComboBox2.SelectedItem = "Arrows" Then
            Guna2TextBox2.Text = "100"
            TextBox1.Text = (Guna2TextBox2.Text) * (Guna2TextBox1.Text)
        ElseIf Guna2ComboBox2.SelectedItem = "Arm Guard" Then
            Guna2TextBox2.Text = "200"
            TextBox1.Text = (Guna2TextBox2.Text) * (Guna2TextBox1.Text)
        ElseIf Guna2ComboBox2.SelectedItem = "Bows" Then
            Guna2TextBox2.Text = "300"
            TextBox1.Text = (Guna2TextBox2.Text) * (Guna2TextBox1.Text)



        End If
        If Guna2ComboBox1.SelectedItem = "Badminton" Then
            Guna2ComboBox2.Items.Add("Rackets")
            Guna2ComboBox2.Items.Add("net")
            Guna2ComboBox2.Items.Add("Shuttlecock")
        End If



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "server=localhost;user id=root;port=330;password=Momosr0568#;database=spm"

    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Guna2TextBox1.KeyPress
        Dim a As Integer
        a = Guna2TextBox1.Text
    End Sub
End Class