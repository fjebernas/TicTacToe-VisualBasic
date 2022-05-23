Public Class UC_Gamescreen
    Dim gameboard As Object

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gameboard = New Gameboard
    End Sub


End Class
