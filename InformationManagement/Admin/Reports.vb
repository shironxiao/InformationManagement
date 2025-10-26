Public Class Reports
    Private Sub LoadFormIntoTab(childForm As Form, tab As TabPage)
        Panel1.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        childForm.Show()
    End Sub
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



                ' Add more cases for additional tabs
        End Select
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class