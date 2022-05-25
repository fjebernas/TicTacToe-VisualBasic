Public Class UC_Statisticsscreen
    Private Sub UC_Statisticsscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScoreX.Text = Gameboard.scoreX
        lblScoreO.Text = Gameboard.scoreO
        lblScoreDraws.Text = Gameboard.scoreDraws
    End Sub
End Class
