'Gameboard class acts as a
'   literal gameboard
'   where it is made up of 3 x 3 squares
'   players can put X and O on those squares
'   it also has a header
'   and that header tells whose turn it is, and announces the winner
Public Class Gameboard
    Private _isGameOver As Boolean
    Private _isXTurn As Boolean
    Private _squareMatrix(3, 3) As Square

    Private _playerX As Player
    Private _playerO As Player
    Private _smartCPU As CPU
    Private _isBattlingCPU As Boolean

    Public Sub New(ByVal btnArray(,) As Button, ByVal isBattlingCPU As Boolean)
        _isGameOver = False
        _isXTurn = True
        For i = 0 To _squareMatrix.GetLength(0) - 1
            For j = 0 To _squareMatrix.GetLength(1) - 1
                _squareMatrix(i, j) = New Square(btnArray(i, j))
            Next
        Next

        _playerX = New Player("x", _squareMatrix)
        'check if 2P mode or CPU mode
        If Not (isBattlingCPU) Then
            _playerO = New Player("o", _squareMatrix)
        Else
            _smartCPU = New CPU("o", _squareMatrix)
            _isBattlingCPU = isBattlingCPU
        End If
    End Sub

    Public Sub SquareUpdate(ByVal row As Byte, ByVal col As Byte)
        If Not (_isGameOver) Then
            If Not (_isBattlingCPU) Then
                If _isXTurn Then
                    _playerX.PutMark(_squareMatrix(row, col))
                    _playerX.CheckIfWin(_isGameOver)
                Else
                    _playerO.PutMark(_squareMatrix(row, col))
                    _playerO.CheckIfWin(_isGameOver)
                End If

                'check if draw
                If _playerX.MoveCount + _playerO.MoveCount = 9 Then
                    MessageBox.Show("Draw!")
                    _isGameOver = True
                End If

                _isXTurn = Not (_isXTurn)
            Else
                _playerX.PutMark(_squareMatrix(row, col))
                _playerX.CheckIfWin(_isGameOver)

                'check if draw *needs refactoring
                If _playerX.MoveCount + _smartCPU.MoveCount = 9 And Not (_isGameOver) Then
                    MessageBox.Show("Draw!")
                    _isGameOver = True
                End If

                If Not (_isGameOver) Then
                    _smartCPU.PutMark()
                    _smartCPU.CheckIfWin(_isGameOver)
                End If

                'check if draw *needs refactoring
                If _playerX.MoveCount + _smartCPU.MoveCount = 9 And Not (_isGameOver) Then
                    MessageBox.Show("Draw!")
                    _isGameOver = True
                End If
            End If
        End If
    End Sub
End Class
