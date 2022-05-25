<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEpi
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
        Me.BackButtonForm2 = New System.Windows.Forms.Button()
        Me.GenerateEventButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNLicencaVet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNDocAni = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InternamentoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CirurgiaRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExameRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConsultaRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextBoxHora = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'BackButtonForm2
        '
        Me.BackButtonForm2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonForm2.Location = New System.Drawing.Point(10, 9)
        Me.BackButtonForm2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButtonForm2.Name = "BackButtonForm2"
        Me.BackButtonForm2.Size = New System.Drawing.Size(82, 22)
        Me.BackButtonForm2.TabIndex = 25
        Me.BackButtonForm2.Text = "Back"
        Me.BackButtonForm2.UseVisualStyleBackColor = False
        '
        'GenerateEventButton
        '
        Me.GenerateEventButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateEventButton.Location = New System.Drawing.Point(450, 250)
        Me.GenerateEventButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GenerateEventButton.Name = "GenerateEventButton"
        Me.GenerateEventButton.Size = New System.Drawing.Size(178, 40)
        Me.GenerateEventButton.TabIndex = 24
        Me.GenerateEventButton.Text = "Novo Episódio"
        Me.GenerateEventButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(580, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(580, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Data"
        '
        'TextBoxNLicencaVet
        '
        Me.TextBoxNLicencaVet.Location = New System.Drawing.Point(73, 145)
        Me.TextBoxNLicencaVet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNLicencaVet.Name = "TextBoxNLicencaVet"
        Me.TextBoxNLicencaVet.Size = New System.Drawing.Size(275, 23)
        Me.TextBoxNLicencaVet.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(73, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Número de Licença do Veterinário"
        '
        'TextBoxNDocAni
        '
        Me.TextBoxNDocAni.Location = New System.Drawing.Point(73, 75)
        Me.TextBoxNDocAni.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxNDocAni.Name = "TextBoxNDocAni"
        Me.TextBoxNDocAni.Size = New System.Drawing.Size(275, 23)
        Me.TextBoxNDocAni.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(73, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Número de Documento do Animal"
        '
        'InternamentoRadioButton
        '
        Me.InternamentoRadioButton.AutoSize = True
        Me.InternamentoRadioButton.Location = New System.Drawing.Point(73, 272)
        Me.InternamentoRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InternamentoRadioButton.Name = "InternamentoRadioButton"
        Me.InternamentoRadioButton.Size = New System.Drawing.Size(97, 19)
        Me.InternamentoRadioButton.TabIndex = 16
        Me.InternamentoRadioButton.TabStop = True
        Me.InternamentoRadioButton.Text = "Internamento"
        Me.InternamentoRadioButton.UseVisualStyleBackColor = True
        '
        'CirurgiaRadioButton
        '
        Me.CirurgiaRadioButton.AutoSize = True
        Me.CirurgiaRadioButton.Location = New System.Drawing.Point(73, 250)
        Me.CirurgiaRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CirurgiaRadioButton.Name = "CirurgiaRadioButton"
        Me.CirurgiaRadioButton.Size = New System.Drawing.Size(67, 19)
        Me.CirurgiaRadioButton.TabIndex = 15
        Me.CirurgiaRadioButton.TabStop = True
        Me.CirurgiaRadioButton.Text = "Cirurgia"
        Me.CirurgiaRadioButton.UseVisualStyleBackColor = True
        '
        'ExameRadioButton
        '
        Me.ExameRadioButton.AutoSize = True
        Me.ExameRadioButton.Location = New System.Drawing.Point(73, 227)
        Me.ExameRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExameRadioButton.Name = "ExameRadioButton"
        Me.ExameRadioButton.Size = New System.Drawing.Size(60, 19)
        Me.ExameRadioButton.TabIndex = 14
        Me.ExameRadioButton.TabStop = True
        Me.ExameRadioButton.Text = "Exame"
        Me.ExameRadioButton.UseVisualStyleBackColor = True
        '
        'ConsultaRadioButton
        '
        Me.ConsultaRadioButton.AutoSize = True
        Me.ConsultaRadioButton.Location = New System.Drawing.Point(73, 205)
        Me.ConsultaRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ConsultaRadioButton.Name = "ConsultaRadioButton"
        Me.ConsultaRadioButton.Size = New System.Drawing.Size(72, 19)
        Me.ConsultaRadioButton.TabIndex = 13
        Me.ConsultaRadioButton.TabStop = True
        Me.ConsultaRadioButton.Text = "Consulta"
        Me.ConsultaRadioButton.UseVisualStyleBackColor = True
        '
        'TextBoxHora
        '
        Me.TextBoxHora.Location = New System.Drawing.Point(436, 145)
        Me.TextBoxHora.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxHora.Name = "TextBoxHora"
        Me.TextBoxHora.Size = New System.Drawing.Size(193, 23)
        Me.TextBoxHora.TabIndex = 26
        Me.TextBoxHora.Text = "00:00"
        Me.TextBoxHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(436, 74)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(191, 23)
        Me.DateTimePicker1.TabIndex = 51
        '
        'AddEpi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBoxHora)
        Me.Controls.Add(Me.BackButtonForm2)
        Me.Controls.Add(Me.GenerateEventButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNLicencaVet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxNDocAni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InternamentoRadioButton)
        Me.Controls.Add(Me.CirurgiaRadioButton)
        Me.Controls.Add(Me.ExameRadioButton)
        Me.Controls.Add(Me.ConsultaRadioButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddEpi"
        Me.Text = "Adicionar Episódio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonForm2 As Button
    Friend WithEvents GenerateEventButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNLicencaVet As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNDocAni As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents InternamentoRadioButton As RadioButton
    Friend WithEvents CirurgiaRadioButton As RadioButton
    Friend WithEvents ExameRadioButton As RadioButton
    Friend WithEvents ConsultaRadioButton As RadioButton
    Friend WithEvents TextBoxHora As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
