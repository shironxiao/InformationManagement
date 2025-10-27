<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RoundedPanel1 = New InformationManagement.RoundedPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RoundedPanel2 = New InformationManagement.RoundedPanel()
        Me.lblTotalOrders = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RoundedPanel3 = New InformationManagement.RoundedPanel()
        Me.lblActiveReservation = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New InformationManagement.RoundedPanel()
        Me.PanelTopMenuItems = New InformationManagement.RoundedPanel()
        Me.PanelRecentReservations = New InformationManagement.RoundedPanel()
        Me.PanelPendingOrders = New InformationManagement.RoundedPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelQuickStats = New InformationManagement.RoundedPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.PanelTopMenuItems.SuspendLayout()
        Me.PanelRecentReservations.SuspendLayout()
        Me.PanelPendingOrders.SuspendLayout()
        Me.PanelQuickStats.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard Overview"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(15, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total Orders"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(20, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Active Reservations"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(36, 17)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(982, 312)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Top Menu Items"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Recent Reservations"
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.White
        Me.RoundedPanel1.Controls.Add(Me.PictureBox4)
        Me.RoundedPanel1.Controls.Add(Me.lblTotalRevenue)
        Me.RoundedPanel1.Controls.Add(Me.PictureBox1)
        Me.RoundedPanel1.Controls.Add(Me.Label2)
        Me.RoundedPanel1.CornerRadius = 18
        Me.RoundedPanel1.Location = New System.Drawing.Point(32, 72)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPanel1.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(279, 17)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.AutoSize = True
        Me.lblTotalRevenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblTotalRevenue.Location = New System.Drawing.Point(46, 76)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(139, 22)
        Me.lblTotalRevenue.TabIndex = 3
        Me.lblTotalRevenue.Text = "16, 400, 00.00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(17, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RoundedPanel2
        '
        Me.RoundedPanel2.BackColor = System.Drawing.Color.White
        Me.RoundedPanel2.Controls.Add(Me.lblTotalOrders)
        Me.RoundedPanel2.Controls.Add(Me.PictureBox2)
        Me.RoundedPanel2.Controls.Add(Me.Label3)
        Me.RoundedPanel2.CornerRadius = 18
        Me.RoundedPanel2.Location = New System.Drawing.Point(398, 72)
        Me.RoundedPanel2.Name = "RoundedPanel2"
        Me.RoundedPanel2.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPanel2.TabIndex = 2
        '
        'lblTotalOrders
        '
        Me.lblTotalOrders.AutoSize = True
        Me.lblTotalOrders.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblTotalOrders.Location = New System.Drawing.Point(23, 76)
        Me.lblTotalOrders.Name = "lblTotalOrders"
        Me.lblTotalOrders.Size = New System.Drawing.Size(60, 22)
        Me.lblTotalOrders.TabIndex = 2
        Me.lblTotalOrders.Text = "2,340"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(277, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'RoundedPanel3
        '
        Me.RoundedPanel3.BackColor = System.Drawing.Color.White
        Me.RoundedPanel3.Controls.Add(Me.lblActiveReservation)
        Me.RoundedPanel3.Controls.Add(Me.PictureBox3)
        Me.RoundedPanel3.Controls.Add(Me.Label4)
        Me.RoundedPanel3.CornerRadius = 18
        Me.RoundedPanel3.Location = New System.Drawing.Point(753, 72)
        Me.RoundedPanel3.Name = "RoundedPanel3"
        Me.RoundedPanel3.Size = New System.Drawing.Size(330, 120)
        Me.RoundedPanel3.TabIndex = 3
        '
        'lblActiveReservation
        '
        Me.lblActiveReservation.AutoSize = True
        Me.lblActiveReservation.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.lblActiveReservation.Location = New System.Drawing.Point(19, 76)
        Me.lblActiveReservation.Name = "lblActiveReservation"
        Me.lblActiveReservation.Size = New System.Drawing.Size(32, 22)
        Me.lblActiveReservation.TabIndex = 2
        Me.lblActiveReservation.Text = "28"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(291, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Chart1)
        Me.Panel5.CornerRadius = 18
        Me.Panel5.Location = New System.Drawing.Point(32, 225)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1051, 378)
        Me.Panel5.TabIndex = 10
        '
        'PanelTopMenuItems
        '
        Me.PanelTopMenuItems.BackColor = System.Drawing.Color.White
        Me.PanelTopMenuItems.Controls.Add(Me.Label6)
        Me.PanelTopMenuItems.CornerRadius = 18
        Me.PanelTopMenuItems.Location = New System.Drawing.Point(32, 634)
        Me.PanelTopMenuItems.Name = "PanelTopMenuItems"
        Me.PanelTopMenuItems.Size = New System.Drawing.Size(505, 62)
        Me.PanelTopMenuItems.TabIndex = 11
        '
        'PanelRecentReservations
        '
        Me.PanelRecentReservations.BackColor = System.Drawing.Color.White
        Me.PanelRecentReservations.Controls.Add(Me.Label7)
        Me.PanelRecentReservations.CornerRadius = 18
        Me.PanelRecentReservations.Location = New System.Drawing.Point(578, 634)
        Me.PanelRecentReservations.Name = "PanelRecentReservations"
        Me.PanelRecentReservations.Size = New System.Drawing.Size(505, 62)
        Me.PanelRecentReservations.TabIndex = 12
        '
        'PanelPendingOrders
        '
        Me.PanelPendingOrders.BackColor = System.Drawing.Color.White
        Me.PanelPendingOrders.Controls.Add(Me.PictureBox5)
        Me.PanelPendingOrders.Controls.Add(Me.Label5)
        Me.PanelPendingOrders.CornerRadius = 18
        Me.PanelPendingOrders.Location = New System.Drawing.Point(32, 702)
        Me.PanelPendingOrders.Name = "PanelPendingOrders"
        Me.PanelPendingOrders.Size = New System.Drawing.Size(505, 62)
        Me.PanelPendingOrders.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Pending Orders"
        '
        'PanelQuickStats
        '
        Me.PanelQuickStats.BackColor = System.Drawing.Color.White
        Me.PanelQuickStats.Controls.Add(Me.Label8)
        Me.PanelQuickStats.CornerRadius = 18
        Me.PanelQuickStats.Location = New System.Drawing.Point(578, 716)
        Me.PanelQuickStats.Name = "PanelQuickStats"
        Me.PanelQuickStats.Size = New System.Drawing.Size(505, 62)
        Me.PanelQuickStats.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Quick Stats"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(20, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 18)
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1103, 749)
        Me.Controls.Add(Me.PanelQuickStats)
        Me.Controls.Add(Me.PanelPendingOrders)
        Me.Controls.Add(Me.PanelRecentReservations)
        Me.Controls.Add(Me.PanelTopMenuItems)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.RoundedPanel3)
        Me.Controls.Add(Me.RoundedPanel1)
        Me.Controls.Add(Me.RoundedPanel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel2.ResumeLayout(False)
        Me.RoundedPanel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel3.ResumeLayout(False)
        Me.RoundedPanel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.PanelTopMenuItems.ResumeLayout(False)
        Me.PanelTopMenuItems.PerformLayout()
        Me.PanelRecentReservations.ResumeLayout(False)
        Me.PanelRecentReservations.PerformLayout()
        Me.PanelPendingOrders.ResumeLayout(False)
        Me.PanelPendingOrders.PerformLayout()
        Me.PanelQuickStats.ResumeLayout(False)
        Me.PanelQuickStats.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents RoundedPanel2 As RoundedPanel
    Friend WithEvents RoundedPanel3 As RoundedPanel
    Friend WithEvents Panel5 As RoundedPanel
    Friend WithEvents PanelTopMenuItems As RoundedPanel
    Friend WithEvents PanelRecentReservations As RoundedPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents lblTotalOrders As Label
    Friend WithEvents lblActiveReservation As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PanelPendingOrders As RoundedPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelQuickStats As RoundedPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class
