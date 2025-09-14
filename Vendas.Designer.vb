<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vendas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendas))
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.ButtonDeletar = New System.Windows.Forms.Button()
        Me.GroupBoxDadosVenda = New System.Windows.Forms.GroupBox()
        Me.TextBoxEstoque = New System.Windows.Forms.TextBox()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.TextBoxQtd = New System.Windows.Forms.TextBox()
        Me.TextBoxNumeroVenda = New System.Windows.Forms.TextBox()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProduto = New System.Windows.Forms.ComboBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.LabelEstoque = New System.Windows.Forms.Label()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.LabelQtd = New System.Windows.Forms.Label()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelProduto = New System.Windows.Forms.Label()
        Me.LabelNumeroVenda = New System.Windows.Forms.Label()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBoxBusca = New System.Windows.Forms.TextBox()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.GroupBoxVendas = New System.Windows.Forms.GroupBox()
        Me.LabelTotalProdutos = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonRelatorio = New System.Windows.Forms.Button()
        Me.LabelID = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDadosVenda.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxVendas.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(6, 15)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(652, 236)
        Me.DataGridView.TabIndex = 0
        '
        'ButtonIncluir
        '
        Me.ButtonIncluir.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIncluir.FlatAppearance.BorderSize = 0
        Me.ButtonIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIncluir.Image = Global.micropdv.My.Resources.Resources.addButton
        Me.ButtonIncluir.Location = New System.Drawing.Point(165, 416)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(60, 60)
        Me.ButtonIncluir.TabIndex = 25
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'ButtonDeletar
        '
        Me.ButtonDeletar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeletar.FlatAppearance.BorderSize = 0
        Me.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeletar.Image = Global.micropdv.My.Resources.Resources.binButton
        Me.ButtonDeletar.Location = New System.Drawing.Point(347, 418)
        Me.ButtonDeletar.Name = "ButtonDeletar"
        Me.ButtonDeletar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonDeletar.TabIndex = 28
        Me.ButtonDeletar.UseVisualStyleBackColor = False
        '
        'GroupBoxDadosVenda
        '
        Me.GroupBoxDadosVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxDadosVenda.Controls.Add(Me.TextBoxEstoque)
        Me.GroupBoxDadosVenda.Controls.Add(Me.TextBoxValor)
        Me.GroupBoxDadosVenda.Controls.Add(Me.TextBoxQtd)
        Me.GroupBoxDadosVenda.Controls.Add(Me.TextBoxNumeroVenda)
        Me.GroupBoxDadosVenda.Controls.Add(Me.ComboBoxCliente)
        Me.GroupBoxDadosVenda.Controls.Add(Me.ComboBoxProduto)
        Me.GroupBoxDadosVenda.Controls.Add(Me.PictureBox)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelEstoque)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelValor)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelQtd)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelCliente)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelProduto)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelNumeroVenda)
        Me.GroupBoxDadosVenda.Controls.Add(Me.LabelBuscar)
        Me.GroupBoxDadosVenda.Controls.Add(Me.TextBoxBusca)
        Me.GroupBoxDadosVenda.Location = New System.Drawing.Point(12, 14)
        Me.GroupBoxDadosVenda.Name = "GroupBoxDadosVenda"
        Me.GroupBoxDadosVenda.Size = New System.Drawing.Size(664, 129)
        Me.GroupBoxDadosVenda.TabIndex = 0
        Me.GroupBoxDadosVenda.TabStop = False
        Me.GroupBoxDadosVenda.Text = "Dados da venda"
        '
        'TextBoxEstoque
        '
        Me.TextBoxEstoque.Location = New System.Drawing.Point(487, 48)
        Me.TextBoxEstoque.Name = "TextBoxEstoque"
        Me.TextBoxEstoque.Size = New System.Drawing.Size(39, 20)
        Me.TextBoxEstoque.TabIndex = 0
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(378, 47)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(51, 20)
        Me.TextBoxValor.TabIndex = 0
        '
        'TextBoxQtd
        '
        Me.TextBoxQtd.Location = New System.Drawing.Point(267, 47)
        Me.TextBoxQtd.Name = "TextBoxQtd"
        Me.TextBoxQtd.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxQtd.TabIndex = 3
        '
        'TextBoxNumeroVenda
        '
        Me.TextBoxNumeroVenda.Location = New System.Drawing.Point(267, 18)
        Me.TextBoxNumeroVenda.Name = "TextBoxNumeroVenda"
        Me.TextBoxNumeroVenda.Size = New System.Drawing.Size(52, 20)
        Me.TextBoxNumeroVenda.TabIndex = 0
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(378, 18)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(148, 21)
        Me.ComboBoxCliente.TabIndex = 1
        '
        'ComboBoxProduto
        '
        Me.ComboBoxProduto.FormattingEnabled = True
        Me.ComboBoxProduto.Location = New System.Drawing.Point(60, 47)
        Me.ComboBoxProduto.Name = "ComboBoxProduto"
        Me.ComboBoxProduto.Size = New System.Drawing.Size(173, 21)
        Me.ComboBoxProduto.TabIndex = 2
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(543, 14)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(111, 109)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'LabelEstoque
        '
        Me.LabelEstoque.AutoSize = True
        Me.LabelEstoque.Location = New System.Drawing.Point(435, 50)
        Me.LabelEstoque.Name = "LabelEstoque"
        Me.LabelEstoque.Size = New System.Drawing.Size(46, 13)
        Me.LabelEstoque.TabIndex = 0
        Me.LabelEstoque.Text = "Estoque"
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Location = New System.Drawing.Point(341, 50)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(31, 13)
        Me.LabelValor.TabIndex = 0
        Me.LabelValor.Text = "Valor"
        '
        'LabelQtd
        '
        Me.LabelQtd.AutoSize = True
        Me.LabelQtd.Location = New System.Drawing.Point(239, 50)
        Me.LabelQtd.Name = "LabelQtd"
        Me.LabelQtd.Size = New System.Drawing.Size(27, 13)
        Me.LabelQtd.TabIndex = 0
        Me.LabelQtd.Text = "Qtd."
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Location = New System.Drawing.Point(333, 21)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(39, 13)
        Me.LabelCliente.TabIndex = 0
        Me.LabelCliente.Text = "Cliente"
        '
        'LabelProduto
        '
        Me.LabelProduto.AutoSize = True
        Me.LabelProduto.Location = New System.Drawing.Point(11, 50)
        Me.LabelProduto.Name = "LabelProduto"
        Me.LabelProduto.Size = New System.Drawing.Size(44, 13)
        Me.LabelProduto.TabIndex = 0
        Me.LabelProduto.Text = "Produto"
        '
        'LabelNumeroVenda
        '
        Me.LabelNumeroVenda.AutoSize = True
        Me.LabelNumeroVenda.Location = New System.Drawing.Point(208, 21)
        Me.LabelNumeroVenda.Name = "LabelNumeroVenda"
        Me.LabelNumeroVenda.Size = New System.Drawing.Size(53, 13)
        Me.LabelNumeroVenda.TabIndex = 0
        Me.LabelNumeroVenda.Text = "Nº Venda"
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Location = New System.Drawing.Point(11, 20)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(43, 13)
        Me.LabelBuscar.TabIndex = 0
        Me.LabelBuscar.Text = "Buscar:"
        '
        'TextBoxBusca
        '
        Me.TextBoxBusca.Location = New System.Drawing.Point(60, 18)
        Me.TextBoxBusca.Name = "TextBoxBusca"
        Me.TextBoxBusca.Size = New System.Drawing.Size(142, 20)
        Me.TextBoxBusca.TabIndex = 0
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalvar.FlatAppearance.BorderSize = 0
        Me.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvar.Image = Global.micropdv.My.Resources.Resources.disketteButton
        Me.ButtonSalvar.Location = New System.Drawing.Point(254, 416)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonSalvar.TabIndex = 26
        Me.ButtonSalvar.UseVisualStyleBackColor = False
        '
        'GroupBoxVendas
        '
        Me.GroupBoxVendas.Controls.Add(Me.DataGridView)
        Me.GroupBoxVendas.Location = New System.Drawing.Point(12, 149)
        Me.GroupBoxVendas.Name = "GroupBoxVendas"
        Me.GroupBoxVendas.Size = New System.Drawing.Size(664, 257)
        Me.GroupBoxVendas.TabIndex = 0
        Me.GroupBoxVendas.TabStop = False
        Me.GroupBoxVendas.Text = "Vendas"
        '
        'LabelTotalProdutos
        '
        Me.LabelTotalProdutos.AutoSize = True
        Me.LabelTotalProdutos.Location = New System.Drawing.Point(552, 409)
        Me.LabelTotalProdutos.Name = "LabelTotalProdutos"
        Me.LabelTotalProdutos.Size = New System.Drawing.Size(87, 13)
        Me.LabelTotalProdutos.TabIndex = 0
        Me.LabelTotalProdutos.Text = "Total de vendas:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(645, 409)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(25, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "999"
        '
        'ButtonRelatorio
        '
        Me.ButtonRelatorio.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRelatorio.FlatAppearance.BorderSize = 0
        Me.ButtonRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRelatorio.Image = Global.micropdv.My.Resources.Resources.reportButton
        Me.ButtonRelatorio.Location = New System.Drawing.Point(433, 418)
        Me.ButtonRelatorio.Name = "ButtonRelatorio"
        Me.ButtonRelatorio.Size = New System.Drawing.Size(60, 60)
        Me.ButtonRelatorio.TabIndex = 30
        Me.ButtonRelatorio.UseVisualStyleBackColor = False
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(12, 468)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "ID"
        '
        'Vendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.ButtonRelatorio)
        Me.Controls.Add(Me.ButtonIncluir)
        Me.Controls.Add(Me.ButtonDeletar)
        Me.Controls.Add(Me.GroupBoxDadosVenda)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.GroupBoxVendas)
        Me.Controls.Add(Me.LabelTotalProdutos)
        Me.Controls.Add(Me.LabelTotal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Vendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDadosVenda.ResumeLayout(False)
        Me.GroupBoxDadosVenda.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxVendas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonIncluir As Button
    Friend WithEvents ButtonDeletar As Button
    Friend WithEvents GroupBoxDadosVenda As GroupBox
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxBusca As TextBox
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents GroupBoxVendas As GroupBox
    Friend WithEvents LabelTotalProdutos As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonRelatorio As Button
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelNumeroVenda As Label
    Friend WithEvents LabelProduto As Label
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelQtd As Label
    Friend WithEvents LabelValor As Label
    Friend WithEvents LabelEstoque As Label
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents TextBoxNumeroVenda As TextBox
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents ComboBoxProduto As ComboBox
    Friend WithEvents TextBoxEstoque As TextBox
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents TextBoxQtd As TextBox
End Class
