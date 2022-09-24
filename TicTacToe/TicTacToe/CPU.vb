
Public Class CPU
    Inherits Player

    Public Sub New(playerSign As Char, squareMatrix(,) As Square)
        MyBase.New(playerSign, squareMatrix)
    End Sub

    Public Overloads Sub PutMark()
        Dim square As Square = SearchForBestSquareToMark()
        square.Trigger(_playerSign)
        _moveCount += 1
    End Sub

    Private Function SearchForBestSquareToMark() As Square
        Dim sq As Square = FindEmptySquareInNearCompleteLines()

        'if still empty, do random move
        If sq Is Nothing Then
            sq = FindRandomEmptySquare()
        End If
        Return sq
    End Function

    Private Function FindRandomEmptySquare() As Square
        Dim sq As Square
        Dim rnd As Random = New Random()
        Do
            sq = _squareMatrix(rnd.Next(0, _squareMatrix.GetLength(0)), rnd.Next(0, _squareMatrix.GetLength(1)))
        Loop While Not (sq.GetState() = " ")
        Return sq
    End Function

    Private Function FindEmptySquareInNearCompleteLines() As Square
        Dim sq As Square
        Dim isAttacking As Boolean = True

        'attack moves
        'rows
        sq = FindInRows(isAttacking)
        If Not (sq Is Nothing) Then
            Return sq
        End If
        'cols
        sq = FindInCols(isAttacking)
        If Not (sq Is Nothing) Then
            Return sq
        End If
        'diags
        sq = FindInDiags(isAttacking)
        If Not (sq Is Nothing) Then
            Return sq
        End If

        'defend moves
        'rows
        sq = FindInRows(Not (isAttacking))
        If Not (sq Is Nothing) Then
            Return sq
        End If
        'cols
        sq = FindInCols(Not (isAttacking))
        If Not (sq Is Nothing) Then
            Return sq
        End If
        'diags
        sq = FindInDiags(Not (isAttacking))
        If Not (sq Is Nothing) Then
            Return sq
        End If

        Return Nothing
    End Function

    Private Function FindInRows(ByVal isAttacking As Boolean) As Square
        Dim sq As Square
        For i = 0 To _squareMatrix.GetLength(0) - 1
            sq = GetEmptySquareAboutToComplete(_squareMatrix(i, 0), _squareMatrix(i, 1), _squareMatrix(i, 2), isAttacking)
            If Not (sq Is Nothing) Then
                Return sq
            End If
        Next
        Return Nothing
    End Function

    Private Function FindInCols(ByVal isAttacking As Boolean) As Square
        Dim sq As Square
        For i = 0 To _squareMatrix.GetLength(0) - 1
            sq = GetEmptySquareAboutToComplete(_squareMatrix(0, i), _squareMatrix(1, i), _squareMatrix(2, i), isAttacking)
            If Not (sq Is Nothing) Then
                Return sq
            End If
        Next
        Return Nothing
    End Function

    Private Function FindInDiags(ByVal isAttacking As Boolean)
        Dim sq As Square
        sq = GetEmptySquareAboutToComplete(_squareMatrix(0, 0), _squareMatrix(1, 1), _squareMatrix(2, 2), isAttacking)
        If Not (sq Is Nothing) Then
            Return sq
        End If
        sq = GetEmptySquareAboutToComplete(_squareMatrix(0, 2), _squareMatrix(1, 1), _squareMatrix(2, 0), isAttacking)
        If Not (sq Is Nothing) Then
            Return sq
        End If
        Return Nothing
    End Function

    Private Function GetEmptySquareAboutToComplete(ByVal sq1 As Square, ByVal sq2 As Square, ByVal sq3 As Square, ByVal isAttacking As Boolean) As Square
        Dim squares() As Square = {
            sq1, sq2, sq3
        }

        'check if only one is empty, otherwise return nothing
        If IsOnlyOneEmpty(squares) Then
            Return GetEmptySquare(squares, isAttacking)
        End If

        Return Nothing
    End Function

    Private Function IsOnlyOneEmpty(ByVal squares() As Square) As Boolean
        Return squares.Count(Function(x) x.GetState() = " ") = 1
    End Function

    Private Function GetEmptySquare(ByVal squares() As Square, ByVal isAttacking As Boolean) As Square
        PlaceEmptySquareOnFirstIndex(squares)

        'check if the other two squares are the same sign
        If squares(1).GetState() = squares(2).GetState() Then
            If isAttacking Then
                If squares(1).GetState() = "o" Then
                    Return squares(0)
                Else
                    Return Nothing
                End If
            Else
                Return squares(0)
            End If
        End If

        Return Nothing
    End Function

    Private Sub PlaceEmptySquareOnFirstIndex(ByRef squares As Square())
        'place the empty square on the first index(0)
        For i = 0 To squares.Length - 1
            If squares(i).GetState() = " " Then
                Dim tempSq As Square
                tempSq = squares(0)
                squares(0) = squares(i)
                squares(i) = tempSq

                Exit For
            End If
        Next
    End Sub
End Class
