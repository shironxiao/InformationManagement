Public Class Adminlogin
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click
        ' Show the Login form
        Dim loginForm As New Login()
        loginForm.Show()

        ' Hide the AdminLog form
        Me.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub adminlog_Click(sender As Object, e As EventArgs) Handles adminlog.Click

        AdminDashboard.Show()

        Me.Hide()
    End Sub
End Class