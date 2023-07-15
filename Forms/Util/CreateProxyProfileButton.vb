Imports Guna.UI2.WinForms

Public Class CreateProxyProfileButton

    Private Shared counter As Integer = 0

    Public Sub cProfileBtn(profileName As String, panel As FlowLayoutPanel, eventType As String)

        Dim proxyGroupBtn = New Guna2Button With {
            .FillColor = Color.FromArgb(42, 44, 64),
            .ForeColor = Color.White,
            .CustomBorderThickness = New Padding(1, 1, 1, 1),
            .CustomBorderColor = Color.FromArgb(42, 44, 64),
            .Width = 180,
            .Height = 100,
            .Text = profileName
        }
        If eventType = "proxyGroupBtnClick" Then
            AddHandler proxyGroupBtn.Click, AddressOf Home.proxyGroupBtnClick
        ElseIf eventType = "taskGroupBtn_Click" Then
            AddHandler proxyGroupBtn.Click, AddressOf Home.taskGroupBtn_Click
        End If

        proxyGroupBtn.PerformClick()
        Home.previousSelectedProfile = proxyGroupBtn
        panel.Controls.Add(proxyGroupBtn)

        'counter += 15 + 180
    End Sub

End Class
