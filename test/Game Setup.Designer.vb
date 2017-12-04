<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGameSetup))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.timP1Connect = New System.Windows.Forms.Timer(Me.components)
        Me.timP2Connect = New System.Windows.Forms.Timer(Me.components)
        Me.timP3Connect = New System.Windows.Forms.Timer(Me.components)
        Me.timP4Connect = New System.Windows.Forms.Timer(Me.components)
        Me.timP1Team = New System.Windows.Forms.Timer(Me.components)
        Me.lblOlah = New System.Windows.Forms.Label()
        Me.picPlayer4Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer3Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Disconnected = New System.Windows.Forms.PictureBox()
        Me.picPlayer4Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer3Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer2Connected = New System.Windows.Forms.PictureBox()
        Me.picPlayer1Connected = New System.Windows.Forms.PictureBox()
        Me.timP2Team = New System.Windows.Forms.Timer(Me.components)
        Me.timP3Team = New System.Windows.Forms.Timer(Me.components)
        Me.timP4Team = New System.Windows.Forms.Timer(Me.components)
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
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(158, 396)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(498, 43)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStart.Location = New System.Drawing.Point(158, 333)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(498, 43)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnOptions.Location = New System.Drawing.Point(158, 271)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(498, 43)
        Me.btnOptions.TabIndex = 7
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'timP1Connect
        '
        Me.timP1Connect.Enabled = True
        Me.timP1Connect.Interval = 1
        '
        'timP2Connect
        '
        Me.timP2Connect.Enabled = True
        Me.timP2Connect.Interval = 1
        '
        'timP3Connect
        '
        Me.timP3Connect.Enabled = True
        Me.timP3Connect.Interval = 1
        '
        'timP4Connect
        '
        Me.timP4Connect.Enabled = True
        Me.timP4Connect.Interval = 1
        '
        'timP1Team
        '
        Me.timP1Team.Enabled = True
        Me.timP1Team.Interval = 200
        '
        'lblOlah
        '
        Me.lblOlah.Font = New System.Drawing.Font("Halo", 69.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOlah.Image = CType(resources.GetObject("lblOlah.Image"), System.Drawing.Image)
        Me.lblOlah.Location = New System.Drawing.Point(0, 0)
        Me.lblOlah.Name = "lblOlah"
        Me.lblOlah.Size = New System.Drawing.Size(1370, 768)
        Me.lblOlah.TabIndex = 4
        Me.lblOlah.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Game Setup"
        '
        'picPlayer4Disconnected
        '
        Me.picPlayer4Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer4Disconnected.Location = New System.Drawing.Point(1094, 353)
        Me.picPlayer4Disconnected.Name = "picPlayer4Disconnected"
        Me.picPlayer4Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer4Disconnected.TabIndex = 22
        Me.picPlayer4Disconnected.TabStop = False
        Me.picPlayer4Disconnected.Visible = False
        '
        'picPlayer3Disconnected
        '
        Me.picPlayer3Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer3Disconnected.Location = New System.Drawing.Point(828, 353)
        Me.picPlayer3Disconnected.Name = "picPlayer3Disconnected"
        Me.picPlayer3Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer3Disconnected.TabIndex = 21
        Me.picPlayer3Disconnected.TabStop = False
        Me.picPlayer3Disconnected.Visible = False
        '
        'picPlayer2Disconnected
        '
        Me.picPlayer2Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer2Disconnected.Location = New System.Drawing.Point(1094, 88)
        Me.picPlayer2Disconnected.Name = "picPlayer2Disconnected"
        Me.picPlayer2Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer2Disconnected.TabIndex = 20
        Me.picPlayer2Disconnected.TabStop = False
        Me.picPlayer2Disconnected.Visible = False
        '
        'picPlayer1Disconnected
        '
        Me.picPlayer1Disconnected.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picPlayer1Disconnected.Location = New System.Drawing.Point(828, 88)
        Me.picPlayer1Disconnected.Name = "picPlayer1Disconnected"
        Me.picPlayer1Disconnected.Size = New System.Drawing.Size(260, 259)
        Me.picPlayer1Disconnected.TabIndex = 19
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
        Me.picPlayer4Connected.TabIndex = 18
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
        Me.picPlayer3Connected.TabIndex = 17
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
        Me.picPlayer2Connected.TabIndex = 16
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
        Me.picPlayer1Connected.TabIndex = 15
        Me.picPlayer1Connected.TabStop = False
        Me.picPlayer1Connected.Visible = False
        '
        'timP2Team
        '
        Me.timP2Team.Enabled = True
        Me.timP2Team.Interval = 200
        '
        'timP3Team
        '
        Me.timP3Team.Enabled = True
        Me.timP3Team.Interval = 200
        '
        'timP4Team
        '
        Me.timP4Team.Enabled = True
        Me.timP4Team.Interval = 200
        '
        'frmGameSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.picPlayer4Disconnected)
        Me.Controls.Add(Me.picPlayer3Disconnected)
        Me.Controls.Add(Me.picPlayer2Disconnected)
        Me.Controls.Add(Me.picPlayer1Disconnected)
        Me.Controls.Add(Me.picPlayer4Connected)
        Me.Controls.Add(Me.picPlayer3Connected)
        Me.Controls.Add(Me.picPlayer2Connected)
        Me.Controls.Add(Me.picPlayer1Connected)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.lblOlah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGameSetup"
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
    Friend WithEvents lblOlah As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents timP1Connect As System.Windows.Forms.Timer
    Friend WithEvents timP2Connect As System.Windows.Forms.Timer
    Friend WithEvents timP3Connect As System.Windows.Forms.Timer
    Friend WithEvents timP4Connect As System.Windows.Forms.Timer
    Friend WithEvents timP1Team As System.Windows.Forms.Timer
    Friend WithEvents picPlayer4Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1Disconnected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer4Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer3Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer2Connected As System.Windows.Forms.PictureBox
    Friend WithEvents picPlayer1Connected As System.Windows.Forms.PictureBox
    Friend WithEvents timP2Team As System.Windows.Forms.Timer
    Friend WithEvents timP3Team As System.Windows.Forms.Timer
    Friend WithEvents timP4Team As System.Windows.Forms.Timer
End Class
