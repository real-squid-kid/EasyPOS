Public Class SettingsForm
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        My.Settings.PrinterName = PrinterNameTxt.Text
        My.Settings.Header = HeaderTxt.Text
        My.Settings.CashSign = CashSignTxt.Text
        Me.Close()
    End Sub

    Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrinterNameTxt.Text = My.Settings.PrinterName
        HeaderTxt.Text = My.Settings.Header
        CashSignTxt.Text = My.Settings.CashSign
        FontLbl.Text = "Шрифт: " & My.Settings.PrinterFont
        FontLbl.Font = New Font(My.Settings.PrinterFont, 10)
    End Sub

    Private Sub LogPathBtn_Click(sender As Object, e As EventArgs) Handles LogPathBtn.Click
        Dim folderpath As New FolderBrowserDialog()
        Dim result As DialogResult = folderpath.ShowDialog()
        If result = DialogResult.OK Then
            My.Settings.LogPath = folderpath.SelectedPath
        End If
    End Sub

    Private Sub FontChangeLbl_Click(sender As Object, e As EventArgs) Handles FontChangeLbl.Click
        Dim fontchoose As New FontDialog()
        Dim result As DialogResult = fontchoose.ShowDialog()
        If result = DialogResult.OK Then
            My.Settings.PrinterFont = fontchoose.Font.Name
            FontLbl.Text = "Шрифт: " & My.Settings.PrinterFont
            FontLbl.Font = New Font(My.Settings.PrinterFont, 10)
        End If
    End Sub

    Private Sub FontTestBtn_Click(sender As Object, e As EventArgs) Handles FontTestBtn.Click
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            '.PrintLogo()
            .WriteLine(My.Settings.Header)
            .SetFont()

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Тест шрифта")

            'Printing Date
            .GotoSixth(1)
            .NormalFont()
            .AlignLeft()
            .WriteChars(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header

            .HugeFont()
            .WriteLine("1234567890")
            .BigFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .NormalFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .SmallFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .Bold = False
            .HugeFont()
            .WriteLine("1234567890")
            .BigFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .NormalFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .SmallFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub
End Class