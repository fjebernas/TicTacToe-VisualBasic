﻿'Square class represents a single square in the 3x3 tictactoe Gameboard
'   can be marked as either X or O
Public Class Square
#Region "old codes"
    'Private ReadOnly pngX As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\RedX.PNG")
    'Private ReadOnly pngO As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\BlueO.PNG")

    'Private isTriggered As Boolean
    'Private btn As Button

    'Public isX As Boolean
    'Public isO As Boolean

    'Public Sub New()
    '    isTriggered = False
    '    isX = False
    '    isO = False
    'End Sub

    'Public Function GetState() As Char
    '    Return " "
    'End Function

    'Public Sub Trigger(ByVal isXTurn As Boolean, ByVal passedBtn As Button)
    '    btn = passedBtn

    '    If Not (isTriggered) Then
    '        If isXTurn Then
    '            isX = True
    '            btn.BackgroundImage = pngX
    '        Else
    '            isO = True
    '            btn.BackgroundImage = pngO
    '        End If

    '        isTriggered = True
    '        btn.Enabled = False
    '    End If
    'End Sub
#End Region
    Private _btn As Button
    Private _state As Char
    Private ReadOnly _pngX As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\RedX.PNG")
    Private ReadOnly _pngO As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\BlueO.PNG")

    Public Sub New(ByVal btn As Button)
        _btn = btn
        _state = " "
    End Sub

    Public Sub Trigger(ByVal playerSign As Char)
        If playerSign = "x" Then
            _btn.BackgroundImage = _pngX
            _state = "x"
        Else
            _btn.BackgroundImage = _pngO
            _state = "o"
        End If
        _btn.Enabled = False
    End Sub

    Public Function GetState() As Char
        Return _state
    End Function
End Class
