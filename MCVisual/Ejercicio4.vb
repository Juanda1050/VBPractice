Public Class Ejercicio4
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim i As Integer = 10
        Dim secuencia As String = ""

        While i >= 1
            If i = 1 Then
                secuencia = secuencia & i
            Else
                secuencia = secuencia & i & ", "
            End If
            i = i - 1
        End While

        lblSecuencia.Text = secuencia
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        If String.IsNullOrEmpty(lblSecuencia.Text) Then
            MessageBox.Show("Primero debe generar una secuencia para eliminarla.")
        Else
            lblSecuencia.Text = ""
        End If
    End Sub
End Class