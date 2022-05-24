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
        Me.lblWelcomeheader = New System.Windows.Forms.Label()
        Me.lblWelcomesubheader = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcomeheader
        '
        Me.lblWelcomeheader.AutoSize = True
        Me.lblWelcomeheader.Font = New System.Drawing.Font("Consolas", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeheader.ForeColor = System.Drawing.Color.Magenta
        Me.lblWelcomeheader.Location = New System.Drawing.Point(143, 113)
        Me.lblWelcomeheader.Name = "lblWelcomeheader"
        Me.lblWelcomeheader.Size = New System.Drawing.Size(262, 47)
        Me.lblWelcomeheader.TabIndex = 0
        Me.lblWelcomeheader.Text = "Tic Tac Toe"
        '
        'lblWelcomesubheader
        '
        Me.lblWelcomesubheader.AutoSize = True
        Me.lblWelcomesubheader.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomesubheader.ForeColor = System.Drawing.Color.Blue
        Me.lblWelcomesubheader.Location = New System.Drawing.Point(158, 178)
        Me.lblWelcomesubheader.Name = "lblWelcomesubheader"
        Me.lblWelcomesubheader.Size = New System.Drawing.Size(233, 28)
        Me.lblWelcomesubheader.TabIndex = 0
        Me.lblWelcomesubheader.Text = "by Francis Bernas"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Green
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.Location = New System.Drawing.Point(202, 304)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(145, 43)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.Navy
        Me.btnStatistics.FlatAppearance.BorderSize = 0
        Me.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistics.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Location = New System.Drawing.Point(202, 353)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(145, 43)
        Me.btnStatistics.TabIndex = 1
        Me.btnStatistics.Text = "Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Maroon
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
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
        Me.Controls.Add(Me.lblWelcomesubheader)
        Me.Controls.Add(Me.lblWelcomeheader)
        Me.Name = "UC_Welcomescreen"
        Me.Size = New System.Drawing.Size(555, 555)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeheader As Label
    Friend WithEvents lblWelcomesubheader As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnQuit As Button
End Class
