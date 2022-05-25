Module Toolbox
    Public Function CreateInstance(ByVal userControl As Control, form As FormMain) As Integer
        For Each item As Control In form.panelContent.Controls
            item.Dispose()
        Next

        form.panelContent.Controls.Add(userControl)
        userControl.Dock = DockStyle.Fill

        Return 0
    End Function
End Module
