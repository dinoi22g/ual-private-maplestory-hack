Module Pointers
    Public Const Char_Base = &H10E7934
    Public Const Attack_Count_Offset = &H7DDC
    Public Const Morph_Offset = &H634 '//變身
    Public Const Breath_Offset = &H6A8
    Public Const Char_PID_Offset = &H257C '//8B 86 ? ? 00 00 6A D8
    Public Const Char_X_Offset = &H8D78
    Public Const Char_Y_Offset = &H8D7C
    Public Const Teleport_Offset = &H7BB8 '//瞬移開關
    Public Const Teleport_X_Offset = &H7BC0 '//瞬移X
    Public Const Teleport_Y_Offset = &H7BC0 + 4 '//瞬移Y

    Public Const MiniMap_Base = &H10ECA28
    Public Const MiniMap_X_Offest = &HFE8
    Public Const MiniMap_Y_Offest = &HFEC

    Public Const iKnockbackOffset = &H134 '// iKnockbackXOffset - =&H0C
    Public Const iKnockbackXOffset = &H140 '// 83 B9 ? ? 00 00 00 D9 EE
    Public Const iKnockbackYOffset = &H144 '// iKnockbackXOffset + =&H08

    Public Const Mob_Base = &H10EC144
    Public Const Mob_Count_Offset = &H10
    Public Const Mob_Death_Offest = &H550 '//89 86 ? ? ? ? 89 86 ? ? ? ? 33 C0 89 86
    Public Const Mob_1 = &H28
    Public Const Mob_2 = &H4
    Public Const Mob_3 = &H130
    Public Const Mob_4 = &H24 '//
    Public Const Mob_X = &H58
    Public Const Mob_Y = &H5C

    Public Const People_Base = &H10EC140
    Public Const People_Count_Offset = &H18

    Public Const Item_Base = &H10EFBF8
    Public Const Item_Count_Offset = &H14

    Public Const Mouse_Base = &H10EC708
    Public Const Mouse_Offset = &H978
    Public Const Mouse_X_Offset = &H8C
    Public Const Mouse_Y_Offset = &H90
    Public Const Mouse_Animation = &H9CC '//89 8f ? ? ? ? 8b 8f ? ? ? ? 83 bc 8f

    Public Const Info_Base = &H10EC418
    Public Const Health = &H21D4 '//Hp
    Public Const Mana = &H21D8 '//Mp
    Public Const Exp = &H2108


    Public Const Settings_Base = &H10EC13C
    Public Const Health_Alert = &H50
    Public Const Mana_Alert = &H54

    Public Const Map_Info_Base = &H10ECA28
    Public Const Map_ID_Offset = &H11C8
    Public Const MapCharXOff = &HFE8 '//8B 8F ? ? 00 00 ? E8 ? ? FF FF ? ? ? C2
    Public Const MapCharYOff = &HFEC '//MapCharXOff + 4;
    Public Const NPCCountOff = &H1020 '//MapCharXOff + =&H38
    Public Const RopeCount = &H11A4 '// 8d ? ? ? ? ? 57 89 ? ? ? ? ? 51 89 [1st]

    Public Const Map_Base = &H10EC0C0
    Public Const Left_Wall_Offset = &H1C
    Public Const Top_Wall_Offset = &H20
    Public Const Right_Wall_Offset = &H24
    Public Const Bottom_Wall_Offset = &H28
    Public Const Rope_Data_Offset = &HB4
    Public Const PlatformOff = &H80

    Public Const Server_Base = &H10E7930
    Public Const World_Offset = &H2098
    Public Const Channel_Offset = World_Offset + 4
    Public Const Tubi_Offset = &H2104
    Public Const DelayOff = &H2108 '// TubiOff + 4;
End Module
