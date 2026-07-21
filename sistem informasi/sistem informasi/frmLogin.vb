Imports System.Data.SqlClient

Public Class frmLogin

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader

    Dim strKoneksi As String =
        "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBUser;Integrated Security=True"

    Sub Koneksi()

        If conn Is Nothing Then
            conn = New SqlConnection(strKoneksi)
        End If

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"

    End Sub

    Private Sub chkTampilPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkTampilPassword.CheckedChanged

        If chkTampilPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Koneksi()

        cmd = New SqlCommand(
            "SELECT * FROM UserLogin WHERE Username=@user AND Password=@pass",
            conn)

        cmd.Parameters.AddWithValue("@user", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

        dr = cmd.ExecuteReader()

        If dr.HasRows Then

            MessageBox.Show("Login Berhasil")

            dr.Close()

            frmMenuUtama.Show()
            Me.Hide()

        Else

            MessageBox.Show("Username atau Password Salah")

            dr.Close()

        End If

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()

    End Sub

End Class
