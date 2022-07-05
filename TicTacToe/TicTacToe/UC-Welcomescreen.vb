Public Class UC_Welcomescreen
    Dim mainForm As FormMain
    Public Shared gameMode As Boolean
    Public Sub New(passedForm As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mainForm = passedForm
        chkBxCPUMode.Appearance = Appearance.Button
        gameMode = False
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Toolbox.CreateInstance(New UC_Gamescreen(gameMode), mainForm)
    End Sub

    Private Sub btnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        Toolbox.CreateInstance(New UC_Statisticsscreen, mainForm)
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        mainForm.Close()
    End Sub

    Private Sub chkBxCPUMode_CheckedChanged(sender As Object, e As EventArgs) Handles chkBxCPUMode.CheckedChanged
        If chkBxCPUMode.Checked Then
            gameMode = True
            chkBxCPUMode.BackColor = Color.OrangeRed
            chkBxCPUMode.ForeColor = Color.Black
        Else
            gameMode = False
            chkBxCPUMode.BackColor = Color.Black
            chkBxCPUMode.ForeColor = Color.OrangeRed
        End If
    End Sub
End Class
