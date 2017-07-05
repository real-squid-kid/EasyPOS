Imports System.IO
Public Class CashierForm

    Private Sub XReportBtn_Click(sender As Object, e As EventArgs) Handles XReportBtn.Click
        Dim cash As New CashBoxHandler
        Dim files = My.Computer.FileSystem.GetFiles(My.Settings.LogPath)
        If My.Settings.ShiftOpened = False Then
            Dim result As DialogResult = MessageBox.Show("Открывается новая смена № " & files.Count + 1 & ". Нажмите Да для продолжения.", "EasyPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If result = DialogResult.Yes Then
                My.Settings.ShiftNumber = files.Count + 1
                My.Settings.CurrentLog = My.Settings.LogPath & Convert.ToString("\string" & My.Settings.ShiftNumber & ".eklz")
                Using outputFile As New StreamWriter(My.Settings.CurrentLog, False, System.Text.Encoding.GetEncoding("UTF-8"))
                    outputFile.WriteLine("EasyPOS ver. 0.1 " & Date.Now)
                    outputFile.WriteLine("Shift opened;" & Date.Now)
                End Using
                My.Settings.ShiftOpenTime = DateTime.Now
                My.Settings.ShiftOpened = True
                My.Settings.DepositedAmount = 0.00
                My.Settings.CheckNumber = 1
                My.Settings.Save()
                cash.PrintXReport()
                cash.OpenShift()
                ShiftStatusLbl.Text = "Смена открыта"
                ShiftTimeLbl.Text = My.Settings.ShiftOpenTime
                DepositBtn.Enabled = True
                WithdrawBtn.Enabled = True
                ZReportBtn.Enabled = True
            End If
        Else
            cash.PrintXReport()
        End If
    End Sub

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.ShiftOpened Then
            ShiftStatusLbl.Text = "Смена открыта"
            ShiftTimeLbl.Text = My.Settings.ShiftOpenTime
            DepositBtn.Enabled = True
            WithdrawBtn.Enabled = True
            ZReportBtn.Enabled = True
        Else
            ShiftStatusLbl.Text = "Смена закрыта"
            ShiftTimeLbl.Text = "---"
        End If
        CashLbl.Text = "Денег в кассе: " & My.Settings.Cash & " " & My.Settings.CashSign
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click
        Dim result As Single = InputBox("Введите сумму внесения и нажмите ОК для продолжения.")
        If result > 0 Then
            My.Settings.Cash += result
            My.Settings.Counter += result
            My.Settings.CheckNumber += 1
            My.Settings.DepositedAmount += result
            My.Settings.Save()
            Dim cash As New CashBoxHandler
            cash.Deposit(result)
            Using outputFile As New StreamWriter(My.Settings.CurrentLog, True, System.Text.Encoding.GetEncoding("UTF-8"))
                outputFile.WriteLine("Deposit;" & result & ";" & Date.Now)
            End Using
            CashLbl.Text = "Денег в кассе: " & My.Settings.Cash & " " & My.Settings.CashSign
        End If
    End Sub

    Private Sub ZReportBtn_Click(sender As Object, e As EventArgs) Handles ZReportBtn.Click
        Dim files = My.Computer.FileSystem.GetFiles(My.Settings.LogPath)
        Dim cash As New CashBoxHandler
        Dim result As DialogResult = MessageBox.Show("Закрывается смена № " & My.Settings.ShiftNumber & ". Нажмите Да для продолжения.", "EasyPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            My.Settings.CurrentLog = My.Settings.LogPath & Convert.ToString("\string" & My.Settings.ShiftNumber & ".eklz")
            Using outputFile As New StreamWriter(My.Settings.CurrentLog, True, System.Text.Encoding.GetEncoding("UTF-8"))
                outputFile.WriteLine("Shift closed;" & Date.Now)
            End Using
            My.Settings.ShiftOpenTime = Nothing
            My.Settings.ShiftOpened = False
            cash.PrintZReport()
            My.Settings.CheckNumber = 0
            My.Settings.Save()
            ShiftStatusLbl.Text = "Смена закрыта"
            ShiftTimeLbl.Text = "---"
            DepositBtn.Enabled = True
            WithdrawBtn.Enabled = True
            ZReportBtn.Enabled = True
        End If
    End Sub

    Private Sub WithdrawBtn_Click(sender As Object, e As EventArgs) Handles WithdrawBtn.Click
        Dim result As Single = InputBox("Введите сумму изъятия и нажмите ОК для продолжения.")
        If result > 0 Then
            My.Settings.Cash -= result
            My.Settings.CheckNumber += 1
            My.Settings.WithdrawAmount += result
            My.Settings.WithdrawTimes += 1
            My.Settings.Save()
            Dim cash As New CashBoxHandler
            cash.Withdraw(result)
            Using outputFile As New StreamWriter(My.Settings.CurrentLog, True, System.Text.Encoding.GetEncoding("UTF-8"))
                outputFile.WriteLine("Withdraw;" & result & ";" & Date.Now)
            End Using
            CashLbl.Text = "Денег в кассе: " & My.Settings.Cash & " " & My.Settings.CashSign
        End If
    End Sub
End Class