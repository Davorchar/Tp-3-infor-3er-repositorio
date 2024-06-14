Public Class Form1
    Private Sub ButtonOrdenar_Click(sender As Object, e As EventArgs) Handles ButtonOrdenar.Click

        Dim num1 As Integer = Integer.Parse(TextBox1.Text)
        Dim num2 As Integer = Integer.Parse(TextBox2.Text)
        Dim num3 As Integer = Integer.Parse(TextBox3.Text)

        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer


        If num1 > num2 AndAlso num1 > num3 Then
            mayor = num1
            If num2 > num3 Then
                medio = num2
                menor = num3
            Else
                medio = num3
                menor = num2
            End If
        ElseIf num2 > num1 AndAlso num2 > num3 Then
            mayor = num2
            If num1 > num3 Then
                medio = num1
                menor = num3
            Else
                medio = num3
                menor = num1
            End If
        Else
            mayor = num3
            If num1 > num2 Then
                medio = num1
                menor = num2
            Else
                medio = num2
                menor = num1
            End If
        End If


        lblResultado.Text = $"Números en orden decreciente: {mayor}, {medio}, {menor}"
    End Sub

End Class


