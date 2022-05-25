Public Class AskFatura
    Private Sub ButtonSimFatura_Click(sender As Object, e As EventArgs) Handles ButtonSimFatura.Click
        Me.Close()
        AddFatura.Show()
    End Sub

    Private Sub ButtonNãoFatura_Click(sender As Object, e As EventArgs) Handles ButtonNãoFatura.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class