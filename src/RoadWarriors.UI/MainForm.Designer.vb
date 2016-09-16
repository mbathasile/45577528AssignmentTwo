<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddArthleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAthleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEventToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(883, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddArthleteToolStripMenuItem, Me.AddEventToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddArthleteToolStripMenuItem
        '
        Me.AddArthleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAthleteToolStripMenuItem, Me.SearchEditToolStripMenuItem})
        Me.AddArthleteToolStripMenuItem.Name = "AddArthleteToolStripMenuItem"
        Me.AddArthleteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddArthleteToolStripMenuItem.Text = "&Manage Arthletes"
        '
        'AddAthleteToolStripMenuItem
        '
        Me.AddAthleteToolStripMenuItem.Name = "AddAthleteToolStripMenuItem"
        Me.AddAthleteToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.AddAthleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddAthleteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddAthleteToolStripMenuItem.Text = "&Add Athlete"
        '
        'SearchEditToolStripMenuItem
        '
        Me.SearchEditToolStripMenuItem.Name = "SearchEditToolStripMenuItem"
        Me.SearchEditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchEditToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.SearchEditToolStripMenuItem.Text = "&Edit Athlete"
        '
        'AddEventToolStripMenuItem
        '
        Me.AddEventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEventToolStripMenuItem1, Me.EditEventToolStripMenuItem})
        Me.AddEventToolStripMenuItem.Name = "AddEventToolStripMenuItem"
        Me.AddEventToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddEventToolStripMenuItem.Text = "&Manage Event"
        '
        'AddEventToolStripMenuItem1
        '
        Me.AddEventToolStripMenuItem1.Name = "AddEventToolStripMenuItem1"
        Me.AddEventToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddEventToolStripMenuItem1.Size = New System.Drawing.Size(202, 22)
        Me.AddEventToolStripMenuItem1.Text = "&Add Event"
        '
        'EditEventToolStripMenuItem
        '
        Me.EditEventToolStripMenuItem.Name = "EditEventToolStripMenuItem"
        Me.EditEventToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.EditEventToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.EditEventToolStripMenuItem.Text = "&Edit Event"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'MainPanel
        '
        Me.MainPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MainPanel.Location = New System.Drawing.Point(0, 27)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(883, 454)
        Me.MainPanel.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 482)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Welcome To Road Warriors"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddArthleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAthleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEventToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainPanel As Panel
End Class
