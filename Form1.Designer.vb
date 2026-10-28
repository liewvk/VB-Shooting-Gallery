<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblTitle = New Label()
        lblInstruction = New Label()
        lblScore = New Label()
        lblTime = New Label()
        lblHits = New Label()
        lblMisses = New Label()
        picTarget = New PictureBox()
        btnStart = New Button()
        btnRestart = New Button()
        gameTimer = New Timer(components)
        targetTimer = New Timer(components)
        CType(picTarget, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(231, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(171, 28)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Shooting Gallery"
        ' 
        ' lblInstruction
        ' 
        lblInstruction.AllowDrop = True
        lblInstruction.AutoSize = True
        lblInstruction.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruction.Location = New Point(231, 74)
        lblInstruction.Name = "lblInstruction"
        lblInstruction.Size = New Size(96, 25)
        lblInstruction.TabIndex = 1
        lblInstruction.Text = "Instruction"
        ' 
        ' lblScore
        ' 
        lblScore.AllowDrop = True
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(26, 99)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(56, 25)
        lblScore.TabIndex = 1
        lblScore.Text = "Score"
        ' 
        ' lblTime
        ' 
        lblTime.AllowDrop = True
        lblTime.AutoSize = True
        lblTime.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTime.Location = New Point(26, 138)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(50, 25)
        lblTime.TabIndex = 1
        lblTime.Text = "Time"
        ' 
        ' lblHits
        ' 
        lblHits.AllowDrop = True
        lblHits.AutoSize = True
        lblHits.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHits.Location = New Point(26, 174)
        lblHits.Name = "lblHits"
        lblHits.Size = New Size(43, 25)
        lblHits.TabIndex = 1
        lblHits.Text = "Hits"
        ' 
        ' lblMisses
        ' 
        lblMisses.AllowDrop = True
        lblMisses.AutoSize = True
        lblMisses.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMisses.Location = New Point(26, 211)
        lblMisses.Name = "lblMisses"
        lblMisses.Size = New Size(65, 25)
        lblMisses.TabIndex = 1
        lblMisses.Text = "Misses"
        ' 
        ' picTarget
        ' 
        picTarget.Image = CType(resources.GetObject("picTarget.Image"), Image)
        picTarget.Location = New Point(615, 74)
        picTarget.Name = "picTarget"
        picTarget.Size = New Size(57, 45)
        picTarget.SizeMode = PictureBoxSizeMode.StretchImage
        picTarget.TabIndex = 2
        picTarget.TabStop = False
        ' 
        ' btnStart
        ' 
        btnStart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStart.Location = New Point(12, 256)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(87, 36)
        btnStart.TabIndex = 3
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnRestart
        ' 
        btnRestart.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRestart.Location = New Point(12, 310)
        btnRestart.Name = "btnRestart"
        btnRestart.Size = New Size(87, 36)
        btnRestart.TabIndex = 3
        btnRestart.Text = "Restart"
        btnRestart.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnRestart)
        Controls.Add(btnStart)
        Controls.Add(picTarget)
        Controls.Add(lblMisses)
        Controls.Add(lblHits)
        Controls.Add(lblTime)
        Controls.Add(lblScore)
        Controls.Add(lblInstruction)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        CType(picTarget, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblHits As Label
    Friend WithEvents lblMisses As Label
    Friend WithEvents picTarget As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnRestart As Button
    Friend WithEvents gameTimer As Timer
    Friend WithEvents targetTimer As Timer

End Class
