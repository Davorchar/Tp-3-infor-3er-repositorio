

Public Class Form1
    Dim dato1 As Integer
    Dim unidad As Integer
    Dim decena As Integer
    Dim centena As Integer
    Dim resto As Integer
    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        If Integer.TryParse(txtNum.Text, dato1) Then
        End If
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click


        centena = dato1 \ 100
        resto = dato1 Mod 100
        decena = resto \ 10
        unidad = resto Mod 10

        lblCent.Text = "la centena es" & centena
        lblDec.Text = "la decena es " & decena
        lblUnid.Text = "la uniad es" & unidad

    End Sub
End Class
