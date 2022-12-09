'' Marwah Nur Shafira - 2107411008

Imports System.Net.Mime.MediaTypeNames
Imports System.IO

Public Class InfoKoleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            'If String.IsNullOrEmpty(Perpustakaan.dataPerpustakaan.GSFoto) Then
            PicFoto.Load(Perpustakaan.dataPerpustakaan.GSFoto)
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        LblNamaKoleksi.Text = Perpustakaan.dataPerpustakaan.GSNama
        LblJenisKoleksi.Text = Perpustakaan.dataPerpustakaan.GSJenis
        LblDeskripsi.Text = Perpustakaan.dataPerpustakaan.GSDeskripsi
        LblPenerbit.Text = Perpustakaan.dataPerpustakaan.GSPenerbit
        LblTahunTerbit.Text = Perpustakaan.dataPerpustakaan.GSTahunTerbit
        LblLokasiRak.Text = Perpustakaan.dataPerpustakaan.GSLokasiRak
        LblTanggalMasukKoleksi.Text = Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi
        LblStock.Text = Perpustakaan.dataPerpustakaan.GSStock
        LblBahasa.Text = Perpustakaan.dataPerpustakaan.GSBahasa

        ' ListBoxKoleksi.Items.Clear()

        For Each kel In Perpustakaan.dataPerpustakaan.GSKategori
            ListBoxKoleksi.Items.Add(kel)
        Next
        Perpustakaan.dataPerpustakaan.GSKategori.Clear()

    End Sub

    Private Sub BtnTutup_Click(sender As Object, e As EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

End Class