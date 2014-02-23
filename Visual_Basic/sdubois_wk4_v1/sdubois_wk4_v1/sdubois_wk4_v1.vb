'Declare I/O to write and read from external file
Imports System
Imports System.IO

Public Class Form1

    'Design, implement, test and debug a Visual Basic program to create
    'an enhanced home utility auditing program based on Week 3
    '***************************************
    'The user should be able to do the following:
    '* Enter the cost per kilowatt-hour
    '* Select from a list of home appliances which includes a washer, among other appliances
    '* Enter the power needed in kilowatts (kW) for the selected appliance
    '* Enter the number of hours used per day for the selected appliance
    '* If the washer is selected, enter both the number of gallons of water used by
    '  the washer per hour and the cost per gallon
    '* Export the data in the listing area to an external text file
    '* Change default power ratings of a selected appliance
    '***************************************
    'The program should do the following:
    '* Validate that the data entered has the correct format and
    '  is within a reasonable range
    '* Calculate and display the cost for operating a home appliance as soon
    '  as the data is entered
    '* Create a listing area to display each of the following for each appliance entered
    '* Home appliance
    '* Number of hours per day
    '* Cost
    '* Display and update the total cost of all appliances as soon as a new entry is
    '  added to the listing area
    '* Use arrays or structures where applicable
    '* Read the default power rating for appliances from an external text file

    'Assign global variable to hold double value for final calculation
    Dim decTotalCost As Decimal

    'Assign global variable to collect values and combine results
    Dim decCombinedExpense As Decimal

    'Assign global array max subscript
    Dim aryMAX As Integer = 14

    'Assign arroy counter variable
    Dim aryCount As Integer

    'Create an array from item input value 
    Dim aryItemList(aryMAX) As String

    'Create an array from hours input value
    Dim aryHoursList(aryMAX) As String

    'Create an array from cost input value
    Dim aryCostList(aryMAX) As String

    'Create an array for set watt ratings
    Dim arySetRating() As String = {0, 0, 0, 0}

    'Variable to hold watt array associated to appliance
    Dim collectWatt As StreamWriter


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub cboxAppliances_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxAppliances.SelectedIndexChanged

        'Dropdown list of appliances available for selection

        'If dropdown selection is Washer then show water fields
        If cboxAppliances.SelectedItem Is "Washer" Then

            lblGalPerHour.Show()
            txtGalPerHour.Show()
            lblCostPerGallon.Show()
            txtPricePerGallon.Show()
            lblGalExample.Show()

            'Default watt rating for washer from string
            txtKwRating.Text = (arySetRating(3))

            'If dropdown selection is not washer then hide water fields
        Else

            lblGalPerHour.Hide()
            txtGalPerHour.Hide()
            lblCostPerGallon.Hide()
            txtPricePerGallon.Hide()
            lblGalExample.Hide()

        End If

        'srText.Close()

        If cboxAppliances.SelectedItem Is "Refrigerator" Then

            'Default watt rating for washer from string
            txtKwRating.Text = (arySetRating(0))

        ElseIf cboxAppliances.SelectedItem Is "Convection Oven" Then

            'Default watt rating for washer from string
            txtKwRating.Text = (arySetRating(1))

        ElseIf cboxAppliances.SelectedItem Is "Air Conditioner" Then

            'Default watt rating for washer from string
            txtKwRating.Text = (arySetRating(2))

        End If

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

            'Hours of operation must be less than 24 otherwiose throw error
            If CDec(txtHoursUsed.Text) <= 24 Then

                'Determines if input is a valid number or text
                decTotalCost = CDec(txtHoursUsed.Text)

                'Print input into Total Cost
                txtTotalCost.Text = decTotalCost.ToString()

                'Call final result procedure
                FinalResult()

            Else

                MessageBox.Show("Value must be 24 hours or less")

                'Clear incorrect value input
                txtHoursUsed.Clear()

            End If

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

    Private Sub txtGalPerHour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGalPerHour.TextChanged

        'Input for number of gallons used

        'Error handling in case input is not in numeric value
        Try

            'Determines if input is a valid number or text
            decTotalCost = CDec(txtGalPerHour.Text)

            'Print input into Total Cost
            txtTotalCost.Text = decTotalCost.ToString()

        Catch ex As Exception

            'Call error handler subroutine
            ErrorHandler()

            'Clear incorrect value input
            txtGalPerHour.Clear()

        End Try

    End Sub

    Private Sub txtPricePerGallon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPricePerGallon.TextChanged

        'Input for the price per gallon of water used

        'Error handling in case input is not in numeric value

        Try

            'Determines if input is a valid number or text
            decTotalCost = CDec(txtPricePerGallon.Text)

            'Print input into Total Cost
            txtTotalCost.Text = decTotalCost.ToString()

        Catch ex As Exception

            'Call error handler subroutine
            ErrorHandler()

            'Clear incorrect value input
            txtPricePerGallon.Clear()

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        'Clears all fields and restarts application

        cboxAppliances.SelectedIndex = -1
        txtKwRating.Clear()
        txtRatePerHour.Clear()
        txtHoursUsed.Clear()
        txtTotalCost.Clear()
        txtGalPerHour.Clear()
        txtPricePerGallon.Clear()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        'Close program
        Me.Close()

    End Sub

    '********************************Subroutine for final result***********************************

    Sub FinalResult()

        If cboxAppliances.SelectedItem Is "Washer" Then

            'Perform calculation on variables and assign to dblTotalCost if washer selected
            decTotalCost = (CDec(txtKwRating.Text) * CDec(txtRatePerHour.Text) * CDec(txtHoursUsed.Text) / 100000) + (CDec(txtGalPerHour.Text) * CDec(txtPricePerGallon.Text) / 100)

            'Event handler to convert variable to a text string and format to monetary value
            'then display in Total Cost TextBox
            txtTotalCost.Text = decTotalCost.ToString("c")

        Else

            'Perform calculation on variables and assign to dblTotalCost if washer not selected
            decTotalCost = (CDec(txtKwRating.Text) * CDec(txtRatePerHour.Text) * CDec(txtHoursUsed.Text)) / 100000

            'Event handler to convert variable to a text string and format to monetary value
            'then display in Total Cost TextBox
            txtTotalCost.Text = decTotalCost.ToString("c")

        End If

    End Sub

    '***********************************************************************************************

    '********************************Subroutine for error handling**********************************

    Sub ErrorHandler()

        'Display error message if input is incorrect
        MessageBox.Show("Input must be a number and can not be empty")

    End Sub

    '***********************************************************************************************

    Private Sub txtCombinedExpense_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCombinedExpense.TextChanged

        'Change text color to red
        txtCombinedExpense.ForeColor = Color.IndianRed

    End Sub

    Private Sub btnAddToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToList.Click


        'On click writes appliance and watt setting to file as association

        '******************************Write watt values to external file*******************************

        If cboxAppliances.SelectedItem Is "Refrigerator" Then

            'Set array value if Refrigerator is selected
            arySetRating(0) = txtKwRating.Text

        ElseIf cboxAppliances.SelectedItem Is "Convection Oven" Then

            'Set array value if Conection Oven is selected
            arySetRating(1) = txtKwRating.Text

        ElseIf cboxAppliances.SelectedItem Is "Air Conditioner" Then

            'Set array value if Air Conditioner is selected
            arySetRating(2) = txtKwRating.Text

        ElseIf cboxAppliances.SelectedItem Is "Washer" Then

            'Set array value if Washer is selected
            arySetRating(3) = txtKwRating.Text

        End If


        'On click adds items to list and totals item costs

        '**************************************Add Items To List****************************************

        'Error handling to insure all fields contain a value before adding to list
        If cboxAppliances.Text = "" Then

            MessageBox.Show("An appliance must be selected")

        ElseIf txtKwRating.Text = "" Then

            MessageBox.Show("Field cannot be empty")

        ElseIf txtRatePerHour.Text = "" Then

            MessageBox.Show("Field cannot be empty")

        ElseIf txtHoursUsed.Text = "" Then

            MessageBox.Show("Field cannot be empty")

        ElseIf aryCount < 15 Then

            '****Item Selection Routine***********************

            'Fill array from user selection on click
            aryItemList(aryCount) = (cboxAppliances.Text)

            'Add item currently in Appliances to list 
            txtItemList.Items.Add(aryItemList(aryCount))

            '****Hours Used Routine***************************

            'Fill array from user selection on click
            aryHoursList(aryCount) = (txtHoursUsed.Text)

            'Add value in Hours Used to list
            txtHoursUsedList.Items.Add(aryHoursList(aryCount))

            '****Total Cost Routine**************************

            'Fill array from user selection on click
            aryCostList(aryCount) = (txtTotalCost.Text)

            'Add value in Total Cost
            txtCostList.Items.Add(aryCostList(aryCount))

            '****Array Counter Routine**********************

            'Add one to array counter modifies input slot and counts iterations
            aryCount += 1

            '*************************************Totals Collection*****************************************

            'Add subsequent totals together
            decCombinedExpense = decCombinedExpense + decTotalCost

            'Convert to string for display
            txtCombinedExpense.Text = decCombinedExpense.ToString("c")

        ElseIf aryCount = 15 Then

            'Disable adding more values 
            btnAddToList.Enabled = False
            btnWrite2File.Enabled = False
            MessageBox.Show("Max listings reached. You must clear the table.")

        End If

        '***********************************************************************************************

    End Sub

    Private Sub txtItemList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemList.SelectedIndexChanged

    End Sub

    Private Sub btnClearTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearTable.Click

        'Clear all items in the table
        txtItemList.Items.Clear()
        txtHoursUsedList.Items.Clear()
        txtCostList.Items.Clear()
        txtCombinedExpense.Clear()
        decCombinedExpense = 0
        aryCount = 0

        If btnAddToList.Enabled = False Then

            btnAddToList.Enabled = True
            btnWrite2File.Enabled = True

        End If

    End Sub
    '**********************************************Write Items to Text File***************************************

    Private Sub btnWrite2File_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite2File.Click

        'Set file name
        Dim collection As String

        'Assign variable for collection of data to external file
        Dim dataCollection As StreamWriter

        'Assign write loop variable
        Dim intWriteCount As Integer

        'Assign array location value variable
        Dim aryLocation As Integer

        'Set spacer variable for formatting
        Dim spacer As String

        'Write data to external file
        Try

            collection = InputBox("Enter file name")

            'Assign variable to data collection file
            dataCollection = File.CreateText(collection)

            'Write header values
            dataCollection.WriteLine("   " + "Appliance Name" + "   " + "Hours Used" + "     " + "Total Cost")

            'Write spacer line
            dataCollection.WriteLine()

            'Loop counter to write each variable value to file
            For intWriteCount = 0 To aryCount

                'Formatting for string length of appliance
                If Len(aryItemList(aryLocation)) = 15 Then

                    'Formatting for string length of hours used
                    If Len(aryHoursList(aryLocation)) = 1 Then

                        spacer = "           "

                    Else

                        spacer = "          "

                    End If

                    'Write data to file if string length count is 15

                    'Write data values
                    dataCollection.WriteLine("   " + (aryItemList(aryLocation)) + "       " + (aryHoursList(aryLocation)) + (spacer) + (aryCostList(aryLocation)))
                    aryLocation += 1

                    'Formatting for string length of appliance
                ElseIf Len(aryItemList(aryLocation)) = 12 Then

                    'Formatting for string length of hours used
                    If Len(aryHoursList(aryLocation)) = 1 Then

                        spacer = "           "

                    Else

                        spacer = "          "

                    End If

                    'Write data to file if string length count is 12
                    dataCollection.WriteLine("    " + (aryItemList(aryLocation)) + "          " + (aryHoursList(aryLocation)) + (spacer) + (aryCostList(aryLocation)))
                    aryLocation += 1

                    'Formatting for string length of appliance
                ElseIf Len(aryItemList(aryLocation)) = 6 Then

                    'Formatting for string length of hours used
                    If Len(aryHoursList(aryLocation)) = 1 Then

                        spacer = "           "

                    Else

                        spacer = "          "

                    End If

                    'Write data to file if string length count is 6
                    dataCollection.WriteLine("    " + (aryItemList(aryLocation)) + "                " + (aryHoursList(aryLocation)) + (spacer) + (aryCostList(aryLocation)))
                    aryLocation += 1

                End If

            Next

            'Announce that data has been written to file
            MessageBox.Show("File saved to \bin\Debug\")

            If btnAddToList.Enabled = False Then

                btnAddToList.Enabled = True

            End If

            'Close file
            dataCollection.Close()

        Catch ex As Exception

            MessageBox.Show("Could not write to file")

        End Try

    End Sub

    Private Sub btnPreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreset.Click

        'Assign variables
        Dim strFile As String
        Dim getWatts As StreamReader

        'Get file name input
        strFile = InputBox("Enter file 'watts' with full path from \bin\Debug\watts")

        Try

            'Open the file
            getWatts = File.OpenText(strFile)

            'Assign values from file in order to each array location
            arySetRating(0) = getWatts.ReadLine()
            arySetRating(1) = getWatts.ReadLine()
            arySetRating(2) = getWatts.ReadLine()
            arySetRating(3) = getWatts.ReadLine()

            'Close file
            getWatts.Close()

        Catch ex As Exception

            MessageBox.Show("Could not open file")

        End Try

    End Sub

End Class
