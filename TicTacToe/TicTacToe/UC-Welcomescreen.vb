Public Class UC_Welcomescreen
    Dim mainForm As New FormMain
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        mainForm.CreateInstance(New UC_Gamescreen)
    End Sub
End Class
