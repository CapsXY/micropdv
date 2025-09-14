Imports System.Data.SqlClient
Public Class Funcionarios
    Private Sub Funcionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        DateTimePickerDataContratacao.Value = Now
        ButtonSalvar.Enabled = False
        MaskedTextBoxCPFBusca.Visible = False
        Listar()
        ButtonEditar.Enabled = False
        ButtonDeletar.Enabled = False
        RadioButtonNome.Checked = True
    End Sub
    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            Abrir()
            da = New SqlDataAdapter("SELECT * FROM funcionarios", conectaDB)
            da.Fill(dt)
            DataGridView.DataSource = dt
            ContarLinhas()
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub FormatarDataGridView()
        DataGridView.Columns(0).Visible = False
        DataGridView.Columns(3).Visible = False
        DataGridView.Columns(1).HeaderText = "Nome"
        DataGridView.Columns(2).HeaderText = "Sexo"
        DataGridView.Columns(3).HeaderText = "CPF"
        DataGridView.Columns(4).HeaderText = "Endereço"
        DataGridView.Columns(5).HeaderText = "Telefone"
        DataGridView.Columns(6).HeaderText = "Email"
        DataGridView.Columns(7).HeaderText = "Turno"
        DataGridView.Columns(8).HeaderText = "Data Contratação"
    End Sub
    Private Sub DesabilitarCampos()
        TextBoxNome.Enabled = False
        MaskedTextBoxCPF.Enabled = False
        TextBoxEndereco.Enabled = False
        MaskedTextBoxTelefone.Enabled = False
        TextBoxEmail.Enabled = False
        ComboBoxSexo.Enabled = False
        ComboBoxTurno.Enabled = False
        DateTimePickerDataContratacao.Enabled = False
    End Sub
    Private Sub HabilitarCampos()
        TextBoxNome.Enabled = True
        MaskedTextBoxCPF.Enabled = True
        TextBoxEndereco.Enabled = True
        MaskedTextBoxTelefone.Enabled = True
        TextBoxEmail.Enabled = True
        ComboBoxSexo.Enabled = True
        ComboBoxTurno.Enabled = True
        DateTimePickerDataContratacao.Enabled = True
    End Sub
    Private Sub Limpar()
        TextBoxNome.Focus()
        TextBoxNome.Text = ""
        MaskedTextBoxCPF.Text = ""
        TextBoxEndereco.Text = ""
        MaskedTextBoxTelefone.Text = ""
        TextBoxEmail.Text = ""
        TextBoxNomeBusca.Text = ""
        DateTimePickerDataContratacao.Value = Now
    End Sub
    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        HabilitarCampos()
        Limpar()
        ButtonSalvar.Enabled = True
    End Sub
    Private Sub RadioButtonNome_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonNome.CheckedChanged
        MaskedTextBoxCPFBusca.Text = ""
        TextBoxNomeBusca.Text = ""
        TextBoxNomeBusca.Visible = True
        MaskedTextBoxCPFBusca.Visible = False
        TextBoxNomeBusca.Focus()
        Listar()
    End Sub
    Private Sub RadioButtonCPF_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCPF.CheckedChanged
        TextBoxNomeBusca.Text = ""
        MaskedTextBoxCPFBusca.Text = ""
        TextBoxNomeBusca.Visible = False
        MaskedTextBoxCPFBusca.Visible = True
        MaskedTextBoxCPFBusca.Focus()
        Listar()
    End Sub
    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Dim command As SqlCommand
        If MaskedTextBoxCPF.Text <> "" And TextBoxNome.Text <> "" Then
            Try
                Abrir()
                command = New SqlCommand("sp_salvarfunc", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@nome", TextBoxNome.Text)
                command.Parameters.AddWithValue("@sexo", ComboBoxSexo.Text)
                command.Parameters.AddWithValue("@cpf", MaskedTextBoxCPF.Text)
                command.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
                command.Parameters.AddWithValue("@telefone", MaskedTextBoxTelefone.Text)
                command.Parameters.AddWithValue("@email", TextBoxEmail.Text)
                command.Parameters.AddWithValue("@turno", ComboBoxTurno.Text)
                command.Parameters.AddWithValue("@data_contratado", DateTimePickerDataContratacao.Text)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                ButtonSalvar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim command As SqlCommand
        If MaskedTextBoxCPF.Text <> "" And TextBoxNome.Text <> "" Then
            Try
                Abrir()
                command = New SqlCommand("sp_editarfunc", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@nome", TextBoxNome.Text)
                command.Parameters.AddWithValue("@sexo", ComboBoxSexo.Text)
                command.Parameters.AddWithValue("@cpf", MaskedTextBoxCPF.Text)
                command.Parameters.AddWithValue("@endereco", TextBoxEndereco.Text)
                command.Parameters.AddWithValue("@telefone", MaskedTextBoxTelefone.Text)
                command.Parameters.AddWithValue("@email", TextBoxEmail.Text)
                command.Parameters.AddWithValue("@turno", ComboBoxTurno.Text)
                command.Parameters.AddWithValue("@data_contratado", DateTimePickerDataContratacao.Text)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        ButtonEditar.Enabled = True
        ButtonDeletar.Enabled = True
        HabilitarCampos()
        MaskedTextBoxCPF.Enabled = False
        TextBoxNome.Text = DataGridView.CurrentRow.Cells(1).Value
        ComboBoxSexo.Text = DataGridView.CurrentRow.Cells(2).Value
        MaskedTextBoxCPF.Text = DataGridView.CurrentRow.Cells(3).Value
        TextBoxEndereco.Text = DataGridView.CurrentRow.Cells(4).Value
        MaskedTextBoxTelefone.Text = DataGridView.CurrentRow.Cells(5).Value
        TextBoxEmail.Text = DataGridView.CurrentRow.Cells(6).Value
        ComboBoxTurno.Text = DataGridView.CurrentRow.Cells(7).Value
        DateTimePickerDataContratacao.Text = DataGridView.CurrentRow.Cells(8).Value
    End Sub
    Private Sub MaskedTextBoxCPFBusca_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBoxCPFBusca.TextChanged
        If MaskedTextBoxCPFBusca.Text = "   .   .   -" And DataGridView.Rows.Count > 0 Then
            Listar()
        Else
            Dim dataTable As New DataTable
            Dim dataAdapter As SqlDataAdapter
            Try
                Abrir()
                dataAdapter = New SqlDataAdapter("sp_buscarFuncCpf", conectaDB)
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                dataAdapter.SelectCommand.Parameters.AddWithValue("@cpf", MaskedTextBoxCPFBusca.Text)
                dataAdapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                ContarLinhas()
            Catch ex As Exception
                MessageBox.Show("Erro ao listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub

    Private Sub ContarLinhas()
        Dim total As Integer = DataGridView.Rows.Count
        LabelTotal.Text = CInt(total)
    End Sub
    Private Sub TextBoxNomeBusca_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNomeBusca.TextChanged
        If TextBoxNomeBusca.Text = "" And DataGridView.Rows.Count > 0 Then
            Listar()
        Else
            Dim dataTable As New DataTable
            Dim dataAdapter As SqlDataAdapter
            Try
                Abrir()
                dataAdapter = New SqlDataAdapter("sp_buscarFuncNome", conectaDB)
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                dataAdapter.SelectCommand.Parameters.AddWithValue("@nome", TextBoxNomeBusca.Text)
                dataAdapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                ContarLinhas()
            Catch ex As Exception
                MessageBox.Show("Erro ao listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub ButtonDeletar_Click(sender As Object, e As EventArgs) Handles ButtonDeletar.Click
        Dim command As SqlCommand
        If MaskedTextBoxCPF.Text <> "" Then
            Try
                Abrir()
                command = New SqlCommand("sp_excluirFunc", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@cpf", MaskedTextBoxCPF.Text)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                ButtonDeletar.Enabled = False
                ButtonEditar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
End Class