<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierForm
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
        Me.DepositBtn = New System.Windows.Forms.Button()
        Me.XReportBtn = New System.Windows.Forms.Button()
        Me.WithdrawBtn = New System.Windows.Forms.Button()
        Me.ZReportBtn = New System.Windows.Forms.Button()
        Me.ShiftStatusLbl = New System.Windows.Forms.Label()
        Me.ShiftTimeLbl = New System.Windows.Forms.Label()
        Me.CashLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DepositBtn
        '
        Me.DepositBtn.Enabled = False
        Me.DepositBtn.Location = New System.Drawing.Point(12, 61)
        Me.DepositBtn.Name = "DepositBtn"
        Me.DepositBtn.Size = New System.Drawing.Size(266, 43)
        Me.DepositBtn.TabIndex = 1
        Me.DepositBtn.Text = "Внесение..."
        Me.DepositBtn.UseVisualStyleBackColor = True
        '
        'XReportBtn
        '
        Me.XReportBtn.Location = New System.Drawing.Point(12, 12)
        Me.XReportBtn.Name = "XReportBtn"
        Me.XReportBtn.Size = New System.Drawing.Size(266, 43)
        Me.XReportBtn.TabIndex = 1
        Me.XReportBtn.Text = "Открыть смену / X-отчет"
        Me.XReportBtn.UseVisualStyleBackColor = True
        '
        'WithdrawBtn
        '
        Me.WithdrawBtn.Enabled = False
        Me.WithdrawBtn.Location = New System.Drawing.Point(12, 110)
        Me.WithdrawBtn.Name = "WithdrawBtn"
        Me.WithdrawBtn.Size = New System.Drawing.Size(266, 43)
        Me.WithdrawBtn.TabIndex = 1
        Me.WithdrawBtn.Text = "Изъятие..."
        Me.WithdrawBtn.UseVisualStyleBackColor = True
        '
        'ZReportBtn
        '
        Me.ZReportBtn.Enabled = False
        Me.ZReportBtn.Location = New System.Drawing.Point(12, 159)
        Me.ZReportBtn.Name = "ZReportBtn"
        Me.ZReportBtn.Size = New System.Drawing.Size(266, 43)
        Me.ZReportBtn.TabIndex = 1
        Me.ZReportBtn.Text = "Закрыть смену"
        Me.ZReportBtn.UseVisualStyleBackColor = True
        '
        'ShiftStatusLbl
        '
        Me.ShiftStatusLbl.AutoSize = True
        Me.ShiftStatusLbl.Location = New System.Drawing.Point(12, 216)
        Me.ShiftStatusLbl.Name = "ShiftStatusLbl"
        Me.ShiftStatusLbl.Size = New System.Drawing.Size(86, 13)
        Me.ShiftStatusLbl.TabIndex = 2
        Me.ShiftStatusLbl.Text = "Смена закрыта"
        '
        'ShiftTimeLbl
        '
        Me.ShiftTimeLbl.AutoSize = True
        Me.ShiftTimeLbl.Location = New System.Drawing.Point(12, 238)
        Me.ShiftTimeLbl.Name = "ShiftTimeLbl"
        Me.ShiftTimeLbl.Size = New System.Drawing.Size(110, 13)
        Me.ShiftTimeLbl.TabIndex = 2
        Me.ShiftTimeLbl.Text = "00/00/0000 00:00:00"
        '
        'CashLbl
        '
        Me.CashLbl.AutoSize = True
        Me.CashLbl.Location = New System.Drawing.Point(12, 263)
        Me.CashLbl.Name = "CashLbl"
        Me.CashLbl.Size = New System.Drawing.Size(56, 13)
        Me.CashLbl.TabIndex = 2
        Me.CashLbl.Text = "В кассе 0"
        '
        'CashierForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 294)
        Me.Controls.Add(Me.ShiftTimeLbl)
        Me.Controls.Add(Me.CashLbl)
        Me.Controls.Add(Me.ShiftStatusLbl)
        Me.Controls.Add(Me.XReportBtn)
        Me.Controls.Add(Me.ZReportBtn)
        Me.Controls.Add(Me.WithdrawBtn)
        Me.Controls.Add(Me.DepositBtn)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CashierForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Работа с кассой"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DepositBtn As Button
    Friend WithEvents XReportBtn As Button
    Friend WithEvents WithdrawBtn As Button
    Friend WithEvents ZReportBtn As Button
    Friend WithEvents ShiftStatusLbl As Label
    Friend WithEvents ShiftTimeLbl As Label
    Friend WithEvents CashLbl As Label
End Class
