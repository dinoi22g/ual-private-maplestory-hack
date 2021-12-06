<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditKey
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_addkey = New System.Windows.Forms.Button()
        Me.cb_keymode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_autotime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_autokey = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCanel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_addkey
        '
        Me.btn_addkey.Location = New System.Drawing.Point(109, 79)
        Me.btn_addkey.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_addkey.Name = "btn_addkey"
        Me.btn_addkey.Size = New System.Drawing.Size(89, 24)
        Me.btn_addkey.TabIndex = 21
        Me.btn_addkey.Text = "確定"
        Me.btn_addkey.UseVisualStyleBackColor = True
        '
        'cb_keymode
        '
        Me.cb_keymode.FormattingEnabled = True
        Me.cb_keymode.Items.AddRange(New Object() {"長壓", "彈按", "雙擊"})
        Me.cb_keymode.Location = New System.Drawing.Point(55, 48)
        Me.cb_keymode.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_keymode.Name = "cb_keymode"
        Me.cb_keymode.Size = New System.Drawing.Size(247, 23)
        Me.cb_keymode.TabIndex = 20
        Me.cb_keymode.Text = "彈按"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "模式"
        '
        'txt_autotime
        '
        Me.txt_autotime.Location = New System.Drawing.Point(213, 13)
        Me.txt_autotime.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_autotime.Name = "txt_autotime"
        Me.txt_autotime.Size = New System.Drawing.Size(89, 25)
        Me.txt_autotime.TabIndex = 18
        Me.txt_autotime.Text = "10"
        Me.txt_autotime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "間隔"
        '
        'cb_autokey
        '
        Me.cb_autokey.FormattingEnabled = True
        Me.cb_autokey.Location = New System.Drawing.Point(56, 13)
        Me.cb_autokey.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_autokey.Name = "cb_autokey"
        Me.cb_autokey.Size = New System.Drawing.Size(101, 23)
        Me.cb_autokey.TabIndex = 16
        Me.cb_autokey.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "按鍵"
        '
        'btnCanel
        '
        Me.btnCanel.Location = New System.Drawing.Point(206, 79)
        Me.btnCanel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCanel.Name = "btnCanel"
        Me.btnCanel.Size = New System.Drawing.Size(89, 24)
        Me.btnCanel.TabIndex = 21
        Me.btnCanel.Text = "取消"
        Me.btnCanel.UseVisualStyleBackColor = True
        '
        'FormEditKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 108)
        Me.Controls.Add(Me.btnCanel)
        Me.Controls.Add(Me.btn_addkey)
        Me.Controls.Add(Me.cb_keymode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_autotime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_autokey)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditKey"
        Me.ShowIcon = False
        Me.Text = "編輯"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_addkey As System.Windows.Forms.Button
    Friend WithEvents cb_keymode As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_autotime As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cb_autokey As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCanel As System.Windows.Forms.Button
End Class
