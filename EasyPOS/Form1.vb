Public Class MainForm
    Private Sub CashierBtn_Click(sender As Object, e As EventArgs) Handles CashierBtn.Click
        CashierForm.Show()
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        SettingsForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.LogPath = "" Then
            SettingsForm.Show()
        End If
    End Sub

    Private Sub SellBtn_Click(sender As Object, e As EventArgs) Handles SellBtn.Click
        MainScreen.Show()
    End Sub
End Class
