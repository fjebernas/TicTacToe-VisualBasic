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

    Public Shared Sub AddScore(ByVal playerSign As Char, ByVal is2P As Boolean)
        If is2P Then
            If playerSign = "x" Then
                scoreX += 1
            ElseIf playerSign = "o" Then
                scoreO += 1
            ElseIf playerSign = "d" Then
                scoreDraws2P += 1
            End If
        Else
            If playerSign = "x" Then
                scoreYou += 1
            ElseIf playerSign = "o" Then
                scoreCPU += 1
            ElseIf playerSign = "d" Then
                scoreDraws1P += 1
            End If
        End If
    End Sub
End Class
