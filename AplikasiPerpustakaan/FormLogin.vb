Public Class FormLogin

    Public Shared Perpustakaan As FormPerpustakaan
    Public Shared Users As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New FormPerpustakaan()
        Users = New User()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.UsernameProperty = data_user(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        FormRegister.Show()
    End Sub

End Class