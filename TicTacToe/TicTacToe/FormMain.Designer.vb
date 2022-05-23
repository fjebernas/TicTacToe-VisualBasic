<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.btnWelcomescreen = New System.Windows.Forms.Button()
        Me.btnGamescreen = New System.Windows.Forms.Button()
        Me.btnStatisticsscreen = New System.Windows.Forms.Button()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnWelcomescreen
        '
        Me.btnWelcomescreen.BackColor = System.Drawing.Color.Green
        Me.btnWelcomescreen.FlatAppearance.BorderSize = 0
        Me.btnWelcomescreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWelcomescreen.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWelcomescreen.ForeColor = System.Drawing.Color.White
        Me.btnWelcomescreen.Location = New System.Drawing.Point(13, 13)
        Me.btnWelcomescreen.Name = "btnWelcomescreen"
        Me.btnWelcomescreen.Size = New System.Drawing.Size(181, 41)
        Me.btnWelcomescreen.TabIndex = 0
        Me.btnWelcomescreen.Text = "Welcome"
        Me.btnWelcomescreen.UseVisualStyleBackColor = False
        '
        'btnGamescreen
        '
        Me.btnGamescreen.BackColor = System.Drawing.Color.White
        Me.btnGamescreen.FlatAppearance.BorderSize = 0
        Me.btnGamescreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGamescreen.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGamescreen.Location = New System.Drawing.Point(200, 13)
        Me.btnGamescreen.Name = "btnGamescreen"
        Me.btnGamescreen.Size = New System.Drawing.Size(181, 41)
        Me.btnGamescreen.TabIndex = 0
        Me.btnGamescreen.Text = "Play"
        Me.btnGamescreen.UseVisualStyleBackColor = False
        '
        'btnStatisticsscreen
        '
        Me.btnStatisticsscreen.BackColor = System.Drawing.Color.White
        Me.btnStatisticsscreen.FlatAppearance.BorderSize = 0
        Me.btnStatisticsscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatisticsscreen.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatisticsscreen.Location = New System.Drawing.Point(387, 13)
        Me.btnStatisticsscreen.Name = "btnStatisticsscreen"
        Me.btnStatisticsscreen.Size = New System.Drawing.Size(181, 41)
        Me.btnStatisticsscreen.TabIndex = 0
        Me.btnStatisticsscreen.Text = "Statistics"
        Me.btnStatisticsscreen.UseVisualStyleBackColor = False
        '
        'panelContent
        '
        Me.panelContent.Location = New System.Drawing.Point(13, 61)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(555, 555)
        Me.panelContent.TabIndex = 1
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(579, 632)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.btnStatisticsscreen)
        Me.Controls.Add(Me.btnGamescreen)
        Me.Controls.Add(Me.btnWelcomescreen)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicTacToe using VisualBasic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWelcomescreen As Button
    Friend WithEvents btnGamescreen As Button
    Friend WithEvents btnStatisticsscreen As Button
    Friend WithEvents panelContent As Panel
End Class
