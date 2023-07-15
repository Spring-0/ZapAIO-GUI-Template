Public Class Started
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Main.runningTasksCountLbl.Text = Home.tasksDataGridView.RowCount + CInt(Main.runningTasksCountLbl.Text)
        Me.Close()
    End Sub
End Class