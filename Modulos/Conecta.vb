Module Conecta
    Public conexao As ADODB.Connection
    Public Function abreBanco()
        Dim caminho As String
        conexao = CreateObject("ADODB.Connection")
        caminho = "C:\ControleAgricola\AgricolaT.accdb"
        conexao.Open("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & caminho)

    End Function
    Public Function fechaBanco()
        conexao.Close()
    End Function
End Module
