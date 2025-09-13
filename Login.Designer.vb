<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.MaskedTextBoxSenha = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBoxUser = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPass = New System.Windows.Forms.PictureBox()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuario.Location = New System.Drawing.Point(76, 171)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(216, 22)
        Me.TextBoxUsuario.TabIndex = 1
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelTitle.Location = New System.Drawing.Point(138, 127)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(93, 20)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Bem-vindo"
        '
        'MaskedTextBoxSenha
        '
        Me.MaskedTextBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaskedTextBoxSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBoxSenha.Location = New System.Drawing.Point(76, 209)
        Me.MaskedTextBoxSenha.Mask = "000\.000\.000-00"
        Me.MaskedTextBoxSenha.Name = "MaskedTextBoxSenha"
        Me.MaskedTextBoxSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.MaskedTextBoxSenha.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaskedTextBoxSenha.Size = New System.Drawing.Size(216, 22)
        Me.MaskedTextBoxSenha.TabIndex = 2
        '
        'PictureBoxUser
        '
        Me.PictureBoxUser.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxUser.Image = Global.micropdv.My.Resources.Resources.user
        Me.PictureBoxUser.Location = New System.Drawing.Point(43, 171)
        Me.PictureBoxUser.Name = "PictureBoxUser"
        Me.PictureBoxUser.Size = New System.Drawing.Size(29, 22)
        Me.PictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxUser.TabIndex = 5
        Me.PictureBoxUser.TabStop = False
        '
        'PictureBoxPass
        '
        Me.PictureBoxPass.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPass.Image = CType(resources.GetObject("PictureBoxPass.Image"), System.Drawing.Image)
        Me.PictureBoxPass.Location = New System.Drawing.Point(43, 209)
        Me.PictureBoxPass.Name = "PictureBoxPass"
        Me.PictureBoxPass.Size = New System.Drawing.Size(29, 22)
        Me.PictureBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxPass.TabIndex = 4
        Me.PictureBoxPass.TabStop = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Image = Global.micropdv.My.Resources.Resources.pdv
        Me.PictureBoxLogo.Location = New System.Drawing.Point(139, 32)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(92, 92)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 3
        Me.PictureBoxLogo.TabStop = False
        '
        'ButtonConectar
        '
        Me.ButtonConectar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonConectar.BackgroundImage = Global.micropdv.My.Resources.Resources.background
        Me.ButtonConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConectar.ForeColor = System.Drawing.SystemColors.Control
        Me.ButtonConectar.Location = New System.Drawing.Point(139, 245)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(100, 40)
        Me.ButtonConectar.TabIndex = 3
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(364, 341)
        Me.Controls.Add(Me.PictureBoxUser)
        Me.Controls.Add(Me.PictureBoxPass)
        Me.Controls.Add(Me.MaskedTextBoxSenha)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.ButtonConectar)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Micro PDV"
        CType(Me.PictureBoxUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents ButtonConectar As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents MaskedTextBoxSenha As MaskedTextBox
    Friend WithEvents PictureBoxPass As PictureBox
    Friend WithEvents PictureBoxUser As PictureBox
End Class
