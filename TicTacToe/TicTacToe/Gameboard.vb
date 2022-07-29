
Public Class Gameboard
    Private _isGameOver As Boolean
    Private _isXTurn As Boolean
    Private _squareMatrix(2, 2) As Square

    Private _playerX As Human
    Private _playerO As Object
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

        _playerX = New Human("x", _squareMatrix)
        'check if 2P mode or CPU mode
        If Not (isBattlingCPU) Then
            _playerO = New Human("o", _squareMatrix)
            _header.Text = "Your turn X!"
        Else
            _playerO = New CPU("o", _squareMatrix)
            _isBattlingCPU = isBattlingCPU
            _header.Text = "Battling CPU..."
        End If
    End Sub

    Public Async Sub SquareUpdate(ByVal row As Byte, ByVal col As Byte)
        If Not (_isGameOver) Then
            If Not (_isBattlingCPU) Then
                '2P mode
                If _isXTurn Then
                    _playerX.PutMark(_squareMatrix(row, col))
                    CheckWin(_playerX, True)
                Else
                    _playerO.PutMark(_squareMatrix(row, col))
                    CheckWin(_playerO, True)
                End If

                'check if draw
                CheckDraw(_playerX, _playerO, True)
                HeaderUpdate()

                'if game is not yet finished,
                _isXTurn = Not (_isXTurn)
            Else
                '1P mode
                If _isXTurn Then
                    _playerX.PutMark(_squareMatrix(row, col))
                    CheckWin(_playerX, False)
                Else
                    _playerO.PutMark()
                    CheckWin(_playerO, False)
                End If

                'check if draw
                CheckDraw(_playerX, _playerO, False)
                HeaderUpdate()

                'if game is not yet finished,
                _isXTurn = Not (_isXTurn)

                If Not (_isGameOver) And Not (_isXTurn) Then
                    'delay for cpu to make move
                    ItsCPUsMove(True)
                    Await Task.Delay(500)
                    SquareUpdate(Nothing, Nothing)
                    ItsCPUsMove(False)
                End If
            End If
        End If
    End Sub

    Private Sub CheckWin(ByVal player As Object, ByVal is2P As Boolean)
        If player.CheckIfWin(_isGameOver) Then
            UC_Statisticsscreen.AddScore(player.GetSign(), is2P)
            MyMedia.GetSound("w").Play()
            For Each square As Square In player.WinningSquares
                square.LightUp()
            Next
        End If
    End Sub

    Private Sub CheckDraw(ByVal player1 As Object, ByVal player2 As Object, ByVal is2P As Boolean)
        If player1.MoveCount + player2.MoveCount = 9 Then
            _isGameOver = True
            UC_Statisticsscreen.AddScore("d", is2P)
            MyMedia.GetSound("d").Play()
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

    'prevent player from making a move While waiting For cpu To place a mark
    Private Sub ItsCPUsMove(ByVal yes As Boolean)
        If yes Then
            For Each square As Square In _squareMatrix
                square.Disable()
            Next
        Else
            For Each square As Square In _squareMatrix
                square.Enable()
            Next
        End If
    End Sub
End Class
