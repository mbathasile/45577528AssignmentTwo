<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditForm
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
        Me.components = New System.ComponentModel.Container()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.MembershipNumberLabel = New System.Windows.Forms.Label()
        Me.DJoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FemaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.MaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AddNewRaceTimesBtn = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RaceTimesListBox = New System.Windows.Forms.ListBox()
        Me.RacesTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(27, 35)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(154, 34)
        Me.SaveButton.TabIndex = 21
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'MembershipNumberLabel
        '
        Me.MembershipNumberLabel.AutoSize = True
        Me.MembershipNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembershipNumberLabel.Location = New System.Drawing.Point(192, 63)
        Me.MembershipNumberLabel.Name = "MembershipNumberLabel"
        Me.MembershipNumberLabel.Size = New System.Drawing.Size(0, 18)
        Me.MembershipNumberLabel.TabIndex = 38
        '
        'DJoinedDateTimePicker
        '
        Me.DJoinedDateTimePicker.Location = New System.Drawing.Point(424, 127)
        Me.DJoinedDateTimePicker.Name = "DJoinedDateTimePicker"
        Me.DJoinedDateTimePicker.Size = New System.Drawing.Size(136, 20)
        Me.DJoinedDateTimePicker.TabIndex = 37
        '
        'BDDateTimePicker
        '
        Me.BDDateTimePicker.Location = New System.Drawing.Point(192, 126)
        Me.BDDateTimePicker.Name = "BDDateTimePicker"
        Me.BDDateTimePicker.Size = New System.Drawing.Size(133, 20)
        Me.BDDateTimePicker.TabIndex = 36
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(192, 238)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(153, 20)
        Me.FeeTextBox.TabIndex = 33
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(192, 95)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(368, 20)
        Me.FullNameTextBox.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Race Times"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 18)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Races Competed In"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(39, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 36)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Membership Fee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Date Joined"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FemaleRadioBtn)
        Me.GroupBox1.Controls.Add(Me.MaleRadioBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 58)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'FemaleRadioBtn
        '
        Me.FemaleRadioBtn.AutoSize = True
        Me.FemaleRadioBtn.Location = New System.Drawing.Point(110, 23)
        Me.FemaleRadioBtn.Name = "FemaleRadioBtn"
        Me.FemaleRadioBtn.Size = New System.Drawing.Size(75, 22)
        Me.FemaleRadioBtn.TabIndex = 1
        Me.FemaleRadioBtn.TabStop = True
        Me.FemaleRadioBtn.Text = "Female"
        Me.FemaleRadioBtn.UseVisualStyleBackColor = True
        '
        'MaleRadioBtn
        '
        Me.MaleRadioBtn.AutoSize = True
        Me.MaleRadioBtn.Location = New System.Drawing.Point(14, 23)
        Me.MaleRadioBtn.Name = "MaleRadioBtn"
        Me.MaleRadioBtn.Size = New System.Drawing.Size(58, 22)
        Me.MaleRadioBtn.TabIndex = 0
        Me.MaleRadioBtn.TabStop = True
        Me.MaleRadioBtn.Text = "Male"
        Me.MaleRadioBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Birth Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Membership Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Edit Athlete"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(27, 131)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(154, 38)
        Me.BackButton.TabIndex = 22
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AddNewRaceTimesBtn)
        Me.GroupBox2.Controls.Add(Me.BackButton)
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(379, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 187)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'AddNewRaceTimesBtn
        '
        Me.AddNewRaceTimesBtn.Location = New System.Drawing.Point(27, 84)
        Me.AddNewRaceTimesBtn.Name = "AddNewRaceTimesBtn"
        Me.AddNewRaceTimesBtn.Size = New System.Drawing.Size(154, 34)
        Me.AddNewRaceTimesBtn.TabIndex = 23
        Me.AddNewRaceTimesBtn.Text = "Add New Times"
        Me.AddNewRaceTimesBtn.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'RaceTimesListBox
        '
        Me.RaceTimesListBox.FormattingEnabled = True
        Me.RaceTimesListBox.Location = New System.Drawing.Point(192, 321)
        Me.RaceTimesListBox.Name = "RaceTimesListBox"
        Me.RaceTimesListBox.Size = New System.Drawing.Size(153, 95)
        Me.RaceTimesListBox.TabIndex = 35
        '
        'RacesTextBox
        '
        Me.RacesTextBox.Location = New System.Drawing.Point(192, 289)
        Me.RacesTextBox.Name = "RacesTextBox"
        Me.RacesTextBox.ReadOnly = True
        Me.RacesTextBox.Size = New System.Drawing.Size(153, 20)
        Me.RacesTextBox.TabIndex = 34
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MembershipNumberLabel)
        Me.Controls.Add(Me.DJoinedDateTimePicker)
        Me.Controls.Add(Me.BDDateTimePicker)
        Me.Controls.Add(Me.RaceTimesListBox)
        Me.Controls.Add(Me.RacesTextBox)
        Me.Controls.Add(Me.FeeTextBox)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditForm"
        Me.Text = "Edit Athlete Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveButton As Button
    Friend WithEvents MembershipNumberLabel As Label
    Friend WithEvents DJoinedDateTimePicker As DateTimePicker
    Friend WithEvents BDDateTimePicker As DateTimePicker
    Friend WithEvents FeeTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FemaleRadioBtn As RadioButton
    Friend WithEvents MaleRadioBtn As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents RaceTimesListBox As ListBox
    Friend WithEvents RacesTextBox As TextBox
    Friend WithEvents AddNewRaceTimesBtn As Button
End Class
