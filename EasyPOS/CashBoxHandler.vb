Imports System.IO
Public Class CashBoxHandler
    Public Sub PrintXReport()
        Dim log As New List(Of String)
        Dim Paid, PaidCount, CreditPaid, ReturnCount, ReturnSum, DepositedAmount, WithdrawAmount, WithdrawTimes As Single
        Using sr As New StreamReader(My.Settings.CurrentLog)
        Do While sr.Peek() >= 0
                log.Add(sr.ReadLine())
            Loop
        End Using
        For Each i As String In log
            Dim j() As String = i.Split(";")
            Select Case j(0)
                Case "Paid"
                    Paid += j(1)
                    Paid += j(2)
                    CreditPaid += j(2)
                    PaidCount += 1
                Case "Deposit"
                    DepositedAmount += j(1)
                Case "Withdraw"
                    WithdrawAmount += j(1)
                    WithdrawTimes += 1
            End Select
        Next
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .NormalFont()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .SetFont()
            .FeedPaper(1)
            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteLine("")
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .DrawLine()
            .FeedPaper(1)

            .AlignCenter()
            .Bold = True
            .NormalFont()
            .WriteLine(Date.Today)
            .BigFont()
            .WriteLine("Х-отчет")
            .Bold = False
            .DrawLine()

            .AlignLeft()
            .BigFont()
            .WriteLine("Отдел 1")
            .SmallFont()
            .WriteLine("Принято:" & Paid)
            .DrawLine()
            .FeedPaper(1)
            .WriteLine("Кол-во продаж:")
            .WriteLine("1: " & PaidCount)
            .WriteLine("")
            .WriteLine("Возвраты:")
            .WriteLine("1: " & ReturnCount)
            .DrawLine()
            .FeedPaper(1)
            .WriteLine("Внесенная сумма:")
            .AlignRight()
            .WriteLine(DepositedAmount)
            .AlignLeft()
            .WriteLine("Снятая выручка:")
            .AlignRight()
            .WriteLine(WithdrawAmount)
            .AlignLeft()
            .WriteLine("Количество снятий:")
            .AlignRight()
            .WriteLine(WithdrawTimes)
            .AlignLeft()
            .WriteLine("Наличных в кассе:")
            .AlignRight()
            .WriteLine(My.Settings.Cash)
            .AlignLeft()
            .WriteLine("Без-нал расчет:")
            .AlignRight()
            .WriteLine(CreditPaid)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Всего продаж")
            .SmallFont()
            .AlignRight()
            .WriteLine(Paid)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Всего возвратов")
            .SmallFont()
            .AlignRight()
            .WriteLine(ReturnSum)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Неснижаемый счетчик")
            .SmallFont()
            .AlignRight()
            .WriteLine(My.Settings.Counter)
            .AlignLeft()
            .DrawLine()
            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub

    Public Sub PrintZReport()

        Dim log As New List(Of String)
        Dim Paid, PaidCount, CreditPaid, ReturnCount, ReturnSum, DepositedAmount, WithdrawAmount, WithdrawTimes As Single
        Using sr As New StreamReader(My.Settings.CurrentLog)
            Do While sr.Peek() >= 0
                log.Add(sr.ReadLine())
            Loop
        End Using
        For Each i As String In log
            Dim j() As String = i.Split(";")
            Select Case j(0)
                Case "Paid"
                    Paid += j(1)
                    Paid += j(2)
                    CreditPaid += j(2)
                    PaidCount += 1
                Case "Deposit"
                    DepositedAmount += j(1)
                Case "Withdraw"
                    WithdrawAmount += j(1)
                    WithdrawTimes += 1
            End Select
        Next
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .SetFont()

            'Printing Title
            .FeedPaper(1)

            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .DrawLine()
            .FeedPaper(1)

            .AlignCenter()
            .BigFont()
            .Bold = True
            .NormalFont()
            .WriteLine(Date.Now)
            .BigFont()
            .WriteLine("Z-отчет")
            .Bold = False
            .DrawLine()
            .FeedPaper(1)
            .AlignLeft()
            .BigFont()
            .WriteLine("Отдел 1")
            .SmallFont()
            .WriteLine("Принято:" & Paid)
            .DrawLine()
            .FeedPaper(1)
            .WriteLine("Кол-во продаж:")
            .WriteLine("1: " & PaidCount)
            .WriteLine("")
            .WriteLine("Возвраты:")
            .WriteLine("1: " & ReturnCount)
            .DrawLine()
            .FeedPaper(1)
            .WriteLine("Внесенная сумма:")
            .AlignRight()
            .WriteLine(DepositedAmount)
            .AlignLeft()
            .WriteLine("Снятая выручка:")
            .AlignRight()
            .WriteLine(WithdrawAmount)
            .AlignLeft()
            .WriteLine("Количество снятий:")
            .AlignRight()
            .WriteLine(WithdrawTimes)
            .AlignLeft()
            .WriteLine("Наличных в кассе:")
            .AlignRight()
            .WriteLine(My.Settings.Cash)
            .AlignLeft()
            .WriteLine("Без-нал расчет:")
            .AlignRight()
            .WriteLine(CreditPaid)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Всего продаж")
            .SmallFont()
            .AlignRight()
            .WriteLine(Paid)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Всего возвратов")
            .SmallFont()
            .AlignRight()
            .WriteLine(ReturnSum)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Неснижаемый счетчик")
            .SmallFont()
            .AlignRight()
            .WriteLine(My.Settings.Counter)
            .AlignLeft()
            .DrawLine()
            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub
    Public Sub OpenShift()

        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .NormalFont()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .SetFont()
            .FeedPaper(1)
            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteLine("")
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .DrawLine()
            .FeedPaper(1)
            .AlignCenter()
            .Bold = True
            .NormalFont()
            .WriteLine(My.Settings.ShiftOpenTime)
            .BigFont()
            .WriteLine("Смена открыта")
            .Bold = False
            .SmallFont()
            .SmallFont()
            .AlignCenter()
            .WriteLine("Кассир 1 Чек " & My.Settings.CheckNumber)
            .DrawLine()

            .EndDoc()
        End With

    End Sub

    Public Sub Deposit(e As Single)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .NormalFont()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .SetFont()
            .FeedPaper(1)
            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .WriteLine("")
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .DrawLine()
            .FeedPaper(1)
            .AlignCenter()

            .NormalFont()
            .WriteLine("Внесенная сумма:")
            .AlignRight()
            .WriteLine(e)
            .SmallFont()
            .AlignCenter()
            .WriteLine("Кассир 1 Чек " & My.Settings.CheckNumber)
            .DrawLine()
            .EndDoc()
        End With
    End Sub
    Public Sub Withdraw(e As Single)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .NormalFont()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .SetFont()
            .FeedPaper(1)
            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .WriteLine("")
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .DrawLine()
            .FeedPaper(1)
            .AlignCenter()

            .NormalFont()
            .WriteLine("Изъятая сумма:")
            .AlignRight()
            .WriteLine(e)
            .SmallFont()
            .AlignCenter()
            .WriteLine("Кассир 1 Чек " & My.Settings.CheckNumber)
            .DrawLine()
            .EndDoc()
        End With
    End Sub
    Public Sub Pay(sum As Single, cash As Single, credit As Single, change As Single, list As DataTable)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .NormalFont()
            .AlignCenter()
            .WriteLine(My.Settings.Header)
            .SetFont()
            .FeedPaper(1)
            'Printing Date
            .GotoSixth(1)
            .SmallFont()
            .AlignLeft()
            .WriteLine("")
            .WriteChars(DateTime.Now.ToString)
            .WriteLine("")
            .WriteLine("Смена № " & My.Settings.ShiftNumber)
            .DrawLine()
            .FeedPaper(1)
            .AlignCenter()
            .NormalFont()
            .WriteLine("Продажа")
            .DrawLine()
            .FeedPaper(1)
            .SmallFont()
            For Each i As DataRow In list.Rows
                .AlignLeft()
                'CheckTxt.AppendText(String.Join(vbTab, i.ItemArray) & vbCrLf)
                .WriteLine(i.Field(Of Integer)(0) & ": " & i.Field(Of String)(1))
                .AlignRight()
                .WriteLine(i.Field(Of Single)(2) & " " & My.Settings.CashSign & " X " & i.Field(Of Single)(3) & " = " & i.Field(Of Single)(4) & " " & My.Settings.CashSign)
            Next
            .AlignLeft()
            .DrawLine()
            .FeedPaper(1)
            .BigFont()
            .WriteLine("Сумма: " & sum & " " & My.Settings.CashSign)
            .NormalFont()
            If cash > 0 Then .WriteLine("Наличные: " & cash & " " & My.Settings.CashSign)
            If credit > 0 Then .WriteLine("Без-нал: " & credit & " " & My.Settings.CashSign)
            .AlignCenter()
            .NormalFont()
            .WriteLine("Спасибо за покупку!")
            .DrawLine()
            .FeedPaper(1)
            .SmallFont()
            .WriteLine("Кассир 1 Чек " & My.Settings.CheckNumber)
            .DrawLine()
            .EndDoc()
        End With
    End Sub
End Class
