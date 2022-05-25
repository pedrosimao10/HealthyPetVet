Imports System.Data.SqlClient
Public Class Animais
    Private Sub BackButtonAnimaisForm_Click(sender As Object, e As EventArgs) Handles BackButtonAnimaisForm.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Animais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AnimalsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.ANIMAL")
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

    Private Sub NewAnimalButton_Click(sender As Object, e As EventArgs) Handles NewAnimalButton.Click
        AddAni.Show()
        Me.Close()

    End Sub

    Private Sub EditAnimalButton_Click(sender As Object, e As EventArgs) Handles EditAnimalButton.Click
        EditAni.Show()
        Me.Close()

    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        If (ComboBoxRaca.Text.Equals("Raça") And ComboBoxSexo.Text.Equals("Sexo")) Then
            MessageBox.Show("Altere os valores dos filtros")
        ElseIf (Not ComboBoxRaca.Text.Equals("Raça") And ComboBoxSexo.Text.Equals("Sexo")) Then
            AnimalsDataGridView.DataSource = LoadData("SELECT * FROM dbo.getAnimaisPorRaca('" + ComboBoxRaca.SelectedItem.ToString() + "')")
        ElseIf (ComboBoxRaca.Text.Equals("Raça") And Not ComboBoxSexo.Text.Equals("Sexo")) Then
            AnimalsDataGridView.DataSource = LoadData("SELECT * FROM dbo.getAnimaisPorSexo('" + ComboBoxSexo.SelectedItem.ToString() + "')")
        Else
            AnimalsDataGridView.DataSource = LoadData("SELECT * FROM dbo.getAnimaisPorSexoRaca('" + ComboBoxRaca.SelectedItem.ToString() + "','" + ComboBoxSexo.SelectedItem.ToString() + "')")
        End If
    End Sub

    Private Sub ButtonLimpar_Click(sender As Object, e As EventArgs) Handles ButtonLimpar.Click
        AnimalsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.ANIMAL")
        ComboBoxRaca.Text = "Raça"
        ComboBoxSexo.Text = "Sexo"
    End Sub

    Private Sub DeleteAnimalButton_Click(sender As Object, e As EventArgs) Handles DeleteAnimalButton.Click
        Dim NDocumento As String
        Dim querry As String
        NDocumento = AnimalsDataGridView.SelectedCells.Item(4).Value.ToString()
        Dim inserido As Boolean
        querry = "EXEC HEALTHYPETVET.p_deleteAni @NDocumento='" + NDocumento + "'"
        inserido = DeleteData(querry)
        If (inserido = 0) Then
            MessageBox.Show("Erro ao eliminar Episódio.")
        Else
            MessageBox.Show("Eliminado com sucesso")
        End If
        AnimalsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.ANIMAL")
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
            Throw New Exception("Falha ao eliminar Episódio da Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return removido
    End Function
End Class