Imports System.Media

Module MyMedia
    'for getting the pngs for x and o
    Public Function GetImage(ByVal symbol As Char) As Bitmap
        Dim image As Bitmap
        If symbol = "x" Then
            image = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\RedX.PNG")
        ElseIf symbol = "o" Then
            image = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\BlueO.PNG")
        Else
            image = Nothing
        End If
        Return image
    End Function

    'for getting wav files for x and o
    Public Function GetSound(ByVal symbol As Char) As SoundPlayer
        Dim sound As SoundPlayer
        If symbol = "x" Then
            sound = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundX.wav")
        ElseIf symbol = "o" Then
            sound = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundO.wav")
        ElseIf symbol = "w" Then
            sound = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundWin.wav")
        ElseIf symbol = "d" Then
            sound = New SoundPlayer("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\soundDraw.wav")
        Else
            sound = Nothing
        End If
        Return sound
    End Function
End Module
