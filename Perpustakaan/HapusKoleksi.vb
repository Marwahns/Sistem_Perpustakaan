'' Marwah Nur Shafira - 2107411008

Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class HapusKoleksi

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LblKoleksi.Text = Perpustakaan.koleksiTerpilih
        LblKoleksi.Text = Perpustakaan.selectedTableKoleksiNama
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        'Perpustakaan.listKoleksi.Remove(Perpustakaan.koleksiTerpilih)
        Perpustakaan.dataPerpustakaan.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub

End Class