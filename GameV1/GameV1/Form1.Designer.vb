<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UltimatePenguinSimulation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Penguin = New System.Windows.Forms.PictureBox()
        Me.Rick = New System.Windows.Forms.PictureBox()
        Me.BossMovement = New System.Windows.Forms.Timer(Me.components)
        Me.LeftWALL = New System.Windows.Forms.PictureBox()
        Me.RightWALL = New System.Windows.Forms.PictureBox()
        Me.BottomWALL = New System.Windows.Forms.PictureBox()
        Me.TopWALL = New System.Windows.Forms.PictureBox()
        Me.WIN = New System.Windows.Forms.PictureBox()
        Me.BulletMovement = New System.Windows.Forms.Timer(Me.components)
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.StarMovement = New System.Windows.Forms.Timer(Me.components)
        Me.PenguinHealth = New System.Windows.Forms.ProgressBar()
        Me.HealthDamage = New System.Windows.Forms.Timer(Me.components)
        Me.GameOver = New System.Windows.Forms.PictureBox()
        Me.BossHealth = New System.Windows.Forms.ProgressBar()
        Me.BossDamage = New System.Windows.Forms.Timer(Me.components)
        Me.Cannonball = New System.Windows.Forms.PictureBox()
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.WinScreen = New System.Windows.Forms.PictureBox()
        Me.StarThingy = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Penguin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopWALL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cannonball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Penguin
        '
        Me.Penguin.BackColor = System.Drawing.Color.Transparent
        Me.Penguin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Penguin.Image = Global.GameV1.My.Resources.Resources.ClubPenguin
        Me.Penguin.Location = New System.Drawing.Point(12, 506)
        Me.Penguin.Name = "Penguin"
        Me.Penguin.Size = New System.Drawing.Size(61, 59)
        Me.Penguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Penguin.TabIndex = 1
        Me.Penguin.TabStop = False
        '
        'Rick
        '
        Me.Rick.BackColor = System.Drawing.Color.Transparent
        Me.Rick.Image = Global.GameV1.My.Resources.Resources.RickRoll
        Me.Rick.Location = New System.Drawing.Point(868, 243)
        Me.Rick.Name = "Rick"
        Me.Rick.Size = New System.Drawing.Size(91, 115)
        Me.Rick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rick.TabIndex = 2
        Me.Rick.TabStop = False
        '
        'BossMovement
        '
        Me.BossMovement.Enabled = True
        '
        'LeftWALL
        '
        Me.LeftWALL.BackColor = System.Drawing.Color.Black
        Me.LeftWALL.Location = New System.Drawing.Point(-5, 1)
        Me.LeftWALL.Name = "LeftWALL"
        Me.LeftWALL.Size = New System.Drawing.Size(10, 606)
        Me.LeftWALL.TabIndex = 10
        Me.LeftWALL.TabStop = False
        '
        'RightWALL
        '
        Me.RightWALL.BackColor = System.Drawing.Color.Black
        Me.RightWALL.Location = New System.Drawing.Point(1001, 1)
        Me.RightWALL.Name = "RightWALL"
        Me.RightWALL.Size = New System.Drawing.Size(10, 606)
        Me.RightWALL.TabIndex = 11
        Me.RightWALL.TabStop = False
        '
        'BottomWALL
        '
        Me.BottomWALL.BackColor = System.Drawing.Color.Transparent
        Me.BottomWALL.Location = New System.Drawing.Point(-5, 571)
        Me.BottomWALL.Name = "BottomWALL"
        Me.BottomWALL.Size = New System.Drawing.Size(1016, 47)
        Me.BottomWALL.TabIndex = 12
        Me.BottomWALL.TabStop = False
        '
        'TopWALL
        '
        Me.TopWALL.BackColor = System.Drawing.Color.Black
        Me.TopWALL.Location = New System.Drawing.Point(-5, -6)
        Me.TopWALL.Name = "TopWALL"
        Me.TopWALL.Size = New System.Drawing.Size(1016, 10)
        Me.TopWALL.TabIndex = 13
        Me.TopWALL.TabStop = False
        '
        'WIN
        '
        Me.WIN.BackColor = System.Drawing.Color.Transparent
        Me.WIN.Image = Global.GameV1.My.Resources.Resources.super_star_super_mario_wiki_the_mario_encyclopedia_mario_star_png_1200_1200
        Me.WIN.Location = New System.Drawing.Point(885, 260)
        Me.WIN.Name = "WIN"
        Me.WIN.Size = New System.Drawing.Size(38, 40)
        Me.WIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WIN.TabIndex = 15
        Me.WIN.TabStop = False
        '
        'BulletMovement
        '
        Me.BulletMovement.Interval = 10
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Transparent
        Me.Bullet.Image = Global.GameV1.My.Resources.Resources.ImprovedObamaBullet
        Me.Bullet.Location = New System.Drawing.Point(113, 339)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(37, 19)
        Me.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet.TabIndex = 16
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'StarMovement
        '
        Me.StarMovement.Enabled = True
        Me.StarMovement.Interval = 1
        '
        'PenguinHealth
        '
        Me.PenguinHealth.BackColor = System.Drawing.SystemColors.Control
        Me.PenguinHealth.ForeColor = System.Drawing.Color.Lime
        Me.PenguinHealth.Location = New System.Drawing.Point(12, 12)
        Me.PenguinHealth.Maximum = 150
        Me.PenguinHealth.Name = "PenguinHealth"
        Me.PenguinHealth.Size = New System.Drawing.Size(270, 22)
        Me.PenguinHealth.Step = 3
        Me.PenguinHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PenguinHealth.TabIndex = 17
        Me.PenguinHealth.Value = 150
        '
        'HealthDamage
        '
        '
        'GameOver
        '
        Me.GameOver.Image = Global.GameV1.My.Resources.Resources._362a2ee7_69ee_4740_a213_32cfc1896c1f
        Me.GameOver.Location = New System.Drawing.Point(-5, -6)
        Me.GameOver.Name = "GameOver"
        Me.GameOver.Size = New System.Drawing.Size(1016, 624)
        Me.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameOver.TabIndex = 18
        Me.GameOver.TabStop = False
        Me.GameOver.Visible = False
        '
        'BossHealth
        '
        Me.BossHealth.BackColor = System.Drawing.SystemColors.Control
        Me.BossHealth.ForeColor = System.Drawing.Color.Red
        Me.BossHealth.Location = New System.Drawing.Point(546, 12)
        Me.BossHealth.Maximum = 500
        Me.BossHealth.Name = "BossHealth"
        Me.BossHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BossHealth.RightToLeftLayout = True
        Me.BossHealth.Size = New System.Drawing.Size(449, 22)
        Me.BossHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.BossHealth.TabIndex = 19
        Me.BossHealth.Value = 500
        '
        'BossDamage
        '
        '
        'Cannonball
        '
        Me.Cannonball.BackColor = System.Drawing.Color.Transparent
        Me.Cannonball.Image = Global.GameV1.My.Resources.Resources.cannball
        Me.Cannonball.Location = New System.Drawing.Point(880, 284)
        Me.Cannonball.Name = "Cannonball"
        Me.Cannonball.Size = New System.Drawing.Size(43, 40)
        Me.Cannonball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Cannonball.TabIndex = 20
        Me.Cannonball.TabStop = False
        '
        'Gravity
        '
        Me.Gravity.Enabled = True
        '
        'WinScreen
        '
        Me.WinScreen.Image = Global.GameV1.My.Resources.Resources.WinScreen
        Me.WinScreen.Location = New System.Drawing.Point(-5, -6)
        Me.WinScreen.Name = "WinScreen"
        Me.WinScreen.Size = New System.Drawing.Size(1016, 624)
        Me.WinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WinScreen.TabIndex = 21
        Me.WinScreen.TabStop = False
        Me.WinScreen.Visible = False
        '
        'StarThingy
        '
        Me.StarThingy.Enabled = True
        '
        'UltimatePenguinSimulation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GameV1.My.Resources.Resources.GameBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 608)
        Me.Controls.Add(Me.GameOver)
        Me.Controls.Add(Me.WinScreen)
        Me.Controls.Add(Me.Cannonball)
        Me.Controls.Add(Me.BossHealth)
        Me.Controls.Add(Me.PenguinHealth)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Rick)
        Me.Controls.Add(Me.Penguin)
        Me.Controls.Add(Me.TopWALL)
        Me.Controls.Add(Me.LeftWALL)
        Me.Controls.Add(Me.BottomWALL)
        Me.Controls.Add(Me.RightWALL)
        Me.Controls.Add(Me.WIN)
        Me.DoubleBuffered = True
        Me.Name = "UltimatePenguinSimulation"
        Me.Text = "Penguin Club"
        CType(Me.Penguin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopWALL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameOver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cannonball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Penguin As PictureBox
    Friend WithEvents Rick As PictureBox
    Friend WithEvents BossMovement As Timer
    Friend WithEvents LeftWALL As PictureBox
    Friend WithEvents RightWALL As PictureBox
    Friend WithEvents BottomWALL As PictureBox
    Friend WithEvents TopWALL As PictureBox
    Friend WithEvents WIN As PictureBox
    Friend WithEvents BulletMovement As Timer
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents StarMovement As Timer
    Friend WithEvents PenguinHealth As ProgressBar
    Friend WithEvents HealthDamage As Timer
    Friend WithEvents GameOver As PictureBox
    Friend WithEvents BossHealth As ProgressBar
    Friend WithEvents BossDamage As Timer
    Friend WithEvents Cannonball As PictureBox
    Friend WithEvents Gravity As Timer
    Friend WithEvents WinScreen As PictureBox
    Friend WithEvents StarThingy As Timer
End Class
