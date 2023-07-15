Imports Guna.UI2.WinForms
Imports Newtonsoft.Json
Imports System.IO

Public Class ProxyGroupnamePrompt

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "proxyGroups.json")
        If Not File.Exists(filePath) Then
            Dim fileStream As System.IO.FileStream = System.IO.File.Create(filePath)
            fileStream.Close()
        End If

        If proxyGroupNameTbx.Text = "" Then
            MessageBox.Show("Proxy group name cannot be empty.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        Dim proxyGroups As List(Of ProxyGroupModel) = New List(Of ProxyGroupModel)()
        If Not String.IsNullOrEmpty(fileContents) Then
            Try
                proxyGroups = JsonConvert.DeserializeObject(Of List(Of ProxyGroupModel))(fileContents)
            Catch ex As Exception
                MessageBox.Show("Error deserializing JSON data: " & ex.Message)
                Return
            End Try
        End If

        For Each prox In proxyGroups
            If proxyGroupNameTbx.Text = prox.proxyGroupName Then
                MessageBox.Show("Cannot have duplicated Proxy Group Names.", "Duplicated Name", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        Dim proxyGroup As New ProxyGroupModel() With {
                .proxyGroupName = proxyGroupNameTbx.Text,
                .proxies = New List(Of String)()
        }

        proxyGroups.Add(proxyGroup)
        Dim jsonSettings As New JsonSerializerSettings With {
                .Formatting = Formatting.Indented
            }
        Dim json As String = JsonConvert.SerializeObject(proxyGroups, jsonSettings)
        File.WriteAllText(filePath, json)

        Dim cppb As CreateProxyProfileButton = New CreateProxyProfileButton()
        cppb.cProfileBtn(proxyGroupNameTbx.Text, Home.proxiesListFlow, "proxyGroupBtnClick")

        Me.Close()

        'Dim proxyGroupBtn = New Guna2Button With {
        '    .FillColor = Color.FromArgb(42, 44, 64),
        '    .ForeColor = Color.White,
        '    .CustomBorderThickness = New Padding(1, 1, 1, 1),
        '    .CustomBorderColor = Color.FromArgb(42, 44, 64),
        '    .Width = 180,
        '    .Height = 100,
        '    .Text = proxyGroupNameTbx.Text,
        '    .Location = New Point(counter)
        '}

        'AddHandler proxyGroupBtn.Click, AddressOf Home.proxyGroupBtnClick
        'Home.proxyGroupPnl.Controls.Add(proxyGroupBtn)
        'MsgBox(proxyGroupBtn.Location.ToString)
        'Me.Close()
        'counter += 15 + 180
        'proxyGroupBtn.CustomBorderColor = Color.Yellow
        'proxyGroupBtn.PerformClick()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
End Class