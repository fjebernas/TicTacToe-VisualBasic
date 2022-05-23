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
    End Sub
End Class
