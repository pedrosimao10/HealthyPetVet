<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAni
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
        Me.BackButtonAddCliForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNIF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GenerateCliButton = New System.Windows.Forms.Button()
        Me.CB_Sexo = New System.Windows.Forms.ComboBox()
        Me.CB_Raca = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BackButtonAddCliForm
        '
        Me.BackButtonAddCliForm.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackButtonAddCliForm.Location = New System.Drawing.Point(12, 12)
        Me.BackButtonAddCliForm.Name = "BackButtonAddCliForm"
        Me.BackButtonAddCliForm.Size = New System.Drawing.Size(94, 29)
        Me.BackButtonAddCliForm.TabIndex = 46
        Me.BackButtonAddCliForm.Text = "Back"
        Me.BackButtonAddCliForm.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(83, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Nome"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(83, 110)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxName.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(550, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 28)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Data de Nascimento"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(521, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(218, 27)
        Me.DateTimePicker1.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(83, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 28)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "NIF do Cliente"
        '
        'TextBoxNIF
        '
        Me.TextBoxNIF.Location = New System.Drawing.Point(83, 209)
        Me.TextBoxNIF.Name = "TextBoxNIF"
        Me.TextBoxNIF.Size = New System.Drawing.Size(218, 27)
        Me.TextBoxNIF.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(405, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 28)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(606, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 28)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Raça"
        '
        'GenerateCliButton
        '
        Me.GenerateCliButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateCliButton.Location = New System.Drawing.Point(197, 351)
        Me.GenerateCliButton.Name = "GenerateCliButton"
        Me.GenerateCliButton.Size = New System.Drawing.Size(413, 54)
        Me.GenerateCliButton.TabIndex = 55
        Me.GenerateCliButton.Text = "Adicionar novo Animal"
        Me.GenerateCliButton.UseVisualStyleBackColor = False
        '
        'CB_Sexo
        '
        Me.CB_Sexo.FormattingEnabled = True
        Me.CB_Sexo.Items.AddRange(New Object() {"M", "F"})
        Me.CB_Sexo.Location = New System.Drawing.Point(405, 208)
        Me.CB_Sexo.Name = "CB_Sexo"
        Me.CB_Sexo.Size = New System.Drawing.Size(151, 28)
        Me.CB_Sexo.TabIndex = 57
        '
        'CB_Raca
        '
        Me.CB_Raca.FormattingEnabled = True
        Me.CB_Raca.Items.AddRange(New Object() {"CAO", "GATO", "GECKO", "COELHO", "MACACO", "CAVALO", "VACA"})
        Me.CB_Raca.Location = New System.Drawing.Point(606, 208)
        Me.CB_Raca.Name = "CB_Raca"
        Me.CB_Raca.Size = New System.Drawing.Size(151, 28)
        Me.CB_Raca.TabIndex = 58
        '
        'AddAni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CB_Raca)
        Me.Controls.Add(Me.CB_Sexo)
        Me.Controls.Add(Me.GenerateCliButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxNIF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackButtonAddCliForm)
        Me.Name = "AddAni"
        Me.Text = "Adicionar Animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButtonAddCliForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNIF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GenerateCliButton As Button
    Friend WithEvents CB_Sexo As ComboBox
    Friend WithEvents CB_Raca As ComboBox
End Class
