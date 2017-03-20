Public Class Login
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub Login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAceptar_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            BtnCancelar_Click(Nothing, Nothing)
        End If
    End Sub
End Class