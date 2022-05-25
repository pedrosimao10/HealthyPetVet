Imports System.Data.SqlClient

Public Class Receita

    Private Sub GenerateReceitaButton_Click(sender As Object, e As EventArgs) Handles GenerateReceitaButton.Click
        Receitas.ReceitasDataGridView.Rows.Add(TextBoxNomeMedicamento.Text, TextBoxNRegisto.Text, TextBoxPreco.Text)
        Me.Close()
        Receitas.Show()
    End Sub

    Private Sub Receita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class