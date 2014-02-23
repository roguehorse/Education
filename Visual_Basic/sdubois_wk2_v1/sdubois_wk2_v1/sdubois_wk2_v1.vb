Public Class sdubois_wk2_v1

    'Design, implement, test and debug a Visual Basic program to create
    'a simple home utility auditing program.
    '***************************************
    '* Enter the cost per kilowatt-hour
    '* Select a home appliance from a list of home appliances
    '* Enter the power needed in kilowatts (kW) for the selected appliance
    '* Enter the number of hours used per day for the selected appliance
    '***************************************
    'The program should do the following:
    '* Validate that the data entered has the correct format and
    '   is within a reasonable range
    '* Calculate and display the cost for operating a home appliance as soon
    '   as the data is entered



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboxAppliances_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxAppliances.SelectedIndexChanged

        'Dropdown list of appliances available for selection

    End Sub

    Private Sub txtKwRating_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKwRating.TextChanged

        'Entry of appliance kW rating against variable

    End Sub

    Private Sub txtRatePerHour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRatePerHour.TextChanged

        'Monetary rate per hour variable assignment

    End Sub

    Private Sub txtHoursUsed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoursUsed.TextChanged

        'Hours of operation used variable assignment

    End Sub

    Private Sub txtTotalCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalCost.TextChanged

        ' Display results in the TextBox here from button event handler

        'Change text color to red
        txtTotalCost.ForeColor = Color.IndianRed

    End Sub

    Private Sub btnResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResults.Click

        'Perform calculation on input values and store in variable
        'Include exception handling in case input is not in numeric form

        'Assign local variable to hold double value for calculation
        Dim decTotalCost As Decimal


        'Exception handles error if text is input instead of number
        Try
            'Perform calculation on variables and assign to dblTotalCost
            decTotalCost = CDec(txtKwRating.Text) * CDec(txtRatePerHour.Text) * CDec(txtHoursUsed.Text)

            'Divide value by 1000 to convert from watts to kW
            decTotalCost = decTotalCost / 1000

            'Event handler to convert variable to a text string and format to monetary value
            'then display in Total Cost TextBox
            txtTotalCost.Text = decTotalCost.ToString("c")

        Catch
            'Display error message if input is incorrect
            MessageBox.Show("An input was not in number format, please try again")

            'Clear values and reset form
            cboxAppliances.SelectedIndex = -1
            txtKwRating.Clear()
            txtRatePerHour.Clear()
            txtHoursUsed.Clear()
            txtTotalCost.Clear()

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clear values and reset form 
        cboxAppliances.SelectedIndex = -1
        txtKwRating.Clear()
        txtRatePerHour.Clear()
        txtHoursUsed.Clear()
        txtTotalCost.Clear()

        'Set focus on appliance selection (top of form)
        cboxAppliances.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        'Close program
        Me.Close()

    End Sub
End Class
