<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckTxt = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.PayBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTagTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PriceTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QuantityTxt = New System.Windows.Forms.TextBox()
        Me.SumLbl = New System.Windows.Forms.Label()
        Me.AddtoCheckBtn = New System.Windows.Forms.Button()
        Me.DeleteLastBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckTxt
        '
        Me.CheckTxt.Enabled = False
        Me.CheckTxt.Location = New System.Drawing.Point(13, 13)
        Me.CheckTxt.MaxLength = 65535
        Me.CheckTxt.Multiline = True
        Me.CheckTxt.Name = "CheckTxt"
        Me.CheckTxt.Size = New System.Drawing.Size(598, 171)
        Me.CheckTxt.TabIndex = 0
        Me.CheckTxt.TabStop = False
        '
        'TotalLabel
        '
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(423, 187)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(188, 36)
        Me.TotalLabel.TabIndex = 1
        Me.TotalLabel.Text = "Сумма: 0"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PayBtn
        '
        Me.PayBtn.Location = New System.Drawing.Point(495, 262)
        Me.PayBtn.Name = "PayBtn"
        Me.PayBtn.Size = New System.Drawing.Size(116, 48)
        Me.PayBtn.TabIndex = 2
        Me.PayBtn.TabStop = False
        Me.PayBtn.Text = "Оплатить"
        Me.PayBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Название:"
        '
        'NameTagTxt
        '
        Me.NameTagTxt.Location = New System.Drawing.Point(87, 207)
        Me.NameTagTxt.Name = "NameTagTxt"
        Me.NameTagTxt.Size = New System.Drawing.Size(100, 20)
        Me.NameTagTxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Цена:"
        '
        'PriceTxt
        '
        Me.PriceTxt.Location = New System.Drawing.Point(87, 232)
        Me.PriceTxt.Name = "PriceTxt"
        Me.PriceTxt.Size = New System.Drawing.Size(100, 20)
        Me.PriceTxt.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Количество:"
        '
        'QuantityTxt
        '
        Me.QuantityTxt.Location = New System.Drawing.Point(87, 258)
        Me.QuantityTxt.Name = "QuantityTxt"
        Me.QuantityTxt.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTxt.TabIndex = 2
        '
        'SumLbl
        '
        Me.SumLbl.AutoSize = True
        Me.SumLbl.Location = New System.Drawing.Point(15, 289)
        Me.SumLbl.Name = "SumLbl"
        Me.SumLbl.Size = New System.Drawing.Size(54, 13)
        Me.SumLbl.TabIndex = 3
        Me.SumLbl.Text = "Сумма: X"
        '
        'AddtoCheckBtn
        '
        Me.AddtoCheckBtn.Enabled = False
        Me.AddtoCheckBtn.Location = New System.Drawing.Point(112, 284)
        Me.AddtoCheckBtn.Name = "AddtoCheckBtn"
        Me.AddtoCheckBtn.Size = New System.Drawing.Size(75, 23)
        Me.AddtoCheckBtn.TabIndex = 3
        Me.AddtoCheckBtn.Text = "Добавить"
        Me.AddtoCheckBtn.UseVisualStyleBackColor = True
        '
        'DeleteLastBtn
        '
        Me.DeleteLastBtn.Location = New System.Drawing.Point(193, 284)
        Me.DeleteLastBtn.Name = "DeleteLastBtn"
        Me.DeleteLastBtn.Size = New System.Drawing.Size(75, 23)
        Me.DeleteLastBtn.TabIndex = 6
        Me.DeleteLastBtn.TabStop = False
        Me.DeleteLastBtn.Text = "Забой"
        Me.DeleteLastBtn.UseVisualStyleBackColor = True
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 322)
        Me.Controls.Add(Me.DeleteLastBtn)
        Me.Controls.Add(Me.AddtoCheckBtn)
        Me.Controls.Add(Me.QuantityTxt)
        Me.Controls.Add(Me.PriceTxt)
        Me.Controls.Add(Me.SumLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameTagTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PayBtn)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.CheckTxt)
        Me.MaximizeBox = False
        Me.Name = "MainScreen"
        Me.Text = "Окно кассира"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckTxt As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents PayBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTagTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PriceTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantityTxt As TextBox
    Friend WithEvents SumLbl As Label
    Friend WithEvents AddtoCheckBtn As Button
    Friend WithEvents DeleteLastBtn As Button
End Class
