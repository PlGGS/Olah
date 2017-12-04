<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.lblOlah = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnTimeLimit = New System.Windows.Forms.Button()
        Me.txtTimeLimit = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOlah
        '
        Me.lblOlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOlah.Font = New System.Drawing.Font("Halo", 69.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblOlah.Image = CType(resources.GetObject("lblOlah.Image"), System.Drawing.Image)
        Me.lblOlah.Location = New System.Drawing.Point(0, 0)
        Me.lblOlah.Name = "lblOlah"
        Me.lblOlah.Size = New System.Drawing.Size(1370, 768)
        Me.lblOlah.TabIndex = 4
        Me.lblOlah.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Options"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBack.Location = New System.Drawing.Point(158, 331)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(498, 43)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnTimeLimit
        '
        Me.btnTimeLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTimeLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeLimit.Font = New System.Drawing.Font("Halo", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeLimit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTimeLimit.Location = New System.Drawing.Point(158, 269)
        Me.btnTimeLimit.Name = "btnTimeLimit"
        Me.btnTimeLimit.Size = New System.Drawing.Size(457, 43)
        Me.btnTimeLimit.TabIndex = 8
        Me.btnTimeLimit.Text = "Time (Mins) 1 - 10"
        Me.btnTimeLimit.UseVisualStyleBackColor = False
        '
        'txtTimeLimit
        '
        Me.txtTimeLimit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTimeLimit.Font = New System.Drawing.Font("Halo", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeLimit.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtTimeLimit.Location = New System.Drawing.Point(612, 269)
        Me.txtTimeLimit.Name = "txtTimeLimit"
        Me.txtTimeLimit.Size = New System.Drawing.Size(44, 44)
        Me.txtTimeLimit.TabIndex = 11
        Me.txtTimeLimit.Text = "3"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.txtTimeLimit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTimeLimit)
        Me.Controls.Add(Me.lblOlah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Olah"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOlah As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnTimeLimit As System.Windows.Forms.Button
    Friend WithEvents txtTimeLimit As System.Windows.Forms.TextBox
End Class
