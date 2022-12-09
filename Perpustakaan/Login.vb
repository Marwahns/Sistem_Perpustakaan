Imports System.DirectoryServices
Imports System.Security.Cryptography

Public Class Login
    Public Shared Perpustakaan As Perpustakaan
    Public Shared users As Users

    Dim max_char_username = 30
    Dim min_char_username = 6
    Dim panjang_karakter = max_char_username - min_char_username
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New Perpustakaan()
        users = New Users()
    End Sub

    'Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
    '    TxtPassword.PasswordChar = "*"
    'End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            'Dim plainUsername As String = TxtUsername.Text
            'Dim plainPassword As String = TxtPassword.Text

            'Dim AuthStatus As Boolean = users.CheckAuth(plainUsername, plainPassword)

            'If AuthStatus Then
            '    Perpustakaan.Show()
            '    Me.Hide()
            'Else
            '    MessageBox.Show("wrong password")
            'End If

            Dim plainUsername As String = TxtUsername.Text
            Dim plainPassword As String = TxtPassword.Text

            Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

            If data_user.Count > 0 Then
                users.UsernameProperty = data_user(1)
                Perpustakaan.Show()
                Me.Hide()

            ElseIf plainUsername = "" Or plainPassword = "" Then
                MessageBox.Show("Lengkapi Data")

            Else
                'MessageBox.Show("Salah Password")
                MessageBox.Show("Username or Password incorrect")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Dim form_signUp = New SignUp()
        form_signUp.Show()
        Me.Hide()
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtUsername.Text = ""
        TxtPassword.Text = ""
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class