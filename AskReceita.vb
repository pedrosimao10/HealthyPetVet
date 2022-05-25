Public Class AskReceita
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Receita.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Episodios.Show()
    End Sub

    Private Sub AskReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class