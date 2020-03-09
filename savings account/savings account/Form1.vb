Option Explicit On
Option Strict On

Public Class frmSavings

    Dim Deposit As Double
    Dim Interest As Double
    Dim Months As Double
    Dim Final As Double

    Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim IntRate As Double
        'read values from text boxes
        Deposit = Val(txtDeposit.Text)
        Interest = Val(txtInterest.Text)
        IntRate = Interest / 1200
        Months = Val(txtMonths.Text)
        'compute final value and put in text box
        If Interest = 0 Then
            'zero interest case
            Final = Deposit * Months
        Else
            Final = Deposit * ((1 + IntRate) ^ Months - 1) / IntRate
        End If

        txtFinal.Text = Format(Final, "0.00")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtDeposit_TextChanged(sender As Object, e As EventArgs) Handles txtDeposit.TextChanged

    End Sub

    Private Sub txtInterest_TextChanged(sender As Object, e As EventArgs) Handles txtInterest.TextChanged

    End Sub

    Private Sub txtMonths_TextChanged(sender As Object, e As EventArgs) Handles txtMonths.TextChanged

    End Sub
End Class
