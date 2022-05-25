<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.DeleteClientButton = New System.Windows.Forms.Button()
        Me.EditClientButton = New System.Windows.Forms.Button()
        Me.ClientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.NewClientButton = New System.Windows.Forms.Button()
        Me.BackButtonClientsForm = New System.Windows.Forms.Button()
        CType(Me.ClientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeleteClientButton
        '
        Me.DeleteClientButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.DeleteClientButton.Location = New System.Drawing.Point(535, 306)
        Me.DeleteClientButton.Name = "DeleteClientButton"
        Me.DeleteClientButton.Size = New System.Drawing.Size(204, 54)
        Me.DeleteClientButton.TabIndex = 22
        Me.DeleteClientButton.Text = "Eliminar Cliente"
        Me.DeleteClientButton.UseVisualStyleBackColor = False
        '
        'EditClientButton
        '
        Me.EditClientButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.EditClientButton.Location = New System.Drawing.Point(535, 206)
        Me.EditClientButton.Name = "EditClientButton"
        Me.EditClientButton.Size = New System.Drawing.Size(204, 54)
        Me.EditClientButton.TabIndex = 21
        Me.EditClientButton.Text = "Editar Cliente"
        Me.EditClientButton.UseVisualStyleBackColor = False
        '
        'ClientsDataGridView
        '
        Me.ClientsDataGridView.AllowUserToAddRows = False
        Me.ClientsDataGridView.AllowUserToDeleteRows = False
        Me.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientsDataGridView.Location = New System.Drawing.Point(47, 79)
        Me.ClientsDataGridView.MultiSelect = False
        Me.ClientsDataGridView.Name = "ClientsDataGridView"
        Me.ClientsDataGridView.ReadOnly = True
        Me.ClientsDataGridView.RowHeadersWidth = 51
        Me.ClientsDataGridView.RowTemplate.Height = 29
        Me.ClientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientsDataGridView.Size = New System.Drawing.Size(400, 300)
        Me.ClientsDataGridView.TabIndex = 20
        '
        'NewClientButton
        '
        Me.NewClientButton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.NewClientButton.Location = New System.Drawing.Point(535, 111)
        Me.NewClientButton.Name = "NewClientButton"
        Me.NewClientButton.Size = New System.Drawing.Size(204, 54)
        Me.NewClientButton.TabIndex = 19
        Me.NewClientButton.Text = "Novo Cliente"
        Me.NewClientButton.UseVisualStyleBackColor = False
        '
        'BackButtonClientsForm
        '
        Me.BackButtonClientsForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonClientsForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonClientsForm.Name = "BackButtonClientsForm"
        Me.BackButtonClientsForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonClientsForm.TabIndex = 18
        Me.BackButtonClientsForm.Text = "Back"
        Me.BackButtonClientsForm.UseVisualStyleBackColor = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DeleteClientButton)
        Me.Controls.Add(Me.EditClientButton)
        Me.Controls.Add(Me.ClientsDataGridView)
        Me.Controls.Add(Me.NewClientButton)
        Me.Controls.Add(Me.BackButtonClientsForm)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.ClientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeleteClientButton As Button
    Friend WithEvents EditClientButton As Button
    Friend WithEvents ClientsDataGridView As DataGridView
    Friend WithEvents NewClientButton As Button
    Friend WithEvents BackButtonClientsForm As Button
End Class
