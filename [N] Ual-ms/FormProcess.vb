Imports System.Text

Public Class FormProcess
    Sub GetProcess()
        On Error Resume Next

        lsvWindow.Items.Clear()
        Dim myProcess As Process() = Process.GetProcesses()
        For Each p As Process In myProcess
            Dim UcaseName As String = UCase(p.ProcessName)
            If UcaseName.Contains("MAPLESTORY") Then
                If p.MainWindowHandle.ToInt32 > 0 Then ListViewItemAdd(lsvWindow, {p.MainWindowTitle, p.MainWindowHandle, p.Id})
            End If
        Next
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            Dim selIndex = lsvWindow.SelectedIndices(0)

            m_hWnd = lsvWindow.Items(selIndex).SubItems(1).Text
            m_pID = lsvWindow.Items(selIndex).SubItems(2).Text
            If OpenProcessByWindow() <> 0 Then
                FormMain.Show()
                Dim buffer As Byte() = New Byte(23) {}
                ReadProcessMemory(m_hProcess, &H10FC1C0, buffer, 8, False)
                ReadProcessMemory(m_hProcess, BitConverter.ToInt32(buffer, 0) + 4, buffer, 8, False)
                SetWindowText(m_hWnd, "[Ual-ms] Hi! " & Encoding.Default.GetString(buffer) & ".")
                m_WindowTitle = "[Ual-ms] Hi! " & Encoding.Default.GetString(buffer) & "."
                Me.Hide()
            End If
        Catch
            MsgBox("尚未選擇", MsgBoxStyle.Critical, "錯誤")
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        GetProcess()
    End Sub

    Private Sub frmChWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetProcess()
    End Sub
End Class