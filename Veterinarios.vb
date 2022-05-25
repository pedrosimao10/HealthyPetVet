Imports System.Data.SqlClient
Public Class Veterinarios
    Private Sub BackButtonVeterinariosForm_Click(sender As Object, e As EventArgs) Handles BackButtonVeterinariosForm.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub NewVetButton_Click(sender As Object, e As EventArgs) Handles NewVetButton.Click
        Me.Close()
        AddVet.Show()
    End Sub

    Private Sub Veterinarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VetsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.VETERINARIO")
    End Sub

    Private Function LoadData(data As String) As DataTable
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim dataToShow As New DataTable
        CN = New SqlConnection("Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p6g4; Persist Security Info=True;User ID=p6g4;password = Rafael.2001")
        CMD = New SqlCommand()
        CMD.Connection = CN
        CMD.CommandText = data
        CN.Open()
        Dim sda As New SqlDataAdapter(CMD)
        sda.Fill(dataToShow)
        Return dataToShow
    End Function

    Private Sub DeleteVetButton_Click(sender As Object, e As EventArgs) Handles DeleteVetButton.Click
        Dim nif As String
        Dim querry As String
        nif = VetsDataGridView.SelectedCells.Item(1).Value.ToString()
        Dim inserido As Boolean
        querry = "EXEC HEALTHYPETVET.p_deleteVet @nif=" + nif
        inserido = DeleteData(querry)
        If (inserido = 0) Then
            MessageBox.Show("Erro ao eliminar Veterinário.")
        Else
            MessageBox.Show("Eliminado com sucesso")
        End If
        VetsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.VETERINARIO")
    End Sub

    Private Function DeleteData(data As String) As Boolean
        Dim CN As SqlConnection
        Dim CMD As SqlCommand
        Dim removido As Boolean
        removido = False
        CN = New SqlConnection("Data Source=tcp:mednat.ieeta.pt\SQLSERVER,8101;Initial Catalog=p6g4; Persist Security Info=True;User ID=p6g4;password = Rafael.2001")
        CMD = New SqlCommand()
        CMD.Connection = CN
        CMD.CommandText = data
        CN.Open()
        Try
            Dim returned As Boolean = CMD.ExecuteNonQuery()
            If (returned = 0) Then
                removido = False
            Else
                removido = True
            End If
        Catch ex As Exception
            Throw New Exception("Falha ao eliminar Veterinário da Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return removido
    End Function

    Private Sub EditVetButton_Click(sender As Object, e As EventArgs) Handles EditVetButton.Click
        Me.Close()
        EditVet.Show()
    End Sub
End Class