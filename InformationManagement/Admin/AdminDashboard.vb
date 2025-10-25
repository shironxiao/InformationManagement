Public Class AdminDashboard

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub SidePanel_Paint(sender As Object, e As PaintEventArgs) Handles SidePanel.Paint

    End Sub
    Private Sub MakeRoundedButton(btn As Button, radius As Integer)
        Dim path As New Drawing2D.GraphicsPath()
        Dim rect As New Rectangle(0, 0, btn.Width, btn.Height)

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        btn.Region = New Region(path)
    End Sub
    Private currentButton As Button = Nothing

    Private Sub HighlightButton(clickedButton As Button)
        If currentButton IsNot Nothing Then
            currentButton.BackColor = Color.FromArgb(44, 62, 80)
        End If
        clickedButton.BackColor = Color.FromArgb(110, 120, 135)
        currentButton = clickedButton
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        HighlightButton(btnDashboard)
        With Dashboard
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnMenuItems_Click(sender As Object, e As EventArgs) Handles btnMenuItems.Click
        HighlightButton(btnMenuItems)
        With MenuItems
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(MenuItems)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnReservations_Click(sender As Object, e As EventArgs) Handles btnReservations.Click
        HighlightButton(btnReservations)
        With Reservations
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Reservations)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnUserAccounts_Click(sender As Object, e As EventArgs) Handles btnUserAccounts.Click
        HighlightButton(btnUserAccounts)
        With UsersAccounts
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(UsersAccounts)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        HighlightButton(btnOrders)
        With Orders
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Orders)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        HighlightButton(btnPayroll)
        With Payroll
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Payroll)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        HighlightButton(btnReports)
        With Reports
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Reports)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Panel1.Controls.Clear()

        End If
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        MakeRoundedButton(btnDashboard, 15)
        MakeRoundedButton(btnMenuItems, 15)
        MakeRoundedButton(btnUserAccounts, 15)
        MakeRoundedButton(btnReservations, 15)
        MakeRoundedButton(btnOrders, 15)
        MakeRoundedButton(btnPayroll, 15)
        MakeRoundedButton(btnReports, 15)
        HighlightButton(btnDashboard)
        With Dashboard
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            Panel1.Controls.Clear()
            Panel1.Controls.Add(Dashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

End Class