Imports System.Data.SqlClient

Public Class frmDataKategori

    Private Sub frmDataKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        TampilData()
    End Sub

    Sub TampilData()

        Call Koneksi()

        Da = New SqlDataAdapter("SELECT * FROM Kategori", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "Kategori")

        dgvKategori.DataSource = Ds.Tables("Kategori")

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        Call Koneksi()

        Conn.Open()

        Cmd = New SqlCommand("INSERT INTO Kategori VALUES (@kode,@nama,@ket)", Conn)

        Cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)
        Cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
        Cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)

        Cmd.ExecuteNonQuery()

        Conn.Close()

        MessageBox.Show("Data berhasil disimpan")

        TampilData()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Call Koneksi()

        Conn.Open()

        Cmd = New SqlCommand("UPDATE Kategori SET NamaKategori=@nama,Keterangan=@ket WHERE KodeKategori=@kode", Conn)

        Cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)
        Cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text)
        Cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text)

        Cmd.ExecuteNonQuery()

        Conn.Close()

        MessageBox.Show("Data berhasil diupdate")

        TampilData()

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Call Koneksi()

        Conn.Open()

        Cmd = New SqlCommand("DELETE FROM Kategori WHERE KodeKategori=@kode", Conn)

        Cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text)

        Cmd.ExecuteNonQuery()

        Conn.Close()

        MessageBox.Show("Data berhasil dihapus")

        TampilData()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtKodeKategori.Clear()
        txtNamaKategori.Clear()
        txtKeterangan.Clear()

        txtKodeKategori.Focus()

    End Sub

    Private Sub dgvKategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKategori.CellClick

        If e.RowIndex >= 0 Then

            txtKodeKategori.Text = dgvKategori.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtNamaKategori.Text = dgvKategori.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtKeterangan.Text = dgvKategori.Rows(e.RowIndex).Cells(2).Value.ToString()

        End If

    End Sub

End Class