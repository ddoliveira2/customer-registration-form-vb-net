Public Class FrmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "ADMIN" AndAlso txtPassword.Text = "123456" Then

            Me.Hide()
            Dim main As New FrmMain()

            main.ShowDialog()

            Me.Show()

        Else

            MessageBox.Show(
                "Usuário não encontrado",
                "Usuário",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If
    End Sub
End Class
