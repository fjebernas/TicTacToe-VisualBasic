Imports System

Module Program
    Sub Main(args As String())
        Dim myArray(,) As Integer
        'myArray(3, 3) = New Integer
        myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        }
        Console.WriteLine(myArray.GetLength(0))
        Console.WriteLine(myArray.GetLength(1))
        'For i As Integer = 0 To myArray.GetLength(0) - 1
        '    For j As Integer = 0 To myArray.GetLength(1) - 1
        '        Console.WriteLine(myArray(i, j) & " i:" & i & " j:" & j)
        '    Next
        '    Console.WriteLine(vbCrLf)
        'Next
    End Sub
End Module
