Public Class PayForm
    Dim Sum, initSum As Single
    Dim Cash As Single
    Dim Credit As Single
    Dim Change As Single
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
    Public Sub GetParameter(e As Single)
        initSum = e
        Sum = e
        SumLbl.Text = "К оплате: " & Sum & My.Settings.CashSign
        ChangeTxt.Text = "Сдача: X"
        Change = 0
        PayBtn.Enabled = False
    End Sub
    Private Sub PayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CreditTxt_TextChanged(sender As Object, e As EventArgs) Handles CreditTxt.TextChanged
        Try
            Credit = CreditTxt.Text
            Sum = initSum - Cash - Credit
            If Sum > 0 Then
                SumLbl.Text = "К оплате: " & Sum & My.Settings.CashSign
                ChangeTxt.Text = "Сдача: X"
                Change = 0
                PayBtn.Enabled = False
            Else
                SumLbl.Text = "Оплачено полностью"
                Change = Sum - Sum * 2
                ChangeTxt.Text = "Сдача:" & Change & My.Settings.CashSign
                PayBtn.Enabled = True
            End If
        Catch ex As Exception
            SumLbl.Text = "К оплате: X"
            ChangeTxt.Text = "Сдача: X"
        End Try
    End Sub

    Private Sub PayBtn_Click(sender As Object, e As EventArgs) Handles PayBtn.Click
        MainScreen.Pay(Cash, Credit, Change)
        Me.Close()
    End Sub

    Private Sub CashTxt_TextChanged(sender As Object, e As EventArgs) Handles CashTxt.TextChanged
        Try
            Cash = CashTxt.Text
            Sum = initSum - Cash - Credit
            If Sum > 0 Then
                SumLbl.Text = "К оплате: " & Sum & My.Settings.CashSign
                ChangeTxt.Text = "Сдача: X"
                Change = 0
                PayBtn.Enabled = False
            Else
                SumLbl.Text = "Оплачено полностью"
                Change = Sum - Sum * 2
                ChangeTxt.Text = "Сдача:" & Change & My.Settings.CashSign
                PayBtn.Enabled = True
            End If
        Catch ex As Exception
            SumLbl.Text = "К оплате: X"
            ChangeTxt.Text = "Сдача: X"
        End Try
    End Sub
End Class