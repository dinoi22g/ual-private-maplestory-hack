Imports System.Drawing.Drawing2D

Public Class ProgressBarEx
    Declare Function CreateRoundRectRgn Lib "gdi32" Alias "CreateRoundRectRgn" (ByVal X1 As Int32, ByVal Y1 As Int32, ByVal X2 As Int32, ByVal Y2 As Int32, ByVal X3 As Int32, ByVal Y3 As Int32) As Int32
    Declare Function SetWindowRgn Lib "user32" Alias "SetWindowRgn" (ByVal hWnd As Int32, ByVal hRgn As Int32, ByVal bRedraw As Boolean) As Int32

    Private _AppValue As String = "0" '值
    Private _MaxValue As String = "100" '極限值
    Private _ValueColor As String = "255,0,0" '值的背景顏色
    Private _BackColor As String = "224,255,255" '進度條背景顏色
    Private _TextColor As String = "0,0,0" '進度顯示顏色
    Private _displayModule As String = "1" '1=Value % 2=Value/MaxValue
    Private _styleModule As String = "1" '1=預設   2=圓形


    Private Rn, Gn, Bn As String '設定字體顏色

    Sub CallRefresh()
        On Error Resume Next
        progress_value.Width = Value * (progress_back.Width / _MaxValue)
        progress_back.Update() : progress_back.Refresh()
        progress_value.Update() : progress_value.Refresh()
        Me.Update() : Me.Refresh()

        If _styleModule = 2 Then
            '創立圓角窗體
            Dim r As Integer = CreateRoundRectRgn(0, 0, Me.Width, Me.Height, 20, 20)
            Dim rc As Integer = CreateRoundRectRgn(0, 0, progress_value.Width, progress_value.Height, 20, 20)
            SetWindowRgn(Me.Handle, r, True)
            SetWindowRgn(progress_value.Handle, rc, True)
        End If
    End Sub

    Sub ProgressBarEx_Load(sender As Object, e As EventArgs) Handles Me.Load
        progress_back.Width = Me.Width
        progress_back.Height = Me.Height

        progress_value.Height = Me.Height
    End Sub

    Private Sub progress_Paint(sender As Object, e As PaintEventArgs) Handles progress_back.Paint, progress_value.Paint
        Dim g As Graphics = e.Graphics
        If _displayModule = 1 Then
            Dim Prc As Double = Math.Round(_AppValue / _MaxValue * 100, 2)
            g.DrawString(Prc & " %", New Font("arial", 9), New SolidBrush(Color.FromArgb(Rn, Gn, Bn)), New PointF(progress_back.Width / 2 - Prc.ToString.Length - 5, progress_back.Height / 2 - 9))
        ElseIf _displayModule = 2 Then
            Dim str As String = _AppValue.ToString & " / " & _MaxValue
            g.DrawString(str, New Font("arial", 9), New SolidBrush(Color.FromArgb(Rn, Gn, Bn)), New PointF(progress_back.Width / 2 - str.Length - 20, progress_back.Height / 2 - 9))
        End If
    End Sub

    Public Property Value() As String
        Get
            Return _AppValue
        End Get
        Set(ByVal value As String)
            _AppValue = value
            CallRefresh()
        End Set
    End Property

    Public Property MaxValue() As String
        Get
            Return _MaxValue
        End Get
        Set(ByVal value As String)
            _MaxValue = value
            CallRefresh()
        End Set
    End Property

    Public Property Value_Backcolor() As String

        Get
            Return _ValueColor
        End Get
        Set(ByVal value As String)
            _ValueColor = value
            Dim pColor() As String = Split(_ValueColor, ",")
            If UBound(pColor) <> 2 Then
                Return
            End If
            progress_value.BackColor = Color.FromArgb(pColor(0), pColor(1), pColor(2))
        End Set
    End Property

    Public Property Back_Backcolor() As String
        Get
            Return _BackColor
        End Get
        Set(ByVal value As String)
            _BackColor = value
            Dim pColor() As String = Split(_BackColor, ",")
            If UBound(pColor) <> 2 Then
                Return
            End If
            progress_back.BackColor = Color.FromArgb(pColor(0), pColor(1), pColor(2))
        End Set
    End Property

    Public Property ProgressBar_Color() As String
        Get
            Return _TextColor
        End Get
        Set(ByVal value As String)
            _TextColor = value
            Dim pColor() As String = Split(_TextColor, ",")
            If UBound(pColor) <> 2 Then
                Return
            End If
            Rn = pColor(0)
            Gn = pColor(1)
            Bn = pColor(2)
        End Set
    End Property

    Public Property displayMoudle() As String
        Get
            Return _displayModule
        End Get
        Set(ByVal value As String)
            _displayModule = value
            CallRefresh()
        End Set
    End Property

    Public Property styleMoudle() As String
        Get
            Return _styleModule
        End Get
        Set(ByVal value As String)
            _styleModule = value
            CallRefresh()
        End Set
    End Property

End Class
