Public Class FormEditKey
    Public selindexA As Integer

    Private Sub btn_addkey_Click(sender As Object, e As EventArgs) Handles btn_addkey.Click
        If ChkAll(cb_autokey.Text, txt_autotime.Text, cb_keymode.Text) Then
            FormMain.lsv_autokey.Items.Item(selindexA).SubItems(1).Text = cb_autokey.Text
            FormMain.lsv_autokey.Items.Item(selindexA).SubItems(2).Text = txt_autotime.Text
            FormMain.lsv_autokey.Items.Item(selindexA).SubItems(3).Text = cb_keymode.Text
            FormMain.lsv_autokey.Items.Item(selindexA).Checked = False
            Me.Hide()
        Else
            MsgBox("出現錯誤，請重新嘗試", MsgBoxStyle.Critical, "錯誤")
            Me.Hide()
        End If
    End Sub

    Private Sub btnCanel_Click(sender As Object, e As EventArgs) Handles btnCanel.Click
        Me.Hide()
    End Sub

    Private Sub FormEditKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddKeys(cb_autokey)
    End Sub
End Class