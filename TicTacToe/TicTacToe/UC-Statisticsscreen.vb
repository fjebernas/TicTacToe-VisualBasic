Public Class UC_Statisticsscreen
    'for 1P mode
    Public Shared scoreYou As Byte
    Public Shared scoreCPU As Byte
    Public Shared scoreDraws1P As Byte

    'for 2P mode
    Public Shared scoreX As Byte
    Public Shared scoreO As Byte
    Public Shared scoreDraws2P As Byte

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblScoreYou.Text = scoreYou
        lblScoreCPU.Text = scoreCPU
        lblScoreDraws1P.Text = scoreDraws1P

        lblScoreX.Text = scoreX
        lblScoreO.Text = scoreO
        lblScoreDraws2P.Text = scoreDraws2P
    End Sub
End Class
