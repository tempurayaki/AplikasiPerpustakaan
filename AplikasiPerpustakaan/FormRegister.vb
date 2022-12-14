Public Class FormRegister
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        'Dim registeredUsername = TxtUsername.Text
        'Dim registeredPassword = TxtPassword.Text

        'Dim regist = FormLogin.Users.Register(registeredUsername, registeredPassword)

        'If regist Then
        'MessageBox.Show("Registration Success")
        'Me.Close()
        'Else
        'MessageBox.Show("Username Already Registered")
        'End If

        If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 Then

            'FormLogin.Users.AddDataUsers(TxtUsername.Text, TxtPassword.Text)
            FormLogin.Users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi Data")
        End If
    End Sub
End Class