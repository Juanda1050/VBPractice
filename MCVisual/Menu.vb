Public Class Menu
    Private Sub btnEjercicio1_Click(sender As Object, e As EventArgs) Handles btnEjercicio1.Click
        Dim f1 As New Ejercicio1
        f1.ShowDialog()
    End Sub

    Private Sub btnEjercicio2_Click(sender As Object, e As EventArgs) Handles btnEjercicio2.Click
        Dim f2 As New Ejercicio2
        f2.ShowDialog()
    End Sub

    Private Sub btnEjercicio3_Click(sender As Object, e As EventArgs) Handles btnEjercicio3.Click
        Dim f3 As New Ejercicio3
        f3.ShowDialog()
    End Sub

    Private Sub btnEjercicio4_Click(sender As Object, e As EventArgs) Handles btnEjercicio4.Click
        Dim f4 As New Ejercicio4
        f4.ShowDialog()
    End Sub

    Private Sub btnEjercicio5_Click(sender As Object, e As EventArgs) Handles btnEjercicio5.Click
        Dim f5 As New Ejercicio5
        f5.ShowDialog()
    End Sub
End Class