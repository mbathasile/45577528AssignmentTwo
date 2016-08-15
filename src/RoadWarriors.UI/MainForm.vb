Imports RoadWarriors.BusinessLogic
Imports RoadWarriors.DataLayer

Public Class MainForm
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim f = New AthleteRepository()

        Dim athlete = New Athlete()
        athlete.BirthDate = DateTime.Today.ToString("d")

        Dim s = f.GetAthleteBy("Musa")
        Dim m = New ClubMembershipNumberGenerator()

        'MessageBox.Show("Returned value is : " & m.GetCheckDigit(athlete.BirthDate.ToString().Replace("/", "")))

        MessageBox.Show("Returned value is : " & m.GetClubMembershipNumber("19890105"))
        Dim check = m.MembershipNumberValidator("15198901050010")
        If check Then
            MessageBox.Show("Yeppy !!! Found" & check)
        Else
            MessageBox.Show("Error this number dont exist" & check)
        End If


    End Sub

    Private Sub ManageAthletes_Btn_Click(sender As Object, e As EventArgs) Handles ManageAthletes_Btn.Click
        Me.Hide()
        Dim manageFrm = New ManageAthletes()
        manageFrm.Show()
    End Sub

    Private Sub ManageEvents_Btn_Click(sender As Object, e As EventArgs) Handles ManageEvents_Btn.Click
        Me.Hide()
        Dim manageEvent = New ManageEvents()
        manageEvent.Show()
    End Sub

    Private Sub AddAthleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddAthleteToolStripMenuItem.Click
        Me.Hide()
        Dim addAthlete = New AddAthleteFrm()
        addAthlete.Show()
    End Sub

    Private Sub SearchEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEditToolStripMenuItem.Click
        Dim serchForm = New SearchForm()
        serchForm.Show()
        Me.Hide()
    End Sub

    Private Sub AddEventToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddEventToolStripMenuItem1.Click
        Dim addEventForm = New AddEventForm()
        Me.Hide()
        addEventForm.Show()
    End Sub

    Private Sub EditEventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditEventToolStripMenuItem.Click
        Dim searchForm = New SearchEvent()
        Me.Hide()
        searchForm.Show()
    End Sub
End Class