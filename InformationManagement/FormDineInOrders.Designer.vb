<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDineInOrders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDineInOrders))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.Item, Me.Amount, Me.PaymentStatus, Me.Time})
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(3, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(712, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(27, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 260)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Dine In Order Report"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(702, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "  Export"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OrderID
        '
        Me.OrderID.HeaderText = "Order ID"
        Me.OrderID.Name = "OrderID"
        Me.OrderID.Width = 120
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.Name = "Item"
        Me.Item.Width = 150
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.Width = 120
        '
        'PaymentStatus
        '
        Me.PaymentStatus.HeaderText = "Payment Status"
        Me.PaymentStatus.Name = "PaymentStatus"
        Me.PaymentStatus.Width = 120
        '
        'Time
        '
        Me.Time.HeaderText = "Time"
        Me.Time.Name = "Time"
        '
        'FormDineInOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormDineInOrders"
        Me.Text = "FormDineInOrders"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents Time As DataGridViewTextBoxColumn
End Class
