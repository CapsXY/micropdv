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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.GroupBoxProdutos = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxInformacoes = New System.Windows.Forms.GroupBox()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LabelValor = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.LabelQtd = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LabelDescricao = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBoxImagem = New System.Windows.Forms.GroupBox()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.ButtonDeletar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.GroupBoxProdutos.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInformacoes.SuspendLayout()
        Me.GroupBoxImagem.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 20)
        Me.TextBox1.TabIndex = 2
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(25, 50)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = "Nome"
        '
        'GroupBoxProdutos
        '
        Me.GroupBoxProdutos.Controls.Add(Me.DataGridView)
        Me.GroupBoxProdutos.Location = New System.Drawing.Point(12, 150)
        Me.GroupBoxProdutos.Name = "GroupBoxProdutos"
        Me.GroupBoxProdutos.Size = New System.Drawing.Size(663, 245)
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
        Me.DataGridView.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(651, 220)
        Me.DataGridView.TabIndex = 0
        '
        'GroupBoxInformacoes
        '
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelBuscar)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBox5)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelValor)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBox4)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelQtd)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBox3)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelDescricao)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBox2)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelNome)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBox1)
        Me.GroupBoxInformacoes.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxInformacoes.Name = "GroupBoxInformacoes"
        Me.GroupBoxInformacoes.Size = New System.Drawing.Size(442, 132)
        Me.GroupBoxInformacoes.TabIndex = 0
        Me.GroupBoxInformacoes.TabStop = False
        Me.GroupBoxInformacoes.Text = "Informações"
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Location = New System.Drawing.Point(20, 22)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(40, 13)
        Me.LabelBuscar.TabIndex = 0
        Me.LabelBuscar.Text = "Buscar"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(66, 19)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(357, 20)
        Me.TextBox5.TabIndex = 1
        '
        'LabelValor
        '
        Me.LabelValor.AutoSize = True
        Me.LabelValor.Location = New System.Drawing.Point(153, 102)
        Me.LabelValor.Name = "LabelValor"
        Me.LabelValor.Size = New System.Drawing.Size(31, 13)
        Me.LabelValor.TabIndex = 0
        Me.LabelValor.Text = "Valor"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(190, 99)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(91, 20)
        Me.TextBox4.TabIndex = 5
        '
        'LabelQtd
        '
        Me.LabelQtd.AutoSize = True
        Me.LabelQtd.Location = New System.Drawing.Point(33, 102)
        Me.LabelQtd.Name = "LabelQtd"
        Me.LabelQtd.Size = New System.Drawing.Size(27, 13)
        Me.LabelQtd.TabIndex = 0
        Me.LabelQtd.Text = "Qtd."
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(66, 99)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(81, 20)
        Me.TextBox3.TabIndex = 4
        '
        'LabelDescricao
        '
        Me.LabelDescricao.AutoSize = True
        Me.LabelDescricao.Location = New System.Drawing.Point(5, 76)
        Me.LabelDescricao.Name = "LabelDescricao"
        Me.LabelDescricao.Size = New System.Drawing.Size(55, 13)
        Me.LabelDescricao.TabIndex = 0
        Me.LabelDescricao.Text = "Descrição"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(66, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(357, 20)
        Me.TextBox2.TabIndex = 3
        '
        'GroupBoxImagem
        '
        Me.GroupBoxImagem.Controls.Add(Me.ButtonAdicionar)
        Me.GroupBoxImagem.Controls.Add(Me.PictureBox1)
        Me.GroupBoxImagem.Location = New System.Drawing.Point(460, 13)
        Me.GroupBoxImagem.Name = "GroupBoxImagem"
        Me.GroupBoxImagem.Size = New System.Drawing.Size(215, 131)
        Me.GroupBoxImagem.TabIndex = 0
        Me.GroupBoxImagem.TabStop = False
        Me.GroupBoxImagem.Text = "Imagem"
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(11, 101)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdicionar.TabIndex = 6
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'ButtonDeletar
        '
        Me.ButtonDeletar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeletar.FlatAppearance.BorderSize = 0
        Me.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeletar.Image = Global.micropdv.My.Resources.Resources.binButton
        Me.ButtonDeletar.Location = New System.Drawing.Point(441, 413)
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
        Me.ButtonEditar.Location = New System.Drawing.Point(350, 413)
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
        Me.ButtonSalvar.Location = New System.Drawing.Point(257, 413)
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
        Me.ButtonIncluir.Location = New System.Drawing.Point(168, 413)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(60, 60)
        Me.ButtonIncluir.TabIndex = 7
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(98, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(111, 109)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(555, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total de produtos: 999"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(12, 469)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(18, 13)
        Me.LabelID.TabIndex = 0
        Me.LabelID.Text = "ID"
        Me.LabelID.Visible = False
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelNome As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents GroupBoxProdutos As GroupBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents GroupBoxInformacoes As GroupBox
    Friend WithEvents LabelValor As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LabelQtd As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LabelDescricao As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents GroupBoxImagem As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents ButtonIncluir As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonDeletar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelID As Label
End Class
