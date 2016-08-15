Imports RoadWarriors.DataLayer

Public Class ManageAthletes
    Private Sub AddAthlete_Btn_Click(sender As Object, e As EventArgs) Handles AddAthlete_Btn.Click
        Me.Hide()
        Dim addAthlete = New AddAthleteFrm()
        addAthlete.Show()
    End Sub

    Private Sub ManageAthletes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim athleteRepository = New AthleteRepository()
        For Each athlete In athleteRepository.GetAllAthletes()
            AthleteListBox.Items.Add(athlete)
        Next
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim serchForm = New SearchForm()
        serchForm.Show()
        Me.Hide()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim form = New MainForm()
        Me.Close()
        form.Show()
    End Sub
End Class