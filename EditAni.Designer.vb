<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAni
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
        Me.BackButtonEditCliForm = New System.Windows.Forms.Button()
        Me.AnimalsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Sexo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Raca = New System.Windows.Forms.ComboBox()
        Me.EditCliButton = New System.Windows.Forms.Button()
        CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonEditCliForm
        '
        Me.BackButtonEditCliForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonEditCliForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonEditCliForm.Name = "BackButtonEditCliForm"
        Me.BackButtonEditCliForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonEditCliForm.TabIndex = 47
        Me.BackButtonEditCliForm.Text = "Back"
        Me.BackButtonEditCliForm.UseVisualStyleBackColor = False
        '
        'AnimalsDataGridView
        '
        Me.AnimalsDataGridView.AllowUserToAddRows = False
        Me.AnimalsDataGridView.AllowUserToDeleteRows = False
        Me.AnimalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnimalsDataGridView.Location = New System.Drawing.Point(38, 72)
        Me.AnimalsDataGridView.MultiSelect = False
        Me.AnimalsDataGridView.Name = "AnimalsDataGridView"
        Me.AnimalsDataGridView.ReadOnly = True
        Me.AnimalsDataGridView.RowHeadersWidth = 51
        Me.AnimalsDataGridView.RowTemplate.Height = 29
        Me.AnimalsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnimalsDataGridView.Size = New System.Drawing.Size(435, 300)
        Me.AnimalsDataGridView.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(722, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nome"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(570, 78)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxName.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(652, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 28)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "NIF do Cliente"
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.Location = New System.Drawing.Point(570, 149)
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNIF.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(734, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 28)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Sexo"
        '
        'CB_Sexo
        '
        Me.CB_Sexo.FormattingEnabled = True
        Me.CB_Sexo.Items.AddRange(New Object() {"M", "F"})
        Me.CB_Sexo.Location = New System.Drawing.Point(637, 220)
        Me.CB_Sexo.Name = "CB_Sexo"
        Me.CB_Sexo.Size = New System.Drawing.Size(151, 28)
        Me.CB_Sexo.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(735, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 28)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Raça"
        '
        'CB_Raca
        '
        Me.CB_Raca.FormattingEnabled = True
        Me.CB_Raca.Items.AddRange(New Object() {"CAO", "GATO", "GECKO", "COELHO", "MACACO", "CAVALO", "VACA", "HAMSTER", "PEIXE", "CARACOL", "TARTARUGA", "BURRO", "PONEI", "PORCO", "GALINHA", "PASSARO"})
        Me.CB_Raca.Location = New System.Drawing.Point(637, 301)
        Me.CB_Raca.Name = "CB_Raca"
        Me.CB_Raca.Size = New System.Drawing.Size(151, 28)
        Me.CB_Raca.TabIndex = 60
        '
        'EditCliButton
        '
        Me.EditCliButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditCliButton.Location = New System.Drawing.Point(183, 378)
        Me.EditCliButton.Name = "EditCliButton"
        Me.EditCliButton.Size = New System.Drawing.Size(413, 54)
        Me.EditCliButton.TabIndex = 61
        Me.EditCliButton.Text = "Guardar Alterações"
        Me.EditCliButton.UseVisualStyleBackColor = False
        '
        'EditAni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditCliButton)
        Me.Controls.Add(Me.CB_Raca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CB_Sexo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AnimalsDataGridView)
        Me.Controls.Add(Me.BackButtonEditCliForm)
        Me.Name = "EditAni"
        Me.Text = "Editar Animal"
        CType(Me.AnimalsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonEditCliForm As Button
    Friend WithEvents AnimalsDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_Sexo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_Raca As ComboBox
    Friend WithEvents EditCliButton As Button
End Class
