Public Class frmAirBnb
    ' Cost per night - constant
    Const _cdecCostPerNight As Decimal = 79D
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        Dim strEnterNumberOfNights As String
        Dim intEnterNumberOfNights As Integer
        Dim decTotalCostOfStay As Decimal

        strEnterNumberOfNights = txtNights.Text
        intEnterNumberOfNights = Convert.ToInt32(strEnterNumberOfNights)
        decTotalCostOfStay = intEnterNumberOfNights * _cdecCostPerNight
        lblTotalCost.Text = decTotalCostOfStay.ToString("C")
        lblTotalCost.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNights.Clear()
        lblTotalCost.Visible = False
        txtNights.Focus()
    End Sub

    Private Sub frmAirBnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotalCost.Visible = False
        lblDescription.Text = "Only " & _cdecCostPerNight.ToString("C") & " per night"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
