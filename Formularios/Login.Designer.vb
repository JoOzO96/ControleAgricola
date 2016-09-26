<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbSenha = New System.Windows.Forms.Label()
        Me.txUsuario = New System.Windows.Forms.TextBox()
        Me.txSenha = New System.Windows.Forms.TextBox()
        Me.btLogin = New System.Windows.Forms.Button()
        Me.btSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(52, 37)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(88, 20)
        Me.lbUsuario.TabIndex = 0
        Me.lbUsuario.Text = "USUARIO:"
        '
        'lbSenha
        '
        Me.lbSenha.AutoSize = True
        Me.lbSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSenha.Location = New System.Drawing.Point(52, 78)
        Me.lbSenha.Name = "lbSenha"
        Me.lbSenha.Size = New System.Drawing.Size(69, 20)
        Me.lbSenha.TabIndex = 1
        Me.lbSenha.Text = "SENHA:"
        '
        'txUsuario
        '
        Me.txUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txUsuario.Location = New System.Drawing.Point(160, 36)
        Me.txUsuario.Name = "txUsuario"
        Me.txUsuario.Size = New System.Drawing.Size(171, 26)
        Me.txUsuario.TabIndex = 2
        '
        'txSenha
        '
        Me.txSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txSenha.Location = New System.Drawing.Point(160, 78)
        Me.txSenha.Name = "txSenha"
        Me.txSenha.Size = New System.Drawing.Size(171, 26)
        Me.txSenha.TabIndex = 3
        '
        'btLogin
        '
        Me.btLogin.Location = New System.Drawing.Point(105, 145)
        Me.btLogin.Name = "btLogin"
        Me.btLogin.Size = New System.Drawing.Size(75, 33)
        Me.btLogin.TabIndex = 4
        Me.btLogin.Text = "Login"
        Me.btLogin.UseVisualStyleBackColor = True
        '
        'btSair
        '
        Me.btSair.Location = New System.Drawing.Point(217, 145)
        Me.btSair.Name = "btSair"
        Me.btSair.Size = New System.Drawing.Size(75, 33)
        Me.btSair.TabIndex = 5
        Me.btSair.Text = "Sair"
        Me.btSair.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 217)
        Me.Controls.Add(Me.btSair)
        Me.Controls.Add(Me.btLogin)
        Me.Controls.Add(Me.txSenha)
        Me.Controls.Add(Me.txUsuario)
        Me.Controls.Add(Me.lbSenha)
        Me.Controls.Add(Me.lbUsuario)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbSenha As Label
    Friend WithEvents txUsuario As TextBox
    Friend WithEvents txSenha As TextBox
    Friend WithEvents btLogin As Button
    Friend WithEvents btSair As Button
End Class
