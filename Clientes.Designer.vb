<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxInformacoes = New System.Windows.Forms.GroupBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.LabelTelefone = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxCPFBusca = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButtonCPF = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNome = New System.Windows.Forms.RadioButton()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBoxNomeBusca = New System.Windows.Forms.TextBox()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.LabelTotalProdutos = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonDeletar = New System.Windows.Forms.Button()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.GroupBoxClientes.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxInformacoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.DataGridView)
        Me.GroupBoxClientes.Location = New System.Drawing.Point(12, 142)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(664, 257)
        Me.GroupBoxClientes.TabIndex = 0
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
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
        'GroupBoxInformacoes
        '
        Me.GroupBoxInformacoes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelEmail)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxInformacoes.Controls.Add(Me.MaskedTextBoxTelefone)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelTelefone)
        Me.GroupBoxInformacoes.Controls.Add(Me.MaskedTextBoxCPF)
        Me.GroupBoxInformacoes.Controls.Add(Me.ComboBoxSexo)
        Me.GroupBoxInformacoes.Controls.Add(Me.MaskedTextBoxCPFBusca)
        Me.GroupBoxInformacoes.Controls.Add(Me.RadioButtonCPF)
        Me.GroupBoxInformacoes.Controls.Add(Me.RadioButtonNome)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelBuscar)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxNomeBusca)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelCPF)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelSexo)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelEndereco)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxEndereco)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelNome)
        Me.GroupBoxInformacoes.Controls.Add(Me.TextBoxNome)
        Me.GroupBoxInformacoes.Location = New System.Drawing.Point(12, 7)
        Me.GroupBoxInformacoes.Name = "GroupBoxInformacoes"
        Me.GroupBoxInformacoes.Size = New System.Drawing.Size(664, 129)
        Me.GroupBoxInformacoes.TabIndex = 0
        Me.GroupBoxInformacoes.TabStop = False
        Me.GroupBoxInformacoes.Text = "Informações"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(35, 99)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(35, 13)
        Me.LabelEmail.TabIndex = 0
        Me.LabelEmail.Text = "E-mail"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(76, 96)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(282, 20)
        Me.TextBoxEmail.TabIndex = 6
        '
        'MaskedTextBoxTelefone
        '
        Me.MaskedTextBoxTelefone.Location = New System.Drawing.Point(419, 70)
        Me.MaskedTextBoxTelefone.Mask = "(00)00000-0000"
        Me.MaskedTextBoxTelefone.Name = "MaskedTextBoxTelefone"
        Me.MaskedTextBoxTelefone.Size = New System.Drawing.Size(87, 20)
        Me.MaskedTextBoxTelefone.TabIndex = 5
        '
        'LabelTelefone
        '
        Me.LabelTelefone.AutoSize = True
        Me.LabelTelefone.Location = New System.Drawing.Point(364, 73)
        Me.LabelTelefone.Name = "LabelTelefone"
        Me.LabelTelefone.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefone.TabIndex = 0
        Me.LabelTelefone.Text = "Telefone"
        '
        'MaskedTextBoxCPF
        '
        Me.MaskedTextBoxCPF.Location = New System.Drawing.Point(76, 44)
        Me.MaskedTextBoxCPF.Mask = "000\.000\.000-00"
        Me.MaskedTextBoxCPF.Name = "MaskedTextBoxCPF"
        Me.MaskedTextBoxCPF.Size = New System.Drawing.Size(92, 20)
        Me.MaskedTextBoxCPF.TabIndex = 1
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"Masculino", "Feminino", "Não informado"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(550, 44)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxSexo.TabIndex = 3
        '
        'MaskedTextBoxCPFBusca
        '
        Me.MaskedTextBoxCPFBusca.Location = New System.Drawing.Point(193, 15)
        Me.MaskedTextBoxCPFBusca.Mask = "000\.000\.000-00"
        Me.MaskedTextBoxCPFBusca.Name = "MaskedTextBoxCPFBusca"
        Me.MaskedTextBoxCPFBusca.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaskedTextBoxCPFBusca.Size = New System.Drawing.Size(92, 20)
        Me.MaskedTextBoxCPFBusca.TabIndex = 0
        '
        'RadioButtonCPF
        '
        Me.RadioButtonCPF.AutoSize = True
        Me.RadioButtonCPF.Location = New System.Drawing.Point(143, 18)
        Me.RadioButtonCPF.Name = "RadioButtonCPF"
        Me.RadioButtonCPF.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonCPF.TabIndex = 0
        Me.RadioButtonCPF.TabStop = True
        Me.RadioButtonCPF.Text = "CPF"
        Me.RadioButtonCPF.UseVisualStyleBackColor = True
        '
        'RadioButtonNome
        '
        Me.RadioButtonNome.AutoSize = True
        Me.RadioButtonNome.Location = New System.Drawing.Point(84, 18)
        Me.RadioButtonNome.Name = "RadioButtonNome"
        Me.RadioButtonNome.Size = New System.Drawing.Size(53, 17)
        Me.RadioButtonNome.TabIndex = 0
        Me.RadioButtonNome.TabStop = True
        Me.RadioButtonNome.Text = "Nome"
        Me.RadioButtonNome.UseVisualStyleBackColor = True
        '
        'LabelBuscar
        '
        Me.LabelBuscar.AutoSize = True
        Me.LabelBuscar.Location = New System.Drawing.Point(17, 20)
        Me.LabelBuscar.Name = "LabelBuscar"
        Me.LabelBuscar.Size = New System.Drawing.Size(61, 13)
        Me.LabelBuscar.TabIndex = 0
        Me.LabelBuscar.Text = "Buscar por:"
        '
        'TextBoxNomeBusca
        '
        Me.TextBoxNomeBusca.Location = New System.Drawing.Point(193, 15)
        Me.TextBoxNomeBusca.Name = "TextBoxNomeBusca"
        Me.TextBoxNomeBusca.Size = New System.Drawing.Size(92, 20)
        Me.TextBoxNomeBusca.TabIndex = 0
        '
        'LabelCPF
        '
        Me.LabelCPF.AutoSize = True
        Me.LabelCPF.Location = New System.Drawing.Point(43, 47)
        Me.LabelCPF.Name = "LabelCPF"
        Me.LabelCPF.Size = New System.Drawing.Size(27, 13)
        Me.LabelCPF.TabIndex = 0
        Me.LabelCPF.Text = "CPF"
        '
        'LabelSexo
        '
        Me.LabelSexo.AutoSize = True
        Me.LabelSexo.Location = New System.Drawing.Point(515, 48)
        Me.LabelSexo.Name = "LabelSexo"
        Me.LabelSexo.Size = New System.Drawing.Size(31, 13)
        Me.LabelSexo.TabIndex = 0
        Me.LabelSexo.Text = "Sexo"
        '
        'LabelEndereco
        '
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.Location = New System.Drawing.Point(17, 73)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.Size = New System.Drawing.Size(53, 13)
        Me.LabelEndereco.TabIndex = 0
        Me.LabelEndereco.Text = "Endereço"
        '
        'TextBoxEndereco
        '
        Me.TextBoxEndereco.Location = New System.Drawing.Point(76, 70)
        Me.TextBoxEndereco.Name = "TextBoxEndereco"
        Me.TextBoxEndereco.Size = New System.Drawing.Size(282, 20)
        Me.TextBoxEndereco.TabIndex = 4
        '
        'LabelNome
        '
        Me.LabelNome.AutoSize = True
        Me.LabelNome.Location = New System.Drawing.Point(174, 47)
        Me.LabelNome.Name = "LabelNome"
        Me.LabelNome.Size = New System.Drawing.Size(35, 13)
        Me.LabelNome.TabIndex = 0
        Me.LabelNome.Text = "Nome"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.Location = New System.Drawing.Point(215, 44)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.Size = New System.Drawing.Size(291, 20)
        Me.TextBoxNome.TabIndex = 2
        '
        'LabelTotalProdutos
        '
        Me.LabelTotalProdutos.AutoSize = True
        Me.LabelTotalProdutos.Location = New System.Drawing.Point(551, 402)
        Me.LabelTotalProdutos.Name = "LabelTotalProdutos"
        Me.LabelTotalProdutos.Size = New System.Drawing.Size(88, 13)
        Me.LabelTotalProdutos.TabIndex = 29
        Me.LabelTotalProdutos.Text = "Total de clientes:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(645, 402)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(25, 13)
        Me.LabelTotal.TabIndex = 22
        Me.LabelTotal.Text = "999"
        '
        'ButtonDeletar
        '
        Me.ButtonDeletar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeletar.FlatAppearance.BorderSize = 0
        Me.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeletar.Image = Global.micropdv.My.Resources.Resources.binButton
        Me.ButtonDeletar.Location = New System.Drawing.Point(445, 413)
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
        Me.ButtonEditar.Location = New System.Drawing.Point(354, 413)
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
        Me.ButtonSalvar.Location = New System.Drawing.Point(261, 413)
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
        Me.ButtonIncluir.Location = New System.Drawing.Point(172, 413)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(60, 60)
        Me.ButtonIncluir.TabIndex = 7
        Me.ButtonIncluir.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.Controls.Add(Me.ButtonDeletar)
        Me.Controls.Add(Me.GroupBoxInformacoes)
        Me.Controls.Add(Me.LabelTotalProdutos)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonIncluir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.GroupBoxClientes.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxInformacoes.ResumeLayout(False)
        Me.GroupBoxInformacoes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents ButtonDeletar As Button
    Friend WithEvents GroupBoxInformacoes As GroupBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents MaskedTextBoxTelefone As MaskedTextBox
    Friend WithEvents LabelTelefone As Label
    Friend WithEvents MaskedTextBoxCPF As MaskedTextBox
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents MaskedTextBoxCPFBusca As MaskedTextBox
    Friend WithEvents RadioButtonCPF As RadioButton
    Friend WithEvents RadioButtonNome As RadioButton
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxNomeBusca As TextBox
    Friend WithEvents LabelCPF As Label
    Friend WithEvents LabelSexo As Label
    Friend WithEvents LabelEndereco As Label
    Friend WithEvents TextBoxEndereco As TextBox
    Friend WithEvents LabelNome As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents LabelTotalProdutos As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonIncluir As Button
End Class
