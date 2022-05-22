<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Welcomescreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tic Tac Toe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "by Francis Bernas"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(202, 304)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(145, 43)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnStatistics.FlatAppearance.BorderSize = 0
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistics.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(202, 353)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(145, 43)
        Me.btnStatistics.TabIndex = 1
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(202, 402)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(145, 43)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit Game"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'UC_Welcomescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UC_Welcomescreen"
        Me.Size = New System.Drawing.Size(555, 555)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnQuit As Button
End Class
