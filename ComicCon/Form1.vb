Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radSuperhero.Checked = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 3800
        Dim decAutographs As Decimal = 2750
        Dim decConvention As Decimal = 2090

        If IsNumeric(TextBox1.Text) Then
            intGroup = Convert.ToInt32(TextBox1.Text)

            If intGroup > 0 And intGroup < 20 Then
                If radSuperhero.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If
                decTotalCost = (intGroup * decRegistration)
                lblCostTickets.Text = decTotalCost.ToString("C")

            Else

                MsgBox("Enter a positive number between 1 and 20",     , "Invalid number error")

            End If
        Else

            MsgBox("Enter a number between 1 and 20",     , "Invalid number error")

        End If



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = ""
        lblCostTickets.Text = ""
        'radSuperhero.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
        TextBox1.Focus()
    End Sub
End Class
