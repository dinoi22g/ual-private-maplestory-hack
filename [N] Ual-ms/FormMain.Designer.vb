<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_charran = New System.Windows.Forms.TextBox()
        Me.btn_tranhelp = New System.Windows.Forms.Button()
        Me.chk_chartran = New System.Windows.Forms.CheckBox()
        Me.chk_noskillani = New System.Windows.Forms.CheckBox()
        Me.chk_logoskip = New System.Windows.Forms.CheckBox()
        Me.chk_slideattack = New System.Windows.Forms.CheckBox()
        Me.chk_charnokb = New System.Windows.Forms.CheckBox()
        Me.chk_unattack = New System.Windows.Forms.CheckBox()
        Me.chk_mousemove = New System.Windows.Forms.CheckBox()
        Me.chk_petitemvac = New System.Windows.Forms.CheckBox()
        Me.chk_mobnoskill = New System.Windows.Forms.CheckBox()
        Me.chk_cpuhack = New System.Windows.Forms.CheckBox()
        Me.chk_mobfollowi = New System.Windows.Forms.CheckBox()
        Me.chk_nodelay = New System.Windows.Forms.CheckBox()
        Me.chk_setmob = New System.Windows.Forms.CheckBox()
        Me.chk_wallvac = New System.Windows.Forms.CheckBox()
        Me.chk_kamivac = New System.Windows.Forms.CheckBox()
        Me.chk_fullmapattack = New System.Windows.Forms.CheckBox()
        Me.chk_blinkgod = New System.Windows.Forms.CheckBox()
        Me.chk_fullgod = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_addkey = New System.Windows.Forms.Button()
        Me.cb_keymode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_autotime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_autokey = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lsv_autokey = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_autokey = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.編輯EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刪除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_mp = New System.Windows.Forms.ComboBox()
        Me.cb_hp = New System.Windows.Forms.ComboBox()
        Me.txt_mp = New System.Windows.Forms.TextBox()
        Me.txt_hp = New System.Windows.Forms.TextBox()
        Me.chk_mp = New System.Windows.Forms.CheckBox()
        Me.chk_hp = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_additem = New System.Windows.Forms.Button()
        Me.txt_itemfilter = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lsv_itemfilter = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_itemfilter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pb_exp = New _N__Ual_ms.ProgressBarEx()
        Me.pb_mp = New _N__Ual_ms.ProgressBarEx()
        Me.pb_hp = New _N__Ual_ms.ProgressBarEx()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.cms_autokey.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.cms_itemfilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(6, 4)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 459)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(332, 425)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  功能"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_charran)
        Me.GroupBox1.Controls.Add(Me.btn_tranhelp)
        Me.GroupBox1.Controls.Add(Me.chk_chartran)
        Me.GroupBox1.Controls.Add(Me.chk_noskillani)
        Me.GroupBox1.Controls.Add(Me.chk_logoskip)
        Me.GroupBox1.Controls.Add(Me.chk_slideattack)
        Me.GroupBox1.Controls.Add(Me.chk_charnokb)
        Me.GroupBox1.Controls.Add(Me.chk_unattack)
        Me.GroupBox1.Controls.Add(Me.chk_mousemove)
        Me.GroupBox1.Controls.Add(Me.chk_petitemvac)
        Me.GroupBox1.Controls.Add(Me.chk_mobnoskill)
        Me.GroupBox1.Controls.Add(Me.chk_cpuhack)
        Me.GroupBox1.Controls.Add(Me.chk_mobfollowi)
        Me.GroupBox1.Controls.Add(Me.chk_nodelay)
        Me.GroupBox1.Controls.Add(Me.chk_setmob)
        Me.GroupBox1.Controls.Add(Me.chk_wallvac)
        Me.GroupBox1.Controls.Add(Me.chk_kamivac)
        Me.GroupBox1.Controls.Add(Me.chk_fullmapattack)
        Me.GroupBox1.Controls.Add(Me.chk_blinkgod)
        Me.GroupBox1.Controls.Add(Me.chk_fullgod)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(327, 412)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txt_charran
        '
        Me.txt_charran.Enabled = False
        Me.txt_charran.Location = New System.Drawing.Point(176, 250)
        Me.txt_charran.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_charran.Name = "txt_charran"
        Me.txt_charran.Size = New System.Drawing.Size(120, 25)
        Me.txt_charran.TabIndex = 25
        Me.txt_charran.Text = "0000"
        Me.txt_charran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_tranhelp
        '
        Me.btn_tranhelp.Location = New System.Drawing.Point(111, 250)
        Me.btn_tranhelp.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_tranhelp.Name = "btn_tranhelp"
        Me.btn_tranhelp.Size = New System.Drawing.Size(59, 25)
        Me.btn_tranhelp.TabIndex = 24
        Me.btn_tranhelp.Text = "選擇"
        Me.btn_tranhelp.UseVisualStyleBackColor = True
        '
        'chk_chartran
        '
        Me.chk_chartran.AutoSize = True
        Me.chk_chartran.Location = New System.Drawing.Point(19, 254)
        Me.chk_chartran.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_chartran.Name = "chk_chartran"
        Me.chk_chartran.Size = New System.Drawing.Size(89, 19)
        Me.chk_chartran.TabIndex = 22
        Me.chk_chartran.Text = "人物變身"
        Me.chk_chartran.UseVisualStyleBackColor = True
        '
        'chk_noskillani
        '
        Me.chk_noskillani.AutoSize = True
        Me.chk_noskillani.Location = New System.Drawing.Point(179, 221)
        Me.chk_noskillani.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_noskillani.Name = "chk_noskillani"
        Me.chk_noskillani.Size = New System.Drawing.Size(119, 19)
        Me.chk_noskillani.TabIndex = 19
        Me.chk_noskillani.Text = "技能動畫移除"
        Me.chk_noskillani.UseVisualStyleBackColor = True
        '
        'chk_logoskip
        '
        Me.chk_logoskip.AutoSize = True
        Me.chk_logoskip.Location = New System.Drawing.Point(19, 221)
        Me.chk_logoskip.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_logoskip.Name = "chk_logoskip"
        Me.chk_logoskip.Size = New System.Drawing.Size(119, 19)
        Me.chk_logoskip.TabIndex = 18
        Me.chk_logoskip.Text = "開場動畫移除"
        Me.chk_logoskip.UseVisualStyleBackColor = True
        '
        'chk_slideattack
        '
        Me.chk_slideattack.AutoSize = True
        Me.chk_slideattack.Enabled = False
        Me.chk_slideattack.Location = New System.Drawing.Point(179, 194)
        Me.chk_slideattack.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_slideattack.Name = "chk_slideattack"
        Me.chk_slideattack.Size = New System.Drawing.Size(119, 19)
        Me.chk_slideattack.TabIndex = 15
        Me.chk_slideattack.Text = "部分繩上攻擊"
        Me.chk_slideattack.UseVisualStyleBackColor = True
        '
        'chk_charnokb
        '
        Me.chk_charnokb.AutoSize = True
        Me.chk_charnokb.Location = New System.Drawing.Point(20, 194)
        Me.chk_charnokb.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_charnokb.Name = "chk_charnokb"
        Me.chk_charnokb.Size = New System.Drawing.Size(104, 19)
        Me.chk_charnokb.TabIndex = 14
        Me.chk_charnokb.Text = "人物不擊退"
        Me.chk_charnokb.UseVisualStyleBackColor = True
        '
        'chk_unattack
        '
        Me.chk_unattack.AutoSize = True
        Me.chk_unattack.Location = New System.Drawing.Point(179, 166)
        Me.chk_unattack.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_unattack.Name = "chk_unattack"
        Me.chk_unattack.Size = New System.Drawing.Size(89, 19)
        Me.chk_unattack.TabIndex = 13
        Me.chk_unattack.Text = "攻擊不停"
        Me.chk_unattack.UseVisualStyleBackColor = True
        '
        'chk_mousemove
        '
        Me.chk_mousemove.AutoSize = True
        Me.chk_mousemove.Location = New System.Drawing.Point(20, 166)
        Me.chk_mousemove.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_mousemove.Name = "chk_mousemove"
        Me.chk_mousemove.Size = New System.Drawing.Size(118, 19)
        Me.chk_mousemove.TabIndex = 12
        Me.chk_mousemove.Text = "滑鼠移動 [F4]"
        Me.chk_mousemove.UseVisualStyleBackColor = True
        '
        'chk_petitemvac
        '
        Me.chk_petitemvac.AutoSize = True
        Me.chk_petitemvac.Location = New System.Drawing.Point(179, 139)
        Me.chk_petitemvac.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_petitemvac.Name = "chk_petitemvac"
        Me.chk_petitemvac.Size = New System.Drawing.Size(89, 19)
        Me.chk_petitemvac.TabIndex = 11
        Me.chk_petitemvac.Text = "寵物吸物"
        Me.chk_petitemvac.UseVisualStyleBackColor = True
        '
        'chk_mobnoskill
        '
        Me.chk_mobnoskill.AutoSize = True
        Me.chk_mobnoskill.Location = New System.Drawing.Point(20, 139)
        Me.chk_mobnoskill.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_mobnoskill.Name = "chk_mobnoskill"
        Me.chk_mobnoskill.Size = New System.Drawing.Size(104, 19)
        Me.chk_mobnoskill.TabIndex = 10
        Me.chk_mobnoskill.Text = "怪物不回擊"
        Me.chk_mobnoskill.UseVisualStyleBackColor = True
        '
        'chk_cpuhack
        '
        Me.chk_cpuhack.AutoSize = True
        Me.chk_cpuhack.Location = New System.Drawing.Point(208, 385)
        Me.chk_cpuhack.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_cpuhack.Name = "chk_cpuhack"
        Me.chk_cpuhack.Size = New System.Drawing.Size(90, 19)
        Me.chk_cpuhack.TabIndex = 9
        Me.chk_cpuhack.Text = "CPU 優化"
        Me.chk_cpuhack.UseVisualStyleBackColor = True
        '
        'chk_mobfollowi
        '
        Me.chk_mobfollowi.AutoSize = True
        Me.chk_mobfollowi.Location = New System.Drawing.Point(179, 111)
        Me.chk_mobfollowi.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_mobfollowi.Name = "chk_mobfollowi"
        Me.chk_mobfollowi.Size = New System.Drawing.Size(89, 19)
        Me.chk_mobfollowi.TabIndex = 7
        Me.chk_mobfollowi.Text = "怪物跟隨"
        Me.chk_mobfollowi.UseVisualStyleBackColor = True
        '
        'chk_nodelay
        '
        Me.chk_nodelay.AutoSize = True
        Me.chk_nodelay.Location = New System.Drawing.Point(20, 111)
        Me.chk_nodelay.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_nodelay.Name = "chk_nodelay"
        Me.chk_nodelay.Size = New System.Drawing.Size(104, 19)
        Me.chk_nodelay.TabIndex = 6
        Me.chk_nodelay.Text = "部分無延遲"
        Me.chk_nodelay.UseVisualStyleBackColor = True
        '
        'chk_setmob
        '
        Me.chk_setmob.AutoSize = True
        Me.chk_setmob.Location = New System.Drawing.Point(179, 84)
        Me.chk_setmob.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_setmob.Name = "chk_setmob"
        Me.chk_setmob.Size = New System.Drawing.Size(89, 19)
        Me.chk_setmob.TabIndex = 5
        Me.chk_setmob.Text = "受擊定怪"
        Me.chk_setmob.UseVisualStyleBackColor = True
        '
        'chk_wallvac
        '
        Me.chk_wallvac.AutoSize = True
        Me.chk_wallvac.Location = New System.Drawing.Point(20, 84)
        Me.chk_wallvac.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_wallvac.Name = "chk_wallvac"
        Me.chk_wallvac.Size = New System.Drawing.Size(144, 19)
        Me.chk_wallvac.TabIndex = 4
        Me.chk_wallvac.Text = "牆值吸怪(需清怪)"
        Me.chk_wallvac.UseVisualStyleBackColor = True
        '
        'chk_kamivac
        '
        Me.chk_kamivac.AutoSize = True
        Me.chk_kamivac.Location = New System.Drawing.Point(179, 56)
        Me.chk_kamivac.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_kamivac.Name = "chk_kamivac"
        Me.chk_kamivac.Size = New System.Drawing.Size(89, 19)
        Me.chk_kamivac.TabIndex = 3
        Me.chk_kamivac.Text = "瞬移跟怪"
        Me.chk_kamivac.UseVisualStyleBackColor = True
        '
        'chk_fullmapattack
        '
        Me.chk_fullmapattack.AutoSize = True
        Me.chk_fullmapattack.Location = New System.Drawing.Point(20, 56)
        Me.chk_fullmapattack.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_fullmapattack.Name = "chk_fullmapattack"
        Me.chk_fullmapattack.Size = New System.Drawing.Size(119, 19)
        Me.chk_fullmapattack.TabIndex = 2
        Me.chk_fullmapattack.Text = "全職業全圖打"
        Me.chk_fullmapattack.UseVisualStyleBackColor = True
        '
        'chk_blinkgod
        '
        Me.chk_blinkgod.AutoSize = True
        Me.chk_blinkgod.Location = New System.Drawing.Point(179, 29)
        Me.chk_blinkgod.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_blinkgod.Name = "chk_blinkgod"
        Me.chk_blinkgod.Size = New System.Drawing.Size(89, 19)
        Me.chk_blinkgod.TabIndex = 1
        Me.chk_blinkgod.Text = "閃爍無敵"
        Me.chk_blinkgod.UseVisualStyleBackColor = True
        '
        'chk_fullgod
        '
        Me.chk_fullgod.AutoSize = True
        Me.chk_fullgod.Location = New System.Drawing.Point(20, 29)
        Me.chk_fullgod.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_fullgod.Name = "chk_fullgod"
        Me.chk_fullgod.Size = New System.Drawing.Size(89, 19)
        Me.chk_fullgod.TabIndex = 0
        Me.chk_fullgod.Text = "完全無敵"
        Me.chk_fullgod.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(332, 425)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  按鍵"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_addkey)
        Me.GroupBox2.Controls.Add(Me.cb_keymode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_autotime)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cb_autokey)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lsv_autokey)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cb_mp)
        Me.GroupBox2.Controls.Add(Me.cb_hp)
        Me.GroupBox2.Controls.Add(Me.txt_mp)
        Me.GroupBox2.Controls.Add(Me.txt_hp)
        Me.GroupBox2.Controls.Add(Me.chk_mp)
        Me.GroupBox2.Controls.Add(Me.chk_hp)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(327, 412)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'btn_addkey
        '
        Me.btn_addkey.Location = New System.Drawing.Point(220, 130)
        Me.btn_addkey.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_addkey.Name = "btn_addkey"
        Me.btn_addkey.Size = New System.Drawing.Size(89, 25)
        Me.btn_addkey.TabIndex = 14
        Me.btn_addkey.Text = "新增"
        Me.btn_addkey.UseVisualStyleBackColor = True
        '
        'cb_keymode
        '
        Me.cb_keymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_keymode.FormattingEnabled = True
        Me.cb_keymode.Items.AddRange(New Object() {"長壓", "彈按", "雙擊"})
        Me.cb_keymode.Location = New System.Drawing.Point(63, 130)
        Me.cb_keymode.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_keymode.Name = "cb_keymode"
        Me.cb_keymode.Size = New System.Drawing.Size(148, 23)
        Me.cb_keymode.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 136)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "模式"
        '
        'txt_autotime
        '
        Me.txt_autotime.Location = New System.Drawing.Point(220, 98)
        Me.txt_autotime.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_autotime.Name = "txt_autotime"
        Me.txt_autotime.Size = New System.Drawing.Size(89, 25)
        Me.txt_autotime.TabIndex = 11
        Me.txt_autotime.Text = "10"
        Me.txt_autotime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "間隔"
        '
        'cb_autokey
        '
        Me.cb_autokey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_autokey.FormattingEnabled = True
        Me.cb_autokey.Location = New System.Drawing.Point(63, 98)
        Me.cb_autokey.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_autokey.Name = "cb_autokey"
        Me.cb_autokey.Size = New System.Drawing.Size(101, 23)
        Me.cb_autokey.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "按鍵"
        '
        'lsv_autokey
        '
        Me.lsv_autokey.CheckBoxes = True
        Me.lsv_autokey.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsv_autokey.ContextMenuStrip = Me.cms_autokey
        Me.lsv_autokey.FullRowSelect = True
        Me.lsv_autokey.Location = New System.Drawing.Point(8, 160)
        Me.lsv_autokey.Margin = New System.Windows.Forms.Padding(4)
        Me.lsv_autokey.Name = "lsv_autokey"
        Me.lsv_autokey.Size = New System.Drawing.Size(309, 244)
        Me.lsv_autokey.TabIndex = 7
        Me.lsv_autokey.UseCompatibleStateImageBehavior = False
        Me.lsv_autokey.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "  "
        Me.ColumnHeader1.Width = 33
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "按鍵"
        Me.ColumnHeader2.Width = 80
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "間隔(ms)"
        Me.ColumnHeader3.Width = 93
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "模式"
        Me.ColumnHeader4.Width = 91
        '
        'cms_autokey
        '
        Me.cms_autokey.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.編輯EToolStripMenuItem, Me.刪除DToolStripMenuItem})
        Me.cms_autokey.Name = "cms_autokey"
        Me.cms_autokey.Size = New System.Drawing.Size(130, 52)
        '
        '編輯EToolStripMenuItem
        '
        Me.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem"
        Me.編輯EToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.編輯EToolStripMenuItem.Text = "編輯(&E)"
        '
        '刪除DToolStripMenuItem
        '
        Me.刪除DToolStripMenuItem.Name = "刪除DToolStripMenuItem"
        Me.刪除DToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.刪除DToolStripMenuItem.Text = "刪除(&D)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(21, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(308, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "___________________________________________"
        '
        'cb_mp
        '
        Me.cb_mp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mp.FormattingEnabled = True
        Me.cb_mp.Location = New System.Drawing.Point(175, 51)
        Me.cb_mp.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_mp.Name = "cb_mp"
        Me.cb_mp.Size = New System.Drawing.Size(135, 23)
        Me.cb_mp.TabIndex = 5
        '
        'cb_hp
        '
        Me.cb_hp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_hp.FormattingEnabled = True
        Me.cb_hp.Location = New System.Drawing.Point(175, 19)
        Me.cb_hp.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_hp.Name = "cb_hp"
        Me.cb_hp.Size = New System.Drawing.Size(135, 23)
        Me.cb_hp.TabIndex = 4
        '
        'txt_mp
        '
        Me.txt_mp.Location = New System.Drawing.Point(108, 51)
        Me.txt_mp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_mp.Name = "txt_mp"
        Me.txt_mp.Size = New System.Drawing.Size(57, 25)
        Me.txt_mp.TabIndex = 3
        Me.txt_mp.Text = "1000"
        Me.txt_mp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_hp
        '
        Me.txt_hp.Location = New System.Drawing.Point(108, 19)
        Me.txt_hp.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_hp.Name = "txt_hp"
        Me.txt_hp.Size = New System.Drawing.Size(57, 25)
        Me.txt_hp.TabIndex = 2
        Me.txt_hp.Text = "200"
        Me.txt_hp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chk_mp
        '
        Me.chk_mp.AutoSize = True
        Me.chk_mp.Location = New System.Drawing.Point(24, 54)
        Me.chk_mp.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_mp.Name = "chk_mp"
        Me.chk_mp.Size = New System.Drawing.Size(71, 19)
        Me.chk_mp.TabIndex = 1
        Me.chk_mp.Text = "魔量 <"
        Me.chk_mp.UseVisualStyleBackColor = True
        '
        'chk_hp
        '
        Me.chk_hp.AutoSize = True
        Me.chk_hp.Location = New System.Drawing.Point(24, 26)
        Me.chk_hp.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_hp.Name = "chk_hp"
        Me.chk_hp.Size = New System.Drawing.Size(71, 19)
        Me.chk_hp.TabIndex = 0
        Me.chk_hp.Text = "血量 <"
        Me.chk_hp.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(332, 425)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "  過濾"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblItemName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btn_additem)
        Me.GroupBox3.Controls.Add(Me.txt_itemfilter)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.lsv_itemfilter)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(327, 412)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Location = New System.Drawing.Point(59, 55)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(67, 15)
        Me.lblItemName.TabIndex = 7
        Me.lblItemName.Text = "------------"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = ">>>   "
        '
        'btn_additem
        '
        Me.btn_additem.Enabled = False
        Me.btn_additem.Location = New System.Drawing.Point(248, 18)
        Me.btn_additem.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_additem.Name = "btn_additem"
        Me.btn_additem.Size = New System.Drawing.Size(67, 29)
        Me.btn_additem.TabIndex = 5
        Me.btn_additem.Text = "添加"
        Me.btn_additem.UseVisualStyleBackColor = True
        '
        'txt_itemfilter
        '
        Me.txt_itemfilter.Location = New System.Drawing.Point(135, 19)
        Me.txt_itemfilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_itemfilter.Name = "txt_itemfilter"
        Me.txt_itemfilter.Size = New System.Drawing.Size(104, 25)
        Me.txt_itemfilter.TabIndex = 4
        Me.txt_itemfilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 26)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "請輸入物品編號"
        '
        'lsv_itemfilter
        '
        Me.lsv_itemfilter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsv_itemfilter.ContextMenuStrip = Me.cms_itemfilter
        Me.lsv_itemfilter.FullRowSelect = True
        Me.lsv_itemfilter.Location = New System.Drawing.Point(8, 74)
        Me.lsv_itemfilter.Margin = New System.Windows.Forms.Padding(4)
        Me.lsv_itemfilter.Name = "lsv_itemfilter"
        Me.lsv_itemfilter.Size = New System.Drawing.Size(309, 330)
        Me.lsv_itemfilter.TabIndex = 2
        Me.lsv_itemfilter.UseCompatibleStateImageBehavior = False
        Me.lsv_itemfilter.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "編號"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "名稱"
        Me.ColumnHeader6.Width = 200
        '
        'cms_itemfilter
        '
        Me.cms_itemfilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.cms_itemfilter.Name = "cms_autokey"
        Me.cms_itemfilter.Size = New System.Drawing.Size(130, 28)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(129, 24)
        Me.ToolStripMenuItem2.Text = "刪除(&D)"
        '
        'pb_exp
        '
        Me.pb_exp.Back_Backcolor = "224,255,255"
        Me.pb_exp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_exp.displayMoudle = "1"
        Me.pb_exp.Location = New System.Drawing.Point(21, 511)
        Me.pb_exp.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_exp.MaxValue = "100"
        Me.pb_exp.Name = "pb_exp"
        Me.pb_exp.ProgressBar_Color = "0,0,0"
        Me.pb_exp.Size = New System.Drawing.Size(326, 23)
        Me.pb_exp.styleMoudle = "1"
        Me.pb_exp.TabIndex = 3
        Me.pb_exp.Value = "0"
        Me.pb_exp.Value_Backcolor = "30,255,30"
        '
        'pb_mp
        '
        Me.pb_mp.Back_Backcolor = "224,255,255"
        Me.pb_mp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_mp.displayMoudle = "2"
        Me.pb_mp.Location = New System.Drawing.Point(184, 480)
        Me.pb_mp.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_mp.MaxValue = "100"
        Me.pb_mp.Name = "pb_mp"
        Me.pb_mp.ProgressBar_Color = "0,0,0"
        Me.pb_mp.Size = New System.Drawing.Size(163, 23)
        Me.pb_mp.styleMoudle = "1"
        Me.pb_mp.TabIndex = 2
        Me.pb_mp.Value = "0"
        Me.pb_mp.Value_Backcolor = "28,255,255"
        '
        'pb_hp
        '
        Me.pb_hp.Back_Backcolor = "224,255,255"
        Me.pb_hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_hp.displayMoudle = "2"
        Me.pb_hp.Location = New System.Drawing.Point(21, 480)
        Me.pb_hp.Margin = New System.Windows.Forms.Padding(5)
        Me.pb_hp.MaxValue = "100"
        Me.pb_hp.Name = "pb_hp"
        Me.pb_hp.ProgressBar_Color = "0,0,0"
        Me.pb_hp.Size = New System.Drawing.Size(154, 23)
        Me.pb_hp.styleMoudle = "1"
        Me.pb_hp.TabIndex = 1
        Me.pb_hp.Value = "0"
        Me.pb_hp.Value_Backcolor = "255,59,59"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 545)
        Me.Controls.Add(Me.pb_exp)
        Me.Controls.Add(Me.pb_mp)
        Me.Controls.Add(Me.pb_hp)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Text = "Ual-ms"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.cms_autokey.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.cms_itemfilter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_blinkgod As CheckBox
    Friend WithEvents chk_fullgod As CheckBox
    Friend WithEvents chk_wallvac As CheckBox
    Friend WithEvents chk_kamivac As CheckBox
    Friend WithEvents chk_fullmapattack As CheckBox
    Friend WithEvents chk_mobfollowi As CheckBox
    Friend WithEvents chk_nodelay As CheckBox
    Friend WithEvents chk_setmob As CheckBox
    Friend WithEvents chk_cpuhack As CheckBox
    Friend WithEvents chk_mobnoskill As CheckBox
    Friend WithEvents chk_petitemvac As CheckBox
    Friend WithEvents chk_mousemove As CheckBox
    Friend WithEvents chk_unattack As CheckBox
    Friend WithEvents chk_charnokb As CheckBox
    Friend WithEvents chk_slideattack As CheckBox
    Friend WithEvents chk_logoskip As CheckBox
    Friend WithEvents chk_noskillani As CheckBox
    Friend WithEvents chk_chartran As CheckBox
    Friend WithEvents btn_tranhelp As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_mp As ComboBox
    Friend WithEvents cb_hp As ComboBox
    Friend WithEvents txt_mp As TextBox
    Friend WithEvents txt_hp As TextBox
    Friend WithEvents chk_mp As CheckBox
    Friend WithEvents chk_hp As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lsv_autokey As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txt_autotime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_autokey As ComboBox
    Friend WithEvents cb_keymode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_addkey As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lsv_itemfilter As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_additem As Button
    Friend WithEvents txt_itemfilter As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_charran As System.Windows.Forms.TextBox
    Friend WithEvents pb_hp As _N__Ual_ms.ProgressBarEx
    Friend WithEvents pb_mp As _N__Ual_ms.ProgressBarEx
    Friend WithEvents pb_exp As _N__Ual_ms.ProgressBarEx
    Friend WithEvents lblItemName As System.Windows.Forms.Label
    Friend WithEvents cms_autokey As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 編輯EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 刪除DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_itemfilter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
End Class
