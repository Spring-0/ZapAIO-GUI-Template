Imports Newtonsoft.Json
Imports System.IO

Public Class Deleted
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Home.tasksDataGridView.DataSource = Nothing

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "taskGroups.json")
        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        Dim taskGroups As List(Of TaskGroupModel) = New List(Of TaskGroupModel)()

        If Not String.IsNullOrEmpty(fileContents) Then
            Try
                taskGroups = JsonConvert.DeserializeObject(Of List(Of TaskGroupModel))(fileContents)
            Catch ex As Exception
                MessageBox.Show("Error deserializing JSON data: " & ex.Message)
                Return
            End Try
        End If

        Dim groupToDelete As TaskGroupModel = taskGroups.Find(Function(g) g.taskGroupName = Home.selectedTaskGroup.Text)

        If groupToDelete IsNot Nothing Then
            taskGroups.Remove(groupToDelete)
            Dim updatedJsonData As String = JsonConvert.SerializeObject(taskGroups)
            File.WriteAllText(filePath, updatedJsonData)
        Else
            MsgBox("Something weird happened?!")
        End If

        Home.taskGroupsFlow.Controls.Remove(Home.selectedTaskGroup)

        Close()
    End Sub
End Class