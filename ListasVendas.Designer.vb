<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListasVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListasVendas))
        Me.GroupBoxVendas = New System.Windows.Forms.GroupBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBoxDadosVenda = New System.Windows.Forms.GroupBox()
        Me.ComboBoxCliente = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFuncionario = New System.Windows.Forms.ComboBox()
        Me.RadioButtonData = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFuncionario = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RadioButtonCliente = New System.Windows.Forms.RadioButton()
        Me.GroupBoxVendas.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDadosVenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxVendas
        '
        Me.GroupBoxVendas.Controls.Add(Me.DataGridView)
        Me.GroupBoxVendas.Location = New System.Drawing.Point(12, 71)
        Me.GroupBoxVendas.Name = "GroupBoxVendas"
        Me.GroupBoxVendas.Size = New System.Drawing.Size(664, 411)
        Me.GroupBoxVendas.TabIndex = 0
        Me.GroupBoxVendas.TabStop = False
        Me.GroupBoxVendas.Text = "Vendas"
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
        Me.DataGridView.Size = New System.Drawing.Size(652, 314)
        Me.DataGridView.TabIndex = 0
        '
        'GroupBoxDadosVenda
        '
        Me.GroupBoxDadosVenda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBoxDadosVenda.Controls.Add(Me.ComboBoxCliente)
        Me.GroupBoxDadosVenda.Controls.Add(Me.ComboBoxFuncionario)
        Me.GroupBoxDadosVenda.Controls.Add(Me.RadioButtonData)
        Me.GroupBoxDadosVenda.Controls.Add(Me.RadioButtonFuncionario)
        Me.GroupBoxDadosVenda.Controls.Add(Me.DateTimePicker)
        Me.GroupBoxDadosVenda.Controls.Add(Me.RadioButtonCliente)
        Me.GroupBoxDadosVenda.Location = New System.Drawing.Point(12, 14)
        Me.GroupBoxDadosVenda.Name = "GroupBoxDadosVenda"
        Me.GroupBoxDadosVenda.Size = New System.Drawing.Size(664, 51)
        Me.GroupBoxDadosVenda.TabIndex = 0
        Me.GroupBoxDadosVenda.TabStop = False
        Me.GroupBoxDadosVenda.Text = "Busca"
        '
        'ComboBoxCliente
        '
        Me.ComboBoxCliente.FormattingEnabled = True
        Me.ComboBoxCliente.Location = New System.Drawing.Point(219, 18)
        Me.ComboBoxCliente.Name = "ComboBoxCliente"
        Me.ComboBoxCliente.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCliente.TabIndex = 0
        '
        'ComboBoxFuncionario
        '
        Me.ComboBoxFuncionario.FormattingEnabled = True
        Me.ComboBoxFuncionario.Location = New System.Drawing.Point(219, 18)
        Me.ComboBoxFuncionario.Name = "ComboBoxFuncionario"
        Me.ComboBoxFuncionario.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxFuncionario.TabIndex = 0
        '
        'RadioButtonData
        '
        Me.RadioButtonData.AutoSize = True
        Me.RadioButtonData.Location = New System.Drawing.Point(165, 19)
        Me.RadioButtonData.Name = "RadioButtonData"
        Me.RadioButtonData.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonData.TabIndex = 3
        Me.RadioButtonData.TabStop = True
        Me.RadioButtonData.Text = "Data"
        Me.RadioButtonData.UseVisualStyleBackColor = True
        '
        'RadioButtonFuncionario
        '
        Me.RadioButtonFuncionario.AutoSize = True
        Me.RadioButtonFuncionario.Location = New System.Drawing.Point(82, 19)
        Me.RadioButtonFuncionario.Name = "RadioButtonFuncionario"
        Me.RadioButtonFuncionario.Size = New System.Drawing.Size(80, 17)
        Me.RadioButtonFuncionario.TabIndex = 2
        Me.RadioButtonFuncionario.TabStop = True
        Me.RadioButtonFuncionario.Text = "Funcionário"
        Me.RadioButtonFuncionario.UseVisualStyleBackColor = True
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker.Location = New System.Drawing.Point(219, 19)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker.TabIndex = 0
        '
        'RadioButtonCliente
        '
        Me.RadioButtonCliente.AutoSize = True
        Me.RadioButtonCliente.Location = New System.Drawing.Point(19, 19)
        Me.RadioButtonCliente.Name = "RadioButtonCliente"
        Me.RadioButtonCliente.Size = New System.Drawing.Size(57, 17)
        Me.RadioButtonCliente.TabIndex = 1
        Me.RadioButtonCliente.TabStop = True
        Me.RadioButtonCliente.Text = "Cliente"
        Me.RadioButtonCliente.UseVisualStyleBackColor = True
        '
        'ListasVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 494)
        Me.Controls.Add(Me.GroupBoxVendas)
        Me.Controls.Add(Me.GroupBoxDadosVenda)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ListasVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Micro PDV - Lista de vendas"
        Me.GroupBoxVendas.ResumeLayout(False)
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDadosVenda.ResumeLayout(False)
        Me.GroupBoxDadosVenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxVendas As GroupBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents GroupBoxDadosVenda As GroupBox
    Friend WithEvents RadioButtonCliente As RadioButton
    Friend WithEvents RadioButtonData As RadioButton
    Friend WithEvents RadioButtonFuncionario As RadioButton
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents ComboBoxCliente As ComboBox
    Friend WithEvents ComboBoxFuncionario As ComboBox
End Class
