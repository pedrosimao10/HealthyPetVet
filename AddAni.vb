Imports System.Data.SqlClient
Public Class AddAni

    Private Sub AddAni_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BackButtonAddCliForm_Click(sender As Object, e As EventArgs) Handles BackButtonAddCliForm.Click
        Me.Close()
        Animais.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBoxName_TextChanged(sender As Object, e As EventArgs) Handles TextBoxName.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub GenerateCliButton_Click(sender As Object, e As EventArgs) Handles GenerateCliButton.Click
        If (TextBoxName.Text = "") Or (TextBoxNIF.Text = "") Then
            MessageBox.Show("Preencha todos os campos com informações válidas")
        Else
            Dim querry As String
            Dim inserido As Boolean
            querry = "EXEC HEALTHYPETVET.p_insertAni @nome='" + TextBoxName.Text + "',@sexo='" + CB_Sexo.SelectedItem.ToString + "',@raca='" + CB_Raca.SelectedItem.ToString + "',@dataNasc={d'" + DateTimePicker1.Text + "'},@nif='" + TextBoxNIF.Text + "'"
            inserido = InsertData(querry)
            If (inserido = 0) Then
                MessageBox.Show("Erro ao adicionar Animal. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Animais")
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
            Throw New Exception("Falha ao adicionar Animal à Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return inserido
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Sexo.SelectedIndexChanged

    End Sub
End Class