<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.LabelUsuarioNome = New System.Windows.Forms.Label()
        Me.LabelData = New System.Windows.Forms.Label()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.GroupBoxBemVindo = New System.Windows.Forms.GroupBox()
        Me.GroupBoxVendasDia = New System.Windows.Forms.GroupBox()
        Me.GroupBoxTotalVenda = New System.Windows.Forms.GroupBox()
        Me.LabelRS = New System.Windows.Forms.Label()
        Me.LabelTotalVenda = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBemVindo.SuspendLayout()
        Me.GroupBoxVendasDia.SuspendLayout()
        Me.GroupBoxTotalVenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.VendasToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(688, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = Global.micropdv.My.Resources.Resources.add
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarVendasToolStripMenuItem, Me.ListarVendasToolStripMenuItem})
        Me.VendasToolStripMenuItem.Image = Global.micropdv.My.Resources.Resources.cart
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'RegistrarVendasToolStripMenuItem
        '
        Me.RegistrarVendasToolStripMenuItem.Name = "RegistrarVendasToolStripMenuItem"
        Me.RegistrarVendasToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RegistrarVendasToolStripMenuItem.Text = "Registrar vendas"
        '
        'ListarVendasToolStripMenuItem
        '
        Me.ListarVendasToolStripMenuItem.Name = "ListarVendasToolStripMenuItem"
        Me.ListarVendasToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ListarVendasToolStripMenuItem.Text = "Listar vendas"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem1, Me.VendasToolStripMenuItem1})
        Me.RelatórioToolStripMenuItem.Image = Global.micropdv.My.Resources.Resources.report
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RelatórioToolStripMenuItem.Text = "Relatórios"
        '
        'ProdutosToolStripMenuItem1
        '
        Me.ProdutosToolStripMenuItem1.Name = "ProdutosToolStripMenuItem1"
        Me.ProdutosToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.ProdutosToolStripMenuItem1.Text = "Produtos"
        '
        'VendasToolStripMenuItem1
        '
        Me.VendasToolStripMenuItem1.Name = "VendasToolStripMenuItem1"
        Me.VendasToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.VendasToolStripMenuItem1.Text = "Vendas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1})
        Me.SairToolStripMenuItem.Image = Global.micropdv.My.Resources.Resources.leave
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(647, 258)
        Me.DataGridView.TabIndex = 1
        '
        'LabelUsuarioNome
        '
        Me.LabelUsuarioNome.AutoSize = True
        Me.LabelUsuarioNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuarioNome.Location = New System.Drawing.Point(8, 16)
        Me.LabelUsuarioNome.Name = "LabelUsuarioNome"
        Me.LabelUsuarioNome.Size = New System.Drawing.Size(80, 13)
        Me.LabelUsuarioNome.TabIndex = 0
        Me.LabelUsuarioNome.Text = "usuarioNome"
        '
        'LabelData
        '
        Me.LabelData.AutoSize = True
        Me.LabelData.Location = New System.Drawing.Point(8, 34)
        Me.LabelData.Name = "LabelData"
        Me.LabelData.Size = New System.Drawing.Size(94, 13)
        Me.LabelData.TabIndex = 0
        Me.LabelData.Text = "Data: 10/03/2020"
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Location = New System.Drawing.Point(106, 34)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(63, 13)
        Me.LabelHora.TabIndex = 0
        Me.LabelHora.Text = "Hora: 09:10"
        '
        'GroupBoxBemVindo
        '
        Me.GroupBoxBemVindo.Controls.Add(Me.LabelHora)
        Me.GroupBoxBemVindo.Controls.Add(Me.LabelUsuarioNome)
        Me.GroupBoxBemVindo.Controls.Add(Me.LabelData)
        Me.GroupBoxBemVindo.Location = New System.Drawing.Point(12, 27)
        Me.GroupBoxBemVindo.Name = "GroupBoxBemVindo"
        Me.GroupBoxBemVindo.Size = New System.Drawing.Size(329, 60)
        Me.GroupBoxBemVindo.TabIndex = 0
        Me.GroupBoxBemVindo.TabStop = False
        Me.GroupBoxBemVindo.Text = "Bem-vindo"
        '
        'GroupBoxVendasDia
        '
        Me.GroupBoxVendasDia.Controls.Add(Me.DataGridView)
        Me.GroupBoxVendasDia.Location = New System.Drawing.Point(13, 94)
        Me.GroupBoxVendasDia.Name = "GroupBoxVendasDia"
        Me.GroupBoxVendasDia.Size = New System.Drawing.Size(663, 283)
        Me.GroupBoxVendasDia.TabIndex = 0
        Me.GroupBoxVendasDia.TabStop = False
        Me.GroupBoxVendasDia.Text = "Vendas do dia"
        '
        'GroupBoxTotalVenda
        '
        Me.GroupBoxTotalVenda.Controls.Add(Me.LabelRS)
        Me.GroupBoxTotalVenda.Controls.Add(Me.LabelTotalVenda)
        Me.GroupBoxTotalVenda.Location = New System.Drawing.Point(348, 28)
        Me.GroupBoxTotalVenda.Name = "GroupBoxTotalVenda"
        Me.GroupBoxTotalVenda.Size = New System.Drawing.Size(322, 60)
        Me.GroupBoxTotalVenda.TabIndex = 0
        Me.GroupBoxTotalVenda.TabStop = False
        Me.GroupBoxTotalVenda.Text = "Total de venda diária"
        '
        'LabelRS
        '
        Me.LabelRS.AutoSize = True
        Me.LabelRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRS.Location = New System.Drawing.Point(97, 23)
        Me.LabelRS.Name = "LabelRS"
        Me.LabelRS.Size = New System.Drawing.Size(40, 26)
        Me.LabelRS.TabIndex = 0
        Me.LabelRS.Text = "R$"
        '
        'LabelTotalVenda
        '
        Me.LabelTotalVenda.AutoSize = True
        Me.LabelTotalVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalVenda.ForeColor = System.Drawing.Color.ForestGreen
        Me.LabelTotalVenda.Location = New System.Drawing.Point(136, 22)
        Me.LabelTotalVenda.Name = "LabelTotalVenda"
        Me.LabelTotalVenda.Size = New System.Drawing.Size(84, 26)
        Me.LabelTotalVenda.TabIndex = 0
        Me.LabelTotalVenda.Text = "999,99"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(688, 389)
        Me.Controls.Add(Me.GroupBoxTotalVenda)
        Me.Controls.Add(Me.GroupBoxVendasDia)
        Me.Controls.Add(Me.GroupBoxBemVindo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Micro PDV - Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBemVindo.ResumeLayout(False)
        Me.GroupBoxBemVindo.PerformLayout()
        Me.GroupBoxVendasDia.ResumeLayout(False)
        Me.GroupBoxTotalVenda.ResumeLayout(False)
        Me.GroupBoxTotalVenda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents LabelUsuarioNome As Label
    Friend WithEvents LabelData As Label
    Friend WithEvents LabelHora As Label
    Friend WithEvents GroupBoxBemVindo As GroupBox
    Friend WithEvents GroupBoxVendasDia As GroupBox
    Friend WithEvents GroupBoxTotalVenda As GroupBox
    Friend WithEvents LabelTotalVenda As Label
    Friend WithEvents LabelRS As Label
    Friend WithEvents ProdutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem1 As ToolStripMenuItem
End Class
