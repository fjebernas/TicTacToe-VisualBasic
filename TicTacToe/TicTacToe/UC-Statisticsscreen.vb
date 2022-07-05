Public Class UC_Statisticsscreen
    Public Shared scoreX As Byte
    Public Shared scoreO As Byte
    Public Shared scoreDraws As Byte

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        lblScoreX.Text = scoreX
        lblScoreO.Text = scoreO
        lblScoreDraws.Text = scoreDraws
    End Sub
End Class
