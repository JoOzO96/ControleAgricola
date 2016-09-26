Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim login = New Login
        login.ShowDialog()
    End Sub

    Private Sub CaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        Dim caixa = New Caixa_M
        caixa.ShowDialog()
    End Sub
End Class