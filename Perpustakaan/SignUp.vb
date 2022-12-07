Public Class SignUp

    Public Shared Perpustakaan As Perpustakaan
    Public Shared users As Users
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
    End Sub
End Class