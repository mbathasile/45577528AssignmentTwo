<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAthletes
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
        Me.AddAthlete_Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AthleteListBox = New System.Windows.Forms.ListBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddAthlete_Btn
        '
        Me.AddAthlete_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAthlete_Btn.Location = New System.Drawing.Point(45, 60)
        Me.AddAthlete_Btn.Name = "AddAthlete_Btn"
        Me.AddAthlete_Btn.Size = New System.Drawing.Size(183, 38)
        Me.AddAthlete_Btn.TabIndex = 0
        Me.AddAthlete_Btn.Text = "Add Athlete"
        Me.AddAthlete_Btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(433, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Athlete Management"
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(438, 60)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(183, 38)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Edit Athlete"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AthleteListBox
        '
        Me.AthleteListBox.FormattingEnabled = True
        Me.AthleteListBox.Location = New System.Drawing.Point(45, 130)
        Me.AthleteListBox.Name = "AthleteListBox"
        Me.AthleteListBox.Size = New System.Drawing.Size(944, 342)
        Me.AthleteListBox.TabIndex = 3
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(806, 60)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(183, 38)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ManageAthletes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 495)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.AthleteListBox)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddAthlete_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAthletes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manage Athletes"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents AddAthlete_Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents AthleteListBox As ListBox
    Friend WithEvents BackButton As Button
End Class
