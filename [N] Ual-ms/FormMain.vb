Imports System.Runtime.InteropServices
Imports System.Text
Imports System.ComponentModel
Imports System.Threading

Public Class FormMain
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            If m.WParam.ToInt32 = 1 Then
                If chk_mousemove.Checked = True Then
                    chk_mousemove.Checked = False
                Else
                    chk_mousemove.Checked = True
                End If

            End If
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        UnRegisterHotKey(Handle, 1)
        End
    End Sub

    Public Sub init()
        cb_autokey.Text = "A"
        cb_hp.Text = "PageUp" : cb_mp.Text = "PageDown"
        cb_keymode.Text = "彈按"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegisterHotKey(Handle, 1, Nothing, 115)
        script.GetCharInfo(m_hProcess)
        ' script.GetItemXY(m_hProcess)
        DropAndPickItemNoAni(m_hProcess) '落物撿物無特效，預設    //開啟會斷線，跟物品過濾衝突到
        Dim thread As New Thread(AddressOf GetCharInfo) : thread.IsBackground = True : thread.Start()
        Dim keys_thread As New Thread(AddressOf ProtectionKeys) : keys_thread.IsBackground = True : keys_thread.Start()
        AddKeys(cb_autokey) : AddKeys(cb_hp) : AddKeys(cb_mp)
        ItemFilter(m_hProcess) '物品過濾，但不寫入清單
        init()
    End Sub
    '//----------------------------------------------功能區-----------------------------------------------------------------
    Private Sub chk_fullgod_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fullgod.CheckedChanged
        OnFullGod(m_hProcess, chk_fullgod.Checked)
    End Sub

    Private Sub chk_blinkgod_CheckedChanged(sender As Object, e As EventArgs) Handles chk_blinkgod.CheckedChanged
        OnBlinkGod(m_hProcess, chk_blinkgod.Checked)
    End Sub

    Private Sub chk_fullmapattack_CheckedChanged(sender As Object, e As EventArgs) Handles chk_fullmapattack.CheckedChanged
        OnFullMapAttack(m_hProcess, chk_fullmapattack.Checked)
    End Sub

    Private Sub chk_kamivac_CheckedChanged(sender As Object, e As EventArgs) Handles chk_kamivac.CheckedChanged
        OnKamiVac(m_hProcess, chk_kamivac.Checked)
    End Sub

    Private Sub chk_wallvac_CheckedChanged(sender As Object, e As EventArgs) Handles chk_wallvac.CheckedChanged
        OnWalkVac(m_hProcess, chk_wallvac.Checked)
    End Sub

    Private Sub chk_setmob_CheckedChanged(sender As Object, e As EventArgs) Handles chk_setmob.CheckedChanged
        OnSetMob(m_hProcess, chk_setmob.Checked)
    End Sub

    Private Sub chk_nodelay_CheckedChanged(sender As Object, e As EventArgs) Handles chk_nodelay.CheckedChanged
        OnNoDelay(m_hProcess, chk_nodelay.Checked)
    End Sub

    Private Sub chk_mobfollowi_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mobfollowi.CheckedChanged
        OnMobFollowMe(m_hProcess, chk_mobfollowi.Checked)
    End Sub

    Private Sub chk_mobnoskill_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mobnoskill.CheckedChanged
        OnMobNoMagic(m_hProcess, chk_mobnoskill.Checked)
    End Sub

    Private Sub chk_petitemvac_CheckedChanged(sender As Object, e As EventArgs) Handles chk_petitemvac.CheckedChanged
        OnPetItemVac(m_hProcess, chk_petitemvac.Checked)
    End Sub

    Private Sub chk_mousemove_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mousemove.CheckedChanged
        OnMouseMoveA(m_hProcess, chk_mousemove.Checked)
    End Sub

    Private Sub chk_unattack_CheckedChanged(sender As Object, e As EventArgs) Handles chk_unattack.CheckedChanged
        OnAttackNoStop(m_hProcess, chk_unattack.Checked)
    End Sub

    Private Sub chk_charnokb_CheckedChanged(sender As Object, e As EventArgs) Handles chk_charnokb.CheckedChanged
        OnCharNoKB(m_hProcess, chk_charnokb.Checked)
    End Sub

    Private Sub chk_slideattack_CheckedChanged(sender As Object, e As EventArgs) Handles chk_slideattack.CheckedChanged
        OnSlideAttack(m_hProcess, chk_slideattack.Checked)
    End Sub

    Private Sub chk_logoskip_CheckedChanged(sender As Object, e As EventArgs) Handles chk_logoskip.CheckedChanged
        OnLogoSkip(m_hProcess, chk_logoskip.Checked)
    End Sub

    Private Sub chk_noskillani_CheckedChanged(sender As Object, e As EventArgs) Handles chk_noskillani.CheckedChanged
        OnSkillNoAni(m_hProcess, chk_noskillani.Checked)
    End Sub

    Private Sub chk_chartran_CheckedChanged(sender As Object, e As EventArgs) Handles chk_chartran.CheckedChanged
        OnCharMorph(m_hProcess, chk_chartran.Checked, txt_charran.Text)
    End Sub

    Private Sub chk_cpuhack_CheckedChanged(sender As Object, e As EventArgs) Handles chk_cpuhack.CheckedChanged
        OnCPUHack(m_hProcess, chk_cpuhack.Checked)
    End Sub

    Private Sub btn_tranhelp_Click(sender As Object, e As EventArgs) Handles btn_tranhelp.Click
        FormRanID.Show()
    End Sub

    Public Sub GetCharInfo()
        While (1)
            ReadInfo(m_hProcess)
            pb_hp.MaxValue = m_MaxHp.ToInt32 : pb_hp.Value = m_Hp.ToInt32
            pb_mp.MaxValue = m_MaxMp.ToInt32 : pb_mp.Value = m_Mp.ToInt32
            pb_exp.MaxValue = m_MaxExp.ToInt32 : pb_exp.Value = m_Exp.ToInt32
            WritePointer(m_hProcess, Char_Base, Breath_Offset, 0) '將呼吸鎖為0
            Thread.Sleep(1)
        End While
    End Sub
    '//-------------------------------------------------------------------------------------------------------------------

    '//----------------------------------------------按鍵區-----------------------------------------------------------------
    '
    '血魔保護
    '
    Dim chkHp, chkMp As Boolean
    Dim HpValue, MpValue, HpKey, MpKey As Integer

    Private Sub chk_hp_CheckedChanged(sender As Object, e As EventArgs) Handles chk_hp.CheckedChanged
        chkHp = chk_hp.Checked : HpValue = txt_hp.Text : HpKey = KeysNameToCode(cb_hp.Text)
    End Sub

    Private Sub chk_mp_CheckedChanged(sender As Object, e As EventArgs) Handles chk_mp.CheckedChanged
        chkMp = chk_mp.Checked : MpValue = txt_mp.Text : MpKey = KeysNameToCode(cb_mp.Text)
    End Sub

    Public Sub ProtectionKeys()
        On Error Resume Next
        While (1)
            If chkHp = True Then If m_Hp.ToInt32 < HpValue Then PressKey(m_hWnd, HpKey, 1) : Thread.Sleep(100)
            If chkMp = True Then If m_Mp.ToInt32 < MpValue Then PressKey(m_hWnd, MpKey, 1) : Thread.Sleep(100)
        End While
    End Sub

    '
    '自動按鍵
    '
    Dim thread_keys(999) As Thread
    Dim keys_en(999) As Boolean

    Private Sub btn_addkey_Click(sender As Object, e As EventArgs) Handles btn_addkey.Click
        If ChkAll(cb_autokey.Text, txt_autotime.Text, cb_keymode.Text) Then
            ListViewItemAdd(lsv_autokey, {"", cb_autokey.Text, txt_autotime.Text, cb_keymode.Text})
        Else
            MsgBox("出現錯誤，請確認是否輸入正確", MsgBoxStyle.Critical, "錯誤")
        End If
    End Sub

    Private Sub lsv_autokey_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lsv_autokey.ItemChecked
        Dim i As Integer = e.Item.Index
        If e.Item.Checked = True Then
            Dim str As String = i & "," & KeysNameToCode(e.Item.SubItems(1).Text) & "," & e.Item.SubItems(2).Text & "," & e.Item.SubItems(3).Text
            keys_en(i) = True
            thread_keys(i) = New Thread(AddressOf AutoKeys)
            thread_keys(i).IsBackground = True
            thread_keys(i).Start(str)
        ElseIf e.Item.Checked = False Then
            keys_en(i) = False
        End If
    End Sub

    Private Sub 編輯EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 編輯EToolStripMenuItem.Click
        Try
            Dim sel As Integer = lsv_autokey.SelectedIndices(0)
            FormEditKey.cb_autokey.Text = lsv_autokey.Items.Item(sel).SubItems(1).Text
            FormEditKey.txt_autotime.Text = lsv_autokey.Items.Item(sel).SubItems(2).Text
            FormEditKey.cb_keymode.Text = lsv_autokey.Items.Item(sel).SubItems(3).Text
            FormEditKey.selindexA = sel
            FormEditKey.Show()
        Catch
            MsgBox("請選擇一個項目", MsgBoxStyle.Critical, "錯誤")
        End Try
    End Sub

    Private Sub 刪除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刪除DToolStripMenuItem.Click
        Try
            Dim sel As Integer = lsv_autokey.SelectedIndices(0)
            lsv_autokey.Items.Item(sel).Remove()
        Catch ex As Exception
            MsgBox("請選擇一個項目", MsgBoxStyle.Critical, "錯誤")
        End Try
    End Sub

    Public Sub AutoKeys(str As String)
        Dim spStr() As String = Split(str, ",") '0=index,1=按鍵,2=延遲時間,3=模式
        While (keys_en(spStr(0)))
            Select Case spStr(3)
                Case "長壓"
                    PressKey(m_hWnd, spStr(1), 1)
                    Exit Select
                Case "彈按"
                    PressKey(m_hWnd, spStr(1), 2)
                    Exit Select
                Case "雙擊"
                    PressKey(m_hWnd, spStr(1), 3)
                    Exit Select
            End Select
            Thread.Sleep(spStr(2))
        End While
    End Sub
    '//-------------------------------------------------------------------------------------------------------------------

    '//----------------------------------------------過濾區-----------------------------------------------------------------
    Private Sub txt_itemfilter_TextChanged(sender As Object, e As EventArgs) Handles txt_itemfilter.TextChanged
        Dim result As String
        If IsNumeric(txt_itemfilter.Text) Then
            result = GetINI("Item", txt_itemfilter.Text, "Items.ini")
        Else
            result = "NULL"
        End If
        If result = "NULL" Then btn_additem.Enabled = False Else btn_additem.Enabled = True
        lblItemName.Text = result
    End Sub

    Public Function ChkItem(item As String) As Boolean
        For m = 0 To lsv_itemfilter.Items.Count - 1
            If item = lsv_itemfilter.Items.Item(m).SubItems(0).Text Then Return False
        Next
        Return True
    End Function

    Public Sub CleanAll()
        For k = 0 To 128
            WriteProcessMemory(m_hProcess, ifMainAddress.ToInt32 + &H4D + k, {&H0}, 1, 0)
        Next
    End Sub

    Public Sub AddFilter()
        Dim bIndex As Integer = 0
        For m = 0 To lsv_itemfilter.Items.Count - 1
            Dim hexItem As String = lsv_itemfilter.Items.Item(m).SubItems(0).Text
            For k = 6 To 0 Step -2
                WriteProcessMemory(m_hProcess, ifMainAddress.ToInt32 + &H4D + bIndex, {"&H" + hexItem.Substring(k, 2)}, 1, 0)
                bIndex += 1
            Next
        Next

        WriteProcessMemory(m_hProcess, ifMainAddress.ToInt32 + &H4D + bIndex, {&H99, &H99, &H99, &H99}, 4, 0)
    End Sub

    Private Sub btn_additem_Click(sender As Object, e As EventArgs) Handles btn_additem.Click
        If ChkItem(txt_itemfilter.Text) Then
            ListViewItemAdd(lsv_itemfilter, {HexLengthToEight(Convert.ToString(CInt(txt_itemfilter.Text), 16)), lblItemName.Text})
            CleanAll()
            AddFilter()
        Else
            MsgBox("清單中已有此物品", MsgBoxStyle.Critical, "錯誤")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Try
            Dim sel As Integer = lsv_itemfilter.SelectedIndices(0)
            lsv_itemfilter.Items.Item(sel).Remove()
            CleanAll()
            AddFilter()
        Catch ex As Exception
            MsgBox("請選擇一個項目", MsgBoxStyle.Critical, "錯誤")
        End Try
    End Sub
    '//-------------------------------------------------------------------------------------------------------------------
End Class