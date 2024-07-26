Public Class Form1
    'Declaramos Varibles
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim usuario, contraseña As String

        usuario = tbx_user.Text
        contraseña = tbx_password.Text

        'Este if es para comprobar los datos administrados
        If (usuario = "Daniela") And (contraseña = "10203040") Then 'Clave y Usuario
            'Con esto podemos abrir nuestro segundo formaliroo y cerrar el anterior siempre y cuando cumplamos el if
            Form2.Show()
            Me.Close()
        Else
            'mensaje de error si los datos son incorrectos
            MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub
End Class
