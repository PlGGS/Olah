<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.timController1 = New System.Windows.Forms.Timer(Me.components)
        Me.timController2 = New System.Windows.Forms.Timer(Me.components)
        Me.timController3 = New System.Windows.Forms.Timer(Me.components)
        Me.timController4 = New System.Windows.Forms.Timer(Me.components)
        Me.timMenu = New System.Windows.Forms.Timer(Me.components)
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnInstructions = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picPlayer4Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer3Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer4Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer3Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Connected = New System.Windows.Forms.PictureBox()
        Me.lblOlah = New System.Windows.Forms.Label()
        Me.btnFairUse = New System.Windows.Forms.Button()
        CType(Me.picPlayer4Disconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3Disconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Disconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Disconnected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer4Connected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3Connected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2Connected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1Connected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timController1
        '
        Me.timController1.Enabled = True
        Me.timController1.Interval = 1
        '
        'timController2
        '
        Me.timController2.Enabled = True
        Me.timController2.Interval = 1
        '
        'timController3
        '
        Me.timController3.Enabled = True
        Me.timController3.Interval = 1
        '
        'timController4
        '
        Me.timController4.Enabled = True
        Me.timController4.Interval = 1
        '
        'timMenu
        '
        Me.timMenu.Enabled = True
        Me.timMenu.Interval = 1
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnPlay.Location = New System.Drawing.Point(158, 271)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(498, 43)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play!"
        Me.btnPlay.UseVisualStyleBackColor = False
        Me.btnPlay.Visible = False
        '
        'btnInstructions
        '
        Me.btnInstructions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstructions.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstructions.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInstructions.Location = New System.Drawing.Point(158, 333)
        Me.btnInstructions.Name = "btnInstructions"
        Me.btnInstructions.Size = New System.Drawing.Size(498, 43)
        Me.btnInstructions.TabIndex = 5
        Me.btnInstructions.Text = "Instructions"
        Me.btnInstructions.UseVisualStyleBackColor = False
        Me.btnInstructions.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExit.Location = New System.Drawing.Point(158, 457)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(498, 43)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'picPlayer4Disconnected
        '
        Me.picPlayer4Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer4Disconnected.Location = New System.Drawing.Point(1094, 353)
        Me.picPlayer4Disconnected.Name = "picPlayer4Disconnected"
        Me.picPlayer4Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer4Disconnected.TabIndex = 14
        Me.picPlayer4Disconnected.TabStop = False
        Me.picPlayer4Disconnected.Visible = False
        '
        'picPlayer3Disconnected
        '
        Me.picPlayer3Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer3Disconnected.Location = New System.Drawing.Point(828, 353)
        Me.picPlayer3Disconnected.Name = "picPlayer3Disconnected"
        Me.picPlayer3Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer3Disconnected.TabIndex = 13
        Me.picPlayer3Disconnected.TabStop = False
        Me.picPlayer3Disconnected.Visible = False
        '
        'picPlayer2Disconnected
        '
        Me.picPlayer2Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer2Disconnected.Location = New System.Drawing.Point(1094, 88)
        Me.picPlayer2Disconnected.Name = "picPlayer2Disconnected"
        Me.picPlayer2Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer2Disconnected.TabIndex = 12
        Me.picPlayer2Disconnected.TabStop = False
        Me.picPlayer2Disconnected.Visible = False
        '
        'picPlayer1Disconnected
        '
        Me.picPlayer1Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer1Disconnected.Location = New System.Drawing.Point(828, 88)
        Me.picPlayer1Disconnected.Name = "picPlayer1Disconnected"
        Me.picPlayer1Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer1Disconnected.TabIndex = 11
        Me.picPlayer1Disconnected.TabStop = False
        Me.picPlayer1Disconnected.Visible = False
        '
        'picPlayer4Connected
        '
        Me.picPlayer4Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer4Connected.Location = New System.Drawing.Point(1094, 353)
        Me.picPlayer4Connected.Name = "picPlayer4Connected"
        Me.picPlayer4Connected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer4Connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlayer4Connected.TabIndex = 10
        Me.picPlayer4Connected.TabStop = False
        Me.picPlayer4Connected.Visible = False
        '
        'picPlayer3Connected
        '
        Me.picPlayer3Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer3Connected.Location = New System.Drawing.Point(828, 353)
        Me.picPlayer3Connected.Name = "picPlayer3Connected"
        Me.picPlayer3Connected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer3Connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlayer3Connected.TabIndex = 9
        Me.picPlayer3Connected.TabStop = False
        Me.picPlayer3Connected.Visible = False
        '
        'picPlayer2Connected
        '
        Me.picPlayer2Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer2Connected.Location = New System.Drawing.Point(1094, 88)
        Me.picPlayer2Connected.Name = "picPlayer2Connected"
        Me.picPlayer2Connected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer2Connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlayer2Connected.TabIndex = 8
        Me.picPlayer2Connected.TabStop = False
        Me.picPlayer2Connected.Visible = False
        '
        'picPlayer1Connected
        '
        Me.picPlayer1Connected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer1Connected.Location = New System.Drawing.Point(828, 88)
        Me.picPlayer1Connected.Name = "picPlayer1Connected"
        Me.picPlayer1Connected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer1Connected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picPlayer1Connected.TabIndex = 7
        Me.picPlayer1Connected.TabStop = False
        Me.picPlayer1Connected.Visible = False
        '
        'lblOlah
        '
        Me.lblOlah.Font = New System.Drawing.Font("Halo", 200.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOlah.Image = CType(resources.GetObject("lblOlah.Image"), System.Drawing.Image)
        Me.lblOlah.Location = New System.Drawing.Point(-1, 0)
        Me.lblOlah.Name = "lblOlah"
        Me.lblOlah.Size = New System.Drawing.Size(1370, 729)
        Me.lblOlah.TabIndex = 3
        Me.lblOlah.Text = "olah"
        Me.lblOlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFairUse
        '
        Me.btnFairUse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFairUse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFairUse.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFairUse.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFairUse.Location = New System.Drawing.Point(158, 396)
        Me.btnFairUse.Name = "btnFairUse"
        Me.btnFairUse.Size = New System.Drawing.Size(498, 43)
        Me.btnFairUse.TabIndex = 15
        Me.btnFairUse.Text = "Fair Use"
        Me.btnFairUse.UseVisualStyleBackColor = False
        Me.btnFairUse.Visible = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.btnFairUse)
        Me.Controls.Add(Me.picPlayer4Disconnected)
        Me.Controls.Add(Me.picPlayer3Disconnected)
        Me.Controls.Add(Me.picPlayer2Disconnected)
        Me.Controls.Add(Me.picPlayer1Disconnected)
        Me.Controls.Add(Me.picPlayer4Connected)
        Me.Controls.Add(Me.picPlayer3Connected)
        Me.Controls.Add(Me.picPlayer2Connected)
        Me.Controls.Add(Me.picPlayer1Connected)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInstructions)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblOlah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Olah"
        CType(Me.picPlayer4Disconnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3Disconnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Disconnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Disconnected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer4Connected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3Connected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2Connected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1Connected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timController1 As System.Windows.Forms.Timer
    Friend WithEvents timController2 As System.Windows.Forms.Timer
    Friend WithEvents timController3 As System.Windows.Forms.Timer
    Friend WithEvents timController4 As System.Windows.Forms.Timer
    Friend WithEvents lblOlah As System.Windows.Forms.Label
    Friend WithEvents timMenu As System.Windows.Forms.Timer
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnInstructions As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents picPlayer1Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer4Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer4Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents btnFairUse As System.Windows.Forms.Button

End Class
