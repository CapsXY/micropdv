<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Funcionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Funcionarios))
        Me.LabelTotalProdutos = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonEditar = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonIncluir = New System.Windows.Forms.Button()
        Me.LabelBuscar = New System.Windows.Forms.Label()
        Me.TextBoxNomeBusca = New System.Windows.Forms.TextBox()
        Me.LabelCPF = New System.Windows.Forms.Label()
        Me.LabelSexo = New System.Windows.Forms.Label()
        Me.ButtonDeletar = New System.Windows.Forms.Button()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.TextBoxEndereco = New System.Windows.Forms.TextBox()
        Me.GroupBoxInformacoes = New System.Windows.Forms.GroupBox()
        Me.LabelDataContratacao = New System.Windows.Forms.Label()
        Me.DateTimePickerDataContratacao = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxTurno = New System.Windows.Forms.ComboBox()
        Me.LabelTurno = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.MaskedTextBoxTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.LabelTelefone = New System.Windows.Forms.Label()
        Me.MaskedTextBoxCPF = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBoxCPFBusca = New System.Windows.Forms.MaskedTextBox()
        Me.RadioButtonCPF = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNome = New System.Windows.Forms.RadioButton()
        Me.LabelNome = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxFuncionarios = New System.Windows.Forms.GroupBox()
        Me.GroupBoxInformacoes.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxFuncionarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTotalProdutos
        '
        Me.LabelTotalProdutos.AutoSize = True
        Me.LabelTotalProdutos.Location = New System.Drawing.Point(530, 401)
        Me.LabelTotalProdutos.Name = "LabelTotalProdutos"
        Me.LabelTotalProdutos.Size = New System.Drawing.Size(109, 13)
        Me.LabelTotalProdutos.TabIndex = 0
        Me.LabelTotalProdutos.Text = "Total de funcionários:"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Location = New System.Drawing.Point(645, 401)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(25, 13)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "999"
        '
        'ButtonEditar
        '
        Me.ButtonEditar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditar.FlatAppearance.BorderSize = 0
        Me.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditar.Image = Global.micropdv.My.Resources.Resources.editButton
        Me.ButtonEditar.Location = New System.Drawing.Point(354, 412)
        Me.ButtonEditar.Name = "ButtonEditar"
        Me.ButtonEditar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonEditar.TabIndex = 11
        Me.ButtonEditar.UseVisualStyleBackColor = False
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSalvar.FlatAppearance.BorderSize = 0
        Me.ButtonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalvar.Image = Global.micropdv.My.Resources.Resources.disketteButton
        Me.ButtonSalvar.Location = New System.Drawing.Point(261, 412)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonSalvar.TabIndex = 10
        Me.ButtonSalvar.UseVisualStyleBackColor = False
        '
        'ButtonIncluir
        '
        Me.ButtonIncluir.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIncluir.FlatAppearance.BorderSize = 0
        Me.ButtonIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIncluir.Image = Global.micropdv.My.Resources.Resources.addButton
        Me.ButtonIncluir.Location = New System.Drawing.Point(172, 412)
        Me.ButtonIncluir.Name = "ButtonIncluir"
        Me.ButtonIncluir.Size = New System.Drawing.Size(60, 60)
        Me.ButtonIncluir.TabIndex = 9
        Me.ButtonIncluir.UseVisualStyleBackColor = False
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
        'ButtonDeletar
        '
        Me.ButtonDeletar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeletar.FlatAppearance.BorderSize = 0
        Me.ButtonDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDeletar.Image = Global.micropdv.My.Resources.Resources.binButton
        Me.ButtonDeletar.Location = New System.Drawing.Point(445, 412)
        Me.ButtonDeletar.Name = "ButtonDeletar"
        Me.ButtonDeletar.Size = New System.Drawing.Size(60, 60)
        Me.ButtonDeletar.TabIndex = 12
        Me.ButtonDeletar.UseVisualStyleBackColor = False
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
        'GroupBoxInformacoes
        '
        Me.GroupBoxInformacoes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelDataContratacao)
        Me.GroupBoxInformacoes.Controls.Add(Me.DateTimePickerDataContratacao)
        Me.GroupBoxInformacoes.Controls.Add(Me.ComboBoxTurno)
        Me.GroupBoxInformacoes.Controls.Add(Me.LabelTurno)
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
        Me.GroupBoxInformacoes.Location = New System.Drawing.Point(12, 6)
        Me.GroupBoxInformacoes.Name = "GroupBoxInformacoes"
        Me.GroupBoxInformacoes.Size = New System.Drawing.Size(664, 129)
        Me.GroupBoxInformacoes.TabIndex = 0
        Me.GroupBoxInformacoes.TabStop = False
        Me.GroupBoxInformacoes.Text = "Informações"
        '
        'LabelDataContratacao
        '
        Me.LabelDataContratacao.AutoSize = True
        Me.LabelDataContratacao.Location = New System.Drawing.Point(365, 102)
        Me.LabelDataContratacao.Name = "LabelDataContratacao"
        Me.LabelDataContratacao.Size = New System.Drawing.Size(105, 13)
        Me.LabelDataContratacao.TabIndex = 0
        Me.LabelDataContratacao.Text = "Data da contratação"
        '
        'DateTimePickerDataContratacao
        '
        Me.DateTimePickerDataContratacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDataContratacao.Location = New System.Drawing.Point(475, 99)
        Me.DateTimePickerDataContratacao.Name = "DateTimePickerDataContratacao"
        Me.DateTimePickerDataContratacao.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePickerDataContratacao.TabIndex = 8
        '
        'ComboBoxTurno
        '
        Me.ComboBoxTurno.FormattingEnabled = True
        Me.ComboBoxTurno.Items.AddRange(New Object() {"Manhã", "Tarde"})
        Me.ComboBoxTurno.Location = New System.Drawing.Point(550, 73)
        Me.ComboBoxTurno.Name = "ComboBoxTurno"
        Me.ComboBoxTurno.Size = New System.Drawing.Size(104, 21)
        Me.ComboBoxTurno.TabIndex = 6
        '
        'LabelTurno
        '
        Me.LabelTurno.AutoSize = True
        Me.LabelTurno.Location = New System.Drawing.Point(509, 76)
        Me.LabelTurno.Name = "LabelTurno"
        Me.LabelTurno.Size = New System.Drawing.Size(35, 13)
        Me.LabelTurno.TabIndex = 0
        Me.LabelTurno.Text = "Turno"
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
        Me.TextBoxEmail.TabIndex = 7
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
        Me.MaskedTextBoxCPFBusca.Location = New System.Drawing.Point(193, 14)
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
        'GroupBoxFuncionarios
        '
        Me.GroupBoxFuncionarios.Controls.Add(Me.DataGridView)
        Me.GroupBoxFuncionarios.Location = New System.Drawing.Point(12, 141)
        Me.GroupBoxFuncionarios.Name = "GroupBoxFuncionarios"
        Me.GroupBoxFuncionarios.Size = New System.Drawing.Size(664, 257)
        Me.GroupBoxFuncionarios.TabIndex = 0
        Me.GroupBoxFuncionarios.TabStop = False
        Me.GroupBoxFuncionarios.Text = "Funcionários"
        '
        'Funcionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.LabelTotalProdutos)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.ButtonEditar)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonIncluir)
        Me.Controls.Add(Me.ButtonDeletar)
        Me.Controls.Add(Me.GroupBoxInformacoes)
        Me.Controls.Add(Me.GroupBoxFuncionarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Funcionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Micro PDV - Funcionarios"
        Me.GroupBoxInformacoes.ResumeLayout(False)
        Me.GroupBoxInformacoes.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxFuncionarios.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTotalProdutos As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonEditar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonIncluir As Button
    Friend WithEvents LabelBuscar As Label
    Friend WithEvents TextBoxNomeBusca As TextBox
    Friend WithEvents LabelCPF As Label
    Friend WithEvents LabelSexo As Label
    Friend WithEvents ButtonDeletar As Button
    Friend WithEvents LabelEndereco As Label
    Friend WithEvents TextBoxEndereco As TextBox
    Friend WithEvents GroupBoxInformacoes As GroupBox
    Friend WithEvents LabelNome As Label
    Friend WithEvents TextBoxNome As TextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents GroupBoxFuncionarios As GroupBox
    Friend WithEvents RadioButtonCPF As RadioButton
    Friend WithEvents RadioButtonNome As RadioButton
    Friend WithEvents MaskedTextBoxCPFBusca As MaskedTextBox
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents MaskedTextBoxCPF As MaskedTextBox
    Friend WithEvents LabelTelefone As Label
    Friend WithEvents MaskedTextBoxTelefone As MaskedTextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ComboBoxTurno As ComboBox
    Friend WithEvents LabelTurno As Label
    Friend WithEvents DateTimePickerDataContratacao As DateTimePicker
    Friend WithEvents LabelDataContratacao As Label
End Class
