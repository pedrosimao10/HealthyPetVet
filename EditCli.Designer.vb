<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCli
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
        Me.ClientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.TextBoxContact = New System.Windows.Forms.TextBox()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.BackButtonEditCliForm = New System.Windows.Forms.Button()
        Me.EditCliButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.ClientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientsDataGridView
        '
        Me.ClientsDataGridView.AllowUserToAddRows = False
        Me.ClientsDataGridView.AllowUserToDeleteRows = False
        Me.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientsDataGridView.Location = New System.Drawing.Point(40, 72)
        Me.ClientsDataGridView.MultiSelect = False
        Me.ClientsDataGridView.Name = "ClientsDataGridView"
        Me.ClientsDataGridView.ReadOnly = True
        Me.ClientsDataGridView.RowHeadersWidth = 51
        Me.ClientsDataGridView.RowTemplate.Height = 29
        Me.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientsDataGridView.Size = New System.Drawing.Size(435, 300)
        Me.ClientsDataGridView.TabIndex = 49
        '
        'TextBoxContact
        '
        Me.TextBoxContact.Location = New System.Drawing.Point(560, 266)
        Me.TextBoxContact.Name = "TextBoxContact"
        Me.TextBoxContact.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxContact.TabIndex = 48
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.Location = New System.Drawing.Point(560, 144)
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNIF.TabIndex = 47
        '
        'BackButtonEditCliForm
        '
        Me.BackButtonEditCliForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonEditCliForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonEditCliForm.Name = "BackButtonEditCliForm"
        Me.BackButtonEditCliForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonEditCliForm.TabIndex = 46
        Me.BackButtonEditCliForm.Text = "Back"
        Me.BackButtonEditCliForm.UseVisualStyleBackColor = False
        '
        'EditCliButton
        '
        Me.EditCliButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditCliButton.Location = New System.Drawing.Point(200, 380)
        Me.EditCliButton.Name = "EditCliButton"
        Me.EditCliButton.Size = New System.Drawing.Size(413, 54)
        Me.EditCliButton.TabIndex = 45
        Me.EditCliButton.Text = "Guardar Alterações"
        Me.EditCliButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(686, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 28)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(589, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Data de Nascimento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(736, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 28)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "NIF"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(560, 83)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxName.TabIndex = 41
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(560, 205)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(218, 27)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(712, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Nome"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(560, 327)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxAddress.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(697, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 28)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Morada"
        '
        'EditCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClientsDataGridView)
        Me.Controls.Add(Me.TextBoxContact)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.BackButtonEditCliForm)
        Me.Controls.Add(Me.EditCliButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditCli"
        Me.Text = "Editar Cliente"
        CType(Me.ClientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientsDataGridView As DataGridView
    Friend WithEvents TextBoxContact As TextBox
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents BackButtonEditCliForm As Button
    Friend WithEvents EditCliButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents Label5 As Label
End Class
