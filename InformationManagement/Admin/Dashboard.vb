Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F7F8FA")
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New Size(0, 1200)

        InitializePieChartAndCards()
    End Sub

    Private Sub InitializePieChartAndCards()
        ' Clear Panel5 content
        Panel5.Controls.Clear()
        Panel5.BackColor = Color.White
        Panel5.Padding = New Padding(20)

        ' ---------- TITLE ----------
        Dim lblTitle As New Label With {
        .Text = "Sales by Channel",
        .Font = New Font("Segoe UI Semibold", 10, FontStyle.Regular),
        .ForeColor = Color.Black,
        .Left = 20,
        .Top = 10,
        .AutoSize = True
    }
        Panel5.Controls.Add(lblTitle)

        ' ---------- PIE CHART ----------
        Dim chart As New DataVisualization.Charting.Chart()
        chart.Width = 280
        chart.Height = 280
        chart.Left = 60
        chart.Top = 60
        chart.BackColor = Color.Transparent

        Dim chartArea As New DataVisualization.Charting.ChartArea()
        chartArea.BackColor = Color.Transparent
        chart.ChartAreas.Add(chartArea)

        Dim series As New DataVisualization.Charting.Series("Sales")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Pie
        series.Points.AddXY("Dine-in", 65)
        series.Points.AddXY("Takeout", 25)
        series.Points.AddXY("Catering", 10)

        ' Colors for each slice
        series.Points(0).Color = ColorTranslator.FromHtml("#A595E9")
        series.Points(1).Color = ColorTranslator.FromHtml("#90D5A9")
        series.Points(2).Color = ColorTranslator.FromHtml("#FBCB77")

        ' Hide default labels
        series.LabelForeColor = Color.Transparent
        chart.Series.Add(series)
        Panel5.Controls.Add(chart)

        ' ---------- SALES CARDS ----------
        Dim startX As Integer = 380
        Dim startY As Integer = 80
        Dim gap As Integer = 85

        AddSalesCard("Dine-in", 65, 1950000.0, "#A595E9", startX, startY)
        AddSalesCard("Takeout", 25, 750000.0, "#90D5A9", startX, startY + gap)
        AddSalesCard("Catering", 10, 300000.0, "#FBCB77", startX, startY + gap * 2)
    End Sub

    Private Sub AddSalesCard(channel As String, percentage As Integer, amount As Double, colorHex As String, x As Integer, y As Integer)
        Dim cardPanel As New Panel With {
        .Width = 580,
        .Height = 70,
        .Left = x,
        .Top = y,
        .BackColor = Color.White
    }

        AddHandler cardPanel.Paint, Sub(sender As Object, e As PaintEventArgs)
                                        Dim panel = DirectCast(sender, Panel)
                                        Dim radius As Integer = 15
                                        Dim rect As New Rectangle(0, 0, panel.Width - 1, panel.Height - 1)
                                        Dim path As New Drawing2D.GraphicsPath()

                                        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
                                        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
                                        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
                                        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
                                        path.CloseAllFigures()

                                        panel.Region = New Region(path)
                                        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

                                        ' Draw subtle border + light shadow
                                        Using pen As New Pen(Color.FromArgb(230, 230, 230), 1)
                                            e.Graphics.DrawPath(pen, path)
                                        End Using
                                    End Sub

        ' Small color box (legend icon)
        Dim colorBox As New PictureBox With {
        .Width = 16,
        .Height = 16,
        .Left = 20,
        .Top = (cardPanel.Height - 16) \ 2,
        .BackColor = ColorTranslator.FromHtml(colorHex)
    }

        ' Channel name
        Dim lblName As New Label With {
        .Text = channel,
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .Left = 45,
        .Top = (cardPanel.Height - 18) \ 2 - 2,
        .AutoSize = True
    }

        ' Percentage (right aligned)
        Dim lblPercent As New Label With {
        .Text = $"{percentage}%",
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .ForeColor = Color.Black,
        .AutoSize = True,
        .Left = cardPanel.Width - 130,
        .Top = 12
    }

        ' Amount
        Dim lblAmount As New Label With {
        .Text = $"₱{amount.ToString("N2")}",
        .Font = New Font("Segoe UI", 9, FontStyle.Regular),
        .ForeColor = Color.Gray,
        .AutoSize = True,
        .Left = cardPanel.Width - 150,
        .Top = 35
    }

        ' Add to card
        cardPanel.Controls.Add(colorBox)
        cardPanel.Controls.Add(lblName)
        cardPanel.Controls.Add(lblPercent)
        cardPanel.Controls.Add(lblAmount)
        Panel5.Controls.Add(cardPanel)
    End Sub

    Private Sub Dashboard_Resize(sender As Object, e As EventArgs) Handles Me.Resize


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

End Class