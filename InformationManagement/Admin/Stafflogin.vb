Public Class Stafflogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Back2_Click(sender As Object, e As EventArgs) Handles Back2.Click
        ' Show the login form
        Dim loginForm As New Login()
        loginForm.Show()

        ' Hide the current form
        Me.Hide()
    End Sub
End Class