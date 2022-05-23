Public Class UC_Gamescreen
    Dim gameboard As Object

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gameboard = New Gameboard
    End Sub

#Region "First Row"
    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        Dim btn As Button = sender
        gameboard.Move(0, 0, btn)
    End Sub

    Private Sub btn01_Click(sender As Object, e As EventArgs) Handles btn01.Click
        Dim btn As Button = sender
        gameboard.Move(0, 1, btn)
    End Sub

    Private Sub btn02_Click(sender As Object, e As EventArgs) Handles btn02.Click
        Dim btn As Button = sender
        gameboard.Move(0, 2, btn)
    End Sub
#End Region

#Region "Second Row"
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        Dim btn As Button = sender
        gameboard.Move(1, 0, btn)
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        Dim btn As Button = sender
        gameboard.Move(1, 1, btn)
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        Dim btn As Button = sender
        gameboard.Move(1, 2, btn)
    End Sub
#End Region

#Region "Third Row"
    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        Dim btn As Button = sender
        gameboard.Move(2, 0, btn)
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        Dim btn As Button = sender
        gameboard.Move(2, 1, btn)
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        Dim btn As Button = sender
        gameboard.Move(2, 2, btn)
    End Sub
#End Region

End Class
