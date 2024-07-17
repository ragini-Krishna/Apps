Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles

Public Class SalesForecast
    Private originalData As DataTable
    Dim conn As SqlConnection = New SqlConnection("data source=DESKTOP-EUJN8A8\SQLEXPRESS;initial catalog=rag;trusted_connection=true")
    Private Sub SalesForecast_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        LoadYears()
        LoadStates()
        CmbState.Visible = False
        Lbstate.Visible = False
    End Sub
    Private Sub LoadYears()
        Dim cmd As New SqlCommand("SELECT DISTINCT YEAR(OrderDate) AS Year FROM Orders order by YEAR(OrderDate)  desc", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        While reader.Read()
            ComboBoxYears.Items.Add(reader("Year").ToString())
        End While
        reader.Close()
    End Sub

    Private Sub LoadStates()

        Dim cmd As New SqlCommand("SELECT DISTINCT State FROM Orders order by State", conn)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
            CmbState.Items.Add(reader("State").ToString())
        End While
        reader.Close()
    End Sub

    Private Sub ButtonQuerySales_Click(sender As Object, e As EventArgs) Handles ButtonQuerySales.Click
        Dim selectedYear As Integer = Integer.Parse(ComboBoxYears.SelectedItem.ToString())

        QuerySales(selectedYear)

    End Sub
    Private Sub QuerySales(year As Integer)


        Dim cmd As New SqlCommand("SELECT O.State, SUM(P.Sales) AS TotalSales 
                                       FROM Orders O 
                                       INNER JOIN Products P ON O.OrderId = P.OrderId 
                                       LEFT JOIN OrdersReturns R ON O.OrderID = R.OrderID 
                                       WHERE YEAR(O.OrderDate) = @Year AND O.OrderId not in (select distinct OrderId from  OrdersReturns )
                                       GROUP BY O.State
									   order by O.State", conn)
        cmd.Parameters.AddWithValue("@Year", year)

        Dim adapter As New SqlDataAdapter(cmd)
            Dim dt As New DataTable()
        adapter.Fill(dt)
        originalData = dt.Copy()
        DataGridViewSales.DataSource = dt
        ' End Using
    End Sub

    Private Sub SalesForecast_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
    End Sub

    Private Sub ButtonApplyPercentage_Click(sender As Object, e As EventArgs) Handles ButtonApplyPercentage.Click
        If Not RBSelectedState.Checked Or RBAllState.Checked Then
            MsgBox("Please Select either by All state or  By selected State to calculate percentage increment!!")
        End If
        If TextBoxPercentage.Text = Nothing Then
            MsgBox("Please Percentage for Increment")
            Exit Sub
        End If
        Dim percentage As Double = Double.Parse(TextBoxPercentage.Text) / 100
        If RBAllState.Checked Then
            ApplyPercentageIncreaseForState(percentage)
        ElseIf RBSelectedState.Checked Then
            If CmbState.SelectedIndex = -1 Then
                MsgBox("Kindly select the state")
                Exit Sub
            End If
            Dim selectedState As String = CmbState.SelectedItem.ToString()
            ' ApplyPercentageIncreaseSelectedState(selectedState, percentage)
            FilterDataByState(selectedState, percentage)
        End If

    End Sub
    Private Sub AddForecastedSalesColumn()

        If Not DataGridViewSales.Columns.Contains("ForecastedSales") Then
            Dim forecastedSalesColumn As New DataGridViewTextBoxColumn()
            forecastedSalesColumn.Name = "ForecastedSales"
            forecastedSalesColumn.HeaderText = "Forecasted Sales"
            DataGridViewSales.Columns.Add(forecastedSalesColumn)
        End If
    End Sub


    Private Sub ApplyPercentageIncreaseForState(percentage As Double)
        AddForecastedSalesColumn()
        For Each row As DataGridViewRow In DataGridViewSales.Rows
            Dim totalSales As Double = Double.Parse(row.Cells("TotalSales").Value.ToString())
            Dim forecastedSales As Double = totalSales * (1 + percentage)
            row.Cells("ForecastedSales").Value = forecastedSales
        Next
    End Sub
    Private Sub ButtonExportCSV_Click(sender As Object, e As EventArgs) Handles ButtonExportCSV.Click

        ExportToCSV()
    End Sub

    Private Sub ExportToCSV()

        SaveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        SaveFileDialog1.Title = "Save Forecasted Sales Data"


        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sb As New System.Text.StringBuilder()
            sb.AppendLine("State,PercentageIncrease,SalesValue")
            For Each row As DataGridViewRow In DataGridViewSales.Rows
                Dim state As String = row.Cells("State").Value.ToString()
                Dim salesValue As String = row.Cells("ForecastedSales").Value.ToString()
                sb.AppendLine($"{state},{TextBoxPercentage.Text},{salesValue}")
            Next
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, sb.ToString())
            MessageBox.Show("Data exported to " & SaveFileDialog1.FileName)
        End If
    End Sub

    Private Sub FilterDataByState(state As String, percentage As Double)

        Dim dt As DataTable = originalData.Clone()


        If Not dt.Columns.Contains("ForecastedSales") Then
            dt.Columns.Add("ForecastedSales", GetType(Double))
        End If


        For Each row As DataRow In originalData.Rows
            If row("State").ToString() = state Then
                Dim totalSales As Double = Double.Parse(row("TotalSales").ToString())
                Dim forecastedSales As Double = totalSales * (1 + percentage)
                Dim newRow As DataRow = dt.NewRow()
                newRow.ItemArray = row.ItemArray.Clone()
                newRow("ForecastedSales") = forecastedSales
                dt.Rows.Add(newRow)
            End If
            Exit For
        Next

        DataGridViewSales.DataSource = dt
    End Sub

    Private Sub ButtonClearFilter_Click(sender As Object, e As EventArgs) Handles ButtonClearFilter.Click

        DataGridViewSales.DataSource = originalData
    End Sub




    Private Sub ButtonShowChart_Click(sender As Object, e As EventArgs) Handles ButtonShowChart.Click

        ShowPieChart()
    End Sub

    Private Sub ShowPieChart()
        ChartSales.Series.Clear()
        Dim series As New Series("Sales")
        series.ChartType = SeriesChartType.Pie
        For Each row As DataGridViewRow In DataGridViewSales.Rows
            series.Points.AddXY(row.Cells("State").Value.ToString(), row.Cells("TotalSales").Value)
        Next
        ChartSales.Series.Add(series)
    End Sub

    Private Sub RBSelectedState_CheckedChanged(sender As Object, e As EventArgs) Handles RBSelectedState.CheckedChanged
        If RBSelectedState.Checked Then
            CmbState.Visible = True
            Lbstate.Visible = True
        Else
            CmbState.Visible = False
            Lbstate.Visible = False
        End If
    End Sub
End Class



