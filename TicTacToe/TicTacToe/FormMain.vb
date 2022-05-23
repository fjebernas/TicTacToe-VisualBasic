Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateInstance(New UC_Welcomescreen)
    End Sub

    Private Sub btnWelcomescreen_Click(sender As Object, e As EventArgs) Handles btnWelcomescreen.Click
        Dim btn As Button = sender
        ButtonHighlight(btn)
        CreateInstance(New UC_Welcomescreen)
    End Sub

    Private Sub btnGamescreen_Click(sender As Object, e As EventArgs) Handles btnGamescreen.Click
        Dim btn As Button = sender
        ButtonHighlight(btn)
        CreateInstance(New UC_Gamescreen)
    End Sub

    Private Sub btnStatisticsscreen_Click(sender As Object, e As EventArgs) Handles btnStatisticsscreen.Click
        Dim btn As Button = sender
        ButtonHighlight(btn)
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

    Function ButtonHighlight(ByVal btn As Button) As Integer
        For Each item As Button In Controls.OfType(Of Button)
            item.BackColor = Color.White
            item.ForeColor = Color.Black
        Next

        btn.BackColor = Color.Green
        btn.ForeColor = Color.White

        Return 0
    End Function
#End Region

End Class
