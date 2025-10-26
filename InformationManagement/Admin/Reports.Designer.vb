<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSales = New System.Windows.Forms.TabPage()
        Me.TabOrder = New System.Windows.Forms.TabPage()
        Me.TabPayroll = New System.Windows.Forms.TabPage()
        Me.TabCateringReservations = New System.Windows.Forms.TabPage()
        Me.TabReservationStatus = New System.Windows.Forms.TabPage()
        Me.TabDineInOrders = New System.Windows.Forms.TabPage()
        Me.TabTakeOutOrders = New System.Windows.Forms.TabPage()
        Me.TabEmployeeAttendance = New System.Windows.Forms.TabPage()
        Me.TabCustomerHistory = New System.Windows.Forms.TabPage()
        Me.TabProductsPerformance = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabSales)
        Me.TabControl1.Controls.Add(Me.TabOrder)
        Me.TabControl1.Controls.Add(Me.TabPayroll)
        Me.TabControl1.Controls.Add(Me.TabCateringReservations)
        Me.TabControl1.Controls.Add(Me.TabReservationStatus)
        Me.TabControl1.Controls.Add(Me.TabDineInOrders)
        Me.TabControl1.Controls.Add(Me.TabTakeOutOrders)
        Me.TabControl1.Controls.Add(Me.TabEmployeeAttendance)
        Me.TabControl1.Controls.Add(Me.TabCustomerHistory)
        Me.TabControl1.Controls.Add(Me.TabProductsPerformance)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft PhagsPa", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(991, 22)
        Me.TabControl1.TabIndex = 1
        '
        'TabSales
        '
        Me.TabSales.BackColor = System.Drawing.Color.White
        Me.TabSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabSales.Location = New System.Drawing.Point(4, 23)
        Me.TabSales.Name = "TabSales"
        Me.TabSales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSales.Size = New System.Drawing.Size(983, 0)
        Me.TabSales.TabIndex = 0
        Me.TabSales.Text = "Sales/Financial"
        '
        'TabOrder
        '
        Me.TabOrder.Location = New System.Drawing.Point(4, 23)
        Me.TabOrder.Name = "TabOrder"
        Me.TabOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.TabOrder.Size = New System.Drawing.Size(870, 0)
        Me.TabOrder.TabIndex = 1
        Me.TabOrder.Text = "Orders"
        Me.TabOrder.UseVisualStyleBackColor = True
        '
        'TabPayroll
        '
        Me.TabPayroll.Location = New System.Drawing.Point(4, 23)
        Me.TabPayroll.Name = "TabPayroll"
        Me.TabPayroll.Size = New System.Drawing.Size(870, 0)
        Me.TabPayroll.TabIndex = 2
        Me.TabPayroll.Text = "Payroll"
        Me.TabPayroll.UseVisualStyleBackColor = True
        '
        'TabCateringReservations
        '
        Me.TabCateringReservations.Location = New System.Drawing.Point(4, 23)
        Me.TabCateringReservations.Name = "TabCateringReservations"
        Me.TabCateringReservations.Size = New System.Drawing.Size(870, 0)
        Me.TabCateringReservations.TabIndex = 3
        Me.TabCateringReservations.Text = "Catering Reservations"
        Me.TabCateringReservations.UseVisualStyleBackColor = True
        '
        'TabReservationStatus
        '
        Me.TabReservationStatus.Location = New System.Drawing.Point(4, 23)
        Me.TabReservationStatus.Name = "TabReservationStatus"
        Me.TabReservationStatus.Size = New System.Drawing.Size(870, 0)
        Me.TabReservationStatus.TabIndex = 4
        Me.TabReservationStatus.Text = "Reservation Status"
        Me.TabReservationStatus.UseVisualStyleBackColor = True
        '
        'TabDineInOrders
        '
        Me.TabDineInOrders.Location = New System.Drawing.Point(4, 23)
        Me.TabDineInOrders.Name = "TabDineInOrders"
        Me.TabDineInOrders.Size = New System.Drawing.Size(870, 0)
        Me.TabDineInOrders.TabIndex = 5
        Me.TabDineInOrders.Text = "Dine-in Orders"
        Me.TabDineInOrders.UseVisualStyleBackColor = True
        '
        'TabTakeOutOrders
        '
        Me.TabTakeOutOrders.Location = New System.Drawing.Point(4, 23)
        Me.TabTakeOutOrders.Name = "TabTakeOutOrders"
        Me.TabTakeOutOrders.Size = New System.Drawing.Size(870, 0)
        Me.TabTakeOutOrders.TabIndex = 6
        Me.TabTakeOutOrders.Text = "Takeout Orders"
        Me.TabTakeOutOrders.UseVisualStyleBackColor = True
        '
        'TabEmployeeAttendance
        '
        Me.TabEmployeeAttendance.Location = New System.Drawing.Point(4, 23)
        Me.TabEmployeeAttendance.Name = "TabEmployeeAttendance"
        Me.TabEmployeeAttendance.Size = New System.Drawing.Size(870, 0)
        Me.TabEmployeeAttendance.TabIndex = 7
        Me.TabEmployeeAttendance.Text = "Employee Attendance"
        Me.TabEmployeeAttendance.UseVisualStyleBackColor = True
        '
        'TabCustomerHistory
        '
        Me.TabCustomerHistory.Location = New System.Drawing.Point(4, 23)
        Me.TabCustomerHistory.Name = "TabCustomerHistory"
        Me.TabCustomerHistory.Size = New System.Drawing.Size(870, 0)
        Me.TabCustomerHistory.TabIndex = 8
        Me.TabCustomerHistory.Text = "Customer History"
        Me.TabCustomerHistory.UseVisualStyleBackColor = True
        '
        'TabProductsPerformance
        '
        Me.TabProductsPerformance.Location = New System.Drawing.Point(4, 23)
        Me.TabProductsPerformance.Name = "TabProductsPerformance"
        Me.TabProductsPerformance.Size = New System.Drawing.Size(870, 0)
        Me.TabProductsPerformance.TabIndex = 9
        Me.TabProductsPerformance.Text = "Products Performance"
        Me.TabProductsPerformance.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reports  and Analytics"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(803, 366)
        Me.Panel1.TabIndex = 3
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reports"
        Me.Text = "Reports"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabSales As TabPage
    Friend WithEvents TabOrder As TabPage
    Friend WithEvents TabPayroll As TabPage
    Friend WithEvents TabCateringReservations As TabPage
    Friend WithEvents TabReservationStatus As TabPage
    Protected WithEvents TabControl1 As TabControl
    Friend WithEvents Label1 As Label
    Friend WithEvents TabDineInOrders As TabPage
    Friend WithEvents TabTakeOutOrders As TabPage
    Friend WithEvents TabEmployeeAttendance As TabPage
    Friend WithEvents TabCustomerHistory As TabPage
    Friend WithEvents TabProductsPerformance As TabPage
    Friend WithEvents Panel1 As Panel
End Class
