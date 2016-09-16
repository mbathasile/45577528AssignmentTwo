
Public Class MainForm
    Dim manageFrm = Nothing
    Dim addAthlete = Nothing
    Dim serchForm = Nothing
    Dim addEventForm = Nothing
    Dim searchForm = Nothing

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Public Sub FormSetup(form As Form)
        Try
            Dim child = form
            child.MdiParent = Me
            child.TopLevel = False
            child.AutoScroll = True
            MainPanel.Controls.Add(child)
            MainPanel.Controls.SetChildIndex(child, 0)
            child.Dock = DockStyle.Fill
            child.Show()
        Catch ex As Exception
            MessageBox.Show(Me, "Error:\n" + ex.Message.ToString())
        End Try
    End Sub

    Private Sub ManageAthletes_Btn_Click(sender As Object, e As EventArgs)
        MainPanel.Controls.Clear()
        If manageFrm IsNot Nothing Then
            manageFrm.close()
        End If
        FormSetup(manageFrm)
    End Sub

    Private Sub ManageEvents_Btn_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub

    Private Sub AddAthleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAthleteToolStripMenuItem.Click
        MainPanel.Controls.Clear()
        If addAthlete IsNot Nothing Then
            addAthlete.close()
        End If
        addAthlete = New AddAthleteFrm()
        FormSetup(addAthlete)
    End Sub

    Private Sub SearchEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEditToolStripMenuItem.Click
        MainPanel.Controls.Clear()
        If serchForm IsNot Nothing Then
            manageFrm.close()
        End If
        serchForm = New SearchForm()
        FormSetup(serchForm)
    End Sub

    Private Sub AddEventToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddEventToolStripMenuItem1.Click
        MainPanel.Controls.Clear()
        If addEventForm IsNot Nothing Then
            addEventForm.close()
        End If
        addEventForm = New AddEventForm()
        FormSetup(addEventForm)
    End Sub

    Private Sub EditEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEventToolStripMenuItem.Click
        MainPanel.Controls.Clear()
        If searchForm IsNot Nothing Then
            searchForm.Close()
        End If
        searchForm = New SearchEvent()
        FormSetup(searchForm)
    End Sub
End Class