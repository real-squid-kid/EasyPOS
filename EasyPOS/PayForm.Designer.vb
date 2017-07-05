<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PayForm
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
        Me.SumLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CashTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CreditTxt = New System.Windows.Forms.TextBox()
        Me.ChangeTxt = New System.Windows.Forms.Label()
        Me.PayBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SumLbl
        '
        Me.SumLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SumLbl.Location = New System.Drawing.Point(13, 13)
        Me.SumLbl.Name = "SumLbl"
        Me.SumLbl.Size = New System.Drawing.Size(332, 36)
        Me.SumLbl.TabIndex = 0
        Me.SumLbl.Text = "К оплате: 0 р."
        Me.SumLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Наличные:"
        '
        'CashTxt
        '
        Me.CashTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CashTxt.Location = New System.Drawing.Point(162, 66)
        Me.CashTxt.Name = "CashTxt"
        Me.CashTxt.Size = New System.Drawing.Size(183, 35)
        Me.CashTxt.TabIndex = 1
        Me.CashTxt.Text = "0,00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Без-нал:"
        '
        'CreditTxt
        '
        Me.CreditTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CreditTxt.Location = New System.Drawing.Point(162, 123)
        Me.CreditTxt.Name = "CreditTxt"
        Me.CreditTxt.Size = New System.Drawing.Size(183, 35)
        Me.CreditTxt.TabIndex = 1
        Me.CreditTxt.Text = "0,00"
        '
        'ChangeTxt
        '
        Me.ChangeTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ChangeTxt.Location = New System.Drawing.Point(12, 176)
        Me.ChangeTxt.Name = "ChangeTxt"
        Me.ChangeTxt.Size = New System.Drawing.Size(332, 36)
        Me.ChangeTxt.TabIndex = 0
        Me.ChangeTxt.Text = "Сдача: X"
        Me.ChangeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PayBtn
        '
        Me.PayBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PayBtn.Location = New System.Drawing.Point(18, 234)
        Me.PayBtn.Name = "PayBtn"
        Me.PayBtn.Size = New System.Drawing.Size(138, 59)
        Me.PayBtn.TabIndex = 2
        Me.PayBtn.Text = "Оплатить"
        Me.PayBtn.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(197, 234)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(138, 59)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'PayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 313)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.PayBtn)
        Me.Controls.Add(Me.CreditTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CashTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChangeTxt)
        Me.Controls.Add(Me.SumLbl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PayForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Оплата"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SumLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CashTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CreditTxt As TextBox
    Friend WithEvents ChangeTxt As Label
    Friend WithEvents PayBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
