Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing
Imports Image = System.Drawing.Image
Public Class Vendas
    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        ButtonSalvar.Enabled = False
        CarregarProdutos()
        CarregarClientes()
        Listar()
        ButtonDeletar.Enabled = False
        ButtonRelatorio.Enabled = False
        totalizar()
    End Sub
    Private Sub Listar()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Try
            Abrir()
            dataAdapter = New SqlDataAdapter("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos AS pro ON ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente ORDER BY num_vendas desc", conectaDB)
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
        DataGridView.Columns(1).HeaderText = "Nº da venda"
        DataGridView.Columns(2).HeaderText = "Produto"
        DataGridView.Columns(3).HeaderText = "Cliente"
        DataGridView.Columns(4).HeaderText = "Valor unit."
        DataGridView.Columns(5).HeaderText = "Qtd."
        DataGridView.Columns(6).HeaderText = "Valor total"
        DataGridView.Columns(7).HeaderText = "Funcionário"
        DataGridView.Columns(8).HeaderText = "Data da venda"
        DataGridView.Columns(1).Width = 100
        DataGridView.Columns(2).Width = 100
        DataGridView.Columns(3).Width = 100
        DataGridView.Columns(4).Width = 100
        DataGridView.Columns(5).Width = 100
        DataGridView.Columns(6).Width = 100
        DataGridView.Columns(7).Width = 100
        DataGridView.Columns(8).Width = 100
    End Sub
    Private Sub DesabilitarCampos()
        TextBoxNumeroVenda.Enabled = False
        TextBoxQtd.Enabled = False
        ComboBoxCliente.Enabled = False
        ComboBoxProduto.Enabled = False
        ButtonRelatorio.Enabled = False
    End Sub
    Private Sub HabilitarCampos()
        TextBoxNumeroVenda.Enabled = True
        TextBoxQtd.Enabled = True
        ComboBoxCliente.Enabled = True
        ComboBoxProduto.Enabled = True
    End Sub
    Private Sub Limpar()
        TextBoxNumeroVenda.Focus()
        TextBoxNumeroVenda.Text = ""
        TextBoxQtd.Text = ""
        TextBoxBusca.Text = ""
    End Sub
    Sub CarregarProdutos()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Try
            Abrir()
            dataAdapter = New SqlDataAdapter("SELECT * FROM produtos", conectaDB)
            dataAdapter.Fill(dataTable)
            ComboBoxProduto.DisplayMember = "nome"
            ComboBoxProduto.ValueMember = "id_produto"
            ComboBoxProduto.DataSource = dataTable
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        Fechar()
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
    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        HabilitarCampos()
        Limpar()
        ButtonSalvar.Enabled = True
        gerarNumero()
    End Sub
    Private Sub ComboBoxProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProduto.SelectedIndexChanged
        atualizarValor()
    End Sub
    Private Sub atualizarValor()
        Dim command As New SqlCommand("buscarValorProd", conectaDB)
        Try
            Abrir()
            command.CommandType = 4
            command.Parameters.AddWithValue("@id_produto", ComboBoxProduto.SelectedValue)
            command.Parameters.Add("@valor", SqlDbType.Decimal).Direction = 2
            command.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            command.ExecuteNonQuery()
            Dim valor As Decimal = command.Parameters("@valor").Value
            TextBoxValor.Text = CStr(valor)
            Dim quant As Int32 = command.Parameters("@quant").Value
            TextBoxEstoque.Text = CStr(quant)
            Dim command2 As New SqlCommand("SELECT imagem FROM produtos WHERE id_produto = @id", conectaDB)
            command2.Parameters.AddWithValue("@id", ComboBoxProduto.SelectedValue)
            command2.ExecuteNonQuery()
            Dim tempImagem As Byte() = DirectCast(command2.ExecuteScalar, Byte())
            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada: ", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fileStream As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fileStream.Write(tempImagem, 0, tempImagem.Length)
            fileStream.Flush()
            fileStream.Close()
            PictureBox.Image = Image.FromFile(strArquivo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Fechar()
    End Sub
    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Dim command As SqlCommand
        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal
        quantidade = TextBoxQtd.Text
        estoque = TextBoxEstoque.Text
        Totestoque = estoque - quantidade
        If TextBoxNumeroVenda.Text <> "" And Totestoque >= 0 Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal
            valor = TextBoxValor.Text
            quant = TextBoxQtd.Text
            total = valor * quant
            Try
                Abrir()
                command = New SqlCommand("sp_editarEstoquepro", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@quantidade", Totestoque)
                command.Parameters.AddWithValue("@id_produto", ComboBoxProduto.SelectedValue)
                command.ExecuteNonQuery()
                command = New SqlCommand("sp_salvarvenda", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@num_vendas", TextBoxNumeroVenda.Text)
                command.Parameters.AddWithValue("@id_produto", ComboBoxProduto.SelectedValue)
                command.Parameters.AddWithValue("@id_cliente", ComboBoxCliente.SelectedValue)
                command.Parameters.AddWithValue("@quantidade", TextBoxQtd.Text)
                command.Parameters.AddWithValue("@valor", total)
                command.Parameters.AddWithValue("@funcionario", usuarioNome)
                command.Parameters.AddWithValue("@data_venda", Now.Date())
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                atualizarValor()
                BuscarVenda()
                totalizar()
                ComboBoxCliente.Enabled = False
                TextBoxNumeroVenda.Enabled = False
                TextBoxQtd.Text = ""
                ButtonRelatorio.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados: " + ex.Message)
                Fechar()
            End Try
        Else
            MsgBox("A quantidade em estoque é insuficiente!")
        End If
    End Sub
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs)
        Dim command As SqlCommand
        If TextBoxNumeroVenda.Text <> "" Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal
            valor = TextBoxValor.Text
            quant = TextBoxQtd.Text
            total = valor * quant
            Try
                Abrir()
                command = New SqlCommand("sp_editarvenda", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_vendas", LabelID.Text)
                command.Parameters.AddWithValue("@num_vendas", TextBoxNumeroVenda.Text)
                command.Parameters.AddWithValue("@id_produto", ComboBoxProduto.SelectedValue)
                command.Parameters.AddWithValue("@quantidade", TextBoxQtd.Text)
                command.Parameters.AddWithValue("@valor", total)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub ButtonDeletar_Click(sender As Object, e As EventArgs) Handles ButtonDeletar.Click
        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal
        quantidade = TextBoxQtd.Text
        estoque = TextBoxEstoque.Text
        Totestoque = estoque + quantidade
        Dim command As SqlCommand
        If LabelID.Text <> "" Then
            Try
                Abrir()
                command = New SqlCommand("sp_editarEstoquepro", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@quantidade", Totestoque)
                command.Parameters.AddWithValue("@id_produto", ComboBoxProduto.SelectedValue)
                command.ExecuteNonQuery()
                command = New SqlCommand("sp_excluirVenda", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_vendas", LabelID.Text)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                totalizar()
                atualizarValor()
                ButtonDeletar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        ButtonRelatorio.Enabled = True
        ButtonDeletar.Enabled = True
        HabilitarCampos()
        LabelID.Text = DataGridView.CurrentRow.Cells(0).Value
        TextBoxNumeroVenda.Text = DataGridView.CurrentRow.Cells(1).Value
        ComboBoxProduto.SelectedValue = DataGridView.CurrentRow.Cells(9).Value
        ComboBoxCliente.SelectedValue = DataGridView.CurrentRow.Cells(10).Value
        TextBoxQtd.Text = CInt(DataGridView.CurrentRow.Cells(5).Value)
    End Sub
    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBusca.TextChanged
        If TextBoxBusca.Text = "" And DataGridView.Rows.Count > 0 Then
            Listar()
            totalizar()
        Else
            Dim dataTable As New DataTable
            Dim dataAdapter As SqlDataAdapter
            Try
                Abrir()
                dataAdapter = New SqlDataAdapter("sp_buscarVenda", conectaDB)
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                dataAdapter.SelectCommand.Parameters.AddWithValue("@num_vendas", TextBoxBusca.Text)
                dataAdapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub totalizar()
        Dim total As Decimal
        For Each linha As DataGridViewRow In DataGridView.Rows
            total = total + linha.Cells(6).Value
        Next
        LabelTotal.Text = total
    End Sub
    Private Sub BuscarVenda()
        If TextBoxNumeroVenda.Text = "" Then
            Listar()
            totalizar()
        Else
            Dim dataTable As New DataTable
            Dim dataAdapter As SqlDataAdapter
            Try
                Abrir()
                dataAdapter = New SqlDataAdapter("sp_buscarVenda", conectaDB)
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                dataAdapter.SelectCommand.Parameters.AddWithValue("@num_vendas", TextBoxNumeroVenda.Text)
                dataAdapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                totalizar()
            Catch ex As Exception
                MessageBox.Show("Erro ao listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub gerarNumero()
        Dim command As New SqlCommand("buscarNumVenda", conectaDB)
        Try
            Abrir()
            command.CommandType = 4
            command.Parameters.Add("@num_venda", SqlDbType.Int).Direction = 2
            command.ExecuteNonQuery()
            Dim num As Integer = command.Parameters("@num_venda").Value
            Dim num_final As Integer
            num_final = num + 1
            TextBoxNumeroVenda.Text = CStr(num_final)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Fechar()
    End Sub
    'Private Sub buttonRelatorio_Click(sender As Object, e As EventArgs) Handles ButtonRelatorio.Click
    '    If TextBoxNumeroVenda.Text = "" Then
    '        MsgBox("Selecione uma venda na tabela!")
    '        Exit Sub
    '    End If
    '    Dim num As String
    '    num = TextBoxNumeroVenda.Text
    '    Dim form = New RelatorioComprovante(num)
    '    form.ShowDialog()
    'End Sub
End Class