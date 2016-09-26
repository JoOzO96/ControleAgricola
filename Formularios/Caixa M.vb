Public Class Caixa_M
    Private Sub Caixa_M_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call completaComboBox("historico", cbNumeroCaixa, 0)
        Call completaComboBox("historico", cbDescricaoCaixa, 1)
    End Sub
End Class