<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMidship
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMidship))
        Me.lblOlah = New System.Windows.Forms.Label()
        Me.timController1 = New System.Windows.Forms.Timer(Me.components)
        Me.timController2 = New System.Windows.Forms.Timer(Me.components)
        Me.timController3 = New System.Windows.Forms.Timer(Me.components)
        Me.timController4 = New System.Windows.Forms.Timer(Me.components)
        Me.picBotLeft = New System.Windows.Forms.PictureBox()
        Me.picBotRight = New System.Windows.Forms.PictureBox()
        Me.picTopLeft = New System.Windows.Forms.PictureBox()
        Me.picTopRight = New System.Windows.Forms.PictureBox()
        Me.picBottom = New System.Windows.Forms.PictureBox()
        Me.picBotSBlocker = New System.Windows.Forms.PictureBox()
        Me.picMidRight = New System.Windows.Forms.PictureBox()
        Me.picMidLeft = New System.Windows.Forms.PictureBox()
        Me.picTopSBlocker = New System.Windows.Forms.PictureBox()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.picSpawnTopLeft = New System.Windows.Forms.PictureBox()
        Me.picSpawnTopRight = New System.Windows.Forms.PictureBox()
        Me.timCollision = New System.Windows.Forms.Timer(Me.components)
        Me.timGrav = New System.Windows.Forms.Timer(Me.components)
        Me.timCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.picSpawnBotLeft = New System.Windows.Forms.PictureBox()
        Me.picSpawnBotRight = New System.Windows.Forms.PictureBox()
        Me.timShootP1 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP2 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP3 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP4 = New System.Windows.Forms.Timer(Me.components)
        Me.picP1Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP2Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP3Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP4Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP1Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP2Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP3Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP4Shot2 = New System.Windows.Forms.PictureBox()
        Me.lblP1Name = New System.Windows.Forms.Label()
        Me.picP1HealthLow = New System.Windows.Forms.PictureBox()
        Me.picP1HealthMed = New System.Windows.Forms.PictureBox()
        Me.picP1HealthHigh = New System.Windows.Forms.PictureBox()
        Me.lblP2Name = New System.Windows.Forms.Label()
        Me.lblP3Name = New System.Windows.Forms.Label()
        Me.lblP4Name = New System.Windows.Forms.Label()
        Me.picP2HealthLow = New System.Windows.Forms.PictureBox()
        Me.picP2HealthMed = New System.Windows.Forms.PictureBox()
        Me.picP2HealthHigh = New System.Windows.Forms.PictureBox()
        Me.picP3HealthHigh = New System.Windows.Forms.PictureBox()
        Me.picP3HealthMed = New System.Windows.Forms.PictureBox()
        Me.picP3HealthLow = New System.Windows.Forms.PictureBox()
        Me.picP4HealthHigh = New System.Windows.Forms.PictureBox()
        Me.picP4HealthMed = New System.Windows.Forms.PictureBox()
        Me.picP4HealthLow = New System.Windows.Forms.PictureBox()
        Me.timGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.timDeath = New System.Windows.Forms.Timer(Me.components)
        Me.lblP1Kills = New System.Windows.Forms.Label()
        Me.lblP2Kills = New System.Windows.Forms.Label()
        Me.lblP3Kills = New System.Windows.Forms.Label()
        Me.lblP4Kills = New System.Windows.Forms.Label()
        Me.lblP1Deaths = New System.Windows.Forms.Label()
        Me.lblP2Deaths = New System.Windows.Forms.Label()
        Me.lblP3Deaths = New System.Windows.Forms.Label()
        Me.lblP4Deaths = New System.Windows.Forms.Label()
        CType(Me.picBotLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBotRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBotSBlocker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMidRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMidLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopSBlocker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnBotLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnBotRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1HealthLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1HealthMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1HealthHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2HealthLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2HealthMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2HealthHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3HealthHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3HealthMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3HealthLow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4HealthHigh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4HealthMed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4HealthLow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOlah
        '
        Me.lblOlah.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblOlah.Font = New System.Drawing.Font("Halo", 200.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOlah.Location = New System.Drawing.Point(-2, 0)
        Me.lblOlah.Name = "lblOlah"
        Me.lblOlah.Size = New System.Drawing.Size(1370, 768)
        Me.lblOlah.TabIndex = 4
        Me.lblOlah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timController1
        '
        Me.timController1.Enabled = True
        Me.timController1.Interval = 20
        '
        'timController2
        '
        Me.timController2.Enabled = True
        Me.timController2.Interval = 20
        '
        'timController3
        '
        Me.timController3.Enabled = True
        Me.timController3.Interval = 20
        '
        'timController4
        '
        Me.timController4.Enabled = True
        Me.timController4.Interval = 20
        '
        'picBotLeft
        '
        Me.picBotLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotLeft.Location = New System.Drawing.Point(220, 607)
        Me.picBotLeft.Name = "picBotLeft"
        Me.picBotLeft.Size = New System.Drawing.Size(180, 25)
        Me.picBotLeft.TabIndex = 20
        Me.picBotLeft.TabStop = False
        '
        'picBotRight
        '
        Me.picBotRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotRight.Location = New System.Drawing.Point(970, 607)
        Me.picBotRight.Name = "picBotRight"
        Me.picBotRight.Size = New System.Drawing.Size(180, 25)
        Me.picBotRight.TabIndex = 19
        Me.picBotRight.TabStop = False
        '
        'picTopLeft
        '
        Me.picTopLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopLeft.Location = New System.Drawing.Point(220, 247)
        Me.picTopLeft.Name = "picTopLeft"
        Me.picTopLeft.Size = New System.Drawing.Size(180, 25)
        Me.picTopLeft.TabIndex = 15
        Me.picTopLeft.TabStop = False
        '
        'picTopRight
        '
        Me.picTopRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopRight.Location = New System.Drawing.Point(970, 247)
        Me.picTopRight.Name = "picTopRight"
        Me.picTopRight.Size = New System.Drawing.Size(180, 25)
        Me.picTopRight.TabIndex = 13
        Me.picTopRight.TabStop = False
        '
        'picBottom
        '
        Me.picBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBottom.Location = New System.Drawing.Point(0, 727)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(1368, 26)
        Me.picBottom.TabIndex = 10
        Me.picBottom.TabStop = False
        '
        'picBotSBlocker
        '
        Me.picBotSBlocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotSBlocker.Location = New System.Drawing.Point(517, 517)
        Me.picBotSBlocker.Name = "picBotSBlocker"
        Me.picBotSBlocker.Size = New System.Drawing.Size(324, 76)
        Me.picBotSBlocker.TabIndex = 9
        Me.picBotSBlocker.TabStop = False
        '
        'picMidRight
        '
        Me.picMidRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picMidRight.Location = New System.Drawing.Point(788, 367)
        Me.picMidRight.Name = "picMidRight"
        Me.picMidRight.Size = New System.Drawing.Size(180, 25)
        Me.picMidRight.TabIndex = 8
        Me.picMidRight.TabStop = False
        '
        'picMidLeft
        '
        Me.picMidLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picMidLeft.Location = New System.Drawing.Point(400, 367)
        Me.picMidLeft.Name = "picMidLeft"
        Me.picMidLeft.Size = New System.Drawing.Size(180, 25)
        Me.picMidLeft.TabIndex = 7
        Me.picMidLeft.TabStop = False
        '
        'picTopSBlocker
        '
        Me.picTopSBlocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopSBlocker.Location = New System.Drawing.Point(594, 0)
        Me.picTopSBlocker.Name = "picTopSBlocker"
        Me.picTopSBlocker.Size = New System.Drawing.Size(180, 214)
        Me.picTopSBlocker.TabIndex = 5
        Me.picTopSBlocker.TabStop = False
        '
        'lblCountdown
        '
        Me.lblCountdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblCountdown.Font = New System.Drawing.Font("Halo", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.Navy
        Me.lblCountdown.Location = New System.Drawing.Point(594, 250)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(180, 111)
        Me.lblCountdown.TabIndex = 29
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCountdown.Visible = False
        '
        'picSpawnTopLeft
        '
        Me.picSpawnTopLeft.BackColor = System.Drawing.Color.Red
        Me.picSpawnTopLeft.Location = New System.Drawing.Point(268, 170)
        Me.picSpawnTopLeft.Name = "picSpawnTopLeft"
        Me.picSpawnTopLeft.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnTopLeft.TabIndex = 30
        Me.picSpawnTopLeft.TabStop = False
        '
        'picSpawnTopRight
        '
        Me.picSpawnTopRight.BackColor = System.Drawing.Color.Red
        Me.picSpawnTopRight.Location = New System.Drawing.Point(1021, 170)
        Me.picSpawnTopRight.Name = "picSpawnTopRight"
        Me.picSpawnTopRight.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnTopRight.TabIndex = 31
        Me.picSpawnTopRight.TabStop = False
        '
        'timCollision
        '
        Me.timCollision.Enabled = True
        Me.timCollision.Interval = 1
        '
        'timGrav
        '
        Me.timGrav.Enabled = True
        Me.timGrav.Interval = 30
        '
        'timCountdown
        '
        Me.timCountdown.Enabled = True
        Me.timCountdown.Interval = 1000
        '
        'picSpawnBotLeft
        '
        Me.picSpawnBotLeft.BackColor = System.Drawing.Color.Red
        Me.picSpawnBotLeft.Location = New System.Drawing.Point(268, 530)
        Me.picSpawnBotLeft.Name = "picSpawnBotLeft"
        Me.picSpawnBotLeft.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnBotLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnBotLeft.TabIndex = 32
        Me.picSpawnBotLeft.TabStop = False
        '
        'picSpawnBotRight
        '
        Me.picSpawnBotRight.BackColor = System.Drawing.Color.Red
        Me.picSpawnBotRight.Location = New System.Drawing.Point(1021, 530)
        Me.picSpawnBotRight.Name = "picSpawnBotRight"
        Me.picSpawnBotRight.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnBotRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnBotRight.TabIndex = 33
        Me.picSpawnBotRight.TabStop = False
        '
        'timShootP1
        '
        Me.timShootP1.Enabled = True
        Me.timShootP1.Interval = 1
        '
        'timShootP2
        '
        Me.timShootP2.Enabled = True
        Me.timShootP2.Interval = 1
        '
        'timShootP3
        '
        Me.timShootP3.Enabled = True
        Me.timShootP3.Interval = 1
        '
        'timShootP4
        '
        Me.timShootP4.Enabled = True
        Me.timShootP4.Interval = 1
        '
        'picP1Shot1
        '
        Me.picP1Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP1Shot1.Location = New System.Drawing.Point(603, 12)
        Me.picP1Shot1.Name = "picP1Shot1"
        Me.picP1Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP1Shot1.TabIndex = 34
        Me.picP1Shot1.TabStop = False
        Me.picP1Shot1.Visible = False
        '
        'picP2Shot1
        '
        Me.picP2Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP2Shot1.Location = New System.Drawing.Point(643, 12)
        Me.picP2Shot1.Name = "picP2Shot1"
        Me.picP2Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP2Shot1.TabIndex = 35
        Me.picP2Shot1.TabStop = False
        Me.picP2Shot1.Visible = False
        '
        'picP3Shot1
        '
        Me.picP3Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP3Shot1.Location = New System.Drawing.Point(690, 12)
        Me.picP3Shot1.Name = "picP3Shot1"
        Me.picP3Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP3Shot1.TabIndex = 36
        Me.picP3Shot1.TabStop = False
        Me.picP3Shot1.Visible = False
        '
        'picP4Shot1
        '
        Me.picP4Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP4Shot1.Location = New System.Drawing.Point(740, 12)
        Me.picP4Shot1.Name = "picP4Shot1"
        Me.picP4Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP4Shot1.TabIndex = 37
        Me.picP4Shot1.TabStop = False
        Me.picP4Shot1.Visible = False
        '
        'picP1Shot2
        '
        Me.picP1Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP1Shot2.Location = New System.Drawing.Point(603, 45)
        Me.picP1Shot2.Name = "picP1Shot2"
        Me.picP1Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP1Shot2.TabIndex = 38
        Me.picP1Shot2.TabStop = False
        Me.picP1Shot2.Visible = False
        '
        'picP2Shot2
        '
        Me.picP2Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP2Shot2.Location = New System.Drawing.Point(643, 45)
        Me.picP2Shot2.Name = "picP2Shot2"
        Me.picP2Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP2Shot2.TabIndex = 39
        Me.picP2Shot2.TabStop = False
        Me.picP2Shot2.Visible = False
        '
        'picP3Shot2
        '
        Me.picP3Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP3Shot2.Location = New System.Drawing.Point(690, 45)
        Me.picP3Shot2.Name = "picP3Shot2"
        Me.picP3Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP3Shot2.TabIndex = 40
        Me.picP3Shot2.TabStop = False
        Me.picP3Shot2.Visible = False
        '
        'picP4Shot2
        '
        Me.picP4Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP4Shot2.Location = New System.Drawing.Point(740, 45)
        Me.picP4Shot2.Name = "picP4Shot2"
        Me.picP4Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP4Shot2.TabIndex = 41
        Me.picP4Shot2.TabStop = False
        Me.picP4Shot2.Visible = False
        '
        'lblP1Name
        '
        Me.lblP1Name.AutoSize = True
        Me.lblP1Name.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP1Name.Location = New System.Drawing.Point(12, 9)
        Me.lblP1Name.Name = "lblP1Name"
        Me.lblP1Name.Size = New System.Drawing.Size(166, 23)
        Me.lblP1Name.TabIndex = 42
        Me.lblP1Name.Text = "Player 1"
        '
        'picP1HealthLow
        '
        Me.picP1HealthLow.BackColor = System.Drawing.Color.Blue
        Me.picP1HealthLow.Location = New System.Drawing.Point(16, 35)
        Me.picP1HealthLow.Name = "picP1HealthLow"
        Me.picP1HealthLow.Size = New System.Drawing.Size(45, 20)
        Me.picP1HealthLow.TabIndex = 43
        Me.picP1HealthLow.TabStop = False
        Me.picP1HealthLow.Visible = False
        '
        'picP1HealthMed
        '
        Me.picP1HealthMed.BackColor = System.Drawing.Color.Blue
        Me.picP1HealthMed.Location = New System.Drawing.Point(67, 35)
        Me.picP1HealthMed.Name = "picP1HealthMed"
        Me.picP1HealthMed.Size = New System.Drawing.Size(45, 20)
        Me.picP1HealthMed.TabIndex = 44
        Me.picP1HealthMed.TabStop = False
        Me.picP1HealthMed.Visible = False
        '
        'picP1HealthHigh
        '
        Me.picP1HealthHigh.BackColor = System.Drawing.Color.Blue
        Me.picP1HealthHigh.Location = New System.Drawing.Point(118, 35)
        Me.picP1HealthHigh.Name = "picP1HealthHigh"
        Me.picP1HealthHigh.Size = New System.Drawing.Size(45, 20)
        Me.picP1HealthHigh.TabIndex = 45
        Me.picP1HealthHigh.TabStop = False
        Me.picP1HealthHigh.Visible = False
        '
        'lblP2Name
        '
        Me.lblP2Name.AutoSize = True
        Me.lblP2Name.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP2Name.Location = New System.Drawing.Point(293, 9)
        Me.lblP2Name.Name = "lblP2Name"
        Me.lblP2Name.Size = New System.Drawing.Size(182, 23)
        Me.lblP2Name.TabIndex = 46
        Me.lblP2Name.Text = "Player 2"
        '
        'lblP3Name
        '
        Me.lblP3Name.AutoSize = True
        Me.lblP3Name.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP3Name.Location = New System.Drawing.Point(890, 9)
        Me.lblP3Name.Name = "lblP3Name"
        Me.lblP3Name.Size = New System.Drawing.Size(182, 23)
        Me.lblP3Name.TabIndex = 47
        Me.lblP3Name.Text = "Player 3"
        '
        'lblP4Name
        '
        Me.lblP4Name.AutoSize = True
        Me.lblP4Name.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP4Name.Location = New System.Drawing.Point(1172, 9)
        Me.lblP4Name.Name = "lblP4Name"
        Me.lblP4Name.Size = New System.Drawing.Size(180, 23)
        Me.lblP4Name.TabIndex = 48
        Me.lblP4Name.Text = "Player 4"
        '
        'picP2HealthLow
        '
        Me.picP2HealthLow.BackColor = System.Drawing.Color.Blue
        Me.picP2HealthLow.Location = New System.Drawing.Point(312, 35)
        Me.picP2HealthLow.Name = "picP2HealthLow"
        Me.picP2HealthLow.Size = New System.Drawing.Size(45, 20)
        Me.picP2HealthLow.TabIndex = 49
        Me.picP2HealthLow.TabStop = False
        Me.picP2HealthLow.Visible = False
        '
        'picP2HealthMed
        '
        Me.picP2HealthMed.BackColor = System.Drawing.Color.Blue
        Me.picP2HealthMed.Location = New System.Drawing.Point(363, 35)
        Me.picP2HealthMed.Name = "picP2HealthMed"
        Me.picP2HealthMed.Size = New System.Drawing.Size(45, 20)
        Me.picP2HealthMed.TabIndex = 50
        Me.picP2HealthMed.TabStop = False
        Me.picP2HealthMed.Visible = False
        '
        'picP2HealthHigh
        '
        Me.picP2HealthHigh.BackColor = System.Drawing.Color.Blue
        Me.picP2HealthHigh.Location = New System.Drawing.Point(414, 35)
        Me.picP2HealthHigh.Name = "picP2HealthHigh"
        Me.picP2HealthHigh.Size = New System.Drawing.Size(45, 20)
        Me.picP2HealthHigh.TabIndex = 51
        Me.picP2HealthHigh.TabStop = False
        Me.picP2HealthHigh.Visible = False
        '
        'picP3HealthHigh
        '
        Me.picP3HealthHigh.BackColor = System.Drawing.Color.Blue
        Me.picP3HealthHigh.Location = New System.Drawing.Point(1005, 35)
        Me.picP3HealthHigh.Name = "picP3HealthHigh"
        Me.picP3HealthHigh.Size = New System.Drawing.Size(45, 20)
        Me.picP3HealthHigh.TabIndex = 52
        Me.picP3HealthHigh.TabStop = False
        Me.picP3HealthHigh.Visible = False
        '
        'picP3HealthMed
        '
        Me.picP3HealthMed.BackColor = System.Drawing.Color.Blue
        Me.picP3HealthMed.Location = New System.Drawing.Point(954, 35)
        Me.picP3HealthMed.Name = "picP3HealthMed"
        Me.picP3HealthMed.Size = New System.Drawing.Size(45, 20)
        Me.picP3HealthMed.TabIndex = 53
        Me.picP3HealthMed.TabStop = False
        Me.picP3HealthMed.Visible = False
        '
        'picP3HealthLow
        '
        Me.picP3HealthLow.BackColor = System.Drawing.Color.Blue
        Me.picP3HealthLow.Location = New System.Drawing.Point(903, 35)
        Me.picP3HealthLow.Name = "picP3HealthLow"
        Me.picP3HealthLow.Size = New System.Drawing.Size(45, 20)
        Me.picP3HealthLow.TabIndex = 54
        Me.picP3HealthLow.TabStop = False
        Me.picP3HealthLow.Visible = False
        '
        'picP4HealthHigh
        '
        Me.picP4HealthHigh.BackColor = System.Drawing.Color.Blue
        Me.picP4HealthHigh.Location = New System.Drawing.Point(1288, 35)
        Me.picP4HealthHigh.Name = "picP4HealthHigh"
        Me.picP4HealthHigh.Size = New System.Drawing.Size(45, 20)
        Me.picP4HealthHigh.TabIndex = 55
        Me.picP4HealthHigh.TabStop = False
        Me.picP4HealthHigh.Visible = False
        '
        'picP4HealthMed
        '
        Me.picP4HealthMed.BackColor = System.Drawing.Color.Blue
        Me.picP4HealthMed.Location = New System.Drawing.Point(1237, 35)
        Me.picP4HealthMed.Name = "picP4HealthMed"
        Me.picP4HealthMed.Size = New System.Drawing.Size(45, 20)
        Me.picP4HealthMed.TabIndex = 56
        Me.picP4HealthMed.TabStop = False
        Me.picP4HealthMed.Visible = False
        '
        'picP4HealthLow
        '
        Me.picP4HealthLow.BackColor = System.Drawing.Color.Blue
        Me.picP4HealthLow.Location = New System.Drawing.Point(1186, 35)
        Me.picP4HealthLow.Name = "picP4HealthLow"
        Me.picP4HealthLow.Size = New System.Drawing.Size(45, 20)
        Me.picP4HealthLow.TabIndex = 57
        Me.picP4HealthLow.TabStop = False
        Me.picP4HealthLow.Visible = False
        '
        'timGameTime
        '
        Me.timGameTime.Interval = 60000
        '
        'timDeath
        '
        Me.timDeath.Enabled = True
        Me.timDeath.Interval = 50
        '
        'lblP1Kills
        '
        Me.lblP1Kills.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Kills.Location = New System.Drawing.Point(16, 35)
        Me.lblP1Kills.Name = "lblP1Kills"
        Me.lblP1Kills.Size = New System.Drawing.Size(147, 23)
        Me.lblP1Kills.TabIndex = 58
        Me.lblP1Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP2Kills
        '
        Me.lblP2Kills.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Kills.Location = New System.Drawing.Point(312, 32)
        Me.lblP2Kills.Name = "lblP2Kills"
        Me.lblP2Kills.Size = New System.Drawing.Size(147, 23)
        Me.lblP2Kills.TabIndex = 59
        Me.lblP2Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP3Kills
        '
        Me.lblP3Kills.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Kills.Location = New System.Drawing.Point(903, 32)
        Me.lblP3Kills.Name = "lblP3Kills"
        Me.lblP3Kills.Size = New System.Drawing.Size(147, 23)
        Me.lblP3Kills.TabIndex = 60
        Me.lblP3Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP4Kills
        '
        Me.lblP4Kills.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Kills.Location = New System.Drawing.Point(1186, 32)
        Me.lblP4Kills.Name = "lblP4Kills"
        Me.lblP4Kills.Size = New System.Drawing.Size(147, 23)
        Me.lblP4Kills.TabIndex = 61
        Me.lblP4Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP1Deaths
        '
        Me.lblP1Deaths.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP1Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Deaths.Location = New System.Drawing.Point(16, 58)
        Me.lblP1Deaths.Name = "lblP1Deaths"
        Me.lblP1Deaths.Size = New System.Drawing.Size(150, 23)
        Me.lblP1Deaths.TabIndex = 62
        Me.lblP1Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP2Deaths
        '
        Me.lblP2Deaths.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP2Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Deaths.Location = New System.Drawing.Point(312, 58)
        Me.lblP2Deaths.Name = "lblP2Deaths"
        Me.lblP2Deaths.Size = New System.Drawing.Size(150, 23)
        Me.lblP2Deaths.TabIndex = 63
        Me.lblP2Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP3Deaths
        '
        Me.lblP3Deaths.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP3Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Deaths.Location = New System.Drawing.Point(903, 55)
        Me.lblP3Deaths.Name = "lblP3Deaths"
        Me.lblP3Deaths.Size = New System.Drawing.Size(150, 23)
        Me.lblP3Deaths.TabIndex = 64
        Me.lblP3Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP4Deaths
        '
        Me.lblP4Deaths.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblP4Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Deaths.Location = New System.Drawing.Point(1186, 55)
        Me.lblP4Deaths.Name = "lblP4Deaths"
        Me.lblP4Deaths.Size = New System.Drawing.Size(150, 23)
        Me.lblP4Deaths.TabIndex = 65
        Me.lblP4Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMidship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.lblP4Deaths)
        Me.Controls.Add(Me.lblP3Deaths)
        Me.Controls.Add(Me.lblP2Deaths)
        Me.Controls.Add(Me.lblP1Deaths)
        Me.Controls.Add(Me.lblP4Kills)
        Me.Controls.Add(Me.lblP3Kills)
        Me.Controls.Add(Me.lblP2Kills)
        Me.Controls.Add(Me.lblP1Kills)
        Me.Controls.Add(Me.picP4HealthLow)
        Me.Controls.Add(Me.picP4HealthMed)
        Me.Controls.Add(Me.picP4HealthHigh)
        Me.Controls.Add(Me.picP3HealthLow)
        Me.Controls.Add(Me.picP3HealthMed)
        Me.Controls.Add(Me.picP3HealthHigh)
        Me.Controls.Add(Me.picP2HealthHigh)
        Me.Controls.Add(Me.picP2HealthMed)
        Me.Controls.Add(Me.picP2HealthLow)
        Me.Controls.Add(Me.lblP4Name)
        Me.Controls.Add(Me.lblP3Name)
        Me.Controls.Add(Me.lblP2Name)
        Me.Controls.Add(Me.picP1HealthHigh)
        Me.Controls.Add(Me.picP1HealthMed)
        Me.Controls.Add(Me.picP1HealthLow)
        Me.Controls.Add(Me.lblP1Name)
        Me.Controls.Add(Me.picP4Shot2)
        Me.Controls.Add(Me.picP3Shot2)
        Me.Controls.Add(Me.picP2Shot2)
        Me.Controls.Add(Me.picP1Shot2)
        Me.Controls.Add(Me.picP4Shot1)
        Me.Controls.Add(Me.picP3Shot1)
        Me.Controls.Add(Me.picP2Shot1)
        Me.Controls.Add(Me.picP1Shot1)
        Me.Controls.Add(Me.picSpawnBotRight)
        Me.Controls.Add(Me.picSpawnBotLeft)
        Me.Controls.Add(Me.picSpawnTopRight)
        Me.Controls.Add(Me.picSpawnTopLeft)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.picBotLeft)
        Me.Controls.Add(Me.picBotRight)
        Me.Controls.Add(Me.picTopLeft)
        Me.Controls.Add(Me.picTopRight)
        Me.Controls.Add(Me.picBottom)
        Me.Controls.Add(Me.picBotSBlocker)
        Me.Controls.Add(Me.picMidRight)
        Me.Controls.Add(Me.picMidLeft)
        Me.Controls.Add(Me.picTopSBlocker)
        Me.Controls.Add(Me.lblOlah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMidship"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Olah"
        CType(Me.picBotLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBotRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBotSBlocker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMidRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMidLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopSBlocker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnBotLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnBotRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1HealthLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1HealthMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1HealthHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2HealthLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2HealthMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2HealthHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3HealthHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3HealthMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3HealthLow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4HealthHigh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4HealthMed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4HealthLow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOlah As System.Windows.Forms.Label
    Friend WithEvents picTopSBlocker As System.Windows.Forms.PictureBox
    Friend WithEvents picMidLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picMidRight As System.Windows.Forms.PictureBox
    Friend WithEvents picBotSBlocker As System.Windows.Forms.PictureBox
    Friend WithEvents picBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picTopRight As System.Windows.Forms.PictureBox
    Friend WithEvents picTopLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picBotRight As System.Windows.Forms.PictureBox
    Friend WithEvents picBotLeft As System.Windows.Forms.PictureBox
    Friend WithEvents timController1 As System.Windows.Forms.Timer
    Friend WithEvents timController2 As System.Windows.Forms.Timer
    Friend WithEvents timController3 As System.Windows.Forms.Timer
    Friend WithEvents timController4 As System.Windows.Forms.Timer
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents picSpawnTopLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picSpawnTopRight As System.Windows.Forms.PictureBox
    Friend WithEvents timCollision As System.Windows.Forms.Timer
    Friend WithEvents timGrav As System.Windows.Forms.Timer
    Friend WithEvents timCountdown As System.Windows.Forms.Timer
    Friend WithEvents picSpawnBotLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picSpawnBotRight As System.Windows.Forms.PictureBox
    Friend WithEvents timShootP1 As System.Windows.Forms.Timer
    Friend WithEvents timShootP2 As System.Windows.Forms.Timer
    Friend WithEvents timShootP3 As System.Windows.Forms.Timer
    Friend WithEvents timShootP4 As System.Windows.Forms.Timer
    Friend WithEvents picP1Shot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picP2Shot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picP3Shot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picP4Shot1 As System.Windows.Forms.PictureBox
    Friend WithEvents picP1Shot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picP2Shot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picP3Shot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picP4Shot2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblP1Name As System.Windows.Forms.Label
    Friend WithEvents picP1HealthLow As System.Windows.Forms.PictureBox
    Friend WithEvents picP1HealthMed As System.Windows.Forms.PictureBox
    Friend WithEvents picP1HealthHigh As System.Windows.Forms.PictureBox
    Friend WithEvents lblP2Name As System.Windows.Forms.Label
    Friend WithEvents lblP3Name As System.Windows.Forms.Label
    Friend WithEvents lblP4Name As System.Windows.Forms.Label
    Friend WithEvents picP2HealthLow As System.Windows.Forms.PictureBox
    Friend WithEvents picP2HealthMed As System.Windows.Forms.PictureBox
    Friend WithEvents picP2HealthHigh As System.Windows.Forms.PictureBox
    Friend WithEvents picP3HealthHigh As System.Windows.Forms.PictureBox
    Friend WithEvents picP3HealthMed As System.Windows.Forms.PictureBox
    Friend WithEvents picP3HealthLow As System.Windows.Forms.PictureBox
    Friend WithEvents picP4HealthHigh As System.Windows.Forms.PictureBox
    Friend WithEvents picP4HealthMed As System.Windows.Forms.PictureBox
    Friend WithEvents picP4HealthLow As System.Windows.Forms.PictureBox
    Friend WithEvents timGameTime As System.Windows.Forms.Timer
    Friend WithEvents timDeath As System.Windows.Forms.Timer
    Friend WithEvents lblP1Kills As System.Windows.Forms.Label
    Friend WithEvents lblP2Kills As System.Windows.Forms.Label
    Friend WithEvents lblP3Kills As System.Windows.Forms.Label
    Friend WithEvents lblP4Kills As System.Windows.Forms.Label
    Friend WithEvents lblP1Deaths As System.Windows.Forms.Label
    Friend WithEvents lblP2Deaths As System.Windows.Forms.Label
    Friend WithEvents lblP3Deaths As System.Windows.Forms.Label
    Friend WithEvents lblP4Deaths As System.Windows.Forms.Label
End Class
