
Public Class Square
    Private _btn As Button
    Private _state As Char

    Public Sub New(ByVal btn As Button)
        _btn = btn
        _state = " "
    End Sub

    Public Sub Trigger(ByVal playerSign As Char)
        _btn.Enabled = False
        _state = playerSign
        _btn.BackgroundImage = MyMedia.GetImage(playerSign)
        'MyMedia.GetSound(playerSign).Play()
    End Sub

    Public Function GetState() As Char
        Return _state
    End Function

    Public Sub LightUp()
        _btn.BackColor = Color.Orange
    End Sub

    Public Sub Disable()
        If _state = " " Then
            _btn.Enabled = False
        End If
    End Sub

    Public Sub Enable()
        If _state = " " Then
            _btn.Enabled = True
        End If
    End Sub
End Class
