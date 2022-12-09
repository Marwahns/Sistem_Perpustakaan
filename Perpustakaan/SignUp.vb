Public Class SignUp

    Public Shared Perpustakaan As Perpustakaan
    Public Shared users As Users

    Dim max_char_username = 30
    Dim min_char_username = 6
    Dim max_char_password = 100
    Dim min_char_password = 8
    Dim panjang_karakter_username = max_char_username - min_char_username
    Dim panjang_karakter_password = max_char_password - min_char_password

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New Perpustakaan()
        users = New Users()
    End Sub

    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then
            Login.users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)
            Perpustakaan.Show()
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If

        'If TxtUsername.Text.Length >= min_char_username And TxtUsername.Text.Length <= max_char_username And TxtPassword.Text.Length >= min_char_password And TxtPassword.Text.Length <= max_char_password Then
        '    Login.users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)
        '    Perpustakaan.Show()
        '    Me.Close()
        'Else
        '    MessageBox.Show("Please enter a username with a minimum length of 6 characters, a maximum of 30 characters. Password with a minimum length of 8 characters, a maximum of 100 characters.")
        'End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim form_login = New Login()
        form_login.Show()
        Me.Close()
    End Sub

    Private Sub TxtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsername.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String or Number or Combine String and Number Only")
        End If

        If TxtUsername.Text.Length >= max_char_username Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If TxtPassword.Text.Length >= max_char_password Then
            If e.KeyChar <> ControlChars.Back Then
                e.Handled = True
                MessageBox.Show("Max Length")
            End If
        End If
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked = True Then
            TxtPassword.UseSystemPasswordChar = False
        Else
            TxtPassword.UseSystemPasswordChar = True
        End If
    End Sub

End Class