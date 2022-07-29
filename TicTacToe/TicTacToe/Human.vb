
Public Class Human
    Inherits Player

    Public Sub New(playerSign As Char, squareMatrix(,) As Square)
        MyBase.New(playerSign, squareMatrix)
    End Sub

    Public Sub PutMark(ByVal square As Square)
        square.Trigger(_playerSign)
        _moveCount += 1
    End Sub
End Class
