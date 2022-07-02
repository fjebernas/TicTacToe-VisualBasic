
Public Class CPU
    Private _playerSign As Char
    Private _squareMatrix(,) As Square
    Private _moveCount As Byte
    Dim _tempTargetSquare As Square

    Public Sub New(ByVal playerSign As Char, ByVal squareMatrix(,) As Square)
        _playerSign = playerSign
        _squareMatrix = squareMatrix
        _moveCount = 0
    End Sub

    Public Property MoveCount() As Byte
        Get
            Return _moveCount
        End Get
        Set(ByVal value As Byte)
            _moveCount = value
        End Set
    End Property

    Public Sub PutMark()
#Region "PRIORITY ATTACK MOVES"
        'check for rows
        For i = 0 To _squareMatrix.GetLength(0) - 1
            _tempTargetSquare = SearchAndStore(_squareMatrix(i, 0), _squareMatrix(i, 1), _squareMatrix(i, 2), True)
            If Not (_tempTargetSquare Is Nothing) Then
                Exit For
            End If
        Next

        'if still empty, check for columns
        If _tempTargetSquare Is Nothing Then
            For i = 0 To _squareMatrix.GetLength(1) - 1
                _tempTargetSquare = SearchAndStore(_squareMatrix(0, i), _squareMatrix(1, i), _squareMatrix(2, i), True)
                If Not (_tempTargetSquare Is Nothing) Then
                    Exit For
                End If
            Next
        End If

        'if still empty, check for diagonals
        If _tempTargetSquare Is Nothing Then
            _tempTargetSquare = SearchAndStore(_squareMatrix(0, 0), _squareMatrix(1, 1), _squareMatrix(2, 2), True)
        End If
        If _tempTargetSquare Is Nothing Then
            _tempTargetSquare = SearchAndStore(_squareMatrix(0, 2), _squareMatrix(1, 1), _squareMatrix(2, 0), True)
        End If
#End Region

#Region "NORMAL MOVE"
        'check for rows
        If _tempTargetSquare Is Nothing Then
            For i = 0 To _squareMatrix.GetLength(0) - 1
                _tempTargetSquare = SearchAndStore(_squareMatrix(i, 0), _squareMatrix(i, 1), _squareMatrix(i, 2), False)
                If Not (_tempTargetSquare Is Nothing) Then
                    Exit For
                End If
            Next
        End If

        'if still empty, check for columns
        If _tempTargetSquare Is Nothing Then
            For i = 0 To _squareMatrix.GetLength(1) - 1
                _tempTargetSquare = SearchAndStore(_squareMatrix(0, i), _squareMatrix(1, i), _squareMatrix(2, i), False)
                If Not (_tempTargetSquare Is Nothing) Then
                    Exit For
                End If
            Next
        End If

        'if still empty, check for diagonals
        If _tempTargetSquare Is Nothing Then
            _tempTargetSquare = SearchAndStore(_squareMatrix(0, 0), _squareMatrix(1, 1), _squareMatrix(2, 2), False)
        End If
        If _tempTargetSquare Is Nothing Then
            _tempTargetSquare = SearchAndStore(_squareMatrix(0, 2), _squareMatrix(1, 1), _squareMatrix(2, 0), False)
        End If

        'if still empty, do random move
        If _tempTargetSquare Is Nothing Then
            Dim rnd As Random
            rnd = New Random
            Do
                _tempTargetSquare = _squareMatrix(rnd.Next(_squareMatrix.GetLength(0)), rnd.Next(_squareMatrix.GetLength(1)))
            Loop While Not (_tempTargetSquare.GetState() = " ")
        End If
#End Region

        _tempTargetSquare.Trigger(_playerSign)
        _moveCount += 1
    End Sub

    Public Function SearchAndStore(ByVal sq1 As Square, ByVal sq2 As Square, ByVal sq3 As Square, ByVal attackMode As Boolean) As Square
        Dim tempSquares() As Square = {
            sq1, sq2, sq3
        }

        'needs to check if only one is empty
        If Not (tempSquares.Count(Function(x) x.GetState() = " ") = 1) Then
            Return Nothing
        End If

        For i = 0 To tempSquares.Length
            If tempSquares(i).GetState() = " " Then
                Dim tempSq As Square
                tempSq = tempSquares(0)
                tempSquares(0) = tempSquares(i)
                tempSquares(i) = tempSq

                Exit For
            End If
        Next

        If tempSquares(1).GetState() = tempSquares(2).GetState() Then
            If attackMode Then
                If tempSquares(1).GetState() = "o" Then
                    Return tempSquares(0)
                Else
                    Return Nothing
                End If
            Else
                Return tempSquares(0)
            End If
        End If

        Return Nothing
    End Function

    Public Function CheckIfWin(ByRef isGameOver As Boolean) As Boolean
        If CheckRowsForWin() Or CheckColsForWin() Or CheckDiagsForWin() Then
            isGameOver = True
            MessageBox.Show(_playerSign + " has won!")
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

    Private Function CheckRowColDiag(ByVal sq1 As Square, ByVal sq2 As Square, ByVal sq3 As Square) As Boolean
        If Not (sq1.GetState() = " ") And sq1.GetState() = sq2.GetState() And sq2.GetState() = sq3.GetState() Then
            Return True
        End If
        Return False
    End Function
End Class
