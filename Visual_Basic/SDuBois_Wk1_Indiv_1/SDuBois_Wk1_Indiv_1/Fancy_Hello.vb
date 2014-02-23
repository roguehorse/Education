Public Class Fancy_Hello

    ' Set global variable
    Dim time As Integer = 0

    Private Sub Fancy_Hello_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Initialize timer
        Timer1.Start()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ' Set timer count to change text color after set number of iterations
        time = time + 1
        If time = 1 Then
            Label1.ForeColor = Color.Green
        ElseIf time = 10 Then
            Label1.ForeColor = Color.Red
        ElseIf time = 20 Then
            Label1.ForeColor = Color.Green

            ' Set timer to zero to repeat loop
            time = 0

        End If

    End Sub
End Class