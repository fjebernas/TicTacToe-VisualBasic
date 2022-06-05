'Gameboard class acts as a
'   literal gameboard
'   where it is made up of 3 x 3 squares
'   players can put X and O on those squares
'   it also has a header
'   and that header tells whose turn it is, and announces the winner
Public Class Gameboard
    Private ReadOnly matrix(3, 3) As Square
    Private ReadOnly arbiter As Arbiter
    Private isGameOver As Boolean
    Private header As Label

    Public Sub New(ByVal headerFromFormmain As Label)
        For i As Byte = 0 To matrix.GetLength(0) - 1
            For j As Byte = 0 To matrix.GetLength(1) - 1
                matrix(i, j) = New Square
            Next
        Next

        arbiter = New Arbiter(matrix)

        header = headerFromFormmain
        header.ForeColor = Color.Yellow
    End Sub

    Public Sub Move(ByVal row As Byte, ByVal column As Byte, ByVal btn As Button)
        If Not (isGameOver) Then
            If arbiter.isXTurn Then
                matrix(row, column).Trigger(True, btn)
            Else
                matrix(row, column).Trigger(False, btn)
            End If
            arbiter.moveCount += 1
            isGameOver = arbiter.CheckIfWin()
            HeaderUpdate()
            arbiter.isXTurn = Not (arbiter.isXTurn)
        End If
    End Sub

    Private Sub HeaderUpdate()
        If Not (isGameOver) Then
            If arbiter.isXTurn Then
                header.Text = "Your turn O!"
            ElseIf Not (arbiter.isXTurn) Then
                header.Text = "Your turn X!"
            End If
        Else
            If arbiter.isXTurn And Not (arbiter.moveCount = 9) Then
                header.Text = "   X WINS!"
                Blink()
            ElseIf Not (arbiter.isXTurn) And Not (arbiter.moveCount = 9) Then
                header.Text = "   O WINS!"
                Blink()
            Else
                header.Text = "   DRAW!"
                Blink()
            End If
        End If
    End Sub

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
