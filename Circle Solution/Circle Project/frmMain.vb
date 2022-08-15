' Name:         Circle Project
' Purpose:      Display the circumference of a circle
' Programmer:   Thomas Dickelman on 2/21/22

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates and displays the circumference of a circle

        'declare named constant
        Const dblPI As Double = 3.14

        'declare variables
        Dim dblDiameter As Double
        Dim dblCicumference As Double

        ' store diameter in a variable
        Double.TryParse(txtDiameter.Text, dblDiameter)

        ' calculate circumference
        dblCicumference = dblPI * dblDiameter

        ' display circumference
        lblCircumference.Text = dblCicumference.ToString("N2")

    End Sub
End Class
