<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Animais
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
        Me.DeleteAnimalButton = New System.Windows.Forms.Button()
        Me.EditAnimalButton = New System.Windows.Forms.Button()
        Me.AnimalsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NewAnimalButton = New System.Windows.Forms.Button()
        Me.BackButtonAnimaisForm = New System.Windows.Forms.Button()
        Me.ComboBoxRaca = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.ButtonFiltrar = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteAnimalButton
        '
        Me.DeleteAnimalButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.DeleteAnimalButton.Location = New System.Drawing.Point(468, 230)
        Me.DeleteAnimalButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteAnimalButton.Name = "DeleteAnimalButton"
        Me.DeleteAnimalButton.Size = New System.Drawing.Size(178, 40)
        Me.DeleteAnimalButton.TabIndex = 22
        Me.DeleteAnimalButton.Text = "Eliminar Animal"
        Me.DeleteAnimalButton.UseVisualStyleBackColor = False
        '
        'EditAnimalButton
        '
        Me.EditAnimalButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.EditAnimalButton.Location = New System.Drawing.Point(468, 154)
        Me.EditAnimalButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EditAnimalButton.Name = "EditAnimalButton"
        Me.EditAnimalButton.Size = New System.Drawing.Size(178, 40)
        Me.EditAnimalButton.TabIndex = 21
        Me.EditAnimalButton.Text = "Editar Animal"
        Me.EditAnimalButton.UseVisualStyleBackColor = False
        '
        'AnimalsDataGridView
        '
        Me.AnimalsDataGridView.AllowUserToAddRows = False
        Me.AnimalsDataGridView.AllowUserToDeleteRows = False
        Me.AnimalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnimalsDataGridView.Location = New System.Drawing.Point(41, 59)
        Me.AnimalsDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AnimalsDataGridView.Name = "AnimalsDataGridView"
        Me.AnimalsDataGridView.ReadOnly = True
        Me.AnimalsDataGridView.RowHeadersWidth = 51
        Me.AnimalsDataGridView.RowTemplate.Height = 29
        Me.AnimalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnimalsDataGridView.Size = New System.Drawing.Size(350, 225)
        Me.AnimalsDataGridView.TabIndex = 20
        '
        'NewAnimalButton
        '
        Me.NewAnimalButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NewAnimalButton.Location = New System.Drawing.Point(468, 83)
        Me.NewAnimalButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewAnimalButton.Name = "NewAnimalButton"
        Me.NewAnimalButton.Size = New System.Drawing.Size(178, 40)
        Me.NewAnimalButton.TabIndex = 19
        Me.NewAnimalButton.Text = "Novo Animal"
        Me.NewAnimalButton.UseVisualStyleBackColor = False
        '
        'BackButtonAnimaisForm
        '
        Me.BackButtonAnimaisForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonAnimaisForm.Location = New System.Drawing.Point(10, 9)
        Me.BackButtonAnimaisForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButtonAnimaisForm.Name = "BackButtonAnimaisForm"
        Me.BackButtonAnimaisForm.Size = New System.Drawing.Size(82, 22)
        Me.BackButtonAnimaisForm.TabIndex = 18
        Me.BackButtonAnimaisForm.Text = "Back"
        Me.BackButtonAnimaisForm.UseVisualStyleBackColor = False
        '
        'ComboBoxRaca
        '
        Me.ComboBoxRaca.FormattingEnabled = True
        Me.ComboBoxRaca.Items.AddRange(New Object() {"CAO", "GATO", "GECKO", "COELHO", "MACACO", "CAVALO", "VACA", "HAMSTER", "PEIXE", "CARACOL", "TARTARUGA", "BURRO", "PONEI", "PORCO", "GALINHA", "PASSARO"})
        Me.ComboBoxRaca.Location = New System.Drawing.Point(41, 289)
        Me.ComboBoxRaca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxRaca.Name = "ComboBoxRaca"
        Me.ComboBoxRaca.Size = New System.Drawing.Size(157, 23)
        Me.ComboBoxRaca.TabIndex = 23
        Me.ComboBoxRaca.Text = "Raça"
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"M", "F"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(287, 289)
        Me.ComboBoxSexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(105, 23)
        Me.ComboBoxSexo.TabIndex = 24
        Me.ComboBoxSexo.Text = "Sexo"
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.BackColor = System.Drawing.Color.Turquoise
        Me.ButtonFiltrar.Location = New System.Drawing.Point(116, 314)
        Me.ButtonFiltrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(193, 22)
        Me.ButtonFiltrar.TabIndex = 25
        Me.ButtonFiltrar.Text = "Filtrar"
        Me.ButtonFiltrar.UseVisualStyleBackColor = False
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ButtonLimpar.Location = New System.Drawing.Point(236, 33)
        Me.ButtonLimpar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(155, 22)
        Me.ButtonLimpar.TabIndex = 26
        Me.ButtonLimpar.Text = "Limpar filtros"
        Me.ButtonLimpar.UseVisualStyleBackColor = False
        '
        'Animais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.ButtonLimpar)
        Me.Controls.Add(Me.ButtonFiltrar)
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.ComboBoxRaca)
        Me.Controls.Add(Me.DeleteAnimalButton)
        Me.Controls.Add(Me.EditAnimalButton)
        Me.Controls.Add(Me.AnimalsDataGridView)
        Me.Controls.Add(Me.NewAnimalButton)
        Me.Controls.Add(Me.BackButtonAnimaisForm)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Animais"
        Me.Text = "Animais"
        CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeleteAnimalButton As Button
    Friend WithEvents EditAnimalButton As Button
    Friend WithEvents AnimalsDataGridView As DataGridView
    Friend WithEvents NewAnimalButton As Button
    Friend WithEvents BackButtonAnimaisForm As Button
    Friend WithEvents ComboBoxRaca As ComboBox
    Friend WithEvents ComboBoxSexo As ComboBox
    Friend WithEvents ButtonFiltrar As Button
    Friend WithEvents ButtonLimpar As Button
End Class
