Imports System.Data.SqlClient

Module ConexaoDB
    Public conectaDB As New SqlConnection("Server=.\PDVNET; DataBase=SistemaVB; User Id=sa; Password=inter#system")
    Sub Abrir()
        If conectaDB.State = 0 Then
            conectaDB.Open()
        End If
    End Sub
    Sub Fechar()
        If conectaDB.State = 1 Then
            conectaDB.Close()
        End If
    End Sub
    Public usuarioNome As String
End Module
