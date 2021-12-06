
Module EnableWriteMemory

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                 ||=================================||                                 '
    '                                 ||         功能開關                ||                                 '
    '                                 ||=================================||                                 '

    '
    '完全無敵
    '
    Public Sub OnFullGod(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HBD8ECD, "0F 84")
        If Not enable Then WriteMEMtoString(hProcess, &HBD8ECD, "0F 85")
    End Sub

    '
    '閃爍無敵
    '
    Public Sub OnBlinkGod(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HB92A17, "EB")
        If Not enable Then WriteMEMtoString(hProcess, &HB92A17, "7E")
    End Sub

    '
    '全職業全圖打
    '
    Public Sub OnFullMapAttack(hProcess As Integer, enable As Boolean)
        If enable Then FullMapAttack(hProcess)
        If Not enable Then WriteMEMtoString(hProcess, &H72C2D7, "E8 E4 B8 D1 FF")
    End Sub

    '
    '瞬移跟怪
    '  
    Dim thr_KamiVac As New Threading.Thread(AddressOf KamiVac)
    Public Sub OnKamiVac(hProcess As Integer, enable As Boolean)
        If enable Then thr_KamiVac = New Threading.Thread(AddressOf KamiVac) : thr_KamiVac.IsBackground = True : thr_KamiVac.Start(hProcess)
        If Not enable Then thr_KamiVac.Abort()
    End Sub

    Public Sub KamiVac(text As Object)
        While (1)
            Dim MonsterX As Integer = ReadPointer(text, &H10EC144, {&H28, &H4, &H130, &H24, &H58}, "4byte")
            Dim MonsterY As Integer = ReadPointer(text, &H10EC144, {&H28, &H4, &H130, &H24, &H5C}, "4byte")
            Kami(text, MonsterX, MonsterY)
            Threading.Thread.Sleep(10)
        End While
    End Sub

    '
    '牆值吸怪
    '
    Dim thr_WalkVac As New Threading.Thread(AddressOf WalkVac)
    Dim CharX, CharY As Integer
    Public Sub OnWalkVac(hProcess As Integer, enable As Boolean)
        CharX = ReadPointer(hProcess, Char_Base, {Char_X_Offset}, "4byte")
        CharY = ReadPointer(hProcess, Char_Base, {Char_Y_Offset}, "4byte")
        If enable Then thr_WalkVac = New Threading.Thread(AddressOf WalkVac) : thr_WalkVac.IsBackground = True : thr_WalkVac.Start(hProcess)
        If Not enable Then thr_WalkVac.Abort()
    End Sub

    Public Sub WalkVac(text As Object)
        While (1)
            WritePointer(text, Map_Base, Left_Wall_Offset, CharX) 'left
            WritePointer(text, Map_Base, Top_Wall_Offset, CharY) 'top
            WritePointer(text, Map_Base, Right_Wall_Offset, CharX) 'right
            WritePointer(text, Map_Base, Bottom_Wall_Offset, CharY) 'bottom
            Threading.Thread.Sleep(100)
        End While
    End Sub

    '
    '受擊定怪
    '
    Public Sub OnSetMob(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &H72C172, "75")
        If Not enable Then WriteMEMtoString(hProcess, &H72C172, "74")
    End Sub

    '
    '部分無延遲
    '
    Public Sub OnNoDelay(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HBDBC1F, "C7 85 D0 D6 FF FF 00 00 00 01")
        If Not enable Then WriteMEMtoString(hProcess, &HBDBC1F, "C7 85 D0 D6 FF FF 00 00 00 00")
    End Sub

    '
    '怪物跟隨
    '
    Public Sub OnMobFollowMe(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &H72C289, "09 C0 50 50 50 50 50 50 50 50 6A 08")
        If Not enable Then WriteMEMtoString(hProcess, &H72C289, "33 C0 50 50 50 50 50 50 50 50 6A FF")
    End Sub

    '
    '怪物不回擊
    '
    Public Sub OnMobNoMagic(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HC67620, "C2 0C 00") : WriteMEMtoString(hProcess, &H710D4E, "90 90 90 90 90 90")
        If Not enable Then WriteMEMtoString(hProcess, &HC67620, "51 55 56") : WriteMEMtoString(hProcess, &H710D4E, "33 c0 33 e0 50 c3")
    End Sub

    '
    '寵物吸物
    '
    Public Sub OnPetItemVac(hProcess As Integer, enable As Boolean)
        If enable Then PetItemVac(hProcess) : WriteMEMtoString(hProcess, &H5682A5, "90 90 90") : WriteMEMtoString(hProcess, &H72C438, "90 90 90") : WriteMEMtoString(hProcess, &H7920B6, "90 90 90")
        If Not enable Then WriteMEMtoString(hProcess, &H568188, "50 53 8d 55 cc") : WriteMEMtoString(hProcess, &H5682A5, "68 00 C3") : WriteMEMtoString(hProcess, &H72C438, "68 00 C3") : WriteMEMtoString(hProcess, &H7920B6, "68 00 C3")
    End Sub

    '
    '滑鼠移動
    '
    Dim thr_MouseMove As New Threading.Thread(AddressOf MouseMove)
    Public Sub OnMouseMoveA(hProcess As Integer, enable As Boolean)
        If enable Then thr_MouseMove = New Threading.Thread(AddressOf MouseMove) : thr_MouseMove.IsBackground = True : thr_MouseMove.Start(hProcess)
        If Not enable Then thr_MouseMove.Abort()
    End Sub

    Public Sub MouseMove(text As Object)
        While (1)
            Dim MouseX As Integer = ReadPointer(text, Mouse_Base, {Mouse_Offset, Mouse_X_Offset}, "4byte")
            Dim MouseY As Integer = ReadPointer(text, Mouse_Base, {Mouse_Offset, Mouse_Y_Offset}, "4byte")
            Kami(text, MouseX, MouseY)
            Threading.Thread.Sleep(1)
        End While
    End Sub

    '
    '攻擊不停
    '
    Public Sub OnAttackNoStop(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HB9A160, "EB")
        If Not enable Then WriteMEMtoString(hProcess, &HB9A160, "7E")
    End Sub

    '
    '人物不擊退
    '
    Public Sub OnCharNoKB(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &H8A51DB, "00")
        If Not enable Then WriteMEMtoString(hProcess, &H8A51DB, "01")
    End Sub

    '
    '部分繩上可攻擊
    '
    Public Sub OnSlideAttack(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HBD0FB4, "0F 84")
        If Not enable Then WriteMEMtoString(hProcess, &HBD0FB4, "0F 85")
    End Sub

    '
    '開場動畫移除
    '
    Public Sub OnLogoSkip(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &H6C7D29, "75")
        If Not enable Then WriteMEMtoString(hProcess, &H6C7D29, "74")
    End Sub

    '
    '技能動畫移除
    '
    Public Sub OnSkillNoAni(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &HB79E2F, "0F 85")
        If Not enable Then WriteMEMtoString(hProcess, &HB79E2F, "0F 84")
    End Sub

    '
    '人物變身
    '
    Dim thr_CharMorph As New Threading.Thread(AddressOf CharMorph)
    Dim morphID As Integer
    Public Sub OnCharMorph(hProcess As Integer, enable As Boolean, morphIDx As Integer)
        morphID = morphIDx
        If enable Then thr_CharMorph = New Threading.Thread(AddressOf CharMorph) : thr_CharMorph.IsBackground = True : thr_CharMorph.Start(hProcess)
        If Not enable Then thr_CharMorph.Abort() : WritePointer(hProcess, Char_Base, Morph_Offset, 0)
    End Sub

    Public Sub CharMorph(text As Object)
        While (1)
            WritePointer(text, Char_Base, Morph_Offset, morphID)
            Threading.Thread.Sleep(100)
        End While
    End Sub

    '
    'CPU優化
    '
    Public Sub OnCPUHack(hProcess As Integer, enable As Boolean)
        If enable Then WriteMEMtoString(hProcess, &H6DE1BB, "90 90 90 90 90") : WriteMEMtoString(hProcess, &H6DEEE9, "90 90 90 90 90") : WriteMEMtoString(hProcess, &H6E39F9, "90 90 90 90 90")
        If Not enable Then WriteMEMtoString(hProcess, &H6DE1BB, "E8 E0 CA FF FF") : WriteMEMtoString(hProcess, &H6DEEE9, "EB 52 C4 FF FF") : WriteMEMtoString(hProcess, &H6E39F9, "E8 32 D9 FF FF")
    End Sub

    '                                                                                                       '
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    '
    'Kami (瞬移)
    '
    Public Sub Kami(hprocess As Integer, X As Integer, Y As Integer)
        WritePointer(hprocess, &H10E7934, &H7BC0, X)
        WritePointer(hprocess, &H10E7934, &H7BC4, Y)
        WritePointer(hprocess, &H10E7934, &H7BB8, 1)
    End Sub

    Public Sub FreeVirtualAlloc(hProcess As Integer, lpAddress As Integer, lpSize As Integer)
        VirtualFreeEx(hProcess, lpAddress, lpSize, FreeType.DECOMMIT)
    End Sub
End Module
