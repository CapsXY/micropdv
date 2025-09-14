Imports System.Data.SqlClient
Public Class Principal
    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelUsuarioNome.Text = usuarioNome
        If (usuarioNome = "micro") Then
            FuncionáriosToolStripMenuItem.Enabled = True
        Else
            FuncionáriosToolStripMenuItem.Enabled = False
        End If
        Listar()
        Totalizar()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelData.Text = "Data: " & Now.ToShortDateString()
        LabelHora.Text = "Hora: " & Now.ToShortTimeString()
    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New Produtos
        form.ShowDialog()
    End Sub
    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New Funcionarios
        form.ShowDialog()
    End Sub
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New Clientes
        form.ShowDialog()
    End Sub
    Private Sub RegistrarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendasToolStripMenuItem.Click
        Dim form = New Vendas
        form.ShowDialog()
    End Sub
    Private Sub ListarVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVendasToolStripMenuItem.Click
        Dim form = New ListasVendas
        form.ShowDialog()
    End Sub
    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New RelatorioProduto
        form.ShowDialog()
    End Sub
    Private Sub VendasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem1.Click
        Dim form = New RelatorioVenda
        form.ShowDialog()
    End Sub
    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub
    Private Sub FormatarDataGridView()
        DataGridView.Columns(0).Visible = False
        DataGridView.Columns(9).Visible = False
        DataGridView.Columns(10).Visible = False
        DataGridView.Columns(1).HeaderText = "Nº Venda"
        DataGridView.Columns(2).HeaderText = "Produto"
        DataGridView.Columns(3).HeaderText = "Cliente"
        DataGridView.Columns(4).HeaderText = "Valor unit."
        DataGridView.Columns(5).HeaderText = "Qtd."
        DataGridView.Columns(6).HeaderText = "Valor total"
        DataGridView.Columns(7).HeaderText = "Funcionário"
        DataGridView.Columns(8).HeaderText = "Data venda"
    End Sub
    Private Sub Listar()
        Dim dataTable As New DataTable
        Dim dataAtapter As SqlDataAdapter
        Dim command As SqlCommand
        Try
            Abrir()
            command = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda =  @data and ven.funcionario = @funcionario order by num_vendas desc", conectaDB)
            command.Parameters.AddWithValue("@data", Now.Date())
            command.Parameters.AddWithValue("@funcionario", usuarioNome)
            dataAtapter = New SqlDataAdapter(command)
            dataAtapter.Fill(dataTable)
            DataGridView.DataSource = dataTable
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub Totalizar()
        Dim total As Decimal
        For Each linha As DataGridViewRow In DataGridView.Rows
            total = total + linha.Cells(6).Value
        Next
        LabelTotalVenda.Text = total
    End Sub
    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class