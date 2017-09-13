<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlappyBird
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlappyBird))
        Me.Gravity = New System.Windows.Forms.Timer(Me.components)
        Me.Animation = New System.Windows.Forms.Timer(Me.components)
        Me.PipeMove1 = New System.Windows.Forms.Timer(Me.components)
        Me.PipeMove2 = New System.Windows.Forms.Timer(Me.components)
        Me.pcDown1 = New System.Windows.Forms.PictureBox()
        Me.EndOfWall2 = New System.Windows.Forms.PictureBox()
        Me.WallSpace2 = New System.Windows.Forms.PictureBox()
        Me.MainWall2 = New System.Windows.Forms.PictureBox()
        Me.pcUp1 = New System.Windows.Forms.PictureBox()
        Me.bird = New System.Windows.Forms.PictureBox()
        Me.pcBottom = New System.Windows.Forms.PictureBox()
        Me.pcUp2 = New System.Windows.Forms.PictureBox()
        Me.pcDown2 = New System.Windows.Forms.PictureBox()
        Me.pcPoint = New System.Windows.Forms.PictureBox()
        Me.pcGameState = New System.Windows.Forms.PictureBox()
        Me.top1 = New System.Windows.Forms.PictureBox()
        Me.Check = New System.ComponentModel.BackgroundWorker()
        CType(Me.pcDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndOfWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WallSpace2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcUp1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcUp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcGameState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.top1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gravity
        '
        Me.Gravity.Interval = 25
        '
        'Animation
        '
        '
        'PipeMove1
        '
        Me.PipeMove1.Interval = 1
        '
        'PipeMove2
        '
        Me.PipeMove2.Interval = 1
        '
        'pcDown1
        '
        Me.pcDown1.BackColor = System.Drawing.Color.Transparent
        Me.pcDown1.Image = Global.FlappyBird.My.Resources.Resources.WallTop
        Me.pcDown1.Location = New System.Drawing.Point(557, 51)
        Me.pcDown1.Name = "pcDown1"
        Me.pcDown1.Size = New System.Drawing.Size(52, 330)
        Me.pcDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcDown1.TabIndex = 6
        Me.pcDown1.TabStop = False
        '
        'EndOfWall2
        '
        Me.EndOfWall2.Location = New System.Drawing.Point(956, 0)
        Me.EndOfWall2.Name = "EndOfWall2"
        Me.EndOfWall2.Size = New System.Drawing.Size(10, 604)
        Me.EndOfWall2.TabIndex = 3
        Me.EndOfWall2.TabStop = False
        Me.EndOfWall2.Visible = False
        '
        'WallSpace2
        '
        Me.WallSpace2.Location = New System.Drawing.Point(854, 316)
        Me.WallSpace2.Name = "WallSpace2"
        Me.WallSpace2.Size = New System.Drawing.Size(100, 125)
        Me.WallSpace2.TabIndex = 2
        Me.WallSpace2.TabStop = False
        '
        'MainWall2
        '
        Me.MainWall2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MainWall2.Location = New System.Drawing.Point(854, 0)
        Me.MainWall2.Name = "MainWall2"
        Me.MainWall2.Size = New System.Drawing.Size(100, 602)
        Me.MainWall2.TabIndex = 1
        Me.MainWall2.TabStop = False
        Me.MainWall2.Visible = False
        '
        'pcUp1
        '
        Me.pcUp1.BackColor = System.Drawing.Color.Transparent
        Me.pcUp1.Image = Global.FlappyBird.My.Resources.Resources.WallBottom
        Me.pcUp1.Location = New System.Drawing.Point(557, 1)
        Me.pcUp1.Name = "pcUp1"
        Me.pcUp1.Size = New System.Drawing.Size(52, 330)
        Me.pcUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcUp1.TabIndex = 1
        Me.pcUp1.TabStop = False
        '
        'bird
        '
        Me.bird.BackColor = System.Drawing.Color.Transparent
        Me.bird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bird.Image = Global.FlappyBird.My.Resources.Resources.Flappy_Bird_FlapII
        Me.bird.Location = New System.Drawing.Point(62, 204)
        Me.bird.Name = "bird"
        Me.bird.Size = New System.Drawing.Size(44, 38)
        Me.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bird.TabIndex = 0
        Me.bird.TabStop = False
        '
        'pcBottom
        '
        Me.pcBottom.BackColor = System.Drawing.Color.White
        Me.pcBottom.Image = Global.FlappyBird.My.Resources.Resources.Floor
        Me.pcBottom.Location = New System.Drawing.Point(1, 444)
        Me.pcBottom.Name = "pcBottom"
        Me.pcBottom.Size = New System.Drawing.Size(374, 57)
        Me.pcBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcBottom.TabIndex = 7
        Me.pcBottom.TabStop = False
        '
        'pcUp2
        '
        Me.pcUp2.BackColor = System.Drawing.Color.Transparent
        Me.pcUp2.Image = Global.FlappyBird.My.Resources.Resources.WallBottom
        Me.pcUp2.Location = New System.Drawing.Point(651, 1)
        Me.pcUp2.Name = "pcUp2"
        Me.pcUp2.Size = New System.Drawing.Size(52, 330)
        Me.pcUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcUp2.TabIndex = 1
        Me.pcUp2.TabStop = False
        '
        'pcDown2
        '
        Me.pcDown2.BackColor = System.Drawing.Color.Transparent
        Me.pcDown2.Image = Global.FlappyBird.My.Resources.Resources.WallTop
        Me.pcDown2.Location = New System.Drawing.Point(651, 51)
        Me.pcDown2.Name = "pcDown2"
        Me.pcDown2.Size = New System.Drawing.Size(52, 330)
        Me.pcDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcDown2.TabIndex = 6
        Me.pcDown2.TabStop = False
        '
        'pcPoint
        '
        Me.pcPoint.BackColor = System.Drawing.Color.Transparent
        Me.pcPoint.Location = New System.Drawing.Point(96, 0)
        Me.pcPoint.Name = "pcPoint"
        Me.pcPoint.Size = New System.Drawing.Size(10, 483)
        Me.pcPoint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcPoint.TabIndex = 8
        Me.pcPoint.TabStop = False
        '
        'pcGameState
        '
        Me.pcGameState.Image = Global.FlappyBird.My.Resources.Resources.Pause
        Me.pcGameState.Location = New System.Drawing.Point(3, 2)
        Me.pcGameState.Name = "pcGameState"
        Me.pcGameState.Size = New System.Drawing.Size(34, 35)
        Me.pcGameState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcGameState.TabIndex = 10
        Me.pcGameState.TabStop = False
        '
        'top1
        '
        Me.top1.Location = New System.Drawing.Point(-3, -137)
        Me.top1.Name = "top1"
        Me.top1.Size = New System.Drawing.Size(378, 131)
        Me.top1.TabIndex = 11
        Me.top1.TabStop = False
        '
        'Check
        '
        '
        'frmFlappyBird
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(374, 499)
        Me.Controls.Add(Me.top1)
        Me.Controls.Add(Me.pcGameState)
        Me.Controls.Add(Me.pcBottom)
        Me.Controls.Add(Me.pcDown2)
        Me.Controls.Add(Me.pcDown1)
        Me.Controls.Add(Me.EndOfWall2)
        Me.Controls.Add(Me.WallSpace2)
        Me.Controls.Add(Me.pcUp2)
        Me.Controls.Add(Me.MainWall2)
        Me.Controls.Add(Me.pcUp1)
        Me.Controls.Add(Me.bird)
        Me.Controls.Add(Me.pcPoint)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFlappyBird"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FlappyBird"
        CType(Me.pcDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndOfWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WallSpace2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcUp1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcUp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcPoint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcGameState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.top1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gravity As System.Windows.Forms.Timer
    Friend WithEvents bird As System.Windows.Forms.PictureBox
    Friend WithEvents pcUp1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainWall2 As System.Windows.Forms.PictureBox
    Friend WithEvents WallSpace2 As System.Windows.Forms.PictureBox
    Friend WithEvents EndOfWall2 As System.Windows.Forms.PictureBox
    Friend WithEvents Animation As System.Windows.Forms.Timer
    Friend WithEvents pcDown1 As System.Windows.Forms.PictureBox
    Friend WithEvents PipeMove1 As System.Windows.Forms.Timer
    Friend WithEvents PipeMove2 As System.Windows.Forms.Timer
    Friend WithEvents pcBottom As System.Windows.Forms.PictureBox
    Friend WithEvents pcUp2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcDown2 As System.Windows.Forms.PictureBox
    Friend WithEvents pcPoint As System.Windows.Forms.PictureBox
    Friend WithEvents pcGameState As System.Windows.Forms.PictureBox
    Friend WithEvents top1 As System.Windows.Forms.PictureBox
    Friend WithEvents Check As System.ComponentModel.BackgroundWorker

End Class
