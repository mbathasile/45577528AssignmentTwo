<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.MembershipNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SearchButton.Location = New System.Drawing.Point(527, 27)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(116, 34)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Search Athlete"
        Me.SearchButton.UseVisualStyleBackColor = true
        '
        'MembershipNumberTextBox
        '
        Me.MembershipNumberTextBox.Location = New System.Drawing.Point(201, 41)
        Me.MembershipNumberTextBox.Name = "MembershipNumberTextBox"
        Me.MembershipNumberTextBox.Size = New System.Drawing.Size(291, 20)
        Me.MembershipNumberTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Membership Number"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(527, 79)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(116, 23)
        Me.BackButton.TabIndex = 3
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = true
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 114)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MembershipNumberTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SearchForm"
        Me.Text = "Search Form"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents SearchButton As Button
    Friend WithEvents MembershipNumberTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackButton As Button
End Class
