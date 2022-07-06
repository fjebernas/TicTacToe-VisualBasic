<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Statisticsscreen
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
        Me.lblStatisticsheader = New System.Windows.Forms.Label()
        Me.lblPlayerX = New System.Windows.Forms.Label()
        Me.lblPlayerO = New System.Windows.Forms.Label()
        Me.lblDraws = New System.Windows.Forms.Label()
        Me.lblScoreX = New System.Windows.Forms.Label()
        Me.lblScoreO = New System.Windows.Forms.Label()
        Me.lblScoreDraws2P = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblScoreYou = New System.Windows.Forms.Label()
        Me.lblScoreCPU = New System.Windows.Forms.Label()
        Me.lblScoreDraws1P = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStatisticsheader
        '
        Me.lblStatisticsheader.AutoSize = True
        Me.lblStatisticsheader.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatisticsheader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStatisticsheader.Location = New System.Drawing.Point(139, 43)
        Me.lblStatisticsheader.Name = "lblStatisticsheader"
        Me.lblStatisticsheader.Size = New System.Drawing.Size(303, 41)
        Me.lblStatisticsheader.TabIndex = 1
        Me.lblStatisticsheader.Text = "Game Statistics"
        '
        'lblPlayerX
        '
        Me.lblPlayerX.AutoSize = True
        Me.lblPlayerX.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPlayerX.Location = New System.Drawing.Point(54, 362)
        Me.lblPlayerX.Name = "lblPlayerX"
        Me.lblPlayerX.Size = New System.Drawing.Size(428, 28)
        Me.lblPlayerX.TabIndex = 1
        Me.lblPlayerX.Text = "Player X........................"
        '
        'lblPlayerO
        '
        Me.lblPlayerO.AutoSize = True
        Me.lblPlayerO.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPlayerO.Location = New System.Drawing.Point(54, 417)
        Me.lblPlayerO.Name = "lblPlayerO"
        Me.lblPlayerO.Size = New System.Drawing.Size(428, 28)
        Me.lblPlayerO.TabIndex = 1
        Me.lblPlayerO.Text = "Player O........................"
        '
        'lblDraws
        '
        Me.lblDraws.AutoSize = True
        Me.lblDraws.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDraws.ForeColor = System.Drawing.Color.Green
        Me.lblDraws.Location = New System.Drawing.Point(54, 472)
        Me.lblDraws.Name = "lblDraws"
        Me.lblDraws.Size = New System.Drawing.Size(428, 28)
        Me.lblDraws.TabIndex = 1
        Me.lblDraws.Text = "Draws..........................."
        '
        'lblScoreX
        '
        Me.lblScoreX.AutoSize = True
        Me.lblScoreX.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreX.ForeColor = System.Drawing.Color.Red
        Me.lblScoreX.Location = New System.Drawing.Point(482, 362)
        Me.lblScoreX.Name = "lblScoreX"
        Me.lblScoreX.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreX.TabIndex = 1
        Me.lblScoreX.Text = "0"
        '
        'lblScoreO
        '
        Me.lblScoreO.AutoSize = True
        Me.lblScoreO.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreO.ForeColor = System.Drawing.Color.Blue
        Me.lblScoreO.Location = New System.Drawing.Point(482, 417)
        Me.lblScoreO.Name = "lblScoreO"
        Me.lblScoreO.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreO.TabIndex = 1
        Me.lblScoreO.Text = "0"
        '
        'lblScoreDraws2P
        '
        Me.lblScoreDraws2P.AutoSize = True
        Me.lblScoreDraws2P.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreDraws2P.ForeColor = System.Drawing.Color.Lime
        Me.lblScoreDraws2P.Location = New System.Drawing.Point(482, 472)
        Me.lblScoreDraws2P.Name = "lblScoreDraws2P"
        Me.lblScoreDraws2P.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreDraws2P.TabIndex = 1
        Me.lblScoreDraws2P.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(259, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2P"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(259, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 34)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1P"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(54, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(428, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "You............................."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(54, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(428, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CPU............................."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(54, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(428, 28)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Draws..........................."
        '
        'lblScoreYou
        '
        Me.lblScoreYou.AutoSize = True
        Me.lblScoreYou.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreYou.ForeColor = System.Drawing.Color.Red
        Me.lblScoreYou.Location = New System.Drawing.Point(482, 155)
        Me.lblScoreYou.Name = "lblScoreYou"
        Me.lblScoreYou.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreYou.TabIndex = 1
        Me.lblScoreYou.Text = "0"
        '
        'lblScoreCPU
        '
        Me.lblScoreCPU.AutoSize = True
        Me.lblScoreCPU.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreCPU.ForeColor = System.Drawing.Color.Blue
        Me.lblScoreCPU.Location = New System.Drawing.Point(482, 210)
        Me.lblScoreCPU.Name = "lblScoreCPU"
        Me.lblScoreCPU.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreCPU.TabIndex = 1
        Me.lblScoreCPU.Text = "0"
        '
        'lblScoreDraws1P
        '
        Me.lblScoreDraws1P.AutoSize = True
        Me.lblScoreDraws1P.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreDraws1P.ForeColor = System.Drawing.Color.Lime
        Me.lblScoreDraws1P.Location = New System.Drawing.Point(482, 265)
        Me.lblScoreDraws1P.Name = "lblScoreDraws1P"
        Me.lblScoreDraws1P.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreDraws1P.TabIndex = 1
        Me.lblScoreDraws1P.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(40, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 34)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "============="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(302, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(223, 34)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "============="
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gray
        Me.Label11.Location = New System.Drawing.Point(40, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 34)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "============="
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gray
        Me.Label12.Location = New System.Drawing.Point(302, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(223, 34)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "============="
        '
        'UC_Statisticsscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblScoreDraws1P)
        Me.Controls.Add(Me.lblScoreDraws2P)
        Me.Controls.Add(Me.lblScoreCPU)
        Me.Controls.Add(Me.lblScoreO)
        Me.Controls.Add(Me.lblScoreYou)
        Me.Controls.Add(Me.lblScoreX)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPlayerO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayerX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStatisticsheader)
        Me.Name = "UC_Statisticsscreen"
        Me.Size = New System.Drawing.Size(555, 555)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStatisticsheader As Label
    Friend WithEvents lblPlayerX As Label
    Friend WithEvents lblPlayerO As Label
    Friend WithEvents lblDraws As Label
    Friend WithEvents lblScoreX As Label
    Friend WithEvents lblScoreO As Label
    Friend WithEvents lblScoreDraws2P As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblScoreYou As Label
    Friend WithEvents lblScoreCPU As Label
    Friend WithEvents lblScoreDraws1P As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
End Class
