<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageEvents
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
        Me.EventsListBox = New System.Windows.Forms.ListBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddEvent_Btn = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EventsListBox
        '
        Me.EventsListBox.FormattingEnabled = True
        Me.EventsListBox.Location = New System.Drawing.Point(50, 144)
        Me.EventsListBox.Name = "EventsListBox"
        Me.EventsListBox.Size = New System.Drawing.Size(944, 342)
        Me.EventsListBox.TabIndex = 7
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(440, 74)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(183, 38)
        Me.EditButton.TabIndex = 6
        Me.EditButton.Text = "Edit Event"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(435, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Event Management"
        '
        'AddEvent_Btn
        '
        Me.AddEvent_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEvent_Btn.Location = New System.Drawing.Point(50, 74)
        Me.AddEvent_Btn.Name = "AddEvent_Btn"
        Me.AddEvent_Btn.Size = New System.Drawing.Size(183, 38)
        Me.AddEvent_Btn.TabIndex = 4
        Me.AddEvent_Btn.Text = "Add Event"
        Me.AddEvent_Btn.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(811, 74)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(183, 38)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ManageEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1078, 547)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.EventsListBox)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddEvent_Btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Events"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EventsListBox As ListBox
    Friend WithEvents EditButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AddEvent_Btn As Button
    Friend WithEvents BackButton As Button
End Class
