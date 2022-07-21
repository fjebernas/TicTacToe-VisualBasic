
Public Class Player
    Private _playerSign As Char
    Private _squareMatrix(,) As Square
    Private _moveCount As Byte

    Public WinningSquares(2) As Square

    Public Sub New(ByVal playerSign As Char, ByVal squareMatrix As Square(,))
        _playerSign = playerSign
        _squareMatrix = squareMatrix
        _moveCount = 0
    End Sub

    Public Function GetSign() As Char
        Return _playerSign
    End Function

    Public Property MoveCount() As Byte
        Get
            Return _moveCount
        End Get
        Set(ByVal value As Byte)
            _moveCount = value
        End Set
    End Property

    Public Sub PutMark(ByVal square As Square)
        square.Trigger(_playerSign)
        _moveCount += 1
    End Sub

    Public Function CheckIfWin(ByRef isGameOver As Boolean) As Boolean
        If CheckRowsForWin() Or CheckColsForWin() Or CheckDiagsForWin() Then
            isGameOver = True
            Return True
        End If
        Return False
    End Function

    Private Function CheckRowsForWin() As Boolean
        For i = 0 To _squareMatrix.GetLength(0) - 1
            If CheckRowColDiag(_squareMatrix(i, 0), _squareMatrix(i, 1), _squareMatrix(i, 2)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function CheckColsForWin() As Boolean
        For i = 0 To _squareMatrix.GetLength(1) - 1
            If CheckRowColDiag(_squareMatrix(0, i), _squareMatrix(1, i), _squareMatrix(2, i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function CheckDiagsForWin() As Boolean
        If CheckRowColDiag(_squareMatrix(0, 0), _squareMatrix(1, 1), _squareMatrix(2, 2)) Or CheckRowColDiag(_squareMatrix(0, 2), _squareMatrix(1, 1), _squareMatrix(2, 0)) Then
            Return True
        End If
        Return False
    End Function

    Private Function CheckRowColDiag(ByVal sq1 As Square, ByVal sq2 As Square, ByVal sq3 As Square)
        If Not (sq1.GetState() = " ") And sq1.GetState() = sq2.GetState() And sq2.GetState() = sq3.GetState() Then
            WinningSquares(0) = sq1
            WinningSquares(1) = sq2
            WinningSquares(2) = sq3
            Return True
        End If
        Return False
    End Function
End Class
