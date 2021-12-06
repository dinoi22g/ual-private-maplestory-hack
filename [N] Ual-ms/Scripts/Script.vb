Module script

    '//----------------------------------------------------------------------------------------------
    '//取得人物資訊
    Public GetInfoHook, CurrentHp, CurrentMp, CurrentExp, MaxHp, MaxMp, MaxExp
    Public m_Hp, m_MaxHp, m_Mp, m_MaxMp, m_Exp, m_MaxExp As IntPtr
    Public Sub GetCharInfo(hprocess As Integer)
        GetInfoHook = VirtualAllocEx(hprocess, 0&, &H128, &H1000, 64) '創建主要進程

        '申請空間存放
        CurrentHp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)
        CurrentMp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)
        CurrentExp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)
        MaxHp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)
        MaxMp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)
        MaxExp = VirtualAllocEx(hprocess, 0&, &H8, &H1000, 64)

        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 0, {&H50}, 1, 0) 'push eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 1, {&H8B, &H45, &H8}, 3, 0) 'mov eax,[ebp+08]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 4, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 6, System.BitConverter.GetBytes(CurrentHp.ToInt32), 4, 0) 'mov [CurrentHP],eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 10, {&H8B, &H45, &HC}, 3, 0) 'mov eax,[ebp+0C]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 13, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 15, System.BitConverter.GetBytes(MaxHp.ToInt32), 4, 0) 'mov [MaxHP],eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 19, {&H8B, &H45, &H10}, 3, 0) 'mov eax,[ebp+10]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 22, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 24, System.BitConverter.GetBytes(CurrentMp.ToInt32), 4, 0) 'mov [CurrentMP],eax
        ''//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 28, {&H8B, &H45, &H14}, 3, 0) 'mov eax,[ebp+14]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 31, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 33, System.BitConverter.GetBytes(MaxMp.ToInt32), 4, 0) 'mov [MaxHP],eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 37, {&H8B, &H45, &H18}, 3, 0) 'mov eax,[ebp+18]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 40, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 42, System.BitConverter.GetBytes(CurrentExp.ToInt32), 4, 0) 'mov [CurrentEXP],eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 46, {&H8B, &H45, &H1C}, 3, 0) 'mov eax,[ebp+1C]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 49, {&H89, &H5}, 2, 0) 'mov 
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 51, System.BitConverter.GetBytes(MaxExp.ToInt32), 4, 0) 'mov [MaxEXP],eax
        '//-------------------------------------------------------------------------------------------------------
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 55, {&H58}, 1, 0) 'pop eax
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 56, {&H8D, &HC, &H89}, 3, 0) 'lea ecx,[ecx+ecx*4]
        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 59, {&H85, &HC9}, 2, 0) 'test ecx,ecx

        WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 61, Jmp("00AC0BC3"), 6, 0) 'push 00AC0BC3;ret
        '  WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 62, {&HC3, &HB, &HAC, &H0}, 4, 0) '00AC0BC3
        '  WriteProcessMemory(hprocess, GetInfoHook.ToInt32 + 66, {&HC3}, 1, 0) 'ret
        AsmJump(hprocess, &HAC0BBE, GetInfoHook)

    End Sub

    Public Sub ReadInfo(hprocess As Integer)
        ReadProcessMemoryAPI(hprocess, CurrentHp.ToInt32, m_Hp, 4, False)
        ReadProcessMemoryAPI(hprocess, MaxHp.ToInt32, m_MaxHp, 4, False)
        ReadProcessMemoryAPI(hprocess, CurrentMp.ToInt32, m_Mp, 4, False)
        ReadProcessMemoryAPI(hprocess, MaxMp.ToInt32, m_MaxMp, 4, False)
        ReadProcessMemoryAPI(hprocess, CurrentExp.ToInt32, m_Exp, 4, False)
        ReadProcessMemoryAPI(hprocess, MaxExp.ToInt32, m_MaxExp, 4, False)
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//全職業全圖打
    '卸載:      VirtualFreeEx(p.m_hProcess, script.fma.ToInt32, UBound(script.byteArray) + 1, FreeType.DECOMMIT)
    Public Sub FullMapAttack(hprocess As Integer)
        Dim fma
        Dim byteArray() As Byte = {&H83, &HC4, &H4, &H56, &H8B, &HF1, &HA1, &H34, &H79, &HE, &H1, &H8B, &H80, &H78, &H8D, &H0, &H0, &H50, &H8D, &H4E, &HC, &HC7, &H44, &H24, &HF8, &HE0, &H5F, &H43, &H0, &HFF, &H54, &H24, &HF8, &HA1, &H34, &H79, &HE, &H1, &H8B, &H80, &H7C, &H8D, &H0, &H0, &H50, &H8B, &HCE, &HC7, &H44, &H24, &HF8, &HE0, &H5F, &H43, &H0, &HFF, &H54, &H24, &HF8, &H8B, &HC6, &H5E, &H68, &HDC, &HC2, &H72, &H0, &HC3}
        fma = VirtualAllocEx(hprocess, 0&, 128, &H1000, 64)
        WriteProcessMemory(hprocess, fma.ToInt32 + 0, byteArray, UBound(byteArray) + 1, 0)
        AsmJump(hprocess, &H72C2D7, fma)
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//寵物吸物
    Public Sub PetItemVac(hprocess As Integer)
        Dim pet
        Dim byteArray() As Byte = {&H57, &H8B, &H7D, &HC, &H89, &H1F, &H89, &H47, &H4, &H5F}
        pet = VirtualAllocEx(hprocess, 0&, 128, &H1000, 64)
        WriteProcessMemory(hprocess, pet.ToInt32 + 0, byteArray, UBound(byteArray) + 1, 0)
        WriteProcessMemory(hprocess, pet.ToInt32 + (UBound(byteArray) + 1), Jmp("005681a9"), 6, 0)
        AsmJump(hprocess, &H568188, pet)
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//人物左右
    Public GetFocusAdr As IntPtr = GetProcAddress(GetModuleHandle("user32.dll"), "GetFocus")

    Public Sub AutoLR(hprocess As Integer, lr As Integer) 'lr=1右 , lr=2左
        Dim lrMainAddress = VirtualAllocEx(hprocess, 0&, 128, &H1000, 64)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 0, {&H81, &H3C, &H24, &HCF, &H10, &HC7, &H0, &HF, &H85}, 9, 0)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 9, reverseAddress(Convert.ToString(GetFocusAdr.ToInt32 - lrMainAddress.ToInt32 - 13, 16)), 4, 0)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 13, {&HC7, &H4, &H24}, 3, 0)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 16, reverseAddress(Convert.ToString(lrMainAddress.ToInt32 + 25, 16)), 4, 0)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 20, {&HE9}, 1, 0)
        WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 21, reverseAddress(Convert.ToString(GetFocusAdr.ToInt32 - lrMainAddress.ToInt32 - 25, 16)), 4, 0)
        If lr = 1 Then
            WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 25, {&HC7, &H44, &H24, &H30, &H1, &H0, &H0, &H0, &H68, &HCF, &H13, &HC7, &H0, &HC3}, 14, 0)
        ElseIf lr = 2 Then
            WriteProcessMemory(hprocess, lrMainAddress.ToInt32 + 25, {&HC7, &H44, &H24, &H30, &HFF, &HFF, &HFF, &HFF, &H68, &HCF, &H13, &HC7, &H0, &HC3}, 14, 0)
        End If
        WriteProcessMemoryAPI(hprocess, &H10F5410, lrMainAddress.ToInt32, 4, 0)
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//物品過濾
    Public PtInRectAdr As IntPtr = GetProcAddress(GetModuleHandle("user32.dll"), "PtInRect")
    Public ifMainAddress
    Public Sub ItemFilter(hprocess As Integer)
        ifMainAddress = VirtualAllocEx(hprocess, 0&, 1024, &H1000, 64)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 0, {&H81, &H3C, &H24, &H8C, &H7E, &H56, &H0}, 7, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 7, {&HF, &H85}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 9, {&H7, &H0, &H0, &H0}, 4, 0) '這邊要修改  jne 0A880014
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 13, {&HC7, &H4, &H24}, 3, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 16, reverseAddress(HexLengthToEight(Convert.ToString(ifMainAddress.ToInt32 + &H19, 16))), 4, 0) '這邊要修改 mov [esp],0A880019 : [840FC085]
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 20, {&HE9}, 1, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 21, reverseAddress(HexLengthToEight(Convert.ToString(PtInRectAdr.ToInt32 - ifMainAddress.ToInt32 - 25, 16))), 4, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 25, {&H85, &HC0}, 2, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 27, {&HF, &H84}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 29, reverseAddress(HexLengthToEight(Convert.ToString(&H567E90 - ifMainAddress.ToInt32 - &H21, 16))), 4, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 33, {&H8B, &H46, &H34}, 3, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 36, {&HF, &H84}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 38, reverseAddress(HexLengthToEight(Convert.ToString(&H567EDE - ifMainAddress.ToInt32 - &H2A, 16))), 4, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 42, {&HB9}, 1, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 43, reverseAddress(HexLengthToEight(Convert.ToString(ifMainAddress.ToInt32 + &H4D, 16))), 4, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 47, {&HE9, &H0, &H0, &H0, &H0}, 5, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 52, {&H81, &H39, &H99, &H99, &H99, &H99}, 6, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 58, {&HF, &H84}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 60, reverseAddress(HexLengthToEight(Convert.ToString(&H567EDE - ifMainAddress.ToInt32 - &H40, 16))), 4, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 64, {&H39, &H1}, 2, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 66, {&HF, &H84}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 68, reverseAddress(HexLengthToEight(Convert.ToString(&H567E90 - ifMainAddress.ToInt32 - &H48, 16))), 4, 0)

        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 72, {&H83, &HC1, &H4}, 3, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 75, {&HEB, &HE7}, 2, 0)
        WriteProcessMemory(hprocess, ifMainAddress.ToInt32 + 77, {&H99, &H99, &H99, &H99}, 4, 0) 'BlackList on End

        WriteProcessMemory(hprocess, &H10F53B4, reverseAddress(HexLengthToEight(Convert.ToString(ifMainAddress.ToInt32, 16))), 4, 0)
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//落物撿物無特效
    Public Sub DropAndPickItemNoAni(hprocess As Integer)
        WriteMEMtoString(hprocess, &H4D5577, "90 90 90 90 90 90")
        WriteMEMtoString(hprocess, &H565A25, "25")
        WriteMEMtoString(hprocess, &H45B639, "81 FE 00 00 00 00")
    End Sub
    '//----------------------------------------------------------------------------------------------

    '//----------------------------------------------------------------------------------------------
    '//取得物品XY
    Public ItemX, ItemY
    Public m_ItemX, m_ItemY As Integer
    Public Sub GetItemXY(hprocess As Integer)
        Dim GetItemXYMainAddress = VirtualAllocEx(m_hProcess, 0&, 1024, &H1000, 64)
        ItemX = VirtualAllocEx(m_hProcess, 0&, 4, &H1000, 64)
        ItemY = VirtualAllocEx(m_hProcess, 0&, 4, &H1000, 64)

        Dim PtInRectAdrEx As IntPtr = GetProcAddress(GetModuleHandle("user32.dll"), "PtInRect")

        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 0, {&H81, &H3C, &H24, &H8C, &H7E, &H56, &H0}, 7, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 7, {&HF, &H85}, 2, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 9, BitConverter.GetBytes(PtInRectAdrEx.ToInt32 - GetItemXYMainAddress.ToInt32 - &HD), 4, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 13, {&H50, &H8B, &H44, &H24, &HC, &H89, &H5}, 7, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 20, BitConverter.GetBytes(ItemX.ToInt32), 4, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 24, {&H8B, &H44, &H24, &H10, &H89, &H5}, 6, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 30, BitConverter.GetBytes(ItemY.ToInt32), 4, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 34, {&H58, &HE9}, 2, 0)
        WriteProcessMemory(m_hProcess, GetItemXYMainAddress + 36, BitConverter.GetBytes(PtInRectAdrEx.ToInt32 - GetItemXYMainAddress.ToInt32 - &H28), 4, 0)

        WriteProcessMemory(hprocess, &H10F53B4, reverseAddress(HexLengthToEight(Convert.ToString(GetItemXYMainAddress.ToInt32, 16))), 4, 0)
    End Sub

    Public Sub ReadItemXY(hprocess As Integer)
        ReadProcessMemoryAPI(hprocess, ItemX.ToInt32, m_ItemX, 4, False)
        ReadProcessMemoryAPI(hprocess, ItemY.ToInt32, m_ItemY, 4, False)
    End Sub
End Module
