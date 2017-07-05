<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrinterNameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogPathBtn = New System.Windows.Forms.Button()
        Me.FontLbl = New System.Windows.Forms.Label()
        Me.FontChangeLbl = New System.Windows.Forms.Button()
        Me.FontTestBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeaderTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CashSignTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Имя принтера:"
        '
        'PrinterNameTxt
        '
        Me.PrinterNameTxt.Location = New System.Drawing.Point(100, 6)
        Me.PrinterNameTxt.Name = "PrinterNameTxt"
        Me.PrinterNameTxt.Size = New System.Drawing.Size(124, 20)
        Me.PrinterNameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Путь к логам:"
        '
        'LogPathBtn
        '
        Me.LogPathBtn.Location = New System.Drawing.Point(149, 36)
        Me.LogPathBtn.Name = "LogPathBtn"
        Me.LogPathBtn.Size = New System.Drawing.Size(75, 23)
        Me.LogPathBtn.TabIndex = 3
        Me.LogPathBtn.Text = "Задать..."
        Me.LogPathBtn.UseVisualStyleBackColor = True
        '
        'FontLbl
        '
        Me.FontLbl.AutoSize = True
        Me.FontLbl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FontLbl.Location = New System.Drawing.Point(12, 77)
        Me.FontLbl.Name = "FontLbl"
        Me.FontLbl.Size = New System.Drawing.Size(102, 13)
        Me.FontLbl.TabIndex = 4
        Me.FontLbl.Text = "Шрифт: Verdana"
        '
        'FontChangeLbl
        '
        Me.FontChangeLbl.Location = New System.Drawing.Point(149, 72)
        Me.FontChangeLbl.Name = "FontChangeLbl"
        Me.FontChangeLbl.Size = New System.Drawing.Size(75, 23)
        Me.FontChangeLbl.TabIndex = 5
        Me.FontChangeLbl.Text = "Изменить..."
        Me.FontChangeLbl.UseVisualStyleBackColor = True
        '
        'FontTestBtn
        '
        Me.FontTestBtn.Location = New System.Drawing.Point(149, 101)
        Me.FontTestBtn.Name = "FontTestBtn"
        Me.FontTestBtn.Size = New System.Drawing.Size(75, 23)
        Me.FontTestBtn.TabIndex = 5
        Me.FontTestBtn.Text = "Тест..."
        Me.FontTestBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(197, 226)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 6
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Заголовок:"
        '
        'HeaderTxt
        '
        Me.HeaderTxt.Location = New System.Drawing.Point(82, 138)
        Me.HeaderTxt.Name = "HeaderTxt"
        Me.HeaderTxt.Size = New System.Drawing.Size(142, 20)
        Me.HeaderTxt.TabIndex = 8
        Me.HeaderTxt.Text = "ООО ""Ромашка"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Знак валюты:"
        '
        'CashSignTxt
        '
        Me.CashSignTxt.Location = New System.Drawing.Point(95, 170)
        Me.CashSignTxt.Name = "CashSignTxt"
        Me.CashSignTxt.Size = New System.Drawing.Size(129, 20)
        Me.CashSignTxt.TabIndex = 8
        Me.CashSignTxt.Text = "р."
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CashSignTxt)
        Me.Controls.Add(Me.HeaderTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.FontTestBtn)
        Me.Controls.Add(Me.FontChangeLbl)
        Me.Controls.Add(Me.FontLbl)
        Me.Controls.Add(Me.LogPathBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PrinterNameTxt)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Настройки"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PrinterNameTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LogPathBtn As Button
    Friend WithEvents FontLbl As Label
    Friend WithEvents FontChangeLbl As Button
    Friend WithEvents FontTestBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents HeaderTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CashSignTxt As TextBox
End Class
