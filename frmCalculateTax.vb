Public Class frmIncomeTaxCalculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim totalIncome As Integer = CInt(txtTaxableIncome.Text)
        Dim incomeTax As Decimal = 0D

        'If totalIncome >= 0 AndAlso totalIncome < 8700 Then
        'incomeTax = totalIncome * 0.1D
        'ElseIf totalIncome >= 8700 AndAlso totalIncome < 35350 Then
        'incomeTax = 870 + (totalIncome - 8700) * 0.15D
        'ElseIf totalIncome >= 35350 AndAlso totalIncome < 85650 Then
        'incomeTax = 4867 + (totalIncome - 35350) * 0.25D
        'ElseIf totalIncome >= 85650 AndAlso totalIncome < 178650 Then
        'incomeTax = 17442 + (totalIncome - 85650) * 0.28D
        'ElseIf totalIncome >= 178650 AndAlso totalIncome < 388350 Then
        'incomeTax = 43482 + (totalIncome - 178650) * 0.33D
        ' Else
        'incomeTax = 112683 + (totalIncome - 388350) * 0.35D
        'End If

        Select Case totalIncome
            Case 0 To 8700
                incomeTax = totalIncome * 0.1D
            Case 8700 To 35350
                incomeTax = 870 + (totalIncome - 8700) * 0.15D
            Case 35350 To 85650
                incomeTax = 4867 + (totalIncome - 35350) * 0.25D
            Case 85650 To 178650
                incomeTax = 17442 + (totalIncome - 85650) * 0.28D
            Case 178650 To 388350
                incomeTax = 43482 + (totalIncome - 178650) * 0.33D
            Case Else
                incomeTax = 112683 + (totalIncome - 388350) * 0.35D
        End Select
        txtIncomeTaxOwed.Text = FormatCurrency(incomeTax)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
