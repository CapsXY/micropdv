Imports System.Data.SqlClient
Public Class Login
    Private Sub ButtonConectar_Click(sender As Object, e As EventArgs) Handles ButtonConectar.Click
        Dim usuario As String = TextBoxUsuario.Text
        Dim senha As String = MaskedTextBoxSenha.Text
        If usuario = "" Or senha = "" Then
            MsgBox("Preencha os Campos!")
        Else
            Dim command As New SqlCommand("login", conectaDB)
            Try
                Abrir()
                command.CommandType = 4
                With command.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    command.ExecuteNonQuery()
                End With
                usuarioNome = TextBoxUsuario.Text
                Dim msg As String = command.Parameters("@msg").Value
                MsgBox(msg, vbInformation)
                If (msg = "Dados Incorretos") Then
                    MaskedTextBoxSenha.Clear()
                    TextBoxUsuario.Clear()
                    TextBoxUsuario.Focus()
                Else
                    Dim form = New Principal
                    Me.Hide()
                    form.ShowDialog()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro ao Listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
End Class