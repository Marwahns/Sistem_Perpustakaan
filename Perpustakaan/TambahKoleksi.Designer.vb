<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahKoleksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TambahKoleksi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.DateTimePickerMasuk = New System.Windows.Forms.DateTimePicker()
        Me.RichDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.TxtTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TxtLokasiRak = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.GroupBahasa = New System.Windows.Forms.GroupBox()
        Me.RdBInggris = New System.Windows.Forms.RadioButton()
        Me.RdBIndonesia = New System.Windows.Forms.RadioButton()
        Me.GroupKategori = New System.Windows.Forms.GroupBox()
        Me.ChckBudaya = New System.Windows.Forms.CheckBox()
        Me.ChckTeknologi = New System.Windows.Forms.CheckBox()
        Me.ChckSosial = New System.Windows.Forms.CheckBox()
        Me.ChckSains = New System.Windows.Forms.CheckBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboBoxJenis = New System.Windows.Forms.ComboBox()
        Me.LblValueDeskripsi = New System.Windows.Forms.Label()
        Me.GroupBahasa.SuspendLayout()
        Me.GroupKategori.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Jenis Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Deskripsi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahGambar.FlatAppearance.BorderSize = 0
        Me.BtnTambahGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahGambar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahGambar.ForeColor = System.Drawing.Color.White
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 327)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(210, 34)
        Me.BtnTambahGambar.TabIndex = 5
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tahun Terbit"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(255, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Lokasi Rak"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(255, 524)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tanggal Masuk Koleksi"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(255, 569)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Stok"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(255, 618)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Bahasa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 748)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Kategori"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(467, 68)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(300, 31)
        Me.TxtNama.TabIndex = 13
        '
        'DateTimePickerMasuk
        '
        Me.DateTimePickerMasuk.Location = New System.Drawing.Point(467, 524)
        Me.DateTimePickerMasuk.Name = "DateTimePickerMasuk"
        Me.DateTimePickerMasuk.Size = New System.Drawing.Size(300, 31)
        Me.DateTimePickerMasuk.TabIndex = 14
        '
        'RichDeskripsi
        '
        Me.RichDeskripsi.Location = New System.Drawing.Point(467, 168)
        Me.RichDeskripsi.Name = "RichDeskripsi"
        Me.RichDeskripsi.Size = New System.Drawing.Size(300, 189)
        Me.RichDeskripsi.TabIndex = 16
        Me.RichDeskripsi.Text = ""
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(467, 378)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(300, 31)
        Me.TxtPenerbit.TabIndex = 17
        '
        'TxtTahunTerbit
        '
        Me.TxtTahunTerbit.Location = New System.Drawing.Point(467, 423)
        Me.TxtTahunTerbit.Name = "TxtTahunTerbit"
        Me.TxtTahunTerbit.Size = New System.Drawing.Size(300, 31)
        Me.TxtTahunTerbit.TabIndex = 18
        '
        'TxtLokasiRak
        '
        Me.TxtLokasiRak.Location = New System.Drawing.Point(467, 474)
        Me.TxtLokasiRak.Name = "TxtLokasiRak"
        Me.TxtLokasiRak.Size = New System.Drawing.Size(300, 31)
        Me.TxtLokasiRak.TabIndex = 19
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(467, 566)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(300, 31)
        Me.TxtStok.TabIndex = 20
        '
        'GroupBahasa
        '
        Me.GroupBahasa.Controls.Add(Me.RdBInggris)
        Me.GroupBahasa.Controls.Add(Me.RdBIndonesia)
        Me.GroupBahasa.Location = New System.Drawing.Point(467, 618)
        Me.GroupBahasa.Name = "GroupBahasa"
        Me.GroupBahasa.Size = New System.Drawing.Size(300, 111)
        Me.GroupBahasa.TabIndex = 21
        Me.GroupBahasa.TabStop = False
        Me.GroupBahasa.Text = "Bahasa"
        '
        'RdBInggris
        '
        Me.RdBInggris.AutoSize = True
        Me.RdBInggris.Location = New System.Drawing.Point(6, 65)
        Me.RdBInggris.Name = "RdBInggris"
        Me.RdBInggris.Size = New System.Drawing.Size(152, 29)
        Me.RdBInggris.TabIndex = 1
        Me.RdBInggris.TabStop = True
        Me.RdBInggris.Text = "Bahasa Inggris"
        Me.RdBInggris.UseVisualStyleBackColor = True
        '
        'RdBIndonesia
        '
        Me.RdBIndonesia.AutoSize = True
        Me.RdBIndonesia.Location = New System.Drawing.Point(6, 30)
        Me.RdBIndonesia.Name = "RdBIndonesia"
        Me.RdBIndonesia.Size = New System.Drawing.Size(174, 29)
        Me.RdBIndonesia.TabIndex = 0
        Me.RdBIndonesia.TabStop = True
        Me.RdBIndonesia.Text = "Bahasa Indonesia"
        Me.RdBIndonesia.UseVisualStyleBackColor = True
        '
        'GroupKategori
        '
        Me.GroupKategori.Controls.Add(Me.ChckBudaya)
        Me.GroupKategori.Controls.Add(Me.ChckTeknologi)
        Me.GroupKategori.Controls.Add(Me.ChckSosial)
        Me.GroupKategori.Controls.Add(Me.ChckSains)
        Me.GroupKategori.Location = New System.Drawing.Point(467, 748)
        Me.GroupKategori.Name = "GroupKategori"
        Me.GroupKategori.Size = New System.Drawing.Size(300, 181)
        Me.GroupKategori.TabIndex = 22
        Me.GroupKategori.TabStop = False
        Me.GroupKategori.Text = "Kategori"
        '
        'ChckBudaya
        '
        Me.ChckBudaya.AutoSize = True
        Me.ChckBudaya.Location = New System.Drawing.Point(6, 135)
        Me.ChckBudaya.Name = "ChckBudaya"
        Me.ChckBudaya.Size = New System.Drawing.Size(96, 29)
        Me.ChckBudaya.TabIndex = 3
        Me.ChckBudaya.Text = "Budaya"
        Me.ChckBudaya.UseVisualStyleBackColor = True
        '
        'ChckTeknologi
        '
        Me.ChckTeknologi.AutoSize = True
        Me.ChckTeknologi.Location = New System.Drawing.Point(6, 100)
        Me.ChckTeknologi.Name = "ChckTeknologi"
        Me.ChckTeknologi.Size = New System.Drawing.Size(114, 29)
        Me.ChckTeknologi.TabIndex = 2
        Me.ChckTeknologi.Text = "Teknologi"
        Me.ChckTeknologi.UseVisualStyleBackColor = True
        '
        'ChckSosial
        '
        Me.ChckSosial.AutoSize = True
        Me.ChckSosial.Location = New System.Drawing.Point(6, 65)
        Me.ChckSosial.Name = "ChckSosial"
        Me.ChckSosial.Size = New System.Drawing.Size(84, 29)
        Me.ChckSosial.TabIndex = 1
        Me.ChckSosial.Text = "Sosial"
        Me.ChckSosial.UseVisualStyleBackColor = True
        '
        'ChckSains
        '
        Me.ChckSains.AutoSize = True
        Me.ChckSains.Location = New System.Drawing.Point(6, 30)
        Me.ChckSains.Name = "ChckSains"
        Me.ChckSains.Size = New System.Drawing.Size(79, 29)
        Me.ChckSains.TabIndex = 0
        Me.ChckSains.Text = "Sains"
        Me.ChckSains.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.BackColor = System.Drawing.Color.Teal
        Me.BtnTambahKoleksi.FlatAppearance.BorderSize = 0
        Me.BtnTambahKoleksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambahKoleksi.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnTambahKoleksi.ForeColor = System.Drawing.Color.White
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(331, 945)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(189, 34)
        Me.BtnTambahKoleksi.TabIndex = 24
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = False
        '
        'PicFoto
        '
        Me.PicFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicFoto.Location = New System.Drawing.Point(12, 71)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(210, 250)
        Me.PicFoto.TabIndex = 25
        Me.PicFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboBoxJenis
        '
        Me.ComboBoxJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxJenis.FormattingEnabled = True
        Me.ComboBoxJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Majalah", "Publikasi"})
        Me.ComboBoxJenis.Location = New System.Drawing.Point(467, 120)
        Me.ComboBoxJenis.Name = "ComboBoxJenis"
        Me.ComboBoxJenis.Size = New System.Drawing.Size(300, 33)
        Me.ComboBoxJenis.TabIndex = 26
        '
        'LblValueDeskripsi
        '
        Me.LblValueDeskripsi.AutoSize = True
        Me.LblValueDeskripsi.Location = New System.Drawing.Point(773, 332)
        Me.LblValueDeskripsi.Name = "LblValueDeskripsi"
        Me.LblValueDeskripsi.Size = New System.Drawing.Size(42, 25)
        Me.LblValueDeskripsi.TabIndex = 28
        Me.LblValueDeskripsi.Text = "268"
        '
        'TambahKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 1001)
        Me.Controls.Add(Me.LblValueDeskripsi)
        Me.Controls.Add(Me.ComboBoxJenis)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.GroupKategori)
        Me.Controls.Add(Me.GroupBahasa)
        Me.Controls.Add(Me.TxtStok)
        Me.Controls.Add(Me.TxtLokasiRak)
        Me.Controls.Add(Me.TxtTahunTerbit)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.RichDeskripsi)
        Me.Controls.Add(Me.DateTimePickerMasuk)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TambahKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormTambahKoleksi"
        Me.GroupBahasa.ResumeLayout(False)
        Me.GroupBahasa.PerformLayout()
        Me.GroupKategori.ResumeLayout(False)
        Me.GroupKategori.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents DateTimePickerMasuk As DateTimePicker
    Friend WithEvents RichDeskripsi As RichTextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents TxtTahunTerbit As TextBox
    Friend WithEvents TxtLokasiRak As TextBox
    Friend WithEvents TxtStok As TextBox
    Friend WithEvents GroupBahasa As GroupBox
    Friend WithEvents RdBInggris As RadioButton
    Friend WithEvents RdBIndonesia As RadioButton
    Friend WithEvents GroupKategori As GroupBox
    Friend WithEvents ChckBudaya As CheckBox
    Friend WithEvents ChckTeknologi As CheckBox
    Friend WithEvents ChckSosial As CheckBox
    Friend WithEvents ChckSains As CheckBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboBoxJenis As ComboBox
    Friend WithEvents LblValueDeskripsi As Label
End Class
