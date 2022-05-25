<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFatura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFatura))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNIFCliente = New System.Windows.Forms.TextBox()
        Me.PrecoFatura = New System.Windows.Forms.Label()
        Me.TextBoxPreco = New System.Windows.Forms.TextBox()
        Me.GenerateFaturaButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(118, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NIF do Cliente"
        '
        'TextBoxNIFCliente
        '
        Me.TextBoxNIFCliente.Location = New System.Drawing.Point(118, 132)
        Me.TextBoxNIFCliente.Name = "TextBoxNIFCliente"
        Me.TextBoxNIFCliente.Size = New System.Drawing.Size(196, 27)
        Me.TextBoxNIFCliente.TabIndex = 20
        '
        'PrecoFatura
        '
        Me.PrecoFatura.AutoSize = True
        Me.PrecoFatura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PrecoFatura.Location = New System.Drawing.Point(118, 207)
        Me.PrecoFatura.Name = "PrecoFatura"
        Me.PrecoFatura.Size = New System.Drawing.Size(205, 28)
        Me.PrecoFatura.TabIndex = 22
        Me.PrecoFatura.Text = "Preço Total (em euros)"
        '
        'TextBoxPreco
        '
        Me.TextBoxPreco.Location = New System.Drawing.Point(118, 257)
        Me.TextBoxPreco.Name = "TextBoxPreco"
        Me.TextBoxPreco.Size = New System.Drawing.Size(148, 27)
        Me.TextBoxPreco.TabIndex = 23
        '
        'GenerateFaturaButton
        '
        Me.GenerateFaturaButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateFaturaButton.Location = New System.Drawing.Point(218, 337)
        Me.GenerateFaturaButton.Name = "GenerateFaturaButton"
        Me.GenerateFaturaButton.Size = New System.Drawing.Size(385, 55)
        Me.GenerateFaturaButton.TabIndex = 26
        Me.GenerateFaturaButton.Text = "Guardar Fatura"
        Me.GenerateFaturaButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(513, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 197)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'AddFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GenerateFaturaButton)
        Me.Controls.Add(Me.TextBoxPreco)
        Me.Controls.Add(Me.PrecoFatura)
        Me.Controls.Add(Me.TextBoxNIFCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddFatura"
        Me.Text = "AddFatura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNIFCliente As TextBox
    Friend WithEvents PrecoFatura As Label
    Friend WithEvents TextBoxPreco As TextBox
    Friend WithEvents GenerateFaturaButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
