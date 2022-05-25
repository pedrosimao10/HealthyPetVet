Public Class Form1
    Private Sub VetButton_Click(sender As Object, e As EventArgs) Handles VetButton.Click
        Me.Hide()
        Veterinarios.Show()
    End Sub

    Private Sub EnfButton_Click(sender As Object, e As EventArgs) Handles EnfButton.Click
        Me.Hide()
        Enfermeiros.Show()
    End Sub

    Private Sub AnimalsButton_Click(sender As Object, e As EventArgs) Handles AnimalsButton.Click
        Me.Hide()
        Animais.Show()
    End Sub
    Private Sub EventsButton_Click(sender As Object, e As EventArgs) Handles EventsButton.Click
        Me.Hide()
        Episodios.Show()
    End Sub

    Private Sub ClientsButton_Click(sender As Object, e As EventArgs) Handles ClientsButton.Click
        Me.Hide()
        Clientes.Show()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Fatura.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ReceitasButton_Click(sender As Object, e As EventArgs) Handles ReceitasButton.Click
        Me.Hide()
        Receitas.Show()
    End Sub
End Class
