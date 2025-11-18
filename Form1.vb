Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As MySqlConnection
    Dim Commands As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root;password=root;"

        Try
            conn.Open()
            MessageBox.Show("Connected")
        Catch ex As Exception
            conn.Close()

        End Try
    End Sub
End Class
