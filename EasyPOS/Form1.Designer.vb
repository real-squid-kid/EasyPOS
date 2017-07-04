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
        Me.CashierFormBtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CashierFormBtn
        '
        Me.CashierFormBtn.Location = New System.Drawing.Point(12, 13)
        Me.CashierFormBtn.Name = "CashierFormBtn"
        Me.CashierFormBtn.Size = New System.Drawing.Size(157, 43)
        Me.CashierFormBtn.TabIndex = 0
        Me.CashierFormBtn.Text = "Окно кассира"
        Me.CashierFormBtn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 43)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Товары..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 160)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 43)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Настройка..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 62)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(157, 43)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Работа с кассой"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(181, 218)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CashierFormBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "EasyPOS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CashierFormBtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
