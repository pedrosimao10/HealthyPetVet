<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Veterinarios
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
        Me.BackButtonVeterinariosForm = New System.Windows.Forms.Button()
        Me.NewVetButton = New System.Windows.Forms.Button()
        Me.VetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EditVetButton = New System.Windows.Forms.Button()
        Me.DeleteVetButton = New System.Windows.Forms.Button()
        CType(Me.VetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonVeterinariosForm
        '
        Me.BackButtonVeterinariosForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonVeterinariosForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonVeterinariosForm.Name = "BackButtonVeterinariosForm"
        Me.BackButtonVeterinariosForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonVeterinariosForm.TabIndex = 13
        Me.BackButtonVeterinariosForm.Text = "Back"
        Me.BackButtonVeterinariosForm.UseVisualStyleBackColor = False
        '
        'NewVetButton
        '
        Me.NewVetButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NewVetButton.Location = New System.Drawing.Point(535, 111)
        Me.NewVetButton.Name = "NewVetButton"
        Me.NewVetButton.Size = New System.Drawing.Size(204, 54)
        Me.NewVetButton.TabIndex = 14
        Me.NewVetButton.Text = "Novo Veterinário"
        Me.NewVetButton.UseVisualStyleBackColor = False
        '
        'VetsDataGridView
        '
        Me.VetsDataGridView.AllowUserToAddRows = False
        Me.VetsDataGridView.AllowUserToDeleteRows = False
        Me.VetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VetsDataGridView.Location = New System.Drawing.Point(47, 79)
        Me.VetsDataGridView.MultiSelect = False
        Me.VetsDataGridView.Name = "VetsDataGridView"
        Me.VetsDataGridView.ReadOnly = True
        Me.VetsDataGridView.RowHeadersWidth = 51
        Me.VetsDataGridView.RowTemplate.Height = 29
        Me.VetsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VetsDataGridView.Size = New System.Drawing.Size(400, 300)
        Me.VetsDataGridView.TabIndex = 15
        '
        'EditVetButton
        '
        Me.EditVetButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.EditVetButton.Location = New System.Drawing.Point(535, 206)
        Me.EditVetButton.Name = "EditVetButton"
        Me.EditVetButton.Size = New System.Drawing.Size(204, 54)
        Me.EditVetButton.TabIndex = 16
        Me.EditVetButton.Text = "Editar Veterinário"
        Me.EditVetButton.UseVisualStyleBackColor = False
        '
        'DeleteVetButton
        '
        Me.DeleteVetButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.DeleteVetButton.Location = New System.Drawing.Point(535, 306)
        Me.DeleteVetButton.Name = "DeleteVetButton"
        Me.DeleteVetButton.Size = New System.Drawing.Size(204, 54)
        Me.DeleteVetButton.TabIndex = 17
        Me.DeleteVetButton.Text = "Eliminar Veterinário"
        Me.DeleteVetButton.UseVisualStyleBackColor = False
        '
        'Veterinarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DeleteVetButton)
        Me.Controls.Add(Me.EditVetButton)
        Me.Controls.Add(Me.VetsDataGridView)
        Me.Controls.Add(Me.NewVetButton)
        Me.Controls.Add(Me.BackButtonVeterinariosForm)
        Me.Name = "Veterinarios"
        Me.Text = "Veterinarios"
        CType(Me.VetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonVeterinariosForm As Button
    Friend WithEvents NewVetButton As Button
    Friend WithEvents VetsDataGridView As DataGridView
    Friend WithEvents EditVetButton As Button
    Friend WithEvents DeleteVetButton As Button
End Class
