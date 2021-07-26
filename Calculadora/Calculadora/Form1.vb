Public Class Form1
    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        Try

            Dim valor1 As Integer = 0
            Dim valor2 As Integer = 0

            valor1 = CInt(txtValor1.Text)
            valor2 = CInt(txtValor2.Text)

            txtResultado.Text = Soma(valor1, valor2)
            'txtResultado.Text = CInt(txtValor1.Text) + CInt(txtValor2.Text)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const COPYRIGHT As String = "Calculadora Natural (powered Eliezer)"
        lblAviso.Text = COPYRIGHT
    End Sub

    Private Sub txtValor1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValor1.KeyPress, txtSub1.KeyPress, txtMult1.KeyPress, txtDiv1.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnSubtrair_Click(sender As Object, e As EventArgs) Handles btnSubtrair.Click
        Try

            Dim valor1 As Integer = 0
            Dim valor2 As Integer = 0

            valor1 = CInt(txtSub1.Text)
            valor2 = CInt(txtSub2.Text)

            txtSubResultado.Text = Subtracao(valor1, valor2)
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub
End Class