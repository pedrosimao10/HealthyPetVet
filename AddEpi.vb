Imports System.Data.SqlClient
Public Class AddEpi
    Private Sub BackButtonForm2_Click(sender As Object, e As EventArgs) Handles BackButtonForm2.Click
        Me.Close()
        Episodios.Show()
    End Sub

    Private Sub GenerateEventButton_Click(sender As Object, e As EventArgs) Handles GenerateEventButton.Click
        If ((TextBoxNDocAni.Text.Equals("")) Or (TextBoxNLicencaVet.Text.Equals("")) Or (TextBoxHora.Text.Equals("00:00"))) Then
            MessageBox.Show("Introduza todos os campos com informações corretas")
        ElseIf (ConsultaRadioButton.Checked) Then
            Dim querry As String
            Dim inserido As Boolean
            querry = "EXEC HEALTHYPETVET.p_insertEpi @hora='" + TextBoxHora.Text + "',@DataEpi={d'" + DateTimePicker1.Text + "'},@NDocAni='" + TextBoxNDocAni.Text + "' ,@NLicencaVet='" + TextBoxNLicencaVet.Text + "', @opcao='" + ConsultaRadioButton.Text + "'"
            inserido = InsertData(querry)
            If (inserido = 0) Then
                MessageBox.Show("Erro ao adicionar Episódio. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Episódios")
            Else
                MessageBox.Show("Adicionado com sucesso")
            End If
            Me.Close()
            AskReceita.Show()
        ElseIf (CirurgiaRadioButton.Checked) Or (InternamentoRadioButton.Checked) Or (ExameRadioButton.Checked) Then
            Dim opcao As String
            opcao = ""
            If (CirurgiaRadioButton.Checked) Then
                opcao = CirurgiaRadioButton.Text
            ElseIf (InternamentoRadioButton.Checked) Then
                opcao = InternamentoRadioButton.Text
            ElseIf (ExameRadioButton.Checked) Then
                opcao = ExameRadioButton.Text
            End If
            Dim querry As String
            Dim inserido As Boolean
            querry = "EXEC HEALTHYPETVET.p_insertEpi @hora='" + TextBoxHora.Text + "',@DataEpi={d'" + DateTimePicker1.Text + "'},@NDocAni='" + TextBoxNDocAni.Text + "' ,@NLicencaVet='" + TextBoxNLicencaVet.Text + "', @opcao='" + opcao + "'"
            inserido = InsertData(querry)
            If (inserido = 0) Then
                MessageBox.Show("Erro ao adicionar Episódio. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Episódios")
            Else
                MessageBox.Show("Adicionado com sucesso")
            End If
            Me.Close()
            AskFatura.Show()
        End If
    End Sub

    Private Function InsertData(data As String) As Boolean
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim inserido As Boolean
        inserido = False
        CN = New SqlConnection("Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p6g4; Persist Security Info=True;User ID=p6g4;password = Rafael.2001")
        CMD = New SqlCommand()
        CMD.Connection = CN
        CMD.CommandText = data
        CN.Open()
        Try
            Dim returned As Boolean = CMD.ExecuteNonQuery()
            If (returned = 0) Then
                inserido = False
            Else
                inserido = True
            End If
        Catch ex As Exception
            Throw New Exception("Falha ao adicionar Episódio à Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return inserido
    End Function

    Private Sub AddEpi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class