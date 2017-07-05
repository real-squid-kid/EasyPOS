<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.SellBtn = New System.Windows.Forms.Button()
        Me.GoodsBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.CashierBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SellBtn
        '
        Me.SellBtn.Location = New System.Drawing.Point(12, 13)
        Me.SellBtn.Name = "SellBtn"
        Me.SellBtn.Size = New System.Drawing.Size(223, 43)
        Me.SellBtn.TabIndex = 0
        Me.SellBtn.Text = "Окно кассира"
        Me.SellBtn.UseVisualStyleBackColor = True
        '
        'GoodsBtn
        '
        Me.GoodsBtn.Location = New System.Drawing.Point(12, 111)
        Me.GoodsBtn.Name = "GoodsBtn"
        Me.GoodsBtn.Size = New System.Drawing.Size(223, 43)
        Me.GoodsBtn.TabIndex = 0
        Me.GoodsBtn.Text = "Товары..."
        Me.GoodsBtn.UseVisualStyleBackColor = True
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Location = New System.Drawing.Point(12, 160)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(223, 43)
        Me.SettingsBtn.TabIndex = 0
        Me.SettingsBtn.Text = "Настройка..."
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'CashierBtn
        '
        Me.CashierBtn.Location = New System.Drawing.Point(12, 62)
        Me.CashierBtn.Name = "CashierBtn"
        Me.CashierBtn.Size = New System.Drawing.Size(223, 43)
        Me.CashierBtn.TabIndex = 0
        Me.CashierBtn.Text = "Работа с кассой"
        Me.CashierBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 218)
        Me.Controls.Add(Me.CashierBtn)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.GoodsBtn)
        Me.Controls.Add(Me.SellBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "EasyPOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SellBtn As Button
    Friend WithEvents GoodsBtn As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents CashierBtn As Button
End Class
