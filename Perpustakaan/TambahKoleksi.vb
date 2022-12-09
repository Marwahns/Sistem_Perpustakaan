'' Marwah Nur Shafira - 2107411008

Imports System.IO

Public Class TambahKoleksi

    Dim max_char_deskripsi = 268
    Dim panjang_karakter = max_char_deskripsi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtNama.Select()

        DateTimePickerMasuk.Format = DateTimePickerFormat.Custom
        DateTimePickerMasuk.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub TxtNama_Leave(sender As Object, e As EventArgs) Handles TxtNama.Leave
        If TxtNama.Text.Length < 1 Then
            TxtNama.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub TxtTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub TxtStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStok.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub RdBIndonesia_CheckedChanged(sender As Object, e As EventArgs) Handles RdBIndonesia.CheckedChanged
        Perpustakaan.dataPerpustakaan.GSBahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RdBInggris_CheckedChanged(sender As Object, e As EventArgs) Handles RdBInggris.CheckedChanged
        Perpustakaan.dataPerpustakaan.GSBahasa = "Bahasa Inggris"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        Try
            OpenFileDialog1.Title = "Open Foto"
            OpenFileDialog1.Filter = "All Format|*.*|Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif"
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

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click

        Perpustakaan.dataPerpustakaan.GSNama = TxtNama.Text
        Perpustakaan.dataPerpustakaan.GSJenis = ComboBoxJenis.SelectedItem()
        Perpustakaan.dataPerpustakaan.GSDeskripsi = RichDeskripsi.Text
        Perpustakaan.dataPerpustakaan.GSPenerbit = TxtPenerbit.Text
        Perpustakaan.dataPerpustakaan.GSTahunTerbit = TxtTahunTerbit.Text
        Perpustakaan.dataPerpustakaan.GSLokasiRak = TxtLokasiRak.Text
        ' FormPerpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi = DateTimePickerMasuk.Value.ToLongTimeString
        Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi = DateTimePickerMasuk.Value.ToLongDateString
        Perpustakaan.dataPerpustakaan.GSStock = TxtStok.Text

        'InfoKoleksi.ListBoxKoleksi.Items.Clear()
        Perpustakaan.dataPerpustakaan.resetKategori()

        If ChckSains.Checked() Then
            Perpustakaan.dataPerpustakaan.AddKategori("Sains")
        End If

        If ChckSosial.Checked() Then
            Perpustakaan.dataPerpustakaan.AddKategori("Sosial")
        End If

        If ChckTeknologi.Checked() Then
            Perpustakaan.dataPerpustakaan.AddKategori("Teknologi")
        End If

        If ChckBudaya.Checked() Then
            Perpustakaan.dataPerpustakaan.AddKategori("Budaya")
        End If

        ''Menampilkan judul buku yang ditambahkan ke list box
        Dim add_item = TxtNama.Text
        Perpustakaan.listKoleksi.Add(add_item)

        Dim convertedKoleksi = Perpustakaan.dataPerpustakaan.ConvertKoleksiToString(Perpustakaan.dataPerpustakaan.getKategoriItem)
        Perpustakaan.dataPerpustakaan.AddDataKoleksiDatabase(Perpustakaan.dataPerpustakaan.GSFoto,
                                                             Perpustakaan.dataPerpustakaan.GSNama,
                                                             Perpustakaan.dataPerpustakaan.GSJenis,
                                                             Perpustakaan.dataPerpustakaan.GSPenerbit,
                                                             Perpustakaan.dataPerpustakaan.GSDeskripsi,
                                                             Perpustakaan.dataPerpustakaan.GSTahunTerbit,
                                                             Perpustakaan.dataPerpustakaan.GSLokasiRak,
                                                             Perpustakaan.dataPerpustakaan.GSTanggalMasukKoleksi,
                                                             Perpustakaan.dataPerpustakaan.GSStock,
                                                             Perpustakaan.dataPerpustakaan.GSBahasa,
                                                             convertedKoleksi
                                                            )

        Dim form_infoKoleksi = New InfoKoleksi()
        form_infoKoleksi.Show()

        Me.Close()
    End Sub

End Class