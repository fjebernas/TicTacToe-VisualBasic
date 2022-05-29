Public Class Gameboard
    Private isXTurn As Boolean
    Private ReadOnly matrix(3, 3) As Square
    Private moveCount As Byte
    Private isGameOver As Boolean

    Public Shared scoreX As Byte = 0
    Public Shared scoreO As Byte = 0
    Public Shared scoreDraws As Byte = 0

    Private conditions_X(8) As Boolean
    Private conditions_O(8) As Boolean

    Private header As Label

    Public Sub New(ByVal headerFromFormmain As Label)
        isXTurn = True
        moveCount = 0

        For i As Byte = 0 To matrix.GetLength(0) - 1
            For j As Byte = 0 To matrix.GetLength(1) - 1
                matrix(i, j) = New Square
            Next
        Next

        header = headerFromFormmain
        header.ForeColor = Color.Yellow
    End Sub

    Public Sub Move(ByVal row As Byte, ByVal column As Byte, ByVal btn As Button)
        If Not (isGameOver) Then
            If isXTurn Then
                matrix(row, column).Trigger(True, btn)
                header.Text = "Your turn O!"
            Else
                matrix(row, column).Trigger(False, btn)
                header.Text = "Your turn X!"
            End If
            moveCount += 1
            CheckGameState()

            isXTurn = Not (isXTurn)
        End If
    End Sub

    Private Sub CheckGameState()
        Dim match As SByte
        match = TestPatterns()

        If match >= 0 Or moveCount = 9 Then
            If isXTurn And Not (moveCount = 9) Then
                header.Text = "   X WINS!"
                Blink()
                scoreX += 1
            ElseIf Not (isXTurn) And Not (moveCount = 9) Then
                header.Text = "   O WINS!"
                Blink()
                scoreO += 1
            Else
                header.Text = "   DRAW!"
                Blink()
                scoreDraws += 1
            End If
            isGameOver = True
        End If
    End Sub

    Private Function TestPatterns() As SByte
        Dim match As SByte

        If isXTurn Then
            'horizontals
            conditions_X(0) = matrix(0, 0).isX And matrix(0, 1).isX And matrix(0, 2).isX
            conditions_X(1) = matrix(1, 0).isX And matrix(1, 1).isX And matrix(1, 2).isX
            conditions_X(2) = matrix(2, 0).isX And matrix(2, 1).isX And matrix(2, 2).isX

            'verticals
            conditions_X(3) = matrix(0, 0).isX And matrix(1, 0).isX And matrix(2, 0).isX
            conditions_X(4) = matrix(0, 1).isX And matrix(1, 1).isX And matrix(2, 1).isX
            conditions_X(5) = matrix(0, 2).isX And matrix(1, 2).isX And matrix(2, 2).isX

            'diagonals
            conditions_X(6) = matrix(0, 0).isX And matrix(1, 1).isX And matrix(2, 2).isX
            conditions_X(7) = matrix(0, 2).isX And matrix(1, 1).isX And matrix(2, 0).isX

            match = Convert.ToSByte(Array.IndexOf(conditions_X, True))
        Else
            'horizontals
            conditions_O(0) = matrix(0, 0).isO And matrix(0, 1).isO And matrix(0, 2).isO
            conditions_O(1) = matrix(1, 0).isO And matrix(1, 1).isO And matrix(1, 2).isO
            conditions_O(2) = matrix(2, 0).isO And matrix(2, 1).isO And matrix(2, 2).isO

            'verticals
            conditions_O(3) = matrix(0, 0).isO And matrix(1, 0).isO And matrix(2, 0).isO
            conditions_O(4) = matrix(0, 1).isO And matrix(1, 1).isO And matrix(2, 1).isO
            conditions_O(5) = matrix(0, 2).isO And matrix(1, 2).isO And matrix(2, 2).isO

            'diagonals
            conditions_O(6) = matrix(0, 0).isO And matrix(1, 1).isO And matrix(2, 2).isO
            conditions_O(7) = matrix(0, 2).isO And matrix(1, 1).isO And matrix(2, 0).isO

            match = Convert.ToSByte(Array.IndexOf(conditions_O, True))
        End If

        Return match
    End Function

    Private Async Sub Blink()
        While True
            Await Task.Delay(300)
            If header.ForeColor = Color.Yellow Then
                header.ForeColor = Color.Black
            ElseIf header.ForeColor = Color.Black Then
                header.ForeColor = Color.Yellow
            End If
        End While
    End Sub
End Class
