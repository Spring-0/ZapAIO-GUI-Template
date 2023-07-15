Imports System.IO
Imports Newtonsoft.Json


Public Class Settings
    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles successOnlyBox.CheckedChanged
        If successOnlyBox.Checked Then
            failsTbx.Enabled = False
            miscTbx.Enabled = False
        Else
            failsTbx.Enabled = True
            miscTbx.Enabled = True
        End If
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Dim dcWeb As dWebHook = New dWebHook
        If successOnlyBox.Checked Then
            If successWebhookTbx.Text = "" Then
                MessageBox.Show("The webhook link is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            dcWeb.WebHook = successWebhookTbx.Text
            dcWeb.SendMessageAsync("ZapAIO Success Task Test", "")
            MsgBox("Successfully sent test webhook!")
            Return
        End If

        If successWebhookTbx.Text = "" Or miscTbx.Text = "" Or failsTbx.Text = "" Then
            MessageBox.Show("The webhook link is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        dcWeb.WebHook = failsTbx.Text
        dcWeb.SendMessageAsync("ZapAIO Failed Task Test", "")
        dcWeb.WebHook = successWebhookTbx.Text
        dcWeb.SendMessageAsync("ZapAIO Success Task Test", "")
        dcWeb.WebHook = miscTbx.Text
        dcWeb.SendMessageAsync("ZapAIO Misc Task Test", "")
        MsgBox("Successfully sent test webhook!")
    End Sub

    Private Sub otherSettingsApplyBtn_Click(sender As Object, e As EventArgs) Handles otherSettingsApplyBtn.Click

        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "settings.json")
        If Not File.Exists(filePath) Then
            Dim fileStream As System.IO.FileStream = System.IO.File.Create(filePath)
            fileStream.Close()
        End If

        Dim fileContents As String = System.IO.File.ReadAllText(filePath)
        Dim settings As List(Of SettingsModel) = New List(Of SettingsModel)()

        Dim newSettings As New SettingsModel With {
            .discordSettings = New DiscordSettings With {
                .failedWebhook = failsTbx.Text,
                .miscWebhook = miscTbx.Text,
                .successWebhook = successWebhookTbx.Text,
                .successOnly = successOnlyBox.Checked,
                .queuePasses = queuePassesBox.Checked
            },
            .aycdSettings = New AYCDSettings With {
                .aycdAutoSolveAccessToken = aycdAutosolveAccessTokenTbx.Text,
                .aycdAutoSolveAPIKey = aycdAutosolveAPIKeyTbx.Text
             },
             .captchaSettings = New CaptchaSettings With {
                .apiKey = captchaAPIKeyTbx.Text,
                .apiService = apiServiceCombo.Text,
                .proxyOnCaptcha = proxyOnCaptchaBox.Checked
            },
            .otherSettings = New OtherSettings With {
                .catchallDomain = catchallDomainTbx.Text
            }
        }

        settings.Add(newSettings)


        Dim jsonSettings As New JsonSerializerSettings With {
            .Formatting = Formatting.Indented
        }
        Dim json As String = JsonConvert.SerializeObject(settings, jsonSettings)

        File.WriteAllText(filePath, json)
        MessageBox.Show("Settings saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "settings.json")
        If Not File.Exists(filePath) Then
            Dim fileStream As System.IO.FileStream = System.IO.File.Create(filePath)
            fileStream.Close()
        End If

        Dim jsonData As String = File.ReadAllText(filePath)


        If Not String.IsNullOrEmpty(jsonData) Then
            Dim settings As SettingsModel = JsonConvert.DeserializeObject(Of SettingsModel())(jsonData)(0)
            Try
                ' Load Discord Settings
                successWebhookTbx.Text = Settings.discordSettings.successWebhook
                failsTbx.Text = Settings.discordSettings.failedWebhook
                miscTbx.Text = Settings.discordSettings.miscWebhook
                successOnlyBox.Checked = Settings.discordSettings.successOnly
                queuePassesBox.Checked = Settings.discordSettings.queuePasses

                ' Load Captcha Settings
                captchaAPIKeyTbx.Text = Settings.captchaSettings.apiKey
                apiServiceCombo.Text = Settings.captchaSettings.apiService
                proxyOnCaptchaBox.Checked = Settings.captchaSettings.proxyOnCaptcha

                ' Load AYCD Settings
                aycdAutosolveAccessTokenTbx.Text = Settings.aycdSettings.aycdAutoSolveAccessToken
                aycdAutosolveAPIKeyTbx.Text = Settings.aycdSettings.aycdAutoSolveAPIKey

                ' Load Other Settings
                catchallDomainTbx.Text = Settings.otherSettings.catchallDomain
            Catch ex As Exception
                MessageBox.Show("Error Reading Settings Data: " & ex.Message)
                Return
            End Try
        End If


    End Sub
End Class
