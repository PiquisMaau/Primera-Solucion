Imports Ejercicio14_Biblioteca_Clases

Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button_Calcular_Click(sender As Object, e As EventArgs) Handles Button_Calcular.Click
        Dim angulo, valoSeno, valorCoseno As Double
        Dim tg As New Trigonometria

        angulo = Convert.ToDouble(TextBox_ValorAngulo.Text)
        valorCoseno = tg.calcularCoseno(angulo)
        valoSeno = tg.CalcularSeno(angulo)

        TextBox_Seno.Text = valoSeno.ToString()
        TextBox_Coseno.Text = valorCoseno.ToString()



    End Sub

End Class
