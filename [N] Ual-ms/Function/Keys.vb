Module Keys
    Public KeyNameAndCode(,) As String = {
                                            {"Esc", &H1B},
                                            {"Tab", &H9},
                                            {"Left", &H25},
                                            {"Up", &H26},
                                            {"Right", &H27},
                                            {"PageDown", &H22},
                                            {"End", &H23},
                                            {"Down", &H28},
                                            {"Enter", &HD},
                                            {"Shift", &H10},
                                            {"Ctrl", &H11},
                                            {"Alt", &H12},
                                            {"Space", &H20},
                                            {"PageUp", &H21},
                                            {"Home", &H24},
                                            {"Insert", &H2D},
                                            {"Delete", &H2E},
                                            {"0", &H30},
                                            {"1", &H31},
                                            {"2", &H32},
                                            {"3", &H33},
                                            {"4", &H34},
                                            {"5", &H35},
                                            {"6", &H36},
                                            {"7", &H37},
                                            {"8", &H38},
                                            {"9", &H39},
                                            {"A", &H41},
                                            {"B", &H42},
                                            {"C", &H43},
                                            {"D", &H44},
                                            {"E", &H45},
                                            {"F", &H46},
                                            {"G", &H47},
                                            {"H", &H48},
                                            {"I", &H49},
                                            {"J", &H4A},
                                            {"K", &H4B},
                                            {"L", &H4C},
                                            {"M", &H4D},
                                            {"N", &H4E},
                                            {"O", &H4F},
                                            {"P", &H50},
                                            {"Q", &H51},
                                            {"R", &H52},
                                            {"S", &H53},
                                            {"T", &H54},
                                            {"U", &H55},
                                            {"V", &H56},
                                            {"W", &H57},
                                            {"X", &H58},
                                            {"Y", &H59},
                                            {"Z", &H5A},
                                            {"F1", &H70},
                                            {"F2", &H71},
                                            {"F3", &H72},
                                            {"F4", &H73},
                                            {"F5", &H74},
                                            {"F6", &H75},
                                            {"F7", &H76},
                                            {"F8", &H77},
                                            {"F9", &H78},
                                            {"F10", &H79},
                                            {"F11", &H7A},
                                            {"F12", &H7B}
                                        }

    Public Sub AddKeys(cbKeys As ComboBox)
        cbKeys.Items.Clear()
        For m = 0 To UBound(KeyNameAndCode)
            cbKeys.Items.Add(KeyNameAndCode(m, 0))
        Next
    End Sub

    Public Function KeysCodeToName(keyCode As Integer) As String
        For m = 0 To UBound(KeyNameAndCode)
            If KeyNameAndCode(m, 1) = keyCode Then
                Return KeyNameAndCode(m, 0)
            End If
        Next
        Return "null"
    End Function

    Public Function KeysNameToCode(keyName As String) As Integer
        For m = 0 To UBound(KeyNameAndCode)
            If KeyNameAndCode(m, 0) = keyName Then
                Return KeyNameAndCode(m, 1)
            End If
        Next
        Return 0
    End Function

    Public Function ChkKeyName(KeyName As String) As Boolean
        For m = 0 To UBound(KeyNameAndCode)
            If KeyNameAndCode(m, 0) = KeyName Then Return True
        Next
        Return False
    End Function

    Public Function IsNumericA(strNumber As [String]) As Boolean
        Dim NumberPattern As New System.Text.RegularExpressions.Regex("[^0-9.-]")
        Return Not NumberPattern.IsMatch(strNumber)
    End Function

    Public Function ChkMode(mode As String) As Boolean
        If mode <> "彈按" And mode <> "長壓" And mode <> "雙擊" Then Return False
        Return True
    End Function

    Public Function ChkAll(keyname As String, stime As String, mode As String) As Boolean
        If ChkKeyName(keyname) = False Then Return False
        If IsNumeric(stime) = False Then Return False
        If ChkMode(mode) = False Then Return False
        Return True
    End Function

    Public Sub PressKey(hWnd As IntPtr, KeyCode As Integer, mode As Integer)
        Select Case mode
            Case 1 '按下
                PostMessage(hWnd, &H100, KeyCode, MakeKeyLparam(KeyCode, &H100))
            Case 2 '按下彈起
                PostMessage(hWnd, &H100, KeyCode, MakeKeyLparam(KeyCode, &H100))
                PostMessage(hWnd, &H101, KeyCode, MakeKeyLparam(KeyCode, &H101))
            Case 3 '雙擊
                PostMessage(hWnd, &H100, KeyCode, MakeKeyLparam(KeyCode, &H100))
                PostMessage(hWnd, &H101, KeyCode, MakeKeyLparam(KeyCode, &H101))
                PostMessage(hWnd, &H100, KeyCode, MakeKeyLparam(KeyCode, &H100))
                PostMessage(hWnd, &H101, KeyCode, MakeKeyLparam(KeyCode, &H101))
        End Select
    End Sub

    Public Function MakeKeyLparam(ByVal VirtualKey As Long, ByVal flag As Long) As Long
        Dim s As String
        Dim Firstbyte As String    'lparam参数的24-31位
        If flag = WM_KEYDOWN Then '如果是按下键
            Firstbyte = "00"
        Else
            Firstbyte = "C0"       '如果是释放键
        End If
        Dim Scancode As Long
        '获得键的扫描码
        Scancode = MapVirtualKey(VirtualKey, 0)
        Dim Secondbyte As String   'lparam参数的16-23位，即虚拟键扫描码
        Secondbyte = Strings.Right("00" & Hex(Scancode), 2)
        s = Firstbyte & Secondbyte & "0001"  '0001为lparam参数的0-15位，即发送次数和其它扩展信息
        MakeKeyLparam = Val("&H" & s)
    End Function
End Module
