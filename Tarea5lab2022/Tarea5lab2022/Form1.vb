Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim j As Double
            Dim i As Integer
            Dim indice As Double = 0
            Dim multiplos As Double = 0

            Dim numero As String = TextBox1.Text

            j = 1
            If numero >= 0 Then
                For i = 1 To numero Step 1
                    j = j * i
                Next
                Label1.Text = j
            Else
                MsgBox("Ingrese un numero positivo")
            End If
            While (indice <= j)
                If (indice Mod 4 = 0) Then
                    multiplos = multiplos + 1
                End If
                indice = indice + 1
            End While

            Label7.Text = "La cantidad de multiplos de 4 para este ciclo es;" + multiplos.ToString



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        Label7.Text = ""
        Label1.Text = ""

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
