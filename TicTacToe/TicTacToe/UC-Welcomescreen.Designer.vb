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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_Welcomescreen))
        Me.lblWelcomeheader = New System.Windows.Forms.Label()
        Me.lblWelcomesubheader = New System.Windows.Forms.Label()
        Me.btnPlay2P = New System.Windows.Forms.Button()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnPlay1P = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnPlay2P
        '
        Me.btnPlay2P.BackColor = System.Drawing.Color.Green
        Me.btnPlay2P.FlatAppearance.BorderSize = 0
        Me.btnPlay2P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlay2P.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay2P.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay2P.ForeColor = System.Drawing.Color.Yellow
        Me.btnPlay2P.Location = New System.Drawing.Point(202, 353)
        Me.btnPlay2P.Name = "btnPlay2P"
        Me.btnPlay2P.Size = New System.Drawing.Size(145, 43)
        Me.btnPlay2P.TabIndex = 1
        Me.btnPlay2P.Text = "2 Players"
        Me.btnPlay2P.UseVisualStyleBackColor = False
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.Teal
        Me.btnStatistics.FlatAppearance.BorderSize = 0
        Me.btnStatistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistics.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.ForeColor = System.Drawing.Color.White
        Me.btnStatistics.Location = New System.Drawing.Point(202, 402)
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
        Me.btnQuit.Location = New System.Drawing.Point(202, 451)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(145, 43)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Quit Game"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnPlay1P
        '
        Me.btnPlay1P.BackColor = System.Drawing.Color.Green
        Me.btnPlay1P.FlatAppearance.BorderSize = 0
        Me.btnPlay1P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPlay1P.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay1P.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay1P.ForeColor = System.Drawing.Color.Yellow
        Me.btnPlay1P.Location = New System.Drawing.Point(202, 304)
        Me.btnPlay1P.Name = "btnPlay1P"
        Me.btnPlay1P.Size = New System.Drawing.Size(145, 43)
        Me.btnPlay1P.TabIndex = 1
        Me.btnPlay1P.Text = "1 Player"
        Me.btnPlay1P.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(161, 308)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'UC_Welcomescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.btnPlay1P)
        Me.Controls.Add(Me.btnPlay2P)
        Me.Controls.Add(Me.lblWelcomesubheader)
        Me.Controls.Add(Me.lblWelcomeheader)
        Me.Name = "UC_Welcomescreen"
        Me.Size = New System.Drawing.Size(555, 555)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeheader As Label
    Friend WithEvents lblWelcomesubheader As Label
    Friend WithEvents btnPlay2P As Button
    Friend WithEvents btnStatistics As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnPlay1P As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
