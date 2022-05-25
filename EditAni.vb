Imports System.Data.SqlClient

Public Class EditAni
    Private Sub BackButtonEditCliForm_Click(sender As Object, e As EventArgs) Handles BackButtonEditCliForm.Click
        Me.Close()
        Animais.Show()
    End Sub

    Private Sub EditAni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub AnimalsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnimalsDataGridView.CellContentClick
        Dim nome, sexo, raca, nif As String
        nome = AnimalsDataGridView.SelectedCells.Item(0).Value.ToString()
        sexo = AnimalsDataGridView.SelectedCells.Item(1).Value.ToString()
        raca = AnimalsDataGridView.SelectedCells.Item(2).Value.ToString()
        nif = AnimalsDataGridView.SelectedCells.Item(5).Value.ToString()
        TextBoxName.Text = nome
        CB_Sexo.SelectedItem = sexo
        CB_Raca.SelectedItem = raca
        TextBoxNIF.Text = nif
    End Sub

    Private Sub EditCliButton_Click(sender As Object, e As EventArgs) Handles EditCliButton.Click
        Dim nome, sexo, raca, nif, nDoc As String
        nome = AnimalsDataGridView.SelectedCells.Item(0).Value.ToString()
        sexo = AnimalsDataGridView.SelectedCells.Item(1).Value.ToString()
        raca = AnimalsDataGridView.SelectedCells.Item(2).Value.ToString()
        nDoc = AnimalsDataGridView.SelectedCells.Item(4).Value.ToString()
        nif = AnimalsDataGridView.SelectedCells.Item(5).Value.ToString()
        If (TextBoxName.Text.Equals(nome) And CB_Raca.SelectedItem.ToString.Equals(raca) And CB_Sexo.SelectedItem.ToString.Equals(sexo) And TextBoxNIF.Text.Equals(nif)) Then
            MessageBox.Show("Altere os campos com informações válidas")
        Else
            If (TextBoxName.Text = "") Or (TextBoxNIF.Text = "") Then
                MessageBox.Show("Preencha todos os campos com informações válidas")
            Else
                Dim querry As String
                Dim inserido As Boolean
                querry = "EXEC HEALTHYPETVET.p_editAni @nome='" + TextBoxName.Text + "',@sexo='" + CB_Sexo.SelectedItem.ToString + "',@raca='" + CB_Raca.SelectedItem.ToString + "' ,@nDoc= " + nDoc + ",@nif=" + TextBoxNIF.Text
                inserido = EditData(querry)
                If (inserido = 0) Then
                    MessageBox.Show("Erro ao editar Animal. Insira os dados corretamente. ATENÇÃO: verifique se os dados que introduziu já não estão na lista de Animais")
                Else
                    MessageBox.Show("Animal editado com sucesso")
                    AnimalsDataGridView.DataSource = LoadData("SELECT * FROM HEALTHYPETVET.ANIMAL")

                End If
            End If
        End If
    End Sub

    Private Function EditData(data As String) As Boolean
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
            Throw New Exception("Falha ao editar Animal da Base de Dados. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
        Return inserido
    End Function
End Class