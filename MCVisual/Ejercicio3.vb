Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Ejercicio3
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim numDia As Integer = Val(txtDia.Text)
        If Not Integer.TryParse(txtDia.Text, numDia) Then
            lblDia.Text = "Número de día inválido"
            Return
        End If

        Dim diasSemana() As String = {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"}
        If numDia < 1 OrElse numDia > diasSemana.Length Then
            lblDia.Text = "Número de día inválido"
            Return
        End If

        lblDia.Text = "El día ingresado es " & diasSemana(numDia - 1)
    End Sub
End Class