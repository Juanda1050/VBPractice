Public Class Ejercicio1
    Private Sub btnCalif_Click(sender As Object, e As EventArgs) Handles btnCalif.Click
        Dim nota As Integer

        If Integer.TryParse(txtCalif.Text, nota) Then
            If nota >= 80 Then
                txtMensaje.Text = "Aprobado"
            Else
                txtMensaje.Text = "Reprobado"
            End If
        Else
            MessageBox.Show("Ingrese un número para calificar al alumno")
        End If
    End Sub
End Class
