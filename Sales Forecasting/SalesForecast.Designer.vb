<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesForecast
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.DataGridViewSales = New System.Windows.Forms.DataGridView()
        Me.ChartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBoxPercentage = New System.Windows.Forms.TextBox()
        Me.ComboBoxYears = New System.Windows.Forms.ComboBox()
        Me.ButtonShowChart = New System.Windows.Forms.Button()
        Me.ButtonQuerySales = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonApplyPercentage = New System.Windows.Forms.Button()
        Me.ButtonExportCSV = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.RBAllState = New System.Windows.Forms.RadioButton()
        Me.RBSelectedState = New System.Windows.Forms.RadioButton()
        Me.CmbState = New System.Windows.Forms.ComboBox()
        Me.Lbstate = New System.Windows.Forms.Label()
        Me.ButtonClearFilter = New System.Windows.Forms.Button()
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewSales
        '
        Me.DataGridViewSales.AllowUserToAddRows = False
        Me.DataGridViewSales.AllowUserToDeleteRows = False
        Me.DataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSales.Location = New System.Drawing.Point(12, 176)
        Me.DataGridViewSales.Name = "DataGridViewSales"
        Me.DataGridViewSales.ReadOnly = True
        Me.DataGridViewSales.Size = New System.Drawing.Size(317, 323)
        Me.DataGridViewSales.TabIndex = 0
        '
        'ChartSales
        '
        ChartArea2.Name = "ChartArea1"
        Me.ChartSales.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.ChartSales.Legends.Add(Legend2)
        Me.ChartSales.Location = New System.Drawing.Point(335, 176)
        Me.ChartSales.Name = "ChartSales"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartSales.Series.Add(Series2)
        Me.ChartSales.Size = New System.Drawing.Size(711, 331)
        Me.ChartSales.TabIndex = 1
        Me.ChartSales.Text = "Sales Report"
        '
        'TextBoxPercentage
        '
        Me.TextBoxPercentage.Location = New System.Drawing.Point(170, 7)
        Me.TextBoxPercentage.Name = "TextBoxPercentage"
        Me.TextBoxPercentage.Size = New System.Drawing.Size(115, 20)
        Me.TextBoxPercentage.TabIndex = 2
        '
        'ComboBoxYears
        '
        Me.ComboBoxYears.FormattingEnabled = True
        Me.ComboBoxYears.Location = New System.Drawing.Point(192, 10)
        Me.ComboBoxYears.Name = "ComboBoxYears"
        Me.ComboBoxYears.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxYears.TabIndex = 3
        '
        'ButtonShowChart
        '
        Me.ButtonShowChart.Location = New System.Drawing.Point(830, 39)
        Me.ButtonShowChart.Name = "ButtonShowChart"
        Me.ButtonShowChart.Size = New System.Drawing.Size(117, 23)
        Me.ButtonShowChart.TabIndex = 6
        Me.ButtonShowChart.Text = "Show Chart"
        Me.ButtonShowChart.UseVisualStyleBackColor = True
        '
        'ButtonQuerySales
        '
        Me.ButtonQuerySales.Location = New System.Drawing.Point(346, 8)
        Me.ButtonQuerySales.Name = "ButtonQuerySales"
        Me.ButtonQuerySales.Size = New System.Drawing.Size(117, 23)
        Me.ButtonQuerySales.TabIndex = 7
        Me.ButtonQuerySales.Text = "Get Sales Data"
        Me.ButtonQuerySales.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Get Sales Data By Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Enter Percentage For Increment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.ButtonQuerySales)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxYears)
        Me.Panel1.Location = New System.Drawing.Point(25, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(496, 37)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.ButtonClearFilter)
        Me.Panel2.Controls.Add(Me.CmbState)
        Me.Panel2.Controls.Add(Me.Lbstate)
        Me.Panel2.Controls.Add(Me.RBSelectedState)
        Me.Panel2.Controls.Add(Me.RBAllState)
        Me.Panel2.Controls.Add(Me.ButtonApplyPercentage)
        Me.Panel2.Controls.Add(Me.TextBoxPercentage)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(25, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(496, 66)
        Me.Panel2.TabIndex = 14
        '
        'ButtonApplyPercentage
        '
        Me.ButtonApplyPercentage.Location = New System.Drawing.Point(409, 16)
        Me.ButtonApplyPercentage.Name = "ButtonApplyPercentage"
        Me.ButtonApplyPercentage.Size = New System.Drawing.Size(84, 36)
        Me.ButtonApplyPercentage.TabIndex = 13
        Me.ButtonApplyPercentage.Text = "Apply Percentage"
        Me.ButtonApplyPercentage.UseVisualStyleBackColor = True
        '
        'ButtonExportCSV
        '
        Me.ButtonExportCSV.Location = New System.Drawing.Point(830, 67)
        Me.ButtonExportCSV.Name = "ButtonExportCSV"
        Me.ButtonExportCSV.Size = New System.Drawing.Size(117, 27)
        Me.ButtonExportCSV.TabIndex = 14
        Me.ButtonExportCSV.Text = "Export Sales Data"
        Me.ButtonExportCSV.UseVisualStyleBackColor = True
        '
        'RBAllState
        '
        Me.RBAllState.AutoSize = True
        Me.RBAllState.Location = New System.Drawing.Point(9, 35)
        Me.RBAllState.Name = "RBAllState"
        Me.RBAllState.Size = New System.Drawing.Size(64, 17)
        Me.RBAllState.TabIndex = 14
        Me.RBAllState.TabStop = True
        Me.RBAllState.Text = "All State"
        Me.RBAllState.UseVisualStyleBackColor = True
        '
        'RBSelectedState
        '
        Me.RBSelectedState.AutoSize = True
        Me.RBSelectedState.Location = New System.Drawing.Point(79, 35)
        Me.RBSelectedState.Name = "RBSelectedState"
        Me.RBSelectedState.Size = New System.Drawing.Size(113, 17)
        Me.RBSelectedState.TabIndex = 15
        Me.RBSelectedState.TabStop = True
        Me.RBSelectedState.Text = "For Selected State"
        Me.RBSelectedState.UseVisualStyleBackColor = True
        '
        'CmbState
        '
        Me.CmbState.FormattingEnabled = True
        Me.CmbState.Location = New System.Drawing.Point(264, 39)
        Me.CmbState.Name = "CmbState"
        Me.CmbState.Size = New System.Drawing.Size(121, 21)
        Me.CmbState.TabIndex = 15
        '
        'Lbstate
        '
        Me.Lbstate.AutoSize = True
        Me.Lbstate.Location = New System.Drawing.Point(198, 39)
        Me.Lbstate.Name = "Lbstate"
        Me.Lbstate.Size = New System.Drawing.Size(65, 13)
        Me.Lbstate.TabIndex = 16
        Me.Lbstate.Text = "Select State"
        '
        'ButtonClearFilter
        '
        Me.ButtonClearFilter.Location = New System.Drawing.Point(310, 10)
        Me.ButtonClearFilter.Name = "ButtonClearFilter"
        Me.ButtonClearFilter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClearFilter.TabIndex = 17
        Me.ButtonClearFilter.Text = "Clear Filter"
        Me.ButtonClearFilter.UseVisualStyleBackColor = True
        '
        'SalesForecast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 519)
        Me.Controls.Add(Me.ButtonExportCSV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonShowChart)
        Me.Controls.Add(Me.ChartSales)
        Me.Controls.Add(Me.DataGridViewSales)
        Me.Name = "SalesForecast"
        Me.Text = "Sales Forecasting"
        CType(Me.DataGridViewSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewSales As DataGridView
    Friend WithEvents ChartSales As DataVisualization.Charting.Chart
    Friend WithEvents TextBoxPercentage As TextBox
    Friend WithEvents ComboBoxYears As ComboBox
    Friend WithEvents ButtonShowChart As Button
    Friend WithEvents ButtonQuerySales As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonApplyPercentage As Button
    Friend WithEvents ButtonExportCSV As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RBSelectedState As RadioButton
    Friend WithEvents RBAllState As RadioButton
    Friend WithEvents CmbState As ComboBox
    Friend WithEvents Lbstate As Label
    Friend WithEvents ButtonClearFilter As Button
End Class
