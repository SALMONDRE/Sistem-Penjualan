Imports System.Data.SqlClient

Module ModuleKoneksi
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Cmd As SqlCommand

    Sub Koneksi()
        Try
            ' Menggunakan server (localdb)\MSSQLLocalDB sesuai dengan SSMS kamu
            ' Database diarahkan ke DBUser (sesuai folder database di SSMS kamu)
            Dim str As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBUser;Integrated Security=True"

            Conn = New SqlConnection(str)
        Catch ex As Exception
            MessageBox.Show("Koneksi Modul Gagal: " & ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
