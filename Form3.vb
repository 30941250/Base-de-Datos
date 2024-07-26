Public Class Form3

    'Boton de Volver
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Form2.Show()
        Me.Close()
    End Sub
End Class