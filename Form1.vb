'Jenna Lambert
'9/11/18
'Addition App
Public Class Form1 'starting class
    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click 'starting sub. Button Click event: when the user clicks the equals button
        Dim num1 As Double 'defining variable "num1" as a double variable
        Dim num2 As Double 'defining variable "num2" as a double variable
        Dim sum As Double 'defineing variable "sum" as a double variable
        num1 = txtNum1.Text 'setting variable num1 equal to the text property of txtNum1
        num2 = txtNum2.Text 'settin variable num2 equal to the text property of txtnum2
        sum = num1 + num2 'adding variable num1 and variable num2 together and settin it equal to variable sum
        txtSum.Text = sum 'setting the text property of txtSum equal to variable sum
    End Sub 'ending sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged 'starting sub. Text changed event: when the text is changed in txtnum1
        txtSum.Text = "" 'the text property of txtsum is emptied
    End Sub 'ending sub
    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged 'Starting sub. Text changed event: when the text is changed in txtnum2
        txtSum.Text = "" 'the text propterty of txtsum si emptied
    End Sub 'ending sub
End Class 'ending class
