Imports Guna.UI2.WinForms
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports System.Collections.Specialized
Imports System.Net

Public Class Form1

    Private _CurrentTaskPanelName As String = Nothing
    Private _TaskPanelsAddedCount As Integer = 0

    Public Sub CreateTaskPanel()

        Dim taskPanel As Panel
        taskPanel = New Panel()

        With taskPanel
            .BackColor = Color.White
            .Size = New Size(920, 50)
            .Name = "pnlTask" + (_TaskPanelsAddedCount + 1).ToString
        End With

        flpTasks.Controls.Add(taskPanel)

        _CurrentTaskPanelName = taskPanel.Name
        _TaskPanelsAddedCount += 1

    End Sub

    Public Sub CreateTaskNameLabel(ByVal panelName As String, ByVal textToShow As String)
        Dim taskNameLabel As Label
        taskNameLabel = New Label

        With taskNameLabel
            .AutoSize = True
            .Location = New Point(10, 10)
            .Name = "lblTaskName" + _TaskPanelsAddedCount.ToString
            .Font = New Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            .ForeColor = Color.Black
            .Text = textToShow
        End With

        For Each controlObject As Control In flpTasks.Controls
            If controlObject.Name = panelName Then
                controlObject.Controls.Add(taskNameLabel)
            End If
        Next

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        positionAllPanels()
        hideAllPanels()
        overviewToggleON()
        profilespnl.Visible = False


        Guna2MouseStateHandler1.Add(pn_earn)
        pn_overview.BorderColor = Color.Gray
        pn_city.BorderColor = Color.Gray
        pn_earn.BorderColor = Color.Gray

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
    End Sub

    Sub positionAllPanels()
        settingsPnl.Location = New Point(23, 114)
        settingsPnl.Size = New Size(1015, 677)

        proxiespnl.Location = New Point(12, 187)
        proxiespnl.Size = New Point(1023, 614)

        profilespnl.Location = New Point(12, 187)
        profilespnl.Size = New Point(1023, 614)

        tasksPnl.Location = New Point(12, 187)
        tasksPnl.Size = New Point(1010, 601)

        pnlViewTasks.Location = New Point(12, 187)
        pnlViewTasks.Size = New Point(1010, 601)

        profilestbx.Location = New Point(427, 61)
        profilestbx.Size = New Point(580, 541)

        proxiesSavetbx.Location = New Point(profilesSaveTbx.Location.X, profilesSaveTbx.Location.Y)
        proxyLbl.Location = New Point(profilesLbl.Location.X, profilesLbl.Location.Y)

        proxySavebtn.Location = New Point(profilesSavebtn.Location.X, profilesSavebtn.Location.Y)
        proxyLoadbtn.Location = New Point(profilesLoadbtn.Location.X, profilesLoadbtn.Location.Y)

        delGroupProxies.Location = New Point(delGroupProfiles.Location.X, delGroupProfiles.Location.Y)
        delGroupProxiesbtn.Location = New Point(delGroupProfilesbtn.Location.X, delGroupProfilesbtn.Location.Y)


    End Sub

    Private Sub Guna2MouseStateHandler1_HoverState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.HoverState
        pn_earn.BorderColor = Color.FromArgb(45, 156, 252)

    End Sub
    Private Sub Guna2MouseStateHandler1_IdleState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.IdleState
        pn_earn.BorderColor = Color.Gray

    End Sub
    Private Sub Guna2MouseStateHandler1_PressedState(sender As Object, e As EventArgs) Handles Guna2MouseStateHandler1.PressedState
        pn_earn.BorderColor = Color.Gray

    End Sub

    Private Sub Guna2ImageButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        Dim webAddress As String = "https://github.com/Spring-0"
        Process.Start(webAddress)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim webAddress As String = "https://github.com/Spring-0"
        Process.Start(webAddress)
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click

    End Sub

    Sub readGroups()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("someFile.txt")
        cbxProxies.Items.Clear()
        delGroupProxies.Items.Clear()
        For Each i In fileReader.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            cbxProxies.Items.Add(i)
            delGroupProxies.Items.Add(i)
        Next

        Dim fileReader2 As String
        fileReader2 = My.Computer.FileSystem.ReadAllText("someFile.txt")
        cbxProfile.Items.Clear()
        delGroupProfiles.Items.Clear()
        For Each i In fileReader2.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
            cbxProfile.Items.Add(i)
            delGroupProfiles.Items.Add(i)
        Next

    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        readGroups()
        resetButtonColors()
        hideAllPanels()
        tasksPnl.Visible = True

        Guna2Separator1.Location = New Point(Guna2Button5.Location.X, Guna2Separator1.Location.Y)
        Guna2Button5.ForeColor = Color.White
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        resetButtonColors()
        hideAllPanels()
        ' Panel elements visibility
        overviewToggleON()

        ' Move button seperator
        Guna2Separator1.Location = New Point(Guna2Button4.Location.X, Guna2Separator1.Location.Y)

        ' Change Button colors
        Guna2Button4.ForeColor = Color.White
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        readGroups()
        resetButtonColors()
        hideAllPanels()
        profilespnl.Visible = True

        Guna2Separator1.Location = New Point(Guna2Button6.Location.X, Guna2Separator1.Location.Y)

        Guna2Button6.ForeColor = Color.White
    End Sub

    Sub overviewToggleOFF()
        pn_overview.Visible = False
        pn_city.Visible = False
        pn_earn.Visible = False
        Label1.Visible = False
        Guna2Panel2.Visible = False
        Guna2Panel3.Visible = False
    End Sub

    Sub overviewToggleON()
        pn_overview.Visible = True
        pn_city.Visible = True
        pn_earn.Visible = True
        Label1.Visible = True
        Guna2Panel2.Visible = True
        Guna2Panel3.Visible = True
    End Sub


    Sub resetButtonColors()
        Guna2Button4.ForeColor = Color.DimGray
        Guna2Button5.ForeColor = Color.DimGray
        Guna2Button6.ForeColor = Color.DimGray
        Guna2Button7.ForeColor = Color.DimGray
    End Sub

    Sub hideAllPanels()
        profilespnl.Visible = False
        proxiespnl.Visible = False
        settingsPnl.Visible = False
        ' Overview
        pn_overview.Visible = False
        pn_city.Visible = False
        pn_earn.Visible = False
        Label1.Visible = False
        Guna2Panel2.Visible = False
        Guna2Panel3.Visible = False
        tasksPnl.Visible = False
        pnlViewTasks.Visible = False
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.ExitThread()
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs) Handles profilesLoadbtn.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            profilestbx.Text = System.IO.File.ReadAllText(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
        End If
        MsgBox("Successfully Loaded Profiles")
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        readGroups()
        hideAllPanels()
        resetButtonColors()

        Guna2Separator1.Location = New Point(Guna2Button7.Location.X, Guna2Separator1.Location.Y)
        Guna2Button7.ForeColor = Color.White



        proxiespnl.Visible = True
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            proxiestbx.Text = System.IO.File.ReadAllText(System.IO.Path.GetFullPath(OpenFileDialog1.FileName))
        End If
        MsgBox("Successfully Loaded Proxies")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        hideAllPanels()
        Guna2Button1.ForeColor = Color.DimGray
        Guna2Button2.ForeColor = Color.White
        Guna2Button3.ForeColor = Color.DimGray


        settingsPnl.Visible = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        hideAllPanels()
        Guna2Button1.ForeColor = Color.White
        Guna2Button2.ForeColor = Color.DimGray
        Guna2Button3.ForeColor = Color.DimGray

        resetButtonColors()
        Guna2Separator1.Location = New Point(Guna2Button4.Location.X, Guna2Separator1.Location.Y)
        Guna2Button4.ForeColor = Color.White

        overviewToggleON()
    End Sub

    Public Class dWebHook
        Implements IDisposable

        Private ReadOnly client As WebClient
        Private Shared discordValues As NameValueCollection = New NameValueCollection()
        Public Property WebHook As String
        Public Property UserName As String
        Public Property ProfilePicture As String

        Public Sub New()
            client = New WebClient()
        End Sub

        Public Sub SendMessage(ByVal msgSend As String)
            If msgSend = "" Or WebHook = "" Then
                MsgBox("The webhook link is required!", vbCritical + vbOKOnly)
                Return
            End If
            discordValues.Add("username", "ZapAIO")
            discordValues.Add("avatar_url", "https://i.imgur.com/iOcZopX.jpg")
            discordValues.Add("content", msgSend)
            Try
                client.UploadValues(WebHook, discordValues)
            Catch
                MsgBox("Unable to send message!" & vbNewLine & vbNewLine & "This issue can be caused by one or more of the following:" & vbNewLine & "- You are making too many requests." & vbNewLine & "- There is no connection to the Internet." & vbNewLine & "- The webhook is incorrect" & vbNewLine & "- Discord's servers are down.")
            End Try
            discordValues.Remove("username")
            discordValues.Remove("avatar_url")
            discordValues.Remove("content")
            MsgBox("Successfully Sent Webhook Test")
        End Sub

        Public Sub Dispose()
            client.Dispose()
        End Sub

        Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
            DirectCast(client, IDisposable).Dispose()
        End Sub
    End Class

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim dcWeb As dWebHook = New dWebHook
        dcWeb.WebHook = tbxWebhook.Text
        dcWeb.SendMessage("ZapAIO Webhook Test")

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Guna2ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMode.SelectedIndexChanged

    End Sub

    Private Sub tasksPnl_Paint(sender As Object, e As PaintEventArgs) Handles tasksPnl.Paint

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click

        Dim validTbx As Boolean
        Dim validCbx As Boolean

        For Each tb As Guna2TextBox In tasksPnl.Controls.OfType(Of Guna2TextBox)()
            If tb.Text = String.Empty Then
                validTbx = False
                Exit For
            Else
                validTbx = True
                Exit For
            End If
        Next

        For Each cbx As Guna2ComboBox In tasksPnl.Controls.OfType(Of Guna2ComboBox)()
            If cbx.Text = String.Empty Then
                validCbx = False
                Exit For
            Else
                validCbx = True
                Exit For
            End If
        Next

        If validCbx = True And validTbx = True Then
            schedLbl.Text += 1
            CreateTaskPanel()
            CreateTaskNameLabel(_CurrentTaskPanelName, tbxProduct.Text)
        Else
            MsgBox("Failed to create task. Please fill out all the values.")
        End If


    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        MsgBox("Successfully Saved Settings", vbInformation)
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles proxySavebtn.Click
        If proxiesSavetbx.Text = String.Empty Then
            MsgBox("You must enter a name for the Proxy Group", vbCritical)
        Else
            MsgBox("Successfully Saved Proxy Group as '" + proxiesSavetbx.Text + "'", vbInformation)
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("proxies.txt", True)
            file.WriteLine(proxiesSavetbx.Text)
            file.Close()
        End If
    End Sub

    Private Sub profilesSavebtn_Click(sender As Object, e As EventArgs) Handles profilesSavebtn.Click
        If profilesSaveTbx.Text = String.Empty Then
            MsgBox("You must enter a name for the Profile Group", vbCritical)
        Else
            MsgBox("Successfully Saved Profile Group as '" + profilesSaveTbx.Text + "'", vbInformation)
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("profiles.txt", True)
            file.WriteLine(profilesSaveTbx.Text)
            file.Close()
        End If
    End Sub

    Private Sub Guna2GradientButton5_Click_2(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        pnlViewTasks.Visible = True
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        pnlViewTasks.Visible = False
        tasksPnl.Visible = True
    End Sub
End Class
