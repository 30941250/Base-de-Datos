Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet1.Biblioteca' Puede moverla o quitarla según sea necesario.
        Me.BibliotecaTableAdapter1.Fill(Me.Database1DataSet1.Biblioteca)


    End Sub

    'Boton de Guardado
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        BibliotecaBindingSource1.EndEdit()
        MsgBox("Guardado con exito", MsgBoxStyle.Information, "Guardar")
        BibliotecaTableAdapter1.Update(Database1DataSet1.Biblioteca)
    End Sub

    'Boton de Borrado
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        BibliotecaTableAdapter1.Eliminar(tbx_id.Text)
        Me.BibliotecaTableAdapter1.Fill(Me.Database1DataSet1.Biblioteca)
    End Sub

    'Boton de Agregar
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Me.BibliotecaTableAdapter1.Agregar(tbx_book.Text, tbx_author.Text, tbx_editorial.Text, tbx_date.Text, tbx_literary_gender.Text)
        Me.BibliotecaTableAdapter1.Fill(Me.Database1DataSet1.Biblioteca)
    End Sub

    'Boton de Editar
    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        BibliotecaTableAdapter1.Modificar(tbx_book.Text, tbx_author.Text, tbx_editorial.Text, tbx_literary_gender.Text, tbx_date.Text, tbx_id.Text)
        Me.BibliotecaTableAdapter1.Fill(Me.Database1DataSet1.Biblioteca)
    End Sub

    'Boton de Volver
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Form1.Show()
        Me.Close()
    End Sub

    'Boton de Creditos
    Private Sub btn_credits_Click(sender As Object, e As EventArgs) Handles btn_credits.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class