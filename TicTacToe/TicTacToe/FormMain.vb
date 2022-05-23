Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Toolbox.CreateInstance(New UC_Welcomescreen(Me), Me)
    End Sub

    Private Sub btnWelcomescreen_Click(sender As Object, e As EventArgs) Handles btnWelcomescreen.Click
        Toolbox.CreateInstance(New UC_Welcomescreen(Me), Me)
    End Sub

    Private Sub btnGamescreen_Click(sender As Object, e As EventArgs) Handles btnGamescreen.Click
        Toolbox.CreateInstance(New UC_Gamescreen, Me)
    End Sub

    Private Sub btnStatisticsscreen_Click(sender As Object, e As EventArgs) Handles btnStatisticsscreen.Click
        Toolbox.CreateInstance(New UC_Statisticsscreen, Me)
    End Sub

#Region "Custom Functions"
    'Function ButtonHighlight(ByVal btn As Button) As Integer
    '    For Each item As Button In Controls.OfType(Of Button)
    '        item.BackColor = Color.White
    '        item.ForeColor = Color.Black
    '    Next

    '    btn.BackColor = Color.Green
    '    btn.ForeColor = Color.White

    '    Return 0
    'End Function
#End Region

End Class
