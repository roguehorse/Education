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

    'Assign global variable to hold double value for final calculation
    Dim decTotalCost As Decimal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cboxAppliances_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxAppliances.SelectedIndexChanged

        'Dropdown list of appliances available for selection

    End Sub

    Private Sub txtKwRating_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKwRating.TextChanged

        'Entry of appliance kW rating against variable

            'Error handling in case input is not in numeric value
            Try

                'Determines if input is a valid number or text
            decTotalCost = CDec(txtKwRating.Text)

            'Print input into Total Cost
            txtTotalCost.Text = decTotalCost.ToString()

            Catch ex As Exception

                'Call error handler subroutine
                ErrorHandler()

                'Clear incorrect value input
                txtKwRating.Clear()

            End Try

    End Sub

    Private Sub txtRatePerHour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRatePerHour.TextChanged

        'Monetary rate per hour variable assignment

            'Error handling in case input is not in numeric value
            Try

                'Determines if input is a valid number or text
            decTotalCost = CDec(txtRatePerHour.Text)

            'Print input into Total Cost
            txtTotalCost.Text = decTotalCost.ToString()

            Catch ex As Exception

                'Call error handler subroutine
                ErrorHandler()

                'Clear incorrect value input
                txtRatePerHour.Clear()

            End Try

    End Sub

    Private Sub txtHoursUsed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHoursUsed.TextChanged

        'Hours of operation used variable assignment

            'Error handling in case input is not in numeric value
            Try

                'Determines if input is a valid number or text
            decTotalCost = CDec(txtHoursUsed.Text)

            'Print input into Total Cost
            txtTotalCost.Text = decTotalCost.ToString()

            'Call final result procedure
            FinalResult()

            Catch ex As Exception

                'Call error handler subroutine
            ErrorHandler()

                'Clear incorrect value input
                txtHoursUsed.Clear()

        End Try

    End Sub

    Private Sub txtTotalCost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalCost.TextChanged

        'Change text color to red
        txtTotalCost.ForeColor = Color.IndianRed

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clears all fields and restarts application

            txtKwRating.Clear()
            txtRatePerHour.Clear()
            txtHoursUsed.Clear()
            txtTotalCost.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        'Close program
        Me.Close()

    End Sub

    '********************************Subroutine for final result***********************************

    Sub FinalResult()

        'Perform calculation on variables and assign to dblTotalCost
        decTotalCost = CDec(txtKwRating.Text) * CDec(txtRatePerHour.Text) * CDec(txtHoursUsed.Text) / 100000

        'Event handler to convert variable to a text string and format to monetary value
        'then display in Total Cost TextBox
        txtTotalCost.Text = decTotalCost.ToString("c")

    End Sub

    '***********************************************************************************************

    '********************************Subroutine for error handling**********************************

    Sub ErrorHandler()

        'Display error message if input is incorrect
        MessageBox.Show("Input must be a number, please try again")

    End Sub

    '***********************************************************************************************

End Class
