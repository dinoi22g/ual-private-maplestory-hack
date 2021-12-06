Imports System.Text
Module FunctionAx
    '=======================================================================================
    '=========================================進程管理======================================
    '=======================================================================================
    Public m_hProcess, m_hWnd, m_pID As Integer
    Public m_Handle As Long
    Public m_WindowTitle As String

    Public Function OpenProcess(Optional ByVal lpPID As Long = -1) As Long
        OpenProcess = 0
        If lpPID = 0 And m_pID = 0 Then Exit Function
        If lpPID > 0 And m_pID = 0 Then m_pID = lpPID
        m_Handle = OpenProcessAPI(PROCESS_ALL_ACCESS, False, m_pID)
        Return m_Handle
    End Function

    Public Function OpenProcessByWindow() As Long
        OpenProcessByWindow = OpenProcess(m_pID)
        m_hProcess = OpenProcessAPI(PROCESS_ALL_ACCESS, False, m_pID)
    End Function
    '=======================================================================================

    '=======================================================================================
    '=========================================記憶體管理====================================
    '=======================================================================================
    Public Function ReadLong(hprocess As Integer, lpAddress As Integer) As Integer
        Dim buffer As Byte() = New Byte(8) {}
        ReadProcessMemory(hprocess, lpAddress, buffer, 8, 0)
        Return BitConverter.ToInt32(buffer, 0)
    End Function

    Public Function ReadPointer(hprocess As Integer, lpAddress As Integer, lpOffset() As Integer, Type As String)
        Try
            Dim buffer As Byte() = New Byte(20) {}
            ReadProcessMemory(hprocess, lpAddress, buffer, 20, False)
            For m = 0 To UBound(lpOffset)
                ReadProcessMemory(hprocess, BitConverter.ToInt32(buffer, 0) + lpOffset(m), buffer, 20, False)
            Next

            Select Case UCase(Type)
                Case "2BYTE"
                    Return BitConverter.ToInt16(buffer, 0)
                    Exit Function
                Case "4BYTE"
                    Return BitConverter.ToInt32(buffer, 0)
                    Exit Function
                Case "8BYTE"
                    Return BitConverter.ToInt64(buffer, 0)
                    Exit Function
                Case "FLOAT"
                    Return BitConverter.ToSingle(buffer, 0)
                    Exit Function
                Case "DOUBLE"
                    Return BitConverter.ToDouble(buffer, 0)
                    Exit Function
                Case "TEXT"
                    Return Encoding.Default.GetString(buffer)
                    Exit Function
            End Select
        Catch
            Return False
        End Try
        Return True
    End Function

    Public Function WriteMemory(ByVal hprocess As Integer, ByVal lpAddress As Long, ByVal lpBuffer As Long, ByVal lpSize As Long) As Long
        WriteMemory = WriteProcessMemoryAPI(hprocess, lpAddress, lpBuffer, lpSize, False)
    End Function

    Public Function WritePointer(ByVal hprocess As Integer, ByVal lpAddress As Long, ByVal lpOffset As Long, ByVal lpValue As Long) As Long
        WritePointer = WriteMemory(hprocess, ReadLong(hprocess, lpAddress) + lpOffset, lpValue, 4)
    End Function

    Public Function HexLengthToEight(str As String) As String
        Dim spaceX As String = ""
        If str.Length < 8 Then
            Dim len As Integer = 8 - str.Length
            For m = 1 To len
                spaceX &= "0"
            Next
        End If
        Return spaceX & str
    End Function

    Public Function reverseAddress(lpAddress As String) As Byte()
        On Error Resume Next
        Return {"&H" + lpAddress.Substring(6, 2), "&H" + lpAddress.Substring(4, 2), "&H" + lpAddress.Substring(2, 2), "&H" + lpAddress.Substring(0, 2)}
    End Function

    Public Function Jmp(lpAddress As String) As Byte() 'Jmp("0072C2D7")
        Return {&H68, "&H" + lpAddress.Substring(6, 2), "&H" + lpAddress.Substring(4, 2), "&H" + lpAddress.Substring(2, 2), "&H" + lpAddress.Substring(0, 2), &HC3}
    End Function

    Public Function AsmJump(hprocess As Integer, lpAddress As Integer, HookAddress As IntPtr) As Boolean
        'Ex : AsmJump(hprocess,&H72C2D7,fma)   全圖打
        Try
            WriteProcessMemory(hprocess, lpAddress, {&HE9}, 1, 0) 'jmp
            WriteProcessMemory(hprocess, lpAddress + 1, System.BitConverter.GetBytes(HookAddress.ToInt32 - lpAddress - 5), 4, 0) 'address
        Catch
            Return False
        End Try
        Return True
    End Function

    Public Sub WriteMEM(hProcess As Integer, lpAddress As Integer, lpByte() As Byte) 'Ex : WriteMEM(hprocess, &H00BD8E45, {&H0F, &H84})
        WriteProcessMemory(hProcess, lpAddress, lpByte, UBound(lpByte) + 1, 0)
    End Sub

    Public Sub WriteMEMtoString(hProcess As Integer, lpAddress As Integer, lpByte As String) 'Ex : WriteMEMtoString(hprocess, &H00BD8E45, " 0F 84")
        Dim pByte As String = Replace(lpByte, " ", "") '清空所有空白

        For k = 0 To pByte.Length - 1
            '判斷所有字元是否為英文或數字
            If Not IsNumeric(pByte.Substring(k, 1)) Then
                If Not Char.IsLetter(pByte.Substring(k, 1)) Then
                    Exit Sub
                End If
            End If
        Next

        Dim ByteCount As Integer = 0
        Dim wByte((pByte.Length / 2) - 1) As Byte

        For k = 0 To pByte.Length - 1 Step 2
            wByte(ByteCount) = Convert.ToInt32(pByte.Substring(k, 2), 16)
            ByteCount += 1
        Next
        WriteMEM(hProcess, lpAddress, wByte)
    End Sub
    '=======================================================================================

    '=======================================================================================
    '==========================================INI操作======================================
    '=======================================================================================
    Public Function GetINI(ByVal sSection As String, ByVal sKey As String, ByVal sinifilename As String) As String
        Dim lReturnLen As UInt32
        Dim sKeyValue As New StringBuilder(1024)
        Dim nSize As UInt32 = Convert.ToUInt32(1024)
        Dim s As String
        lReturnLen = GetPrivateProfileString(sSection, sKey, "NULL", sKeyValue, nSize, Application.StartupPath & "\" & sinifilename)
        s = sKeyValue.ToString
        GetINI = s
    End Function

    Public Function WriteINI(ByVal sSection As String, ByVal sKey As String, ByVal ValStr As String, ByVal sinifilename As String) As Boolean
        Dim Res%
        Res% = WritePrivateProfileString(sSection, sKey, ValStr, Application.StartupPath & "\" & sinifilename)
        Return True
    End Function
    '=======================================================================================


    '=======================================================================================
    '====================================UIControl操作======================================
    '=======================================================================================
    Public Sub ListViewItemAdd(lsv As ListView, str() As String)
        Dim item As New ListViewItem
        If UBound(str) >= 0 Then
            item.Text = str(0)
            If UBound(str) > 0 Then
                For m = 1 To UBound(str)
                    item.SubItems.Add(str(m))
                Next
            End If
            lsv.Items.Add(item)
        End If
    End Sub
    '=======================================================================================
End Module

