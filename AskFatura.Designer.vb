<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AskFatura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSimFatura = New System.Windows.Forms.Button()
        Me.ButtonNãoFatura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pretende fatura?"
        '
        'ButtonSimFatura
        '
        Me.ButtonSimFatura.Location = New System.Drawing.Point(61, 142)
        Me.ButtonSimFatura.Name = "ButtonSimFatura"
        Me.ButtonSimFatura.Size = New System.Drawing.Size(128, 51)
        Me.ButtonSimFatura.TabIndex = 6
        Me.ButtonSimFatura.Text = "Sim"
        Me.ButtonSimFatura.UseVisualStyleBackColor = True
        '
        'ButtonNãoFatura
        '
        Me.ButtonNãoFatura.Location = New System.Drawing.Point(310, 142)
        Me.ButtonNãoFatura.Name = "ButtonNãoFatura"
        Me.ButtonNãoFatura.Size = New System.Drawing.Size(128, 51)
        Me.ButtonNãoFatura.TabIndex = 7
        Me.ButtonNãoFatura.Text = "Não"
        Me.ButtonNãoFatura.UseVisualStyleBackColor = True
        '
        'AskFatura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 265)
        Me.Controls.Add(Me.ButtonNãoFatura)
        Me.Controls.Add(Me.ButtonSimFatura)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AskFatura"
        Me.Text = "AskFatura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSimFatura As Button
    Friend WithEvents ButtonNãoFatura As Button
End Class
