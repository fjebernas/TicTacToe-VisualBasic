'Arbiter class is responsible for:
'   checking the Gameboard it there is a winner
'   for keeping track of scores
Public Class Arbiter
    Private conditions_X(8) As Boolean
    Private conditions_O(8) As Boolean
    '(below) this and the other matrix in Gameboard class points to the same Square objects created in the Gameboard constructor
    Private matrix As Square(,)

    Public isXTurn As Boolean
    Public moveCount As Byte

    Public Shared scoreX As Byte = 0
    Public Shared scoreO As Byte = 0
    Public Shared scoreDraws As Byte = 0

    Public Sub New(ByVal passedMatrix As Square(,))
        isXTurn = True
        matrix = passedMatrix
        moveCount = 0
    End Sub

    Public Function CheckIfWin() As Boolean
        Dim match As SByte
        match = TestPatterns()

        If match >= 0 Or moveCount = 9 Then
            If isXTurn And Not (moveCount = 9) Then
                scoreX += 1
            ElseIf Not (isXTurn) And Not (moveCount = 9) Then
                scoreO += 1
            Else
                scoreDraws += 1
            End If
            Return True
        End If
        Return False
    End Function

    Public Function TestPatterns() As SByte
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
End Class
