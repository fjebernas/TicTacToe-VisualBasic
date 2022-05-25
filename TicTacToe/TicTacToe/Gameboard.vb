Public Class Gameboard
    Private flag As Boolean
    Private ReadOnly matrix(3, 3) As Char
    Private moveCount As Byte
    Private isGameOver As Boolean

    Private ReadOnly pngX As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\RedX.PNG")
    Private ReadOnly pngO As Bitmap = New Bitmap("C:\Users\franc\Documents\School\ELECTIVE 3\repos\TicTacToe-folder\TicTacToe\TicTacToe\assets\BlueO.PNG")

    Public Shared scoreX As Byte = 0
    Public Shared scoreO As Byte = 0
    Public Shared scoreDraws As Byte = 0

    Private header As Label

    Public Sub New(ByVal headerFromFormmain As Label)
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

        header = headerFromFormmain
        header.ForeColor = Color.Yellow
    End Sub

    Public Sub Move(ByVal row As Byte, ByVal column As Byte, ByVal btn As Button)
        If Not isGameOver Then
            If Not flag Then
                matrix(row, column) = "x"
                btn.BackgroundImage = pngX
                'header.ForeColor = Color.Blue
                header.Text = "Your turn O!"
            Else
                matrix(row, column) = "o"
                btn.BackgroundImage = pngO
                'header.ForeColor = Color.Red
                header.Text = "Your turn X!"
            End If

            flag = Not flag
            btn.Enabled = False
            moveCount += 1

            CheckStatus()
        End If
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
            'header.ForeColor = Color.Red
            header.Text = "   X WINS!"
            Blink()
            scoreX += 1
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
            'header.ForeColor = Color.Blue
            header.Text = "   O WINS!"
            Blink()
            scoreO += 1
            isGameOver = True
        ElseIf moveCount = 9 Then
            'header.ForeColor = Color.Green
            header.Text = "   DRAW!"
            Blink()
            scoreDraws += 1
            isGameOver = True
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
