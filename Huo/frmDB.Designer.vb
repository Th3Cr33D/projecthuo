<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDB))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picMinimize = New System.Windows.Forms.PictureBox()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(46, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, user"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Location = New System.Drawing.Point(49, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 415)
        Me.Panel1.TabIndex = 1
        '
        'picMinimize
        '
        Me.picMinimize.BackColor = System.Drawing.Color.Transparent
        Me.picMinimize.BackgroundImage = CType(resources.GetObject("picMinimize.BackgroundImage"), System.Drawing.Image)
        Me.picMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picMinimize.Location = New System.Drawing.Point(666, 2)
        Me.picMinimize.Name = "picMinimize"
        Me.picMinimize.Size = New System.Drawing.Size(35, 34)
        Me.picMinimize.TabIndex = 2
        Me.picMinimize.TabStop = False
        '
        'picExit
        '
        Me.picExit.BackColor = System.Drawing.Color.Transparent
        Me.picExit.BackgroundImage = CType(resources.GetObject("picExit.BackgroundImage"), System.Drawing.Image)
        Me.picExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picExit.Location = New System.Drawing.Point(701, 1)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(35, 35)
        Me.picExit.TabIndex = 3
        Me.picExit.TabStop = False
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.BackgroundImage = CType(resources.GetObject("picLogo.BackgroundImage"), System.Drawing.Image)
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picLogo.Location = New System.Drawing.Point(1, 7)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(46, 38)
        Me.picLogo.TabIndex = 4
        Me.picLogo.TabStop = False
        '
        'frmDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(738, 467)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.picExit)
        Me.Controls.Add(Me.picMinimize)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents picExit As System.Windows.Forms.PictureBox
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Me.Close()
    End Sub

    Private Sub picExit_MouseEnter(sender As Object, e As EventArgs) Handles picExit.MouseEnter
        picExit.BackColor = Color.Silver
    End Sub

    Private Sub picExit_MouseLeave(sender As Object, e As EventArgs) Handles picExit.MouseLeave
        picExit.BackColor = Color.Transparent
    End Sub

    Private Sub picMinimize_MouseEnter(sender As Object, e As EventArgs) Handles picMinimize.MouseEnter
        picMinimize.BackColor = Color.Silver
    End Sub

    Private Sub picMinimize_MouseLeave(sender As Object, e As EventArgs) Handles picMinimize.MouseLeave
        picMinimize.BackColor = Color.Transparent
    End Sub
End Class
