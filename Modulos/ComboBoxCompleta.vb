Module ComboBoxCompleta
    Public Function completaComboBox(tabela As String, nomeBox As ComboBox, indice As Integer)
        Call abreBanco()
        Dim consulta As ADODB.Recordset
        consulta = CreateObject("ADODB.Recordset")
        consulta.Open("SELECT * FROM historico", conexao)
        consulta.MoveFirst()

        Do While Not consulta.EOF
            nomeBox.Items.Add(consulta(indice).Value)
            consulta.MoveNext()
        Loop
        fechaBanco()
    End Function
End Module
