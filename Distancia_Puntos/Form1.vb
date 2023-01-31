Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim D As Datos = New Datos()
        txtDistancia.Text = D.Calculo(txtX2.Text, txtX1.Text, txtY2.Text, txtY1.text)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtX1.Clear()
        txtX2.Clear()
        txtY1.Clear()
        txtY2.Clear()
        txtDistancia.Clear()
    End Sub
End Class