Public Class Ejercicio2
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If Not Integer.TryParse(txtNumero.Text, Nothing) OrElse Convert.ToInt32(txtNumero.Text) < 2 Then
            MessageBox.Show("Ingrese un número válido mayor o igual a 2." & vbCrLf & vbCrLf & "Porque el número 2 es el primer número primo.")
            Return
        End If

        Dim numero As Integer = Convert.ToInt32(txtNumero.Text)

        Dim esPrimo As Boolean = True
        For i As Integer = 2 To numero - 1
            If numero Mod i = 0 Then
                esPrimo = False
            End If
        Next

        If esPrimo Then
            MessageBox.Show(numero & " es un número primo.")
        Else
            MessageBox.Show(numero & " no es un número primo.")
        End If
    End Sub
End Class