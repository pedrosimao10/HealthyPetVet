Public Class Receitas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Receita.Show()
    End Sub

    Private Sub Receitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackButtonAddEnfForm_Click(sender As Object, e As EventArgs) Handles BackButtonAddEnfForm.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class