Public Class Login
    Private Sub AdminBot_Click(sender As Object, e As EventArgs) Handles AdminBot.Click
        ' Show the Admin login form
        Dim adminForm As New Adminlogin()
        adminForm.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub Staff1_Click(sender As Object, e As EventArgs) Handles Staff1.Click
        ' Show the StaffLogin form
        Dim staffForm As New Stafflogin()
        staffForm.Show()

        ' Hide the current form
        Me.Hide()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class