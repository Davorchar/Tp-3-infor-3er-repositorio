Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim numero1 As Integer
        Dim numero2 As Integer

        If Integer.TryParse(txtIngresar.Text, numero1) AndAlso Integer.TryParse(txtIngresar2.Text, numero2) Then


            If numero1 <> numero2 Then

                If numero1 > numero2 Then
                    lblMostrar1.Text = "El número mayor es: " & numero1
                Else
                    lblMostrar1.Text = "El número mayor es: " & numero2
                End If

            End If
        End If
    End Sub

End Class
