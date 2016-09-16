Imports System.IO
Imports RoadWarriors.DataLayer.Repository

Public Class EditForm

    Dim membershipNumber, fullName, birthDate, dateJoined, membershipFee, racesCompetedIn, raceTimes

    Private Sub AddNewRaceTimesBtn_Click(sender As Object, e As EventArgs) Handles AddNewRaceTimesBtn.Click

    End Sub
    'under construction
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim athleteRepo = New AthleteRepository()
        Dim raceResultsRepo = New RaceResultsRepository()

        membershipNumber = MembershipNumberLabel.Text
        fullName = FullNameTextBox.Text
        birthDate = BDDateTimePicker.Value.ToString("dd/MM/yyyy")
        dateJoined = DJoinedDateTimePicker.Value.ToString("dd/MM/yyyy")
        membershipFee = FeeTextBox.Text
        
        Dim gender As String
        If MaleRadioBtn.Checked Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        Dim isValid = ValidateValues(membershipNumber, fullName)


        Dim athlete = athleteRepo.GetAthleteBy(membershipNumber)
        athleteRepo.DeleteAthlete(athlete)


        If isValid = 0 Then

            Dim data = String.Format("{0},{1},{2},{3},{4},{5},{6},{7}", membershipNumber, fullName, birthDate, dateJoined, gender, membershipFee, racesCompetedIn, raceTimes)


            'athleteRepo.Save(data)
            MsgBox("Data Was Saved Successfully", MsgBoxStyle.Information, "Success")
            Me.Close()
        End If

    End Sub

    Function ValidateValues(membershipNumber As String, fullName As String) As Integer
        Dim count = 0
        If membershipNumber = String.Empty Then
            ErrorProvider1.SetError(MembershipNumberLabel, "Please select date of birth")
            count = count + 1
        End If

        If fullName = String.Empty Then
            ErrorProvider1.SetError(FullNameTextBox, "Please enter full name")
            count = count + 1
        End If

        Return count

    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
    End Sub

    Public Sub GetValues(athlete As String)
        Dim athleteData = athlete.Split(",")

        membershipNumber = athleteData(0)
        fullName = athleteData(1)
        birthDate = (athleteData(2))
        dateJoined = (athleteData(3))

        If athleteData(4) = "Male" Then
            MaleRadioBtn.Checked = True
        Else
            FemaleRadioBtn.Checked = True
        End If

        membershipFee = athleteData(5)
        racesCompetedIn = athleteData(6)
        raceTimes = athleteData(7).ToString()
    End Sub

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MembershipNumberLabel.Text = membershipNumber
        FullNameTextBox.Text = fullName
        BDDateTimePicker.Value = DateTime.Parse(birthDate)
        FeeTextBox.Text = membershipFee
        RacesTextBox.Text = racesCompetedIn
        DJoinedDateTimePicker.Value = DateTime.Parse(dateJoined)
        Dim raceT = raceTimes.Split("][")

        For Each s In raceT
            RaceTimesListBox.Items.Add(s & "]")
        Next
    End Sub
End Class