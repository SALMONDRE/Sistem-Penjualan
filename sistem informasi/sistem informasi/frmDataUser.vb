Imports System.Data.SqlClient

Public Class frmDataUser

    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

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

    Sub TampilData()

        Koneksi()

        da = New SqlDataAdapter("SELECT * FROM UserLogin", conn)

        dt = New DataTable

        da.Fill(dt)

        dgvUser.DataSource = dt

    End Sub

    Sub ClearForm()

        txtIdUser.Clear()
        txtUsername.Clear()
        txtPassword.Clear()

        cmbLevel.SelectedIndex = -1

        chkStatus.Checked = False

        txtUsername.Focus()

    End Sub

    Private Sub frmDataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbLevel.Items.Add("Admin")
        cmbLevel.Items.Add("Staff")
        cmbLevel.Items.Add("Manager")

        TampilData()

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Dim statusUser As String

        If chkStatus.Checked = True Then
            statusUser = "Aktif"
        Else
            statusUser = "Tidak Aktif"
        End If

        Koneksi()

        Dim sql As String =
            "INSERT INTO UserLogin " &
            "(Username,Password,LevelUser,StatusAktif) " &
            "VALUES (@Username,@Password,@LevelUser,@StatusAktif)"

        cmd = New SqlCommand(sql, conn)

        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@LevelUser", cmbLevel.Text)
        cmd.Parameters.AddWithValue("@StatusAktif", statusUser)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil disimpan")

        TampilData()
        ClearForm()

    End Sub

    Private Sub dgvUser_CellClick(sender As Object,
                                  e As DataGridViewCellEventArgs) Handles dgvUser.CellClick

        If e.RowIndex >= 0 Then

            txtIdUser.Text = dgvUser.Rows(e.RowIndex).Cells("IdUser").Value.ToString()
            txtUsername.Text = dgvUser.Rows(e.RowIndex).Cells("Username").Value.ToString()
            txtPassword.Text = dgvUser.Rows(e.RowIndex).Cells("Password").Value.ToString()

            cmbLevel.Text = dgvUser.Rows(e.RowIndex).Cells("LevelUser").Value.ToString()

            If dgvUser.Rows(e.RowIndex).Cells("StatusAktif").Value.ToString() = "Aktif" Then
                chkStatus.Checked = True
            Else
                chkStatus.Checked = False
            End If

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim statusUser As String

        If chkStatus.Checked = True Then
            statusUser = "Aktif"
        Else
            statusUser = "Tidak Aktif"
        End If

        Koneksi()

        Dim sql As String =
            "UPDATE UserLogin SET " &
            "Username=@Username," &
            "Password=@Password," &
            "LevelUser=@LevelUser," &
            "StatusAktif=@StatusAktif " &
            "WHERE IdUser=@IdUser"

        cmd = New SqlCommand(sql, conn)

        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
        cmd.Parameters.AddWithValue("@LevelUser", cmbLevel.Text)
        cmd.Parameters.AddWithValue("@StatusAktif", statusUser)
        cmd.Parameters.AddWithValue("@IdUser", txtIdUser.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil diupdate")

        TampilData()
        ClearForm()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Koneksi()

        Dim sql As String =
            "DELETE FROM UserLogin WHERE IdUser=@IdUser"

        cmd = New SqlCommand(sql, conn)

        cmd.Parameters.AddWithValue("@IdUser", txtIdUser.Text)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Data berhasil dihapus")

        TampilData()
        ClearForm()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearForm()

    End Sub

End Class
