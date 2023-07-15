Imports System.Collections.Specialized
Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text

Public Class dWebHook
    Implements IDisposable

    Private ReadOnly client As HttpClient
    Private ReadOnly discordValues As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public Property WebHook As String
    Public Property UserName As String
    Public Property ProfilePicture As String

    Public Sub New()
        client = New HttpClient()
    End Sub

    Public Async Function SendMessageAsync(ByVal msgSend As String, ByVal fileToSend As String) As Task

        If String.IsNullOrEmpty(fileToSend) Then
            discordValues.Add("username", "ZapAIO")
            discordValues.Add("avatar_url", "https://i.imgur.com/SfGyK24.png")
            discordValues.Add("content", msgSend)

            Try
                Dim content As New FormUrlEncodedContent(discordValues)
                Await client.PostAsync(WebHook, content)
            Catch ex As Exception
                MsgBox("Unable to send message!" & vbCrLf & vbCrLf & "This issue can be caused by one or more of the following:" & vbCrLf & "- You are making too many requests." & vbCrLf & "- There is no connection to the Internet." & vbCrLf & "- The webhook is incorrect" & vbCrLf & "- Discord's servers are down." & vbCrLf & vbCrLf & "Error: " & ex.Message)
            End Try

            discordValues.Remove("content")
            Return
        End If

        discordValues.Add("username", UserName)
        discordValues.Add("avatar_url", ProfilePicture)

        Try
            Dim multipartContent As New MultipartFormDataContent()
            multipartContent.Add(New StringContent(msgSend), "content")

            Dim fileStream As New FileStream(fileToSend, FileMode.Open)
            Dim fileContent As New StreamContent(fileStream)
            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/octet-stream")
            fileContent.Headers.ContentDisposition = New ContentDispositionHeaderValue("form-data") With {
                .Name = "file",
                .FileName = Path.GetFileName(fileToSend)
            }
            multipartContent.Add(fileContent)

            Dim response As HttpResponseMessage = Await client.PostAsync("https://discord.com/api/webhooks/934286659648909363/7vdZf_1Hx64VWynUE-HOC3LqG641uSF6CwPrFdX4K_02HpkqeLZ9qipGpqOsGUH2Zvqm", multipartContent)
            Dim responseString As String = Await response.Content.ReadAsStringAsync()
        Catch ex As Exception
            MsgBox("Unable to send message!" & vbCrLf & vbCrLf & "This issue can be caused by one or more of the following:" & vbCrLf & "- You are making too many requests." & vbCrLf & "- There is no connection to the Internet." & vbCrLf & "- The webhook is incorrect" & vbCrLf & "- Discord's servers are down." & vbCrLf & vbCrLf & "Error: " & ex.Message)
        End Try

        discordValues.Remove("username")
        discordValues.Remove("avatar_url")
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        client.Dispose()
    End Sub
End Class
