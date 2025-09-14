<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produtos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produtos))
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.GroupBoxProdutos = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxInformacoes = New System.Windows.Forms.GroupBox()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.LabelQtd = New System.Windows.Forms.Label()
        Me.TextBoxQtd = New System.Windows.Forms.TextBox()
        Me.LabelDescricao = New System.Windows.Forms.Label()
        Me.TextBoxDescricao = New System.Windows.Forms.TextBox()
        Me.GroupBoxImagem = New System.Windows.Forms.GroupBox()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonDeletar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelTotalProdutos = New System.Windows.Forms.Label()
        Me.GroupBoxProdutos.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInformacoes.SuspendLayout()
        Me.GroupBoxImagem.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(66, 43)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxNome.TabIndex = 2
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(25, 46)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = "Nome"
        '
        'GroupBoxProdutos
        '
        Me.GroupBoxProdutos.Controls.Add(Me.DataGridView)
        Me.GroupBoxProdutos.Location = New System.Drawing.Point(12, 175)
        Me.GroupBoxProdutos.Name = "GroupBoxProdutos"
        Me.GroupBoxProdutos.Size = New System.Drawing.Size(663, 216)
        Me.GroupBoxProdutos.TabIndex = 0
        Me.GroupBoxProdutos.TabStop = False
        Me.GroupBoxProdutos.Text = "Produtos"
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(6, 12)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(651, 191)
        Me.DataGridView.TabIndex = 0
        '
        'GroupBoxInformacoes
        '
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelBuscar)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxBuscar)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelValor)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxValor)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelQtd)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxQtd)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelDescricao)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxDescricao)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelNome)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxInformacoes.Location = New System.Drawing.Point(12, 8)
        Me.GroupBoxInformacoes.Name = "GroupBoxInformacoes"
        Me.GroupBoxInformacoes.Size = New System.Drawing.Size(321, 161)
        Me.GroupBoxInformacoes.TabIndex = 0
        Me.GroupBoxInformacoes.TabStop = False
        Me.GroupBoxInformacoes.Text = "Informações"
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Location = New System.Drawing.Point(20, 18)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(40, 13)
        Me.LabelBuscar.TabIndex = 0
        Me.LabelBuscar.Text = "Buscar"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(66, 15)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxBuscar.TabIndex = 1
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Location = New System.Drawing.Point(174, 98)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(31, 13)
        Me.LabelValor.TabIndex = 0
        Me.LabelValor.Text = "Valor"
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(211, 95)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxValor.TabIndex = 5
        '
        'LabelQtd
        '
        Me.LabelQtd.AutoSize = True
        Me.LabelQtd.Location = New System.Drawing.Point(33, 98)
        Me.LabelQtd.Name = "LabelQtd"
        Me.LabelQtd.Size = New System.Drawing.Size(27, 13)
        Me.LabelQtd.TabIndex = 0
        Me.LabelQtd.Text = "Qtd."
        '
        'TextBoxQtd
        '
        Me.TextBoxQtd.Location = New System.Drawing.Point(66, 95)
        Me.TextBoxQtd.Name = "TextBoxQtd"
        Me.TextBoxQtd.Size = New System.Drawing.Size(95, 20)
        Me.TextBoxQtd.TabIndex = 4
        '
        'LabelDescricao
        '
        Me.LabelDescricao.AutoSize = True
        Me.LabelDescricao.Location = New System.Drawing.Point(5, 72)
        Me.LabelDescricao.Name = "LabelDescricao"
        Me.LabelDescricao.Size = New System.Drawing.Size(55, 13)
        Me.LabelDescricao.TabIndex = 0
        Me.LabelDescricao.Text = "Descrição"
        '
        'TextBoxDescricao
        '
        Me.TextBoxDescricao.Location = New System.Drawing.Point(66, 69)
        Me.TextBoxDescricao.Name = "TextBoxDescricao"
        Me.TextBoxDescricao.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxDescricao.TabIndex = 3
        '
        'GroupBoxImagem
        '
        Me.GroupBoxImagem.Controls.Add(Me.ButtonAdicionar)
        Me.GroupBoxImagem.Controls.Add(Me.PictureBox)
        Me.GroupBoxImagem.Location = New System.Drawing.Point(542, 9)
        Me.GroupBoxImagem.Name = "GroupBoxImagem"
        Me.GroupBoxImagem.Size = New System.Drawing.Size(133, 160)
        Me.GroupBoxImagem.TabIndex = 0
        Me.GroupBoxImagem.TabStop = False
        Me.GroupBoxImagem.Text = "Imagem"
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(34, 127)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdicionar.TabIndex = 6
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(111, 109)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ButtonDeletar
        '
        Me.ButtonDeletar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeletar.FlatAppearance.BorderSize = 0
        Me.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeletar.Image = Global.micropdv.My.Resources.Resources.binButton
        Me.ButtonDeletar.Location = New System.Drawing.Point(442, 409)
        Me.ButtonDeletar.Name = "ButtonDeletar"
        Me.ButtonDeletar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonDeletar.TabIndex = 10
        Me.ButtonDeletar.UseVisualStyleBackColor = False
        '
        'ButtonEditar
        '
        Me.ButtonEditar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditar.FlatAppearance.BorderSize = 0
        Me.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditar.Image = Global.micropdv.My.Resources.Resources.editButton
        Me.ButtonEditar.Location = New System.Drawing.Point(351, 409)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonEditar.TabIndex = 9
        Me.ButtonEditar.UseVisualStyleBackColor = False
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalvar.FlatAppearance.BorderSize = 0
        Me.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvar.Image = Global.micropdv.My.Resources.Resources.disketteButton
        Me.ButtonSalvar.Location = New System.Drawing.Point(258, 409)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonSalvar.TabIndex = 8
        Me.ButtonSalvar.UseVisualStyleBackColor = False
        '
        'ButtonIncluir
        '
        Me.ButtonIncluir.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIncluir.FlatAppearance.BorderSize = 0
        Me.ButtonIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIncluir.Image = Global.micropdv.My.Resources.Resources.addButton
        Me.ButtonIncluir.Location = New System.Drawing.Point(169, 409)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(60, 60)
        Me.ButtonIncluir.TabIndex = 7
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(644, 396)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(25, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "999"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(12, 465)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "ID"
        Me.LabelID.Visible = False
        '
        'LabelTotalProdutos
        '
        Me.LabelTotalProdutos.AutoSize = True
        Me.LabelTotalProdutos.Location = New System.Drawing.Point(545, 396)
        Me.LabelTotalProdutos.Name = "LabelTotalProdutos"
        Me.LabelTotalProdutos.Size = New System.Drawing.Size(93, 13)
        Me.LabelTotalProdutos.TabIndex = 11
        Me.LabelTotalProdutos.Text = "Total de produtos:"
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.LabelTotalProdutos)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ButtonDeletar)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonIncluir)
        Me.Controls.Add(Me.GroupBoxImagem)
        Me.Controls.Add(Me.GroupBoxInformacoes)
        Me.Controls.Add(Me.GroupBoxProdutos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Micro PDV - Produtos"
        Me.GroupBoxProdutos.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInformacoes.ResumeLayout(False)
        Me.GroupBoxInformacoes.PerformLayout()
        Me.GroupBoxImagem.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents LabelNome As Label
    Friend WithEvents GroupBoxProdutos As GroupBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents GroupBoxInformacoes As GroupBox
    Friend WithEvents LabelValor As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents LabelQtd As Label
    Friend WithEvents TextBoxQtd As TextBox
    Friend WithEvents LabelDescricao As Label
    Friend WithEvents TextBoxDescricao As TextBox
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents GroupBoxImagem As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents ButtonIncluir As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonDeletar As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelTotalProdutos As Label
End Class
