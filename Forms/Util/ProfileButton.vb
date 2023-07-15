Imports Guna.UI2.WinForms

Public Class ProfileButton

    Private Shared counter As Integer = 0

    Public Sub cProfileBtn(profileName As String, panel As Guna2Panel)

        Dim profileButton As New Guna2TileButton() With {
            .Text = profileName,
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

        panel.Controls.Add(profileButton)

        'counter += 15 + 180
    End Sub

End Class
