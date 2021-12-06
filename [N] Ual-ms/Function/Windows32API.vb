Imports System.Runtime.InteropServices
Imports System.Text

Module Windows32API
    Public Declare Function CEInitialize Lib "ceautoassembler" (ByVal ngPassedPID As Integer, ByVal Phandle As Integer) As Integer
    Public Declare Function CEAutoAsm Lib "ceautoassembler" (ByVal Script As String, ByVal AllocID As Boolean, ByVal Alloc As Integer) As Boolean
    Public Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal lpClassName As String, ByVal lpWindowName As String) As Integer
    Public Declare Function PostMessage Lib "user32" Alias "PostMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As IntPtr, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Public Declare Function OpenProcessAPI Lib "kernel32" Alias "OpenProcess" (ByVal dwDesiredAccess As Int32, ByVal bInheritHandle As Int32, ByVal dwProcessId As Int32) As Int32
    Public Declare Function WriteProcessMemoryAPI Lib "kernel32" Alias "WriteProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function ReadProcessMemoryAPI Lib "kernel32" Alias "ReadProcessMemory" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef lpBuffer As Integer, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function MapVirtualKey Lib "user32" Alias "MapVirtualKeyA" (ByVal wCode As Integer, ByVal wMapType As Integer) As Integer
    Public Declare Function CreateToolhelp32Snapshot Lib "kernel32" (ByVal lFlags As Long, ByVal lProcessID As Long) As Long
    Public Declare Function Process32First Lib "kernel32" (ByVal hSnapshot As Integer, ByVal lppe As PROCESSENTRY32) As Integer
    Public Declare Function Process32Next Lib "kernel32" (ByVal hSapshot As Integer, ByVal lppe As PROCESSENTRY32) As Integer
    Public Declare Function CloseHandleAPI Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Long) As Long
    Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hWnd As IntPtr, <Out()> ByRef lpdwProcessId As IntPtr) As Integer
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (<MarshalAs(UnmanagedType.LPStr)> ByVal lpApplicationName As String, <MarshalAs(UnmanagedType.LPStr)> ByVal lpKeyName As String, <MarshalAs(UnmanagedType.LPStr)> ByVal lpDefault As String, <MarshalAs(UnmanagedType.LPStr)> ByVal lpReturnedString As StringBuilder, ByVal nSize As UInt32, <MarshalAs(UnmanagedType.LPStr)> ByVal lpFileName As String) As UInt32
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFilename As String) As Int32

    <DllImport("kernel32.dll", SetLastError:=True, ExactSpelling:=True)>
    Public Function VirtualAllocEx(ByVal hProcess As Integer, ByVal lpAddress As Integer,
     ByVal dwSize As IntPtr, ByVal flAllocationType As UInteger,
     ByVal flProtect As UInteger) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Function WriteProcessMemory(
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As Byte(),
    ByVal nSize As Int32,
    <Out()> ByRef lpNumberOfBytesWritten As IntPtr) As Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Public Function VirtualProtect(ByVal lpAddress As IntPtr, ByVal dwSize As Integer, ByVal flNewProtect As Integer, ByRef lpflOldProtect As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function SetWindowText(ByVal hwnd As IntPtr, ByVal lpString As String) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True)> _
    Public Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)> _
    Public Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll")> _
    Public Function ReadProcessMemory(hProcess As Integer, lpBaseAddress As Integer, lpBuffer As Byte(), dwSize As Integer, ByRef lpNumberOfBytesRead As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll")> _
    Public Function VirtualFreeEx(ByVal hProcess As Integer, _
                      ByVal lpAddress As Integer, _
                      ByVal dwSize As Integer, _
                      ByVal dwFreeType As FreeType) As Boolean
    End Function

    <Flags()> _
    Public Enum FreeType As UInteger
        DECOMMIT = &H4000
        RELEASE = &H8000
    End Enum

    '熱鍵註冊
    Public Declare Auto Function RegisterHotKey Lib "user32.dll" Alias _
  "RegisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Boolean
    '解除熱鍵
    Public Declare Auto Function UnRegisterHotKey Lib "user32.dll" Alias _
        "UnregisterHotKey" (ByVal hwnd As IntPtr, ByVal id As Integer) As Boolean
    Public Const WM_HOTKEY = &H312

    Public Structure PROCESSENTRY32
        Dim dwSize As Integer
        Dim cntUseage As Integer
        Dim th32ProcessID As Integer
        Dim th32DefaultHeapID As Integer
        Dim th32ModuleID As Integer
        Dim cntThreads As Integer
        Dim th32ParentProcessID As Integer
        Dim pcPriClassBase As Integer
        Dim swFlags As Integer
        Dim szExeFile As String
    End Structure

    Public Const PROCESS_ALL_ACCESS = &H1F0FFF
    Public Const WM_KEYDOWN = &H100
    Public Const WM_CLOSE = &H10
    Public Const MOUSEEVENTF_LEFTDOWN = &H201    '模擬鼠標左鍵按下 
    Public Const MOUSEEVENTF_LEFTUP = &H202    '模擬鼠標左鍵抬起 

    Private Const MAX_PATH = 260
    Private Const TH32CS_SNAPPROCESS = &H2
    Public Const WM_CHAR = &H102

    Public Const PAGE_EXECUTE_READWRITE = &H40
End Module
