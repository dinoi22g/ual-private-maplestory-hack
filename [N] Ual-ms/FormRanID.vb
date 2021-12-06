﻿Public Class FormRanID
    Public Sub ItemAdd(name As String, id As String)
        Dim item As New ListViewItem
        item.Text = name
        item.SubItems.Add(id)
        ListView1.Items.Add(item)
    End Sub

    Private Sub FormRanID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ItemAdd("0009", "蘇菲莉雅丟棄的娃娃")
        ItemAdd("0015", "屈原變身祕藥")
        ItemAdd("0022", "佩圖變身藥水")
        ItemAdd("0036", "傑配託變身藥水")
        ItemAdd("0001", "菇菇寶貝的雕像")
        ItemAdd("0002", "緞帶肥肥的雕像")
        ItemAdd("0003", "葛雷的雕像")
        ItemAdd("0004", "龍族變身祕藥")
        ItemAdd("0005", "藍色緞帶肥肥雕像")
        ItemAdd("0006", "提肯變身祕藥")
        ItemAdd("0007", "彩虹蝸牛殼")
        ItemAdd("0008", "幽靈變身.幽靈糖果")
        ItemAdd("0009", "蘇菲莉雅丟棄的娃娃")
        ItemAdd("0010", "鬥神附體變身祕藥")
        ItemAdd("0011", "鬥神附體變身祕藥")
        ItemAdd("0012", "老鼠變身藥水")
        ItemAdd("0015", "屈原變身祕藥")
        ItemAdd("0016", "變身迷你小紅龍")
        ItemAdd("0017", "月亮的照片")
        ItemAdd("0018", "月亮花糕點")
        ItemAdd("0019", "白色兔子變身祕藥")
        ItemAdd("0020", "粉紅兔子變身祕藥")
        ItemAdd("0021", "加加變身祕藥")
        ItemAdd("0022", "佩圖變身藥水")
        ItemAdd("0023", "聖誕團隊藥水")
        ItemAdd("0024", "聖誕團隊藥水")
        ItemAdd("0025", "聖誕團隊藥水")
        ItemAdd("0026", "聖誕團隊藥水")
        ItemAdd("0027", "聖誕團隊藥水")
        ItemAdd("0028", "聖誕團隊藥水")
        ItemAdd("0029", "聖誕團隊藥水")
        ItemAdd("0030", "聖誕團隊藥水")
        ItemAdd("0031", "吉祥紅包")
        ItemAdd("0032", "吉祥紅包")
        ItemAdd("0033", "吉祥紅包")
        ItemAdd("0034", "吉祥紅包")
        ItemAdd("0035", "黃金豬")
        ItemAdd("0036", "傑配託變身藥水")
        ItemAdd("0037", "皮諾秋變身藥水")
        ItemAdd("0040", "葛雷變身")
        ItemAdd("0041", "企鵝變身1")
        ItemAdd("0042", "企鵝變身2")
        ItemAdd("0043", "企鵝變身3")
        ItemAdd("0044", "企鵝變身4")
        ItemAdd("0045", "企鵝變身5")
        ItemAdd("0046", "幽靈變身藥水")
        ItemAdd("0047", "幽靈小娃變身藥水")
        ItemAdd("0048", "傑克變身藥水")
        ItemAdd("0050", "雪人變身")
        ItemAdd("0051", "克里特變身")
        ItemAdd("0052", "艾娜變身")
        ItemAdd("0053", "猶塔變身")
        ItemAdd("0063", "修亞勒變身藥水")
        ItemAdd("0068", "綠色")
        ItemAdd("0069", "穆魯穆魯")
        ItemAdd("0070", "綠菇菇")
        ItemAdd("0071", "蝙蝠")
        ItemAdd("0072", "巡邏機器人")
        ItemAdd("0073", "大蛇王")
        ItemAdd("0074", "猴子")
        ItemAdd("0075", "特殊紅寶王")
        ItemAdd("0076", "發條楓葉鼠")
        ItemAdd("0077", "鼬鼠鬧鐘")
        ItemAdd("0078", "積木泥人王")
        ItemAdd("0079", "小雪球")
        ItemAdd("0080", "特殊仙人長老")
        ItemAdd("0081", "企鵝王")
        ItemAdd("0082", "土龍")
        ItemAdd("0083", "黑格里芬")
        ItemAdd("0084", "小虎")
        ItemAdd("0085", "特殊巨居蟹")
        ItemAdd("0086", "三尾狐")
        ItemAdd("0087", "勇猛石巨人")
        ItemAdd("0088", "喵仙")
        ItemAdd("0089", "貨運熊")
        ItemAdd("0090", "特殊葛雷金剛")
        ItemAdd("0091", "豪豬")
        ItemAdd("0092", "黑妖苗三兄弟")
        ItemAdd("0093", "拉坎")
        ItemAdd("0094", "梅花鹿")
        ItemAdd("0095", "特殊艾利傑")
        ItemAdd("0096", "深山人蔘")
        ItemAdd("0097", "怨靈女巫")
        ItemAdd("0098", "萊西")
        ItemAdd("0099", "船員克魯")
        ItemAdd("0100", "特殊地獄巴洛古")
        ItemAdd("0101", "特貝爾芬變身藥水")
        ItemAdd("0102", "百烈")
        ItemAdd("0103", "雪吉拉")
        ItemAdd("0104", "伊魯薇達")
        ItemAdd("0105", "特殊獅鷲")
        ItemAdd("0106", "藍菇菇")
        ItemAdd("0107", "古木妖")
        ItemAdd("0108", "殭屍菇菇")
        ItemAdd("0109", "黑肥肥")
        ItemAdd("0110", "特殊凡雷恩")
        ItemAdd("0111", "特殊拉圖斯")
        ItemAdd("0112", "公子月妙變身雕像")
        ItemAdd("0113", "小姐月妙變身雕像")
        ItemAdd("1000", "鬥神附體")
        ItemAdd("1001", "鬥神附體")
        ItemAdd("1002", "偽裝術")
        ItemAdd("1003", "阿爾法")
        ItemAdd("1100", "鬥神附體")
        ItemAdd("1101", "鬥神附體")
        ItemAdd("1103", "阿爾法")
        ItemAdd("2000", "冰騎士變身1")
        ItemAdd("2001", "冰騎士變身2")
        ItemAdd("2002", "冰騎士變身3")
        ItemAdd("2003", "冰藍寶")
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        FormMain.txt_charran.Text = ListView1.Items.Item(ListView1.SelectedIndices(0)).SubItems(0).Text
        Me.Hide()
    End Sub
End Class