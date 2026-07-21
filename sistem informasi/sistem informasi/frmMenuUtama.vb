Public Class frmMenuUtama

    ' Event saat Form Menu Utama pertama kali dimuat
    Private Sub frmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menampilkan nama user dan waktu sistem pada label di bawah
        lblUser.Text = "User : Admin"
        lblTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss")
    End Sub

    ' Event untuk membuka Form Data User
    Private Sub mnuDataUser_Click(sender As Object, e As EventArgs) Handles mnuDataUser.Click
        frmDataUser.Show()
    End Sub

    ' Event untuk membuka Form Transaksi (Sudah diperbaiki nama komponennya)
    Private Sub mnuDataTransaksi_Click(sender As Object, e As EventArgs) Handles mnuDataTransaksi.Click
        ' Membuka Form Transaksi dengan metode ShowDialog agar fokus dan aman
        frmTransaksi.ShowDialog()
    End Sub

    ' Event untuk menu Laporan (Pertemuan berikutnya)
    Private Sub mnuCetakLaporan_Click(sender As Object, e As EventArgs) Handles mnuCetakLaporan.Click
        frmCetakLaporan.ShowDialog()
    End Sub

    ' Event untuk menutup aplikasi secara aman
    Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
        If MessageBox.Show("Yakin ingin keluar aplikasi ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DataKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKategoriToolStripMenuItem.Click
        frmDataKategori.Show()
    End Sub
End Class
