<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditEventForm_
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
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.EventDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(200, 228)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(245, 20)
        Me.DistanceTextBox.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DeleteButton)
        Me.GroupBox2.Controls.Add(Me.BackButton)
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(469, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 157)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(27, 67)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(154, 38)
        Me.DeleteButton.TabIndex = 23
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(28, 111)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(154, 38)
        Me.BackButton.TabIndex = 22
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(27, 27)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(154, 34)
        Me.SaveButton.TabIndex = 21
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'EventDateTimePicker
        '
        Me.EventDateTimePicker.Location = New System.Drawing.Point(200, 106)
        Me.EventDateTimePicker.Name = "EventDateTimePicker"
        Me.EventDateTimePicker.Size = New System.Drawing.Size(245, 20)
        Me.EventDateTimePicker.TabIndex = 50
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Location = New System.Drawing.Point(200, 190)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(245, 20)
        Me.LocationTextBox.TabIndex = 49
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(200, 150)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(245, 20)
        Me.FeeTextBox.TabIndex = 48
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(200, 66)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(451, 20)
        Me.TitleTextBox.TabIndex = 47
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(46, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 18)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Distance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 18)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 18)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Registration Fee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Event Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Event Title"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Edit Event"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditEventForm_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 292)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EventDateTimePicker)
        Me.Controls.Add(Me.LocationTextBox)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditEventForm_"
        Me.Text = "Edit Event Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents EventDateTimePicker As DateTimePicker
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents FeeTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteButton As Button
End Class
