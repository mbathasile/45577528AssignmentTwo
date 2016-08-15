<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddArthleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAthleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAthleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEventToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteEventToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ManageAthletes_Btn = New System.Windows.Forms.Button()
        Me.ManageEvents_Btn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 24)
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
        Me.AddArthleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAthleteToolStripMenuItem, Me.SearchEditToolStripMenuItem, Me.DeleteAthleteToolStripMenuItem})
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
        'DeleteAthleteToolStripMenuItem
        '
        Me.DeleteAthleteToolStripMenuItem.Name = "DeleteAthleteToolStripMenuItem"
        Me.DeleteAthleteToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.DeleteAthleteToolStripMenuItem.Text = "&Delete Athlete"
        '
        'AddEventToolStripMenuItem
        '
        Me.AddEventToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEventToolStripMenuItem1, Me.EditEventToolStripMenuItem, Me.DeleteEventToolStripMenuItem})
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
        'DeleteEventToolStripMenuItem
        '
        Me.DeleteEventToolStripMenuItem.Name = "DeleteEventToolStripMenuItem"
        Me.DeleteEventToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.DeleteEventToolStripMenuItem.Text = "&Delete Event"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome To Road Warriors"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ManageAthletes_Btn
        '
        Me.ManageAthletes_Btn.Location = New System.Drawing.Point(34, 100)
        Me.ManageAthletes_Btn.Name = "ManageAthletes_Btn"
        Me.ManageAthletes_Btn.Size = New System.Drawing.Size(130, 60)
        Me.ManageAthletes_Btn.TabIndex = 3
        Me.ManageAthletes_Btn.Text = "Manage Athletes"
        Me.ManageAthletes_Btn.UseVisualStyleBackColor = True
        '
        'ManageEvents_Btn
        '
        Me.ManageEvents_Btn.Location = New System.Drawing.Point(248, 100)
        Me.ManageEvents_Btn.Name = "ManageEvents_Btn"
        Me.ManageEvents_Btn.Size = New System.Drawing.Size(130, 60)
        Me.ManageEvents_Btn.TabIndex = 4
        Me.ManageEvents_Btn.Text = "Manage Events"
        Me.ManageEvents_Btn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 226)
        Me.Controls.Add(Me.ManageEvents_Btn)
        Me.Controls.Add(Me.ManageAthletes_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Road Warriors Management System"
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddArthleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAthleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAthleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEventToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteEventToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents ManageAthletes_Btn As Button
    Friend WithEvents ManageEvents_Btn As Button
End Class
