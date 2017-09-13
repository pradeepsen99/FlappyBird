Imports System.IO
Imports System.Text

Public Class frmFlappyBird
    Dim flap As Boolean = False
    Dim speed As Integer
    Dim Pause As Boolean = True
    Dim WallMoveSpeed As Single = 5
    Dim Dead As Boolean = False
    Public Score As Integer
    Public FileReader1 As File
    'Dim FileSaveLocation As String = "C:\Users\Public\Desktop\Leader1.txt"
    Private Sub FlappyBird_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Up Then
            flap = True
            Animation.Interval = 10
            My.Computer.Audio.Play(My.Resources.JumpSound, AudioPlayMode.Background)
        End If
        If e.KeyCode = Keys.P Then
            PauseAndPlay()
        End If
        If e.KeyCode = Keys.S And Pause = False Then
            PauseAndPlay()
        End If
    End Sub

    Private Sub FlappyBird_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Up Then
            flap = False
            Animation.Interval = 100
        End If
    End Sub

    Private Sub FlappyBird_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.CenterToScreen()
        Gravity.Start()
    End Sub

    Private Sub Gravity_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gravity.Tick
        Static Bool As Boolean = False
        Me.Text = "Flappy Bird" & "    " & Str(Score)
        bird.BringToFront()
        If flap = True And Dead = False Then
            speed -= 3
        ElseIf Bool = False Then
            speed += 1
        End If
        DeadSub()
        bird.Top += speed
        If Dead = True Then
            If bird.Bounds.IntersectsWith(pcBottom.Bounds) Then
                speed = 0
                Bool = True
            End If
            Animation.Stop()
            Static int1 As Integer = 0
            int1 += 1
            If int1 = 1 Then
                bird.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            End If

            If int1 = 40 Then
                int1 += 10
                MessageBox.Show("You Died!" & vbNewLine & "Score = " & Score, "Died", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Application.Restart()
            End If
        End If
    End Sub


    Private Sub FlappyBird_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        pcUp2.Hide()
        pcDown2.Hide()
        PipeMove1.Start()
        SpawnPipes()
        Control.CheckForIllegalCrossThreadCalls = False
        Check.RunWorkerAsync()
        Animation.Start()
    End Sub

    Private Sub Animation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Animation.Tick
        Static Counter As Integer = 1
        Select Case Counter
            Case 1
                bird.Image = My.Resources.tumblr_n0dw9jUXOD1s6294bo1_r2_5001
            Case 2
                bird.Image = My.Resources.Flappy_Bird_FlapII
        End Select
        Counter += 1
        If Counter = 3 Then
            Counter = 1
        End If
    End Sub
    Sub DeadSub()
        If Dead = True Then
            PipeMove1.Stop()
            PipeMove2.Stop()
            Animation.Stop()
            Gravity.Stop()
            If Score < My.Settings.Score Then
                'Dim str As String = Score.ToString
                'Dim name As String = InputBox("Please ENter your name!", "Name!")
                'File.WriteAllText(FileSaveLocation, str)
                'File.WriteAllText("C:\Users\Public\Desktop\Leader.txt", name)
            End If
            Application.Restart()
        End If
    End Sub

    Private Sub Check_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Check.DoWork
        Do

            Static cross As Boolean = True

            If bird.Bounds.IntersectsWith(pcBottom.Bounds) Then
                Dead = True
            End If

            If pcUp1.Bounds.IntersectsWith(pcPoint.Bounds) And cross = True Then
                My.Computer.Audio.Play(My.Resources.PointSound, AudioPlayMode.Background)
                Score += 1
                cross = False
            End If

            If pcUp2.Bounds.IntersectsWith(pcPoint.Bounds) And cross = False Then
                cross = True
                My.Computer.Audio.Play(My.Resources.PointSound, AudioPlayMode.Background)
                Score += 1
            End If


            If bird.Bounds.IntersectsWith(pcUp1.Bounds) Then
                Dead = True
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            ElseIf bird.Bounds.IntersectsWith(pcDown1.Bounds) Then
                Dead = True
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            ElseIf bird.Bounds.IntersectsWith(pcUp2.Bounds) Then
                Dead = True
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            ElseIf bird.Bounds.IntersectsWith(pcDown2.Bounds) Then
                Dead = True
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            ElseIf bird.Bounds.IntersectsWith(pcBottom.Bounds) Then
                Dead = True
                My.Computer.Audio.Play(My.Resources.DieSound, AudioPlayMode.Background)
            End If
            If bird.Bounds.IntersectsWith(top1.Bounds) Then
                bird.Location = New Point(62, -1)
                speed = 0
            End If

        Loop
    End Sub

    Sub SpawnPipes()
        Dim PipeLocationUp1, PipeLocationDown1 As New Point
        Dim rndUp1 As New Random
        Dim intUp1, intDown1 As Integer
        intUp1 = rndUp1.Next(-310, 10)
        intDown1 = intUp1 + 460
        PipeLocationUp1.X = 460
        PipeLocationUp1.Y = intUp1
        PipeLocationDown1.X = 460
        PipeLocationDown1.Y = intDown1

        pcUp1.Location = PipeLocationUp1
        pcDown1.Location = PipeLocationDown1
        PipeMove1.Start()

    End Sub


    Private Sub Move1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PipeMove1.Tick
        DeadSub()
        pcUp1.Left -= 2
        pcDown1.Left -= 2
        If pcUp1.Location.X = 230 Then
            pcDown2.Show()
            pcUp2.Show()
            Call SpawnPipes2()
        End If
        If pcDown1.Location.X = 0 Then
            Call SpawnPipes()
        End If
    End Sub

    Private Sub Move2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PipeMove2.Tick

        pcDown2.Left -= 2
        pcUp2.Left -= 2
        If pcDown2.Location.X = 0 Then
            Call SpawnPipes2()
        End If
    End Sub

    Sub SpawnPipes2()
        Dim pipeU2, pipeD2 As New Point
        Dim rndU2 As New Random
        Dim intU2, intD2 As Integer
        intU2 = rndU2.Next(-320, 1)
        intD2 = intU2 + 440
        pipeU2.X = 460
        pipeU2.Y = intU2
        pipeD2.X = 460
        pipeD2.Y = intD2

        pcUp2.Location = pipeU2
        pcDown2.Location = pipeD2
        PipeMove2.Start()
    End Sub

    Private Sub pcGameState_Click() Handles pcGameState.Click
        PauseAndPlay()
    End Sub

    Sub PauseAndPlay()
        Try
            If Pause = True Then
                pcGameState.Image = My.Resources.Play
                PipeMove1.Stop()
                PipeMove2.Stop()
                Animation.Stop()
                Gravity.Stop()
                Pause = False
                Exit Try
            ElseIf Pause = False Then
                pcGameState.Image = My.Resources.Pause
                PipeMove1.Start()
                PipeMove2.Start()
                Animation.Start()
                Gravity.Start()
                Pause = True
                Exit Try
            End If
        Catch ex As Exception
        End Try
        Me.Text = "Flappy Bird" & "    " & Str(Score)
    End Sub

    Private Sub frmFlappyBird_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
