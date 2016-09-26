<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caixa_M
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
        Me.lbConta = New System.Windows.Forms.Label()
        Me.cbNumeroCaixa = New System.Windows.Forms.ComboBox()
        Me.cbDescricaoCaixa = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbConta
        '
        Me.lbConta.AutoSize = True
        Me.lbConta.Location = New System.Drawing.Point(52, 49)
        Me.lbConta.Name = "lbConta"
        Me.lbConta.Size = New System.Drawing.Size(38, 13)
        Me.lbConta.TabIndex = 0
        Me.lbConta.Text = "Conta:"
        '
        'cbNumeroCaixa
        '
        Me.cbNumeroCaixa.FormattingEnabled = True
        Me.cbNumeroCaixa.Location = New System.Drawing.Point(108, 41)
        Me.cbNumeroCaixa.Name = "cbNumeroCaixa"
        Me.cbNumeroCaixa.Size = New System.Drawing.Size(52, 21)
        Me.cbNumeroCaixa.TabIndex = 1
        '
        'cbDescricaoCaixa
        '
        Me.cbDescricaoCaixa.FormattingEnabled = True
        Me.cbDescricaoCaixa.Location = New System.Drawing.Point(166, 41)
        Me.cbDescricaoCaixa.Name = "cbDescricaoCaixa"
        Me.cbDescricaoCaixa.Size = New System.Drawing.Size(256, 21)
        Me.cbDescricaoCaixa.TabIndex = 2
        '
        'Caixa_M
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 301)
        Me.Controls.Add(Me.cbDescricaoCaixa)
        Me.Controls.Add(Me.cbNumeroCaixa)
        Me.Controls.Add(Me.lbConta)
        Me.Name = "Caixa_M"
        Me.Text = "Caixa_M"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbConta As Label
    Friend WithEvents cbNumeroCaixa As ComboBox
    Friend WithEvents cbDescricaoCaixa As ComboBox
End Class
