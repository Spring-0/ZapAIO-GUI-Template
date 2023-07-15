Imports Guna.UI2.WinForms
Imports System.IO
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json

Public Class TaskCreation
    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "taskGroups.json")

        Dim taskModel As New TaskModel() With {
            .site = siteCombo.Text,
            .mode = modeCombo.Text,
            .monitorInput = monitorInputTbx.Text,
            .size = sizeCombo.Text,
            .profiles = profileCombo.Text,
            .proxies = proxyCombo.Text,
            .quantity = quantityTbx.Value
         }


        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        Dim taskGroups As List(Of TaskGroupModel) = JsonConvert.DeserializeObject(Of List(Of TaskGroupModel))(fileContents)

        'If Not String.IsNullOrEmpty(fileContents) Then
        '    Try

        '    Catch ex As Exception
        '        MessageBox.Show("Error deserializing JSON data: " & ex.Message)
        '        Return
        '    End Try
        'End If


        If checkForEmptyFields() Then
            MessageBox.Show("You must fill all values to create a task.", "Missing value(s)", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim groupToUpdate As TaskGroupModel = taskGroups.Find(Function(g) g.taskGroupName = taskGroupCombo.Text)

        If groupToUpdate IsNot Nothing Then
            groupToUpdate.taskModel = taskModel
            Dim updatedJsonData As String = JsonConvert.SerializeObject(taskGroups)
            File.WriteAllText(filePath, updatedJsonData)
        Else
            MsgBox("Something weird happened?!")
        End If
        Close()

    End Sub

    Private Function checkForEmptyFields() As Boolean
        Dim emptyFieldFound As Boolean = False
        For Each control As Control In Me.Controls
            If TypeOf control Is Guna2ComboBox OrElse
               TypeOf control Is Guna2TextBox OrElse
               TypeOf control Is Guna2NumericUpDown Then
                If String.IsNullOrWhiteSpace(control.Text) Then
                    emptyFieldFound = True
                    Exit For
                End If
            End If
        Next
        Return emptyFieldFound
    End Function


    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Close()
    End Sub

    Private Sub TaskCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadComboBoxData("proxyGroups.json", "proxyGroupName", proxyCombo)
        loadComboBoxData("profiles.json", "profileName", profileCombo)
        loadComboBoxData("taskGroups.json", "taskGroupName", taskGroupCombo)

    End Sub

    Private Sub loadComboBoxData(filePath As String, keyName As String, cb As Guna2ComboBox)
        Try

            Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
            Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
            filePath = System.IO.Path.Combine(zapAioFolderPath, filePath)

            Dim json As String = File.ReadAllText(filePath)
            Dim data As JArray = JArray.Parse(json)
            cb.Items.Clear()
            For Each d As JObject In data
                cb.Items.Add(d(keyName).ToString())
            Next
        Catch ex As Exception
            ' Nothing
        End Try

    End Sub

End Class