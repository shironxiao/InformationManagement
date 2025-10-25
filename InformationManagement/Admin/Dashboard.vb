Imports System.Windows.Forms.DataVisualization.Charting

Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#F7F8FA")
        InitializePieChartAndCards()
    End Sub

    Private Sub InitializePieChartAndCards()
        ' Clear existing controls in Panel5
        Panel5.Controls.Clear()
        Panel5.BackColor = Color.White
        Panel5.Padding = New Padding(20)

        ' ---------- TITLE ----------
        Dim lblTitle As New Label With {
            .Text = "Sales by Channel",
            .Font = New Font("Segoe UI Semibold", 10, FontStyle.Regular),
            .ForeColor = Color.Gray,
            .Left = 15,
            .Top = 10,
            .AutoSize = True
        }
        Panel5.Controls.Add(lblTitle)

        ' ---------- PIE CHART ----------
        Dim chart As New Chart()
        chart.Width = 250
        chart.Height = 250
        chart.Left = 40
        chart.Top = 30
        chart.BackColor = Color.Transparent

        Dim chartArea As New ChartArea()
        chartArea.BackColor = Color.Transparent
        chart.ChartAreas.Add(chartArea)

        Dim series As New Series("Sales")
        series.ChartType = SeriesChartType.Pie
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

        ' ---------- SALES CARDS (on the right side) ----------
        Dim startX As Integer = 400 ' Right of the pie chart
        Dim startY As Integer = 60
        Dim gap As Integer = 70

        AddSalesCard("Dine-in", 65, 1950000.0, "#A595E9", startX, startY)
        AddSalesCard("Takeout", 25, 750000.0, "#90D5A9", startX, startY + gap)
        AddSalesCard("Catering", 10, 300000.0, "#FBCB77", startX, startY + gap * 2)
    End Sub

    Private Sub AddSalesCard(channel As String, percentage As Integer, amount As Double, colorHex As String, x As Integer, y As Integer)
        Dim cardPanel As New Panel With {
            .Width = 580,
            .Height = 60,
            .Left = x,
            .Top = y,
            .BackColor = Color.White,
            .BorderStyle = BorderStyle.FixedSingle
        }

        ' Color box
        Dim colorBox As New PictureBox With {
            .Width = 14,
            .Height = 14,
            .Left = 15,
            .Top = 23,
            .BackColor = ColorTranslator.FromHtml(colorHex)
        }

        ' Channel label
        Dim lblName As New Label With {
            .Text = channel,
            .Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold),
            .Left = 38,
            .Top = 20,
            .AutoSize = True
        }

        ' Percentage label
        Dim lblPercent As New Label With {
            .Text = $"{percentage}%",
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .ForeColor = Color.Black,
            .Left = cardPanel.Width - 110,
            .Top = 10,
            .AutoSize = True
        }

        ' Amount label
        Dim lblAmount As New Label With {
            .Text = $"₱{amount.ToString("N2")}",
            .Font = New Font("Segoe UI", 9, FontStyle.Regular),
            .ForeColor = Color.Gray,
            .Left = cardPanel.Width - 130,
            .Top = 32,
            .AutoSize = True
        }

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