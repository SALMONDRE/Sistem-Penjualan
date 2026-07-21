Imports System.Data.SqlClient

Public Class frmTransaksi

    Sub TampilData()
        Try
            Call Koneksi()
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            Dim sql As String = "SELECT * FROM Transaksi"
            Dim Da As New SqlDataAdapter(sql, Conn)
            Dim Ds As New DataSet
            Ds.Clear()

            Da.Fill(Ds, "Transaksi")
            dgvTransaksi.DataSource = Ds.Tables("Transaksi")

        Catch ex As Exception
            MessageBox.Show("Error tampil data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Memperbaiki logika penutupan koneksi yang aman
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub frmTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' Hitung otomatis perkalian jumlah dan harga
        txtTotal.Text = (Val(txtJumlah.Text) * Val(txtHarga.Text)).ToString()
    End Sub

    Sub SimpanData()
        Try
            Call Koneksi()
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

            ' Query aman menggunakan kurung siku mencocokkan struktur tabel SQL kamu
            Dim sql As String = "INSERT INTO Transaksi ([Tanggal], [NamaBarang], [Jumlah], [Harga], [Total]) VALUES (@tgl, @nama, @jml, @hrg, @tot)"

            Using Cmd As New SqlCommand(sql, Conn)
                Cmd.Parameters.AddWithValue("@tgl", dtpTanggal.Value.Date)
                Cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text)
                Cmd.Parameters.AddWithValue("@jml", Convert.ToInt32(Val(txtJumlah.Text)))
                Cmd.Parameters.AddWithValue("@hrg", Convert.ToInt32(Val(txtHarga.Text)))
                Cmd.Parameters.AddWithValue("@tot", Convert.ToInt32(Val(txtTotal.Text)))

                Cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data transaksi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Gagal simpan data: " & ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ' Validasi sebelum menyimpan data
        If txtNamaBarang.Text = "" Or txtJumlah.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Semua inputan transaksi harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Jika total masih kosong, hitung otomatis dahulu
        If txtTotal.Text = "" Or Val(txtTotal.Text) = 0 Then
            txtTotal.Text = (Val(txtJumlah.Text) * Val(txtHarga.Text)).ToString()
        End If

        SimpanData()
    End Sub

    Sub ClearForm()
        txtNamaBarang.Clear()
        txtJumlah.Clear()
        txtHarga.Clear()
        txtTotal.Clear()
        dtpTanggal.Value = DateTime.Now
        txtNamaBarang.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

End Class
