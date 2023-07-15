Imports Newtonsoft.Json
Imports Guna.UI2.WinForms
Imports System.Threading
Imports System.ComponentModel

Public Class Login
    Dim savedPassword As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        savedPassword = My.Settings.loginPassword
        tbxKey.Text = savedPassword
        tbxKey.UseSystemPasswordChar = True
    End Sub



    Private Sub LoadProfileGroupButtonsCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        ' Perform any actions that need to be done after the background worker has completed here
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbxKey.Text.Length = 30 Then
            Hide()
            Main.Show()

            If My.Settings.loginPassword = "" Then
                My.Settings.loginPassword = tbxKey.Text
                My.Settings.Save()
            End If

        Else
            tbxKey.Text = "That is not a valid key"
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If tbxKey.UseSystemPasswordChar = True Then
            tbxKey.UseSystemPasswordChar = False
        Else
            tbxKey.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim webAddress As String = ""
        Process.Start(webAddress)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim webAddress As String = "https://discord.gg/jzqAYwKz4m"
        Process.Start(webAddress)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim webAddress As String = "https://twitter.com/ZapBots"
        Process.Start(webAddress)
    End Sub

    Private Sub pbxLogo_Click(sender As Object, e As EventArgs) Handles pbxLogo.Click
        My.Computer.Audio.Play(My.Resources.welcomeAudio, AudioPlayMode.Background)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim zapAioFolderPath As String = System.IO.Path.Combine(appDataPath, "ZapAIO")
        Dim filePath As String = System.IO.Path.Combine(zapAioFolderPath, "proxyGroups.json")
        If IO.File.Exists(filePath) Then
            Dim fileContents As String = System.IO.File.ReadAllText(filePath)
            If Not String.IsNullOrEmpty(fileContents) Then
                Dim cppb As New CreateProxyProfileButton()
                Dim proxyGroups As List(Of ProxyGroupModel) = JsonConvert.DeserializeObject(Of List(Of ProxyGroupModel))(fileContents)
                For Each proxy In proxyGroups
                    If BackgroundWorker1.CancellationPending Then
                        e.Cancel = True
                        Return
                    End If

                    cppb.cProfileBtn(proxy.proxyGroupName, Home.proxiesListFlow, "proxyGroupBtnClick")
                Next
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If e.Cancelled Then
            ' The operation was cancelled by the user
            MessageBox.Show("Operation cancelled.")
        ElseIf e.Error IsNot Nothing Then
            ' An error occurred during the operation
            MessageBox.Show("An error occurred: " & e.Error.Message)
        Else
            ' The operation completed successfully
            MessageBox.Show("Operation completed.")
        End If
    End Sub
End Class