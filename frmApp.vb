Option Strict On
Public Class frmApp
    'Program:	
    'Developer:	
    'Date:		
    'Purpose:	
	
'1. The user is presented a form with the ability to enter hours worked and their hourly wage. 
'2. The user enters hours worked and their hourly wage.
'3. The user selects to calculate their total income.
'4. The user can select to clear the form at any time.
'5. The user can exit the application at any time.
'
'btnCalculate
'take the hourly input from the user and convert it to a Double
'take the hourly wage and convert it to a Decimal
'perform the calculation and display it in the results label as currency
'
'btnClear
'clear the textbox field values
'clear the total income lable text value
'
'btnExit
'exit the application

    Private Sub BtnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'take the hourly input from the user And convert it to a Double
        Dim strHoursWorked As String
        Dim intHoursWorked As Integer
        strHoursWorked = txtHours.Text
        intHoursWorked = Convert.ToInt32(strHoursWorked)

        'take the hourly wage And convert it to a Decimal
        Dim strHourlyWage As String
        Dim decHourlyWage As Decimal
        strHourlyWage = txtWage.Text
        decHourlyWage = Convert.ToDecimal(strHourlyWage)

        'perform the calculation And display it in the results label
        Dim decIncome As Decimal = intHoursWorked * decHourlyWage
        lblIncome.Visible = True
        lblIncome.Text = decIncome.ToString("C")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the textbox field values
        txtHours.Clear()
        txtWage.Clear()

        'clear the total income lable text value
        lblIncome.Text = ""
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
