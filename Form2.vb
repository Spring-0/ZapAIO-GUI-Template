Public Class Form2
    Dim savedPassword As String

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        savedPassword = My.Settings.loginPassword
        tbxKey.Text = savedPassword
        tbxKey.UseSystemPasswordChar = True

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If tbxKey.Text.Length = 30 Then
            Hide()
            Form1.Show()

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
        Dim webAddress As String = "https://github.com/Spring-0"
        Process.Start(webAddress)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim webAddress As String = "https://github.com/Spring-0"
        Process.Start(webAddress)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim webAddress As String = "https://github.com/Spring-0"
        Process.Start(webAddress)
    End Sub
End Class