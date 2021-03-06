Imports System.Data.SqlClient
Public Class AddEnf
    Private Sub BackButtonAddVetForm_Click(sender As Object, e As EventArgs) Handles BackButtonAddEnfForm.Click
        Me.Close()
        Enfermeiros.Show()
    End Sub

    Private Sub GenerateEnfButton_Click(sender As Object, e As EventArgs) Handles GenerateEnfButton.Click
        If (TextBoxName.Text = "") Or (TextBoxContact.Text = "") Or (TextBoxNIF.Text = "") Then
            MessageBox.Show("Preencha todos os campos com informações válidas")
        Else
            Dim querry As String
            Dim inserido As Boolean
            querry = "EXEC HEALTHYPETVET.p_insertEnf @nome='" + TextBoxName.Text + "',@nif=" + TextBoxNIF.Text + ",@contacto=" + TextBoxContact.Text + ",@dataNasc={d'" + DateTimePicker1.Text + "'}"
            inserido = InsertData(querry)
            If (inserido = 0) Then
                MessageBox.Show("Erro ao adicionar Enfermeiro. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Enfermeiros")
            Else
                MessageBox.Show("Adicionado com sucesso")
            End If
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
            Throw New Exception("Falha ao adicionar Enfermeiro à Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return inserido
    End Function
End Class