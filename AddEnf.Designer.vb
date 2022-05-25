<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEnf
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
        Me.BackButtonAddEnfForm = New System.Windows.Forms.Button()
        Me.GenerateEnfButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxContact
        '
        Me.TextBoxContact.Location = New System.Drawing.Point(498, 193)
        Me.TextBoxContact.Name = "TextBoxContact"
        Me.TextBoxContact.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxContact.TabIndex = 37
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.Location = New System.Drawing.Point(83, 193)
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNIF.TabIndex = 36
        '
        'BackButtonAddEnfForm
        '
        Me.BackButtonAddEnfForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonAddEnfForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonAddEnfForm.Name = "BackButtonAddEnfForm"
        Me.BackButtonAddEnfForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonAddEnfForm.TabIndex = 35
        Me.BackButtonAddEnfForm.Text = "Back"
        Me.BackButtonAddEnfForm.UseVisualStyleBackColor = False
        '
        'GenerateEnfButton
        '
        Me.GenerateEnfButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateEnfButton.Location = New System.Drawing.Point(190, 296)
        Me.GenerateEnfButton.Name = "GenerateEnfButton"
        Me.GenerateEnfButton.Size = New System.Drawing.Size(413, 54)
        Me.GenerateEnfButton.TabIndex = 34
        Me.GenerateEnfButton.Text = "Adicionar novo Enfermeiro"
        Me.GenerateEnfButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(624, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(529, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "NIF"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(83, 100)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxName.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(498, 98)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(218, 27)
        Me.DateTimePicker1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nome"
        '
        'AddEnf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxContact)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.BackButtonAddEnfForm)
        Me.Controls.Add(Me.GenerateEnfButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddEnf"
        Me.Text = "Adicionar novo enfermeiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxContact As TextBox
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents BackButtonAddEnfForm As Button
    Friend WithEvents GenerateEnfButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
