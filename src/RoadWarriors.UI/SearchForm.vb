Imports RoadWarriors.BusinessLogic
Imports RoadWarriors.BusinessLogic.Logic
Imports RoadWarriors.DataLayer
Imports RoadWarriors.DataLayer.Repository

Public Class SearchForm
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim athleteRepo = New AthleteRepository()
        Dim membershipValidator = New ClubMembershipNumberGenerator()

        Dim isValidMember = False

        If MembershipNumberTextBox.Text <> "" Then
        isValidMember = membershipValidator.MembershipNumberValidator(MembershipNumberTextBox.Text)
       End If

        If isValidMember Then
            Me.Hide()
            Dim editAthleteFrm = New EditForm()
            editAthleteFrm.GetValues(athleteRepo.GetAthleteBy(MembershipNumberTextBox.Text))
            editAthleteFrm.Show()
            Else
            MsgBox("Member number is not valid please enter a valid number", MsgBoxStyle.Exclamation, "Error")
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Close()
        Dim manageAthletesFrm = New ManageAthletes()
        manageAthletesFrm.Show()
    End Sub
End Class