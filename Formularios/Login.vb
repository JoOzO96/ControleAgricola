Public Class Login
    Private Sub btSair_Click(sender As Object, e As EventArgs) Handles btSair.Click
        End
    End Sub

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Call abreBanco()
        Dim usuario As ADODB.Recordset
        usuario = CreateObject("ADODB.Recordset")

        If (txSenha.Text = "" Or txUsuario.Text = "") Then
            MsgBox("Por favor, preencha todos os campos do login com seu usuario e senha")
        Else
            usuario.Open("SELECT * FROM Usuario WHERE usuario = " & txUsuario.Text & " and senha = " & txSenha.Text, conexao)
            usuario.MoveFirst()
            If (usuario.RecordCount = 0) Then
                MsgBox("Usuario nao encontrado")
                Call fechaBanco()
            Else
                Me.Dispose()
                Call fechaBanco()
            End If
        End If
    End Sub
End Class
