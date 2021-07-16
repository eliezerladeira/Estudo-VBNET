Public Class Form1
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Dim valor1 As Integer = 0
        Dim valor2 As Integer = 0

        valor1 = CInt(txtValor1.Text)
        valor2 = CInt(txtValor2.Text)

        Soma(valor1, valor2)
        'txtResultado.Text = CInt(txtValor1.Text) + CInt(txtValor2.Text)
    End Sub

    Private Sub Soma(ByVal v1 As Integer, ByVal v2 As Integer)
        Dim resultado As Integer

        resultado = v1 + v2

        txtResultado.Text = resultado
    End Sub
End Class
