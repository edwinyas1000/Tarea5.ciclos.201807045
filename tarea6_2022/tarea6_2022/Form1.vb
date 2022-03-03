Public Class Form1
    Function restarlabel(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero - 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function
    Function sumalabel(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevotexto As String
        numero = numero + 1
        nuevotexto = numero.ToString()
        Return nuevotexto
    End Function

    Private Sub BAmenos_Click(sender As Object, e As EventArgs) Handles BAmenos.Click
        Dim numeroentrante As String = LA.Text
        numeroentrante = restarlabel(numeroentrante)
        LA.Text = numeroentrante
    End Sub

    Private Sub BAmas_Click(sender As Object, e As EventArgs) Handles BAmas.Click
        Dim numeroentrante As String = LA.Text
        numeroentrante = sumalabel(numeroentrante)
        LA.Text = numeroentrante
    End Sub

    Private Sub BBmenos_Click(sender As Object, e As EventArgs) Handles BBmenos.Click
        Dim numeroentrante As String = LB.Text
        numeroentrante = restarlabel(numeroentrante)
        LB.Text = numeroentrante
    End Sub

    Private Sub BBmas_Click(sender As Object, e As EventArgs) Handles BBmas.Click
        Dim numeroentrante As String = LB.Text
        numeroentrante = sumalabel(numeroentrante)
        LB.Text = numeroentrante
    End Sub
    Function Sumar(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA + numB
        Return resultado

    End Function
    Function Restar(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA - numB
        Return resultado

    End Function
    Function Multiplicar(numA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numA * numB
        Return resultado

    End Function
    Function Dividir(numA As Integer, numB As Integer) As Double
        Dim resultado As Double
        resultado = numA / numB
        Return resultado

    End Function

    Private Sub Bsuma_Click(sender As Object, e As EventArgs) Handles Bsuma.Click
        Dim txtA = LA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = LB.Text
        Dim numB = Int32.Parse(txtB)
        Dim resultadosuma = Sumar(numA, numB)
        Lresultado.Text = ("El resultado de la suma es: " + resultadosuma.ToString)
    End Sub

    Private Sub Bresta_Click(sender As Object, e As EventArgs) Handles Bresta.Click
        Dim txtA = LA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = LB.Text
        Dim numB = Int32.Parse(txtB)
        Dim resultadoresta = Restar(numA, numB)
        Lresultado.Text = ("El resultado de la resta  es: " + resultadoresta.ToString)
    End Sub

    Private Sub Bmultiplicar_Click(sender As Object, e As EventArgs) Handles Bmultiplicar.Click
        Dim txtA = LA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = LB.Text
        Dim numB = Int32.Parse(txtB)
        Dim resultadomul = Multiplicar(numA, numB)
        Lresultado.Text = ("El resultado de la multiplicación  es: " + resultadomul.ToString)
    End Sub

    Private Sub Bdividir_Click(sender As Object, e As EventArgs) Handles Bdividir.Click
        Dim txtA = LA.Text
        Dim numA = Int32.Parse(txtA)
        Dim txtB = LB.Text
        Dim numB = Int32.Parse(txtB)
        If numB <> 0 Then
            Dim resultadodivsion = Dividir(numA, numB)
            Lresultado.Text = ("El resultado de la división   es: " + resultadodivsion.ToString)
        Else
            MsgBox("ingrese en un numero diferente a cero en el texto B")
        End If
    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        Lresultado.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
