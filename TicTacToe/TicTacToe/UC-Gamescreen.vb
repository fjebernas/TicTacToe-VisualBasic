Public Class UC_Gamescreen
    Dim gameboard As Object
    Private _btnArray(,) As Button

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _btnArray = {
            {btn00, btn01, btn02},
            {btn10, btn11, btn12},
            {btn20, btn21, btn22}
        }

        'gameboard = New Gameboard(lblGamescreenHeader)
        gameboard = New Gameboard(_btnArray, True)
    End Sub

#Region "First Row"
    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        gameboard.SquareUpdate(0, 0)
    End Sub

    Private Sub btn01_Click(sender As Object, e As EventArgs) Handles btn01.Click
        gameboard.SquareUpdate(0, 1)
    End Sub

    Private Sub btn02_Click(sender As Object, e As EventArgs) Handles btn02.Click
        gameboard.SquareUpdate(0, 2)
    End Sub
#End Region

#Region "Second Row"
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        gameboard.SquareUpdate(1, 0)
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        gameboard.SquareUpdate(1, 1)
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        gameboard.SquareUpdate(1, 2)
    End Sub
#End Region

#Region "Third Row"
    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        gameboard.SquareUpdate(2, 0)
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        gameboard.SquareUpdate(2, 1)
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        gameboard.SquareUpdate(2, 2)
    End Sub
#End Region

End Class
