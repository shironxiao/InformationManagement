Public Class Reports
    Private Sub LoadFormIntoTab(childForm As Form, tab As TabPage)
        Panel1.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        Panel1.Controls.Add(childForm)
        childForm.Show()
    End Sub
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(0, 800)
        TabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        TabControl1.SizeMode = TabSizeMode.Fixed
        TabControl1.ItemSize = New Size(130, 45)
        TabControl1.Font = New Font("Segoe UI Semibold", 9.5F)
        TabControl1.Appearance = TabAppearance.Normal
        TabControl1.Multiline = True ' allow more tabs and scrolling
        TabControl1.HotTrack = True

        TabControl1.Multiline = False

        TabControl1.Padding = New Point(15, 0)


        LoadFormIntoTab(New FormSales(), TabSales) ' Default tab on load
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                LoadFormIntoTab(New FormSales(), TabSales)
            Case 1
                LoadFormIntoTab(New FormOrders(), TabOrder)
            Case 2
                LoadFormIntoTab(New FormPayroll(), TabPayroll)
            Case 3
                LoadFormIntoTab(New FormCateringReservations(), TabCateringReservations)
            Case 4
                LoadFormIntoTab(New FormReservationStatus(), TabReservationStatus)
            Case 5
                LoadFormIntoTab(New FormDineInOrders(), TabDineInOrders)
            Case 6
                LoadFormIntoTab(New FormTakeOutOrders(), TabTakeOutOrders)
            Case 7
                LoadFormIntoTab(New FormEmployeeAttendance(), TabEmployeeAttendance)
            Case 8
                LoadFormIntoTab(New FormCustomerHistory(), TabCustomerHistory)
            Case 9
                LoadFormIntoTab(New FormProductPerformance(), TabProductsPerformance)

        End Select

    End Sub
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem
        Dim g As Graphics = e.Graphics
        Dim tabControl As TabControl = DirectCast(sender, TabControl)
        Dim tabPage As TabPage = tabControl.TabPages(e.Index)
        Dim tabRect As Rectangle = tabControl.GetTabRect(e.Index)
        Dim isSelected As Boolean = (e.Index = tabControl.SelectedIndex)

        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit

        ' --- Draw the gray bar background (always visible) ---
        Using bgBrush As New SolidBrush(Color.FromArgb(240, 240, 240))
            g.FillRectangle(bgBrush, 0, 0, tabControl.Width, tabRect.Height + 5)
        End Using

        ' --- Selected tab highlight ---
        If isSelected Then
            Dim radius As Integer = 10
            Dim path As New Drawing2D.GraphicsPath()
            Dim rect As New Rectangle(tabRect.X + 3, tabRect.Y + 4, tabRect.Width - 6, tabRect.Height - 2)

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
            path.AddLine(rect.Right, rect.Bottom, rect.X, rect.Bottom)
            path.CloseFigure()

            Using whiteBrush As New SolidBrush(Color.White)
                g.FillPath(whiteBrush, path)
            End Using
        End If

        ' --- Draw the text label (always visible) ---
        Dim textColor As Color = If(isSelected, Color.Black, Color.FromArgb(100, 100, 100))
        Dim textRect As New Rectangle(tabRect.X, tabRect.Y, tabRect.Width, tabRect.Height)
        Dim sf As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}

        Using textBrush As New SolidBrush(textColor)
            g.DrawString(tabPage.Text, TabControl1.Font, textBrush, textRect, sf)
        End Using
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)
    End Sub
End Class