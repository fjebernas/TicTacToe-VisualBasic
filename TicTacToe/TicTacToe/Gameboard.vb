'Gameboard class acts as a
'   literal gameboard
'   where it is made up of 3 x 3 squares
'   players can put X and O on those squares
'   it also has a header
'   and that header tells whose turn it is, and announces the winner
Public Class Gameboard
    Private _isGameOver As Boolean
    Private _isXTurn As Boolean
    Private _squareMatrix(2, 2) As Square

    Private _playerX As Player
    Private _playerO As Object
    'Private _smartCPU As CPU
    Private _isBattlingCPU As Boolean

    Private _header As Label

    Public Sub New(ByVal btnArray(,) As Button, ByVal isBattlingCPU As Boolean, ByVal lblGamescreen As Label)
        _isGameOver = False
        _isXTurn = True
        _header = lblGamescreen

        For i As Byte = 0 To _squareMatrix.GetLength(0) - 1
            For j As Byte = 0 To _squareMatrix.GetLength(1) - 1
                _squareMatrix(i, j) = New Square(btnArray(i, j))
            Next
        Next

        _playerX = New Player("x", _squareMatrix)
        'check if 2P mode or CPU mode
        If Not (isBattlingCPU) Then
            _playerO = New Player("o", _squareMatrix)
            _header.Text = "Your turn X!"
        Else
            _playerO = New CPU("o", _squareMatrix)
            _isBattlingCPU = isBattlingCPU
            _header.Text = "Battling CPU..."
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
                    _isGameOver = True
                End If
                HeaderUpdate()
                _isXTurn = Not (_isXTurn)
            Else
                _isXTurn = True
                _playerX.PutMark(_squareMatrix(row, col))
                If _playerX.CheckIfWin(_isGameOver) Then
                    HeaderUpdate()
                End If

                'check if draw *needs refactoring
                If _playerX.MoveCount + _playerO.MoveCount = 9 And Not (_isGameOver) Then
                    _isGameOver = True
                    HeaderUpdate()
                End If

                If Not (_isGameOver) Then
                    _isXTurn = False
                    _playerO.PutMark()
                    If _playerO.CheckIfWin(_isGameOver) Then
                        HeaderUpdate()
                    End If
                End If

                'check if draw *needs refactoring
                If _playerX.MoveCount + _playerO.MoveCount = 9 And Not (_isGameOver) Then
                    _isGameOver = True
                    HeaderUpdate()
                End If
            End If
        End If
    End Sub

    Private Sub HeaderUpdate()
        If Not (_isGameOver) Then
            If Not (_isBattlingCPU) Then
                If _isXTurn Then
                    _header.Text = "Your turn O!"
                Else
                    _header.Text = "Your turn X!"
                End If
            End If
        Else
            If _isXTurn And Not (_playerX.MoveCount + _playerO.MoveCount = 9) Then
                If Not (_isBattlingCPU) Then
                    _header.Text = "   X WINS!"
                ElseIf _isBattlingCPU Then
                    _header.Text = "   YOU WIN!"
                End If
            ElseIf Not (_isXTurn) And Not (_playerX.MoveCount + _playerO.MoveCount = 9) Then
                If Not (_isBattlingCPU) Then
                    _header.Text = "   O WINS!"
                Else
                    _header.Text = "   CPU WINS!"
                End If
            Else
                _header.Text = "   DRAW!"
            End If
            Blink()
        End If
    End Sub

    Private Async Sub Blink()
        _header.ForeColor = Color.Yellow
        While True
            Await Task.Delay(300)
            If _header.ForeColor = Color.Yellow Then
                _header.ForeColor = Color.Black
            ElseIf _header.ForeColor = Color.Black Then
                _header.ForeColor = Color.Yellow
            End If
        End While
    End Sub
End Class
