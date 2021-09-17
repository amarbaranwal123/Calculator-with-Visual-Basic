Public Class Form1
    Private resultValue As Double = 0.0
    Private userInput As String = ""
    Private functions As Char
    Private First = ""
    Private Second = ""
    Private firstnum As Double
    Private secondnum As Double




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonOne_Click(sender As Object, e As EventArgs) Handles ButtonOne.Click
        calculatorDisplay.Text = ""
        userInput += "1"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonTwo_Click(sender As Object, e As EventArgs) Handles ButtonTwo.Click

        calculatorDisplay.Text = ""
        userInput += "2"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonThree_Click(sender As Object, e As EventArgs) Handles ButtonThree.Click
        calculatorDisplay.Text = ""
        userInput += "3"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonFour_Click(sender As Object, e As EventArgs) Handles ButtonFour.Click
        calculatorDisplay.Text = ""
        userInput += "4"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonSix_Click(sender As Object, e As EventArgs) Handles ButtonSix.Click
        calculatorDisplay.Text = ""
        userInput += "6"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonFive_Click(sender As Object, e As EventArgs) Handles ButtonFive.Click
        calculatorDisplay.Text = ""
        userInput += "5"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonSeven_Click(sender As Object, e As EventArgs) Handles ButtonSeven.Click
        calculatorDisplay.Text = ""
        userInput += "7"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonEight_Click(sender As Object, e As EventArgs) Handles ButtonEight.Click
        calculatorDisplay.Text = ""
        userInput += "8"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonNine_Click(sender As Object, e As EventArgs) Handles ButtonNine.Click
        calculatorDisplay.Text = ""
        userInput += "9"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        functions = "\0"
        First = ""
        Second = ""
        userInput = ""
        resultValue = 0.0
        calculatorDisplay.Text = "0"
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        userInput = ""
        calculatorDisplay.Text = "0"
    End Sub

    Private Sub ButtonZero_Click(sender As Object, e As EventArgs) Handles ButtonZero.Click

        calculatorDisplay.Text = ""
        userInput += "0"
        calculatorDisplay.Text += userInput
    End Sub

    Private Sub ButtonDot_Click(sender As Object, e As EventArgs) Handles ButtonDot.Click
        userInput += "."
        calculatorDisplay.Text = userInput
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        functions = "+"
        First = userInput
        userInput = ""
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        functions = "-"
        First = userInput
        userInput = ""
    End Sub

    Private Sub ButtonDevide_Click(sender As Object, e As EventArgs) Handles ButtonDevide.Click
        functions = "/"
        First = userInput
        userInput = ""
    End Sub

    Private Sub ButtonMultiply_Click(sender As Object, e As EventArgs) Handles ButtonMultiply.Click
        functions = "*"
        First = userInput
        userInput = ""
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        Second = userInput
        firstnum = Convert.ToDouble(First)
        secondnum = Convert.ToDouble(Second)

        If functions = "+" Then
            resultValue = firstnum + secondnum
            calculatorDisplay.Text = resultValue.ToString()

        ElseIf functions = "-" Then
            resultValue = firstnum - secondnum
            calculatorDisplay.Text = resultValue.ToString()

        ElseIf functions = "*" Then
            resultValue = firstnum * secondnum
            calculatorDisplay.Text = resultValue.ToString()

        ElseIf functions = "/" Then

            If secondnum = 0 Then
                calculatorDisplay.Text = "No ZERO"

            Else
                resultValue = firstnum / secondnum
                calculatorDisplay.Text = resultValue.ToString()

            End If

        End If

    End Sub
End Class


