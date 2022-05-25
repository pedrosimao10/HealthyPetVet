﻿Imports System.Data.SqlClient
Public Class AddVet
    Private Sub BackButtonAddVetForm_Click(sender As Object, e As EventArgs) Handles BackButtonAddVetForm.Click
        Me.Close()
        Veterinarios.Show()
    End Sub

    Private Sub GenerateVetButton_Click(sender As Object, e As EventArgs) Handles GenerateVetButton.Click
        If (TextBoxName.Text = "") Or (TextBoxContact.Text = "") Or (TextBoxNIF.Text = "") Then
            MessageBox.Show("Preencha todos os campos com informações válidas")
        Else
            Dim querry As String
            Dim inserido As Boolean
            querry = "EXEC HEALTHYPETVET.p_insertVet @nome='" + TextBoxName.Text + "',@nif=" + TextBoxNIF.Text + ",@contacto=" + TextBoxContact.Text + ",@dataNasc={d'" + DateTimePicker1.Text + "'}"
            inserido = InsertData(querry)
            If (inserido = 0) Then
                MessageBox.Show("Erro ao adicionar Veterinário. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Veterinários")
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
            Throw New Exception("Falha ao adicionar Veterinário à Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return inserido
    End Function

    Private Sub AddVet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class