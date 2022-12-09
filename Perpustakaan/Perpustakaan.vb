'' Marwah Nur Shafira - 2107411008
Imports System.IO
Public Class Perpustakaan

    Public Shared dataPerpustakaan As DataPerpustakaan
    Public Shared listKoleksi As New List(Of String)

    Public Shared koleksiTerpilih As String

    Public Shared selectedTableKoleksi As Integer
    Public Shared selectedTableKoleksiNama As String

    Private selectedRow As DataGridViewRow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataPerpustakaan = New DataPerpustakaan()

        ReloadDataTableDatabase()
    End Sub


    Private Sub TambahKoleksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKoleksiToolStripMenuItem.Click
        Dim form_tambahKoleksi = New TambahKoleksi()
        form_tambahKoleksi.Show()
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs)

        If koleksiTerpilih = "" Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")

        Else
            Dim form_hapus = New HapusKoleksi()
            form_hapus.Show()

        End If

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs)
        Dim form_tambahKoleksi = New TambahKoleksi()
        form_tambahKoleksi.Show()
    End Sub


    Private Sub FormPerpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        '' Agar saat menambahkan koleksi, datanya tidak double
        ReloadDataTableDatabase()

        KoleksiBuku.Items.Clear()

        For Each koll In dataPerpustakaan.getKoleksiItem
            KoleksiBuku.Items.Add(koll)
        Next

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = dataPerpustakaan.GetDataKoleksiDatabase()
    End Sub

    Private Sub KoleksiBuku_Click(sender As Object, e As EventArgs) Handles KoleksiBuku.Click
        koleksiTerpilih = KoleksiBuku.SelectedItem()
    End Sub

    Private Sub BtnKurang_Click_1(sender As Object, e As EventArgs) Handles BtnKurang.Click
        If koleksiTerpilih = "" Then
            MessageBox.Show("Pilih koleksi yang ingin dihapus")

        Else
            Dim form_hapus = New HapusKoleksi()
            form_hapus.Show()

        End If
    End Sub

    Private Sub BtnTambah_Click_1(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Dim form_tambahKoleksi = New TambahKoleksi()
        form_tambahKoleksi.Show()
    End Sub

    Public Sub UpdateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In Perpustakaan.dataPerpustakaan.getKoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)}
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow

        Try
            selectedRow = DataGridKoleksi.Rows(index)
            'selectedTableKoleksi = DataGridKoleksi.CurrentRow.Index
            selectedTableKoleksi = selectedRow.Cells(0).Value
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
        Catch ex As Exception
            'MessageBox.Show(ex.ToString())
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataPerpustakaan.GSFoto = selectedKoleksi(2)

            dataPerpustakaan.GSNama = selectedKoleksi(1)
            dataPerpustakaan.GSJenis = selectedKoleksi(5)
            dataPerpustakaan.GSDeskripsi = selectedKoleksi(3)
            dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
            dataPerpustakaan.GSTahunTerbit = selectedKoleksi(6)
            dataPerpustakaan.GSLokasiRak = selectedKoleksi(7)
            dataPerpustakaan.GSTanggalMasukKoleksi = selectedKoleksi(8)
            dataPerpustakaan.GSStock = selectedKoleksi(9)
            dataPerpustakaan.GSBahasa = selectedKoleksi(10)
            dataPerpustakaan.GSKategori = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

            Dim infoTambah = New InfoKoleksi()
            infoTambah.Show()
        Catch ex As Exception
            MessageBox.Show("Please select data")
        End Try

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataPerpustakaan.GSFoto = selectedKoleksi(2)

            dataPerpustakaan.GSNama = selectedKoleksi(1)
            dataPerpustakaan.GSJenis = selectedKoleksi(5)
            dataPerpustakaan.GSDeskripsi = selectedKoleksi(3)
            dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
            dataPerpustakaan.GSTahunTerbit = selectedKoleksi(6)
            dataPerpustakaan.GSLokasiRak = selectedKoleksi(7)
            dataPerpustakaan.GSTanggalMasukKoleksi = selectedKoleksi(8)
            dataPerpustakaan.GSStock = selectedKoleksi(9)
            dataPerpustakaan.GSBahasa = selectedKoleksi(10)
            'Dim data_kategori As List(Of String) = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))
            dataPerpustakaan.GSKategori = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

            Dim formUpdate = New UpdateKoleksi()
            formUpdate.Show()
        Catch ex As Exception
            MessageBox.Show("Please Select Data")
        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataPerpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataPerpustakaan.GSFoto = selectedKoleksi(2)

            dataPerpustakaan.GSNama = selectedKoleksi(1)
            dataPerpustakaan.GSJenis = selectedKoleksi(5)
            dataPerpustakaan.GSDeskripsi = selectedKoleksi(3)
            dataPerpustakaan.GSPenerbit = selectedKoleksi(4)
            dataPerpustakaan.GSTahunTerbit = selectedKoleksi(6)
            dataPerpustakaan.GSLokasiRak = selectedKoleksi(7)
            dataPerpustakaan.GSTanggalMasukKoleksi = selectedKoleksi(8)
            dataPerpustakaan.GSStock = selectedKoleksi(9)
            dataPerpustakaan.GSBahasa = selectedKoleksi(10)
            'Dim data_kategori As List(Of String) = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))
            dataPerpustakaan.GSKategori = dataPerpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

            Dim formHapus = New HapusKoleksi()
            formHapus.Show()
        Catch ex As Exception
            MessageBox.Show("Please Select Data")
        End Try

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim form_login = New Login()
        Login.Show()

        Me.Close()
    End Sub

    Private Sub Perpustakaan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblDate.Text = Date.Now.ToString("dddd, dd MMMM yyyy")
        LblTime.Text = TimeOfDay
    End Sub
End Class
