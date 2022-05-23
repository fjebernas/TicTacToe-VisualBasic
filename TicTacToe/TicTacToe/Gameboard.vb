Public Class Gameboard
    Private flag As Boolean
    Private ReadOnly matrix(3, 3) As Char
    Private moveCount As Byte
    Private isGameOver As Boolean

    Public Sub New()
        flag = False
        moveCount = 0
        matrix(0, 0) = "."
        matrix(0, 1) = "."
        matrix(0, 2) = "."
        matrix(1, 0) = "."
        matrix(1, 1) = "."
        matrix(1, 2) = "."
        matrix(2, 0) = "."
        matrix(2, 1) = "."
        matrix(2, 2) = "."
    End Sub

    Public Sub Move(ByVal row As Byte, ByVal column As Byte, ByVal btn As Button)
        If Not flag Then
            matrix(row, column) = "x"
            btn.BackColor = Color.Blue
        Else
            matrix(row, column) = "o"
            btn.BackColor = Color.Green
        End If

        flag = Not flag
        btn.Enabled = False
        moveCount += 1

        CheckStatus()
    End Sub

    Private Sub CheckStatus()
        'check horizontals, verticals and diagonals for x
        If matrix(0, 0) = "x" And matrix(0, 1) = "x" And matrix(0, 2) = "x" Or
            matrix(1, 0) = "x" And matrix(1, 1) = "x" And matrix(1, 2) = "x" Or
            matrix(2, 0) = "x" And matrix(2, 1) = "x" And matrix(2, 2) = "x" Or
            matrix(0, 0) = "x" And matrix(1, 0) = "x" And matrix(2, 0) = "x" Or
            matrix(0, 1) = "x" And matrix(1, 1) = "x" And matrix(2, 1) = "x" Or
            matrix(0, 2) = "x" And matrix(1, 2) = "x" And matrix(2, 2) = "x" Or
            matrix(0, 0) = "x" And matrix(1, 1) = "x" And matrix(2, 2) = "x" Or
            matrix(0, 2) = "x" And matrix(1, 1) = "x" And matrix(2, 0) = "x" Then
            MessageBox.Show("X wins!")
            isGameOver = True
            'check horizontals, verticals and diagonals for o
        ElseIf matrix(0, 0) = "o" And matrix(0, 1) = "o" And matrix(0, 2) = "o" Or
            matrix(1, 0) = "o" And matrix(1, 1) = "o" And matrix(1, 2) = "o" Or
            matrix(2, 0) = "o" And matrix(2, 1) = "o" And matrix(2, 2) = "o" Or
            matrix(0, 0) = "o" And matrix(1, 0) = "o" And matrix(2, 0) = "o" Or
            matrix(0, 1) = "o" And matrix(1, 1) = "o" And matrix(2, 1) = "o" Or
            matrix(0, 2) = "o" And matrix(1, 2) = "o" And matrix(2, 2) = "o" Or
            matrix(0, 0) = "o" And matrix(1, 1) = "o" And matrix(2, 2) = "o" Or
            matrix(0, 2) = "o" And matrix(1, 1) = "o" And matrix(2, 0) = "o" Then
            MessageBox.Show("O wins!")
            isGameOver = True
        ElseIf moveCount = 9 Then
            MessageBox.Show("Draw!")
            isGameOver = True
        End If
    End Sub
End Class
