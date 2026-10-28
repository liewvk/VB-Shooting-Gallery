Public Class Form1
    Dim rnd As New Random()
    Dim score As Integer = 0
    Dim hits As Integer = 0
    Dim misses As Integer = 0
    Dim timeRemaining As Integer = 30
    Dim bestScore As Integer = 0
    Dim gameStarted As Boolean = False
    Dim gameOver As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Shooting Gallery Game"
        lblInstruction.Text = "Click the target as quickly as you can."

        lblScore.Text = "Score: 0"
        lblHits.Text = "Hits: 0"
        lblMisses.Text = "Misses: 0"
        lblTime.Text = "Time: 30"

        picTarget.Visible = False
    End Sub

    Private Sub StartGame()
        score = 0
        hits = 0
        misses = 0
        timeRemaining = 30

        gameStarted = True
        gameOver = False

        lblScore.Text = "Score: 0"
        lblHits.Text = "Hits: 0"
        lblMisses.Text = "Misses: 0"
        lblTime.Text = "Time: 30"

        picTarget.Visible = True
        MoveTarget()

        gameTimer.Interval = 1000
        targetTimer.Interval = 1200

        gameTimer.Start()
        targetTimer.Start()
    End Sub

    Private Sub MoveTarget()
        picTarget.Left = rnd.Next(0, Me.ClientSize.Width - picTarget.Width)
        picTarget.Top = rnd.Next(80, Me.ClientSize.Height - picTarget.Height)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartGame()
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        StartGame()
    End Sub

    Private Sub picTarget_Click(sender As Object, e As EventArgs) Handles picTarget.Click
        If Not gameStarted OrElse gameOver Then Exit Sub

        score += 10
        hits += 1

        lblScore.Text = "Score: " & score.ToString()
        lblHits.Text = "Hits: " & hits.ToString()

        MoveTarget()
    End Sub

    Private Sub targetTimer_Tick(sender As Object, e As EventArgs) Handles targetTimer.Tick
        If Not gameStarted OrElse gameOver Then Exit Sub

        misses += 1
        lblMisses.Text = "Misses: " & misses.ToString()

        MoveTarget()
    End Sub

    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        timeRemaining -= 1
        lblTime.Text = "Time: " & timeRemaining.ToString()

        If timeRemaining <= 0 Then
            EndGame()
        End If
    End Sub

    Private Sub EndGame()
        gameTimer.Stop()
        targetTimer.Stop()

        gameStarted = False
        gameOver = True

        picTarget.Visible = False

        If score > bestScore Then
            bestScore = score
        End If

        MessageBox.Show("Time's up! Final Score: " & score.ToString())
    End Sub

End Class
