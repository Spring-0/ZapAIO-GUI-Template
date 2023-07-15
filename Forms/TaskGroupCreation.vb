Imports Guna.UI2.WinForms
Imports Newtonsoft.Json
Imports System.IO

Public Class TaskGroupCreation
    Private Property counter As Integer = 0
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click


        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "taskGroups.json")
        If Not File.Exists(filePath) Then
            Dim fileStream As System.IO.FileStream = System.IO.File.Create(filePath)
            fileStream.Close()
        End If

        If taskGroupTbx.Text = "" Then
            MessageBox.Show("Task group name cannot be empty.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

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

        For Each tg In taskGroups
            If taskGroupTbx.Text = tg.taskGroupName Then
                MessageBox.Show("Cannot have duplicated Task Group Names.", "Duplicated Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next


        Dim taskGroup As New TaskGroupModel() With {
                .taskGroupName = taskGroupTbx.Text.Trim()
        }

        taskGroups.Add(taskGroup)
        Dim jsonSettings As New JsonSerializerSettings With {
                .Formatting = Formatting.Indented
            }
        Dim json As String = JsonConvert.SerializeObject(taskGroups, jsonSettings)
        File.WriteAllText(filePath, json)

        Dim taskGroupBtn = New Guna2Button With {
            .FillColor = Color.FromArgb(42, 44, 64),
            .ForeColor = Color.White,
            .CustomBorderThickness = New Padding(1, 1, 1, 1),
            .CustomBorderColor = Color.FromArgb(42, 44, 64),
            .Width = 180,
            .Height = 100,
            .Text = taskGroupTbx.Text.Trim(),
            .Location = New Point(counter)
        }

        AddHandler taskGroupBtn.Click, AddressOf Home.taskGroupBtn_Click
        Home.taskGroupsFlow.Controls.Add(taskGroupBtn)
        Me.Close()
        ' taskGroupBtn.CustomBorderColor = Color.Yellow
        taskGroupBtn.PerformClick()
        Home.taskViewPnl.Visible = True

    End Sub
End Class