<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCli
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
        Me.TextBoxContact = New System.Windows.Forms.TextBox()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.BackButtonAddCliForm = New System.Windows.Forms.Button()
        Me.GenerateCliButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBoxContact
        '
        Me.TextBoxContact.Location = New System.Drawing.Point(498, 193)
        Me.TextBoxContact.Name = "TextBoxContact"
        Me.TextBoxContact.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxContact.TabIndex = 47
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.Location = New System.Drawing.Point(83, 193)
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNIF.TabIndex = 46
        '
        'BackButtonAddCliForm
        '
        Me.BackButtonAddCliForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonAddCliForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonAddCliForm.Name = "BackButtonAddCliForm"
        Me.BackButtonAddCliForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonAddCliForm.TabIndex = 45
        Me.BackButtonAddCliForm.Text = "Back"
        Me.BackButtonAddCliForm.UseVisualStyleBackColor = False
        '
        'GenerateCliButton
        '
        Me.GenerateCliButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateCliButton.Location = New System.Drawing.Point(190, 336)
        Me.GenerateCliButton.Name = "GenerateCliButton"
        Me.GenerateCliButton.Size = New System.Drawing.Size(413, 54)
        Me.GenerateCliButton.TabIndex = 44
        Me.GenerateCliButton.Text = "Adicionar novo Cliente"
        Me.GenerateCliButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(624, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(529, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 28)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "NIF"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(83, 100)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxName.TabIndex = 40
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(498, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(218, 27)
        Me.DateTimePicker1.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(83, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 28)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Morada"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(83, 285)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(633, 27)
        Me.TextBoxAddress.TabIndex = 49
        '
        'AddCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxContact)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.BackButtonAddCliForm)
        Me.Controls.Add(Me.GenerateCliButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddCli"
        Me.Text = "Adicionar novo cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxContact As TextBox
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents BackButtonAddCliForm As Button
    Friend WithEvents GenerateCliButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxAddress As TextBox
End Class
