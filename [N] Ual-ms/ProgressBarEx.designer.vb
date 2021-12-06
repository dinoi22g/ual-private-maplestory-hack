<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgressBarEx
    Inherits System.Windows.Forms.UserControl

    'UserControl 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.progress_back = New System.Windows.Forms.Panel()
        Me.progress_value = New System.Windows.Forms.Panel()
        Me.progress_back.SuspendLayout()
        Me.SuspendLayout()
        '
        'progress_back
        '
        Me.progress_back.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progress_back.BackColor = System.Drawing.Color.LightCyan
        Me.progress_back.Controls.Add(Me.progress_value)
        Me.progress_back.Location = New System.Drawing.Point(0, 0)
        Me.progress_back.Name = "progress_back"
        Me.progress_back.Size = New System.Drawing.Size(212, 28)
        Me.progress_back.TabIndex = 0
        '
        'progress_value
        '
        Me.progress_value.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.progress_value.BackColor = System.Drawing.Color.Red
        Me.progress_value.Location = New System.Drawing.Point(0, 0)
        Me.progress_value.Name = "progress_value"
        Me.progress_value.Size = New System.Drawing.Size(10, 32)
        Me.progress_value.TabIndex = 0
        '
        'ProgressBarEx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.progress_back)
        Me.Name = "ProgressBarEx"
        Me.Size = New System.Drawing.Size(224, 28)
        Me.progress_back.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents progress_back As Panel
    Friend WithEvents progress_value As Panel
End Class
