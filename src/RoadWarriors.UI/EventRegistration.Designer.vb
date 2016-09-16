<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventRegistration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EventTileComboBox = New System.Windows.Forms.ComboBox()
        Me.AthletesComboBox = New System.Windows.Forms.ComboBox()
        Me.RaceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Event Title"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Event Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Athletes"
        '
        'EventTileComboBox
        '
        Me.EventTileComboBox.FormattingEnabled = True
        Me.EventTileComboBox.Location = New System.Drawing.Point(158, 47)
        Me.EventTileComboBox.Name = "EventTileComboBox"
        Me.EventTileComboBox.Size = New System.Drawing.Size(395, 21)
        Me.EventTileComboBox.TabIndex = 8
        '
        'AthletesComboBox
        '
        Me.AthletesComboBox.FormattingEnabled = True
        Me.AthletesComboBox.Location = New System.Drawing.Point(158, 86)
        Me.AthletesComboBox.Name = "AthletesComboBox"
        Me.AthletesComboBox.Size = New System.Drawing.Size(395, 21)
        Me.AthletesComboBox.TabIndex = 9
        '
        'RaceTextBox
        '
        Me.RaceTextBox.Location = New System.Drawing.Point(158, 127)
        Me.RaceTextBox.Name = "RaceTextBox"
        Me.RaceTextBox.Size = New System.Drawing.Size(395, 20)
        Me.RaceTextBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Races Competed In"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(478, 171)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 27)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(395, 171)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 27)
        Me.BackButton.TabIndex = 13
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'EventRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 210)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RaceTextBox)
        Me.Controls.Add(Me.AthletesComboBox)
        Me.Controls.Add(Me.EventTileComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EventRegistration"
        Me.Text = "Event Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents EventTileComboBox As ComboBox
    Friend WithEvents AthletesComboBox As ComboBox
    Friend WithEvents RaceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
End Class
