Imports System.Text

Public Class Ejercicio5
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim multiplicando As Integer
        If Integer.TryParse(txtMultiplicando.Text, multiplicando) AndAlso multiplicando > 0 Then
            Dim tabla As New StringBuilder()
            For i As Integer = 1 To 10
                tabla.AppendFormat("{0} x {1} = {2}" & vbCrLf, multiplicando, i, multiplicando * i)
            Next
            lblTabla.Text = tabla.ToString()
        Else
            MessageBox.Show("Ingrese un número válido mayor que 0.")
        End If
    End Sub
End Class