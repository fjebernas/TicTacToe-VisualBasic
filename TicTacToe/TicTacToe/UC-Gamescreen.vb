Public Class UC_Gamescreen
    Dim gameboard As Object
    Private _btnArray(,) As Button

    Public Sub New(ByVal gameMode As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _btnArray = {
            {btn00, btn01, btn02},
            {btn10, btn11, btn12},
            {btn20, btn21, btn22}
        }

        'gameboard = New Gameboard(lblGamescreenHeader)
        gameboard = New Gameboard(_btnArray, gameMode, lblGamescreenHeader)
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btn00.Click, btn22.Click, btn21.Click, btn20.Click, btn12.Click, btn11.Click, btn10.Click, btn02.Click, btn01.Click
        Dim btn As Button = sender
        gameboard.SquareUpdate(btn.Tag, btn.Text)
    End Sub

End Class
