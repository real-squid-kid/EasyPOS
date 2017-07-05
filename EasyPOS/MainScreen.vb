Imports System.IO
Public Class MainScreen
    Dim TotalCost As Single
    Dim Sum As Single
    Dim CurrentCheck As New DataTable

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentCheck.Columns.Add("Number", GetType(Integer))
        CurrentCheck.Columns.Add("Nametag", GetType(String))
        CurrentCheck.Columns.Add("Price", GetType(Single))
        CurrentCheck.Columns.Add("Quantity", GetType(Single))
        CurrentCheck.Columns.Add("Total", GetType(Single))
        TotalLabel.Text = "Сумма: 0 " & My.Settings.CashSign
        UpdateBox()
    End Sub

    Private Sub PriceTxt_TextChanged(sender As Object, e As EventArgs) Handles PriceTxt.TextChanged, QuantityTxt.TextChanged
        Try
            TotalCost = PriceTxt.Text * QuantityTxt.Text
            SumLbl.Text = "Сумма: " & TotalCost & " " & My.Settings.CashSign
            AddtoCheckBtn.Enabled = True
        Catch ex As Exception
            SumLbl.Text = "Cумма: Х"
            AddtoCheckBtn.Enabled = False
        End Try
    End Sub

    Private Sub UpdateBox()
        CheckTxt.Text = ""
        'CheckTxt.AppendText("№" & vbTab & "Название" & vbTab & "Цена" & vbTab & "Количество" & vbTab & "Сумма" & vbCrLf)
        For Each i As DataRow In CurrentCheck.Rows
            'CheckTxt.AppendText(String.Join(vbTab, i.ItemArray) & vbCrLf)
            CheckTxt.AppendText(i.Field(Of Integer)(0) & ": " & i.Field(Of String)(1) & vbTab & i.Field(Of Single)(2) & " " & My.Settings.CashSign & " X " & i.Field(Of Single)(3) & " = " & i.Field(Of Single)(4) & " " & My.Settings.CashSign & vbCrLf)
        Next
        Sum = 0
        For Each i As DataRow In CurrentCheck.Rows
            Sum += i.Field(Of Single)(4)
        Next
        TotalLabel.Text = "Cумма: " & Sum & " " & My.Settings.CashSign
        If Sum <> 0 Then PayBtn.Enabled = True Else PayBtn.Enabled = False

    End Sub

    Private Sub AddtoCheckBtn_Click(sender As Object, e As EventArgs) Handles AddtoCheckBtn.Click
        CurrentCheck.Rows.Add(CurrentCheck.Rows.Count + 1, NameTagTxt.Text, PriceTxt.Text, QuantityTxt.Text, TotalCost)
        UpdateBox()
        PriceTxt.Text = ""
        NameTagTxt.Text = ""
        QuantityTxt.Text = ""
        NameTagTxt.Focus()
    End Sub

    Private Sub DeleteLastBtn_Click(sender As Object, e As EventArgs) Handles DeleteLastBtn.Click
        Try
            CurrentCheck.Rows.Remove(CurrentCheck.Rows.Item(CurrentCheck.Rows.Count - 1))
            UpdateBox()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub PayBtn_Click(sender As Object, e As EventArgs) Handles PayBtn.Click
        PayForm.Show()
        PayForm.GetParameter(Sum)
    End Sub

    Public Sub Pay(a As Single, b As Single, c As Single)
        If My.Settings.ShiftOpened Then
            Dim print As New CashBoxHandler
            My.Settings.Cash += a
            My.Settings.Counter += a + b
            My.Settings.CheckNumber += 1
            My.Settings.Save()
            print.Pay(Sum, a, b, c, CurrentCheck)
            Using outputFile As New StreamWriter(My.Settings.CurrentLog, True, System.Text.Encoding.GetEncoding("UTF-8"))
                outputFile.WriteLine("Paid;" & a & ";" & b & ";" & Date.Now)
            End Using
            CurrentCheck.Clear()
            TotalLabel.Text = "Сумма: 0 " & My.Settings.CashSign
            UpdateBox()
        Else
            MessageBox.Show("Сначала нужно открыть смену!")
        End If

    End Sub
End Class