<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuDataUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDataTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCetakLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKategoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblTanggal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1206, 32)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(73, 25)
        Me.lblUser.Text = "Tanggal"
        '
        'lblTanggal
        '
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(47, 25)
        Me.lblTanggal.Text = "User"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDataUser, Me.mnuDataTransaksi, Me.DataKategoriToolStripMenuItem, Me.mnuCetakLaporan, Me.mnuKeluar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1206, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuDataUser
        '
        Me.mnuDataUser.Name = "mnuDataUser"
        Me.mnuDataUser.Size = New System.Drawing.Size(144, 29)
        Me.mnuDataUser.Text = "MASTER DATA"
        '
        'mnuDataTransaksi
        '
        Me.mnuDataTransaksi.Name = "mnuDataTransaksi"
        Me.mnuDataTransaksi.Size = New System.Drawing.Size(120, 29)
        Me.mnuDataTransaksi.Text = "TRANSAKSI"
        '
        'mnuCetakLaporan
        '
        Me.mnuCetakLaporan.Name = "mnuCetakLaporan"
        Me.mnuCetakLaporan.Size = New System.Drawing.Size(109, 29)
        Me.mnuCetakLaporan.Text = "LAPORAN"
        '
        'mnuKeluar
        '
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.Size = New System.Drawing.Size(90, 29)
        Me.mnuKeluar.Text = "KELUAR"
        '
        'DataKategoriToolStripMenuItem
        '
        Me.DataKategoriToolStripMenuItem.Name = "DataKategoriToolStripMenuItem"
        Me.DataKategoriToolStripMenuItem.Size = New System.Drawing.Size(158, 29)
        Me.DataKategoriToolStripMenuItem.Text = "DATA KATEGORI"
        '
        'frmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 571)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMenuUtama"
        Me.Text = "frmMenuUtama"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuDataUser As ToolStripMenuItem
    Friend WithEvents mnuDataTransaksi As ToolStripMenuItem
    Friend WithEvents mnuCetakLaporan As ToolStripMenuItem
    Friend WithEvents mnuKeluar As ToolStripMenuItem
    Friend WithEvents lblTanggal As ToolStripStatusLabel
    Friend WithEvents DataKategoriToolStripMenuItem As ToolStripMenuItem
End Class
