<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receitas
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
        Me.BackButtonAddEnfForm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReceitasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ReceitasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackButtonAddEnfForm
        '
        Me.BackButtonAddEnfForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonAddEnfForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonAddEnfForm.Name = "BackButtonAddEnfForm"
        Me.BackButtonAddEnfForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonAddEnfForm.TabIndex = 37
        Me.BackButtonAddEnfForm.Text = "Back"
        Me.BackButtonAddEnfForm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(577, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 29)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Adicionar nova receita"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReceitasDataGridView
        '
        Me.ReceitasDataGridView.AllowUserToAddRows = False
        Me.ReceitasDataGridView.AllowUserToDeleteRows = False
        Me.ReceitasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ReceitasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReceitasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.ReceitasDataGridView.Location = New System.Drawing.Point(167, 76)
        Me.ReceitasDataGridView.Name = "ReceitasDataGridView"
        Me.ReceitasDataGridView.ReadOnly = True
        Me.ReceitasDataGridView.RowHeadersWidth = 51
        Me.ReceitasDataGridView.RowTemplate.Height = 29
        Me.ReceitasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ReceitasDataGridView.Size = New System.Drawing.Size(508, 300)
        Me.ReceitasDataGridView.TabIndex = 40
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nome do Medicamento"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Número de Registo do Medicamento"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço Total"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Receitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReceitasDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BackButtonAddEnfForm)
        Me.Name = "Receitas"
        Me.Text = "Receitas"
        CType(Me.ReceitasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackButtonAddEnfForm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Public WithEvents ReceitasDataGridView As DataGridView
End Class
