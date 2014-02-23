<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdubois_wk2_v1
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
        Me.txtHoursUsed = New System.Windows.Forms.TextBox()
        Me.lblHoursUsed = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblRatingExample = New System.Windows.Forms.Label()
        Me.lblRateExample = New System.Windows.Forms.Label()
        Me.lblMustBe = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(128, 21)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(159, 25)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "kW Calculator"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApplianceSelect
        '
        Me.lblApplianceSelect.AutoSize = True
        Me.lblApplianceSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplianceSelect.Location = New System.Drawing.Point(88, 84)
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
        Me.cboxAppliances.Items.AddRange(New Object() {"Refrigerator", "Convection Oven", "Air Conditioner"})
        Me.cboxAppliances.Location = New System.Drawing.Point(205, 81)
        Me.cboxAppliances.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxAppliances.Name = "cboxAppliances"
        Me.cboxAppliances.Size = New System.Drawing.Size(160, 24)
        Me.cboxAppliances.TabIndex = 3
        Me.cboxAppliances.UseWaitCursor = True
        '
        'txtKwRating
        '
        Me.txtKwRating.Location = New System.Drawing.Point(205, 116)
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
        Me.lblEnterKw.Location = New System.Drawing.Point(88, 119)
        Me.lblEnterKw.Name = "lblEnterKw"
        Me.lblEnterKw.Size = New System.Drawing.Size(111, 16)
        Me.lblEnterKw.TabIndex = 5
        Me.lblEnterKw.Text = "Enter Watt Rating"
        '
        'txtRatePerHour
        '
        Me.txtRatePerHour.Location = New System.Drawing.Point(205, 167)
        Me.txtRatePerHour.MaxLength = 5
        Me.txtRatePerHour.Name = "txtRatePerHour"
        Me.txtRatePerHour.Size = New System.Drawing.Size(160, 22)
        Me.txtRatePerHour.TabIndex = 6
        Me.txtRatePerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblKwValue
        '
        Me.lblKwValue.AutoSize = True
        Me.lblKwValue.Location = New System.Drawing.Point(49, 170)
        Me.lblKwValue.Name = "lblKwValue"
        Me.lblKwValue.Size = New System.Drawing.Size(149, 16)
        Me.lblKwValue.TabIndex = 7
        Me.lblKwValue.Text = "Enter kW Rate per Hour"
        '
        'txtHoursUsed
        '
        Me.txtHoursUsed.Location = New System.Drawing.Point(205, 219)
        Me.txtHoursUsed.Name = "txtHoursUsed"
        Me.txtHoursUsed.Size = New System.Drawing.Size(160, 22)
        Me.txtHoursUsed.TabIndex = 8
        Me.txtHoursUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHoursUsed
        '
        Me.lblHoursUsed.AutoSize = True
        Me.lblHoursUsed.Location = New System.Drawing.Point(118, 222)
        Me.lblHoursUsed.Name = "lblHoursUsed"
        Me.lblHoursUsed.Size = New System.Drawing.Size(80, 16)
        Me.lblHoursUsed.TabIndex = 9
        Me.lblHoursUsed.Text = "Hours Used"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(157, 267)
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
        Me.txtTotalCost.Location = New System.Drawing.Point(149, 290)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(110, 19)
        Me.txtTotalCost.TabIndex = 11
        Me.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClear.Location = New System.Drawing.Point(123, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(205, 332)
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
        Me.lblRatingExample.Location = New System.Drawing.Point(270, 142)
        Me.lblRatingExample.Name = "lblRatingExample"
        Me.lblRatingExample.Size = New System.Drawing.Size(95, 13)
        Me.lblRatingExample.TabIndex = 15
        Me.lblRatingExample.Text = "i.e. 12kW = 12000"
        '
        'lblRateExample
        '
        Me.lblRateExample.AutoSize = True
        Me.lblRateExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRateExample.Location = New System.Drawing.Point(279, 192)
        Me.lblRateExample.Name = "lblRateExample"
        Me.lblRateExample.Size = New System.Drawing.Size(86, 13)
        Me.lblRateExample.TabIndex = 16
        Me.lblRateExample.Text = "i.e.  $.45/hr = 45"
        '
        'lblMustBe
        '
        Me.lblMustBe.AutoSize = True
        Me.lblMustBe.ForeColor = System.Drawing.Color.Red
        Me.lblMustBe.Location = New System.Drawing.Point(109, 46)
        Me.lblMustBe.Name = "lblMustBe"
        Me.lblMustBe.Size = New System.Drawing.Size(194, 16)
        Me.lblMustBe.TabIndex = 17
        Me.lblMustBe.Text = "Hours Used Must Be Final Input"
        '
        'sdubois_wk2_v1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(417, 388)
        Me.Controls.Add(Me.lblMustBe)
        Me.Controls.Add(Me.lblRateExample)
        Me.Controls.Add(Me.lblRatingExample)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblHoursUsed)
        Me.Controls.Add(Me.txtHoursUsed)
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
        Me.Name = "sdubois_wk2_v1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sdubois_wk2_v2"
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
    Friend WithEvents txtHoursUsed As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursUsed As System.Windows.Forms.Label
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblRatingExample As System.Windows.Forms.Label
    Friend WithEvents lblRateExample As System.Windows.Forms.Label
    Friend WithEvents lblMustBe As System.Windows.Forms.Label

End Class
