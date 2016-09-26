Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login = New Login
        login.ShowDialog()
    End Sub
End Class