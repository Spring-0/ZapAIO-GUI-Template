Public Class SettingsModel
    Public Property discordSettings As DiscordSettings
    Public Property captchaSettings As CaptchaSettings
    Public Property aycdSettings As AYCDSettings
    Public Property otherSettings As OtherSettings

End Class


Public Class DiscordSettings
    Public Property successWebhook As String
    Public Property failedWebhook As String
    Public Property miscWebhook As String
    Public Property successOnly As Boolean
    Public Property queuePasses As Boolean
End Class


Public Class CaptchaSettings
    Public Property apiService As String
    Public Property apiKey As String
    Public Property proxyOnCaptcha As Boolean
End Class

Public Class AYCDSettings
    Public Property aycdAutoSolveAccessToken As String
    Public Property aycdAutoSolveAPIKey As String
End Class

Public Class OtherSettings
    Public Property catchallDomain As String
End Class
