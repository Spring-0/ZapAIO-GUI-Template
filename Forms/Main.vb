Public Class Main

    Private _CurrentTaskPanelName As String = Nothing
    Private _TaskPanelsAddedCount As Integer = 0

    Private Sub profilesSavebtn_Click(sender As Object, e As EventArgs)


    End Sub

    Sub switchPanel(ByVal panel As Form)
        mainSwapPnl.Controls.Clear()
        panel.TopLevel = False
        Debug.Print("")
        mainSwapPnl.Controls.Add(panel)
        panel.Location = New Point(0, 0)
        panel.Size = New Size(1108, 718)
        panel.Show()
    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        helpBtn.ForeColor = Color.DimGray
        settingsBtn.ForeColor = Color.DimGray
        switchPanel(Home)
        homeBtn.ForeColor = Color.White
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        homeBtn.ForeColor = Color.DimGray
        helpBtn.ForeColor = Color.DimGray
        switchPanel(Settings)
        settingsBtn.ForeColor = Color.White
    End Sub

    'Public Sub CreateTaskPanel()

    '    Dim taskPanel As Panel
    '    taskPanel = New Panel()

    '    With taskPanel
    '        .BackColor = Color.White
    '        .Size = New Size(920, 50)
    '        .Name = "pnlTask" + (_TaskPanelsAddedCount + 1).ToString
    '    End With

    '    flpTasks.Controls.Add(taskPanel)

    '    _CurrentTaskPanelName = taskPanel.Name
    '    _TaskPanelsAddedCount += 1

    'End Sub

    'Public Sub CreateTaskNameLabel(ByVal panelName As String, ByVal textToShow As String)
    '    Dim taskNameLabel As Label
    '    taskNameLabel = New Label

    '    With taskNameLabel
    '        .AutoSize = True
    '        .Location = New Point(10, 10)
    '        .Name = "lblTaskName" + _TaskPanelsAddedCount.ToString
    '        .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
    '        .ForeColor = Color.Black
    '        .Text = textToShow
    '    End With

    '    For Each controlObject As Control In flpTasks.Controls
    '        If controlObject.Name = panelName Then
    '            controlObject.Controls.Add(taskNameLabel)
    '        End If
    '    Next

    'End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Home)
    End Sub

    Private Sub helpBtn_Click(sender As Object, e As EventArgs) Handles helpBtn.Click
        homeBtn.ForeColor = Color.DimGray
        settingsBtn.ForeColor = Color.DimGray
        ' switchPanel(help)
        helpBtn.ForeColor = Color.White
    End Sub

    'Sub positionAllPanels()
    '    settingsPnl.Location = New Point(23, 114)
    '    settingsPnl.Size = New Size(1015, 677)

    '    proxiespnl.Location = New Point(12, 187)
    '    proxiespnl.Size = New Point(1023, 614)

    '    profilespnl.Location = New Point(12, 187)
    '    profilespnl.Size = New Point(1023, 614)

    '    tasksPnl.Location = New Point(12, 187)
    '    tasksPnl.Size = New Point(1010, 601)

    '    pnlViewTasks.Location = New Point(12, 187)
    '    pnlViewTasks.Size = New Point(1010, 601)

    '    profilestbx.Location = New Point(427, 61)
    '    profilestbx.Size = New Point(580, 541)

    '    proxiesSavetbx.Location = New Point(profilesSaveTbx.Location.X, profilesSaveTbx.Location.Y)
    '    proxyLbl.Location = New Point(profilesLbl.Location.X, profilesLbl.Location.Y)

    '    proxySavebtn.Location = New Point(profilesSavebtn.Location.X, profilesSavebtn.Location.Y)
    '    proxyLoadbtn.Location = New Point(profilesLoadbtn.Location.X, profilesLoadbtn.Location.Y)

    '    delGroupProxies.Location = New Point(delGroupProfiles.Location.X, delGroupProfiles.Location.Y)
    '    delGroupProxiesbtn.Location = New Point(delGroupProfilesbtn.Location.X, delGroupProfilesbtn.Location.Y)


    'End Sub


    'Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs)

    'End Sub

    'Sub readGroups()
    '    Dim fileReader As String

    '    Try
    '        fileReader = My.Computer.FileSystem.ReadAllText("proxies.txt")
    '        cbxProxies.Items.Clear()
    '        delGroupProxies.Items.Clear()
    '        For Each i In fileReader.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
    '            cbxProxies.Items.Add(i)
    '            delGroupProxies.Items.Add(i)
    '        Next
    '    Catch ex As System.IO.FileNotFoundException
    '        MsgBox("Proxies.txt could not be found")
    '    End Try


    '    Dim fileReader2 As String
    '    Try
    '        fileReader2 = My.Computer.FileSystem.ReadAllText("profiles.txt")
    '        cbxProfile.Items.Clear()
    '        delGroupProfiles.Items.Clear()
    '        For Each i In fileReader2.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
    '            cbxProfile.Items.Add(i)
    '            delGroupProfiles.Items.Add(i)
    '        Next
    '    Catch ex As System.IO.FileNotFoundException
    '        MsgBox("Profiles.txt could not be found")
    '    End Try



    'End Sub


    'Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
    '    readGroups()
    '    resetButtonColors()
    '    hideAllPanels()
    '    tasksPnl.Visible = True

    '    Guna2Separator1.Location = New Point(Guna2Button5.Location.X, Guna2Separator1.Location.Y)
    '    Guna2Button5.ForeColor = Color.White
    'End Sub

    'Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
    '    resetButtonColors()
    '    hideAllPanels()
    '    ' Panel elements visibility
    '    overviewToggleON()

    '    ' Move button seperator
    '    Guna2Separator1.Location = New Point(Guna2Button4.Location.X, Guna2Separator1.Location.Y)

    '    ' Change Button colors
    '    Guna2Button4.ForeColor = Color.White
    'End Sub

    'Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
    '    readGroups()
    '    resetButtonColors()
    '    hideAllPanels()
    '    profilespnl.Visible = True

    '    Guna2Separator1.Location = New Point(Guna2Button6.Location.X, Guna2Separator1.Location.Y)

    '    Guna2Button6.ForeColor = Color.White
    'End Sub

    'Sub overviewToggleOFF()
    '    pn_overview.Visible = False
    '    pn_city.Visible = False
    '    pn_earn.Visible = False
    '    Label1.Visible = False
    '    Guna2Panel2.Visible = False
    '    Guna2Panel3.Visible = False
    'End Sub

    'Sub overviewToggleON()
    '    pn_overview.Visible = True
    '    pn_city.Visible = True
    '    pn_earn.Visible = True
    '    Label1.Visible = True
    '    Guna2Panel2.Visible = True
    '    Guna2Panel3.Visible = True
    'End Sub


    'Sub resetButtonColors()
    '    Guna2Button4.ForeColor = Color.DimGray
    '    Guna2Button5.ForeColor = Color.DimGray
    '    Guna2Button6.ForeColor = Color.DimGray
    '    Guna2Button7.ForeColor = Color.DimGray
    'End Sub

    'Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
    '    Application.ExitThread()
    'End Sub

    'Private Sub Guna2Button11_Click(sender As Object, e As EventArgs)
    '    Dim result As DialogResult = OpenFileDialog1.ShowDialog()

    '    If result = Windows.Forms.DialogResult.OK Then
    '        profilestbx.Text = System.IO.File.ReadAllText(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
    '    End If
    '    MsgBox("Successfully Loaded Profiles")
    'End Sub

    'Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
    '    readGroups()
    '    hideAllPanels()
    '    resetButtonColors()

    '    Guna2Separator1.Location = New Point(Guna2Button7.Location.X, Guna2Separator1.Location.Y)
    '    Guna2Button7.ForeColor = Color.White



    '    proxiespnl.Visible = True
    'End Sub

    'Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
    '    Dim result As DialogResult = OpenFileDialog1.ShowDialog()

    '    If result = Windows.Forms.DialogResult.OK Then
    '        proxiestbx.Text = System.IO.File.ReadAllText(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
    '    End If
    '    MsgBox("Successfully Loaded Proxies")
    'End Sub

    'Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
    '    hideAllPanels()
    '    Guna2Button1.ForeColor = Color.DimGray
    '    Guna2Button2.ForeColor = Color.White
    '    Guna2Button3.ForeColor = Color.DimGray


    '    settingsPnl.Visible = True
    'End Sub

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
    '    hideAllPanels()
    '    Guna2Button1.ForeColor = Color.White
    '    Guna2Button2.ForeColor = Color.DimGray
    '    Guna2Button3.ForeColor = Color.DimGray

    '    resetButtonColors()
    '    Guna2Separator1.Location = New Point(Guna2Button4.Location.X, Guna2Separator1.Location.Y)
    '    Guna2Button4.ForeColor = Color.White

    '    overviewToggleON()
    'End Sub



    'Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs)
    '    Dim dcWeb As dWebHook = New dWebHook
    '    dcWeb.WebHook = tbxWebhook.Text
    '    dcWeb.SendMessage("ZapAIO Webhook Test")

    'End Sub

    'Private Sub Label9_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub tasksPnl_Paint(sender As Object, e As PaintEventArgs)

    'End Sub

    'Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs)

    '    Dim validTbx As Boolean
    '    Dim validCbx As Boolean

    '    For Each tb As Guna2TextBox In tasksPnl.Controls.OfType(Of Guna2TextBox)()
    '        If tb.Text = String.Empty Then
    '            validTbx = False
    '            Exit For
    '        Else
    '            validTbx = True
    '            Exit For
    '        End If
    '    Next

    '    For Each cbx As Guna2ComboBox In tasksPnl.Controls.OfType(Of Guna2ComboBox)()
    '        If cbx.Text = String.Empty Then
    '            validCbx = False
    '            Exit For
    '        Else
    '            validCbx = True
    '            Exit For
    '        End If
    '    Next

    '    If validCbx = True And validTbx = True Then
    '        schedLbl.Text += 1
    '        CreateTaskPanel()
    '        CreateTaskNameLabel(_CurrentTaskPanelName, tbxProduct.Text)
    '    Else
    '        MsgBox("Failed to create task. Please fill out all the values.")
    '    End If


    'End Sub

    'Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)
    '    MsgBox("Successfully Saved Settings", vbInformation)
    'End Sub

    'Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs)
    '    If proxiesSavetbx.Text = String.Empty Then
    '        MsgBox("You must enter a name for the Proxy Group", vbCritical)
    '    Else
    '        MsgBox("Successfully Saved Proxy Group as '" + proxiesSavetbx.Text + "'", vbInformation)
    '        Dim file As System.IO.StreamWriter
    '        file = My.Computer.FileSystem.OpenTextFileWriter("proxies.txt", True)
    '        file.WriteLine(proxiesSavetbx.Text)
    '        file.Close()
    '    End If
    'End Sub

    'Private Sub profilesSavebtn_Click(sender As Object, e As EventArgs)
    '    If profilesSaveTbx.Text = String.Empty Then
    '        MsgBox("You must enter a name for the Profile Group", vbCritical)
    '    Else
    '        MsgBox("Successfully Saved Profile Group as '" + profilesSaveTbx.Text + "'", vbInformation)
    '        Dim file As System.IO.StreamWriter
    '        file = My.Computer.FileSystem.OpenTextFileWriter("profiles.txt", True)
    '        file.WriteLine(profilesSaveTbx.Text)
    '        file.Close()
    '    End If
    'End Sub

    'Private Sub Guna2GradientButton5_Click_2(sender As Object, e As EventArgs)
    '    pnlViewTasks.Visible = True
    'End Sub

    'Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs)
    '    pnlViewTasks.Visible = False
    '    tasksPnl.Visible = True
    'End Sub

    'Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
    '    Dim webAddress As String = "https://guide.zapaio.com/"
    '    Process.Start(webAddress)
    'End Sub

End Class

Public Class Profile
    Public Property profileName As String
    Public Property shippingInfo As Shipping
    Public Property billingInfo As Billing
End Class

Public Class Shipping
    Public Property profileEmail As String
    Public Property profilePhone As String
    Public Property profileAddress1 As String
    Public Property profileAddress2 As String
    Public Property profileCountry As String
    Public Property profileState As String
    Public Property profileCity As String
    Public Property profileZip As String
End Class

Public Class Billing
    Public Property billingAddress As String
    Public Property billingCountry As String
    Public Property billingState As String
    Public Property billingCity As String
    Public Property billingZip As String
    Public Property firstName As String
    Public Property lastName As String
    Public Property cardNum As String
    Public Property expiration As String
    Public Property cvv As String
End Class
