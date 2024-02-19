Imports System.ComponentModel.Design
Imports System.Net.Security
Imports System.Security.Cryptography

Public Class frmRentals

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstDisplay.Items.Clear()

        Dim cost, x, extraDays, days As Double
        Dim primative, yurt, cabin As Double
        primative = 20
        yurt = 30
        cabin = 40

        If radCabin.Checked = False And radPrimitive.Checked = False And radYurt.Checked = False Then
            MessageBox.Show("Please select a structure.")
        End If

        If IsNothing(txtNumberOfDays.Text) = True Then
            MessageBox.Show("Please input a number.")
            Return
        End If

        If IsNumeric(txtNumberOfDays.Text) = False Then
            MessageBox.Show("Only Enter Numbers in the text box.")
            Return
        End If


        If radPrimitive.Checked = True Then


            If CDbl(txtNumberOfDays.Text) > 6 Then
                extraDays = CDbl(txtNumberOfDays.Text) - 6
                days = 6
                x = primative - 5
                cost = (primative * days) + (x * extraDays)

            ElseIf CDbl(txtNumberOfDays.Text) <= 6 Then
                days = CDbl(txtNumberOfDays.Text)
                cost = days * primative
            End If


        ElseIf radYurt.Checked = True Then

            If CDbl(txtNumberOfDays.Text) > 6 Then
                extraDays = CDbl(txtNumberOfDays.Text) - 6
                days = 6
                x = yurt - 5
                cost = (yurt * days) + (x * extraDays)

            ElseIf CDbl(txtNumberOfDays.Text) <= 6 Then
                days = CDbl(txtNumberOfDays.Text)
                cost = days * yurt
            End If

        ElseIf radCabin.Checked = True Then

            If CDbl(txtNumberOfDays.Text) > 6 Then
                    extraDays = CDbl(txtNumberOfDays.Text) - 6
                    days = 6
                    x = cabin - 5
                    cost = (cabin * days) + (x * extraDays)

                ElseIf CDbl(txtNumberOfDays.Text) <= 6 Then
                    days = CDbl(txtNumberOfDays.Text)
                    cost = days * cabin
                End If
            End If


        lstDisplay.Items.Add(cost.ToString("c2"))



    End Sub
End Class
