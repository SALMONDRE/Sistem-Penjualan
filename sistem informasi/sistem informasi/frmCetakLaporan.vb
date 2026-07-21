Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmCetakLaporan

    Private Sub frmCetakLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Panggil fungsi koneksi dari modul Bapak
            Call Koneksi()
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            ' 2. Ambil seluruh data dari tabel Transaksi database
            Dim sql As String = "SELECT * FROM Transaksi"
            Dim Da As New SqlDataAdapter(sql, Conn)
            Dim dt As New DataTable()
            Da.Fill(dt)

            ' 3. Bersihkan data bawaan yang ada di ReportViewer sebelumnya
            ReportViewer1.LocalReport.DataSources.Clear()

            ' 4. Ikat DataTable hasil query ke DataSource ReportViewer 
            ' (Pastikan teks "DS_Transaksi" SAMA PERSIS dengan nama dataset rdlc kemarin)
            Dim rds As New ReportDataSource("DS_Transaksi", dt)
            ReportViewer1.LocalReport.DataSources.Add(rds)

            ' 5. Refresh dan jalankan render cetak laporan di layar
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat laporan: " & ex.Message, "Error Laporan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

End Class