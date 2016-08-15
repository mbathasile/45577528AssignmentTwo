<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAthleteFrm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FemaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.MaleRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.FeeTextBox = New System.Windows.Forms.TextBox()
        Me.RacesTextBox = New System.Windows.Forms.TextBox()
        Me.RaceTimesListBox = New System.Windows.Forms.ListBox()
        Me.BDDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DJoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MembershipNumberLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Add Athlete"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Membership Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Birth Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FemaleRadioBtn)
        Me.GroupBox1.Controls.Add(Me.MaleRadioBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(203, 58)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'FemaleRadioBtn
        '
        Me.FemaleRadioBtn.AutoSize = True
        Me.FemaleRadioBtn.Location = New System.Drawing.Point(111, 23)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Date Joined"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(27, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 36)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Membership Fee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 18)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Races Competed In"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Race Times"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(180, 83)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(451, 20)
        Me.FullNameTextBox.TabIndex = 13
        '
        'FeeTextBox
        '
        Me.FeeTextBox.Location = New System.Drawing.Point(180, 262)
        Me.FeeTextBox.Name = "FeeTextBox"
        Me.FeeTextBox.Size = New System.Drawing.Size(245, 20)
        Me.FeeTextBox.TabIndex = 14
        '
        'RacesTextBox
        '
        Me.RacesTextBox.Location = New System.Drawing.Point(180, 297)
        Me.RacesTextBox.Name = "RacesTextBox"
        Me.RacesTextBox.Size = New System.Drawing.Size(245, 20)
        Me.RacesTextBox.TabIndex = 15
        '
        'RaceTimesListBox
        '
        Me.RaceTimesListBox.FormattingEnabled = True
        Me.RaceTimesListBox.Location = New System.Drawing.Point(180, 329)
        Me.RaceTimesListBox.Name = "RaceTimesListBox"
        Me.RaceTimesListBox.Size = New System.Drawing.Size(245, 95)
        Me.RaceTimesListBox.TabIndex = 16
        '
        'BDDateTimePicker
        '
        Me.BDDateTimePicker.Location = New System.Drawing.Point(180, 114)
        Me.BDDateTimePicker.Name = "BDDateTimePicker"
        Me.BDDateTimePicker.Size = New System.Drawing.Size(245, 20)
        Me.BDDateTimePicker.TabIndex = 18
        '
        'DJoinedDateTimePicker
        '
        Me.DJoinedDateTimePicker.Location = New System.Drawing.Point(180, 152)
        Me.DJoinedDateTimePicker.Name = "DJoinedDateTimePicker"
        Me.DJoinedDateTimePicker.Size = New System.Drawing.Size(245, 20)
        Me.DJoinedDateTimePicker.TabIndex = 19
        '
        'MembershipNumberLabel
        '
        Me.MembershipNumberLabel.AutoSize = True
        Me.MembershipNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MembershipNumberLabel.Location = New System.Drawing.Point(180, 51)
        Me.MembershipNumberLabel.Name = "MembershipNumberLabel"
        Me.MembershipNumberLabel.Size = New System.Drawing.Size(0, 18)
        Me.MembershipNumberLabel.TabIndex = 20
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BackButton)
        Me.GroupBox2.Controls.Add(Me.SaveButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(431, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 139)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(27, 84)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(154, 38)
        Me.BackButton.TabIndex = 22
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AddAthleteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 466)
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
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddAthleteFrm"
        Me.ShowIcon = false
        Me.Text = "Add Athlete"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        CType(Me.ErrorProvider1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaleRadioBtn As RadioButton
    Friend WithEvents FemaleRadioBtn As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents FeeTextBox As TextBox
    Friend WithEvents RacesTextBox As TextBox
    Friend WithEvents RaceTimesListBox As ListBox
    Friend WithEvents BDDateTimePicker As DateTimePicker
    Friend WithEvents DJoinedDateTimePicker As DateTimePicker
    Friend WithEvents MembershipNumberLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
