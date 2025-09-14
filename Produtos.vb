Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Drawing
Imports Image = System.Drawing.Image
Public Class Produtos
    Private imagemCarregada As Image
    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarImagem()
        DesabilitarCampos()
        Listar()
        ButtonSalvar.Enabled = False
        ButtonEditar.Enabled = False
        ButtonDeletar.Enabled = False
    End Sub
    Private Sub Listar()
        Dim dataTable As New DataTable
        Dim dataAdapter As SqlDataAdapter
        Try
            Abrir()
            dataAdapter = New SqlDataAdapter("SELECT * FROM produtos", conectaDB)
            dataAdapter.Fill(dataTable)
            DataGridView.DataSource = dataTable
            ContarLinhas()
            FormatarDataGridView()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar: " + ex.Message)
            Fechar()
        End Try
    End Sub
    Private Sub FormatarDataGridView()
        DataGridView.Columns(0).Visible = False
        DataGridView.Columns(6).Visible = False
        DataGridView.Columns(1).HeaderText = "Nome"
        DataGridView.Columns(2).HeaderText = "Descriçao"
        DataGridView.Columns(3).HeaderText = "Quantidade"
        DataGridView.Columns(4).HeaderText = "Valor"
        DataGridView.Columns(5).HeaderText = "Data de Cadastro"
    End Sub
    Private Sub DesabilitarCampos()
        TextBoxNome.Enabled = False
        TextBoxDescricao.Enabled = False
        TextBoxQtd.Enabled = False
        TextBoxValor.Enabled = False
    End Sub
    Private Sub HabilitarCampos()
        TextBoxNome.Enabled = True
        TextBoxDescricao.Enabled = True
        TextBoxQtd.Enabled = True
        TextBoxValor.Enabled = True
    End Sub
    Private Sub Limpar()
        TextBoxBuscar.Text = ""
        TextBoxNome.Focus()
        TextBoxNome.Text = ""
        TextBoxDescricao.Text = ""
        TextBoxQtd.Text = ""
        TextBoxValor.Text = ""
        CarregarImagem()
    End Sub
    Private Sub ContarLinhas()
        Dim total As Integer = DataGridView.Rows.Count
        LabelTotal.Text = CInt(total)
    End Sub

    Private Sub ButtonIncluir_Click(sender As Object, e As EventArgs) Handles ButtonIncluir.Click
        HabilitarCampos()
        Limpar()
        ButtonSalvar.Enabled = True
    End Sub
    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Dim command As SqlCommand
        If TextBoxNome.Text <> "" Then
            Try
                Dim ms As New IO.MemoryStream
                imagemCarregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = ms.ToArray
                Abrir()
                command = New SqlCommand("sp_salvarpro", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@nome", TextBoxNome.Text)
                command.Parameters.AddWithValue("@descricao", TextBoxDescricao.Text)
                command.Parameters.AddWithValue("@quantidade", TextBoxQtd.Text)
                command.Parameters.AddWithValue("@valor", TextBoxValor.Text)
                command.Parameters.AddWithValue("@data_cadastro", Now.Date())
                command.Parameters.AddWithValue("@imagem", byteArray)
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
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        ButtonEditar.Enabled = True
        ButtonDeletar.Enabled = True
        HabilitarCampos()
        LabelID.Text = DataGridView.CurrentRow.Cells(0).Value
        TextBoxNome.Text = DataGridView.CurrentRow.Cells(1).Value
        TextBoxDescricao.Text = DataGridView.CurrentRow.Cells(2).Value
        TextBoxQtd.Text = DataGridView.CurrentRow.Cells(3).Value
        TextBoxValor.Text = CInt(DataGridView.CurrentRow.Cells(4).Value)
        Dim tempImagem As Byte() = DirectCast(DataGridView.CurrentRow.Cells(6).Value, Byte())
        If tempImagem Is Nothing Then
            MessageBox.Show("Imagem não localizada", "Erro")
            Exit Sub
        End If
        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
        Dim fileStream As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
        fileStream.Write(tempImagem, 0, tempImagem.Length)
        fileStream.Flush()
        fileStream.Close()
        imagemCarregada = Image.FromFile(strArquivo)
        PictureBox.Image = imagemCarregada
    End Sub
    Private Sub ButtonEditar_Click(sender As Object, e As EventArgs) Handles ButtonEditar.Click
        Dim command As SqlCommand
        If TextBoxNome.Text <> "" Then
            Try
                Dim ms As New IO.MemoryStream
                imagemCarregada.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim byteArray = ms.ToArray
                Abrir()
                command = New SqlCommand("sp_editarpro", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@nome", TextBoxNome.Text)
                command.Parameters.AddWithValue("@descricao", TextBoxDescricao.Text)
                command.Parameters.AddWithValue("@quantidade", TextBoxQtd.Text)
                command.Parameters.AddWithValue("@valor", TextBoxValor.Text)
                command.Parameters.AddWithValue("@id_produto", LabelID.Text)
                command.Parameters.AddWithValue("@imagem", byteArray)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub ButtonDeletar_Click(sender As Object, e As EventArgs) Handles ButtonDeletar.Click
        Dim command As SqlCommand
        If LabelID.Text <> "" Then
            Try
                Abrir()
                command = New SqlCommand("sp_excluirPro", conectaDB)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.AddWithValue("@id_produto", LabelID.Text)
                command.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                command.ExecuteNonQuery()
                Dim message As String = command.Parameters("@mensagem").Value.ToString
                MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Listar()
                Limpar()
                ButtonDeletar.Enabled = False
                ButtonEditar.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        If TextBoxBuscar.Text = "" And DataGridView.Rows.Count > 0 Then
            Listar()
        Else
            Dim dataTable As New DataTable
            Dim dataAdapter As SqlDataAdapter
            Try
                Abrir()
                dataAdapter = New SqlDataAdapter("sp_buscarProNome", conectaDB)
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
                dataAdapter.SelectCommand.Parameters.AddWithValue("@nome", TextBoxBuscar.Text)
                dataAdapter.Fill(dataTable)
                DataGridView.DataSource = dataTable
                ContarLinhas()
            Catch ex As Exception
                MessageBox.Show("Erro ao listar: " + ex.Message)
                Fechar()
            End Try
        End If
    End Sub
    Private Sub ButtonAdicionar_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png"}
            If OFD.ShowDialog = DialogResult.OK Then
                Try
                    imagemCarregada = Image.FromFile(OFD.FileName)
                    PictureBox.Image = imagemCarregada
                Catch ex As Exception
                    MessageBox.Show("Erro ao carregar imagem: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    imagemCarregada = Nothing
                    PictureBox.Image = Nothing
                End Try
            End If
        End Using
    End Sub
    Sub CarregarImagem()
        Dim image As String = "https://www.buritama.sp.leg.br/imagens/parlamentares-2013-2016/sem-foto.jpg/image"
        Dim request As System.Net.HttpWebRequest
        Dim response As System.Net.HttpWebResponse
        request = request.Create(image)
        response = request.GetResponse
        imagemCarregada = New Bitmap(response.GetResponseStream)
        PictureBox.Image = imagemCarregada
        request.Abort()
    End Sub
End Class