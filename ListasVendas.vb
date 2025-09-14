Imports System.Data.SqlClient
Public Class ListasVendas
    Private Sub ListasVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        CarregarClientes()
        Listar()
    End Sub
    Private Sub RadioButtonCliente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonCliente.CheckedChanged
        ComboBoxCliente.Text = ""
        ComboBoxFuncionario.Text = ""
        ComboBoxCliente.Visible = True
        ComboBoxFuncionario.Visible = False
        DateTimePicker.Visible = False
    End Sub
    Private Sub RadioButtonFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFuncionario.CheckedChanged
        ComboBoxCliente.Text = ""
        ComboBoxFuncionario.Text = ""
        ComboBoxCliente.Visible = False
        ComboBoxFuncionario.Visible = True
        DateTimePicker.Visible = False
    End Sub
    Private Sub RadioButtonData_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonData.CheckedChanged
        ComboBoxCliente.Text = ""
        ComboBoxFuncionario.Text = ""
        ComboBoxCliente.Visible = False
        ComboBoxFuncionario.Visible = False
        DateTimePicker.Visible = True
    End Sub
    Sub CarregarClientes()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Try
            Abrir()
            dataAdapter = New SqlDataAdapter("SELECT * FROM clientes", conectaDB)
            dataAdapter.Fill(dataTable)
            ComboBoxCliente.DisplayMember = "nome"
            ComboBoxCliente.ValueMember = "id_cliente"
            ComboBoxCliente.DataSource = dataTable
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Fechar()
    End Sub
    Sub CarregarFuncionarios()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Try
            Abrir()
            dataAdapter = New SqlDataAdapter("SELECT * FROM funcionarios", conectaDB)
            dataAdapter.Fill(dataTable)
            ComboBoxFuncionario.DisplayMember = "nome"
            ComboBoxFuncionario.ValueMember = "id_func"
            ComboBoxFuncionario.DataSource = dataTable
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Fechar()
    End Sub
    Private Sub Listar()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Dim command As SqlCommand
        Try
            Abrir()
            command = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas AS ven INNER JOIN produtos AS pro ON ven.id_produto = pro.id_produto INNER JOIN clientes AS cli ON ven.id_cliente = cli.id_cliente WHERE ven.data_venda = @data ORDER BY num_vendas DESC", conectaDB)
            command.Parameters.AddWithValue("@data", Now.Date())
            dataAdapter = New SqlDataAdapter(command)
            dataAdapter.Fill(dataTable)
            DataGridView.DataSource = dataTable
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub FormatarDataGridView()
        DataGridView.Columns(0).Visible = False
        DataGridView.Columns(9).Visible = False
        DataGridView.Columns(10).Visible = False
        DataGridView.Columns(1).HeaderText = "Nº venda"
        DataGridView.Columns(2).HeaderText = "Produto"
        DataGridView.Columns(3).HeaderText = "Cliente"
        DataGridView.Columns(4).HeaderText = "Valor unit."
        DataGridView.Columns(5).HeaderText = "Quantidade"
        DataGridView.Columns(6).HeaderText = "Valor total"
        DataGridView.Columns(7).HeaderText = "Funcionário"
        DataGridView.Columns(8).HeaderText = "Data venda"
    End Sub
    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Dim command As SqlCommand
        Try
            Abrir()
            command = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas AS ven INNER JOIN produtos AS pro ON ven.id_produto = pro.id_produto INNER JOIN clientes AS cli ON ven.id_cliente = cli.id_cliente WHERE ven.data_venda = @data ORDER BY num_vendas DESC", conectaDB)
            command.Parameters.AddWithValue("@data", DateTimePicker.Text)
            dataAdapter = New SqlDataAdapter(command)
            dataAdapter.Fill(dataTable)
            DataGridView.DataSource = dataAdapter
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub ComboBoxFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFuncionario.SelectedIndexChanged
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Dim command As SqlCommand
        Try
            Abrir()
            command = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas AS ven INNER JOIN produtos AS pro ON ven.id_produto = pro.id_produto INNER JOIN clientes AS cli ON ven.id_cliente = cli.id_cliente WHERE ven.funcionario = @func ORDER BY num_vendas DESC", conectaDB)
            command.Parameters.AddWithValue("@func", ComboBoxFuncionario.Text)
            dataAdapter = New SqlDataAdapter(command)
            dataAdapter.Fill(dataTable)
            DataGridView.DataSource = dataTable
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub ComboBoxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCliente.SelectedIndexChanged
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Dim command As SqlCommand
        Try
            Abrir()
            command = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas AS ven INNER JOIN produtos AS pro ON ven.id_produto = pro.id_produto INNER JOIN clientes AS cli ON ven.id_cliente = cli.id_cliente WHERE ven.id_cliente = @cli ORDER BY num_vendas DESC", conectaDB)
            command.Parameters.AddWithValue("@cli", ComboBoxCliente.SelectedValue)
            dataAdapter = New SqlDataAdapter(command)
            dataAdapter.Fill(dataTable)
            DataGridView.DataSource = dataTable
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
End Class