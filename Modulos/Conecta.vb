Module Conecta
    Public conexao As ADODB.Connection
    Public Function abreBanco()
        Dim caminho As String
        caminho = "C:\ControleAgricola\AgricolaT.accdb"
        conexao.Open("Provider=Microsoft.Jet.OLEDB.15.0;Data Source= " & caminho)
    End Function
    Public Function fechaBanco()
        conexao.Close()
    End Function
End Module
