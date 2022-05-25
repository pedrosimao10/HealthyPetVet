Public Class AddFatura
    Private Sub GenerateFaturaButton_Click(sender As Object, e As EventArgs) Handles GenerateFaturaButton.Click
        Fatura.FaturasDataGridView.Rows.Add(TextBoxNIFCliente.Text, TextBoxPreco.Text)
        Me.Close()
        Fatura.Show()
    End Sub

    Private Sub AddFatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class