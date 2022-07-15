
Imports System.Media

Public Class Square
    Private _btn As Button
    Private _state As Char
    Private ReadOnly _pngX As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\RedX.PNG")
    Private ReadOnly _pngO As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\BlueO.PNG")
    Private ReadOnly _soundX As SoundPlayer = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundX.wav")
    Private ReadOnly _soundO As SoundPlayer = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundO.wav")

    Public Sub New(ByVal btn As Button)
        _btn = btn
        _state = " "
    End Sub

    Public Sub Trigger(ByVal playerSign As Char)
        If playerSign = "x" Then
            _btn.BackgroundImage = _pngX
            _soundX.Play()
            _state = "x"
        Else
            _btn.BackgroundImage = _pngO
            _soundO.Play()
            _state = "o"
        End If
        _btn.Enabled = False
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
