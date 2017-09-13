<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrance))
        Me.pcLogo = New System.Windows.Forms.PictureBox()
        Me.pcBird = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcLogo
        '
        Me.pcLogo.Image = Global.FlappyBird.My.Resources.Resources.Flappy_Bird_Logo
        Me.pcLogo.Location = New System.Drawing.Point(29, 31)
        Me.pcLogo.Name = "pcLogo"
        Me.pcLogo.Size = New System.Drawing.Size(200, 100)
        Me.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcLogo.TabIndex = 0
        Me.pcLogo.TabStop = False
        '
        'pcBird
        '
        Me.pcBird.BackColor = System.Drawing.Color.Transparent
        Me.pcBird.Image = Global.FlappyBird.My.Resources.Resources.Flappy_Bird_FlapII
        Me.pcBird.Location = New System.Drawing.Point(235, 59)
        Me.pcBird.Name = "pcBird"
        Me.pcBird.Size = New System.Drawing.Size(52, 49)
        Me.pcBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcBird.TabIndex = 1
        Me.pcBird.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(177, 409)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CreditsToolStripMenuItem, Me.AudioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.FileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ShareToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'ShareToolStripMenuItem
        '
        Me.ShareToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.ShareToolStripMenuItem.Name = "ShareToolStripMenuItem"
        Me.ShareToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShareToolStripMenuItem.Text = "Share"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CreditsToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'AudioToolStripMenuItem
        '
        Me.AudioToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.AudioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuteToolStripMenuItem})
        Me.AudioToolStripMenuItem.Name = "AudioToolStripMenuItem"
        Me.AudioToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.AudioToolStripMenuItem.Text = "Audio"
        '
        'MuteToolStripMenuItem
        '
        Me.MuteToolStripMenuItem.BackgroundImage = Global.FlappyBird.My.Resources.Resources.Background
        Me.MuteToolStripMenuItem.Name = "MuteToolStripMenuItem"
        Me.MuteToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.MuteToolStripMenuItem.Text = "Mute"
        '
        'Entrance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(332, 490)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pcBird)
        Me.Controls.Add(Me.pcLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(348, 528)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(348, 528)
        Me.Name = "Entrance"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = " "
        CType(Me.pcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pcLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pcBird As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
