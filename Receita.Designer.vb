<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receita
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
        Me.NomeMedicamento = New System.Windows.Forms.Label()
        Me.TextBoxNomeMedicamento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPreco = New System.Windows.Forms.TextBox()
        Me.GenerateReceitaButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNRegisto = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'NomeMedicamento
        '
        Me.NomeMedicamento.AutoSize = True
        Me.NomeMedicamento.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NomeMedicamento.Location = New System.Drawing.Point(64, 63)
        Me.NomeMedicamento.Name = "NomeMedicamento"
        Me.NomeMedicamento.Size = New System.Drawing.Size(221, 28)
        Me.NomeMedicamento.TabIndex = 18
        Me.NomeMedicamento.Text = "Nome do Medicamento"
        '
        'TextBoxNomeMedicamento
        '
        Me.TextBoxNomeMedicamento.Location = New System.Drawing.Point(64, 103)
        Me.TextBoxNomeMedicamento.Name = "TextBoxNomeMedicamento"
        Me.TextBoxNomeMedicamento.Size = New System.Drawing.Size(314, 27)
        Me.TextBoxNomeMedicamento.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(64, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 28)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Preço Total (em euros)"
        '
        'TextBoxPreco
        '
        Me.TextBoxPreco.Location = New System.Drawing.Point(64, 290)
        Me.TextBoxPreco.Name = "TextBoxPreco"
        Me.TextBoxPreco.Size = New System.Drawing.Size(148, 27)
        Me.TextBoxPreco.TabIndex = 22
        '
        'GenerateReceitaButton
        '
        Me.GenerateReceitaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateReceitaButton.Location = New System.Drawing.Point(198, 361)
        Me.GenerateReceitaButton.Name = "GenerateReceitaButton"
        Me.GenerateReceitaButton.Size = New System.Drawing.Size(385, 55)
        Me.GenerateReceitaButton.TabIndex = 25
        Me.GenerateReceitaButton.Text = "Guardar Receita"
        Me.GenerateReceitaButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(64, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Número de Registo do Medicamento"
        '
        'TextBoxNRegisto
        '
        Me.TextBoxNRegisto.Location = New System.Drawing.Point(64, 195)
        Me.TextBoxNRegisto.Name = "TextBoxNRegisto"
        Me.TextBoxNRegisto.Size = New System.Drawing.Size(148, 27)
        Me.TextBoxNRegisto.TabIndex = 27
        '
        'Receita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxNRegisto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenerateReceitaButton)
        Me.Controls.Add(Me.TextBoxPreco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNomeMedicamento)
        Me.Controls.Add(Me.NomeMedicamento)
        Me.Name = "Receita"
        Me.Text = "Receita"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NomeMedicamento As Label
    Friend WithEvents TextBoxNomeMedicamento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPreco As TextBox
    Friend WithEvents GenerateReceitaButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNRegisto As TextBox
End Class
