Imports System.Data.SqlClient
Public Class Clientes
    Private Sub BackButtonVeterinariosForm_Click(sender As Object, e As EventArgs) Handles BackButtonClientsForm.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClientsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.CLIENTE")
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

    Private Sub NewClientButton_Click(sender As Object, e As EventArgs) Handles NewClientButton.Click
        Me.Close()
        AddCli.Show()
    End Sub

    Private Sub DeleteClientButton_Click(sender As Object, e As EventArgs) Handles DeleteClientButton.Click
        Dim nif As String
        Dim querry As String
        nif = ClientsDataGridView.SelectedCells.Item(1).Value.ToString()
        Dim inserido As Boolean
        querry = "EXEC HEALTHYPETVET.p_deleteCli @nif=" + nif
        inserido = DeleteData(querry)
        If (inserido = 0) Then
            MessageBox.Show("Erro ao eliminar Cliente.")
        Else
            MessageBox.Show("Eliminado com sucesso")
        End If
        ClientsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.CLIENTE")
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
            Throw New Exception("Falha ao eliminar Cliente da Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return removido
    End Function

    Private Sub EditClientButton_Click(sender As Object, e As EventArgs) Handles EditClientButton.Click
        Me.Close()
        EditCli.Show()
    End Sub
End Class