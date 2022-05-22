Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateInstance(New UC_Welcomescreen)
    End Sub

    Private Sub btnWelcomescreen_Click(sender As Object, e As EventArgs) Handles btnWelcomescreen.Click
        CreateInstance(New UC_Welcomescreen)
    End Sub

    Private Sub btnGamescreen_Click(sender As Object, e As EventArgs) Handles btnGamescreen.Click
        CreateInstance(New UC_Gamescreen)
    End Sub

    Private Sub btnStatisticsscreen_Click(sender As Object, e As EventArgs) Handles btnStatisticsscreen.Click
        CreateInstance(New UC_Statisticsscreen)
    End Sub

#Region "Custom Functions"
    Function CreateInstance(ByVal userControl As Control) As Integer
        For Each item As Control In panelContent.Controls
            item.Dispose()
        Next

        panelContent.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill

        Return 0
    End Function
#End Region

End Class
