<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.lblApplianceSelect = New System.Windows.Forms.Label()
        Me.cboxAppliances = New System.Windows.Forms.ComboBox()
        Me.txtKwRating = New System.Windows.Forms.TextBox()
        Me.lblEnterKw = New System.Windows.Forms.Label()
        Me.txtRatePerHour = New System.Windows.Forms.TextBox()
        Me.lblKwValue = New System.Windows.Forms.Label()
        Me.lblHoursUsed = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRatingExample = New System.Windows.Forms.Label()
        Me.lblRateExample = New System.Windows.Forms.Label()
        Me.lblMustBe = New System.Windows.Forms.Label()
        Me.txtGalPerHour = New System.Windows.Forms.TextBox()
        Me.txtPricePerGallon = New System.Windows.Forms.TextBox()
        Me.lblGalPerHour = New System.Windows.Forms.Label()
        Me.lblCostPerGallon = New System.Windows.Forms.Label()
        Me.lblGalExample = New System.Windows.Forms.Label()
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.lblFinalInputNote = New System.Windows.Forms.Label()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.txtItemList = New System.Windows.Forms.ListBox()
        Me.txtCombinedExpense = New System.Windows.Forms.TextBox()
        Me.txtCombinedTotal = New System.Windows.Forms.Label()
        Me.lblItemsCollect = New System.Windows.Forms.Label()
        Me.txtHoursUsedList = New System.Windows.Forms.ListBox()
        Me.txtCostList = New System.Windows.Forms.ListBox()
        Me.lblCostList = New System.Windows.Forms.Label()
        Me.btnClearTable = New System.Windows.Forms.Button()
        Me.lblHoursUsedList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(207, 4)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(230, 25)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Appliance Calculator"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApplianceSelect
        '
        Me.lblApplianceSelect.AutoSize = True
        Me.lblApplianceSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplianceSelect.Location = New System.Drawing.Point(25, 75)
        Me.lblApplianceSelect.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApplianceSelect.Name = "lblApplianceSelect"
        Me.lblApplianceSelect.Size = New System.Drawing.Size(110, 16)
        Me.lblApplianceSelect.TabIndex = 2
        Me.lblApplianceSelect.Text = "Select Appliance"
        Me.lblApplianceSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboxAppliances
        '
        Me.cboxAppliances.AutoCompleteCustomSource.AddRange(New String() {"Refrigerator", "Convection Oven", "Air Conditioning"})
        Me.cboxAppliances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxAppliances.FormattingEnabled = True
        Me.cboxAppliances.Items.AddRange(New Object() {"Refrigerator", "Convection Oven", "Air Conditioner", "Washer"})
        Me.cboxAppliances.Location = New System.Drawing.Point(142, 72)
        Me.cboxAppliances.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxAppliances.Name = "cboxAppliances"
        Me.cboxAppliances.Size = New System.Drawing.Size(160, 24)
        Me.cboxAppliances.TabIndex = 3
        Me.cboxAppliances.UseWaitCursor = True
        '
        'txtKwRating
        '
        Me.txtKwRating.Location = New System.Drawing.Point(142, 107)
        Me.txtKwRating.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKwRating.MaxLength = 5
        Me.txtKwRating.Name = "txtKwRating"
        Me.txtKwRating.Size = New System.Drawing.Size(160, 22)
        Me.txtKwRating.TabIndex = 4
        Me.txtKwRating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEnterKw
        '
        Me.lblEnterKw.AutoSize = True
        Me.lblEnterKw.Location = New System.Drawing.Point(25, 110)
        Me.lblEnterKw.Name = "lblEnterKw"
        Me.lblEnterKw.Size = New System.Drawing.Size(111, 16)
        Me.lblEnterKw.TabIndex = 5
        Me.lblEnterKw.Text = "Enter Watt Rating"
        '
        'txtRatePerHour
        '
        Me.txtRatePerHour.Location = New System.Drawing.Point(142, 158)
        Me.txtRatePerHour.MaxLength = 5
        Me.txtRatePerHour.Name = "txtRatePerHour"
        Me.txtRatePerHour.Size = New System.Drawing.Size(160, 22)
        Me.txtRatePerHour.TabIndex = 6
        Me.txtRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKwValue
        '
        Me.lblKwValue.AutoSize = True
        Me.lblKwValue.Location = New System.Drawing.Point(20, 161)
        Me.lblKwValue.Name = "lblKwValue"
        Me.lblKwValue.Size = New System.Drawing.Size(115, 16)
        Me.lblKwValue.TabIndex = 7
        Me.lblKwValue.Text = "kW Rate per Hour"
        '
        'lblHoursUsed
        '
        Me.lblHoursUsed.AutoSize = True
        Me.lblHoursUsed.Location = New System.Drawing.Point(32, 213)
        Me.lblHoursUsed.Name = "lblHoursUsed"
        Me.lblHoursUsed.Size = New System.Drawing.Size(103, 16)
        Me.lblHoursUsed.TabIndex = 9
        Me.lblHoursUsed.Text = "kW Hours Used"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(104, 352)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(91, 20)
        Me.lblTotalCost.TabIndex = 10
        Me.lblTotalCost.Text = "Total Cost"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTotalCost.Location = New System.Drawing.Point(28, 388)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(238, 19)
        Me.txtTotalCost.TabIndex = 11
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(26, 420)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(108, 420)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblRatingExample
        '
        Me.lblRatingExample.AutoSize = True
        Me.lblRatingExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRatingExample.Location = New System.Drawing.Point(207, 133)
        Me.lblRatingExample.Name = "lblRatingExample"
        Me.lblRatingExample.Size = New System.Drawing.Size(95, 13)
        Me.lblRatingExample.TabIndex = 15
        Me.lblRatingExample.Text = "i.e. 12kW = 12000"
        '
        'lblRateExample
        '
        Me.lblRateExample.AutoSize = True
        Me.lblRateExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateExample.Location = New System.Drawing.Point(216, 183)
        Me.lblRateExample.Name = "lblRateExample"
        Me.lblRateExample.Size = New System.Drawing.Size(86, 13)
        Me.lblRateExample.TabIndex = 16
        Me.lblRateExample.Text = "i.e.  $.45/hr = 45"
        '
        'lblMustBe
        '
        Me.lblMustBe.AutoSize = True
        Me.lblMustBe.ForeColor = System.Drawing.Color.Red
        Me.lblMustBe.Location = New System.Drawing.Point(55, 38)
        Me.lblMustBe.Name = "lblMustBe"
        Me.lblMustBe.Size = New System.Drawing.Size(217, 16)
        Me.lblMustBe.TabIndex = 17
        Me.lblMustBe.Text = "kW Hours Used Must Be Final Input"
        '
        'txtGalPerHour
        '
        Me.txtGalPerHour.Location = New System.Drawing.Point(142, 258)
        Me.txtGalPerHour.Name = "txtGalPerHour"
        Me.txtGalPerHour.Size = New System.Drawing.Size(160, 22)
        Me.txtGalPerHour.TabIndex = 20
        Me.txtGalPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGalPerHour.Visible = False
        '
        'txtPricePerGallon
        '
        Me.txtPricePerGallon.Location = New System.Drawing.Point(142, 309)
        Me.txtPricePerGallon.Name = "txtPricePerGallon"
        Me.txtPricePerGallon.Size = New System.Drawing.Size(160, 22)
        Me.txtPricePerGallon.TabIndex = 21
        Me.txtPricePerGallon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPricePerGallon.Visible = False
        '
        'lblGalPerHour
        '
        Me.lblGalPerHour.AutoSize = True
        Me.lblGalPerHour.Location = New System.Drawing.Point(40, 261)
        Me.lblGalPerHour.Name = "lblGalPerHour"
        Me.lblGalPerHour.Size = New System.Drawing.Size(95, 16)
        Me.lblGalPerHour.TabIndex = 22
        Me.lblGalPerHour.Text = "Gallons Per Hr"
        Me.lblGalPerHour.Visible = False
        '
        'lblCostPerGallon
        '
        Me.lblCostPerGallon.AutoSize = True
        Me.lblCostPerGallon.Location = New System.Drawing.Point(30, 312)
        Me.lblCostPerGallon.Name = "lblCostPerGallon"
        Me.lblCostPerGallon.Size = New System.Drawing.Size(105, 16)
        Me.lblCostPerGallon.TabIndex = 23
        Me.lblCostPerGallon.Text = "Price Per Gallon"
        Me.lblCostPerGallon.Visible = False
        '
        'lblGalExample
        '
        Me.lblGalExample.AutoSize = True
        Me.lblGalExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGalExample.Location = New System.Drawing.Point(209, 334)
        Me.lblGalExample.Name = "lblGalExample"
        Me.lblGalExample.Size = New System.Drawing.Size(93, 13)
        Me.lblGalExample.TabIndex = 24
        Me.lblGalExample.Text = "i.e.  $.45/Gal = 45"
        Me.lblGalExample.Visible = False
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoursUsed.Location = New System.Drawing.Point(142, 211)
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(160, 22)
        Me.txtHoursUsed.TabIndex = 8
        Me.txtHoursUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFinalInputNote
        '
        Me.lblFinalInputNote.AutoSize = True
        Me.lblFinalInputNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalInputNote.ForeColor = System.Drawing.Color.Red
        Me.lblFinalInputNote.Location = New System.Drawing.Point(201, 236)
        Me.lblFinalInputNote.Name = "lblFinalInputNote"
        Me.lblFinalInputNote.Size = New System.Drawing.Size(101, 13)
        Me.lblFinalInputNote.TabIndex = 25
        Me.lblFinalInputNote.Text = "Must Be Final Input!"
        '
        'btnAddToList
        '
        Me.btnAddToList.Location = New System.Drawing.Point(189, 420)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddToList.TabIndex = 26
        Me.btnAddToList.Text = "To List"
        Me.btnAddToList.UseVisualStyleBackColor = True
        '
        'txtItemList
        '
        Me.txtItemList.FormattingEnabled = True
        Me.txtItemList.ItemHeight = 16
        Me.txtItemList.Location = New System.Drawing.Point(343, 70)
        Me.txtItemList.Name = "txtItemList"
        Me.txtItemList.Size = New System.Drawing.Size(128, 276)
        Me.txtItemList.TabIndex = 27
        '
        'txtCombinedExpense
        '
        Me.txtCombinedExpense.BackColor = System.Drawing.SystemColors.Menu
        Me.txtCombinedExpense.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCombinedExpense.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCombinedExpense.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCombinedExpense.Location = New System.Drawing.Point(343, 388)
        Me.txtCombinedExpense.Name = "txtCombinedExpense"
        Me.txtCombinedExpense.Size = New System.Drawing.Size(283, 19)
        Me.txtCombinedExpense.TabIndex = 28
        Me.txtCombinedExpense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCombinedTotal
        '
        Me.txtCombinedTotal.AutoSize = True
        Me.txtCombinedTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCombinedTotal.Location = New System.Drawing.Point(397, 352)
        Me.txtCombinedTotal.Name = "txtCombinedTotal"
        Me.txtCombinedTotal.Size = New System.Drawing.Size(176, 20)
        Me.txtCombinedTotal.TabIndex = 29
        Me.txtCombinedTotal.Text = "Combined Total Cost"
        Me.txtCombinedTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblItemsCollect
        '
        Me.lblItemsCollect.AutoSize = True
        Me.lblItemsCollect.Location = New System.Drawing.Point(368, 51)
        Me.lblItemsCollect.Name = "lblItemsCollect"
        Me.lblItemsCollect.Size = New System.Drawing.Size(69, 16)
        Me.lblItemsCollect.TabIndex = 30
        Me.lblItemsCollect.Text = "Appliance"
        '
        'txtHoursUsedList
        '
        Me.txtHoursUsedList.FormattingEnabled = True
        Me.txtHoursUsedList.ItemHeight = 16
        Me.txtHoursUsedList.Location = New System.Drawing.Point(470, 70)
        Me.txtHoursUsedList.Name = "txtHoursUsedList"
        Me.txtHoursUsedList.Size = New System.Drawing.Size(80, 276)
        Me.txtHoursUsedList.TabIndex = 31
        '
        'txtCostList
        '
        Me.txtCostList.FormattingEnabled = True
        Me.txtCostList.ItemHeight = 16
        Me.txtCostList.Location = New System.Drawing.Point(549, 70)
        Me.txtCostList.Name = "txtCostList"
        Me.txtCostList.Size = New System.Drawing.Size(77, 276)
        Me.txtCostList.TabIndex = 33
        '
        'lblCostList
        '
        Me.lblCostList.AutoSize = True
        Me.lblCostList.Location = New System.Drawing.Point(567, 51)
        Me.lblCostList.Name = "lblCostList"
        Me.lblCostList.Size = New System.Drawing.Size(35, 16)
        Me.lblCostList.TabIndex = 34
        Me.lblCostList.Text = "Cost"
        '
        'btnClearTable
        '
        Me.btnClearTable.Location = New System.Drawing.Point(442, 420)
        Me.btnClearTable.Name = "btnClearTable"
        Me.btnClearTable.Size = New System.Drawing.Size(92, 23)
        Me.btnClearTable.TabIndex = 41
        Me.btnClearTable.Text = "Clear Table"
        Me.btnClearTable.UseVisualStyleBackColor = True
        '
        'lblHoursUsedList
        '
        Me.lblHoursUsedList.AutoSize = True
        Me.lblHoursUsedList.Location = New System.Drawing.Point(470, 51)
        Me.lblHoursUsedList.Name = "lblHoursUsedList"
        Me.lblHoursUsedList.Size = New System.Drawing.Size(80, 16)
        Me.lblHoursUsedList.TabIndex = 32
        Me.lblHoursUsedList.Text = "Hours Used"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(653, 451)
        Me.Controls.Add(Me.btnClearTable)
        Me.Controls.Add(Me.lblCostList)
        Me.Controls.Add(Me.txtCostList)
        Me.Controls.Add(Me.lblHoursUsedList)
        Me.Controls.Add(Me.txtHoursUsedList)
        Me.Controls.Add(Me.lblItemsCollect)
        Me.Controls.Add(Me.txtCombinedTotal)
        Me.Controls.Add(Me.txtCombinedExpense)
        Me.Controls.Add(Me.txtItemList)
        Me.Controls.Add(Me.btnAddToList)
        Me.Controls.Add(Me.lblFinalInputNote)
        Me.Controls.Add(Me.txtHoursUsed)
        Me.Controls.Add(Me.lblGalExample)
        Me.Controls.Add(Me.lblCostPerGallon)
        Me.Controls.Add(Me.lblGalPerHour)
        Me.Controls.Add(Me.txtPricePerGallon)
        Me.Controls.Add(Me.txtGalPerHour)
        Me.Controls.Add(Me.lblMustBe)
        Me.Controls.Add(Me.lblRateExample)
        Me.Controls.Add(Me.lblRatingExample)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblHoursUsed)
        Me.Controls.Add(Me.lblKwValue)
        Me.Controls.Add(Me.txtRatePerHour)
        Me.Controls.Add(Me.lblEnterKw)
        Me.Controls.Add(Me.txtKwRating)
        Me.Controls.Add(Me.cboxAppliances)
        Me.Controls.Add(Me.lblApplianceSelect)
        Me.Controls.Add(Me.txtTitle)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sdubois_wk3_v1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.Label
    Friend WithEvents lblApplianceSelect As System.Windows.Forms.Label
    Friend WithEvents cboxAppliances As System.Windows.Forms.ComboBox
    Friend WithEvents txtKwRating As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterKw As System.Windows.Forms.Label
    Friend WithEvents txtRatePerHour As System.Windows.Forms.TextBox
    Friend WithEvents lblKwValue As System.Windows.Forms.Label
    Friend WithEvents lblHoursUsed As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblRatingExample As System.Windows.Forms.Label
    Friend WithEvents lblRateExample As System.Windows.Forms.Label
    Friend WithEvents lblMustBe As System.Windows.Forms.Label
    Friend WithEvents txtGalPerHour As System.Windows.Forms.TextBox
    Friend WithEvents txtPricePerGallon As System.Windows.Forms.TextBox
    Friend WithEvents lblGalPerHour As System.Windows.Forms.Label
    Friend WithEvents lblCostPerGallon As System.Windows.Forms.Label
    Friend WithEvents lblGalExample As System.Windows.Forms.Label
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalInputNote As System.Windows.Forms.Label
    Friend WithEvents btnAddToList As System.Windows.Forms.Button
    Friend WithEvents txtItemList As System.Windows.Forms.ListBox
    Friend WithEvents txtCombinedExpense As System.Windows.Forms.TextBox
    Friend WithEvents txtCombinedTotal As System.Windows.Forms.Label
    Friend WithEvents lblItemsCollect As System.Windows.Forms.Label
    Friend WithEvents txtHoursUsedList As System.Windows.Forms.ListBox
    Friend WithEvents txtCostList As System.Windows.Forms.ListBox
    Friend WithEvents lblCostList As System.Windows.Forms.Label
    Friend WithEvents btnClearTable As System.Windows.Forms.Button
    Friend WithEvents lblHoursUsedList As System.Windows.Forms.Label

End Class
