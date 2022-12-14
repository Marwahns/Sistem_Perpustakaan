Imports System.IO
Imports System.Net.Mime.MediaTypeNames

Public Class UpdateKoleksi

    Dim max_char_deskripsi = 268
    Dim panjang_karakter = max_char_deskripsi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            If Not String.IsNullOrEmpty(Perpustakaan.dataPerpustakaan.GSFoto) Then
                PicFoto.Load(Perpustakaan.dataPerpustakaan.GSFoto)
                PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Catch ex As Exception

        End Try

        DateTimePickerMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerMasuk.CustomFormat = "yyyy/MM/dd"
        TxtNama.Text = Perpustakaan.dataPerpustakaan.GSNama
        ComboBoxJenis.SelectedItem() = Perpustakaan.dataPerpustakaan.GSJenis
        RichDeskripsi.Text = Perpustakaan.dataPerpustakaan.GSDeskripsi
        TxtPenerbit.Text = Perpustakaan.dataPerpustakaan.GSPenerbit
        TxtTahunTerbit.Text = Perpustakaan.dataPerpustakaan.GSTahunTerbit
        TxtLokasiRak.Text = Perpustakaan.dataPerpustakaan.GSLokasiRak
        DateTimePickerMasuk.Value = Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi
        TxtStok.Text = Perpustakaan.dataPerpustakaan.GSStock

        If String.Compare(Perpustakaan.dataPerpustakaan.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdBIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.dataPerpustakaan.GSBahasa, "Bahasa Inggris") = 0 Then
            RdBInggris.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.dataPerpustakaan.GSKategori

            If String.Compare(kategoriItem, "Sains") = 0 Then
                ChckSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") = 0 Then
                ChckSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") = 0 Then
                ChckTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") = 0 Then
                ChckBudaya.Checked = True
            End If

        Next
        Perpustakaan.dataPerpustakaan.resetKategori()
    End Sub

    Private Sub UpdateKoleksi_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LblValueDeskripsi.Text = Perpustakaan.dataPerpustakaan.getDeskripsiProperty.Length
    End Sub

    Private Sub BtnUpdateGambar_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambar.Click
        Try
            OpenFileDialog1.Title = "Open Gambar Koleksi"
            OpenFileDialog1.Filter = "All format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
            OpenFileDialog1.ShowDialog()

            Dim picKoleksiDir As String = OpenFileDialog1.FileName

            PicFoto.Load(picKoleksiDir)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            Perpustakaan.dataPerpustakaan.GSFoto = picKoleksiDir.ToString()
            Perpustakaan.dataPerpustakaan.GSFoto = Perpustakaan.dataPerpustakaan.GSFoto.Replace("\", "/")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RichDeskripsi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichDeskripsi.KeyPress
        LblValueDeskripsi.Text = max_char_deskripsi - RichDeskripsi.Text.Length

        If RichDeskripsi.Text.Length >= max_char_deskripsi Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub BtnUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click
        Perpustakaan.dataPerpustakaan.GSNama = TxtNama.Text.ToString()
        Perpustakaan.dataPerpustakaan.GSJenis = ComboBoxJenis.SelectedItem().ToString()
        Perpustakaan.dataPerpustakaan.GSDeskripsi = RichDeskripsi.Text.ToString()
        Perpustakaan.dataPerpustakaan.GSPenerbit = TxtPenerbit.Text.ToString()
        Perpustakaan.dataPerpustakaan.GSTahunTerbit = Integer.Parse(TxtTahunTerbit.Text)

        Perpustakaan.dataPerpustakaan.GSLokasiRak = TxtLokasiRak.Text.ToString()
        Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi = DateTimePickerMasuk.Value.ToString("yyyy/MM/dd")
        Perpustakaan.dataPerpustakaan.GSStock = Integer.Parse(TxtStok.Text)

        If RdBIndonesia.Checked = True Then
            Perpustakaan.dataPerpustakaan.GSBahasa = "Bahasa Indonesia"
        ElseIf RdBInggris.Checked = True Then
            Perpustakaan.dataPerpustakaan.GSBahasa = "Bahasa Inggris"
        End If

        If ChckSains.Checked = True Then
            Perpustakaan.dataPerpustakaan.AddKategori("Sains")
        End If

        If ChckSosial.Checked = True Then
            Perpustakaan.dataPerpustakaan.AddKategori("Sosial")
        End If

        If ChckTeknologi.Checked = True Then
            Perpustakaan.dataPerpustakaan.AddKategori("Teknologi")
        End If

        If ChckBudaya.Checked = True Then
            Perpustakaan.dataPerpustakaan.AddKategori("Budaya")
        End If

        Dim convertedKoleksi = Perpustakaan.dataPerpustakaan.ConvertKoleksiToString(Perpustakaan.dataPerpustakaan.getKategoriItem)

        Perpustakaan.dataPerpustakaan.UpdateDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi,
                                                                    Perpustakaan.dataPerpustakaan.GSFoto,
                                                                    Perpustakaan.dataPerpustakaan.GSNama,
                                                                    Perpustakaan.dataPerpustakaan.GSJenis,
                                                                    Perpustakaan.dataPerpustakaan.GSPenerbit,
                                                                    Perpustakaan.dataPerpustakaan.GSDeskripsi,
                                                                    Perpustakaan.dataPerpustakaan.GSTahunTerbit,
                                                                    Perpustakaan.dataPerpustakaan.GSLokasiRak,
                                                                    Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi,
                                                                    Perpustakaan.dataPerpustakaan.GSStock,
                                                                    Perpustakaan.dataPerpustakaan.GSBahasa,
                                                                    convertedKoleksi)

        Dim infoTambah = New InfoKoleksi()
        infoTambah.Show()

        Me.Close()
    End Sub

End Class