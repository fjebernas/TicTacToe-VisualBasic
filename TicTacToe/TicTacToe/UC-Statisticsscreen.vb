Public Class UC_Statisticsscreen
    Private Sub UC_Statisticsscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScoreX.Text = Arbiter.scoreX
        lblScoreO.Text = Arbiter.scoreO
        lblScoreDraws.Text = Arbiter.scoreDraws
    End Sub
End Class
