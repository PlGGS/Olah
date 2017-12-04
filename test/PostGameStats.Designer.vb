<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPostGameStats
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
        Me.lblPostGameWinner = New System.Windows.Forms.Label()
        Me.picP1Stats = New System.Windows.Forms.PictureBox()
        Me.picP2Stats = New System.Windows.Forms.PictureBox()
        Me.picP4Stats = New System.Windows.Forms.PictureBox()
        Me.picP3Stats = New System.Windows.Forms.PictureBox()
        Me.lblP1Name = New System.Windows.Forms.Label()
        Me.lblP2Name = New System.Windows.Forms.Label()
        Me.lblP3Name = New System.Windows.Forms.Label()
        Me.lblP4Name = New System.Windows.Forms.Label()
        Me.lblP1Kills2 = New System.Windows.Forms.Label()
        Me.lblP2Kills2 = New System.Windows.Forms.Label()
        Me.lblP3Kills2 = New System.Windows.Forms.Label()
        Me.lblP4Kills2 = New System.Windows.Forms.Label()
        Me.lblP1Deaths2 = New System.Windows.Forms.Label()
        Me.lblP2Deaths2 = New System.Windows.Forms.Label()
        Me.lblP3Deaths2 = New System.Windows.Forms.Label()
        Me.lblP4Deaths2 = New System.Windows.Forms.Label()
        Me.btnBackToMenu1 = New System.Windows.Forms.Button()
        Me.btnBackToMenu2 = New System.Windows.Forms.Button()
        Me.btnBackToMenu3 = New System.Windows.Forms.Button()
        Me.btnBackToMenu4 = New System.Windows.Forms.Button()
        CType(Me.picP1Stats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Stats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4Stats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3Stats, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPostGameWinner
        '
        Me.lblPostGameWinner.Font = New System.Drawing.Font("Halo", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostGameWinner.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPostGameWinner.Image = Global.SerialCommands1.My.Resources.Resources.Olah_Background
        Me.lblPostGameWinner.Location = New System.Drawing.Point(-6, 0)
        Me.lblPostGameWinner.Name = "lblPostGameWinner"
        Me.lblPostGameWinner.Size = New System.Drawing.Size(1368, 758)
        Me.lblPostGameWinner.TabIndex = 1
        Me.lblPostGameWinner.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Post Game Stats"
        Me.lblPostGameWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picP1Stats
        '
        Me.picP1Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picP1Stats.Location = New System.Drawing.Point(339, 114)
        Me.picP1Stats.Name = "picP1Stats"
        Me.picP1Stats.Size = New System.Drawing.Size(333, 300)
        Me.picP1Stats.TabIndex = 2
        Me.picP1Stats.TabStop = False
        '
        'picP2Stats
        '
        Me.picP2Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picP2Stats.Location = New System.Drawing.Point(678, 114)
        Me.picP2Stats.Name = "picP2Stats"
        Me.picP2Stats.Size = New System.Drawing.Size(333, 300)
        Me.picP2Stats.TabIndex = 3
        Me.picP2Stats.TabStop = False
        '
        'picP4Stats
        '
        Me.picP4Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picP4Stats.Location = New System.Drawing.Point(678, 420)
        Me.picP4Stats.Name = "picP4Stats"
        Me.picP4Stats.Size = New System.Drawing.Size(333, 300)
        Me.picP4Stats.TabIndex = 4
        Me.picP4Stats.TabStop = False
        '
        'picP3Stats
        '
        Me.picP3Stats.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picP3Stats.Location = New System.Drawing.Point(339, 420)
        Me.picP3Stats.Name = "picP3Stats"
        Me.picP3Stats.Size = New System.Drawing.Size(333, 300)
        Me.picP3Stats.TabIndex = 5
        Me.picP3Stats.TabStop = False
        '
        'lblP1Name
        '
        Me.lblP1Name.AutoSize = True
        Me.lblP1Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP1Name.Font = New System.Drawing.Font("Halo", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Name.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Name.Location = New System.Drawing.Point(352, 124)
        Me.lblP1Name.Name = "lblP1Name"
        Me.lblP1Name.Size = New System.Drawing.Size(311, 42)
        Me.lblP1Name.TabIndex = 6
        Me.lblP1Name.Text = "Player 1"
        '
        'lblP2Name
        '
        Me.lblP2Name.AutoSize = True
        Me.lblP2Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP2Name.Font = New System.Drawing.Font("Halo", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Name.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Name.Location = New System.Drawing.Point(696, 124)
        Me.lblP2Name.Name = "lblP2Name"
        Me.lblP2Name.Size = New System.Drawing.Size(301, 37)
        Me.lblP2Name.TabIndex = 7
        Me.lblP2Name.Text = "Player 2"
        '
        'lblP3Name
        '
        Me.lblP3Name.AutoSize = True
        Me.lblP3Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP3Name.Font = New System.Drawing.Font("Halo", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Name.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Name.Location = New System.Drawing.Point(355, 430)
        Me.lblP3Name.Name = "lblP3Name"
        Me.lblP3Name.Size = New System.Drawing.Size(302, 37)
        Me.lblP3Name.TabIndex = 8
        Me.lblP3Name.Text = "Player 3"
        '
        'lblP4Name
        '
        Me.lblP4Name.AutoSize = True
        Me.lblP4Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP4Name.Font = New System.Drawing.Font("Halo", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Name.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Name.Location = New System.Drawing.Point(696, 430)
        Me.lblP4Name.Name = "lblP4Name"
        Me.lblP4Name.Size = New System.Drawing.Size(297, 37)
        Me.lblP4Name.TabIndex = 9
        Me.lblP4Name.Text = "Player 4"
        '
        'lblP1Kills2
        '
        Me.lblP1Kills2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP1Kills2.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Kills2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Kills2.Location = New System.Drawing.Point(359, 195)
        Me.lblP1Kills2.Name = "lblP1Kills2"
        Me.lblP1Kills2.Size = New System.Drawing.Size(290, 42)
        Me.lblP1Kills2.TabIndex = 14
        '
        'lblP2Kills2
        '
        Me.lblP2Kills2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP2Kills2.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Kills2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Kills2.Location = New System.Drawing.Point(702, 195)
        Me.lblP2Kills2.Name = "lblP2Kills2"
        Me.lblP2Kills2.Size = New System.Drawing.Size(287, 42)
        Me.lblP2Kills2.TabIndex = 15
        '
        'lblP3Kills2
        '
        Me.lblP3Kills2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP3Kills2.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Kills2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Kills2.Location = New System.Drawing.Point(362, 498)
        Me.lblP3Kills2.Name = "lblP3Kills2"
        Me.lblP3Kills2.Size = New System.Drawing.Size(287, 42)
        Me.lblP3Kills2.TabIndex = 16
        '
        'lblP4Kills2
        '
        Me.lblP4Kills2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP4Kills2.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Kills2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Kills2.Location = New System.Drawing.Point(695, 498)
        Me.lblP4Kills2.Name = "lblP4Kills2"
        Me.lblP4Kills2.Size = New System.Drawing.Size(294, 42)
        Me.lblP4Kills2.TabIndex = 17
        '
        'lblP1Deaths2
        '
        Me.lblP1Deaths2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP1Deaths2.Font = New System.Drawing.Font("Halo", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Deaths2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Deaths2.Location = New System.Drawing.Point(362, 248)
        Me.lblP1Deaths2.Name = "lblP1Deaths2"
        Me.lblP1Deaths2.Size = New System.Drawing.Size(287, 42)
        Me.lblP1Deaths2.TabIndex = 22
        '
        'lblP2Deaths2
        '
        Me.lblP2Deaths2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP2Deaths2.Font = New System.Drawing.Font("Halo", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Deaths2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Deaths2.Location = New System.Drawing.Point(702, 248)
        Me.lblP2Deaths2.Name = "lblP2Deaths2"
        Me.lblP2Deaths2.Size = New System.Drawing.Size(287, 42)
        Me.lblP2Deaths2.TabIndex = 23
        '
        'lblP3Deaths2
        '
        Me.lblP3Deaths2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP3Deaths2.Font = New System.Drawing.Font("Halo", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Deaths2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Deaths2.Location = New System.Drawing.Point(359, 550)
        Me.lblP3Deaths2.Name = "lblP3Deaths2"
        Me.lblP3Deaths2.Size = New System.Drawing.Size(287, 42)
        Me.lblP3Deaths2.TabIndex = 24
        '
        'lblP4Deaths2
        '
        Me.lblP4Deaths2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP4Deaths2.Font = New System.Drawing.Font("Halo", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Deaths2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Deaths2.Location = New System.Drawing.Point(695, 550)
        Me.lblP4Deaths2.Name = "lblP4Deaths2"
        Me.lblP4Deaths2.Size = New System.Drawing.Size(294, 42)
        Me.lblP4Deaths2.TabIndex = 25
        '
        'btnBackToMenu1
        '
        Me.btnBackToMenu1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackToMenu1.Font = New System.Drawing.Font("Halo", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMenu1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnBackToMenu1.Location = New System.Drawing.Point(362, 314)
        Me.btnBackToMenu1.Name = "btnBackToMenu1"
        Me.btnBackToMenu1.Size = New System.Drawing.Size(287, 82)
        Me.btnBackToMenu1.TabIndex = 26
        Me.btnBackToMenu1.Text = "Exit Game"
        Me.btnBackToMenu1.UseVisualStyleBackColor = False
        '
        'btnBackToMenu2
        '
        Me.btnBackToMenu2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackToMenu2.Font = New System.Drawing.Font("Halo", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMenu2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnBackToMenu2.Location = New System.Drawing.Point(702, 314)
        Me.btnBackToMenu2.Name = "btnBackToMenu2"
        Me.btnBackToMenu2.Size = New System.Drawing.Size(287, 82)
        Me.btnBackToMenu2.TabIndex = 27
        Me.btnBackToMenu2.Text = "Exit Game"
        Me.btnBackToMenu2.UseVisualStyleBackColor = False
        '
        'btnBackToMenu3
        '
        Me.btnBackToMenu3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackToMenu3.Font = New System.Drawing.Font("Halo", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMenu3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnBackToMenu3.Location = New System.Drawing.Point(362, 619)
        Me.btnBackToMenu3.Name = "btnBackToMenu3"
        Me.btnBackToMenu3.Size = New System.Drawing.Size(287, 82)
        Me.btnBackToMenu3.TabIndex = 28
        Me.btnBackToMenu3.Text = "Exit Game"
        Me.btnBackToMenu3.UseVisualStyleBackColor = False
        '
        'btnBackToMenu4
        '
        Me.btnBackToMenu4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackToMenu4.Font = New System.Drawing.Font("Halo", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMenu4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btnBackToMenu4.Location = New System.Drawing.Point(702, 619)
        Me.btnBackToMenu4.Name = "btnBackToMenu4"
        Me.btnBackToMenu4.Size = New System.Drawing.Size(287, 82)
        Me.btnBackToMenu4.TabIndex = 29
        Me.btnBackToMenu4.Text = "Exit Game"
        Me.btnBackToMenu4.UseVisualStyleBackColor = False
        '
        'frmPostGameStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 729)
        Me.Controls.Add(Me.btnBackToMenu4)
        Me.Controls.Add(Me.btnBackToMenu3)
        Me.Controls.Add(Me.btnBackToMenu2)
        Me.Controls.Add(Me.btnBackToMenu1)
        Me.Controls.Add(Me.lblP4Deaths2)
        Me.Controls.Add(Me.lblP3Deaths2)
        Me.Controls.Add(Me.lblP2Deaths2)
        Me.Controls.Add(Me.lblP1Deaths2)
        Me.Controls.Add(Me.lblP4Kills2)
        Me.Controls.Add(Me.lblP3Kills2)
        Me.Controls.Add(Me.lblP2Kills2)
        Me.Controls.Add(Me.lblP1Kills2)
        Me.Controls.Add(Me.lblP4Name)
        Me.Controls.Add(Me.lblP3Name)
        Me.Controls.Add(Me.lblP2Name)
        Me.Controls.Add(Me.lblP1Name)
        Me.Controls.Add(Me.picP3Stats)
        Me.Controls.Add(Me.picP4Stats)
        Me.Controls.Add(Me.picP2Stats)
        Me.Controls.Add(Me.picP1Stats)
        Me.Controls.Add(Me.lblPostGameWinner)
        Me.Name = "frmPostGameStats"
        Me.Text = "Olah"
        CType(Me.picP1Stats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Stats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4Stats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3Stats, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPostGameWinner As System.Windows.Forms.Label
    Friend WithEvents picP1Stats As System.Windows.Forms.PictureBox
    Friend WithEvents picP2Stats As System.Windows.Forms.PictureBox
    Friend WithEvents picP4Stats As System.Windows.Forms.PictureBox
    Friend WithEvents picP3Stats As System.Windows.Forms.PictureBox
    Friend WithEvents lblP1Name As System.Windows.Forms.Label
    Friend WithEvents lblP2Name As System.Windows.Forms.Label
    Friend WithEvents lblP3Name As System.Windows.Forms.Label
    Friend WithEvents lblP4Name As System.Windows.Forms.Label
    Friend WithEvents lblP1Kills2 As System.Windows.Forms.Label
    Friend WithEvents lblP2Kills2 As System.Windows.Forms.Label
    Friend WithEvents lblP3Kills2 As System.Windows.Forms.Label
    Friend WithEvents lblP4Kills2 As System.Windows.Forms.Label
    Friend WithEvents lblP1Deaths2 As System.Windows.Forms.Label
    Friend WithEvents lblP2Deaths2 As System.Windows.Forms.Label
    Friend WithEvents lblP3Deaths2 As System.Windows.Forms.Label
    Friend WithEvents lblP4Deaths2 As System.Windows.Forms.Label
    Friend WithEvents btnBackToMenu1 As System.Windows.Forms.Button
    Friend WithEvents btnBackToMenu2 As System.Windows.Forms.Button
    Friend WithEvents btnBackToMenu3 As System.Windows.Forms.Button
    Friend WithEvents btnBackToMenu4 As System.Windows.Forms.Button
End Class
