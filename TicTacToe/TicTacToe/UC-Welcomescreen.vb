Public Class UC_Welcomescreen
    Dim mainForm As FormMain
    Public Shared gameMode As Boolean
    Public Sub New(passedForm As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainForm = passedForm
        gameMode = True
    End Sub

    Private Sub btnPlay1P_Click(sender As Object, e As EventArgs) Handles btnPlay1P.Click
        gameMode = True
        Toolbox.CreateInstance(New UC_Gamescreen(gameMode), mainForm)
    End Sub

    Private Sub btnPlay2P_Click(sender As Object, e As EventArgs) Handles btnPlay2P.Click
        gameMode = False
        Toolbox.CreateInstance(New UC_Gamescreen(gameMode), mainForm)
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs)
        Toolbox.CreateInstance(New UC_Gamescreen(gameMode), mainForm)
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Toolbox.CreateInstance(New UC_Statisticsscreen, mainForm)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        mainForm.Close()
    End Sub
End Class
