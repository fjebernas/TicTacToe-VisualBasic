﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblScoreDraws = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblStatisticsheader
        '
        Me.lblStatisticsheader.AutoSize = True
        Me.lblStatisticsheader.Font = New System.Drawing.Font("Consolas", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatisticsheader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStatisticsheader.Location = New System.Drawing.Point(133, 91)
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
        Me.lblPlayerX.Location = New System.Drawing.Point(48, 205)
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
        Me.lblPlayerO.Location = New System.Drawing.Point(48, 260)
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
        Me.lblDraws.Location = New System.Drawing.Point(48, 315)
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
        Me.lblScoreX.Location = New System.Drawing.Point(476, 205)
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
        Me.lblScoreO.Location = New System.Drawing.Point(476, 260)
        Me.lblScoreO.Name = "lblScoreO"
        Me.lblScoreO.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreO.TabIndex = 1
        Me.lblScoreO.Text = "0"
        '
        'lblScoreDraws
        '
        Me.lblScoreDraws.AutoSize = True
        Me.lblScoreDraws.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreDraws.ForeColor = System.Drawing.Color.Lime
        Me.lblScoreDraws.Location = New System.Drawing.Point(476, 315)
        Me.lblScoreDraws.Name = "lblScoreDraws"
        Me.lblScoreDraws.Size = New System.Drawing.Size(25, 28)
        Me.lblScoreDraws.TabIndex = 1
        Me.lblScoreDraws.Text = "0"
        '
        'UC_Statisticsscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblScoreDraws)
        Me.Controls.Add(Me.lblScoreO)
        Me.Controls.Add(Me.lblScoreX)
        Me.Controls.Add(Me.lblDraws)
        Me.Controls.Add(Me.lblPlayerO)
        Me.Controls.Add(Me.lblPlayerX)
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
    Friend WithEvents lblScoreDraws As Label
End Class
