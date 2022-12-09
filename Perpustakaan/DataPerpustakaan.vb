Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class DataPerpustakaan
    Private foto As String
    Private nama As String
    Private jenis As String
    Private deskripsi
    Private penerbit As String
    Private tahun_terbit As String
    Private lokasi_rak As String
    Private tanggal_koleksi
    Private stock As String
    Private bahasa As String

    Private kategori_list As New List(Of String)
    Private listKoleksi As New List(Of String)

    Private koleksiDataTable As New ArrayList()

    'Database Global Variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    ' Getter And Setter
    ' Foto
    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(ByVal value As String)
            foto = value
        End Set
    End Property

    ' Nama
    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(ByVal value As String)
            nama = value
        End Set
    End Property

    ' Jenis
    Public Property GSJenis() As String
        Get
            Return jenis
        End Get
        Set(ByVal value As String)
            jenis = value
        End Set
    End Property

    ' Deskripsi
    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
        End Set
    End Property

    Public ReadOnly Property getDeskripsiProperty() As String
        Get
            Return deskripsi
        End Get
    End Property

    ' Penerbit
    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    ' Tahun Terbit
    Public Property GSTahunTerbit() As String
        Get
            Return tahun_terbit
        End Get
        Set(ByVal value As String)
            tahun_terbit = value
        End Set
    End Property

    ' Lokasi Rak
    Public Property GSLokasiRak() As String
        Get
            Return lokasi_rak
        End Get
        Set(ByVal value As String)
            lokasi_rak = value
        End Set
    End Property

    ' Tanggal Masuk Koleksi
    Public Property GSTanggalMasukKoleksi() As String
        Get
            Return tanggal_koleksi
        End Get
        Set(ByVal value As String)
            tanggal_koleksi = value
        End Set
    End Property

    ' Stock
    Public Property GSStock() As String
        Get
            Return stock
        End Get
        Set(ByVal value As String)
            stock = value
        End Set
    End Property

    ' Bahasa
    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    ' Kategori
    '' GSKategori() sudah tidak digunakan
    Public Property GSKategori() As List(Of String)
        Get
            Return kategori_list
        End Get
        Set(ByVal value As List(Of String))
            kategori_list = value
        End Set
    End Property

    Public Function AddKategori(value As String)
        kategori_list.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori_list
        End Get
    End Property

    Public Function resetKategori()
        kategori_list.Clear()
    End Function

    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
    End Function

    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
    End Function

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        ' Convert to string.
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        ' Convert to List.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function AddKoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As String,
                                        bahasa_koleksi As String)

        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi})
    End Function

    '' Function untuk hapus data table tidak pakai database
    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    'Menampilkan data di data grid view
    Public Function DBConnection()
        dbConn.ConnectionString = "server =" + server + ";" _
                                   + "user id=" + username + ";" _
                                   + "password=" + password + ";" _
                                   + "database =" + database
    End Function

    '' Function untuk mengambil data koleksi database
    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        Try
            DBConnection()

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_koleksi AS 'ID',
                                      nama_koleksi AS 'Nama Koleksi',
                                      jenis_koleksi AS 'Jenis Koleksi',
                                      penerbit AS 'Penerbit',
                                      tahun_terbit AS 'Tahun Terbit',
                                      tanggal_masuk_koleksi AS 'Tanggal Masuk',
                                      lokasi AS 'Lokasi Rak',
                                      stock AS 'Stock',
                                      bahasa AS 'Bahasa'
                                      From koleksi"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            'Return result

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function


    '' Function untuk data koleksi database
    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                           nama_koleksi As String,
                                           jenis_koleksi As String,
                                           penerbit_koleksi As String,
                                           deskripsi_koleksi As String,
                                           tahun_terbit As String,
                                           lokasi_rak As String,
                                           tanggal_masuk As Date,
                                           stock_koleksi As Integer,
                                           bahasa_koleksi As String,
                                           kategori_koleksi As String)

        DBConnection()

        Try

            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO KOLEKSI(nama_koleksi, dir_gambar, 
                        deskripsi, penerbit, jenis_koleksi, 
                        tahun_terbit, lokasi, tanggal_masuk_koleksi,
                        stock, bahasa, kategori) VALUE('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi_koleksi & "', '" _
                        & penerbit_koleksi & "', '" _
                        & jenis_koleksi & "', '" _
                        & tahun_terbit & "', '" _
                        & lokasi_rak & "', '" _
                        & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                        & stock_koleksi & "', '" _
                        & bahasa_koleksi & "', '" _
                        & kategori_koleksi & "')"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data Added")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    '' Function untuk mengambil data koleksi database berdasarkan id
    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            DBConnection()

            dbConn.Open()

            'MessageBox.Show(ID)

            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_koleksi, 
                                      nama_koleksi, 
                                      dir_gambar, 
                                      deskripsi, 
                                      penerbit, 
                                      jenis_koleksi, 
                                      tahun_terbit, 
                                      lokasi, 
                                      tanggal_masuk_koleksi, 
                                      stock, 
                                      bahasa, 
                                      kategori
                                      FROM koleksi
                                      WHERE id_koleksi='" & ID & "'"

            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                ' MessageBox.Show(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
                result.Add(sqlRead.GetString(4).ToString())
                result.Add(sqlRead.GetString(5).ToString())
                result.Add(sqlRead.GetString(6).ToString())
                result.Add(sqlRead.GetString(7).ToString())
                result.Add(sqlRead.GetString(8).ToString())
                result.Add(sqlRead.GetString(9).ToString())
                result.Add(sqlRead.GetString(10).ToString())
                result.Add(sqlRead.GetString(11).ToString())
            End While

            'Return result
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Function

    '' Function untuk update data koleksi database
    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                  dir_gambar As String,
                                                  nama_koleksi As String,
                                                  jenis_koleksi As String,
                                                  penerbit_koleksi As String,
                                                  deskripsi_koleksi As String,
                                                  tahun_terbit As String,
                                                  lokasi_rak As String,
                                                  tanggal_masuk As String,
                                                  stock_koleksi As Integer,
                                                  bahasa_koleksi As String,
                                                  kategori_koleksi As String)

        'tahun_terbit = tahun_terbit.ToString()

        Try
            DBConnection()

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE koleksi SET nama_koleksi='" & nama_koleksi & "', " &
                       "dir_gambar='" & dir_gambar & "', " &
                       "deskripsi='" & deskripsi_koleksi & "', " &
                       "penerbit='" & penerbit_koleksi & "', " &
                       "jenis_koleksi='" & jenis_koleksi & "', " &
                       "tahun_terbit='" & tahun_terbit & "', " &
                       "lokasi='" & lokasi_rak & "', " &
                       "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                       "stock='" & stock_koleksi & "', " &
                       "bahasa='" & bahasa_koleksi & "', " &
                       "kategori='" & kategori_koleksi & "' " &
                       "WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data Updated")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
            MessageBox.Show(ex.ToString())
        Finally
            dbConn.Dispose()
        End Try

    End Function

    '' Function untuk delete data koleksi database
    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)

        DBConnection()

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi " &
                       "WHERE id_koleksi='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

End Class